using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using System.Text.Json;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class UtilityServiceTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public UtilityServiceTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
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
        public async Task Given_Deserialize_When_UtilityResponse_For_OriginKeys_Returns_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkoututility/originkeys-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<UtilityResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("pub.v2.7814286629520534.aHR0cHM6Ly93d3cueW91ci1kb21haW4xLmNvbQ.UEwIBmW9-c_uXo5wSEr2w8Hz8hVIpujXPHjpcEse3xI", response.OriginKeys["https://www.your-domain1.com"]);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_CardDetailsResponse_Returns_Not_Null()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/checkout/card-details-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<CardDetailsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsFalse(response.IsCardCommercial);
            Assert.AreEqual("CREDIT", response.FundingSource);
            Assert.AreEqual("FR", response.IssuingCountryCode);
            
            Assert.AreEqual("visa", response.Brands[0].Type);
            Assert.IsTrue(response.Brands[0].Supported);
            
            Assert.AreEqual("cartebancaire", response.Brands[1].Type);
            Assert.IsFalse(response.Brands[1].Supported);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_ApplePaySessionResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/apple-pay-sessions-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ApplePaySessionResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("eyJ2Z...340278gdflkaswer", response.Data);
        }
    }
}