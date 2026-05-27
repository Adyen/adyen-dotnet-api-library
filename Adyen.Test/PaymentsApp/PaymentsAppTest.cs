using Adyen.Core.Options;
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Client;
using Adyen.PaymentsApp.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.PaymentsApp
{
    [TestClass]
    public class PaymentsAppTest
    {
        private static IHost _host;
        private static JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((ctx, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = _host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
        }

        [TestMethod]
        public void Given_Deserialize_When_BoardingTokenResponseMerchant_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/boarding-token-response-merchant.json");

            // Act
            var response = JsonSerializer.Deserialize<BoardingTokenResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("install-merchant-001", response.InstallationId);
            Assert.IsNotNull(response.BoardingToken);
        }

        [TestMethod]
        public void Given_Deserialize_When_BoardingTokenResponseStore_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/boarding-token-response-store.json");

            // Act
            var response = JsonSerializer.Deserialize<BoardingTokenResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("install-store-001", response.InstallationId);
            Assert.IsNotNull(response.BoardingToken);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentsAppResponseMerchant_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/list-payments-apps-merchant.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentsAppResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.PaymentsApps);
            Assert.AreEqual(3, response.PaymentsApps.Count);
            Assert.AreEqual("install-merchant-001", response.PaymentsApps[0].InstallationId);
            Assert.AreEqual("TestMerchantAccount", response.PaymentsApps[0].MerchantAccountCode);
            Assert.AreEqual("BOARDED", response.PaymentsApps[0].Status);
            Assert.AreEqual("TestStore", response.PaymentsApps[0].MerchantStoreCode);
            Assert.AreEqual("BOARDING", response.PaymentsApps[1].Status);
            Assert.IsNull(response.PaymentsApps[1].MerchantStoreCode);
            Assert.AreEqual("REVOKED", response.PaymentsApps[2].Status);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentsAppResponseStore_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/list-payments-apps-store.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentsAppResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.PaymentsApps);
            Assert.AreEqual(2, response.PaymentsApps.Count);
            Assert.AreEqual("install-store-001", response.PaymentsApps[0].InstallationId);
            Assert.AreEqual("Store001", response.PaymentsApps[0].MerchantStoreCode);
            Assert.AreEqual("BOARDED", response.PaymentsApps[0].Status);
            Assert.AreEqual("install-store-002", response.PaymentsApps[1].InstallationId);
            Assert.AreEqual("Store002", response.PaymentsApps[1].MerchantStoreCode);
        }

        [TestMethod]
        public void Given_Deserialize_When_DefaultErrorResponseEntity_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/error-response-400.json");

            // Act
            var response = JsonSerializer.Deserialize<DefaultErrorResponseEntity>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(400, response.Status);
            Assert.AreEqual("Invalid request", response.Title);
            Assert.AreEqual("PAYMENTAPP_001", response.ErrorCode);
            Assert.AreEqual("The request is invalid.", response.Detail);
        }

        [TestMethod]
        public void Given_Serialize_When_BoardingTokenRequest_Returns_Valid_Json()
        {
            // Arrange
            var request = new BoardingTokenRequest
            {
                BoardingRequestToken = "test-boarding-token"
            };

            // Act
            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);
            var deserialized = JsonSerializer.Deserialize<BoardingTokenRequest>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(deserialized);
            Assert.AreEqual("test-boarding-token", deserialized.BoardingRequestToken);
        }
    }
}
