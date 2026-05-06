using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.NetworkTokens
{
    [TestClass]
    public class NetworkTokensServiceTest
    {
        public NetworkTokensServiceTest() { }

        [TestMethod]
        public async Task GetNetworkTokenAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GetNetworkTokenResponse.json");

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
                    services.AddNetworkTokensService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var networkTokensService = testHost.Services.GetRequiredService<INetworkTokensService>();

            // Act
            IGetNetworkTokenApiResponse response = await networkTokensService.GetNetworkTokenAsync("NT1234567890");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            GetNetworkTokenResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Token);
            Assert.AreEqual("NT1234567890", result.Token.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/networkTokens/NT1234567890", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task UpdateNetworkTokenAsync_Returns202Accepted_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Accepted);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddNetworkTokensService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var networkTokensService = testHost.Services.GetRequiredService<INetworkTokensService>();
            var updateRequest = new UpdateNetworkTokenRequest { Status = UpdateNetworkTokenRequest.StatusEnum.Active };

            // Act
            IUpdateNetworkTokenApiResponse response =
                await networkTokensService.UpdateNetworkTokenAsync("NT1234567890", updateRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsAccepted);
            Assert.AreEqual(HttpStatusCode.Accepted, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/networkTokens/NT1234567890", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
