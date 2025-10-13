#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Adyen.Core.Client
{
    /// <summary>
    /// Provides a non-generic contract for the ApiResponse wrapper.
    /// </summary>
    public partial interface IApiResponse
    {
        /// <summary>
        /// The IsSuccessStatusCode from the api response
        /// </summary>
        bool IsSuccessStatusCode { get; }

        /// <summary>
        /// Gets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw content of this response.
        /// </summary>
        string RawContent { get; }
        
        /// <summary>
        /// The raw binary stream (only set for binary responses)
        /// </summary>
        System.IO.Stream? ContentStream { get; }

        /// <summary>
        /// The DateTime when the request was retrieved.
        /// </summary>
        DateTime DownloadedAt { get; }

        /// <summary>
        /// The headers contained in the api response
        /// </summary>
        System.Net.Http.Headers.HttpResponseHeaders Headers { get; }

        /// <summary>
        /// The path used when making the request.
        /// </summary>
        string Path { get; }

        /// <summary>
        /// The reason phrase contained in the api response
        /// </summary>
        string? ReasonPhrase { get; }

        /// <summary>
        /// The DateTime when the request was sent.
        /// </summary>
        DateTime RequestedAt { get; }

        /// <summary>
        /// The Uri used when making the request.
        /// </summary>
        Uri? RequestUri { get; }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public partial class ApiResponse : IApiResponse
    {
        /// <summary>
        /// Gets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw data
        /// </summary>
        public string RawContent { get; protected set; }

        /// <summary>
        /// The raw binary stream (only set for binary responses)
        /// </summary>
        public System.IO.Stream? ContentStream { get; protected set; }

        /// <summary>
        /// The IsSuccessStatusCode from the api response
        /// </summary>
        public bool IsSuccessStatusCode { get; }

        /// <summary>
        /// The reason phrase contained in the api response
        /// </summary>
        public string? ReasonPhrase { get; }

        /// <summary>
        /// The headers contained in the api response
        /// </summary>
        public System.Net.Http.Headers.HttpResponseHeaders Headers { get; }

        /// <summary>
        /// The DateTime when the request was retrieved.
        /// </summary>
        public DateTime DownloadedAt { get; } = DateTime.UtcNow;

        /// <summary>
        /// The DateTime when the request was sent.
        /// </summary>
        public DateTime RequestedAt { get; }

        /// <summary>
        /// The path used when making the request.
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The Uri used when making the request.
        /// </summary>
        public Uri? RequestUri { get; }

        /// <summary>
        /// The <see cref="System.Text.Json.JsonSerializerOptions"/>
        /// </summary>
        protected System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// Construct the response using an HttpResponseMessage
        /// </summary>
        /// <param name="httpRequestMessage"></param>
        /// <param name="httpResponseMessage"></param>
        /// <param name="rawContent"></param>
        /// <param name="path"></param>
        /// <param name="requestedAt"></param>
        /// <param name="jsonSerializerOptions"></param>
        public ApiResponse(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions)
        {
            StatusCode = httpResponseMessage.StatusCode;
            Headers = httpResponseMessage.Headers;
            IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode;
            ReasonPhrase = httpResponseMessage.ReasonPhrase;
            RawContent = rawContent;
            Path = path;
            RequestUri = httpRequestMessage.RequestUri;
            RequestedAt = requestedAt;
            _jsonSerializerOptions = jsonSerializerOptions;
            OnCreated(httpRequestMessage, httpResponseMessage);
        }

        /// <summary>
        /// Construct the response using an HttpResponseMessage
        /// </summary>
        /// <param name="httpRequestMessage"></param>
        /// <param name="httpResponseMessage"></param>
        /// <param name="contentStream"></param>
        /// <param name="path"></param>
        /// <param name="requestedAt"></param>
        /// <param name="jsonSerializerOptions"></param>
        public ApiResponse(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, System.IO.Stream contentStream, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions)
        {
            StatusCode = httpResponseMessage.StatusCode;
            Headers = httpResponseMessage.Headers;
            IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode;
            ReasonPhrase = httpResponseMessage.ReasonPhrase;
            ContentStream = contentStream;
            RawContent = string.Empty;
            Path = path;
            RequestUri = httpRequestMessage.RequestUri;
            RequestedAt = requestedAt;
            _jsonSerializerOptions = jsonSerializerOptions;
            OnCreated(httpRequestMessage, httpResponseMessage);
        }

        partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface IBadRequest<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is BadRequest
        /// </summary>
        /// <returns></returns>
        TType BadRequest();

        /// <summary>
        /// Returns true if the response is BadRequest and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryBadRequest([NotNullWhen(true)]out TType? result);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface IUnauthorized<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is Unauthorized
        /// </summary>
        /// <returns></returns>
        TType Unauthorized();

        /// <summary>
        /// Returns true if the response is Unauthorized and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryUnauthorized([NotNullWhen(true)]out TType? result);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface IForbidden<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is Forbidden
        /// </summary>
        /// <returns></returns>
        TType Forbidden();

        /// <summary>
        /// Returns true if the response is Forbidden and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryForbidden([NotNullWhen(true)]out TType? result);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface IOk<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is Ok
        /// </summary>
        /// <returns></returns>
        TType Ok();

        /// <summary>
        /// Returns true if the response is Ok and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryOk([NotNullWhen(true)]out TType? result);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface IUnprocessableContent<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is UnprocessableContent
        /// </summary>
        /// <returns></returns>
        TType UnprocessableContent();

        /// <summary>
        /// Returns true if the response is UnprocessableContent and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryUnprocessableContent([NotNullWhen(true)]out TType? result);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface IInternalServerError<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is InternalServerError
        /// </summary>
        /// <returns></returns>
        TType InternalServerError();

        /// <summary>
        /// Returns true if the response is InternalServerError and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryInternalServerError([NotNullWhen(true)]out TType? result);
    }

    /// <summary>
    /// An interface for responses of type 
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    public interface ICreated<TType> : IApiResponse
    {
        /// <summary>
        /// Deserializes the response if the response is Created
        /// </summary>
        /// <returns></returns>
        TType Created();

        /// <summary>
        /// Returns true if the response is Created and the deserialized response is not null
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryCreated([NotNullWhen(true)]out TType? result);
    }
}
