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
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-success.json");

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
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-error-invalid-data-422.json");
            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.Payments(paymentMethodsRequest);
            Assert.IsNull( paymentResponse.PspReference);
        }
        
        [TestMethod]
        public void PaymentDetailsTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details.Add("payload", "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-sucess.json");
            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.PaymentDetails(detailsRequest);
           Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

         [TestMethod]
        public void PaymentDetailsErrorTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details.Add("payload", "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-error-invalid-data-422.json");
            var _checkout = new Checkout(client);
            var paymentResponse = _checkout.PaymentDetails(detailsRequest);
           Assert.IsNull( paymentResponse.ResultCode);
        }

        [TestMethod]
        public void PaymentMethodsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-success.json");
            var _checkout = new Checkout(client);
            var paymentMethodsResponse = _checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 65);
           
        }

        [TestMethod]
        public void PaymentMethodsErrorTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-error-forbidden-403.json");
            var _checkout = new Checkout(client);
            var paymentMethodsResponse = _checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsNull(paymentMethodsResponse.PaymentMethods);
        }

        [TestMethod]
        public void CheckoutEndpointTest()
        {
            var config = new Config();
            var client = new Client(config);
            client.SetEnviroment(Model.Enum.Environment.Live, "companyUrl");
            Assert.AreEqual(config.CheckoutEndpoint, @"https://companyUrl-checkout-live.adyenpayments.com/checkout");
            Assert.AreEqual(config.Endpoint, @"https://companyUrl-pal-live.adyenpayments.com");
        }

        [TestMethod]
        public void PaymentSessionSuccessTest()
        {
             var paymentSetupRequest= CreatePaymentSetupRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-sucess.json");
            var _checkout = new Checkout(client);
            var paymentSessionResponse = _checkout.PaymentSession(paymentSetupRequest);
            Assert.IsNotNull(paymentSessionResponse.PaymentSession);
        }

        [TestMethod]
        public void PaymentSessionErrorTest()
        {
           var paymentSetupRequest= CreatePaymentSetupRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-error-invalid-data-422.json");
            var _checkout = new Checkout(client);
            var paymentSessionResponse = _checkout.PaymentSession(paymentSetupRequest);
            Assert.IsNull(paymentSessionResponse.PaymentSession);
        }

        [TestMethod]
        public void PaymentsResultSuccessTest()
        {
            var paymentVerificationRequest = CreatePaymentVerificationRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsresult-sucess.json");
            var _checkout = new Checkout(client);
            var paymentResultResponse = _checkout.PaymentsResult(paymentVerificationRequest);
            Assert.AreEqual(paymentResultResponse.ResultCode, Model.Checkout.PaymentVerificationResponse.ResultCodeEnum.Authorised);
        }

        [TestMethod]
        public void PaymentsResultErrorTest()
        {
            var paymentVerificationRequest = CreatePaymentVerificationRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsresult-error-invalid-data-payload-422.json");
            var _checkout = new Checkout(client);
            var paymentResultResponse = _checkout.PaymentsResult(paymentVerificationRequest);
            Assert.IsNull(paymentResultResponse.ResultCode);
        }
    }
}
