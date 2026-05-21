using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.SessionAuthentication.Client;
using Adyen.SessionAuthentication.Extensions;
using Adyen.SessionAuthentication.Models;
using Adyen.SessionAuthentication.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.SessionAuthentication
{
    [TestClass]
    public class SessionAuthenticationServiceTest
    {
        private static AuthenticationSessionRequest BuildRequest() => new()
        {
            AllowOrigin = "https://www.your-website.com",
            Product = ProductType.Onboarding,
            Policy = new Policy
            {
                Resources = new HashSet<Resource> { new LegalEntityResource { LegalEntityId = "LE00000000000000000000001" } },
                Roles = new HashSet<string> { "createTransferInstrumentComponent", "manageTransferInstrumentComponent" },
            },
        };

        [TestMethod]
        public async Task CreateAuthenticationSessionAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string responseJson = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-response.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(responseJson, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureSessionAuthentication((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddSessionAuthenticationService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var service = testHost.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            var response = await service.CreateAuthenticationSessionAsync(BuildRequest());

            // Assert - response
            Assert.IsTrue(response.IsOk);
            Assert.IsTrue(response.TryDeserializeOkResponse(out var session));
            Assert.IsNotNull(session);
            Assert.AreEqual("11a1e60a-18b0-4dda-9258-e0ae29e1e2a3", session.Id);
            Assert.AreEqual("eyJraWQiOiJwbGF0Zm9ybWNvbGRlciI...", session.Token);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/authe/api/v1/sessions", capturedRequest.RequestUri.AbsolutePath);
        }

        [TestMethod]
        public async Task CreateAuthenticationSessionAsync_Returns400BadRequest_WhenBadRequest()
        {
            // Arrange
            string errorJson = @"{""status"":400,""errorCode"":""00_500"",""message"":""Internal Server Error"",""errorType"":""internal""}";

            var mockHandler = new MockDelegatingHandler(_ =>
                new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(errorJson, Encoding.UTF8, "application/json")
                });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureSessionAuthentication((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddSessionAuthenticationService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var service = testHost.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            var response = await service.CreateAuthenticationSessionAsync(BuildRequest());

            // Assert
            Assert.IsFalse(response.IsOk);
            Assert.IsTrue(response.IsBadRequest);
            Assert.IsTrue(response.TryDeserializeBadRequestResponse(out var error));
            Assert.IsNotNull(error);
            Assert.AreEqual(400, error.Status);
        }

        [TestMethod]
        public async Task CreateAuthenticationSessionAsync_RequestBody_ContainsCorrectFields()
        {
            // Arrange
            string? capturedBody = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedBody = request.Content != null
                    ? request.Content.ReadAsStringAsync().GetAwaiter().GetResult()
                    : null;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-response.json"),
                        Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureSessionAuthentication((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddSessionAuthenticationService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var service = testHost.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            await service.CreateAuthenticationSessionAsync(BuildRequest());

            // Assert - body content
            Assert.IsNotNull(capturedBody);
            using var json = System.Text.Json.JsonDocument.Parse(capturedBody);
            Assert.AreEqual("https://www.your-website.com", json.RootElement.GetProperty("allowOrigin").GetString());
            Assert.AreEqual("onboarding", json.RootElement.GetProperty("product").GetString());
            Assert.AreEqual("LegalEntityResource", json.RootElement.GetProperty("policy").GetProperty("resources")[0].GetProperty("type").GetString());
            Assert.AreEqual("LE00000000000000000000001", json.RootElement.GetProperty("policy").GetProperty("resources")[0].GetProperty("legalEntityId").GetString());
        }
    }
}
