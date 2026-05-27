using System.Linq;
using System.Net;
using System.Text;
using Adyen.Core;
using Adyen.Core.Options;
using Adyen.PaymentsApp.Extensions;
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.PaymentsApp
{
    [TestClass]
    public class PaymentsAppServiceTest
    {
        #region URL verification

        [TestMethod]
        public async Task Given_PaymentsAppService_When_Initialized_Result_Should_Return_Management_Test_Url()
        {
            // Arrange
            // Act
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    services.AddPaymentsAppService();
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Assert
            Assert.AreEqual("https://management-test.adyen.com/v1", paymentsAppService.HttpClient.BaseAddress.ToString());
        }

        [TestMethod]
        public void Given_PaymentsAppService_When_Initialized_Result_Should_Return_Management_Live_Url()
        {
            // Arrange
            // Act
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                    });
                    services.AddPaymentsAppService();
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Assert
            Assert.AreEqual("https://management-live.adyen.com/v1", paymentsAppService.HttpClient.BaseAddress.ToString());
        }

        [TestMethod]
        public void Given_PaymentsAppService_When_Initialized_Result_Should_Return_Management_Live_Url_And_No_Prefix()
        {
            // Arrange
            // Act
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                    services.AddPaymentsAppService();
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Assert
            Assert.AreEqual("https://management-live.adyen.com/v1", paymentsAppService.HttpClient.BaseAddress.ToString());
        }

        #endregion

        #region GeneratePaymentsAppBoardingTokenForMerchantAsync

        [TestMethod]
        public async Task GeneratePaymentsAppBoardingTokenForMerchantAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/boarding-token-response-merchant.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            var boardingRequest = new BoardingTokenRequest
            {
                BoardingRequestToken = "test-boarding-token"
            };

            // Act
            var response = await paymentsAppService.GeneratePaymentsAppBoardingTokenForMerchantAsync(
                "TestMerchantAccount", boardingRequest);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var boardingTokenResponse));
            Assert.IsNotNull(boardingTokenResponse);
            Assert.AreEqual("install-merchant-001", boardingTokenResponse.InstallationId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/generatePaymentsAppBoardingToken", capturedRequest.RequestUri.AbsolutePath);
        }

        [TestMethod]
        public async Task GeneratePaymentsAppBoardingTokenForMerchantAsync_Returns400BadRequest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/error-response-400.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            var boardingRequest = new BoardingTokenRequest
            {
                BoardingRequestToken = "invalid-token"
            };

            // Act
            var response = await paymentsAppService.GeneratePaymentsAppBoardingTokenForMerchantAsync(
                "TestMerchantAccount", boardingRequest);

            // Assert - response
            Assert.IsFalse(response.IsOk);
            Assert.IsTrue(response.IsBadRequest);
            Assert.IsTrue(response.TryDeserializeBadRequestResponse(out var errorResponse));
            Assert.IsNotNull(errorResponse);
            Assert.AreEqual(400, errorResponse.Status);
            Assert.AreEqual("Invalid request", errorResponse.Title);
            Assert.AreEqual("PAYMENTAPP_001", errorResponse.ErrorCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/generatePaymentsAppBoardingToken", capturedRequest.RequestUri.AbsolutePath);
        }

        [TestMethod]
        public async Task GeneratePaymentsAppBoardingTokenForMerchantAsync_ReturnsApiResponseOn500InternalServerError()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            var boardingRequest = new BoardingTokenRequest
            {
                BoardingRequestToken = "test-token"
            };

            // Act
            var response = await paymentsAppService.GeneratePaymentsAppBoardingTokenForMerchantAsync(
                "TestMerchantAccount", boardingRequest);

            // Assert - response
            Assert.AreEqual(500, (int)response.StatusCode);
            Assert.IsTrue(response.IsInternalServerError);
            Assert.IsTrue(response.TryDeserializeInternalServerErrorResponse(out var errorResponse));
            Assert.IsNotNull(errorResponse);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/generatePaymentsAppBoardingToken", capturedRequest.RequestUri.AbsolutePath);
        }

        #endregion

        #region GeneratePaymentsAppBoardingTokenForStoreAsync

        [TestMethod]
        public async Task GeneratePaymentsAppBoardingTokenForStoreAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/boarding-token-response-store.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            var boardingRequest = new BoardingTokenRequest
            {
                BoardingRequestToken = "store-boarding-token"
            };

            // Act
            var response = await paymentsAppService.GeneratePaymentsAppBoardingTokenForStoreAsync(
                "TestMerchantAccount", "TestStore", boardingRequest);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var boardingTokenResponse));
            Assert.IsNotNull(boardingTokenResponse);
            Assert.AreEqual("install-store-001", boardingTokenResponse.InstallationId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/stores/TestStore/generatePaymentsAppBoardingToken", capturedRequest.RequestUri.AbsolutePath);
        }

        #endregion

        #region ListPaymentsAppForMerchantAsync

        [TestMethod]
        public async Task ListPaymentsAppForMerchantAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/list-payments-apps-merchant.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Act
            var response = await paymentsAppService.ListPaymentsAppForMerchantAsync("TestMerchantAccount");

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var listResponse));
            Assert.IsNotNull(listResponse);
            Assert.AreEqual(3, listResponse.PaymentsApps.Count);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/paymentsApps", capturedRequest.RequestUri.AbsolutePath);
        }

        [TestMethod]
        public async Task ListPaymentsAppForMerchantAsync_WithStatusFilter_Returns200Ok()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/list-payments-apps-merchant.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Act
            var response = await paymentsAppService.ListPaymentsAppForMerchantAsync(
                "TestMerchantAccount", statuses: new Option<string>("BOARDED"));

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/paymentsApps", capturedRequest.RequestUri.AbsolutePath);
            Assert.IsTrue(capturedRequest.RequestUri!.Query.Contains("statuses=BOARDED"));
        }

        [TestMethod]
        public async Task ListPaymentsAppForMerchantAsync_WithPagination_Returns200Ok()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/list-payments-apps-merchant.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Act
            var response = await paymentsAppService.ListPaymentsAppForMerchantAsync(
                "TestMerchantAccount",
                statuses: new Option<string>("BOARDED"),
                limit: new Option<int>(10),
                offset: new Option<long>(0));

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/paymentsApps", capturedRequest.RequestUri.AbsolutePath);
            Assert.IsTrue(capturedRequest.RequestUri!.Query.Contains("statuses=BOARDED"));
            Assert.IsTrue(capturedRequest.RequestUri.Query.Contains("limit=10"));
            Assert.IsTrue(capturedRequest.RequestUri.Query.Contains("offset=0"));
        }

        #endregion

        #region ListPaymentsAppForStoreAsync

        [TestMethod]
        public async Task ListPaymentsAppForStoreAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/list-payments-apps-store.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Act
            var response = await paymentsAppService.ListPaymentsAppForStoreAsync(
                "TestMerchantAccount", "TestStore");

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var listResponse));
            Assert.IsNotNull(listResponse);
            Assert.AreEqual(2, listResponse.PaymentsApps.Count);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/stores/TestStore/paymentsApps", capturedRequest.RequestUri.AbsolutePath);
        }

        #endregion

        #region RevokePaymentsAppAsync

        [TestMethod]
        public async Task RevokePaymentsAppAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Act
            var response = await paymentsAppService.RevokePaymentsAppAsync(
                "TestMerchantAccount", "install-merchant-001");

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/paymentsApps/install-merchant-001/revoke", capturedRequest.RequestUri.AbsolutePath);
        }

        [TestMethod]
        public async Task RevokePaymentsAppAsync_Returns400BadRequest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/error-response-400.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();

            // Act
            var response = await paymentsAppService.RevokePaymentsAppAsync(
                "TestMerchantAccount", "install-merchant-001");

            // Assert - response
            Assert.IsFalse(response.IsOk);
            Assert.IsTrue(response.IsBadRequest);
            Assert.IsTrue(response.TryDeserializeBadRequestResponse(out var errorResponse));
            Assert.IsNotNull(errorResponse);
            Assert.AreEqual(400, errorResponse.Status);
            Assert.AreEqual("Invalid request", errorResponse.Title);
            Assert.AreEqual("PAYMENTAPP_001", errorResponse.ErrorCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/v1/merchants/TestMerchantAccount/paymentsApps/install-merchant-001/revoke", capturedRequest.RequestUri.AbsolutePath);
        }

        #endregion

        [TestMethod]
        public async Task GeneratePaymentsAppBoardingTokenForMerchantAsync_AddsXApiKeyHeader()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/paymentsapp/boarding-token-response-merchant.json");

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
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddPaymentsAppService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            var boardingRequest = new BoardingTokenRequest { BoardingRequestToken = "test-boarding-token" };

            // Act
            await paymentsAppService.GeneratePaymentsAppBoardingTokenForMerchantAsync("TestMerchantAccount", boardingRequest);

            // Assert
            Assert.IsNotNull(capturedRequest);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var values));
            Assert.AreEqual("test-api-key", values.First());
        }
    }
}
