using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test.BalancePlatform.BalanceAccounts
{
    [TestClass]
    public class BalanceAccountTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BalanceAccountTest()
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
        public async Task Given_BalanceAccounts_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccount.json");
        
            // Act
            var response = JsonSerializer.Deserialize<BalanceAccount>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222H5J4DCGQ9V9L");
        }
        
        [TestMethod]
        public async Task Given_SweepConfigurationV2_Deserialize_Correctly()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/SweepConfiguration.json");
            
            // Act
            var response = JsonSerializer.Deserialize<SweepConfigurationV2>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Type, SweepConfigurationV2.TypeEnum.Pull);
            Assert.AreEqual(response.Id, "SWPC4227C224555B5FTD2NT2JV4WN5");
        }
        
        [TestMethod]
        public async Task Given_BalanceSweepConfigurationsResponse_Deserialize_Correctly()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceSweepConfigurationsResponse.json");
            
            // Act
            var response = JsonSerializer.Deserialize<BalanceSweepConfigurationsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Sweeps[0].Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Sweeps[0].Id, "SWPC4227C224555B5FTD2NT2JV4WN5");
            Assert.AreEqual(response.Sweeps[0].Schedule.Type, SweepSchedule.TypeEnum.Daily);
        }
        
        [TestMethod]
        public async Task Given_UpdateSweepConfigurationV2_Deserialize_Correctly()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/SweepConfiguration.json");
            
            // Act
            var response = JsonSerializer.Deserialize<SweepConfigurationV2>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Type, SweepConfigurationV2.TypeEnum.Pull);
            Assert.AreEqual(response.Id, "SWPC4227C224555B5FTD2NT2JV4WN5");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_PaginatedPaymentInstrumentsResponse_Returns_Correct_Object()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedPaymentInstrumentsResponse.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaginatedPaymentInstrumentsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.PaymentInstruments[0].Status, PaymentInstrument.StatusEnum.Active);
            Assert.AreEqual(response.PaymentInstruments[0].Id, "PI32272223222B59M5TM658DT");
        }
    }
}