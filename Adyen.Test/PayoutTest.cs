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
//  * Copyright (c) 2019 Adyen B.V.
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
            Client client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/storeDetailAndSubmitThirdParty-success.json");
            Payout payout = new Payout(client);

            StoreDetailAndSubmitRequest request = new StoreDetailAndSubmitRequest();
            StoreDetailAndSubmitResponse result = payout.StoreDetailAndSubmitThirdParty(request);

            Assert.AreEqual("[payout-submit-received]", result.ResultCode);
            Assert.AreEqual("8515131751004933", result.PspReference);
            Assert.AreEqual("GREEN", result.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", result.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void StoreDetailSuccessTest()
        {
            Client client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/storeDetail-success.json");
            Payout payout = new Payout(client);

            StoreDetailRequest request = new StoreDetailRequest();
            StoreDetailResponse result = payout.StoreDetail(request);

            Assert.AreEqual("Success", result.ResultCode);
            Assert.AreEqual("8515136787207087", result.PspReference);
            Assert.AreEqual("8415088571022720", result.RecurringDetailReference);
        }

        [TestMethod]
        public void ConfirmThirdPartySuccessTest()
        {
            Client client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/modifyResponse-success.json");
            Payout payout = new Payout(client);

            ConfirmThirdPartyRequest request = new ConfirmThirdPartyRequest();
            ConfirmThirdPartyResponse result = payout.ConfirmThirdParty(request);

            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void SubmitThirdPartySuccessTest()
        {
            Client client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/submitResponse-success.json");
            Payout payout = new Payout(client);
            SubmitRequest request = new SubmitRequest();
            SubmitResponse result = payout.SubmitThirdParty(request);
            Assert.AreEqual("[payout-submit-received]", result.ResultCode);
            Assert.AreEqual("8815131768219992", result.PspReference);
            Assert.AreEqual("GREEN", result.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", result.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void DeclineThirdPartySuccessTest()
        {
            Client client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/modifyResponse-success.json");
            Payout payout = new Payout(client);
            DeclineThirdPartyRequest request = new DeclineThirdPartyRequest();
            DeclineThirdPartyResponse result = payout.DeclineThirdParty(request);
            Assert.AreEqual("[payout-confirm-received]", result.Response);
            Assert.AreEqual("8815131762537886", result.PspReference);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            Client client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/payout/payout-success.json");
            Payout payout = new Payout(client);
            PayoutRequest request = new PayoutRequest();
            PayoutResponse result = payout.PayoutSubmit(request);
            Assert.AreEqual("8814689190961342", result.PspReference);
            Assert.AreEqual("12345", result.AuthCode);
        }

        [TestMethod]
        public void PayoutErrorMerchantTest()
        {
            Client client = CreateMockTestClientForErrors(403, "Mocks/payout/payout-error-403.json");
            Payout payout = new Payout(client);
            PayoutRequest request = new PayoutRequest();
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
            Client client = CreateMockTestClientForErrors(422, "Mocks/payout/payout-error-422.json");
            Payout payout = new Payout(client);
            PayoutRequest request = new PayoutRequest();
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

