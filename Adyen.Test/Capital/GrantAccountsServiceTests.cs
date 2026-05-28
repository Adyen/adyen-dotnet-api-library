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
    public class GrantsAccountsServiceTests
    {
        [TestMethod]
        public async Task GetGrantAccountInformationAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/get-grant-account-success.json");
            var id = "GA000000011111";

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
                    services.AddGrantAccountsService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var grantAccountsService = testHost.Services.GetRequiredService<IGrantAccountsService>();

            // Act
            var response = await grantAccountsService.GetGrantAccountInformationAsync(id);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var result));
            Assert.IsNotNull(result);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual($"/capital/v1/grantAccounts/{id}", capturedRequest.RequestUri.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var values));
            Assert.AreEqual("test-api-key", values.First());
        }
    }
}
