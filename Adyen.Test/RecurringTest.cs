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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using Adyen.Model.Enum;
using Adyen.Model.Recurring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recurring = Adyen.Model.Recurring.Recurring;
using System.Threading.Tasks;

namespace Adyen.Test
{
    [TestClass]
    public class RecurringTest : BaseTest
    {

        [TestMethod]
        public void TestListRecurringDetails()
        {
            var client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/listRecurringDetails-success.json");
            var recurring = new Service.Recurring(client);
            var recurringDetailsRequest = this.CreateRecurringDetailsRequest();
            var recurringDetailsResult = recurring.ListRecurringDetails(recurringDetailsRequest);
            Assert.AreEqual(1L, (long)recurringDetailsResult.Details.Count);
            var recurringDetail = recurringDetailsResult.Details[0].RecurringDetail;
            Assert.AreEqual("recurringReference", recurringDetail.RecurringDetailReference);
            Assert.AreEqual("cardAlias", recurringDetail.Alias);
            Assert.AreEqual("1111", recurringDetail.Card.Number);
        }

        [TestMethod]
        public async Task TestListRecurringDetailsAsync()
        {
            var client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/listRecurringDetails-success.json");
            var recurring = new Service.Recurring(client);
            var recurringDetailsRequest = this.CreateRecurringDetailsRequest();
            var recurringDetailsResult = await recurring.ListRecurringDetailsAsync(recurringDetailsRequest);
            Assert.AreEqual(1L, (long)recurringDetailsResult.Details.Count);
            var recurringDetail = recurringDetailsResult.Details[0].RecurringDetail;
            Assert.AreEqual("recurringReference", recurringDetail.RecurringDetailReference);
            Assert.AreEqual("cardAlias", recurringDetail.Alias);
            Assert.AreEqual("1111", recurringDetail.Card.Number);
        }

        [TestMethod]
        public void TestDisable()
        {
            var client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/disable-success.json");
            var recurring = new Service.Recurring(client);
            var disableRequest = this.CreateDisableRequest();
            var disableResult = recurring.Disable(disableRequest);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }

        [TestMethod]
        public async Task TestDisableAsync()
        {
            var client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/disable-success.json");
            var recurring = new Service.Recurring(client);
            var disableRequest = this.CreateDisableRequest();
            var disableResult = await recurring.DisableAsync(disableRequest);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }

        [TestMethod]
        public void TestDisable803()
        {
            try
            {
                var client = base.CreateMockTestClientForErrors(422, "Mocks/recurring/disable-error-803.json");
                var recurring = new Service.Recurring(client);
                var disableRequest = this.CreateDisableRequest();

                var disableResult = recurring.Disable(disableRequest);
                Assert.Fail("Exception expected!");
            }
            catch (Exception exception)
            {
                Assert.AreNotEqual<int>(200, exception.GetHashCode());

            }

        }

        [TestMethod]
        public void NotifyShopperTest()
        {
            Client client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/notifyShopper-success.json");
            var recurring = new Service.Recurring(client);
            NotifyShopperRequest request = CreateNotifyShopperRequest();
            NotifyShopperResult result = recurring.NotifyShopper(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("Example displayed reference", result.DisplayedReference);
            Assert.AreEqual("8516167336214570", result.PspReference);
            Assert.AreEqual("Request processed successfully", result.Message);
            Assert.AreEqual("Example reference", result.Reference);
            Assert.AreEqual("Success", result.ResultCode);
            Assert.AreEqual("IA0F7500002462", result.ShopperNotificationReference);
        }

        private RecurringDetailsRequest CreateRecurringDetailsRequest()
        {
            var request = new RecurringDetailsRequest
            {
                ShopperReference = "test-123",
                MerchantAccount = "DotNetAlexandros"
            };
            return request;
        }

        private DisableRequest CreateDisableRequest()
        {
            var request = new DisableRequest
            {
                ShopperReference = "test-123",
                MerchantAccount = "DotNetAlexandros"
            };
            return request;
        }

        private NotifyShopperRequest CreateNotifyShopperRequest()
        {
            return new NotifyShopperRequest
            {
                MerchantAccount = "TestMerchant",
                RecurringDetailReference = "8316158654144897",
                Reference = "Example reference",
                ShopperReference = "1234567",
                BillingDate = "2021-03-31",
                DisplayedReference = "Example displayed reference"
            };
        }
    }
}
