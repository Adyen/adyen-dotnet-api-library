#nullable enable

using System;

namespace Adyen.Core.Auth
{
    /// <summary>
    /// A token constructed from an ApiKey.
    /// The `ADYEN_API_KEY` is an Adyen API authentication token that must be included in the HTTP request header and allows your application to securely communicate with the Adyen APIs.
    /// Guide on how to obtain the `ADYEN_API_KEY`
    /// 1. Most common use-case for Digital (ECOM) & In-Person payments, visit: https://docs.adyen.com/development-resources/api-credentials/#generate-api-key to get your API Key.
    /// 2. For Platforms & Financial Services, visit: https://docs.adyen.com/adyen-for-platforms-model to get started.
    /// </summary>
    public class ApiKeyToken : TokenBase
    {
        private readonly string _apiKeyValue;

        /// <summary>
        /// The key of the header for your API Key.
        /// </summary>
        public string Key { get; set; } = "X-API-Key";

        /// <summary>
        /// Constructs an ApiKeyToken object.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="prefix"></param>
        public ApiKeyToken(string value, string prefix = "")
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
    }
}