using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.NetworkTokens
{
    [TestClass]
    public class NetworkTokensTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public NetworkTokensTest()
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
        public void Given_GetNetworkTokenResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GetNetworkTokenResponse.json");

            // Act
            GetNetworkTokenResponse result = JsonSerializer.Deserialize<GetNetworkTokenResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Token);
            Assert.AreEqual("NT1234567890", result.Token.Id);
            Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", result.Token.PaymentInstrumentId);
            Assert.AreEqual(NetworkToken.StatusEnum.Active, result.Token.Status);
        }
    }
}
