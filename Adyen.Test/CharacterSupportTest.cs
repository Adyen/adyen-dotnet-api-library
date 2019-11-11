using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class CharacterSupportTest : BaseTest
    {
        [TestMethod]
        public void PolishCharsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-brands-polish.json");
            var checkout = new Checkout(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Details[0].Items[0].Name, "Bank Spółdzielczy w Brodnicy");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Details[0].Items[1].Name, "Bank transfer / postal");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Details[0].Items[2].Name, "Banki Spółdzielcze");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Details[0].Items[3].Name, "BLIK");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Details[0].Items[4].Name, "BNP Paribas - Płacę z Żółty");
        }
    }
}
