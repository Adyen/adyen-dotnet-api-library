using System.Net.Http;

namespace Adyen.Core.Client.Extensions
{
    /// <summary>
    /// Extension function that adds custom headers and UserAgent to the <see cref="HttpRequestMessage"/>.
    /// </summary>
    public static class HttpRequestMessageExtensions
    {
        /// <summary>
        /// The name of the application.
        /// </summary>
        public static string ApplicationName { get; set; }

        /// <summary>
        /// Name of this library. This will be sent as a part of the headers.
        /// </summary>
        public const string AdyenLibraryName = "adyen-dotnet-api-library";
        
        /// <summary>
        /// Version of this library.
        /// </summary>
        public const string AdyenLibraryVersion = "34.0.0"; // Updated by release-automation-action

        /// <summary>
        /// Adds the UserAgent to the headers of the <see cref="HttpRequestMessage"/> object.
        /// </summary>
        /// <param name="httpRequestMessage"><see cref="HttpRequestMessage"/>.</param>
        /// <returns><see cref="HttpRequestMessage"/>.</returns>
        public static HttpRequestMessage AddUserAgentToHeaders(this HttpRequestMessage httpRequestMessage)
        {
            // Add application name if set.
            if (!string.IsNullOrWhiteSpace(ApplicationName)) 
            {
                httpRequestMessage.Headers.Add("UserAgent", $"{ApplicationName} {AdyenLibraryName}/{AdyenLibraryVersion}");
                return httpRequestMessage;
            }

            httpRequestMessage.Headers.Add("UserAgent", $"{AdyenLibraryName}/{AdyenLibraryVersion}");
            return httpRequestMessage;
        }
        
        /// <summary>
        /// Adds the <see cref="AdyenLibraryName"/> to the headers of the <see cref="HttpRequestMessage"/> object.
        /// </summary>
        /// <param name="httpRequestMessage"><see cref="HttpRequestMessage"/>.</param>
        /// <returns><see cref="HttpRequestMessage"/>.</returns>
        public static HttpRequestMessage AddLibraryNameToHeader(this HttpRequestMessage httpRequestMessage)
        {
            httpRequestMessage.Headers.Add("adyen-library-name", AdyenLibraryName);
            return httpRequestMessage;
        }
        
        /// <summary>
        /// Adds the <see cref="AdyenLibraryVersion"/> to the headers of the <see cref="HttpRequestMessage"/> object.
        /// </summary>
        /// <param name="httpRequestMessage"><see cref="HttpRequestMessage"/>.</param>
        /// <returns><see cref="HttpRequestMessage"/>.</returns>
        public static HttpRequestMessage AddLibraryVersionToHeader(this HttpRequestMessage httpRequestMessage)
        {
            httpRequestMessage.Headers.Add("adyen-library-version", AdyenLibraryVersion);
            return httpRequestMessage;
        }
    }
}