using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.BalanceControl.Client;
using Adyen.BalanceControl.Extensions;
using Adyen.BalanceControl.Models;
using Adyen.BalanceControl.Services;
using Adyen.Core.Auth;
using Adyen.Core.Options;
using Adyen.Test.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalanceControl
{
    [TestClass]
    public class BalanceControlTest
    {
        private readonly IBalanceControlService _balanceControlService;
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BalanceControlTest()
        {  IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalanceControl((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _balanceControlService = host.Services.GetRequiredService<IBalanceControlService>();
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
    }
}