using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.GrantOffers
{
    [TestClass]
    public class GrantOffersTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public GrantOffersTest()
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
        public void Given_GrantOffer_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GrantOffer.json");

            // Act
            GrantOffer result = JsonSerializer.Deserialize<GrantOffer>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("UNIQUE_GRANT_OFFER_ID", result.Id);
            Assert.AreEqual("AH3227C223222B5CMD3FJFKGZ", result.AccountHolderId);
            Assert.AreEqual(GrantOffer.ContractTypeEnum.Loan, result.ContractType);
        }

        [TestMethod]
        public void Given_GrantOffers_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GrantOffers.json");

            // Act
            Adyen.BalancePlatform.Models.GrantOffers result = JsonSerializer.Deserialize<Adyen.BalancePlatform.Models.GrantOffers>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.VarGrantOffers);
            Assert.AreEqual(1, result.VarGrantOffers.Count);
            Assert.AreEqual("UNIQUE_GRANT_OFFER_ID", result.VarGrantOffers[0].Id);
        }
    }
}
