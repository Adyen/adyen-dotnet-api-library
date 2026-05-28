using System.Linq;
using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.PaymentInstruments
{
    [TestClass]
    public class PaymentInstrumentsServiceTest
    {
        private static IHost BuildTestHost(MockDelegatingHandler mockHandler)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddPaymentInstrumentsService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        [TestMethod]
        public async Task CreatePaymentInstrumentAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaymentInstrument.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            var paymentInstrumentInfo = new PaymentInstrumentInfo
            {
                BalanceAccountId = "BA3227C223222B5CTBLR8BWJB",
                IssuingCountryCode = "NL",
                Type = PaymentInstrumentInfo.TypeEnum.BankAccount
            };

            // Act
            ICreatePaymentInstrumentApiResponse response = await service.CreatePaymentInstrumentAsync(paymentInstrumentInfo);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaymentInstrument? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("PI322LJ223222B5DJS7CD9LWL", result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/paymentInstruments", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetPaymentInstrumentAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaymentInstrument.json");
            const string paymentInstrumentId = "PI322LJ223222B5DJS7CD9LWL";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            // Act
            IGetPaymentInstrumentApiResponse response = await service.GetPaymentInstrumentAsync(paymentInstrumentId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaymentInstrument? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(paymentInstrumentId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetAllTransactionRulesForPaymentInstrumentAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRulesResponse.json");
            const string paymentInstrumentId = "PI322LJ223222B5DJS7CD9LWL";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            // Act
            IGetAllTransactionRulesForPaymentInstrumentApiResponse response =
                await service.GetAllTransactionRulesForPaymentInstrumentAsync(paymentInstrumentId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRulesResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.TransactionRules.Count);
            Assert.AreEqual("TR3227C223222C5GXR3XP596N", result.TransactionRules[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}/transactionRules", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task CreateNetworkTokenProvisioningDataAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/NetworkTokenActivationDataResponse.json");
            const string paymentInstrumentId = "PI322LJ223222B5DJS7CD9LWL";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            var activationDataRequest = new NetworkTokenActivationDataRequest();

            // Act
            ICreateNetworkTokenProvisioningDataApiResponse response =
                await service.CreateNetworkTokenProvisioningDataAsync(paymentInstrumentId, activationDataRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            NetworkTokenActivationDataResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.SdkInput);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}/networkTokenActivationData", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetNetworkTokenActivationDataAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/NetworkTokenActivationDataResponse.json");
            const string paymentInstrumentId = "PI322LJ223222B5DJS7CD9LWL";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            // Act
            IGetNetworkTokenActivationDataApiResponse response =
                await service.GetNetworkTokenActivationDataAsync(paymentInstrumentId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            NetworkTokenActivationDataResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.SdkInput);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}/networkTokenActivationData", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetPanOfPaymentInstrumentAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaymentInstrumentRevealInfo.json");
            const string paymentInstrumentId = "PI322LJ223222B5DJS7CD9LWL";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            // Act
            IGetPanOfPaymentInstrumentApiResponse response =
                await service.GetPanOfPaymentInstrumentAsync(paymentInstrumentId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaymentInstrumentRevealInfo? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("5555444411209883", result.Pan);
            Assert.AreEqual("123", result.Cvc);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}/reveal", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task ListNetworkTokensAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/ListNetworkTokensResponse.json");
            const string paymentInstrumentId = "PI32272223222B59M5TM658DT";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            // Act
            IListNetworkTokensApiResponse response = await service.ListNetworkTokensAsync(paymentInstrumentId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            ListNetworkTokensResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.NetworkTokens.Count);
            Assert.AreEqual("NT3227C223222B5GFSNSXFFL9", result.NetworkTokens[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}/networkTokens", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task RevealDataOfPaymentInstrumentAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaymentInstrumentRevealResponse.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            var revealRequest = new PaymentInstrumentRevealRequest
            {
                EncryptedKey = "dGVzdC1lbmNyeXB0ZWQta2V5",
                PaymentInstrumentId = "PI322LJ223222B5DJS7CD9LWL"
            };

            // Act
            IRevealDataOfPaymentInstrumentApiResponse response =
                await service.RevealDataOfPaymentInstrumentAsync(revealRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaymentInstrumentRevealResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.EncryptedData);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/paymentInstruments/reveal", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task UpdatePaymentInstrumentAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/UpdatePaymentInstrument.json");
            const string paymentInstrumentId = "PI3227C223222B5CMD278FKGS";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IPaymentInstrumentsService>();

            var updateRequest = new PaymentInstrumentUpdateRequest();

            // Act
            IUpdatePaymentInstrumentApiResponse response =
                await service.UpdatePaymentInstrumentAsync(paymentInstrumentId, updateRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            UpdatePaymentInstrument? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("PI3227C223222B5CMD278FKGS", result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/paymentInstruments/{paymentInstrumentId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }
    }
}

