using Adyen;
using Adyen.Model.Checkout;
using Adyen.Service.Checkout;
using Environment = Adyen.Model.Environment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class ReadmeTest
    {
        [TestMethod]
        public void PaymentTest()
        {
            var config = new Config()
            {
                XApiKey = "your-api-key",
                Environment = Environment.Test
            };
            var client = new Client(config);
            var paymentsService = new PaymentsService(client);
            var amount = new Model.Checkout.Amount("USD", 1000);
            var cardDetails = new CardDetails
            {
                Number = "4111111111111111",
                Cvc = "737",
                ExpiryMonth = "03",
                ExpiryYear = "2030",
                HolderName = "John Smith",
                Type = CardDetails.TypeEnum.Card
            };
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number ",
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "your-merchant-account",
                Amount = amount,
                PaymentMethod = new CheckoutPaymentMethod(cardDetails)
            };
            if (!string.Equals(config.XApiKey , "your-api-key"))
            {
                var paymentResponse = paymentsService.Payments(paymentsRequest);
                Assert.IsNotNull(paymentResponse);
                Assert.IsNotNull(paymentResponse.PspReference);
            }
        }
    }
}