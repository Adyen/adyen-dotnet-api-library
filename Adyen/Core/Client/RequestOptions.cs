#nullable enable

namespace Adyen.Core.Client
{
    public class RequestOptions
    {
        /// <summary>
        /// Dictionary containing the optional header values. If set, these values will be sent in the HttpRequest when <see cref="AddHeadersToHttpRequestMessage"/> is called.
        /// </summary>
        public IDictionary<string, string> Headers { get; private set; } = new Dictionary<string, string>();
        
        
        #region Helper functions to append headers to the Headers dictionary.
        
        /// <summary>
        /// Add the "IdempotencyKey" to the headers with the given value.
        /// The Adyen API supports idempotency, allowing you to retry a request multiple times while only performing the action once.
        /// This helps avoid unwanted duplication in case of failures and retries. 
        /// </summary>
        /// <param name="idempotencyKey">The value of the IdempotencyKey.</param>
        /// <returns><see cref="RequestOptions"/>.</returns>
        public RequestOptions AddIdempotencyKey(string idempotencyKey)
        {
            this.Headers.Add("Idempotency-Key", idempotencyKey);
            return this;
        }

        /// <summary>
        /// Adds additional custom headers with the given keys and values.
        /// </summary>
        /// <param name="additionalHeaders">The values.</param>
        /// <returns><see cref="RequestOptions"/>.</returns>
        public RequestOptions AddAdditionalHeaders(IDictionary<string, string> additionalHeaders)
        {
            foreach (KeyValuePair<string, string> kvp in additionalHeaders)
                this.Headers.Add(kvp.Key, kvp.Value);
            return this;
        }
        
        /// <summary>
        /// Adds the "WWW-Authenticate" to the headers with the given value. Used in the Configuration and Transfers API.
        /// </summary>
        /// <param name="wwwAuthenticate">The value of WWW-Authenticate.</param>
        /// <returns><see cref="RequestOptions"/>.</returns>
        public RequestOptions AddWWWAuthenticateHeader(string wwwAuthenticate)
        {
            this.Headers.Add("WWW-Authenticate", wwwAuthenticate);
            return this;
        }
        
        /// <summary>
        /// Adds the "x-requested-verification-code" to the headers with the given value. Used in the LegalEntityManagement API.
        /// </summary>
        /// <param name="xRequestedVerificationCodeHeader">The value of x-requested-verification-code.</param>
        /// <returns><see cref="RequestOptions"/>.</returns>
        public RequestOptions AddxRequestedVerificationCodeHeader(string xRequestedVerificationCodeHeader)
        {
            this.Headers.Add("x-requested-verification-code", xRequestedVerificationCodeHeader);
            return this;
        }
        
        #endregion
        
        /// <summary>
        /// Adds all key-value-pairs from <see cref="Headers"/> to the <see cref="System.Net.Http.HttpRequestMessage"/> header.
        /// </summary>
        /// <param name="httpRequestMessage"><see cref="System.Net.Http.HttpRequestMessage"/></param>
        public System.Net.Http.HttpRequestMessage AddHeadersToHttpRequestMessage(System.Net.Http.HttpRequestMessage httpRequestMessage)
        {
            foreach (KeyValuePair<string, string> header in this.Headers)
                httpRequestMessage.Headers.Add(header.Key, header.Value);
            return httpRequestMessage;
        }
    }
}