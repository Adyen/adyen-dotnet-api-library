using System.Net;
using Adyen.Core.Client;
using Adyen.Core.Options;
using Adyen.DocumentCollector.Extensions;
using Adyen.DocumentCollector.Models;
using Adyen.DocumentCollector.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.IntegrationTest.DocumentCollector
{
    [TestClass]
    public class DocumentsServiceIntegrationTest : BaseIntegrationTest
    {
        [TestMethod]
        public async Task Given_Invoice_When_Uploaded_Then_ReturnsCreatedDocument()
        {
            // Arrange
            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureLogging(logging => logging.ClearProviders())
                .ConfigureDocumentCollector((_, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = ApiKey;
                    });
                    services.AddDocumentsService(httpClientOptions: client =>
                        client.Timeout = TimeSpan.FromSeconds(60));
                })
                .Build();
            IDocumentsService service = host.Services.GetRequiredService<IDocumentsService>();
            string fileName = $"{PspReference}.pdf";
            using FileStream file = File.OpenRead(
                Path.Combine(AppContext.BaseDirectory, "DocumentCollector", "Fixtures", "invoice.pdf"));
            var requestOptions = new RequestOptions().AddIdempotencyKey(Guid.NewGuid().ToString("N"));

            // Act
            IUploadCrossBorderInvoiceApiResponse response = await service.UploadCrossBorderInvoiceAsync(
                DocumentContext.PaCbInvoice, file, fileName, "application/pdf", MerchantAccount, requestOptions);

            // Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode,
                "Uploading a valid invoice must return HTTP 201 Created.");
            Assert.IsTrue(response.TryDeserializeCreatedResponse(out DocumentUploadResponse document),
                "A created response must contain a document upload resource.");
            Assert.AreEqual("paCbInvoice", document.Context, "The document context must match the upload.");
            Assert.AreEqual(fileName, document.FileName, "The filename must match the uploaded PDF.");
            Assert.AreEqual(MerchantAccount, document.MerchantAccount,
                "The document must belong to the configured merchant.");
            Assert.AreEqual(PspReference, document.PspReference,
                "The document must reference the configured TEST payment.");
        }
    }
}
