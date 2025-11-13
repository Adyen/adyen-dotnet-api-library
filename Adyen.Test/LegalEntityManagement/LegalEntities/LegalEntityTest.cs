using System.Net;
using System.Text.Json;
using Adyen.Core;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Client;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test.LegalEntityManagement.LegalEntities
{
    [TestClass]
    public class LegalEntityTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly ILegalEntitiesService _legalEntitiesService;
        
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
            _legalEntitiesService = Substitute.For<ILegalEntitiesService>();

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
        
        /// <summary>
        /// Test GetLegalEntity
        /// </summary>
        [TestMethod]
        public async Task GetLegalEntity()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");
            
            _legalEntitiesService.GetLegalEntityAsync(Arg.Any<string>())
                .Returns(
                    Task.FromResult<IGetLegalEntityApiResponse>(
                        new LegalEntitiesService.GetLegalEntityApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<LegalEntitiesService.GetLegalEntityApiResponse>>(),
                            new HttpRequestMessage(), 
                            new HttpResponseMessage(), 
                            json, 
                            "/documents/DOC01234", 
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));
            
            IGetLegalEntityApiResponse response = await _legalEntitiesService.GetLegalEntityAsync("LE322JV223222D5GG42KN6869");
            
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", response.Ok().Id);
        }
        
    }
}
