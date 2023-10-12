using System.Net;
using Adyen.Model;

namespace Adyen
{
    public class Config
    {
        //Merchant details
        public string Username { get; set; }
        public string Password { get; set; }
        public Environment Environment { get; set; }
        public string LiveEndpointUrlPrefix { get; set; }
        public string Endpoint { get; set; }
        public string ApplicationName { get; set; }
        public IWebProxy Proxy { get; set; }
        //Terminal cloud api
        public string XApiKey { get; set; }
        // Timeout in milliseconds
        public int Timeout { get; set; }
        public string CloudApiEndPoint { get; set; }
        // Local TAPI endpoint
        public string LocalTerminalApiEndpoint { get; set; }
        public bool HasPassword => !string.IsNullOrEmpty(Password);
        public bool HasApiKey => !string.IsNullOrEmpty(XApiKey);
        public BaseUrlConfig BaseUrlConfig { get; set; }
    }
}