using System.Text;
using System.Text.Json;
using Adyen.Checkout.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Serialization
{
    /// <summary>
    /// Verifies that Adyen SDK models can be deserialized using a bare
    /// <see cref="JsonSerializer.Deserialize{T}(string)"/> call without supplying any
    /// <see cref="JsonSerializerOptions"/>. This works because each generated model carries a
    /// class-level <c>[JsonConverter]</c> attribute that STJ discovers automatically.
    /// </summary>
    [TestClass]
    public class BareSerializationTests
    {
        [TestMethod]
        public void Given_AmountJson_When_BareDeserialize_Then_Returns_CorrectAmount()
        {
            string json = "{\"currency\":\"EUR\",\"value\":1000}";

            var amount = JsonSerializer.Deserialize<Amount>(json);

            Assert.IsNotNull(amount);
            Assert.AreEqual("EUR", amount.Currency);
            Assert.AreEqual(1000L, amount.Value);
        }

        [TestMethod]
        public void Given_AmountObject_When_BareSerialize_Then_Returns_CorrectJson()
        {
            var amount = new Amount { Currency = "USD", Value = 500 };

            string json = JsonSerializer.Serialize(amount);

            Assert.IsNotNull(json);
            Assert.IsTrue(json.Contains("\"currency\":\"USD\""));
            Assert.IsTrue(json.Contains("\"value\":500"));
        }

        [TestMethod]
        public void Given_AmountJson_When_BareRoundTrip_Then_Returns_OriginalValues()
        {
            var original = new Amount { Currency = "GBP", Value = 750 };
            string json = JsonSerializer.Serialize(original);

            var deserialized = JsonSerializer.Deserialize<Amount>(json);

            Assert.IsNotNull(deserialized);
            Assert.AreEqual(original.Currency, deserialized.Currency);
            Assert.AreEqual(original.Value, deserialized.Value);
        }

        [TestMethod]
        public void Given_ThreeDSecureDataJson_When_BareDeserialize_Then_Returns_CorrectFields()
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
            // Only cavvAlgorithm is present; all other optional fields are absent.
            string json = "{\"cavvAlgorithm\":\"1\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            Assert.AreEqual("1", data.CavvAlgorithm);
            Assert.IsNull(data.ThreeDSVersion);
            Assert.IsNull(data.Eci);
            Assert.IsNull(data.AuthenticationResponse);
        }

        [TestMethod]
        public void Given_CavvJson_When_BareDeserialize_Then_CavvContainsBase64DecodedBytes()
        {
            // Known limitation (issue #1687): bare mode uses STJ's default base64 handler,
            // not ByteArrayConverter. "aGVsbG8=" is base64 for "hello" (5 bytes).
            // When #1687 is fixed, this test should be updated: bare mode will return
            // Encoding.UTF8.GetBytes("aGVsbG8=") instead (8 bytes).
            string json = "{\"cavv\":\"aGVsbG8=\"}";

            var data = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.IsNotNull(data);
            CollectionAssert.AreEqual(Convert.FromBase64String("aGVsbG8="), data.Cavv);
        }

        [TestMethod]
        public void Given_JsonWithNestedModel_When_BareDeserialize_Then_NestedAmountIsPopulated()
        {
            string json = "{\"amount\":{\"currency\":\"EUR\",\"value\":1000}," +
                          "\"merchantAccount\":\"TestMerchant\",\"reference\":\"ref123\"," +
                          "\"returnUrl\":\"https://example.com\"," +
                          "\"paymentMethod\":{\"type\":\"ach\"}}";

            var request = JsonSerializer.Deserialize<PaymentRequest>(json);

            Assert.IsNotNull(request);
            Assert.IsNotNull(request.Amount);
            Assert.AreEqual("EUR", request.Amount.Currency);
            Assert.AreEqual(1000L, request.Amount.Value);
        }

        [TestMethod]
        public void Given_AchDetailsJson_When_BareDeserialize_Then_AchDetailsArePopulated()
        {
            // In bare mode the TryDeserialize pattern selects the first variant whose Type is
            // non-null. AchDetails is the first variant in the converter's selection order, so
            // JSON with "type":"ach" produces a CheckoutPaymentMethod wrapping AchDetails.
            string json = "{\"type\":\"ach\",\"bankAccountNumber\":\"123456789\"}";

            var method = JsonSerializer.Deserialize<CheckoutPaymentMethod>(json);

            Assert.IsNotNull(method);
            Assert.IsNotNull(method.AchDetails);
            Assert.AreEqual("123456789", method.AchDetails.BankAccountNumber);
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
        }
    }
}
