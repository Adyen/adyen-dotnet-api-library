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
using Adyen.HttpClient;

namespace Adyen.Test
{
    [TestClass]
    public class RecurringTest : BaseTest
    {

        [TestMethod]
        public void TestListRecurringDetails()
        {
            Client client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/listRecurringDetails-success.json");
            Service.Recurring recurring = new Service.Recurring(client);
            RecurringDetailsRequest recurringDetailsRequest = this.CreateRecurringDetailsRequest();
            RecurringDetailsResult recurringDetailsResult = recurring.ListRecurringDetails(recurringDetailsRequest);
            Assert.AreEqual(1L, (long)recurringDetailsResult.Details.Count);
            RecurringDetail recurringDetail = recurringDetailsResult.Details[0].RecurringDetail;
            Assert.AreEqual("recurringReference", recurringDetail.RecurringDetailReference);
            Assert.AreEqual("cardAlias", recurringDetail.Alias);
            Assert.AreEqual("1111", recurringDetail.Card.Number);
        }

        [TestMethod]
        public async Task TestListRecurringDetailsAsync()
        {
            Client client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/listRecurringDetails-success.json");
            Service.Recurring recurring = new Service.Recurring(client);
            RecurringDetailsRequest recurringDetailsRequest = this.CreateRecurringDetailsRequest();
            RecurringDetailsResult recurringDetailsResult = await recurring.ListRecurringDetailsAsync(recurringDetailsRequest);
            Assert.AreEqual(1L, (long)recurringDetailsResult.Details.Count);
            RecurringDetail recurringDetail = recurringDetailsResult.Details[0].RecurringDetail;
            Assert.AreEqual("recurringReference", recurringDetail.RecurringDetailReference);
            Assert.AreEqual("cardAlias", recurringDetail.Alias);
            Assert.AreEqual("1111", recurringDetail.Card.Number);
        }

        [TestMethod]
        public void TestDisable()
        {
            Client client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/disable-success.json");
            Service.Recurring recurring = new Service.Recurring(client);
            DisableRequest disableRequest = this.CreateDisableRequest();
            DisableResult disableResult = recurring.Disable(disableRequest);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }

        [TestMethod]
        public async Task TestDisableAsync()
        {
            Client client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/disable-success.json");
            Service.Recurring recurring = new Service.Recurring(client);
            DisableRequest disableRequest = this.CreateDisableRequest();
            DisableResult disableResult = await recurring.DisableAsync(disableRequest);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }

        [TestMethod]
        public void TestDisable803()
        {
            try
            {
                Client client = base.CreateMockTestClientForErrors(422, "Mocks/recurring/disable-error-803.json");
                Service.Recurring recurring = new Service.Recurring(client);
                DisableRequest disableRequest = this.CreateDisableRequest();

                DisableResult disableResult = recurring.Disable(disableRequest);
                Assert.Fail("Exception expected!");
            }
            catch (HttpClientException exception)
            {
                Assert.AreEqual(422, exception.Code);

            }

        }

        [TestMethod]
        public void NotifyShopperTest()
        {
            Client client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/notifyShopper-success.json");
            Service.Recurring recurring = new Service.Recurring(client);
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
            RecurringDetailsRequest request = new RecurringDetailsRequest
            {
                ShopperReference = "test-123",
                MerchantAccount = "DotNetAlexandros"
            };
            return request;
        }

        private DisableRequest CreateDisableRequest()
        {
            DisableRequest request = new DisableRequest
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
