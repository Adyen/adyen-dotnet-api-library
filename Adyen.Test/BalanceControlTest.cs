using System;
using Adyen.Model.BalanceControl;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class BalanceControlTest : BaseTest
    {
        [TestMethod]
        public void BalanceTransferTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balance-control-transfer.json");
            var service = new BalanceControlService(client);
            var response = service.BalanceTransfer(new BalanceTransferRequest());
            Assert.AreEqual(response.CreatedAt, new DateTime(2022,01, 24, 14,59, 11));
            Assert.AreEqual(response.Status, BalanceTransferResponse.StatusEnum.Transferred);
        }
    }
}