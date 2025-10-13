#nullable enable

using System;

namespace Adyen.Core.Auth
{
    /// <summary>
    /// A token constructed from an apiKey.
    /// </summary>
    public class ApiKeyToken : TokenBase
    {
        private string _apiKeyValue;

        /// <summary>
        /// The key of the header for your API Key.
        /// </summary>
        public string Key { get; } = "X-API-Key";

        /// <summary>
        /// Constructs an ApiKeyToken object.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="prefix"></param>
        /// <param name="timeout"></param>
        public ApiKeyToken(string value, string prefix = "", TimeSpan? timeout = null) : base(timeout)
        {
            _apiKeyValue = $"{prefix}{value}";
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        public virtual void UseInHeader(global::System.Net.Http.HttpRequestMessage request)
        {
            request.Headers.Add(Key, _apiKeyValue);
        }
        
        /// <summary>
        /// Places the token in the query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="uriBuilder"></param>
        /// <param name="parseQueryString"></param>
        public virtual void UseInQuery(global::System.Net.Http.HttpRequestMessage request, UriBuilder uriBuilder, System.Collections.Specialized.NameValueCollection parseQueryString)
        {
            parseQueryString[Key] = Uri.EscapeDataString(_apiKeyValue);
        }
    }
}