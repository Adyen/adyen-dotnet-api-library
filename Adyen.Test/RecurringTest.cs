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
using Adyen.HttpClient;
using Adyen.Model.Enum;
using Adyen.Model.Recurring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Recurring = Adyen.Model.Recurring.Recurring;

namespace Adyen.Test
{
    [TestClass]
    public class RecurringTest:BaseTest
    {

        [TestMethod]
        public void TestListRecurringDetails()
        {
            var client = base.CreateMockTestClientNullRequiredFieldsRequest("Mocks/recurring/listRecurringDetails-success.json");
            var recurring=new Service.Recurring(client);
            var recurringDetailsRequest = this.CreateRecurringDetailsRequest();
            var recurringDetailsResult = recurring.ListRecurringDetails(recurringDetailsRequest);
            Assert.AreEqual(1L, (long)recurringDetailsResult.Details.Count);
            var recurringDetail = recurringDetailsResult.Details.FirstOrDefault().RecurringDetail;
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
            Assert.AreEqual(1L, (long)disableResult.Details.Count);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }



        [TestMethod]
        public void TestDisable803()
        {
            try
            {
                var client = base.CreateMockTestClientForErrors(422,"Mocks/recurring/disable-error-803.json");
                var recurring = new Service.Recurring(client);
                var disableRequest = this.CreateDisableRequest();

                var disableResult = recurring.Disable(disableRequest);
                Assert.Fail("Exception expected!");
            }
            catch (Exception exception)
            {
                Assert.AreNotEqual(200, exception);
             
            }
           
        }

        private RecurringDetailsRequest CreateRecurringDetailsRequest()
        {
            var request = new RecurringDetailsRequest
            {
                ShopperReference = "test-123",
                MerchantAccount = "DotNetAlexandros",
                Recurring = new Recurring { Contract = Contract.Oneclick }
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

    }
}
