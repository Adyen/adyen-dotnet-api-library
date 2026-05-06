using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.ManageSCADevices
{
    [TestClass]
    public class ManageSCADevicesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public ManageSCADevicesTest()
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
        public void Given_RegisterSCAResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/RegisterSCAResponse.json");

            // Act
            RegisterSCAResponse result = JsonSerializer.Deserialize<RegisterSCAResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("UNIQUE_SCA_DEVICE_ID", result.Id);
            Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", result.PaymentInstrumentId);
            Assert.AreEqual(true, result.Success);
        }

        [TestMethod]
        public void Given_SearchRegisteredDevicesResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/SearchRegisteredDevicesResponse.json");

            // Act
            SearchRegisteredDevicesResponse result = JsonSerializer.Deserialize<SearchRegisteredDevicesResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ItemsTotal);
            Assert.AreEqual(1, result.PagesTotal);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(1, result.Data.Count);
        }
    }
}
