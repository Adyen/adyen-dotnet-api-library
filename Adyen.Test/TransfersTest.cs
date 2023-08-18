using System;
using Adyen.Model.Transfers;
using Adyen.Service.Transfers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class TransfersTest : BaseTest
    {
        [TestMethod]
        public void GetAllTransactionsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/transfers/get-all-transactions.json");
            var service = new TransactionsService(client);
            var response = service.GetAllTransactions(new DateTime(), new DateTime(), balancePlatform:"balance", accountHolderId:"id");
            Assert.AreEqual(response.Links.Next.Href, "https://balanceplatform-api-test.adyen.com/btl/v2/transactions?balancePlatform=Bastronaut&createdUntil=2022-03-21T00%3A00%3A00Z&createdSince=2022-03-11T00%3A00%3A00Z&limit=3&cursor=S2B-TSAjOkIrYlIlbjdqe0RreHRyM32lKRSxubXBHRkhHL2E32XitQQz5SfzpucD5HbHwpM1p6NDR1eXVQLFF6MmY33J32sobDxQYT90MHIud1hwLnd6JitcX32xJ");
        }
        
        [TestMethod]
        public void GetSpecificTransactionTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/transfers/get-transaction.json");
            var service = new TransactionsService(client);
            var response = service.GetTransaction("id");
            Assert.AreEqual(response.Status, Transaction.StatusEnum.Booked);
        }
        
        [TestMethod]
        public void PostTransferFundsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/transfers/transfer-funds.json");
            var service = new TransfersService(client);
            var response = service.TransferFunds(new TransferInfo());
            Assert.AreEqual(response.Status, Transfer.StatusEnum.Authorised);
            Assert.AreEqual(response.Category, Transfer.CategoryEnum.Bank);
        }
    }
}