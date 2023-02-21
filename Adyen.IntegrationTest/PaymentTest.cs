using System;
using Adyen.Model.ClassicPayments;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using Adyen.HttpClient;
using Adyen.Model.StoredValue;
using Adyen.Service.ClassicPayments;
using Environment = Adyen.Model.Environment;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class PaymentTest : BaseTest
    {
        [TestMethod]
        public void BasicAuthenticationAuthoriseSuccessTest()
        {
            var paymentResult = CreatePaymentResult();
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("1111", GetAdditionalData(paymentResult.AdditionalData, "cardSummary"));
            Assert.IsNotNull(GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("H167852639363479", GetAdditionalData(paymentResult.AdditionalData, "alias"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethodVariant"));
            Assert.AreEqual("Default", GetAdditionalData(paymentResult.AdditionalData, "aliasType"));
        }

        [TestMethod]
        public async Task BasicAuthenticationAuthoriseAsyncSuccessTest()
        {
            var paymentResult = await CreatePaymentResultAsync();

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("1111", GetAdditionalData(paymentResult.AdditionalData, "cardSummary"));
            Assert.IsNotNull(GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("H167852639363479", GetAdditionalData(paymentResult.AdditionalData, "alias"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethodVariant"));
            Assert.AreEqual("Default", GetAdditionalData(paymentResult.AdditionalData, "aliasType"));
        }

        [TestMethod]
        public void ApiKeyAuthoriseSuccessTest()
        {
            var paymentResult = CreatePaymentResultWithApiKeyAuthentication();

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("1111", GetAdditionalData(paymentResult.AdditionalData, "cardSummary"));
            Assert.IsNotNull(GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("H167852639363479", GetAdditionalData(paymentResult.AdditionalData, "alias"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethodVariant"));
            Assert.AreEqual("Default", GetAdditionalData(paymentResult.AdditionalData, "aliasType"));
        }

        [TestMethod]
        public void ApiIdemptotencyKeySuccessTest()
        {
            var paymentResult1 = CreatePaymentResultWithIdempotency("AUTH_IDEMPOTENCY_KEY_AUTHOR");
            var paymentResult2 = CreatePaymentResultWithIdempotency("AUTH_IDEMPOTENCY_KEY_AUTHOR");
            Assert.AreEqual(paymentResult1.PspReference, paymentResult2.PspReference);
        }
        
        [TestMethod]
        public void StoredValueIssueFailIntegrationTest()
        {
            var client = new Client(new Config()
            {
                Environment = Environment.Test,
                XApiKey = ClientConstants.Xapikey
            });
            var service = new StoredValue(client);
            var ex = Assert.ThrowsException<HttpClientException>(() => service.Issue(new StoredValueIssueRequest()));
            Assert.AreEqual(ex.Code, 422);
        }

        [TestMethod]
        public void ApiIdemptotencyKeyFailTest()
        {
            try
            {
                //This key is used by another Merchant account
                var paymentResult1 = CreatePaymentResultWithIdempotency("AUTH_IDEMPOTENCY_KEY_AUTHOR");
                var paymentResult2 = CreatePaymentResultWithIdempotency("AUTH_IDEMPOTENCY_KEY_AUTHOR");
            }
            catch (HttpClientException ex)
            {
                Assert.AreEqual(ex.Code, 403);
            }
        }
        
        [TestMethod]
        public void AuthenticationResult()
        {
            var authenticationResultRequest = new AuthenticationResultRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                PspReference = GetTestPspReference()
            };
            var client = CreateApiKeyTestClient();
            var payment = new PaymentService(client);
            try
            {
                payment.GetThe3dsAuthenticationResult(authenticationResultRequest);
            }
            catch (HttpClientException ex)
            {
                Assert.AreEqual(422, ex.Code);
            }
        }

        private string GetAdditionalData(Dictionary<string, string> additionalData, string assertKey)
        {
            string result = "";
            if (additionalData.ContainsKey(assertKey))
            {
                result = additionalData[assertKey];
            }
            return result;
        }
    }
}
