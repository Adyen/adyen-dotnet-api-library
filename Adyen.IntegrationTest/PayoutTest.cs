using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adyen.Service;
using Adyen.Model.Payout;
using Adyen.Model;
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
            var payoutRequest = CreatePayoutRequest("DotNetAlexandros");
            var result = _payout.PayoutSubmit(payoutRequest);
            Assert.AreEqual(result.ResultCode, PayoutResponse.ResultCodeEnum.Authorised);
        }


        [TestMethod]
        public void PayoutErrorMissingMerchantTest()
        {
            var payoutRequest = CreatePayoutRequest("");
            var ex = Assert.ThrowsException<HttpClientException>(() => _payout.PayoutSubmit(payoutRequest));
            Assert.AreEqual(ex.Code, 403);
        }

        [TestMethod]
        public void PayoutErrorMissingReferenceTest()
        {
            var payoutRequest = CreatePayoutRequest("DotNetAlexandros");
            payoutRequest.ShopperReference = "";
            var ex = Assert.ThrowsException<HttpClientException>(() => _payout.PayoutSubmit(payoutRequest));
            Assert.AreEqual(ex.Code, 403);
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
