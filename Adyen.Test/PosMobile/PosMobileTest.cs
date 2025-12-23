using Adyen.Core.Options;
using Adyen.PosMobile.Models;
using Adyen.PosMobile.Client;
using Adyen.PosMobile.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.PosMobile
{
    [TestClass]
    public class PosMobileTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PosMobileTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePosMobile((context, services, config) =>
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
        public async Task Given_Deserialize_When_CreateSessionResponse_Returns_Correct_Id()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/posmobile/create-session.json");

            // Act
            var response = JsonSerializer.Deserialize<CreateSessionResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Id, "CS451F2AB1ED897A94");
        }
    }
}