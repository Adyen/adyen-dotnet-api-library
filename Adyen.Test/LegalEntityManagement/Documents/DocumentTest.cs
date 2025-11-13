using System.Net;
using System.Text.Json;
using Adyen.Core;
using Adyen.Core.Client;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;
using Adyen.LegalEntityManagement.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.Abstractions;
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
        public async Task DeserializeDocument()
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
        public async Task UpdateDocument()
        {
            
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/Document.json");
            var document = new Document
            {
                Attachment = new Attachment()
            };
            
            _documentsService.UpdateDocumentAsync(
                    Arg.Any<string>(), 
                    Arg.Any<Option<Document>>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                        Task.FromResult<IUpdateDocumentApiResponse>(
                            new DocumentsService.UpdateDocumentApiResponse(
                            NullLogger<DocumentsService.UpdateDocumentApiResponse>.Instance,
                            new HttpRequestMessage(), 
                            new HttpResponseMessage(), 
                            json, 
                            "/documents/DOC01234", 
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                        ));
            
            IUpdateDocumentApiResponse response = await _documentsService.UpdateDocumentAsync("DOC01234", null, new RequestOptions(), CancellationToken.None);
            
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(Document.TypeEnum.DriversLicense, response.Ok().Type);
        }
        
        /// <summary>
        /// Test UploadDocumentForVerificationChecksAsync
        /// </summary>
        [TestMethod]
        public async Task UploadDocumentForVerificationChecksAsyncTest()
        {
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/Document.json");
            var document = new Document
            {
                Attachment = new Attachment()
            };
            _documentsService.UploadDocumentForVerificationChecksAsync(
                    Arg.Any<Option<Document>>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                        Task.FromResult<IUploadDocumentForVerificationChecksApiResponse>(
                            new DocumentsService.UploadDocumentForVerificationChecksApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<DocumentsService.UploadDocumentForVerificationChecksApiResponse>>(),
                            new HttpRequestMessage(), 
                            new HttpResponseMessage(), 
                            json, 
                            "/documents", 
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                        ));
            
            IUploadDocumentForVerificationChecksApiResponse response = await _documentsService.UploadDocumentForVerificationChecksAsync(new Option<Document>(document), new RequestOptions().AddxRequestedVerificationCodeHeader("xRequestedVerificationCode"), CancellationToken.None);
            
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(Document.TypeEnum.DriversLicense, response.Ok().Type);
        }
        
        /// <summary>
        /// Test DeleteDocumentAsync
        /// </summary>
        [TestMethod]
        public async Task DeleteDocumentAsyncTest()
        {
            var documentId = "DOC01234";
            _documentsService.DeleteDocumentAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                        Task.FromResult<IDeleteDocumentApiResponse>(
                            new DocumentsService.DeleteDocumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<DocumentsService.DeleteDocumentApiResponse>>(),
                            new HttpRequestMessage(), 
                            new HttpResponseMessage { StatusCode = HttpStatusCode.NoContent }, 
                            "", // Empty content for 204 No Content
                            $"/documents/{documentId}", 
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                        ));
            
            IDeleteDocumentApiResponse response = await _documentsService.DeleteDocumentAsync(documentId);
            
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
            Assert.IsTrue(response.IsNoContent);
        }
        
    }
}
