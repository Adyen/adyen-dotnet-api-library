#nullable enable

using System;
using System.Net.Http.Headers;

namespace Adyen.Core.Auth
{
    /// <summary>
    /// A token constructed from a username and password.
    /// </summary>
    public class BasicToken : TokenBase
    {
        private readonly string _username;

        private readonly string _password;

        /// <summary>
        /// The key of the header for basic authentication.
        /// </summary>
        public string Key { get; set; } = "Basic";
        
        /// <summary>
        /// Constructs a BasicToken object.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="timeout"></param>
        public BasicToken(string username, string password, TimeSpan? timeout = null) : base()
        {
            _username = username;
            _password = password;
        }

        /// <summary>
        /// Places the username/password token in the header.
        /// </summary>
        /// <param name="request"><see cref="System.Net.Http.HttpRequestMessage"/></param>
        public virtual void UseInHeader(global::System.Net.Http.HttpRequestMessage request)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue(Key, Base64Encode(_username + ":" + _password));
        }
        
        /// <summary>
        /// Encodes <param name="value"></param> to a Base64-string.
        /// </summary>
        /// <param name="value">The string to encode.</param>
        /// <returns>Base64-encoded string.</returns>
        private static string Base64Encode(string value)
        {
            return Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(value));
        }
    }
}