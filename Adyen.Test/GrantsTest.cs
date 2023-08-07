
using Adyen.Model.Transfers;
using Adyen.Service.Transfers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    public class GrantsTest : BaseTest
    {
        [TestMethod]
        public void StoredValueIssueTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/grants/post-grants-success.json");
            var service = new CapitalService(client);
            var response = service.RequestGrantPayout(new CapitalGrantInfo());
            Assert.AreEqual(response.Id, "CG00000000000000000000001");
            Assert.AreEqual(response.GrantAccountId, "CG00000000000000000000001");
            Assert.AreEqual(response.Status, CapitalGrant.StatusEnum.Pending);
            Assert.IsNotNull(response.Balances);
        }
    }
}