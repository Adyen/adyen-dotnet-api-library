using System.Net;
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

namespace Adyen.Test.LegalEntityManagement.PCIQuestionnaires
{
    [TestClass]
    public class PCIQuestionnairesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IPCIQuestionnairesService _pciQuestionnairesService;

        public PCIQuestionnairesTest()
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
            _pciQuestionnairesService = Substitute.For<IPCIQuestionnairesService>();
        }

        [TestMethod]
        public void CalculatePciStatusOfLegalEntityAsyncTest()
        {
            // Arrange
            var json = "{\"signingRequired\": true}";
            var legalEntityId = "LE123";
            var request = new CalculatePciStatusRequest();

            _pciQuestionnairesService.CalculatePciStatusOfLegalEntityAsync(
                    Arg.Any<string>(),
                    Arg.Any<Option<CalculatePciStatusRequest>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<ICalculatePciStatusOfLegalEntityApiResponse>(
                        new PCIQuestionnairesService.CalculatePciStatusOfLegalEntityApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<PCIQuestionnairesService.CalculatePciStatusOfLegalEntityApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/pciQuestionnaires/signingRequired",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _pciQuestionnairesService.CalculatePciStatusOfLegalEntityAsync(legalEntityId, new Option<CalculatePciStatusRequest>(request), CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.SigningRequired);
        }

        [TestMethod]
        public void GeneratePciQuestionnaireAsyncTest()
        {
            // Arrange
            var json = "{\n  \"content\": \"JVBERi0xLjQKJcOkw7zDtsOfCjIgMCBv+f/ub0j6JPRX+E3EmC==\",\n  \"language\": \"fr\",\n  \"pciTemplateReferences\": [\n    \"PCIT-T7KC6VGL\",\n    \"PCIT-PKB6DKS4\"\n  ]\n}";
            var legalEntityId = "LE123";
            var request = new GeneratePciDescriptionRequest();

            _pciQuestionnairesService.GeneratePciQuestionnaireAsync(
                    Arg.Any<string>(),
                    Arg.Any<Option<GeneratePciDescriptionRequest>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGeneratePciQuestionnaireApiResponse>(
                        new PCIQuestionnairesService.GeneratePciQuestionnaireApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<PCIQuestionnairesService.GeneratePciQuestionnaireApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/pciQuestionnaires/generatePciTemplates",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _pciQuestionnairesService.GeneratePciQuestionnaireAsync(legalEntityId, new Option<GeneratePciDescriptionRequest>(request), CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("fr", result.Language);
            Assert.AreEqual(2, result.PciTemplateReferences.Count);
        }

        [TestMethod]
        public void GetPciQuestionnaireAsyncTest()
        {
            // Arrange
            var json = "{\n  \"content\": \"JVBERi0xLjQKJcOkw7zDtsOfCjIgMCBv+f/ub0j6JPRX+E3EmC==\",\n  \"createdAt\": \"2023-03-02T17:54:19.538365Z\",\n  \"id\": \"PCID422GZ22322565HHMH48CW63CPH\",\n  \"validUntil\": \"2024-03-01T17:54:19.538365Z\"\n}";
            var legalEntityId = "LE123";
            var pciId = "PCI123";

            _pciQuestionnairesService.GetPciQuestionnaireAsync(
                    Arg.Any<string>(),
                    Arg.Any<string>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetPciQuestionnaireApiResponse>(
                        new PCIQuestionnairesService.GetPciQuestionnaireApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<PCIQuestionnairesService.GetPciQuestionnaireApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/pciQuestionnaires/{pciId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _pciQuestionnairesService.GetPciQuestionnaireAsync(legalEntityId, pciId, CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("PCID422GZ22322565HHMH48CW63CPH", result.Id);
        }

        [TestMethod]
        public void GetPciQuestionnaireDetailsAsyncTest()
        {
            // Arrange
            var json = "{\n  \"data\": [\n    {\n      \"createdAt\": \"2023-03-02T17:54:19.538365Z\",\n      \"id\": \"PCID422GZ22322565HHMH48CW63CPH\",\n      \"validUntil\": \"2024-03-01T17:54:19.538365Z\"\n    },\n    {\n      \"createdAt\": \"2023-03-02T17:54:19.538365Z\",\n      \"id\": \"PCID422GZ22322565HHMH49CW75Z9H\",\n      \"validUntil\": \"2024-03-01T17:54:19.538365Z\"\n    }\n  ]\n}";
            var legalEntityId = "LE123";

            _pciQuestionnairesService.GetPciQuestionnaireDetailsAsync(
                    Arg.Any<string>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetPciQuestionnaireDetailsApiResponse>(
                        new PCIQuestionnairesService.GetPciQuestionnaireDetailsApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<PCIQuestionnairesService.GetPciQuestionnaireDetailsApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/pciQuestionnaires",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _pciQuestionnairesService.GetPciQuestionnaireDetailsAsync(legalEntityId, CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(2, result.Data.Count);
        }

        [TestMethod]
        public void SignPciQuestionnaireAsyncTest()
        {
            // Arrange
            var json = "{\n  \"pciQuestionnaireIds\": [\n    \"PCID422GZ22322565HHMH48CW63CPH\",\n    \"PCID422GZ22322565HHMH49CW75Z9H\"\n  ]\n}";
            var legalEntityId = "LE123";
            var request = new PciSigningRequest();

            _pciQuestionnairesService.SignPciQuestionnaireAsync(
                    Arg.Any<string>(),
                    Arg.Any<Option<PciSigningRequest>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<ISignPciQuestionnaireApiResponse>(
                        new PCIQuestionnairesService.SignPciQuestionnaireApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<PCIQuestionnairesService.SignPciQuestionnaireApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/pciQuestionnaires/signPciTemplates",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _pciQuestionnairesService.SignPciQuestionnaireAsync(legalEntityId, new Option<PciSigningRequest>(request), CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.PciQuestionnaireIds.Count);
        }
    }
}