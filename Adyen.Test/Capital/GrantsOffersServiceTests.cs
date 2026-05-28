using System.Linq;
using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.Capital.Extensions;
using Adyen.Capital.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Capital
{
    [TestClass]
    public class GrantsOffersServiceTests
    {
        [TestMethod]
        public async Task GetAllGrantOffersAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/grant-offers-success.json");
            var accountHolderId = "AH00000000000001";

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
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddGrantOffersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var grantOffersService = testHost.Services.GetRequiredService<IGrantOffersService>();

            // Act
            var response = await grantOffersService.GetAllGrantOffersAsync(accountHolderId);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var result));
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VarGrantOffers.Count);
            Assert.AreEqual("GO00000000000000000000001", result.VarGrantOffers[0].Id);
            Assert.AreEqual("AH00000000000001", result.VarGrantOffers[0].AccountHolderId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/capital/v1/grantOffers", capturedRequest.RequestUri.AbsolutePath);
            StringAssert.Contains(capturedRequest.RequestUri.Query, $"accountHolderId={accountHolderId}");
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var values));
            Assert.AreEqual("test-api-key", values.First());
        }
    }
}
