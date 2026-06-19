using System.Text.Json;
using Adyen.Management.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Serialization
{
    /// <summary>
    /// Verifies that missing required properties in a JSON response no longer throw
    /// <see cref="ArgumentException"/> during deserialization. The library is intentionally
    /// lenient here: if the Adyen API omits a field marked required in the OpenAPI spec,
    /// the corresponding property on the model will be null/default instead of crashing.
    /// </summary>
    [TestClass]
    public class RequiredPropertyDeserializationTest
    {
        [TestMethod]
        public void Given_PayPalResponseInfo_When_RequiredStringsMissing_Should_Succeed_With_Null_Properties()
        {
            // PayPalResponseInfo has two required strings: payerId and subject.
            string json = "{}";

            var result = JsonSerializer.Deserialize<PayPalResponseInfo>(json);

            Assert.IsNotNull(result);
            Assert.IsNull(result.PayerId);
            Assert.IsNull(result.Subject);
        }

        [TestMethod]
        public void Given_PayPalResponseInfo_When_AllRequiredFieldsPresent_Should_Deserialize_Correctly()
        {
            string json = "{\"payerId\":\"MERCHANT123\",\"subject\":\"merchant@example.com\",\"directCapture\":true}";

            var result = JsonSerializer.Deserialize<PayPalResponseInfo>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual("MERCHANT123", result.PayerId);
            Assert.AreEqual("merchant@example.com", result.Subject);
            Assert.AreEqual(true, result.DirectCapture);
        }

        [TestMethod]
        public void Given_AccelResponseInfo_When_RequiredEnumMissing_Should_Succeed_With_Null_ProcessingType()
        {
            // AccelResponseInfo has one required enum: processingType.
            string json = "{}";

            var result = JsonSerializer.Deserialize<AccelResponseInfo>(json);

            Assert.IsNotNull(result);
            Assert.IsNull(result.ProcessingType);
        }

        [TestMethod]
        public void Given_AccelResponseInfo_When_RequiredEnumPresent_Should_Deserialize_Correctly()
        {
            string json = "{\"processingType\":\"ecom\"}";

            var result = JsonSerializer.Deserialize<AccelResponseInfo>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(AccelResponseInfo.ProcessingTypeEnum.Ecom, result.ProcessingType);
        }

        [TestMethod]
        public void Given_PayPalResponseInfo_When_OnlyOptionalFieldPresent_Should_Succeed()
        {
            // Only the optional directCapture field is present; required fields are absent.
            string json = "{\"directCapture\":false}";

            var result = JsonSerializer.Deserialize<PayPalResponseInfo>(json);

            Assert.IsNotNull(result);
            Assert.IsNull(result.PayerId);
            Assert.IsNull(result.Subject);
            Assert.AreEqual(false, result.DirectCapture);
        }
    }
}
