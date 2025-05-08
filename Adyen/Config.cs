using System;
using System.Net;
using Adyen.Constants;
using Environment = Adyen.Model.Environment;

namespace Adyen
{
    public class Config
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool HasPassword => !string.IsNullOrEmpty(Password);
        
        public Environment Environment { get; set; }
        public string LiveEndpointUrlPrefix { get; set; }
        public string ApplicationName { get; set; }
        public IWebProxy Proxy { get; set; }
        
        /// <summary>
        /// Your Adyen API key.
        /// </summary>
        public string XApiKey { get; set; }
        public bool HasApiKey => !string.IsNullOrEmpty(XApiKey);
        
        /// <summary>
        /// HttpConnection Timeout in milliseconds.
        /// </summary>
        public int Timeout { get; set; } = 60000;
        
        /// <summary>
        /// Force reconnection to refresh DNS and avoid stale connections.
        /// Once a connection exceeds the specified lifetime, it is no longer considered reusable and it is closed & removed from the pool.
        /// This value is only used in <seealso cref="Adyen.HttpClient.HttpClientExtensions"/> when no default <see cref="HttpClient"/> was passed in the <see cref="Client"/> constructor.
        /// </summary>
        public TimeSpan PooledConnectionLifetime = TimeSpan.FromMinutes(5);
                
        /// <summary>
        /// Close idle connections after the specified time.
        /// This value is only used in <seealso cref="Adyen.HttpClient.HttpClientExtensions"/> when no default <see cref="HttpClient"/> was passed in the <see cref="Client"/> constructor.
        /// </summary>
        public TimeSpan PooledConnectionIdleTimeout = TimeSpan.FromMinutes(2);

        /// <summary>
        /// Maximum number of concurrent TCP connections per server.
        /// This value is only used in <seealso cref="Adyen.HttpClient.HttpClientExtensions"/> when no default <see cref="HttpClient"/> was passed in the <see cref="Client"/> constructor.
        /// </summary>
        public int MaxConnectionsPerServer = 2;

        /// <summary>
        /// The url of the Cloud Terminal Api endpoint.
        /// This value is populated when specifying the <see cref="TerminalApiRegion"/> in <see cref="Client"/>.
        /// </summary>
        public string CloudApiEndPoint { get; set; }
        
        /// <summary>
        /// The url of the Terminal Api endpoint, can be overriden if you want to send local terminal-api requests.
        /// </summary>
        public string LocalTerminalApiEndpoint { get; set; }
        
        public BaseUrlConfig BaseUrlConfig { get; set; }
        
        public Region TerminalApiRegion { get; set; } 
    }
}