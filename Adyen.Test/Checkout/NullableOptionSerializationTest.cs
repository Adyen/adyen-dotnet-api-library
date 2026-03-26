using System.Text.Json;
using Adyen.Checkout.Client;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class NullableOptionSerializationTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public NullableOptionSerializationTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        // Passes: nullable reference-type Option<string?> with null value serializes correctly.
        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableString_IsExplicitlyNull_Then_Serializes_Without_Error()
        {
            var request = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                countryCode: null
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(json);
            Assert.IsFalse(json.Contains("countryCode"), "Null optional string should be omitted from JSON output.");
        }

        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableBool_IsExplicitlyNull_Then_Serializes_Without_Error()
        {
            var request = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                reusable: null
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(json);
            Assert.IsFalse(json.Contains("reusable"), "Null optional bool should be omitted from JSON output.");
        }

        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableInt_IsExplicitlyNull_Then_Serializes_Without_Error()
        {
            var request = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                captureDelayHours: null
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(json);
            Assert.IsFalse(json.Contains("captureDelayHours"), "Null optional int should be omitted from JSON output.");
        }

        [TestMethod]
        public void Given_CreateCheckoutSessionRequest_When_NullableDate_IsExplicitlyNull_Then_Serializes_Without_Error()
        {
            var request = new CreateCheckoutSessionRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                returnUrl: "https://example.com",
                dateOfBirth: null
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(json);
            Assert.IsFalse(json.Contains("dateOfBirth"), "Null optional DateOnly? should be omitted from JSON output.");
        }

        [TestMethod]
        public void Given_CreateCheckoutSessionRequest_When_NullableDateTime_IsExplicitlyNull_Then_Serializes_Without_Error()
        {
            var request = new CreateCheckoutSessionRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                returnUrl: "https://example.com",
                expiresAt: null
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(json);
            Assert.IsFalse(json.Contains("expiresAt"), "Null optional DateTimeOffset? should be omitted from JSON output.");
        }

        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableBool_HasValue_Then_Serializes_Correctly()
        {
            var request = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                reusable: true
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsTrue(json.Contains("\"reusable\":true"), "Non-null optional bool should appear in JSON output.");
        }

        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableInt_HasValue_Then_Serializes_Correctly()
        {
            var request = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                captureDelayHours: 5
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsTrue(json.Contains("\"captureDelayHours\":5"), "Non-null optional int should appear in JSON output.");
        }

        [TestMethod]
        public void Given_CreateCheckoutSessionRequest_When_NullableDateTime_HasValue_Then_Serializes_Correctly()
        {
            var expiresAt = new DateTimeOffset(2026, 12, 31, 23, 59, 59, TimeSpan.Zero);
            var request = new CreateCheckoutSessionRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                returnUrl: "https://example.com",
                expiresAt: expiresAt
            );

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            Assert.IsTrue(json.Contains("expiresAt"), "Non-null optional DateTimeOffset? should appear in JSON output.");
        }

        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableBool_IsExplicitlyNull_Then_RoundTrip_Produces_No_Value()
        {
            var original = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                reusable: null
            );

            string json = JsonSerializer.Serialize(original, _jsonSerializerOptionsProvider.Options);
            var deserialized = JsonSerializer.Deserialize<PaymentLinkRequest>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(deserialized);
            Assert.IsNull(deserialized.Reusable, "Omitted null bool should deserialize back as null.");
        }

        [TestMethod]
        public void Given_PaymentLinkRequest_When_NullableBool_HasValue_Then_RoundTrip_Preserves_Value()
        {
            var original = new PaymentLinkRequest(
                amount: new Amount("EUR", 1000),
                merchantAccount: "TestMerchant",
                reference: "test-ref",
                reusable: true
            );

            string json = JsonSerializer.Serialize(original, _jsonSerializerOptionsProvider.Options);
            var deserialized = JsonSerializer.Deserialize<PaymentLinkRequest>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(deserialized);
            Assert.AreEqual(true, deserialized.Reusable);
        }
    }
}
