using Adyen.Model.Payout;
using Adyen.Service.Payout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class PayoutTest : BaseTest
    {
        [TestMethod]
        public void StoreDetailAndSubmitThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/payout/storeDetailAndSubmitThirdParty-success.json");
            var payout = new InitializationService(client);

            var request = new StoreDetailAndSubmitRequest();
            var result = payout.StoreDetailAndSubmitThirdParty(request);

            Assert.AreEqual("[payout-submit-received]", result.ResultCode);
            Assert.AreEqual("8515131751004933", result.PspReference);
            Assert.AreEqual("GREEN", result.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", result.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void StoreDetailSuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/payout/storeDetail-success.json");
            var payout = new InitializationService(client);

            var request = new StoreDetailRequest();
            var result = payout.StoreDetail(request);

            Assert.AreEqual("Success", result.ResultCode);
            Assert.AreEqual("8515136787207087", result.PspReference);
            Assert.AreEqual("8415088571022720", result.RecurringDetailReference);
        }

        [TestMethod]
        public void ConfirmThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/payout/modifyResponse-success.json");
            var payout = new ReviewingService(client);

            var request = new ModifyRequest();
            var result = payout.ConfirmThirdParty(request);

            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void SubmitThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/payout/submitResponse-success.json");
            var payout = new InitializationService(client);
            var request = new SubmitRequest();
            var result = payout.SubmitThirdParty(request);
            Assert.AreEqual("[payout-submit-received]", result.ResultCode);
            Assert.AreEqual("8815131768219992", result.PspReference);
            Assert.AreEqual("GREEN", result.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", result.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void DeclineThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/payout/modifyResponse-success.json");
            var payout = new ReviewingService(client);
            var request = new ModifyRequest();
            var result = payout.DeclineThirdParty(request);
            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/payout/payout-success.json");
            var payout = new InstantPayoutsService(client);
            var request = new PayoutRequest();
            var result = payout.Payout(request);
            Assert.AreEqual("8814689190961342", result.PspReference);
            Assert.AreEqual("12345", result.AuthCode);
        }
    }
}

