using Adyen.Core.Options;
using Adyen.PosMobile.Extensions;
using Adyen.PosMobile.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.PosMobile
{
    [TestClass]
    public class PosMobileHttpClientBaseAddressTest
    {
        
        [TestMethod]
        public async Task CheckoutService_TestUrl_IsCorrect()
        {
            // Arrange with test configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePosMobile((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    services.AddAllPosMobileServices();
                })
                .Build();
            

            // Act
            var posMobileService = host.Services.GetRequiredService<IPosMobileService>();     
            
            // Assert
            Assert.IsNotNull(posMobileService.HttpClient.BaseAddress);
            var baseAddress = posMobileService.HttpClient.BaseAddress.ToString();

            Assert.IsNotNull(baseAddress);
            StringAssert.StartsWith(baseAddress, "https://checkout-test.adyen.com/checkout/possdk/v");
        }        

        [TestMethod]
        public async Task RecurringService_LiveUrl_IsCorrect()
        {
            // Arrange with live configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePosMobile((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "mycompany";
                    });
                    services.AddAllPosMobileServices();
                })
                .Build();
            

            // Act
            var posMobileService = host.Services.GetRequiredService<IPosMobileService>();     
            
            // Assert
            Assert.IsNotNull(posMobileService.HttpClient.BaseAddress);
            var baseAddress = posMobileService.HttpClient.BaseAddress.ToString();

            Assert.IsNotNull(baseAddress);
            StringAssert.StartsWith(baseAddress, "https://mycompany-checkout-live.adyenpayments.com/checkout/possdk/v");
            
        }        
        
    }
}
