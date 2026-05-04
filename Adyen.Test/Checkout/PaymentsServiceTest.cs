using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Adyen.Core.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class PaymentsServiceTest
    {
        public PaymentsServiceTest() { }

        [TestMethod]
        public async Task SessionsAsyncTest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/sessions-success.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Created)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsService = testHost.Services.GetRequiredService<IPaymentsService>();
            var createCheckoutSessionRequest = new CreateCheckoutSessionRequest
            {
                Amount = new Amount { Currency = "EUR", Value = 10000L },
                MerchantAccount = "TestMerchantAccount",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Channel = CreateCheckoutSessionRequest.ChannelEnum.Web,
                CountryCode = "NL",
            };

            // Act
            ISessionsApiResponse response = await paymentsService.SessionsAsync(createCheckoutSessionRequest, new RequestOptions().AddIdempotencyKey("idempotencyKey"));

            // Assert - response
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.IsTrue(response.IsCreated);
            CreateCheckoutSessionResponse sessionResponse = response.Created();
            Assert.IsNotNull(sessionResponse);
            Assert.AreEqual("CS0068299CB8DA273A", sessionResponse.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/v71/sessions", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task AddAdditionalHeadersWithPaymentsServiceTest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/sessions-success.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Created)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsService = testHost.Services.GetRequiredService<IPaymentsService>();
            var createCheckoutSessionRequest = new CreateCheckoutSessionRequest
            {
                Amount = new Amount { Currency = "EUR", Value = 10000L },
                MerchantAccount = "TestMerchantAccount",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Channel = CreateCheckoutSessionRequest.ChannelEnum.Web,
                CountryCode = "NL",
            };

            var requestOptions = new RequestOptions();
            requestOptions.AddAdditionalHeaders(new Dictionary<string, string>
            {
                { "X-Custom-Header-For-Payments", "PaymentsValue" },
                { "X-Another-Custom-Header", "AnotherValue" }
            });

            // Act
            await paymentsService.SessionsAsync(createCheckoutSessionRequest, requestOptions);

            // Assert - custom headers sent on the wire
            Assert.IsNotNull(capturedRequest);
            Assert.IsTrue(capturedRequest.Headers.Contains("X-Custom-Header-For-Payments"));
            Assert.AreEqual("PaymentsValue", capturedRequest.Headers.GetValues("X-Custom-Header-For-Payments").First());
            Assert.IsTrue(capturedRequest.Headers.Contains("X-Another-Custom-Header"));
            Assert.AreEqual("AnotherValue", capturedRequest.Headers.GetValues("X-Another-Custom-Header").First());

            // Assert - HTTP verb and path
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/v71/sessions", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task Given_SessionResultWithSpecialChars_When_GetResultOfPaymentSession_Then_QueryStringIsNotEncoded()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/session-result-success.json");

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
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddPaymentsService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var paymentsService = testHost.Services.GetRequiredService<IPaymentsService>();
            // sessionResult includes special characters AND an ampersand to verify it
            // does not split into two query params
            string sessionResult = "AB1234+value/with!special=chars&extra";

            // Act
            var response = await paymentsService.GetResultOfPaymentSessionAsync("CS123", sessionResult);

            // Assert - response
            Assert.IsTrue(response.IsOk);
            var sessionResultResponse = response.Ok();
            Assert.IsNotNull(sessionResultResponse);
            Assert.AreEqual("CS123", sessionResultResponse.Id);
            Assert.AreEqual(SessionResultResponse.StatusEnum.Completed, sessionResultResponse.Status);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/v71/sessions/CS123", capturedRequest.RequestUri?.AbsolutePath);

            // Assert - query string encoding
            string query = capturedRequest.RequestUri!.Query;
            Assert.IsTrue(query.Contains("+"), $"Expected '+' to not be encoded, but query was: {query}");
            Assert.IsTrue(query.Contains("/"), $"Expected '/' to not be encoded, but query was: {query}");
            Assert.IsTrue(query.Contains("!"), $"Expected '!' to not be encoded, but query was: {query}");
            Assert.IsFalse(query.Contains("%2B"), $"Expected '+' to not be percent-encoded as %2B, but query was: {query}");
            Assert.IsFalse(query.Contains("%2F"), $"Expected '/' to not be percent-encoded as %2F, but query was: {query}");
            Assert.IsFalse(query.Contains("%21"), $"Expected '!' to not be percent-encoded as %21, but query was: {query}");
            // Verify & in the value does not create a second query parameter
            var queryParams = System.Web.HttpUtility.ParseQueryString(query);
            Assert.AreEqual(1, queryParams.Count, $"Expected exactly 1 query parameter, but found {queryParams.Count}. Query was: {query}");
            Assert.AreEqual("sessionResult", queryParams.AllKeys[0], $"Expected the only query parameter to be 'sessionResult', but was: {queryParams.AllKeys[0]}");
        }
    }
}
