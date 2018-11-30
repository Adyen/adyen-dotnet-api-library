using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static Adyen.EcommLibrary.Model.Checkout.PaymentResponse;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CheckoutTest : BaseTest
    {
        [TestMethod]
        public void PaymentsTest()
        {
            var paymentMethodsRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyCheckoutRequest("Mocks/checkout/payments-success.json");

            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.Payments(paymentMethodsRequest);
            Assert.AreEqual("8535296650153317", paymentResponse.PspReference);
            Assert.AreEqual(ResultCodeEnum.Authorised, paymentResponse.ResultCode);
            Assert.IsNotNull(paymentResponse.AdditionalData);
            Assert.AreEqual(9, paymentResponse.AdditionalData.Count);
            Assert.AreEqual("411111", paymentResponse.AdditionalData["cardBin"]);
            Assert.AreEqual("visa", paymentResponse.AdditionalData["cardPaymentMethod"]);
        }

        [TestMethod]
        public void PaymentsErrorTest()
        {
            var paymentMethodsRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyCheckoutRequest("Mocks/checkout/payments-error-invalid-data-422.json");
            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.Payments(paymentMethodsRequest);
            Assert.IsNull( paymentResponse.PspReference);
        }
        
        [TestMethod]
        public void PaymentDetailsTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details.Add("payload", "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyCheckoutRequest("Mocks/checkout/paymentsdetails-sucess.json");
            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.PaymentDetails(detailsRequest);
           Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

         [TestMethod]
        public void PaymentDetailsErrorTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details.Add("payload", "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyCheckoutRequest("Mocks/checkout/paymentsdetails-error-invalid-data-422.json");
            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.PaymentDetails(detailsRequest);
           Assert.IsNull( paymentResponse.ResultCode);
        }

        [TestMethod]
        public void PaymentMethodsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyCheckoutRequest("Mocks/checkout/paymentmethods-success.json");
            var _checkout = new Checkout(client);
            var paymentMethodsResponse = _checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 65);
           
        }

        [TestMethod]
        public void PaymentMethodsErrorTest()
        {
             var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyCheckoutRequest("Mocks/checkout/paymentmethods-error-forbidden-403.json");
            var _checkout = new Checkout(client);
            var paymentMethodsResponse = _checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsNull(paymentMethodsResponse.PaymentMethods);
        }
    }
}
