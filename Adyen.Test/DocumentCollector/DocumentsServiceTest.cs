using System.Net;
using System.Text;
using Adyen.Core.Client;
using Adyen.Core.Options;
using Adyen.DocumentCollector.Extensions;
using Adyen.DocumentCollector.Models;
using Adyen.DocumentCollector.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.DocumentCollector
{
    [TestClass]
    public class DocumentsServiceTest
    {
        private const string FileName = "QRMJC25GDZRKDM92.pdf";
        private const string MerchantAccount = "TestMerchantAccount";
        private const string UploadResponse = """
            {
                "context": "paCbInvoice",
                "fileName": "QRMJC25GDZRKDM92.pdf",
                "merchantAccount": "TestMerchantAccount",
                "pspReference": "QRMJC25GDZRKDM92"
            }
            """;

        [TestMethod]
        public async Task Given_Invoice_When_Uploaded_Then_SendsMultipartRequestAndDeserializesCreatedResponse()
        {
            var fileBytes = Encoding.UTF8.GetBytes("%PDF-1.7\nTest invoice\n%%EOF");
            var requestCount = 0;
            using var host = CreateHost(request =>
            {
                requestCount++;
                Assert.AreEqual(HttpMethod.Post, request.Method);
                Assert.AreEqual("https://document-collector-test.adyen.com/v1/crossBorderInvoices",
                    request.RequestUri.ToString());
                Assert.AreEqual("test-api-key", request.Headers.GetValues("X-API-Key").Single());
                Assert.AreEqual("test-idempotency-key", request.Headers.GetValues("Idempotency-Key").Single());
                Assert.AreEqual("application/json", request.Headers.Accept.Single().MediaType);

                var multipart = request.Content as MultipartFormDataContent;
                Assert.IsNotNull(multipart);
                Assert.AreEqual("multipart/form-data", multipart.Headers.ContentType.MediaType);
                Assert.IsTrue(multipart.Headers.ContentType.Parameters.Any(p => p.Name == "boundary"));
                var parts = multipart.ToDictionary(part => part.Headers.ContentDisposition.Name.Trim('"'));
                Assert.AreEqual(3, parts.Count);
                Assert.AreEqual("paCbInvoice", parts["context"].ReadAsStringAsync().GetAwaiter().GetResult());
                Assert.AreEqual(MerchantAccount, parts["merchantAccount"].ReadAsStringAsync().GetAwaiter().GetResult());
                Assert.AreEqual(FileName, parts["file"].Headers.ContentDisposition.FileName.Trim('"'));
                Assert.AreEqual("application/pdf", parts["file"].Headers.ContentType.MediaType);
                CollectionAssert.AreEqual(fileBytes, parts["file"].ReadAsByteArrayAsync().GetAwaiter().GetResult());
                return JsonResponse(HttpStatusCode.Created, UploadResponse);
            });
            var service = host.Services.GetRequiredService<IDocumentsService>();
            ApiResponse eventResponse = null;
            var responseEventCount = 0;
            service.Events.OnUploadCrossBorderInvoice += (_, args) =>
            {
                eventResponse = args.ApiResponse;
                responseEventCount++;
            };
            using var file = new MemoryStream(fileBytes);

            var response = await service.UploadCrossBorderInvoiceAsync(DocumentContext.PaCbInvoice, file,
                FileName, "application/pdf", MerchantAccount, new RequestOptions().AddIdempotencyKey("test-idempotency-key"));

            Assert.AreEqual(1, requestCount);
            Assert.AreEqual(1, responseEventCount);
            Assert.AreSame<IApiResponse>(response, eventResponse);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.IsTrue(response.IsCreated);
            Assert.IsTrue(response.TryDeserializeCreatedResponse(out var document));
            Assert.AreEqual("paCbInvoice", document.Context);
            Assert.AreEqual(FileName, document.FileName);
            Assert.AreEqual(MerchantAccount, document.MerchantAccount);
            Assert.AreEqual("QRMJC25GDZRKDM92", document.PspReference);
            Assert.IsNull(response.BadRequest());
            Assert.IsFalse(response.TryDeserializeBadRequestResponse(out _));
        }

        [TestMethod]
        public async Task Given_NonSeekableStream_When_Uploaded_Then_SerializesMultipartWithoutSeeking()
        {
            var fileBytes = Encoding.UTF8.GetBytes("%PDF-1.7\nStreamed invoice €\n%%EOF");
            var requestCount = 0;
            using var host = CreateHost(request =>
            {
                requestCount++;
                var multipart = request.Content as MultipartFormDataContent;
                Assert.IsNotNull(multipart);
                Assert.IsNull(multipart.Headers.ContentLength,
                    "A non-seekable source must not require a known multipart length.");
                var filePart = multipart.Single(part =>
                    part.Headers.ContentDisposition.Name.Trim('"') == "file");
                Assert.AreEqual(FileName, filePart.Headers.ContentDisposition.FileName.Trim('"'));
                Assert.AreEqual("application/pdf", filePart.Headers.ContentType.MediaType);

                using var serialized = new MemoryStream();
                multipart.CopyToAsync(serialized).GetAwaiter().GetResult();
                StringAssert.Contains(Encoding.Latin1.GetString(serialized.ToArray()),
                    "\r\n\r\n" + Encoding.Latin1.GetString(fileBytes) + "\r\n",
                    "Multipart serialization must preserve every byte from the non-seekable source.");
                return JsonResponse(HttpStatusCode.Created, UploadResponse);
            });
            var service = host.Services.GetRequiredService<IDocumentsService>();
            using var file = new NonSeekableReadStream(fileBytes);

            var response = await service.UploadCrossBorderInvoiceAsync(DocumentContext.PaCbInvoice, file,
                FileName, "application/pdf", MerchantAccount);

            Assert.AreEqual(1, requestCount);
            Assert.IsTrue(response.TryDeserializeCreatedResponse(out var document));
            Assert.AreEqual(FileName, document.FileName);
        }

        [TestMethod]
        public async Task Given_NullContentType_When_Uploaded_Then_UsesOctetStream()
        {
            using var host = CreateHost(request =>
            {
                var part = ((MultipartFormDataContent)request.Content)
                    .Single(content => content.Headers.ContentDisposition.Name.Trim('"') == "file");
                Assert.AreEqual("application/octet-stream", part.Headers.ContentType.MediaType);
                return JsonResponse(HttpStatusCode.Created, UploadResponse);
            });
            var service = host.Services.GetRequiredService<IDocumentsService>();
            using var file = new MemoryStream();

            await service.UploadCrossBorderInvoiceAsync(DocumentContext.PaCbInvoice, file, FileName, null, MerchantAccount);
        }

        [TestMethod]
        [DataRow(400)]
        [DataRow(401)]
        [DataRow(403)]
        [DataRow(422)]
        [DataRow(500)]
        public async Task Given_ErrorResponse_When_Uploaded_Then_DeserializesMatchingError(int statusCode)
        {
            var json = $$"""
                {"status":{{statusCode}},"title":"Upload failed","detail":"Invoice could not be uploaded.","errorCode":"TEST_ERROR"}
                """;
            using var host = CreateHost(_ => JsonResponse((HttpStatusCode)statusCode, json));
            var service = host.Services.GetRequiredService<IDocumentsService>();
            var responseEventCount = 0;
            var errorEventCount = 0;
            service.Events.OnUploadCrossBorderInvoice += (_, _) => responseEventCount++;
            service.Events.OnErrorUploadCrossBorderInvoice += (_, _) => errorEventCount++;
            using var file = new MemoryStream();

            var response = await service.UploadCrossBorderInvoiceAsync(DocumentContext.PaCbInvoice, file,
                FileName, "application/pdf", MerchantAccount);

            Assert.AreEqual((HttpStatusCode)statusCode, response.StatusCode);
            Assert.IsFalse(response.IsCreated);
            Assert.AreEqual(statusCode == 400, response.IsBadRequest);
            Assert.AreEqual(statusCode == 401, response.IsUnauthorized);
            Assert.AreEqual(statusCode == 403, response.IsForbidden);
            Assert.AreEqual(statusCode == 422, response.IsUnprocessableContent);
            Assert.AreEqual(statusCode == 500, response.IsInternalServerError);
            DefaultErrorResponseEntity error;
            var deserialized = statusCode switch
            {
                400 => response.TryDeserializeBadRequestResponse(out error),
                401 => response.TryDeserializeUnauthorizedResponse(out error),
                403 => response.TryDeserializeForbiddenResponse(out error),
                422 => response.TryDeserializeUnprocessableContentResponse(out error),
                _ => response.TryDeserializeInternalServerErrorResponse(out error)
            };
            Assert.IsTrue(deserialized);
            Assert.AreEqual(statusCode, error.Status);
            Assert.AreEqual("Upload failed", error.Title);
            Assert.AreEqual("Invoice could not be uploaded.", error.Detail);
            Assert.AreEqual("TEST_ERROR", error.ErrorCode);
            Assert.IsNull(response.Created());
            Assert.IsFalse(response.TryDeserializeCreatedResponse(out _));
            Assert.AreEqual(1, responseEventCount);
            Assert.AreEqual(0, errorEventCount);
        }

        [TestMethod]
        public async Task Given_MalformedCreatedResponse_When_Deserialized_Then_ReturnsFalse()
        {
            using var host = CreateHost(_ => JsonResponse(HttpStatusCode.Created, "not json"));
            var service = host.Services.GetRequiredService<IDocumentsService>();
            using var file = new MemoryStream();

            var response = await service.UploadCrossBorderInvoiceAsync(DocumentContext.PaCbInvoice, file,
                FileName, "application/pdf", MerchantAccount);

            Assert.IsTrue(response.IsCreated);
            Assert.IsFalse(response.TryDeserializeCreatedResponse(out var document));
            Assert.IsNull(document);
        }

        [TestMethod]
        [DataRow("context", null)]
        [DataRow("file", null)]
        [DataRow("merchantAccount", null)]
        [DataRow("fileName", null)]
        [DataRow("fileName", "")]
        [DataRow("fileName", " ")]
        public async Task Given_MissingRequiredArgument_When_Uploaded_Then_ThrowsBeforeSending(
            string parameterName, string fileName)
        {
            var requestCount = 0;
            using var host = CreateHost(_ =>
            {
                requestCount++;
                return JsonResponse(HttpStatusCode.Created, UploadResponse);
            });
            var service = host.Services.GetRequiredService<IDocumentsService>();
            Exception eventException = null;
            service.Events.OnErrorUploadCrossBorderInvoice += (_, args) => eventException = args.Exception;
            using var file = new MemoryStream();

            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                service.UploadCrossBorderInvoiceAsync(
                    parameterName == "context" ? null : DocumentContext.PaCbInvoice,
                    parameterName == "file" ? null : file,
                    parameterName == "fileName" ? fileName : FileName,
                    "application/pdf",
                    parameterName == "merchantAccount" ? null : MerchantAccount));

            Assert.AreEqual(parameterName, exception.ParamName);
            Assert.AreSame(exception, eventException);
            Assert.AreEqual(0, requestCount);
        }

        [TestMethod]
        public async Task Given_TransportFailure_When_Uploaded_Then_RethrowsAndRaisesErrorEvent()
        {
            var expectedException = new HttpRequestException("Test connection failure.");
            using var host = CreateHost(_ => throw expectedException);
            var service = host.Services.GetRequiredService<IDocumentsService>();
            Exception eventException = null;
            var responseEventCount = 0;
            service.Events.OnErrorUploadCrossBorderInvoice += (_, args) => eventException = args.Exception;
            service.Events.OnUploadCrossBorderInvoice += (_, _) => responseEventCount++;
            using var file = new MemoryStream();

            var exception = await Assert.ThrowsExactlyAsync<HttpRequestException>(() =>
                service.UploadCrossBorderInvoiceAsync(DocumentContext.PaCbInvoice, file, FileName,
                    "application/pdf", MerchantAccount));

            Assert.AreSame(expectedException, exception);
            Assert.AreSame(exception, eventException);
            Assert.AreEqual(0, responseEventCount);
        }

        private sealed class NonSeekableReadStream : Stream
        {
            private readonly MemoryStream _source;

            public NonSeekableReadStream(byte[] bytes)
            {
                _source = new MemoryStream(bytes);
            }

            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position
            {
                get => throw new NotSupportedException();
                set => throw new NotSupportedException();
            }

            public override int Read(byte[] buffer, int offset, int count) =>
                _source.Read(buffer, offset, Math.Min(count, 3));

            public override void Flush() => throw new NotSupportedException();
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                    _source.Dispose();
                base.Dispose(disposing);
            }
        }

        private static IHost CreateHost(Func<HttpRequestMessage, HttpResponseMessage> handler)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureDocumentCollector((_, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddDocumentsService(httpClientBuilderOptions: builder =>
                        builder.AddHttpMessageHandler(() => new MockDelegatingHandler(handler)));
                })
                .Build();
        }

        private static HttpResponseMessage JsonResponse(HttpStatusCode statusCode, string json)
        {
            return new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }
    }
}
