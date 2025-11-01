using Adyen.Core.Options;
using Adyen.PaymentsApp.Client;
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Adyen.PaymentsApp.Services;

namespace Adyen.Test.PaymentsApp
{
    [TestClass]
    public class PaymentsAppTest
    {
        [TestMethod]
        public async Task Given_PaymentsAppService_When_Initialized_Result_Should_Return_Management_Test_Url()
        {
            // Arrange
            // Act
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            
            // Assert
            Assert.AreEqual("https://management-test.adyen.com/v1", paymentsAppService.HttpClient.BaseAddress.ToString());
        }
        
        [TestMethod]
        public void Given_PaymentsAppService_When_Initialized_Result_Should_Return_Management_Live_Url()
        {
            // Arrange
            // Act
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                    });
                })
                .Build();
            
            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            
            // Assert
            Assert.AreEqual("https://management-live.adyen.com/v1", paymentsAppService.HttpClient.BaseAddress.ToString());
        }
        
        [TestMethod]
        public void Given_PaymentsAppService_When_Initialized_Result_Should_Return_Management_Live_Url_And_No_Prefix()
        {
            // Arrange
            // Act
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                })
                .Build();
            
            var paymentsAppService = testHost.Services.GetRequiredService<IPaymentsAppService>();
            
            // Assert
            Assert.AreEqual("https://management-live.adyen.com/v1", paymentsAppService.HttpClient.BaseAddress.ToString());
        }
    }
}