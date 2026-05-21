using Adyen.Capital.Client;
using Adyen.Capital.Extensions;
using Adyen.Capital.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.Capital
{
    [TestClass]
    public class DynamicOffersTest
    {
        private static IHost _host;
        private static JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureCapital((ctx, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = _host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
        }

        [TestMethod]
        public void Given_Deserialize_When_GetDynamicOffersResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/dynamic-offers-success.json");

            // Act
            var response = JsonSerializer.Deserialize<GetDynamicOffersResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.DynamicOffers.Count);
            Assert.AreEqual("DO00000000000000000000001", response.DynamicOffers[0].Id);
            Assert.AreEqual("AH00000000000000000000001", response.DynamicOffers[0].AccountHolderId);
            Assert.AreEqual("EUR", response.DynamicOffers[0].MinimumAmount.Currency);
            Assert.AreEqual(5000, response.DynamicOffers[0].MinimumAmount.Value);
            Assert.AreEqual("EUR", response.DynamicOffers[0].MaximumAmount.Currency);
            Assert.AreEqual(25000, response.DynamicOffers[0].MaximumAmount.Value);
        }

        [TestMethod]
        public void Given_Deserialize_When_CalculatedGrantOffer_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/dynamic-offer-calculate-preliminary.json");

            // Act
            var response = JsonSerializer.Deserialize<CalculatedGrantOffer>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("EUR", response.Amount.Currency);
            Assert.AreEqual(10000, response.Amount.Value);
            Assert.AreEqual("EUR", response.Fee.Amount.Currency);
            Assert.AreEqual(1000, response.Fee.Amount.Value);
            Assert.AreEqual(1000, response.Repayment.BasisPoints);
        }

        [TestMethod]
        public void Given_Deserialize_When_GrantOffer_From_DynamicOffer_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/dynamic-offer-create-static-offer.json");

            // Act
            var response = JsonSerializer.Deserialize<GrantOffer>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("GO00000000000000000000002", response.Id);
            Assert.AreEqual("AH00000000000000000000001", response.AccountHolderId);
            Assert.AreEqual(GrantOffer.ContractTypeEnum.CashAdvance, response.ContractType);
            Assert.AreEqual("EUR", response.Amount.Currency);
            Assert.AreEqual(10000, response.Amount.Value);
        }
    }
}
