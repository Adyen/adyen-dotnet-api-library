using Adyen.BalanceControl.Client;
using Adyen.BalanceControl.Extensions;
using Adyen.BalanceControl.Models;
using Adyen.BalanceControl.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.BalanceControl
{
    [TestClass]
    public class BalanceControlTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BalanceControlTest()
        {  
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalanceControl((context, services, config) =>
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
        public async Task DeserializeBalanceControlTest()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balance-control-transfer.json");
            
            // Act
            var response = JsonSerializer.Deserialize<BalanceTransferResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.CreatedAt, new DateTime(2022,01, 24));
            Assert.AreEqual(response.Status, BalanceTransferResponse.StatusEnum.Transferred);
        }
        
        [TestMethod]
        public void Given_IBalanceControlService_When_Live_Url_And_Prefix_Are_Set_Returns_Correct_Live_Url_Endpoint()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureBalanceControl((context, services, config) =>
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
            var balanceControlService = liveHost.Services.GetRequiredService<IBalanceControlService>();

            // Assert
            Assert.AreEqual("https://prefix-pal-live.adyenpayments.com/pal/servlet/BalanceControl/v1", balanceControlService.HttpClient.BaseAddress.ToString()); 
        }

    }
}