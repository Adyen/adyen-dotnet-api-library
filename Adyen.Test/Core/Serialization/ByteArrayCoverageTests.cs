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
        public void Given_TokenAuthenticationVerificationValueJson_When_BareDeserialize_Then_ContainsUTF8EncodedBytes()
        {
            string json = "{\"tokenAuthenticationVerificationValue\":\"dGVzdA==\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("dGVzdA=="), data.TokenAuthenticationVerificationValue);
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

        #region Gap 2: Write-path parity (bare vs DI)

        [TestMethod]
        public void Given_ThreeDSecureDataWithByteArrays_When_BareAndDiSerialize_Then_OutputIsIdentical()
        {
            byte[] bytes = Encoding.UTF8.GetBytes("test-cavv-bytes");
            var model = new ThreeDSecureData
            {
                Cavv = bytes,
                TokenAuthenticationVerificationValue = bytes,
                Xid = bytes,
            };

            string bareJson = JsonSerializer.Serialize(model);
            string diJson = JsonSerializer.Serialize(model, BuildDiOptions());

            Assert.AreEqual(bareJson, diJson);
        }

        [TestMethod]
        public void Given_ThreeDSecureDataJson_When_BareAndDiDeserialize_Then_ByteArraysAreIdentical()
        {
            string json = "{\"cavv\":\"dGVzdA==\",\"tokenAuthenticationVerificationValue\":\"dGVzdA==\",\"xid\":\"dGVzdA==\"}";

            var bareResult = JsonSerializer.Deserialize<ThreeDSecureData>(json);
            var diResult = JsonSerializer.Deserialize<ThreeDSecureData>(json, BuildDiOptions());

            Assert.IsNotNull(bareResult);
            Assert.IsNotNull(diResult);
            CollectionAssert.AreEqual(bareResult.Cavv, diResult.Cavv);
            CollectionAssert.AreEqual(bareResult.TokenAuthenticationVerificationValue, diResult.TokenAuthenticationVerificationValue);
            CollectionAssert.AreEqual(bareResult.Xid, diResult.Xid);
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
