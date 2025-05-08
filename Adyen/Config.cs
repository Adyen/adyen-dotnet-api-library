using System.Net;
using Adyen.Constants;
using Adyen.Model;

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
        /// Timeout in milliseconds.
        /// </summary>
        public int Timeout { get; set; }
        public string CloudApiEndPoint { get; set; }
        
        /// <summary>
        /// The url of the Terminal Api endpoint, can be overriden if you want to send local terminal-api requests.
        /// </summary>
        public string LocalTerminalApiEndpoint { get; set; }
        
        public BaseUrlConfig BaseUrlConfig { get; set; }
        
        public Region TerminalApiRegion { get; set; } 
    }
}