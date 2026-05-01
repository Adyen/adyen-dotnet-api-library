using System.Text.Json;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Client;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.LegalEntityManagement.LegalEntities
{
    [TestClass]
    public class LegalEntityTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public LegalEntityTest()
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
        /// Test DeserializeLegalEntity
        /// </summary>
        [TestMethod]
        public async Task DeserializeLegalEntity()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            // Act
            var result = JsonSerializer.Deserialize<LegalEntity>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", result.Id);
        }
        
        /// <summary>
        /// Test DeserializeLegalEntityBusinessLines
        /// </summary>
        [TestMethod]
        public async Task DeserializeLegalEntityBusinessLines()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntityBusinessLines.json");

            // Act
            var result = JsonSerializer.Deserialize<Adyen.LegalEntityManagement.Models.BusinessLines>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.VarBusinessLines.Count);
        }
        
    }
}
