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

        // Fails: nullable value-type Option<bool?> with null value throws InvalidOperationException.
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

        // Fails: nullable value-type Option<int?> with null value throws InvalidOperationException.
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
    }
}
