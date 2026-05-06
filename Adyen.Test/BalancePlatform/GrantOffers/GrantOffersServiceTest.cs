using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.GrantOffers
{
    [TestClass]
    public class GrantOffersServiceTest
    {
        public GrantOffersServiceTest() { }

        [TestMethod]
        public async Task GetAllAvailableGrantOffersAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GrantOffers.json");

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
                    services.AddGrantOffersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var grantOffersService = testHost.Services.GetRequiredService<IGrantOffersService>();

            // Act
            IGetAllAvailableGrantOffersApiResponse response =
                await grantOffersService.GetAllAvailableGrantOffersAsync("AH3227C223222B5CMD3FJFKGZ");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Adyen.BalancePlatform.Models.GrantOffers? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.VarGrantOffers);
            Assert.AreEqual(1, result.VarGrantOffers.Count);
            Assert.AreEqual("UNIQUE_GRANT_OFFER_ID", result.VarGrantOffers[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/grantOffers", capturedRequest.RequestUri?.AbsolutePath);
            string query = capturedRequest.RequestUri!.Query;
            Assert.IsTrue(query.Contains("accountHolderId=AH3227C223222B5CMD3FJFKGZ"),
                $"Expected 'accountHolderId=AH3227C223222B5CMD3FJFKGZ' in query, but was: {query}");
        }

        [TestMethod]
        public async Task GetGrantOfferAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GrantOffer.json");

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
                    services.AddGrantOffersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var grantOffersService = testHost.Services.GetRequiredService<IGrantOffersService>();

            // Act
            IGetGrantOfferApiResponse response = await grantOffersService.GetGrantOfferAsync("UNIQUE_GRANT_OFFER_ID");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            GrantOffer? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("UNIQUE_GRANT_OFFER_ID", result.Id);
            Assert.AreEqual("AH3227C223222B5CMD3FJFKGZ", result.AccountHolderId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/grantOffers/UNIQUE_GRANT_OFFER_ID", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
