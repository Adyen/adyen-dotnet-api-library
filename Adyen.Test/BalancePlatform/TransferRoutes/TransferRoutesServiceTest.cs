using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.TransferRoutes
{
    [TestClass]
    public class TransferRoutesServiceTest
    {
        public TransferRoutesServiceTest() { }

        [TestMethod]
        public async Task CalculateTransferRoutesAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferRouteResponse.json");

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
                    services.AddTransferRoutesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var transferRoutesService = testHost.Services.GetRequiredService<ITransferRoutesService>();
            var request = new TransferRouteRequest
            {
                BalancePlatform = "YOUR_BALANCE_PLATFORM",
                Category = TransferRouteRequest.CategoryEnum.Bank,
                Currency = "USD"
            };

            // Act
            ICalculateTransferRoutesApiResponse response = await transferRoutesService.CalculateTransferRoutesAsync(request);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransferRouteResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.TransferRoutes);
            Assert.AreEqual(2, result.TransferRoutes.Count);
            Assert.AreEqual("USD", result.TransferRoutes[0].Currency);
            Assert.AreEqual("NL", result.TransferRoutes[0].Country);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/transferRoutes/calculate", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
