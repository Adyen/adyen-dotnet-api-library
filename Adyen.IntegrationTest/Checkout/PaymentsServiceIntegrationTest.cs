using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Core.Client.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;

namespace Adyen.IntegrationTest.Checkout
{
    [TestClass]
    public class PaymentsServiceIntegrationTest
    {
        private readonly IPaymentsService _paymentsApiService;

        public PaymentsServiceIntegrationTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureCheckout(
                    (context, services, config) =>
                    {
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                            options.Environment = AdyenEnvironment.Test;
                        });
                    })
                .Build();

            _paymentsApiService = host.Services.GetRequiredService<IPaymentsService>();
        }

        [TestMethod]
        public async Task Given_Payments_When_CardDetails_Provided_Returns_OK()
        {
            // Arrange
            var request = new PaymentRequest(
                amount: new Amount("EUR", 1999),
                merchantAccount: "HeapUnderflowECOM",
                reference: "reference",
                returnUrl: "https://adyen.com/",
                paymentMethod: new CheckoutPaymentMethod(
                    new CardDetails(
                        type: CardDetails.TypeEnum.Scheme,
                        encryptedCardNumber: "test_4111111111111111",
                        encryptedExpiryMonth: "test_03",
                        encryptedExpiryYear: "test_2030",
                        encryptedSecurityCode: "test_737",
                        holderName: "John Smith"
                        )
                    )
                );
            IPaymentsApiResponse response = await _paymentsApiService.PaymentsAsync(Guid.NewGuid().ToString(), request);

            response.TryDeserializeOkResponse(out var result);
            Assert.AreEqual(result?.MerchantReference, "reference");
        }

        [TestMethod]
        public void HttpClientBuilderExtensions_Polly_Retry_CircuitBreaker_Timeout_Example()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureCheckout(
                    (context, services, config) =>
                    {
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                            options.Environment = AdyenEnvironment.Test;
                        });
                    },
                    httpClientBuilderDelegate: (IHttpClientBuilder builder) =>
                    {
                        builder.AddRetryPolicy(5);
                        builder.AddCircuitBreakerPolicy(3, TimeSpan.FromSeconds(30));
                        builder.AddTimeoutPolicy(TimeSpan.FromMinutes(5));
                    })
                .Build();
        }

        [TestMethod]
        public void HttpClientBuilderExtensions_Regular_Timeout_Modify_HttpClient_Example()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureCheckout(
                    (context, services, config) =>
                    {
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                            options.Environment = AdyenEnvironment.Test;
                        });
                    }, client =>
                    {
                        client.Timeout = TimeSpan.FromMinutes(1);
                    })
                .Build();
        }
    }
}