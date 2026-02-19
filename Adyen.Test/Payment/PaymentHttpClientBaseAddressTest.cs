using Adyen.Core.Options;
using Adyen.Payment.Extensions;
using Adyen.Payment.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Payment
{
    [TestClass]
    public class PaymentHttpClientBaseAddressTest
    {
        
        [TestMethod]
        public async Task CheckoutService_TestUrl_IsCorrect()
        {
            // Arrange with test configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePayment((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    services.AddAllPaymentServices();
                })
                .Build();
            

            // Act
            var paymentsService = host.Services.GetRequiredService<IPaymentsService>();     
            
            // Assert
            Assert.IsNotNull(paymentsService.HttpClient.BaseAddress);
            var baseAddress = paymentsService.HttpClient.BaseAddress.ToString();

            Assert.IsNotNull(baseAddress);
            StringAssert.StartsWith(baseAddress, "https://pal-test.adyen.com/pal/servlet/Payment/v");
        }        

        [TestMethod]
        public async Task RecurringService_LiveUrl_IsCorrect()
        {
            // Arrange with live configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePayment((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "mycompany";
                    });
                    services.AddAllPaymentServices();
                })
                .Build();
            

            // Act
            var paymentsService = host.Services.GetRequiredService<IPaymentsService>();     
            
            // Assert
            Assert.IsNotNull(paymentsService.HttpClient.BaseAddress);
            var baseAddress = paymentsService.HttpClient.BaseAddress.ToString();

            Assert.IsNotNull(baseAddress);
            StringAssert.StartsWith(baseAddress, "https://mycompany-pal-live.adyenpayments.com/pal/servlet/Payment/v68");
            
        }        
        
    }
}
