using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.AccountHolders
{
    [TestClass]
    public class AccountHolderTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public AccountHolderTest()
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
        public async Task Given_AccountHolder_When_Unknown_Enum_Then_Result_Deserialize_To_Null()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/AccountHolderWithUnknownEnum.json");
            
            // Act
            var response = JsonSerializer.Deserialize<AccountHolder>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response);
            Assert.IsNull(response.Status);
        }
        
        [TestMethod]
        public async Task Given_AccountHolder_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/AccountHolder.json");
            
            // Act
            var response = JsonSerializer.Deserialize<AccountHolder>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        [TestMethod]
        public async Task Given_PaginatedBalanceAccountsResponse_Deserialize_Correctly()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedAccountHoldersResponse.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaginatedAccountHoldersResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.AccountHolders[0].Id, "AH32272223222B5GFSNSXFFL9");
            Assert.AreEqual(response.AccountHolders[0].Status, AccountHolder.StatusEnum.Active);
        }

        [TestMethod]
        public async Task Given_IAccountHolderService_When_Live_Url_And_Prefix_Are_Set_Returns_Correct_Live_Url_Endpoint_And_No_Prefix()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "your-live-api-key";
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                })
                .Build();
            
            // Act
            var accountHoldersService = liveHost.Services.GetRequiredService<IAccountHoldersService>();

            // Assert
            Assert.AreEqual("https://balanceplatform-api-live.adyen.com/bcl/v2", accountHoldersService.HttpClient.BaseAddress.ToString());
        }
    }
}