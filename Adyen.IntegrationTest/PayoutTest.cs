using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adyen.Service;
using Adyen.Model.Payout;
using Adyen.Model;
using Adyen.HttpClient;
using Adyen.Service.Payout;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class PayoutTest : BaseTest
    {
        private Client _client;
        private InstantPayoutsService _instantPayoutsService;
        private InitializationService _initializationService;
        private ReviewingService _reviewingService;

        [TestInitialize]
        public void Init()
        {
            _client = this.CreateApiKeyTestClient();
            _instantPayoutsService = new InstantPayoutsService(_client);
            _initializationService = new InitializationService(_client);
            _reviewingService = new ReviewingService(_client);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            var payoutRequest = CreatePayoutRequest("DotNetAlexandros");
            var result = _instantPayoutsService.MakeInstantCardPayout(payoutRequest);
            Assert.AreEqual(result.ResultCode, PayoutResponse.ResultCodeEnum.Authorised);
        }


        [TestMethod]
        public void PayoutErrorMissingMerchantTest()
        {
            var payoutRequest = CreatePayoutRequest("");
            var ex = Assert.ThrowsException<HttpClientException>(() => _instantPayoutsService.MakeInstantCardPayout(payoutRequest));
            Assert.AreEqual(ex.Code, 403);
        }

        [TestMethod]
        public void PayoutErrorMissingReferenceTest()
        {
            var payoutRequest = CreatePayoutRequest("DotNetAlexandros");
            payoutRequest.Reference = "";
            var ex = Assert.ThrowsException<HttpClientException>(() => _instantPayoutsService.MakeInstantCardPayout(payoutRequest));
            Assert.AreEqual("{\"status\":422,\"errorCode\":\"130\",\"message\":\"Required field 'reference' is not provided.\",\"errorType\":\"validation\"}",ex.ResponseBody);
            Assert.AreEqual(422, ex.Code);
        }

        private PayoutRequest CreatePayoutRequest(string merchantAccount)
        {
            var payoutRequest = new PayoutRequest
            {
                Amount = new Model.Payout.Amount { Currency = "EUR", Value = 10 },
                Card = new Model.Payout.Card
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
