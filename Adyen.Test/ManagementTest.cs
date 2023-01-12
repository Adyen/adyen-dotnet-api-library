using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Management;
using Adyen.Service.Management;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Adyen.Test
{
    [TestClass]
    public class ManagementTest : BaseTest
    {
        [TestMethod]
        public void Me()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/management/me.json");
            var service = new MyAPICredentialApi(client);

            var response = service.GetMe();

            Assert.AreEqual("S2-6262224667", response.Id);
            Assert.IsTrue(response.Active);
            Assert.AreEqual("Management API - Users read and write", response.Roles[0]);
        }

        [TestMethod]
        public void ListMerchantAccounts()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/management/list-merchant-accounts.json");
            var service = new AccountCompanyLevelApi(client);

            var response = service.GetCompaniesCompanyIdMerchants("ABC123", new RequestOptions
            {
                QueryParameters = new Dictionary<string, string>
                {
                    { "pageNumber", "1" },
                    { "pageSize", "10" }
                }
            });

            Assert.AreEqual(22, response.ItemsTotal);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT_1", response.Data[0].Id);
            ClientInterfaceMock.Verify(mock =>
                mock.Request("/v1/companies/ABC123/merchants?pageNumber=1&pageSize=10", null, null,
                    HttpMethod.Get));
        }

        [TestMethod]
        public async Task UpdateResource()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/management/logo.json");
            var service = new TerminalSettingsCompanyLevelApi(client);

            var requestOptions = new RequestOptions
            {
                QueryParameters = new Dictionary<string, string>
                {
                    { "model", "E355" }
                }
            };
            var logo = await service.PatchCompaniesCompanyIdTerminalLogosAsync("123ABC", new Logo("base64"),
                requestOptions);

            Assert.AreEqual("BASE-64_ENCODED_STRING_FROM_THE_REQUEST", logo.Data);
            ClientInterfaceMock.Verify(mock =>
                mock.RequestAsync("/v1/companies/123ABC/terminalLogos?model=E355",
                    It.IsRegex(@"""data"": ""base64"""),
                    null,
                    new HttpMethod("PATCH")));
        }

        [TestMethod]
        public void ListTerminals()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/management/list-terminals.json");
            var service = new TerminalsTerminalLevelApi(client);

            var terminals = service.GetTerminals(new RequestOptions
            {
                QueryParameters = new Dictionary<string, string>
                {
                    { "searchQuery", "ABC OR 123" },
                    { "pageSize", "2" },
                }
            });

            Assert.AreEqual(2, terminals.Data.Count);
            ClientInterfaceMock.Verify(mock =>
                mock.Request("/v1/terminals?searchQuery=ABC+OR+123&pageSize=2",
                    null, null, new HttpMethod("GET")));
            var terminal =
                from o in terminals.Data
                where o.SerialNumber == "080-020-970" && o.Status == "onlineLast1Day"
                select o;
            Assert.AreEqual("6064364710330000000", terminal.First().Iccid);
        }
    }
}