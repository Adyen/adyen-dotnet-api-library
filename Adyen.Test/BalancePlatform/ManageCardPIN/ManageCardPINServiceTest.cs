using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.ManageCardPIN
{
    [TestClass]
    public class ManageCardPINServiceTest
    {
        public ManageCardPINServiceTest() { }

        [TestMethod]
        public async Task ChangeCardPinAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PinChangeResponse.json");

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
                    services.AddManageCardPINService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageCardPINService = testHost.Services.GetRequiredService<IManageCardPINService>();
            var pinChangeRequest = new PinChangeRequest
            {
                PaymentInstrumentId = "PI6789678967896789",
                EncryptedKey = "75989E8881284D10153ABACF022EEA09F5...",
                EncryptedPinBlock = "63E5060591EF65F48DD1D4FECD0FECD5",
                Token = "5555341244441115"
            };

            // Act
            IChangeCardPinApiResponse response = await manageCardPINService.ChangeCardPinAsync(pinChangeRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PinChangeResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(PinChangeResponse.StatusEnum.Completed, result.Status);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/pins/change", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task RevealCardPinAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/RevealPinResponse.json");

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
                    services.AddManageCardPINService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageCardPINService = testHost.Services.GetRequiredService<IManageCardPINService>();
            var revealPinRequest = new RevealPinRequest
            {
                PaymentInstrumentId = "PI3227C223222B5BPCMFXD2XG",
                EncryptedKey = "75989E8881284D10153ABACF022EEA09F5..."
            };

            // Act
            IRevealCardPinApiResponse response = await manageCardPINService.RevealCardPinAsync(revealPinRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            RevealPinResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("63E5060591EF65F48DD1D4FECD0FECD5", result.EncryptedPinBlock);
            Assert.AreEqual("5555341244441115", result.Token);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/pins/reveal", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task PublicKeyAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PublicKeyResponse.json");

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
                    services.AddManageCardPINService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageCardPINService = testHost.Services.GetRequiredService<IManageCardPINService>();

            // Act
            IPublicKeyApiResponse response = await manageCardPINService.PublicKeyAsync(
                purpose: new Option<string>("pinReveal"),
                format: new Option<string>("pem"));

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PublicKeyResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.PublicKey);
            Assert.AreEqual("2027-06-30", result.PublicKeyExpiryDate);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/publicKey", capturedRequest.RequestUri?.AbsolutePath);

            // Assert - query string parameters
            string query = capturedRequest.RequestUri!.Query;
            Assert.IsTrue(query.Contains("purpose=pinReveal"), $"Expected 'purpose=pinReveal' in query, but was: {query}");
            Assert.IsTrue(query.Contains("format=pem"), $"Expected 'format=pem' in query, but was: {query}");
        }

        [TestMethod]
        public async Task PublicKeyAsync_WithNoParams_Returns200Ok_WithCorrectPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PublicKeyResponse.json");

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
                    services.AddManageCardPINService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageCardPINService = testHost.Services.GetRequiredService<IManageCardPINService>();

            // Act
            IPublicKeyApiResponse response = await manageCardPINService.PublicKeyAsync();

            // Assert - response
            Assert.IsTrue(response.IsOk);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/publicKey", capturedRequest.RequestUri?.AbsolutePath);
            Assert.AreEqual(string.Empty, capturedRequest.RequestUri!.Query);
        }
    }
}
