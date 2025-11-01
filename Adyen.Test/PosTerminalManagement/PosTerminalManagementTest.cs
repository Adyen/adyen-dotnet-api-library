using Adyen.Core.Options;
using Adyen.PosTerminalManagement.Client;
using Adyen.PosTerminalManagement.Models;
using Adyen.PosTerminalManagement.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.PosTerminalManagement
{
    [TestClass]
    public class PosTerminalManagementTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PosTerminalManagementTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePosTerminalManagement((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public async Task Given_Deserialize_When_FindTerminal_Result_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/pos-terminal-management/find-terminals-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<FindTerminalResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.Terminal, "V400m-123456789");
            Assert.AreEqual(response.CompanyAccount, "TestCompany");
            Assert.AreEqual(response.MerchantAccount, "TestMerchant");
            Assert.AreEqual(response.Store, "MyStore");
            Assert.AreEqual(response.MerchantInventory, false);
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_AssignTerminals_Result_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/pos-terminal-management/assigning-terminals-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<AssignTerminalsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.Results["V400m-123456789"], "ActionScheduled");
            Assert.AreEqual(response.Results["P400Plus-123456789"], "Done");
        }

        [TestMethod]
        public async Task Given_Deserialize_When_GetTerminalsUnderAccount_Result_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/pos-terminal-management/get-terminals-under-account-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<GetTerminalsUnderAccountResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.CompanyAccount, "TestCompany");
            Assert.AreEqual(response.MerchantAccounts[0].VarMerchantAccount, "TestMerchantPOS_EU");
            Assert.AreEqual(response.MerchantAccounts[1].VarMerchantAccount, "TestMerchantPOS_US");
            Assert.AreEqual(response.InventoryTerminals[0], "V400m-123456789");
            Assert.AreEqual(response.InventoryTerminals[1], "P400Plus-123456789");
            Assert.AreEqual(response.MerchantAccounts[0].VarMerchantAccount, "TestMerchantPOS_EU");
            Assert.AreEqual(response.MerchantAccounts[0].InventoryTerminals[0], "M400-123456789");
            Assert.AreEqual(response.MerchantAccounts[0].InventoryTerminals[1], "VX820-123456789");
            Assert.AreEqual(response.MerchantAccounts[0].InStoreTerminals[0], "E355-123456789");
            Assert.AreEqual(response.MerchantAccounts[0].InStoreTerminals[1], "V240mPlus-123456789");
            Assert.AreEqual(response.MerchantAccounts[0].Stores[0].VarStore, "TestStore");
            Assert.AreEqual(response.MerchantAccounts[0].Stores[0].InStoreTerminals[0], "MX925-123456789");
            Assert.AreEqual(response.MerchantAccounts[1].InStoreTerminals[0], "VX820-123456789");
            Assert.AreEqual(response.MerchantAccounts[1].InStoreTerminals[1], "VX690-123456789");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_GetTerminalDetails_Result_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/pos-terminal-management/get-terminal-details-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<GetTerminalDetailsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.CompanyAccount, "YOUR_COMPANY_ACCOUNT");
            Assert.AreEqual(response.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(response.MerchantInventory, false);
            Assert.AreEqual(response.Terminal, "P400Plus-275479597");
            Assert.AreEqual(response.DeviceModel, "P400Plus");
            Assert.AreEqual(response.SerialNumber, "275-479-597");
            Assert.AreEqual(response.PermanentTerminalId, "12000000");
            Assert.AreEqual(response.FirmwareVersion, "Verifone_VOS 1.50.7");
            Assert.AreEqual(response.TerminalStatus, GetTerminalDetailsResponse.TerminalStatusEnum.ReAssignToInventoryPending);
            Assert.AreEqual(response.Country, "NETHERLANDS");
            Assert.AreEqual(response.DhcpEnabled, false);
        }

        [TestMethod]
        public async Task Given_Deserialize_When_GetStoresUnderAccount_Result_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/pos-terminal-management/get-stores-under-account-success.json");
            
            // Act
            var response =JsonSerializer.Deserialize<GetStoresUnderAccountResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Stores[0].MerchantAccountCode, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(response.Stores[0].VarStore, "YOUR_STORE");
            Assert.AreEqual(response.Stores[0].Description, "YOUR_STORE");
            Assert.AreEqual(response.Stores[0].Status, "Active");
        }
    }
}
