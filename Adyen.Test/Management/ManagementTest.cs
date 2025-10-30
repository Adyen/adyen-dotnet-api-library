using Adyen.Core.Options;
using Adyen.Management.Client;
using Adyen.Management.Extensions;
using Adyen.Management.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.Management
{
    [TestClass]
    public class ManagementTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        
        public ManagementTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureManagement((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public void Given_Deserialize_When_MeApiCredential_Result_Return_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/me.json");
         
            // Act
            var response = JsonSerializer.Deserialize<MeApiCredential>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("S2-6262224667", response.Id);
            Assert.IsTrue(response.Active);
            Assert.AreEqual("Management API - Users read and write", response.Roles[0]);
        }

        [TestMethod]
        public void Given_Deserialize_When_ListMerchantResponse_Returns_Correct_Data()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/list-merchant-accounts.json");

            // Act
            var response = JsonSerializer.Deserialize<ListMerchantResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(22, response.ItemsTotal);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT_1", response.Data[0].Id);
        }

        [TestMethod]
        public async Task Given_Deserialize_When_UpdateResource_Returns_Data_String()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/logo.json");
            
            // Act
            var response = JsonSerializer.Deserialize<Logo>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("BASE-64_ENCODED_STRING_FROM_THE_REQUEST", response.Data);
        }

        [TestMethod]
        public void Given_Deserialize_When_ListTerminalsResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/list-terminals.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ListTerminalsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(2, response.Data.Count);
            Assert.AreEqual("V400m-080020970", response.Data.First(o => o.SerialNumber == "080-020-970").Id);
        }
    }
}