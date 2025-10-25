using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
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
              .ConfigureCheckout((context, services, config) =>
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
    }
}