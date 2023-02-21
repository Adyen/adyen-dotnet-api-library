using Adyen.Model.StoredValue;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class StoredValueTest : BaseTest
    {
        [TestMethod]
        public void StoredValueIssueTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/storedvalue/issue-success.json");
            var service = new StoredValue(client);
            var response = service.IssuesNewCard(new StoredValueIssueRequest());
            Assert.AreEqual(response.ResultCode, StoredValueIssueResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.AuthCode, "authCode");
        }
        
        [TestMethod]
        public void StoredValueChangeStatusTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/storedvalue/changeStatus-success.json");
            var service = new StoredValue(client);
            var response = service.ChangesStatusOfPaymentMethod(new StoredValueStatusChangeRequest());
            Assert.AreEqual(response.ResultCode, StoredValueStatusChangeResponse.ResultCodeEnum.Refused);
            Assert.AreEqual(response.AuthCode, "authCode");
        }
        
        [TestMethod]
        public void StoredValueLoadTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/storedvalue/load-success.json");
            var service = new StoredValue(client);
            var response = service.LoadsPaymentMethod(new StoredValueLoadRequest());
            Assert.AreEqual(response.ResultCode, StoredValueLoadResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.AuthCode, "authCode");
        }
        
        [TestMethod]
        public void StoredValueCheckBalanceTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/storedvalue/checkBalance-success.json");
            var service = new StoredValue(client);
            var response = service.ChecksBalance(new StoredValueBalanceCheckRequest());
            Assert.AreEqual(response.ResultCode, StoredValueBalanceCheckResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.CurrentBalance.Value, 0);
        }
        
        [TestMethod]
        public void StoredValueMergeBalanceTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/storedvalue/mergeBalance-success.json");
            var service = new StoredValue(client);
            var response = service.MergeBalanceOfTwoCards(new StoredValueBalanceMergeRequest());
            Assert.AreEqual(response.ResultCode, StoredValueBalanceMergeResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.CurrentBalance.Value, 0);
        }
        
        [TestMethod]
        public void StoredValueVoidTransactionTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/storedvalue/mergeBalance-success.json");
            var service = new StoredValue(client);
            var response = service.VoidsTransactionAsync(new StoredValueVoidRequest()).Result;
            Assert.AreEqual(response.ResultCode, StoredValueVoidResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.CurrentBalance.Value, 0);
        }
    }
}