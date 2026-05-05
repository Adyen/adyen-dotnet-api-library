using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class RecurringTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public RecurringTest()
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

        [TestMethod]
        public void Given_ListStoredPaymentMethodsResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/get-storedPaymentMethod-success.json");
            
            // Act
            ListStoredPaymentMethodsResponse result = JsonSerializer.Deserialize<ListStoredPaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("merchantAccount", result.MerchantAccount);
            Assert.AreEqual("string", result.ShopperReference);
            Assert.IsNotNull(result.StoredPaymentMethods);
            Assert.AreEqual(1, result.StoredPaymentMethods.Count);
            Assert.AreEqual("string", result.StoredPaymentMethods[0].Id);
            Assert.AreEqual("string", result.StoredPaymentMethods[0].Brand);
            Assert.AreEqual("string", result.StoredPaymentMethods[0].HolderName);
            Assert.AreEqual("string", result.StoredPaymentMethods[0].LastFour);
        }

        [TestMethod]
        public void Given_ListStoredPaymentMethodsResponse_With_StoredPaymentMethods_When_Deserialized_Then_Result_Contains_Multiple()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-storedpaymentmethods.json");
            
            // Act
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.StoredPaymentMethods);
            Assert.AreEqual(4, result.StoredPaymentMethods.Count);
            Assert.AreEqual("8416148729107853", result.StoredPaymentMethods[1].Id);
            Assert.AreEqual("visa", result.StoredPaymentMethods[1].Brand);
            Assert.AreEqual("03", result.StoredPaymentMethods[1].ExpiryMonth);
            Assert.AreEqual("2030", result.StoredPaymentMethods[1].ExpiryYear);
            Assert.AreEqual("1111", result.StoredPaymentMethods[1].LastFour);
        }

        [TestMethod]
        public void Given_CheckoutForwardResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/forward-success.json");
            
            // Act
            CheckoutForwardResponse result = JsonSerializer.Deserialize<CheckoutForwardResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("8815658961765250", result.PspReference);
            Assert.AreEqual("PAYMENT_METHOD_ID", result.StoredPaymentMethodId);
            Assert.IsNotNull(result.Response);
            Assert.AreEqual(200, result.Response.Status);
        }

        [TestMethod]
        public void Given_StoredPaymentMethodRequest_When_Serialized_Then_Contains_Required_Fields()
        {
            // Arrange
            var request = new StoredPaymentMethodRequest
            {
                MerchantAccount = "TestMerchant",
                ShopperReference = "shopper-123",
                PaymentMethod = new PaymentMethodToStore
                {
                    Type = "scheme",
                    EncryptedCardNumber = "test_4111111111111111",
                    EncryptedExpiryMonth = "test_03",
                    EncryptedExpiryYear = "test_2030",
                    EncryptedSecurityCode = "test_737",
                    HolderName = "John Smith"
                },
                RecurringProcessingModel = StoredPaymentMethodRequest.RecurringProcessingModelEnum.Subscription,
            };

            // Act
            string serialized = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("TestMerchant", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("shopper-123", jsonDoc.RootElement.GetProperty("shopperReference").GetString());
            Assert.AreEqual("Subscription", jsonDoc.RootElement.GetProperty("recurringProcessingModel").GetString());
            Assert.IsTrue(jsonDoc.RootElement.TryGetProperty("paymentMethod", out _));
        }

        [TestMethod]
        public void Given_StoredPaymentMethodRequest_When_Optional_Fields_Not_Set_Then_Not_Serialized()
        {
            // Arrange
            var request = new StoredPaymentMethodRequest
            {
                MerchantAccount = "TestMerchant",
                ShopperReference = "shopper-123",
                PaymentMethod = new PaymentMethodToStore
                {
                    Type = "scheme",
                },
                RecurringProcessingModel = StoredPaymentMethodRequest.RecurringProcessingModelEnum.CardOnFile,
            };

            // Act
            string serialized = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("shopperEmail", out _));
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("shopperIP", out _));
        }

        [TestMethod]
        public void Given_IRecurringService_When_Test_Url_Returns_Correct_Endpoint()
        {
            // Arrange
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });

                    services.AddRecurringService();
                })
                .Build();

            // Act
            var recurringService = testHost.Services.GetRequiredService<IRecurringService>();

            // Assert
            Assert.AreEqual("https://checkout-test.adyen.com/v71", recurringService.HttpClient.BaseAddress.ToString());
        }

        [TestMethod]
        public void Given_IRecurringService_When_Live_Url_And_Prefix_Set_Returns_Correct_Live_Endpoint()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "your-live-api-key";
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });

                    services.AddRecurringService();
                })
                .Build();

            // Act
            var recurringService = liveHost.Services.GetRequiredService<IRecurringService>();

            // Assert
            Assert.AreEqual("https://prefix-checkout-live.adyenpayments.com/checkout/v71", recurringService.HttpClient.BaseAddress.ToString());
        }
    }
}
