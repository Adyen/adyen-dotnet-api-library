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
        public void Given_Deserialize_When_UtilityResponse_For_OriginKeys_Returns_Success()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkoututility/originkeys-success.json");
            var response = JsonSerializer.Deserialize<UtilityResponse>(json, _jsonSerializerOptionsProvider.Options);
            Assert.AreEqual("pub.v2.7814286629520534.aHR0cHM6Ly93d3cueW91ci1kb21haW4xLmNvbQ.UEwIBmW9-c_uXo5wSEr2w8Hz8hVIpujXPHjpcEse3xI", response.OriginKeys["https://www.your-domain1.com"]);
        }
    }
}