using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static Adyen.EcommLibrary.Model.Checkout.PaymentsResponse;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CheckoutTest : BaseTest
    {
        [TestMethod]
        public void CheckoutEndpointTest()
        {
            var config = new Config();
            var client = new Client(config);
            client.SetEnviroment(Model.Enum.Environment.Live, "companyUrl");
            Assert.AreEqual(config.CheckoutEndpoint, @"https://companyUrl-checkout-live.adyenpayments.com/checkout");
            Assert.AreEqual(config.Endpoint, @"https://companyUrl-pal-live.adyenpayments.com");
        }

        /// <summary>
        /// Test success flow for
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void PaymentsTest()
        {
            var paymentMethodsRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-success.json");

            var checkout = new Checkout(client);
            var paymentResponse = checkout.Payments(paymentMethodsRequest);
            Assert.AreEqual("8535296650153317", paymentResponse.PspReference);
            Assert.AreEqual(ResultCodeEnum.Authorised, paymentResponse.ResultCode);
            Assert.IsNotNull(paymentResponse.AdditionalData);
            Assert.AreEqual(9, paymentResponse.AdditionalData.Count);
            Assert.AreEqual("411111", paymentResponse.AdditionalData["cardBin"]);
            Assert.AreEqual("visa", paymentResponse.AdditionalData["cardPaymentMethod"]);
        }

        /// <summary>
        /// Test error flow for
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void PaymentsErrorTest()
        {
            var paymentMethodsRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-error-invalid-data-422.json");
            var checkout = new Checkout(client);
            var paymentResponse = checkout.Payments(paymentMethodsRequest);
            Assert.IsNull(paymentResponse.PspReference);
        }

        /// <summary>
        /// Test success flow for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details.Add("payload", "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-sucess.json");
            var checkout = new Checkout(client);
            var paymentResponse = checkout.PaymentDetails(detailsRequest);
            Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

        /// <summary>
        /// Test error flow for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsErrorTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details.Add("payload", "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-error-invalid-data-422.json");
            var checkout = new Checkout(client);
            var paymentResponse = checkout.PaymentDetails(detailsRequest);
            Assert.IsNull(paymentResponse.ResultCode);
        }
        /// <summary>
        /// Test success flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-success.json");
            var checkout = new Checkout(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 65);

        }
        /// <summary>
        /// Test error flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsErrorTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-error-forbidden-403.json");
            var checkout = new Checkout(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsNull(paymentMethodsResponse.PaymentMethods);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public void PaymentSessionSuccessTest()
        {
            var paymentSessionRequest = CreatePaymentSessionRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-sucess.json");
            var checkout = new Checkout(client);
            var paymentSessionResponse = checkout.PaymentSession(paymentSessionRequest);
            Assert.IsNotNull(paymentSessionResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public void PaymentSessionErrorTest()
        {
            var paymentSessionRequest = CreatePaymentSessionRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-error-invalid-data-422.json");
            var checkout = new Checkout(client);
            var paymentSessionResponse = checkout.PaymentSession(paymentSessionRequest);
            Assert.IsNull(paymentSessionResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsResultSuccessTest()
        {
            var paymentResultRequest = CreatePaymentResultRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsresult-sucess.json");
            var checkout = new Checkout(client);
            var paymentResultResponse = checkout.PaymentsResult(paymentResultRequest);
            Assert.AreEqual(paymentResultResponse.ResultCode, Model.Checkout.PaymentResultResponse.ResultCodeEnum.Authorised);
        }
        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsResultErrorTest()
        {
            var paymentResultRequest = CreatePaymentResultRequest();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsresult-error-invalid-data-payload-422.json");
            var checkout = new Checkout(client);
            var paymentResultResponse = checkout.PaymentsResult(paymentResultRequest);
            Assert.IsNull(paymentResultResponse.ResultCode);
        }

        [TestMethod]
        public void PaymentRequestApplicationInfoTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var name = paymentRequest.ApplicationInfo.AdyenLibrary.Name;
            var version = paymentRequest.ApplicationInfo.AdyenLibrary.Version;
            Assert.AreEqual(version, Constants.ClientConfig.LibVersion);
            Assert.AreEqual(name, Constants.ClientConfig.LibName);
        }


        [TestMethod]
        public void PaymentSessionRequestApplicationInfoTest()
        {
            var paymentSessionRequest = CreatePaymentSessionRequest();
            var name = paymentSessionRequest.ApplicationInfo.AdyenLibrary.Name;
            var version = paymentSessionRequest.ApplicationInfo.AdyenLibrary.Version;
            Assert.AreEqual(version, Constants.ClientConfig.LibVersion);
            Assert.AreEqual(name, Constants.ClientConfig.LibName);
        }
    }
}
