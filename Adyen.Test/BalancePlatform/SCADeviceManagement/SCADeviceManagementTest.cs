using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.SCADeviceManagement
{
    [TestClass]
    public class SCADeviceManagementTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public SCADeviceManagementTest()
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
        public void Given_BeginScaDeviceRegistrationResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BeginScaDeviceRegistrationResponse.json");

            // Act
            BeginScaDeviceRegistrationResponse result = JsonSerializer.Deserialize<BeginScaDeviceRegistrationResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ScaDevice);
            Assert.AreEqual("BSDR42XV3223223S5N6CDQDGH53M8H", result.ScaDevice.Id);
            Assert.AreEqual(ScaDeviceType.Ios, result.ScaDevice.Type);
            Assert.IsNotNull(result.SdkInput);
        }

        [TestMethod]
        public void Given_FinishScaDeviceRegistrationResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/FinishScaDeviceRegistrationResponse.json");

            // Act
            FinishScaDeviceRegistrationResponse result = JsonSerializer.Deserialize<FinishScaDeviceRegistrationResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ScaDevice);
            Assert.AreEqual("BSDR42XV3223223S5N6CDQDGH53M8H", result.ScaDevice.Id);
            Assert.AreEqual(ScaDeviceType.Ios, result.ScaDevice.Type);
        }

        [TestMethod]
        public void Given_SubmitScaAssociationResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/SubmitScaAssociationResponse.json");

            // Act
            SubmitScaAssociationResponse result = JsonSerializer.Deserialize<SubmitScaAssociationResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ScaAssociations);
            Assert.AreEqual(1, result.ScaAssociations.Count);
            Assert.AreEqual("BSDR11111111111A1AAA1AAAAA1AA1", result.ScaAssociations[0].ScaDeviceId);
            Assert.AreEqual("AH00000000000000000000001", result.ScaAssociations[0].EntityId);
            Assert.AreEqual(ScaEntityType.AccountHolder, result.ScaAssociations[0].EntityType);
            Assert.AreEqual(AssociationStatus.PendingApproval, result.ScaAssociations[0].Status);
        }
    }
}
