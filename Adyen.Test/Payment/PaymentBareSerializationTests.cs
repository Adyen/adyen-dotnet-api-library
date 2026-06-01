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
        public void Given_CavvJson_When_BareDeserialize_Then_CavvContainsBase64DecodedBytes()
        {
            // STJ default: base64-decodes the JSON string. "aGVsbG8=" decodes to "hello".
            string json = "{\"cavv\":\"aGVsbG8=\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("hello"), data.Cavv);
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
        public void Given_PaymentRequest_With_MpiData_When_BareSerialize_Then_CavvIsBase64Encoded()
        {
            byte[] cavvBytes = Convert.FromBase64String("3q2+78r+ur7erb7vyv66vv////8=");
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "YOUR_ORDER_NUMBER",
                MpiData = new ThreeDSecureData
                {
                    Cavv = cavvBytes,
                    Eci = "05",
                    DsTransID = "c4e59ceb-a382-4d6a-bc87-385d591fa09d",
                    DirectoryResponse = ThreeDSecureData.DirectoryResponseEnum.C,
                    AuthenticationResponse = ThreeDSecureData.AuthenticationResponseEnum.Y,
                    ThreeDSVersion = "2.1.0",
                },
            };

            string result = JsonSerializer.Serialize(request);

            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement mpiData = json.RootElement.GetProperty("mpiData");
            Assert.AreEqual("3q2+78r+ur7erb7vyv66vv////8=", mpiData.GetProperty("cavv").GetString());
            Assert.AreEqual("05", mpiData.GetProperty("eci").GetString());
            Assert.AreEqual("c4e59ceb-a382-4d6a-bc87-385d591fa09d", mpiData.GetProperty("dsTransID").GetString());
            Assert.AreEqual("C", mpiData.GetProperty("directoryResponse").GetString());
            Assert.AreEqual("Y", mpiData.GetProperty("authenticationResponse").GetString());
            Assert.AreEqual("2.1.0", mpiData.GetProperty("threeDSVersion").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_Json_With_MpiData_When_BareDeserialize_Then_CavvBytesAreCorrect()
        {
            string json = """
                {
                  "amount": { "currency": "EUR", "value": 1000 },
                  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
                  "reference": "YOUR_ORDER_NUMBER",
                  "mpiData": {
                    "cavv": "3q2+78r+ur7erb7vyv66vv////8=",
                    "eci": "05",
                    "dsTransID": "c4e59ceb-a382-4d6a-bc87-385d591fa09d",
                    "directoryResponse": "C",
                    "authenticationResponse": "Y",
                    "threeDSVersion": "2.1.0"
                  }
                }
                """;

            var result = JsonSerializer.Deserialize<PaymentRequest>(json);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.MpiData);
            CollectionAssert.AreEqual(Convert.FromBase64String("3q2+78r+ur7erb7vyv66vv////8="), result.MpiData.Cavv);
            Assert.AreEqual("05", result.MpiData.Eci);
            Assert.AreEqual("c4e59ceb-a382-4d6a-bc87-385d591fa09d", result.MpiData.DsTransID);
            Assert.AreEqual(ThreeDSecureData.DirectoryResponseEnum.C, result.MpiData.DirectoryResponse);
            Assert.AreEqual(ThreeDSecureData.AuthenticationResponseEnum.Y, result.MpiData.AuthenticationResponse);
            Assert.AreEqual("2.1.0", result.MpiData.ThreeDSVersion);
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
