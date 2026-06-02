using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.ManagedPayoutSchedules
{
    [TestClass]
    public class ManagedPayoutSchedulesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public ManagedPayoutSchedulesTest()
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
        public void Given_BalanceAccountConfiguration_When_Deserialized_Then_Result_Is_Correct()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfiguration.json");

            // Act
            var result = JsonSerializer.Deserialize<BalanceAccountConfiguration>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("PSAC00000000000000000000000001", result.Id);
            Assert.AreEqual("PSPC00000000000000000000000001", result.BalancePlatformPayoutScheduleId);
            Assert.AreEqual("BA000000000000000000001", result.BalanceAccountId);
            Assert.AreEqual("SE00000000000000000000001", result.TransferInstrumentId);
            Assert.AreEqual("EUR", result.Currency);
            Assert.AreEqual("Monthly payout", result.Reference);
            Assert.AreEqual("Scheduled payout to merchant bank account", result.Description);
            Assert.AreEqual("PAYOUT-REF-001", result.ReferenceForBeneficiary);
            Assert.AreEqual(10000, result.RetainedAmount);
            Assert.AreEqual(1000, result.MinPayoutAmount);
            Assert.AreEqual(100000000, result.MaxPayoutAmount);
            Assert.AreEqual(true, result.Enabled);
            Assert.AreEqual("monthly", result.Frequency);
            Assert.AreEqual(1, result.FrequencyValue);
            Assert.IsNotNull(result.CreatedAt);
        }

        [TestMethod]
        public void Given_BalanceAccountConfigurations_When_Deserialized_Then_Result_Is_Correct()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfigurations.json");

            // Act
            var result = JsonSerializer.Deserialize<BalanceAccountConfigurations>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BalanceAccountPayoutSchedules.Count);
            Assert.AreEqual("PSAC00000000000000000000000001", result.BalanceAccountPayoutSchedules[0].Id);
            Assert.AreEqual("BA000000000000000000001", result.BalanceAccountPayoutSchedules[0].BalanceAccountId);
            Assert.IsNotNull(result.Link);
        }

        [TestMethod]
        public void Given_BalanceAccountConfigurationUpdated_When_Deserialized_Then_Result_Is_Correct()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfigurationUpdated.json");

            // Act
            var result = JsonSerializer.Deserialize<BalanceAccountConfiguration>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("PSAC00000000000000000000000001", result.Id);
            Assert.AreEqual("Updated payout description", result.Description);
            Assert.AreEqual(false, result.Enabled);
            Assert.AreEqual(20000, result.RetainedAmount);
            Assert.IsNotNull(result.CreatedAt);
        }

        [TestMethod]
        public void Given_PayoutScheduleExecutions_When_Deserialized_Then_Result_Is_Correct()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PayoutScheduleExecutions.json");

            // Act
            var result = JsonSerializer.Deserialize<PayoutScheduleExecutions>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.VarPayoutScheduleExecutions.Count);

            var skipped = result.VarPayoutScheduleExecutions[0];
            Assert.AreEqual("PS0000000000001", skipped.Id);
            Assert.AreEqual(ExecutionResult.Skipped, skipped.Result);
            Assert.IsNotNull(skipped.TriggeredAt);
            Assert.IsNotNull(skipped.ResultDetails);

            var succeeded = result.VarPayoutScheduleExecutions[1];
            Assert.AreEqual("PS0000000000002", succeeded.Id);
            Assert.AreEqual(ExecutionResult.Succeeded, succeeded.Result);
            Assert.IsNotNull(succeeded.TriggeredAt);
        }

        [TestMethod]
        public void Given_BalanceAccountConfigurationRequest_When_Serialized_Then_RequiredFields_Are_Present()
        {
            // Arrange
            var request = new BalanceAccountConfigurationRequest
            {
                BalancePlatformPayoutScheduleId = "PSPC00000000000000000000000001",
                TransferInstrumentId = "SE00000000000000000000001",
                Frequency = BalanceAccountConfigurationRequest.FrequencyEnum.Monthly
            };

            // Act
            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            Assert.AreEqual("PSPC00000000000000000000000001", root.GetProperty("balancePlatformPayoutScheduleId").GetString());
            Assert.AreEqual("SE00000000000000000000001", root.GetProperty("transferInstrumentId").GetString());
            Assert.AreEqual("monthly", root.GetProperty("frequency").GetString());
        }

        [TestMethod]
        public void Given_BalanceAccountConfigurationUpdate_When_Serialized_Then_OnlySetFields_Are_Present()
        {
            // Arrange
            var update = new BalanceAccountConfigurationUpdate
            {
                Description = "Updated payout description",
                Enabled = false,
                RetainedAmount = 20000
            };

            // Act
            string json = JsonSerializer.Serialize(update, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            Assert.IsTrue(root.TryGetProperty("description", out _),
                "description must be present when set");
            Assert.IsTrue(root.TryGetProperty("enabled", out _),
                "enabled must be present when set");
            Assert.IsTrue(root.TryGetProperty("retainedAmount", out _),
                "retainedAmount must be present when set");
            Assert.IsFalse(root.TryGetProperty("frequency", out _),
                "frequency must not be present when not set");
        }
    }
}
