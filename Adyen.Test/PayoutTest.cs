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

using Adyen.Model.Payout;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class PayoutTest : BaseTest
    {
        [TestMethod]
        public void StoreDetailAndSubmitThirdPartySuccessTest()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/storeDetailAndSubmitThirdParty-success.json");
            var payout = new Payout(client);

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
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/storeDetail-success.json");
            var payout = new Payout(client);

            var request = new StoreDetailRequest();
            var result = payout.StoreDetail(request);

            Assert.AreEqual("Success", result.ResultCode);
            Assert.AreEqual("8515136787207087", result.PspReference);
            Assert.AreEqual("8415088571022720", result.RecurringDetailReference);
        }

        [TestMethod]
        public void ConfirmThirdPartySuccessTest()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/modifyResponse-success.json");
            var payout = new Payout(client);

            var request = new ModifyRequest();
            var result = payout.ConfirmThirdParty(request);

            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void SubmitThirdPartySuccessTest()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/submitResponse-success.json");
            var payout = new Payout(client);
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
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/modifyResponse-success.json");
            var payout = new Payout(client);
            var request = new ModifyRequest();
            var result = payout.DeclineThirdParty(request);
            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/payout-success.json");
            var payout = new Payout(client);
            var request = new PayoutRequest();
            var result = payout.PayoutSubmit(request);
            Assert.AreEqual("8814689190961342", result.PspReference);
            Assert.AreEqual("12345", result.AuthCode);
        }
        
        [TestMethod]
        public void PayoutErrorMerchantTest()
        {
            var client = CreateAsyncMockTestClientForErrors(403, "Mocks/payout/payout-error-403.json");
            var payout = new Payout(client);
            var request = new PayoutRequest();
            try
            {
                payout.PayoutSubmit(request);
            }
            catch (HttpClient.HttpClientException e)
            {
                Assert.IsNotNull(e.ResponseBody);
                Assert.AreEqual(403, e.Code);
            }
        }

        [TestMethod]
        public void PayoutErrorReferenceTest()
        {
            var client = CreateAsyncMockTestClientForErrors(422, "Mocks/payout/payout-error-422.json");
            var payout = new Payout(client);
            var request = new PayoutRequest();
            try
            {
                payout.PayoutSubmit(request);
            }
            catch (HttpClient.HttpClientException e)
            {
                Assert.IsNotNull(e.ResponseBody);
                Assert.AreEqual(422, e.Code);
            }
        }
    }
}

