using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model.Management;
using Adyen.Service.Management;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test
{
    [TestClass]
    public class ManagementTest : BaseTest
    {
        [TestMethod]
        public void Me()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/management/me.json");
            var service = new MyAPICredentialService(client);

            var response = service.GetApiCredentialDetails();

            Assert.AreEqual("S2-6262224667", response.Id);
            Assert.IsTrue(response.Active);
            Assert.AreEqual("Management API - Users read and write", response.Roles[0]);
        }

        [TestMethod]
        public void ListMerchantAccounts()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/management/list-merchant-accounts.json");
            var service = new AccountCompanyLevelService(client);

            var response = service.ListMerchantAccounts("ABC123", 1, 10);

            Assert.AreEqual(22, response.ItemsTotal);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT_1", response.Data[0].Id);
            ClientInterfaceSubstitute.Received().RequestAsync(
                    "https://management-test.adyen.com/v3/companies/ABC123/merchants?pageNumber=1&pageSize=10", null, null,
                    HttpMethod.Get, default);
        }

        [TestMethod]
        public async Task UpdateResource()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/management/logo.json");
            var service = new TerminalSettingsCompanyLevelService(client);

            var logo = await service.UpdateTerminalLogoAsync("123ABC", "E355", new Logo("base64"));

            Assert.AreEqual("BASE-64_ENCODED_STRING_FROM_THE_REQUEST", logo.Data);
            await ClientInterfaceSubstitute.Received().RequestAsync(
                    "https://management-test.adyen.com/v3/companies/123ABC/terminalLogos?model=E355",
                    Arg.Any<string>(),
                    null,
                    new HttpMethod("PATCH"), default);
        }

        [TestMethod]
        public void ListTerminals()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/management/list-terminals.json");
            var service = new TerminalsTerminalLevelService(client);

            var terminals = service.ListTerminals(searchQuery: "ABC OR 123", pageSize: 2);

            Assert.AreEqual(2, terminals.Data.Count);
            ClientInterfaceSubstitute.Received().RequestAsync(
                    "https://management-test.adyen.com/v3/terminals?searchQuery=ABC+OR+123&pageSize=2",
                    null, null, new HttpMethod("GET"), default);
            var terminal =
                from o in terminals.Data
                where o.SerialNumber == "080-020-970"
                select o;
            Assert.AreEqual("V400m-080020970", terminal.First().Id);
        }


        public void Test()
        { var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/management/list-terminals.json");
            var service = new SplitConfigurationMerchantLevelService(client);
            service.DeleteSplitConfigurationRule("merchantId", "splitConfigurationId", "ruleId");

        }
    }
}