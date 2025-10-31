using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform
{
    [TestClass]
    public class BalancePlatformTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BalancePlatformTest()
        {
            IHost host = Host.CreateDefaultBuilder()
            .ConfigureBalancePlatform((context, services, config) =>
            {
                config.ConfigureAdyenOptions(options =>
                {
                    options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                    options.Environment = AdyenEnvironment.Test;
                });
            })
            .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public async Task Given_BalancePlatform_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/BalancePlatform.json");
            
            // Act
            var response = JsonSerializer.Deserialize<Adyen.BalancePlatform.Models.BalancePlatform>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Status, "Active");
            Assert.AreEqual(response.Id, "YOUR_BALANCE_PLATFORM");
        }
        
        [TestMethod]
        public async Task Given_PaginatedAccountHoldersResponse_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedBalanceAccountsResponse.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaginatedBalanceAccountsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("BA32272223222B5CTDNB66W2Z", response.BalanceAccounts[0].Id);
            Assert.AreEqual(BalanceAccountBase.StatusEnum.Active, response.BalanceAccounts[1].Status);
        }
    }
}