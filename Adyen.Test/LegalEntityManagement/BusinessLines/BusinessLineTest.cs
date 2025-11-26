using System.Text.Json;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Client;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.LegalEntityManagement.BusinessLines
{
    [TestClass]
    public class BusinessLineTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        
        public BusinessLineTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureLegalEntityManagement((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        /// <summary>
        /// Test DeserializeBusinessLine
        /// </summary>
        [TestMethod]
        public void DeserializeBusinessLine()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/BusinessLine.json");

            // Act
            var result = JsonSerializer.Deserialize<BusinessLine>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
        }

        
    }
}
