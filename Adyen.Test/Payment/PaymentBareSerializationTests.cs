using System.Text;
using System.Text.Json;
using Adyen.Payment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Payment
{
    [TestClass]
    public class PaymentBareSerializationTests
    {
        [TestMethod]
        public void Given_ThreeDSecureDataJson_When_BareDeserialize_Then_Returns_CorrectStringFields()
        {
            string json = "{\"cavvAlgorithm\":\"2\",\"threeDSVersion\":\"2.1.0\",\"eci\":\"05\",\"authenticationResponse\":\"Y\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            Assert.AreEqual("2", data.CavvAlgorithm);
            Assert.AreEqual("2.1.0", data.ThreeDSVersion);
            Assert.AreEqual("05", data.Eci);
            Assert.AreEqual(ThreeDSecureData.AuthenticationResponseEnum.Y, data.AuthenticationResponse);
        }

        [TestMethod]
        public void Given_PartialJson_When_BareDeserialize_Then_AbsentOptionalFieldsAreNull()
        {
            string json = "{\"cavvAlgorithm\":\"1\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            Assert.AreEqual("1", data.CavvAlgorithm);
            Assert.IsNull(data.ThreeDSVersion);
            Assert.IsNull(data.Eci);
            Assert.IsNull(data.AuthenticationResponse);
            Assert.IsNull(data.Cavv);
            Assert.IsNull(data.Xid);
        }

        [TestMethod]
        public void Given_CavvJson_When_BareDeserialize_Then_CavvContainsUTF8EncodedBytes()
        {
            string json = "{\"cavv\":\"aGVsbG8=\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("aGVsbG8="), data.Cavv);
        }

        [TestMethod]
        public void Given_ByteArrayFields_When_BareRoundTrip_Then_ValuesPreserved()
        {
            byte[] cavvBytes = Encoding.UTF8.GetBytes("test-cavv-value");
            byte[] xidBytes = Encoding.UTF8.GetBytes("test-xid-value");
            var original = new ThreeDSecureData { Cavv = cavvBytes, Xid = xidBytes };

            string json = JsonSerializer.Serialize(original);
            var deserialized = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(deserialized);
            CollectionAssert.AreEqual(cavvBytes, deserialized.Cavv);
            CollectionAssert.AreEqual(xidBytes, deserialized.Xid);
        }

        [TestMethod]
        public void Given_ThreeDSecureDataObject_When_BareSerialize_Then_DoesNotThrow()
        {
            var data = new ThreeDSecureData
            {
                CavvAlgorithm = "1",
                ThreeDSVersion = "2.2.0",
            };

            string json = JsonSerializer.Serialize(data);

            Assert.IsNotNull(json);
            Assert.IsTrue(json.Contains("\"cavvAlgorithm\":\"1\""));
            Assert.IsTrue(json.Contains("\"threeDSVersion\":\"2.2.0\""));
        }
    }
}
