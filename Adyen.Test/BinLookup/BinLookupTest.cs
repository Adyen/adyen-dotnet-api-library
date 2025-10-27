using System.Text.Json;
using Adyen.BinLookup.Client;
using Adyen.BinLookup.Extensions;
using Adyen.BinLookup.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BinLookup
{
    [TestClass]
    public class BinLookupTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BinLookupTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBinLookup((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public void Get3dsAvailabilitySuccessMockedTest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/binlookup/get3dsavailability-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ThreeDSAvailabilityResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("F013371337", response.DsPublicKeys[0].DirectoryServerId);
            Assert.AreEqual("visa", response.DsPublicKeys[0].Brand);
            Assert.AreEqual("411111111111", response.ThreeDS2CardRangeDetails[0].StartRange);
            Assert.AreEqual("411111111111", response.ThreeDS2CardRangeDetails[0].EndRange);
            Assert.AreEqual("2.1.0", response.ThreeDS2CardRangeDetails[0].ThreeDS2Versions.FirstOrDefault());
            Assert.AreEqual("https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", response.ThreeDS2CardRangeDetails[0].ThreeDSMethodURL);
            Assert.AreEqual(true, response.ThreeDS1Supported);
            Assert.AreEqual(true, response.ThreeDS2supported);
        }

        [TestMethod]
        public void GetCostEstimateSuccessMockedTest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/binlookup/getcostestimate-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<CostEstimateResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("1111", response.CardBin.Summary);
            Assert.AreEqual("Unsupported", response.ResultCode);
        }
    }
}
