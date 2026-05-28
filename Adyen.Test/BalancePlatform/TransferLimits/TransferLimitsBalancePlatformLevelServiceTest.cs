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

namespace Adyen.Test.BalancePlatform.TransferLimits
{
    [TestClass]
    public class TransferLimitsBalancePlatformLevelServiceTest
    {
        private const string BalancePlatformId = "YOUR_BALANCE_PLATFORM";
        private const string TransferLimitId = "TRLI00000000000000000000000001";

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
                    services.AddTransferLimitsBalancePlatformLevelService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        [TestMethod]
        public async Task CreateTransferLimitAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimit.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransferLimitsBalancePlatformLevelService>();

            // Act
            ICreateTransferLimitApiResponse response =
                await service.CreateTransferLimitAsync(BalancePlatformId, new CreateTransferLimitRequest());

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransferLimit? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(TransferLimitId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balancePlatforms/{BalancePlatformId}/transferLimits", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetTransferLimitsAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimits.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransferLimitsBalancePlatformLevelService>();

            // Act
            IGetTransferLimitsApiResponse response = await service.GetTransferLimitsAsync(BalancePlatformId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransferLimitListResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.TransferLimits.Count);
            Assert.AreEqual(TransferLimitId, result.TransferLimits[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balancePlatforms/{BalancePlatformId}/transferLimits", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetSpecificTransferLimitAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimit.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransferLimitsBalancePlatformLevelService>();

            // Act
            IGetSpecificTransferLimitApiResponse response =
                await service.GetSpecificTransferLimitAsync(BalancePlatformId, TransferLimitId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransferLimit? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(TransferLimitId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balancePlatforms/{BalancePlatformId}/transferLimits/{TransferLimitId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task DeletePendingTransferLimitAsync_Returns204_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransferLimitsBalancePlatformLevelService>();

            // Act
            IDeletePendingTransferLimitApiResponse response =
                await service.DeletePendingTransferLimitAsync(BalancePlatformId, TransferLimitId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Delete, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balancePlatforms/{BalancePlatformId}/transferLimits/{TransferLimitId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }
    }
}
