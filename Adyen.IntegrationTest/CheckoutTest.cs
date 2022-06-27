
using Adyen.Model.Checkout;
using Adyen.Model.Checkout.Action;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class CheckoutTest : BaseTest
    {
        private Client _client;
        private Checkout _checkout;
        private static readonly string MerchantAccount = ClientConstants.MerchantAccount;

        [TestInitialize]
        public void Init()
        {
            _client = CreateApiKeyTestClient();
            _checkout = new Checkout(_client);
        }

        [TestMethod]
        public void PaymentsFlowWithInvalidApiKey()
        {
            _client.Config.XApiKey = "InvalidKey";
            try
            {
                var paymentResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            }
            catch (HttpClient.HttpClientException ex)
            {
                Assert.AreEqual(401, ex.Code );
            }
        }

        [TestMethod]
        public void PaymentsFlowWithEmptyApiKey()
        {
            _client.Config.XApiKey = null;
            try
            {
                var paymentResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            }
            catch (HttpClient.HttpClientException ex)
            {
                 Assert.AreEqual(401, ex.Code );
            }
        }

        [TestMethod]
        public void PaymentsFlowWithPartiallyCorrectKeyApiKey()
        {
            var key = _client.Config.XApiKey;
            _client.Config.XApiKey = "1" + key;
            try
            {
                var paymentResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            }
            catch (HttpClient.HttpClientException ex)
            {
                 Assert.AreEqual(401, ex.Code);
            }
        }

        [TestMethod]
        public void PaymentsTest()
        {
            var paymentResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            Assert.IsNotNull(paymentResponse.AdditionalData);
            Assert.AreEqual("411111", paymentResponse.AdditionalData["cardBin"]);
            Assert.IsNotNull(paymentResponse.AdditionalData["avsResult"]);
            Assert.AreEqual("1 Matches", paymentResponse.AdditionalData["cvcResult"]);
            Assert.AreEqual("visa", paymentResponse.AdditionalData["paymentMethodVariant"]);
        }

        [TestMethod]
        public void PaymentMethodsTest()
        {
            var amount = new Amount("EUR", 1000);
            var paymentMethodsRequest = new PaymentMethodsRequest(merchantAccount: MerchantAccount)
            {
                CountryCode = "NL",
                Amount = amount,
                Channel = PaymentMethodsRequest.ChannelEnum.Web
            };
            var paymentMethodsResponse = _checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsTrue(paymentMethodsResponse.PaymentMethods.Count != 0);
            Assert.IsTrue(!string.IsNullOrEmpty(paymentMethodsResponse.PaymentMethods[0].Name));
        }

        [TestMethod]
        public void PaymentWithIdealTest()
        {
            var paymentResponse = _checkout.Payments(CreatePaymentRequestIDealCheckout());
            var paymentResponseResult = (CheckoutRedirectAction)paymentResponse.Action;
            Assert.AreEqual(paymentResponse.ResultCode, PaymentResponse.ResultCodeEnum.RedirectShopper);
            Assert.AreEqual(paymentResponseResult.PaymentMethodType, "ideal");
            Assert.IsNotNull(paymentResponseResult.Url);
            Assert.AreEqual(paymentResponse.ResultCode, PaymentResponse.ResultCodeEnum.RedirectShopper);
        }

        [TestMethod]
        public void PaymentSessionTest()
        {
            var paymentSessionRequest = CreatePaymentSessionRequest();
            var paymentSessionResponse = _checkout.PaymentSession(paymentSessionRequest);
            Assert.IsNotNull(paymentSessionResponse.PaymentSession);
        }

        [TestMethod]
        public void PaymentLinksSuccessTest()
        {
            var amount = new Amount("EUR", 1000);
            var address = new Address(country: "NL", city: "Amsterdam", houseNumberOrName: "11", postalCode: "1234AB", street: "ams");
            var createPaymentLinkRequest = new CreatePaymentLinkRequest(amount: amount, merchantAccount: ClientConstants.MerchantAccount, reference: "Reference")
            {
                CountryCode = "NL",
                ShopperReference = "Unique_shopper_reference",
                ShopperEmail = "test@shopperEmail.com",
                BillingAddress = address,
                DeliveryAddress = address,
                ExpiresAt = DateTime.Now.AddHours(4).ToString("yyyy-MM-ddTHH:mm:ss")
            };
            var createPaymentLinkResponse = _checkout.PaymentLinks(createPaymentLinkRequest);
            Assert.IsNotNull(createPaymentLinkResponse);
            Assert.IsNotNull(createPaymentLinkResponse.Url);
            Assert.IsNotNull(createPaymentLinkResponse.Amount);
            Assert.IsNotNull(createPaymentLinkResponse.Reference);
            Assert.IsNotNull(createPaymentLinkResponse.ExpiresAt);
        }

        /// <summary>
        /// Test success sessions
        /// POST /sessions
        /// </summary>
        [TestMethod]
        public void CheckoutSessionSuccessTest()
        {
            var checkoutSessionRequest = new CreateCheckoutSessionRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Amount = new Amount("EUR", 10000L)
            };

            var createCheckoutSessionResponse = _checkout.Sessions(checkoutSessionRequest);
            Assert.AreEqual(MerchantAccount, createCheckoutSessionResponse.MerchantAccount);
            Assert.AreEqual("TestReference", createCheckoutSessionResponse.Reference);
            Assert.AreEqual("http://test-url.com", createCheckoutSessionResponse.ReturnUrl);
            Assert.AreEqual("EUR", createCheckoutSessionResponse.Amount.Currency);
            Assert.AreEqual("10000", createCheckoutSessionResponse.Amount.Value.ToString());
            Assert.IsNotNull(createCheckoutSessionResponse.SessionData);
        }


        /// <summary>
        /// Test success capture
        /// POST /payments/{paymentPspReference}/captures
        /// </summary>
        [TestMethod]
        public void ModificationsCapturesTest()
        {
            var paymentsResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            var createPaymentCaptureRequest = new CreatePaymentCaptureRequest(
                amount: new Amount(currency: "EUR", value: 500L), reference: "my_capture_reference",
                merchantAccount: MerchantAccount);
            var paymentCaptureResource =
                _checkout.PaymentsCaptures(paymentsResponse.PspReference, createPaymentCaptureRequest);
            Assert.AreEqual(paymentsResponse.PspReference, paymentCaptureResource.PaymentPspReference);
            Assert.AreEqual(paymentCaptureResource.Reference, "my_capture_reference");
        }

        /// <summary>
        /// Test success payments cancels
        /// POST /payments/{paymentPspReference}/cancels
        /// </summary>
        [TestMethod]
        public void ModificationsCancelsTest()
        {
            var paymentsResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            var createPaymentCancelRequest = new CreatePaymentCancelRequest(reference: "my_cancel_reference",
                merchantAccount: MerchantAccount);
            var paymentCancelResource =
                _checkout.PaymentsCancels(paymentsResponse.PspReference, createPaymentCancelRequest);
            Assert.AreEqual(paymentsResponse.PspReference, paymentCancelResource.PaymentPspReference);
            Assert.AreEqual(paymentCancelResource.Reference, "my_cancel_reference");
        }

        /// <summary>
        /// Test success payments reversals
        /// POST /payments/{paymentPspReference}/reversals
        /// </summary>
        [TestMethod]
        public void ModificationReversalsTest()
        {
            var paymentsResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            var createPaymentReversalRequest = new CreatePaymentReversalRequest(reference: "my_reversal_reference",
                merchantAccount: MerchantAccount);
            var paymentReversalResource =
                _checkout.PaymentsReversals(paymentsResponse.PspReference, createPaymentReversalRequest);
            Assert.AreEqual(paymentsResponse.PspReference, paymentReversalResource.PaymentPspReference);
            Assert.AreEqual(paymentReversalResource.Reference, "my_reversal_reference");
        }

        /// <summary>
        /// Test success payments reversals
        /// POST /payments/{paymentPspReference}/reversals
        /// </summary>
        [TestMethod]
        public void ModificationsRefundsTest()
        {
            var paymentsResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            var createPaymentRefundRequest = new CreatePaymentRefundRequest(
                amount: new Amount(currency: "EUR", value: 500L), reference: "my_refund_reference",
                merchantAccount: MerchantAccount);
            var paymentRefundResource =
                _checkout.PaymentsRefunds(paymentsResponse.PspReference, createPaymentRefundRequest);
            Assert.AreEqual(paymentsResponse.PspReference, paymentRefundResource.PaymentPspReference);
            Assert.AreEqual(paymentRefundResource.Reference, "my_refund_reference");
        }

        /// <summary>
        /// Test success payments cancels
        /// POST /payments/{paymentPspReference}/amountUpdates
        /// </summary>
        [TestMethod]
        public void ModificationsAmountUpdatesTest()
        {
            var paymentsResponse = _checkout.Payments(CreatePaymentRequestCheckout());
            var createPaymentAmountUpdateRequest = new CreatePaymentAmountUpdateRequest(
                amount: new Amount(currency: "EUR", value: 500L), reference: "my_updates_reference",
                merchantAccount: MerchantAccount);
            var paymentAmountUpdateResource =
                _checkout.PaymentsAmountUpdates(paymentsResponse.PspReference, createPaymentAmountUpdateRequest);
            Assert.AreEqual(paymentsResponse.PspReference, paymentAmountUpdateResource.PaymentPspReference);
            Assert.AreEqual(paymentAmountUpdateResource.Reference, "my_updates_reference");
        }
    }
}
