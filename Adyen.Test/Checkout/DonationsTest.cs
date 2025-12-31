using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class DonationsTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public DonationsTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public void Given_Deserialize_When_Donations_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/donations-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<DonationPaymentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(DonationPaymentResponse.StatusEnum.Completed, response.Status);
            Assert.AreEqual("10720de4-7c5d-4a17-9161-fa4abdcaa5c4", response.Reference);
        }
    }
}