using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.Platform
{
    [TestClass]
    public class PlatformTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PlatformTest()
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
        public void Given_BalancePlatform_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalancePlatform.json");

            // Act
            Adyen.BalancePlatform.Models.BalancePlatform result = JsonSerializer.Deserialize<Adyen.BalancePlatform.Models.BalancePlatform>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", result.Id);
            Assert.AreEqual("Active", result.Status);
        }

        [TestMethod]
        public void Given_PaginatedAccountHoldersResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedAccountHoldersResponse.json");

            // Act
            PaginatedAccountHoldersResponse result = JsonSerializer.Deserialize<PaginatedAccountHoldersResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.AccountHolders);
        }
    }
}
