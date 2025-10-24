using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adyen.Core.Client;

namespace Adyen.Core.Tests
{
    [TestClass]
    public class ApiResponseTests
    {
        private HttpRequestMessage CreateRequest(string? uri = "https://adyen.com")
            => new HttpRequestMessage(HttpMethod.Get, uri);

        private HttpResponseMessage CreateResponse(HttpStatusCode statusCode, string reasonPhrase = "")
            => new HttpResponseMessage(statusCode)
            {
                ReasonPhrase = reasonPhrase
            };

        [TestMethod]
        [DataRow(HttpStatusCode.OK, true)]
        [DataRow(HttpStatusCode.Created, true)]
        [DataRow(HttpStatusCode.Accepted, true)]
        [DataRow(HttpStatusCode.BadRequest, false)]
        [DataRow(HttpStatusCode.Unauthorized, false)]
        [DataRow(HttpStatusCode.Forbidden, false)]
        [DataRow(HttpStatusCode.NotFound, false)]
        [DataRow(HttpStatusCode.TooManyRequests, false)]
        [DataRow(HttpStatusCode.UnprocessableEntity, false)]
        [DataRow(HttpStatusCode.InternalServerError, false)]
        public void Given_ApiResponse_When_SuccessStatusCode_Then_Result_ShouldMatchHttpResponseMessage(HttpStatusCode code, bool expected)
        {
            // Arrange
            // Act
            var response = new ApiResponse(CreateRequest(), CreateResponse(code), "", "/", DateTime.UtcNow, new JsonSerializerOptions());
            // Assert
            Assert.AreEqual(expected, response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void Given_ApiResponse_When_Properties_Are_Set_Then_Object_Should_Return_Correct_Values()
        {
            // Arrange
            var request = CreateRequest("https://adyen.com/");
            
            // Act
            var responseMessage = CreateResponse(HttpStatusCode.Accepted, "Accepted");
            var apiResponse = new ApiResponse(request, responseMessage, "{\"key\":\"value\"}", "/path", DateTime.UtcNow, new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(responseMessage.StatusCode, apiResponse.StatusCode);
            Assert.AreEqual(responseMessage.ReasonPhrase, apiResponse.ReasonPhrase);
            Assert.AreEqual(request.RequestUri, apiResponse.RequestUri);
            Assert.AreEqual("/path", apiResponse.Path);
            Assert.IsNotNull(apiResponse.Headers);
            Assert.AreEqual("{\"key\":\"value\"}", apiResponse.RawContent);
            Assert.IsNull(apiResponse.ContentStream);
        }

        [TestMethod]
        public void Given_ApiResponse_When_ContentStream_Is_Set_Then_Return_ContentStream_And_Empty_RawContent()
        {
            // Arrange
            var request = CreateRequest();
            var responseMessage = CreateResponse(HttpStatusCode.OK);
            
            // Act
            var stream = new MemoryStream(new byte[] { 1, 2, 3 });
            var apiResponse = new ApiResponse(request, responseMessage, stream, "/stream", DateTime.UtcNow, new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(stream, apiResponse.ContentStream);
            Assert.AreEqual(string.Empty, apiResponse.RawContent);
        }

        private class ExampleApiResponse<T> : ApiResponse,
            IOk<T>, ICreated<T>, IAccepted<T>,
            IBadRequest<T>, IUnauthorized<T>, IForbidden<T>, ITooManyRequests<T>, INotFound<T>, IUnprocessableContent<T>, IInternalServerError<T>
        {
            public ExampleApiResponse(HttpRequestMessage message, HttpResponseMessage response, string raw, string path, DateTime requested, JsonSerializerOptions opts)
                : base(message, response, raw, path, requested, opts) { }

            private T DeserializeRaw() => JsonSerializer.Deserialize<T>(RawContent, _jsonSerializerOptions)!;

            public T Ok() => DeserializeRaw();
            public bool TryDeserializeOkResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T Created() => DeserializeRaw();
            public bool TryDeserializeCreatedResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T Accepted() => DeserializeRaw();
            public bool TryDeserializeAcceptedResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T BadRequest() => DeserializeRaw();
            public bool TryDeserializeBadRequestResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T Unauthorized() => DeserializeRaw();
            public bool TryDeserializeUnauthorizedResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T Forbidden() => DeserializeRaw();
            public bool TryDeserializeForbiddenResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T TooManyRequests() => DeserializeRaw();
            public bool TryDeserializeTooManyRequestsResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T NotFound() => DeserializeRaw();
            public bool TryDeserializeNotFoundResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T UnprocessableContent() => DeserializeRaw();
            public bool TryDeserializeUnprocessableContentResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }

            public T InternalServerError() => DeserializeRaw();
            public bool TryDeserializeInternalServerErrorResponse(out T? result) { result = string.IsNullOrEmpty(RawContent) ? default : DeserializeRaw(); return result != null; }
        }
        
        private record TestModel(string Foo);

        [TestMethod]
        public void Given_ApiResponse_When_TypedResponses_Then_Deserialize_Correctly()
        {
            // Arrange
            var model = new TestModel("adyen");
            
            // Act
            string json = JsonSerializer.Serialize(model, new JsonSerializerOptions());
            var response = new ExampleApiResponse<TestModel>(CreateRequest(), CreateResponse(HttpStatusCode.OK), json, "/path", DateTime.UtcNow, new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(model, response.Ok());
            Assert.IsTrue(response.TryDeserializeOkResponse(out var okResult));
            Assert.AreEqual(model, okResult);

            Assert.AreEqual(model, response.Created());
            Assert.IsTrue(response.TryDeserializeCreatedResponse(out var createdResult));
            Assert.AreEqual(model, createdResult);

            Assert.AreEqual(model, response.Accepted());
            Assert.IsTrue(response.TryDeserializeAcceptedResponse(out var acceptedResult));
            Assert.AreEqual(model, acceptedResult);

            Assert.AreEqual(model, response.BadRequest());
            Assert.IsTrue(response.TryDeserializeBadRequestResponse(out var badResult));
            Assert.AreEqual(model, badResult);

            Assert.AreEqual(model, response.Unauthorized());
            Assert.IsTrue(response.TryDeserializeUnauthorizedResponse(out var unAuthResult));
            Assert.AreEqual(model, unAuthResult);

            Assert.AreEqual(model, response.Forbidden());
            Assert.IsTrue(response.TryDeserializeForbiddenResponse(out var forbiddenResult));
            Assert.AreEqual(model, forbiddenResult);

            Assert.AreEqual(model, response.TooManyRequests());
            Assert.IsTrue(response.TryDeserializeTooManyRequestsResponse(out var tooManyResult));
            Assert.AreEqual(model, tooManyResult);

            Assert.AreEqual(model, response.NotFound());
            Assert.IsTrue(response.TryDeserializeNotFoundResponse(out var notFoundResult));
            Assert.AreEqual(model, notFoundResult);

            Assert.AreEqual(model, response.UnprocessableContent());
            Assert.IsTrue(response.TryDeserializeUnprocessableContentResponse(out var unprocessableResult));
            Assert.AreEqual(model, unprocessableResult);

            Assert.AreEqual(model, response.InternalServerError());
            Assert.IsTrue(response.TryDeserializeInternalServerErrorResponse(out var internalResult));
            Assert.AreEqual(model, internalResult);
        }
    }
}
