using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.TransferLimits
{
    [TestClass]
    public class TransferLimitsBalanceAccountLevelTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public TransferLimitsBalanceAccountLevelTest()
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
        public void GetTransferLimitDeserializes()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimit.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferLimit>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(10000, response.Amount.Value);
            Assert.AreEqual("EUR", response.Amount.Currency);
            Assert.AreEqual("TRLI00000000000000000000000001", response.Id);
            Assert.AreEqual(Scope.PerTransaction, response.Scope);
            Assert.AreEqual("Your reference for the transfer limit", response.Reference);
            Assert.AreEqual(ScaStatus.Pending, response.ScaInformation.Status);
            Assert.AreEqual(LimitStatus.PendingSCA, response.LimitStatus);
            Assert.AreEqual(TransferType.All, response.TransferType);
        }
        
        [TestMethod]
        public void GetTransferLimitsListDeserializes()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimits.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferLimitListResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.TransferLimits.Count);
            
            Assert.AreEqual(10000, response.TransferLimits[0].Amount.Value);
            Assert.AreEqual("EUR", response.TransferLimits[0].Amount.Currency);
            Assert.AreEqual("TRLI00000000000000000000000001", response.TransferLimits[0].Id);
            Assert.AreEqual(Scope.PerTransaction, response.TransferLimits[0].Scope);
            Assert.AreEqual("Your reference for the transfer limit", response.TransferLimits[0].Reference);
            Assert.AreEqual(ScaExemption.InitialLimit, response.TransferLimits[0].ScaInformation.Exemption);
            Assert.AreEqual(ScaStatus.NotPerformed, response.TransferLimits[0].ScaInformation.Status);
            Assert.AreEqual(LimitStatus.Active, response.TransferLimits[0].LimitStatus);
            Assert.AreEqual(TransferType.Instant, response.TransferLimits[0].TransferType);
            
            Assert.AreEqual(20000, response.TransferLimits[1].Amount.Value);
            Assert.AreEqual("EUR", response.TransferLimits[1].Amount.Currency);
            Assert.AreEqual("TRLI00000000000000000000000002", response.TransferLimits[1].Id);
            Assert.AreEqual(Scope.PerTransaction, response.TransferLimits[1].Scope);
            Assert.AreEqual("Your reference for the transfer limit", response.TransferLimits[1].Reference);
            Assert.AreEqual(ScaExemption.InitialLimit, response.TransferLimits[1].ScaInformation.Exemption);
            Assert.AreEqual(ScaStatus.NotPerformed, response.TransferLimits[1].ScaInformation.Status);
            Assert.AreEqual(LimitStatus.Active, response.TransferLimits[1].LimitStatus);
            Assert.AreEqual(TransferType.All, response.TransferLimits[1].TransferType);
        }
    }
}
