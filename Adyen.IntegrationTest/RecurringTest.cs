using System;
using Adyen.Model.Recurring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static Adyen.Model.Recurring.Recurring;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class RecurringTest : BaseTest
    {

        [TestMethod]
        public void TestListRecurringDetails()
        {
            var paymentResult = base.CreatePaymentResultWithRecurring(Model.Payments.Recurring.ContractEnum.RECURRING);
            var client = CreateApiKeyTestClient();
            var recurring = new Service.Recurring(client);
            var recurringDetailsRequest = this.CreateRecurringDetailsRequest();
            var recurringDetailsResult = recurring.ListRecurringDetails(recurringDetailsRequest);
            var recurringDetail = recurringDetailsResult.Details[0].RecurringDetail;
            Assert.AreEqual(recurringDetail.PaymentMethodVariant, "visa");
        }

        [TestMethod]
        public void TestDisable()
        {
            var paymentResult = base.CreatePaymentResultWithRecurring(Model.Payments.Recurring.ContractEnum.ONECLICK);
            var client = CreateApiKeyTestClient();
            var recurring = new Service.Recurring(client);
            var disableRequest = this.CreateDisableRequest();
            var disableResult = recurring.Disable(disableRequest);
            Assert.AreEqual("[all-details-successfully-disabled]", disableResult.Response);
        }
       
        private RecurringDetailsRequest CreateRecurringDetailsRequest()
        {
            var request = new RecurringDetailsRequest
            {
                ShopperReference = "test-1234",
                MerchantAccount = ClientConstants.MerchantAccount,
                Recurring = new Recurring { Contract = ContractEnum.RECURRING }
            };
            return request;
        }

        private DisableRequest CreateDisableRequest()
        {
            var request = new DisableRequest
            {
                ShopperReference = "test-1234",
                MerchantAccount = ClientConstants.MerchantAccount
            };
            return request;
        }
    }
}
