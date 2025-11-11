using System.Net;
using System.Text.Json;
using Adyen.Core;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;
using Adyen.LegalEntityManagement.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test.LegalEntityManagement.Documents
{
    [TestClass]
    public class DocumentTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IDocumentsService _documentsService;
        
        public DocumentTest()
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
            _documentsService = Substitute.For<IDocumentsService>();

        }

        /// <summary>
        /// Test deserializeDocument
        /// </summary>
        [TestMethod]
        public void DeserializeDocument()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/Document.json");

            // Act
            var result = JsonSerializer.Deserialize<Document>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
        }
        
        /// <summary>
        /// Test UpdateDocument
        /// </summary>
        [TestMethod]
        public void UpdateDocument()
        {
            
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/Document.json");
            var document = new Document
            {
                Attachment = new Attachment()
            };
            _documentsService.UpdateDocumentAsync(
                    Arg.Any<string>(), 
                    Arg.Any<Option<string>>(),
                    Arg.Any<Option<Document>>(),
            Arg.Any<CancellationToken>())
                .Returns(
                        Task.FromResult<IUpdateDocumentApiResponse>(
                            new DocumentsService.UpdateDocumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<DocumentsService.UpdateDocumentApiResponse>>(),
                            new HttpRequestMessage(), 
                            new HttpResponseMessage(), 
                            json, 
                            "/documents/DOC01234", 
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                        ));
            
            IUpdateDocumentApiResponse response = _documentsService.UpdateDocumentAsync("DOC01234", "xRequestedVerificationCode", document, CancellationToken.None).Result;
            
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(Document.TypeEnum.DriversLicense, response.Ok().Type);
        }
        
        //
        // /// <summary>
        // /// Test createDocument
        // /// </summary>
        // [TestMethod]
        // public void UpdateDocument()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/Document.json");
        //     var service = new DocumentsService(client);
        //     var document = new Document
        //     {
        //         Attachment = new Attachment()
        //     };
        //     var response = service.UpdateDocument("SE322KT223222D5FJ7TJN2986",document);
        //     Assert.AreEqual(Encoding.ASCII.GetString(response.Attachments[0].Content), "This is a string");
        //     Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");
        //
        // }
        //
        // /// <summary>
        // /// Test deleteDocument
        // /// </summary>
        // [TestMethod]
        // public void DeleteDocumentTest()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/Document.json");
        //     var service = new DocumentsService(client);
        //     service.DeleteDocument("SE322KT223222D5FJ7TJN2986");
        //
        // }
        // #endregion
        //
        // #region TransferInstruments
        // /// <summary>
        // /// Test createTransferInstruments
        // /// </summary>
        // [TestMethod]
        // public void CreateTransferInstrumentsTest()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/TransferInstrument.json");
        //     var service = new TransferInstrumentsService(client);
        //     var transferInstrumentInfo = new TransferInstrumentInfo
        //     {
        //         LegalEntityId = "",
        //         Type = TransferInstrumentInfo.TypeEnum.BankAccount
        //     };
        //     var response = service.CreateTransferInstrument(transferInstrumentInfo);
        //     Assert.AreEqual(response.LegalEntityId, "LE322KH223222D5GG4C9J83RN");
        //     Assert.AreEqual(response.Id, "SE576BH223222F5GJVKHH6BDT");
        // }
        // /// <summary>
        // /// Test updateTransferInstruments
        // /// </summary>
        // [TestMethod]
        // public void UpdateTransferInstrumentsTest()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/TransferInstrument.json");
        //     var service = new TransferInstrumentsService(client);
        //     var transferInstrumentInfo = new TransferInstrumentInfo
        //     {
        //         LegalEntityId = "",
        //         Type = TransferInstrumentInfo.TypeEnum.BankAccount
        //     };
        //     var task = service.UpdateTransferInstrumentAsync("SE576BH223222F5GJVKHH6BDT", transferInstrumentInfo);
        //     var response = task.Result;
        //     Assert.AreEqual(response.LegalEntityId, "LE322KH223222D5GG4C9J83RN");
        //     Assert.AreEqual(response.Id, "SE576BH223222F5GJVKHH6BDT");
        // }
        // #endregion
        //
        // #region HostedOnboarding
        // /// <summary>
        // /// Test hostedOnboarding
        // /// </summary>
        // [TestMethod]
        // public void ListThemesTest()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/OnboardingThemes.json");
        //     var service = new HostedOnboardingService(client);
        //     var task = service.ListHostedOnboardingPageThemesAsync();
        //     var response = task.Result;
        //     Assert.AreEqual(response.Themes[0].Id, "SE322KT223222D5FJ7TJN2986");
        //     Assert.AreEqual(response.Themes[0].CreatedAt, DateTime.Parse("2022-10-31T01:30:00+01:00"));
        // }
        // #endregion
        //
        // #region LegalEntities
        // /// <summary>
        // /// Test update LegalEntities
        // /// </summary>
        // [TestMethod]
        // public void UpdateLegalEntitiesTest()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/LegalEntity.json");
        //     var service = new LegalEntitiesService(client);
        //     var legalEntityInfo = new LegalEntityInfo
        //     {
        //         Organization = new Organization(),
        //         Type = LegalEntityInfo.TypeEnum.Individual,
        //         EntityAssociations = new List<LegalEntityAssociation>(),
        //         SoleProprietorship = new SoleProprietorship()
        //     };
        //     var response = service.UpdateLegalEntity("LE322JV223222D5GG42KN6869", legalEntityInfo);
        //     Assert.AreEqual(response.Id, "LE322JV223222D5GG42KN6869");
        //     Assert.AreEqual(response.Type, LegalEntity.TypeEnum.Individual);
        // }
        // #endregion
        //
        // #region LegalEntities
        // /// <summary>
        // /// Test update BusinessLines
        // /// </summary>
        // [TestMethod]
        // public void UpdateBusinessLinesTest()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/BusinessLine.json");
        //     var service = new BusinessLinesService(client);
        //     var businessLine = new BusinessLineInfoUpdate
        //     {
        //         IndustryCode = "124rrdfer",
        //         SourceOfFunds = new SourceOfFunds()
        //     };
        //     var response = service.UpdateBusinessLine("SE322KT223222D5FJ7TJN2986", businessLine);
        //     Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");
        //     Assert.AreEqual(response.IndustryCode, "55");
        // }
        // #endregion
        //
        // #region TermsOfService
        // /// <summary>
        // /// Test get TermsOfService Status
        // /// </summary>
        // [TestMethod]
        // public void GetTermsOfServiceStatus()
        // {
        //     var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/legalentitymanagement/TermsOfServiceStatus.json");
        //     var service = new TermsOfServiceService(client);
        //     var response = service.GetTermsOfServiceInformationForLegalEntity("id123");
        //     ClientInterfaceSubstitute.Received().RequestAsync(
        //         "https://kyc-test.adyen.com/lem/v3/legalEntities/id123/termsOfServiceAcceptanceInfos",
        //         null,
        //         null,
        //         new HttpMethod("GET"), default);
        //     Assert.AreEqual(response.Data[0].Type, TermsOfServiceAcceptanceInfo.TypeEnum.AdyenIssuing);
        // }
        // #endregion
    }
}
