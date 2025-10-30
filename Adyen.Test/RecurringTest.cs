using System.Threading.Tasks;
using Adyen.Model.Recurring;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class RecurringTest : BaseTest
    {

        [TestMethod]
        public void TestListRecurringDetails()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/listRecurringDetails-success.json");
            var recurring = new Service.RecurringService(client);
            var recurringDetailsRequest = CreateRecurringDetailsRequest();
            var recurringDetailsResult = recurring.ListRecurringDetails(recurringDetailsRequest);
            Assert.AreEqual(3L, recurringDetailsResult.Details.Count);
            var recurringDetail = recurringDetailsResult.Details[0].RecurringDetail;

            Assert.AreEqual("BFXCHLC5L6KXWD82", recurringDetail.RecurringDetailReference);
            Assert.AreEqual("K652534298119846", recurringDetail.Alias);
            Assert.AreEqual("0002", recurringDetail.Card.Number);
        }

        [TestMethod]
        public async Task TestListRecurringDetailsAsync()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/listRecurringDetails-success.json");
            var recurring = new Service.RecurringService(client);
            var recurringDetailsRequest = CreateRecurringDetailsRequest();
            var recurringDetailsResult = await recurring.ListRecurringDetailsAsync(recurringDetailsRequest);
            Assert.AreEqual(3L, recurringDetailsResult.Details.Count);
            var recurringDetail = recurringDetailsResult.Details[1].RecurringDetail;
            Assert.AreEqual("JW6RTP5PL6KXWD82", recurringDetail.RecurringDetailReference);
            Assert.AreEqual("Wirecard", recurringDetail.Bank.BankName);
            Assert.AreEqual("sepadirectdebit", recurringDetail.Variant);
        }

        [TestMethod]
        public void TestDisable()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/disable-success.json");
            var recurring = new Service.RecurringService(client);
            var disableRequest = CreateDisableRequest();
            var disableResult = recurring.Disable(disableRequest);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }

        [TestMethod]
        public async Task TestDisableAsync()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/disable-success.json");
            var recurring = new Service.RecurringService(client);
            var disableRequest = CreateDisableRequest();
            var disableResult = await recurring.DisableAsync(disableRequest);
            Assert.AreEqual("[detail-successfully-disabled]", disableResult.Response);
        }
        
        [TestMethod]
        public void NotifyShopperTest()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/notifyShopper-success.json");
            var recurring = new Service.RecurringService(client);
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
        
        [TestMethod]
        public void CreatePermitTest()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/createPermit-success.json");
            var recurring = new Service.RecurringService(client);
            var createPermitResult = recurring.CreatePermit(new CreatePermitRequest());
            Assert.IsNotNull(createPermitResult);
            Assert.AreEqual("string", createPermitResult.PspReference);
            Assert.AreEqual(1,createPermitResult.PermitResultList.Count);
        }
        
        [TestMethod]
        public void DisablePermitTest()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/disablePermit-success.json");
            var recurring = new Service.RecurringService(client);
            var disablePermitResult = recurring.DisablePermit(new DisablePermitRequest());
            Assert.IsNotNull(disablePermitResult);
            Assert.AreEqual("string", disablePermitResult.PspReference);
            Assert.AreEqual("disabled",disablePermitResult.Status);
        }
        
        [TestMethod]
        public void ScheduleAccountUpdaterTest()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/recurring/scheduleAccountUpdater-success.json");
            var recurring = new Service.RecurringService(client);
            var scheduleAccountUpdaterResult = recurring.ScheduleAccountUpdater(new ScheduleAccountUpdaterRequest());
            Assert.IsNotNull(scheduleAccountUpdaterResult);
            Assert.AreEqual("string", scheduleAccountUpdaterResult.PspReference);
            Assert.AreEqual("string",scheduleAccountUpdaterResult.Result);
        }
        
        private RecurringDetailsRequest CreateRecurringDetailsRequest()
        {
            var request = new RecurringDetailsRequest 
            {
                ShopperReference = "test-123",
                MerchantAccount = "DotNetAlexandros",
                Recurring = new Model.Recurring.Recurring(Model.Recurring.Recurring.ContractEnum.RECURRING)
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
