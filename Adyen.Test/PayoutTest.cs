#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.HttpClient;
using Adyen.Model.Payouts;
using Adyen.Service;
using Adyen.Service.Payouts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.Language.Flow;

namespace Adyen.Test
{
    [TestClass]
    public class PayoutTest : BaseTest
    {
        [TestMethod]
        public void StoreDetailAndSubmitThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/payout/storeDetailAndSubmitThirdParty-success.json");
            var payout = new InitializationService(client);

            var request = new StoreDetailAndSubmitRequest();
            var result = payout.StoreDetailsAndSubmitPayout(request);

            Assert.AreEqual("[payout-submit-received]", result.ResultCode);
            Assert.AreEqual("8515131751004933", result.PspReference);
            Assert.AreEqual("GREEN", result.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", result.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void StoreDetailSuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/payout/storeDetail-success.json");
            var payout = new InitializationService(client);

            var request = new StoreDetailRequest();
            var result = payout.StorePayoutDetails(request);

            Assert.AreEqual("Success", result.ResultCode);
            Assert.AreEqual("8515136787207087", result.PspReference);
            Assert.AreEqual("8415088571022720", result.RecurringDetailReference);
        }

        [TestMethod]
        public void ConfirmThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/payout/modifyResponse-success.json");
            var payout = new ReviewingService(client);

            var request = new ModifyRequest();
            var result = payout.ConfirmPayout(request);

            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void SubmitThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/payout/submitResponse-success.json");
            var payout = new InitializationService(client);
            var request = new SubmitRequest();
            var result = payout.SubmitPayout(request);
            Assert.AreEqual("[payout-submit-received]", result.ResultCode);
            Assert.AreEqual("8815131768219992", result.PspReference);
            Assert.AreEqual("GREEN", result.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", result.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void DeclineThirdPartySuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/payout/modifyResponse-success.json");
            var payout = new ReviewingService(client);
            var request = new ModifyRequest();
            var result = payout.CancelPayout(request);
            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/payout/payout-success.json");
            var payout = new InstantPayoutsService(client);
            var request = new PayoutRequest();
            var result = payout.MakeInstantCardPayout(request);
            Assert.AreEqual("8814689190961342", result.PspReference);
            Assert.AreEqual("12345", result.AuthCode);
        }
    }
}

