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

namespace Adyen.Test.LegalEntityManagement.TermsOfService
{
    [TestClass]
    public class TermsOfServiceTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly ITermsOfServiceService _termsOfServiceService;

        public TermsOfServiceTest()
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
            _termsOfServiceService = Substitute.For<ITermsOfServiceService>();
        }

        [TestMethod]
        public void AcceptTermsOfServiceAsyncTest()
        {
            // Arrange
            var json = "{\"id\":\"TOS123\",\"type\":\"adyenIssuing\",\"acceptedBy\":\"user\",\"acceptedFor\":\"LE123\"}";
            var legalEntityId = "LE123";
            var tosDocumentId = "TOSDOC123";
            var request = new AcceptTermsOfServiceRequest();

            _termsOfServiceService.AcceptTermsOfServiceAsync(
                    Arg.Any<string>(),
                    Arg.Any<string>(),
                    Arg.Any<Option<AcceptTermsOfServiceRequest>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IAcceptTermsOfServiceApiResponse>(
                        new TermsOfServiceService.AcceptTermsOfServiceApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TermsOfServiceService.AcceptTermsOfServiceApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/termsOfService/{tosDocumentId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _termsOfServiceService.AcceptTermsOfServiceAsync(legalEntityId, tosDocumentId, new Option<AcceptTermsOfServiceRequest>(request), CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("TOS123", result.Id);
        }

        [TestMethod]
        public void GetAcceptedTermsOfServiceDocumentAsyncTest()
        {
            // Arrange
            var json = "{\"id\":\"LE123\", \"document\":\"document-content\"}";
            var legalEntityId = "LE123";
            var tosAcceptanceRef = "TOSREF123";

            _termsOfServiceService.GetAcceptedTermsOfServiceDocumentAsync(
                    Arg.Any<string>(),
                    Arg.Any<string>(),
                    Arg.Any<Option<string>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetAcceptedTermsOfServiceDocumentApiResponse>(
                        new TermsOfServiceService.GetAcceptedTermsOfServiceDocumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TermsOfServiceService.GetAcceptedTermsOfServiceDocumentApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/acceptedTermsOfServiceDocument/{tosAcceptanceRef}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _termsOfServiceService.GetAcceptedTermsOfServiceDocumentAsync(legalEntityId, tosAcceptanceRef, "JSON", CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("LE123", result.Id);
        }

        [TestMethod]
        public void GetTermsOfServiceDocumentAsyncTest()
        {
            // Arrange
            var json = "{\"id\":\"LE123\", \"document\":\"document-content\"}";
            var legalEntityId = "LE123";
            var request = new GetTermsOfServiceDocumentRequest();

            _termsOfServiceService.GetTermsOfServiceDocumentAsync(
                    Arg.Any<string>(),
                    Arg.Any<Option<GetTermsOfServiceDocumentRequest>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetTermsOfServiceDocumentApiResponse>(
                        new TermsOfServiceService.GetTermsOfServiceDocumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TermsOfServiceService.GetTermsOfServiceDocumentApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/termsOfService",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _termsOfServiceService.GetTermsOfServiceDocumentAsync(legalEntityId, new Option<GetTermsOfServiceDocumentRequest>(request), CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("LE123", result.Id);
        }

        [TestMethod]
        public void GetTermsOfServiceInformationForLegalEntityAsyncTest()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/TermsOfServiceStatus.json");
            var legalEntityId = "LE123";

            _termsOfServiceService.GetTermsOfServiceInformationForLegalEntityAsync(
                    Arg.Any<string>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetTermsOfServiceInformationForLegalEntityApiResponse>(
                        new TermsOfServiceService.GetTermsOfServiceInformationForLegalEntityApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TermsOfServiceService.GetTermsOfServiceInformationForLegalEntityApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/termsOfServiceAcceptanceInfos",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _termsOfServiceService.GetTermsOfServiceInformationForLegalEntityAsync(legalEntityId, CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Data.Count);
        }

        [TestMethod]
        public void GetTermsOfServiceStatusAsyncTest()
        {
            // Arrange
            var json = "{\"termsOfServiceTypes\":[\"adyenIssuing\"]}";
            var legalEntityId = "LE123";

            _termsOfServiceService.GetTermsOfServiceStatusAsync(
                    Arg.Any<string>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetTermsOfServiceStatusApiResponse>(
                        new TermsOfServiceService.GetTermsOfServiceStatusApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TermsOfServiceService.GetTermsOfServiceStatusApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/termsOfServiceStatus",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _termsOfServiceService.GetTermsOfServiceStatusAsync(legalEntityId, CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, response.Ok().TermsOfServiceTypes.Count);
        }
    }
}
