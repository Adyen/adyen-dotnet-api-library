using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.Platform
{
    [TestClass]
    public class PlatformServiceTest
    {
        public PlatformServiceTest() { }

        [TestMethod]
        public async Task GetBalancePlatformAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalancePlatform.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPlatformService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var platformService = testHost.Services.GetRequiredService<IPlatformService>();

            // Act
            IGetBalancePlatformApiResponse response = await platformService.GetBalancePlatformAsync("YOUR_BALANCE_PLATFORM");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Adyen.BalancePlatform.Models.BalancePlatform? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task GetAllAccountHoldersUnderBalancePlatformAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedAccountHoldersResponse.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPlatformService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var platformService = testHost.Services.GetRequiredService<IPlatformService>();

            // Act
            IGetAllAccountHoldersUnderBalancePlatformApiResponse response =
                await platformService.GetAllAccountHoldersUnderBalancePlatformAsync("YOUR_BALANCE_PLATFORM");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaginatedAccountHoldersResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.AccountHolders);
            Assert.AreEqual(3, result.AccountHolders.Count);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM/accountHolders", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task GetAllTransactionRulesForBalancePlatformAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRulesResponse.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPlatformService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var platformService = testHost.Services.GetRequiredService<IPlatformService>();

            // Act
            IGetAllTransactionRulesForBalancePlatformApiResponse response =
                await platformService.GetAllTransactionRulesForBalancePlatformAsync("YOUR_BALANCE_PLATFORM");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRulesResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.TransactionRules);
            Assert.AreEqual(2, result.TransactionRules.Count);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM/transactionRules", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
