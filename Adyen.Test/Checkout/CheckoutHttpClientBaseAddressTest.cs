using Adyen.Checkout.Extensions;
using Adyen.Checkout.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class CheckoutHttpClientBaseAddressTest
    {
        
        [TestMethod]
        public async Task CheckoutService_TestUrl_IsCorrect()
        {
            // Arrange with test configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    services.AddAllCheckoutServices();
                })
                .Build();
            

            // Act
            var paymentsService = host.Services.GetRequiredService<IPaymentsService>();     
            
            // Assert
            Assert.IsNotNull(paymentsService.HttpClient.BaseAddress);
            var baseAddress = paymentsService.HttpClient.BaseAddress.ToString();

            Assert.IsNotNull(baseAddress);
            StringAssert.StartsWith(baseAddress, "https://checkout-test.adyen.com/v");
        }        

        [TestMethod]
        public async Task RecurringService_LiveUrl_IsCorrect()
        {
            // Arrange with live configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "mycompany";
                    });
                    services.AddAllCheckoutServices();
                })
                .Build();
            

            // Act
            var paymentsService = host.Services.GetRequiredService<IPaymentsService>();     
            
            // Assert
            Assert.IsNotNull(paymentsService.HttpClient.BaseAddress);
            var baseAddress = paymentsService.HttpClient.BaseAddress.ToString();

            Assert.IsNotNull(baseAddress);
            StringAssert.StartsWith(baseAddress, "https://mycompany-checkout-live.adyenpayments.com/checkout/v");
            
        }        
        
    }
}
