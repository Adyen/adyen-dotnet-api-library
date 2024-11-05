using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.BinLookup;
using Adyen.Model.Checkout;
using Adyen.Model.Payment;
using Adyen.Service;
using Adyen.Service.Checkout;
using Amount = Adyen.Model.Checkout;
using PaymentRequest = Adyen.Model.Payment.PaymentRequest;
using PaymentResult = Adyen.Model.Payment.PaymentResult;
using Environment = Adyen.Model.Environment;
using ExternalPlatform = Adyen.Model.ApplicationInformation.ExternalPlatform;
using Recurring = Adyen.Model.Payment.Recurring;

namespace Adyen.IntegrationTest
{
    public class BaseTest
    {
        public PaymentResult CreatePaymentResult()
        {
            var client = CreateApiKeyTestClient();
            var payment = new PaymentService(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);

            return paymentResult;
        }

        public async Task<PaymentResult> CreatePaymentResultAsync()
        {
            var client = CreateApiKeyTestClient();
            var payment = new PaymentService(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = await payment.AuthoriseAsync(paymentRequest);

            return paymentResult;
        }

        public PaymentResult CreatePaymentResultWithApiKeyAuthentication()
        {
            var client = CreateApiKeyTestClient();
            var payment = new PaymentService(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);

            return paymentResult;
        }

        public PaymentResult CreatePaymentResultWithIdempotency(string idempotency)
        {
            var client = CreateApiKeyTestClient();
            var payment = new PaymentService(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest, new RequestOptions{ IdempotencyKey=idempotency});

            return paymentResult;
        }

        public PaymentResult CreatePaymentResultWithRecurring(Recurring.ContractEnum contract)
        {
            var client = CreateApiKeyTestClient();
            var payment = new PaymentService(client);
            var paymentRequest = CreateFullPaymentRequestWithRecurring(contract);
            var paymentResult = payment.Authorise(paymentRequest);

            return paymentResult;
        }

       
        /// <summary>
        /// Creates a payment and returns the psp result
        /// </summary>
        /// <returns></returns>
        public string GetTestPspReference()
        {
            //Do test payment
            var paymentResult = CreatePaymentResult();
            //Get the psp referense 
            var paymentResultPspReference = paymentResult.PspReference;
            return paymentResultPspReference;
        }

        #region Modification objects

        protected CaptureRequest CreateCaptureTestRequest(string pspReference)
        {
            var captureRequest = new CaptureRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                ModificationAmount = new Adyen.Model.Payment.Amount("EUR", 150),
                Reference = "capture - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return captureRequest;
        }

        protected CancelOrRefundRequest CreateCancelOrRefundTestRequest(string pspReference)
        {
            var cancelOrRefundRequest = new CancelOrRefundRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Reference = "cancelOrRefund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelOrRefundRequest;
        }

        protected RefundRequest CreateRefundTestRequest(string pspReference)
        {
            var refundRequest = new RefundRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                ModificationAmount = new Adyen.Model.Payment.Amount("EUR", 150),
                Reference = "refund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return refundRequest;
        }

        protected CancelRequest CreateCancelTestRequest(string pspReference)
        {
            var cancelRequest = new CancelRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Reference = "cancel - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelRequest;
        }
        protected AdjustAuthorisationRequest CreateAdjustAuthorisationtestRequest(string pspReference)
        {
            var adjustAuthorisationRequest = new AdjustAuthorisationRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                ModificationAmount = new Adyen.Model.Payment.Amount("EUR", 150),
                Reference = "adjust authorisation - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return adjustAuthorisationRequest;
        }

        #endregion
        
        protected Client CreateApiKeyTestClient()
        {
            var config = new Config()
            {
                XApiKey = ClientConstants.Xapikey,
                Environment = Environment.Test
            };
            return new Client(config);        
        }
        
        private PaymentRequest CreateFullPaymentRequest()
        {
            PaymentRequest paymentRequest = new PaymentRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Amount = new Model.Payment.Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData(),
                ApplicationInfo = new Model.Payment.ApplicationInfo()
                {
                    ExternalPlatform = new Model.Payment.ExternalPlatform()
                    {
                        Integrator = "test merchant",
                        Name = "merchant name",
                        Version = "2.8"
                    }
                }

            };
            paymentRequest.ApplicationInfo.ExternalPlatform = new Model.Payment.ExternalPlatform("test merchant", "merchant name", "2.8");
            return paymentRequest;
        }

        private PaymentRequest CreateFullPaymentRequestWithRecurring(Recurring.ContractEnum contract)
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Amount = new Model.Payment.Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                ShopperReference = "test-1234",
                AdditionalData = CreateAdditionalData(),
                Recurring = new Recurring { Contract = contract },
                ApplicationInfo = new Model.Payment.ApplicationInfo()
                {
                    ExternalPlatform = new Model.Payment.ExternalPlatform()
                    {
                        Integrator = "test merchant",
                        Name = "merchant name",
                        Version = "2.8"
                    }
                }
            };

            paymentRequest.ApplicationInfo.ExternalPlatform = new Adyen.Model.Payment.ExternalPlatform("test merchant", "merchant name", "2.8");
            return paymentRequest;
        }

        /// <summary>
        /// Check out payment request
        /// </summary>
        /// <param name="merchantAccount"></param>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequestCheckout()
        {
            var amount = new Model.Checkout.Amount("USD", 1000);
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number from e2e",
                Amount = amount,
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = ClientConstants.MerchantAccount,
            };
            var cardDetails = new Model.Checkout.CardDetails()
            {
                Number = "4111111111111111",
                ExpiryMonth = "10",
                ExpiryYear = "2020",
                HolderName = "John Smith",
                Cvc = "737"
            };
            paymentsRequest.PaymentMethod = new CheckoutPaymentMethod(cardDetails);
            return paymentsRequest;
        }

        /// <summary>
        /// Check out payment IDeal request
        /// </summary>
        /// <param name="merchantAccount"></param>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequestIDealCheckout()
        {
            var amount = new Model.Checkout.Amount("EUR", 1000);
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number from e2e",
                Amount = amount,
                PaymentMethod= new Model.Checkout.CheckoutPaymentMethod(new IdealDetails(type: IdealDetails.TypeEnum.Ideal, issuer: "1121")),
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = ClientConstants.MerchantAccount,
            };
          
            return paymentsRequest;
        }

        protected Model.Payment.Card CreateTestCard()
        {
            return new Model.Payment.Card(number: "4111111111111111", expiryMonth: "03", expiryYear: "2030", cvc: "737",
                holderName: "John Smith");
        }

        /// <summary>
        /// Returns additional data object
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> CreateAdditionalData()
        {
            return new Dictionary<string, string>
            {
                {"fraudOffset", "0"},
            };
        }
    }
}
