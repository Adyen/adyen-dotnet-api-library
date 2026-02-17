using System.Net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.Logging;

namespace Adyen.IntegrationTest.LegalEntityManagement
{
    [TestClass]
    public class LegalEntityManagementServiceIntegrationTest
    {
        private readonly ILegalEntitiesService _legalEntitiesService;
        private readonly IHost _host;
        private readonly ILogger _logger;
        
        public LegalEntityManagementServiceIntegrationTest()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureLegalEntityManagement(
                    (context, services, config) =>
                    {
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = context.Configuration["LEM_API_KEY"];
                            options.Environment = AdyenEnvironment.Test;
                        });
                        services.AddAllLegalEntityManagementServices();
                    })
                .Build();
            
            _legalEntitiesService = _host.Services.GetRequiredService<ILegalEntitiesService>();
            
            _logger = _host.Services.GetRequiredService<ILogger<ILegalEntitiesService>>();
        }

        [TestMethod]
        public async Task Given_LegalEntityService_When_GetAllBusinessLines_Returns_OK()
        {
            var legalEntityId = Environment.GetEnvironmentVariable("LEGAL_ENTITY_ID");
            Assert.IsNotNull(legalEntityId, "env var LEGAL_ENTITY_ID is null");

            IGetAllBusinessLinesUnderLegalEntityApiResponse response = 
                await _legalEntitiesService.GetAllBusinessLinesUnderLegalEntityAsync(legalEntityId);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result?.VarBusinessLines);
        }

        [TestMethod]
        public async Task Given_LegalEntityService_When_CreateLegalEntity_Returns_OK()
        {
            var request = new LegalEntityInfoRequiredType(
                type: LegalEntityInfoRequiredType.TypeEnum.Individual,
                individual: new Individual(
                    name: new Name(
                        firstName: "John",
                        lastName: "Visconti"
                        ),
                    residentialAddress: new Address(
                        country: "IT",
                        city: "Rome",
                        postalCode: "23100",
                        street: "123 Main St"
                        )
                    )
                );
            ICreateLegalEntityApiResponse response = 
                await _legalEntitiesService.CreateLegalEntityAsync(request);
            
            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result?.Id);
        }
    }
}