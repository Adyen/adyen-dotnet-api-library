using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.AuthorizedCardUsers
{
    [TestClass]
    public class AuthorizedCardUsersServiceTest
    {
        public AuthorizedCardUsersServiceTest() { }

        [TestMethod]
        public async Task GetAllAuthorisedCardUsersAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/AuthorisedCardUsers-get-success.json");

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
                    services.AddAuthorizedCardUsersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var authorizedCardUsersService = testHost.Services.GetRequiredService<IAuthorizedCardUsersService>();

            // Act
            IGetAllAuthorisedCardUsersApiResponse response =
                await authorizedCardUsersService.GetAllAuthorisedCardUsersAsync("PI3227C223222B5BPCMFXD2XG");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            AuthorisedCardUsers? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.LegalEntityIds);
            Assert.AreEqual(1, result.LegalEntityIds.Count);
            Assert.AreEqual("LE1234567890", result.LegalEntityIds[0]);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/paymentInstruments/PI3227C223222B5BPCMFXD2XG/authorisedCardUsers", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task CreateAuthorisedCardUsersAsync_Returns204NoContent_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddAuthorizedCardUsersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var authorizedCardUsersService = testHost.Services.GetRequiredService<IAuthorizedCardUsersService>();
            var users = new AuthorisedCardUsers { LegalEntityIds = new List<string> { "LE1234567890" } };

            // Act
            ICreateAuthorisedCardUsersApiResponse response =
                await authorizedCardUsersService.CreateAuthorisedCardUsersAsync("PI3227C223222B5BPCMFXD2XG", users);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsNoContent);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/paymentInstruments/PI3227C223222B5BPCMFXD2XG/authorisedCardUsers", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task DeleteAuthorisedCardUsersAsync_Returns204NoContent_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddAuthorizedCardUsersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var authorizedCardUsersService = testHost.Services.GetRequiredService<IAuthorizedCardUsersService>();

            // Act
            IDeleteAuthorisedCardUsersApiResponse response =
                await authorizedCardUsersService.DeleteAuthorisedCardUsersAsync("PI3227C223222B5BPCMFXD2XG");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsNoContent);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Delete, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/paymentInstruments/PI3227C223222B5BPCMFXD2XG/authorisedCardUsers", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
