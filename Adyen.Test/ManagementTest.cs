using Adyen.Service.Management;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class ManagementTest : BaseTest
    {
        [TestMethod]
        public void Me()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/management/me.json");
            var service = new MyAPICredentialApi(client);
            var response = service.GetMe();

            Assert.AreEqual("S2-6262224667", response.Id);
            Assert.IsTrue(response.Active);
            Assert.AreEqual("Management API - Users read and write", response.Roles[0]);
        }
    }
}