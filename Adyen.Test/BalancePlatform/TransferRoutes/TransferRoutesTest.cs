using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.TransferRoutes
{
    [TestClass]
    public class TransferRoutesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public TransferRoutesTest()
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
        public void Given_TransferRouteResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferRouteResponse.json");

            // Act
            TransferRouteResponse result = JsonSerializer.Deserialize<TransferRouteResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.TransferRoutes);
            Assert.AreEqual(2, result.TransferRoutes.Count);
            Assert.AreEqual("USD", result.TransferRoutes[0].Currency);
            Assert.AreEqual("NL", result.TransferRoutes[0].Country);
        }
    }
}
