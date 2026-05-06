using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.Balances
{
    [TestClass]
    public class BalancesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BalancesTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
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
        public void Given_BalanceWebhookSettingInfoUpdate_When_Serialized_Then_PaymentInstrumentId_Is_Present()
        {
            // Arrange
            var update = new BalanceWebhookSettingInfoUpdate { Status = BalanceWebhookSettingInfoUpdate.StatusEnum.Active };

            // Act
            string result = JsonSerializer.Serialize(update, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            Assert.IsTrue(json.RootElement.TryGetProperty("status", out _),
                "status must be present in the serialized output when set");
        }
    }
}
