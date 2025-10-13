#nullable enable

using System;

namespace Adyen.Core.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// The reason the api request failed
        /// </summary>
        public string? ReasonPhrase { get; }

        /// <summary>
        /// The HttpStatusCode
        /// </summary>
        public System.Net.HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw data returned by the API
        /// </summary>
        public string RawContent { get; }
        
        /// <summary>
        /// Construct the ApiException from parts of the response
        /// </summary>
        /// <param name="reasonPhrase">Reason for ApiException</param>
        /// <param name="statusCode"><see cref="System.Net.HttpStatusCode"/></param>
        /// <param name="rawContent">Raw content</param>
        public ApiException(string? reasonPhrase, System.Net.HttpStatusCode statusCode, string rawContent) : base(reasonPhrase ?? rawContent)
        {
            ReasonPhrase = reasonPhrase;
            StatusCode = statusCode;
            RawContent = rawContent;
        }
    }
}
