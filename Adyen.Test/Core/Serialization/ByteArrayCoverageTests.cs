using System.Text;
using System.Text.Json;
using Adyen.BinLookup.Models;
using Adyen.Checkout.Models;
using Adyen.Core.Converters;
using Adyen.Disputes.Models;
using Adyen.LegalEntityManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Serialization
{
    /// <summary>
    /// Covers the four test-coverage gaps identified in issue #1737:
    /// 1. tokenAuthenticationVerificationValue (third byte[] field on ThreeDSecureData)
    /// 2. Write-path parity (bare vs DI serialization for byte[] fields)
    /// 3. Cross-service coverage (non-Checkout/Payment models with byte[] properties)
    /// 4. Null byte[] in model context
    /// </summary>
    [TestClass]
    public class ByteArrayCoverageTests
    {
        private static JsonSerializerOptions BuildDiOptions()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new ByteArrayConverter());
            options.Converters.Add(new ThreeDSecureDataJsonConverter());
            return options;
        }

        #region Gap 1: tokenAuthenticationVerificationValue

        [TestMethod]
        public void Given_TokenAuthenticationVerificationValueJson_When_BareDeserialize_Then_ContainsBase64DecodedBytes()
        {
            // In bare mode STJ uses its built-in base64 converter for byte[], so "dGVzdA==" is
            // decoded to the bytes of "test", not the UTF-8 bytes of the base64 string itself.
            string json = "{\"tokenAuthenticationVerificationValue\":\"dGVzdA==\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            CollectionAssert.AreEqual(Convert.FromBase64String("dGVzdA=="), data.TokenAuthenticationVerificationValue);
        }

        [TestMethod]
        public void Given_AllThreeByteArrayFields_When_BareRoundTrip_Then_AllValuesPreserved()
        {
            byte[] cavvBytes = Encoding.UTF8.GetBytes("cavv-value");
            byte[] tavvBytes = Encoding.UTF8.GetBytes("tavv-value");
            byte[] xidBytes = Encoding.UTF8.GetBytes("xid-value");
            var original = new ThreeDSecureData
            {
                Cavv = cavvBytes,
                TokenAuthenticationVerificationValue = tavvBytes,
                Xid = xidBytes,
            };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(deserialized);
            CollectionAssert.AreEqual(cavvBytes, deserialized.Cavv);
            CollectionAssert.AreEqual(tavvBytes, deserialized.TokenAuthenticationVerificationValue);
            CollectionAssert.AreEqual(xidBytes, deserialized.Xid);
        }

        #endregion

        #region Gap 2: Write-path (bare vs DI)

        [TestMethod]
        public void Given_ThreeDSecureDataWithByteArrays_When_BareSerialize_Then_OutputIsBase64Encoded()
        {
            // In bare mode (no options) STJ encodes byte[] as base64.
            // UTF-8 bytes of "test-cavv-bytes" base64-encode to "dGVzdC1jYXZ2LWJ5dGVz".
            byte[] bytes = Encoding.UTF8.GetBytes("test-cavv-bytes");
            var model = new ThreeDSecureData
            {
                Cavv = bytes,
                TokenAuthenticationVerificationValue = bytes,
                Xid = bytes,
            };

            string bareJson = JsonSerializer.Serialize(model);

            using JsonDocument json = JsonDocument.Parse(bareJson);
            Assert.AreEqual("dGVzdC1jYXZ2LWJ5dGVz", json.RootElement.GetProperty("cavv").GetString());
            Assert.AreEqual("dGVzdC1jYXZ2LWJ5dGVz", json.RootElement.GetProperty("tokenAuthenticationVerificationValue").GetString());
            Assert.AreEqual("dGVzdC1jYXZ2LWJ5dGVz", json.RootElement.GetProperty("xid").GetString());
        }

        [TestMethod]
        public void Given_ThreeDSecureDataWithByteArrays_When_DiSerialize_Then_OutputIsUtf8String()
        {
            // In DI mode ByteArrayConverter is registered and writes byte[] as a UTF-8 string.
            byte[] bytes = Encoding.UTF8.GetBytes("test-cavv-bytes");
            var model = new ThreeDSecureData
            {
                Cavv = bytes,
                TokenAuthenticationVerificationValue = bytes,
                Xid = bytes,
            };

            string diJson = JsonSerializer.Serialize(model, BuildDiOptions());

            using JsonDocument json = JsonDocument.Parse(diJson);
            Assert.AreEqual("test-cavv-bytes", json.RootElement.GetProperty("cavv").GetString());
            Assert.AreEqual("test-cavv-bytes", json.RootElement.GetProperty("tokenAuthenticationVerificationValue").GetString());
            Assert.AreEqual("test-cavv-bytes", json.RootElement.GetProperty("xid").GetString());
        }

        [TestMethod]
        public void Given_ThreeDSecureDataJson_When_BareDeserialize_Then_ByteArrayContainsBase64DecodedBytes()
        {
            // In bare mode "dGVzdA==" is base64-decoded to the bytes of "test".
            string json = "{\"cavv\":\"dGVzdA==\",\"tokenAuthenticationVerificationValue\":\"dGVzdA==\",\"xid\":\"dGVzdA==\"}";

            var result = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(Convert.FromBase64String("dGVzdA=="), result.Cavv);
            CollectionAssert.AreEqual(Convert.FromBase64String("dGVzdA=="), result.TokenAuthenticationVerificationValue);
            CollectionAssert.AreEqual(Convert.FromBase64String("dGVzdA=="), result.Xid);
        }

        [TestMethod]
        public void Given_ThreeDSecureDataJson_When_DiDeserialize_Then_ByteArrayContainsUtf8Bytes()
        {
            // In DI mode ByteArrayConverter reads the JSON string as UTF-8 bytes.
            string json = "{\"cavv\":\"dGVzdA==\",\"tokenAuthenticationVerificationValue\":\"dGVzdA==\",\"xid\":\"dGVzdA==\"}";

            var result = JsonSerializer.Deserialize<ThreeDSecureData>(json, BuildDiOptions());

            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("dGVzdA=="), result.Cavv);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("dGVzdA=="), result.TokenAuthenticationVerificationValue);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("dGVzdA=="), result.Xid);
        }

        #endregion

        #region Gap 3: Cross-service coverage

        [TestMethod]
        public void Given_DefenseDocumentContent_When_BareRoundTrip_Then_ContentPreserved()
        {
            byte[] content = Encoding.UTF8.GetBytes("defense-doc-content");
            var original = new DefenseDocument
            {
                Content = content,
                ContentType = "application/pdf",
                DefenseDocumentTypeCode = "PROOF_OF_DELIVERY",
            };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<DefenseDocument>(json);

            Assert.IsNotNull(deserialized);
            CollectionAssert.AreEqual(content, deserialized.Content);
            Assert.AreEqual("application/pdf", deserialized.ContentType);
        }

        [TestMethod]
        public void Given_DSPublicKeyDetailPublicKey_When_BareRoundTrip_Then_KeyPreserved()
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes("ds-public-key-bytes");
            var original = new DSPublicKeyDetail { PublicKey = keyBytes, Brand = "visa" };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<DSPublicKeyDetail>(json);

            Assert.IsNotNull(deserialized);
            CollectionAssert.AreEqual(keyBytes, deserialized.PublicKey);
            Assert.AreEqual("visa", deserialized.Brand);
        }

        [TestMethod]
        public void Given_AttachmentContent_When_BareRoundTrip_Then_ContentPreserved()
        {
            byte[] content = Encoding.UTF8.GetBytes("attachment-content-bytes");
            var original = new Attachment { Content = content };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<Attachment>(json);

            Assert.IsNotNull(deserialized);
            CollectionAssert.AreEqual(content, deserialized.Content);
        }

        #endregion

        #region Gap 4: Null byte[] in model context

        [TestMethod]
        public void Given_ThreeDSecureDataWithNullCavv_When_BareRoundTrip_Then_NullIsPreserved()
        {
            var original = new ThreeDSecureData
            {
                CavvAlgorithm = "2",
                Cavv = null,
                TokenAuthenticationVerificationValue = null,
            };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(deserialized);
            Assert.IsNull(deserialized.Cavv);
            Assert.IsNull(deserialized.TokenAuthenticationVerificationValue);
            Assert.AreEqual("2", deserialized.CavvAlgorithm);
        }

        [TestMethod]
        public void Given_DSPublicKeyDetailWithNullPublicKey_When_BareRoundTrip_Then_NullIsPreserved()
        {
            var original = new DSPublicKeyDetail { Brand = "mc", PublicKey = null };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<DSPublicKeyDetail>(json);

            Assert.IsNotNull(deserialized);
            Assert.IsNull(deserialized.PublicKey);
            Assert.AreEqual("mc", deserialized.Brand);
        }

        #endregion
    }
}
