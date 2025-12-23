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

namespace Adyen.Test.BalancePlatform.PaymentInstrumentGroups
{
    [TestClass]
    public class PaymentInstrumentGroupTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PaymentInstrumentGroupTest()
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
        public async Task Given_PaymentInstrumentGroup_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/PaymentInstrumentGroup.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentInstrumentGroup>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Id, "PG3227C223222B5CMD3FJFKGZ");
            Assert.AreEqual(response.BalancePlatform, "YOUR_BALANCE_PLATFORM");
        }
        
        [TestMethod]
        public async Task Given_TransactionRulesResponse_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRulesResponse.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransactionRulesResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Arrange
            Assert.AreEqual(response.TransactionRules[0].Type, TransactionRule.TypeEnum.Velocity);
            Assert.AreEqual(response.TransactionRules[0].Id, "TR3227C223222C5GXR3XP596N");
        }
    }
}