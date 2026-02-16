using Adyen.Core.Options;
using Adyen.Recurring.Client;
using Adyen.Recurring.Models;
using Adyen.Recurring.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Adyen.Recurring.Services;

namespace Adyen.Test.Recurring
{
    [TestClass]
    public class RecurringHttpClientBaseAddressTest
    {
        
        
        [TestMethod]
        public async Task RecurringService_TestUrl_IsCorrect()
        {
            // Arrange with test configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureRecurring((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    services.AddAllRecurringServices();
                })
                .Build();
            

            // Act
            var recurringService = host.Services.GetRequiredService<IRecurringService>();     
            
            // Assert
            Assert.IsNotNull(recurringService.HttpClient.BaseAddress);
            Assert.AreEqual("https://pal-test.adyen.com/pal/servlet/Recurring/v68", recurringService.HttpClient.BaseAddress.ToString());
        }        

        [TestMethod]
        public async Task RecurringService_LiveUrl_IsCorrect()
        {
            // Arrange with live configuration
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureRecurring((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "mycompany";
                    });
                    services.AddAllRecurringServices();
                })
                .Build();
            

            // Act
            var recurringService = host.Services.GetRequiredService<IRecurringService>();
            
            // Assert
            Assert.IsNotNull(recurringService.HttpClient.BaseAddress);
            Assert.AreEqual("https://mycompany-pal-live.adyenpayments.com/pal/servlet/Recurring/v68", recurringService.HttpClient.BaseAddress.ToString());
        }        
        
    }
}
