using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.GrantAccounts
{
    [TestClass]
    public class GrantAccountsTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public GrantAccountsTest()
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
        public void Given_GrantAccount_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GrantAccount.json");

            // Act
            CapitalGrantAccount result = JsonSerializer.Deserialize<CapitalGrantAccount>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("UNIQUE_GRANT_ACCOUNT_ID", result.Id);
            Assert.AreEqual("BA3227C223222B5CMD3FJFKGZ", result.FundingBalanceAccountId);
        }
    }
}
