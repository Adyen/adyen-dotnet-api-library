using System.Diagnostics.Tracing;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Core.Client;
using Adyen.Core.Client.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using Microsoft.Extensions.Logging;

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
            
            // Example how to do logging for IPaymentsService and the PaymensServiceEvents.
            ILogger<IPaymentsService> logger = host.Services.GetRequiredService<ILogger<IPaymentsService>>();
            
            PaymentsServiceEvents events = host.Services.GetRequiredService<PaymentsServiceEvents>();
            
            // On /payments
            events.OnPayments += (sender, eventArgs) =>
            {
                ApiResponse apiResponse = eventArgs.ApiResponse;
                logger.LogInformation("{TotalSeconds,-9} | {Path} | {StatusCode} |", (apiResponse.DownloadedAt - apiResponse.RequestedAt).TotalSeconds, apiResponse.StatusCode, apiResponse.Path);
            };
            
            // OnError /payments.
            events.OnErrorPayments += (sender, eventArgs) =>
            {
                logger.LogError(eventArgs.Exception, "An error occurred after sending the request to the server.");
            };

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
        public async Task Given_Payments_When_CardDetails_Without_Idempotency_Key_Provided_Returns_DifferentRefs()
        {
            // Test when no idempotency key is provided
            var request = new PaymentRequest(
                amount: new Amount("EUR", 1999),
                merchantAccount: "HeapUnderflowECOM",
                reference: "ref1-original-request-1",
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
            IPaymentsApiResponse response = await _paymentsApiService.PaymentsAsync(paymentRequest: request);

            response.TryDeserializeOkResponse(out PaymentResponse result);
            Assert.AreEqual(result?.MerchantReference, "ref1-original-request-1");
            
            
            // Test when no idempotency key is provided
            var request2 = new PaymentRequest(
                amount: new Amount("EUR", 1999),
                merchantAccount: "HeapUnderflowECOM",
                reference: "ref2-should-be-different",
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
            IPaymentsApiResponse response2 = await _paymentsApiService.PaymentsAsync(paymentRequest: request2);

            response2.TryDeserializeOkResponse(out PaymentResponse result2);
            Assert.AreEqual(result2?.MerchantReference, "ref2-should-be-different");
            
            // Test when null is explicitly provided.
            var request3 = new PaymentRequest(
                amount: new Amount("EUR", 1999),
                merchantAccount: "HeapUnderflowECOM",
                reference: "ref3-should-be-very-different",
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
            IPaymentsApiResponse response3 = await _paymentsApiService.PaymentsAsync(null, request3);
            response3.TryDeserializeOkResponse(out PaymentResponse result3);
            Assert.AreEqual(result3?.MerchantReference, "ref3-should-be-very-different");
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

        [TestMethod]
        public async Task PaymentsServiceEvents_Override_Delegates_Example()
        {
            // Arrange
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

            
            PaymentsServiceEvents paymentsServiceEvents = host.Services.GetRequiredService<PaymentsServiceEvents>();
            IPaymentsService paymentsApiService = host.Services.GetRequiredService<IPaymentsService>();

            int isCalledOnce = 0;
            
            // Example override using a delegate:
            paymentsServiceEvents.OnPayments += (sender, args) =>
            {
                Console.WriteLine("OnPayments event received - IsSuccessStateCode: " + args.ApiResponse.IsSuccessStatusCode);
                isCalledOnce++;
            };
            
            // Act
            await paymentsApiService.PaymentsAsync(Guid.NewGuid().ToString(), request);
            
            // Assert
            Assert.IsTrue(isCalledOnce == 1);
        }
    }
}