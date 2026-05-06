using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.GrantAccounts
{
    [TestClass]
    public class GrantAccountsServiceTest
    {
        public GrantAccountsServiceTest() { }

        [TestMethod]
        public async Task GetGrantAccountAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GrantAccount.json");

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
                    services.AddGrantAccountsService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var grantAccountsService = testHost.Services.GetRequiredService<IGrantAccountsService>();

            // Act
            IGetGrantAccountApiResponse response = await grantAccountsService.GetGrantAccountAsync("UNIQUE_GRANT_ACCOUNT_ID");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            CapitalGrantAccount? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("UNIQUE_GRANT_ACCOUNT_ID", result.Id);
            Assert.AreEqual("BA3227C223222B5CMD3FJFKGZ", result.FundingBalanceAccountId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/grantAccounts/UNIQUE_GRANT_ACCOUNT_ID", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
