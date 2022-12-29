using Adyen.Service.Resource.Payout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Adyen.Service;
using Adyen.Model.Payout;
using Adyen.Model;
using System;
using Adyen.HttpClient;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class PayoutTest : BaseTest
    {
        private Client _client;
        private Payout _payout;

        [TestInitialize]
        public void Init()
        {
            _client = this.CreateApiKeyTestClient();
            _payout = new Payout(_client);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            PayoutRequest payoutRequest = CreatePayoutRequest("DotNetAlexandros");
            PayoutResponse result = _payout.PayoutSubmit(payoutRequest);
            Assert.AreEqual(result.ResultCode, "Authorised");
        }


        [TestMethod]
        public void PayoutErrorMissingMerchantTest()
        {
            PayoutRequest payoutRequest = CreatePayoutRequest("");
            try
            {
                PayoutResponse result = _payout.PayoutSubmit(payoutRequest);
            }
            catch (HttpClientException e)
            {
                Assert.AreEqual("403: Forbidden, ResponseBody: {\"status\":403,\"errorCode\":\"901\",\"message\":\"Invalid Merchant Account\",\"errorType\":\"security\"}", e.Message);
            }
        }

        [TestMethod]
        public void PayoutErrorMissingReferenceTest()
        {
            PayoutRequest payoutRequest = CreatePayoutRequest("DotNetAlexandros");
            payoutRequest.ShopperReference = "";
            try
            {
                PayoutResponse result = _payout.PayoutSubmit(payoutRequest);
            }
            catch (HttpClientException e)
            {
                Assert.AreEqual(403, e.Code);
            }
        }

        private PayoutRequest CreatePayoutRequest(string merchantAccount)
        {
            PayoutRequest payoutRequest = new PayoutRequest
            {
                Amount = new Model.Amount { Currency = "EUR", Value = 10 },
                Card = new Card
                {
                    Number = "4111111111111111",
                    ExpiryMonth = "03",
                    ExpiryYear = "2030",
                    HolderName = "John Smith",
                    Cvc = "737"
                },
                MerchantAccount = merchantAccount,
                Reference = "Your order number from e2e",
                ShopperReference = "reference",
            };
            return payoutRequest;
        }
    }
}
