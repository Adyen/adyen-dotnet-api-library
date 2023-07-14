using System;
using System.Net.Http;
using Adyen.Constants;
using Adyen.Exceptions;
using Adyen.HttpClient;
using Adyen.HttpClient.Interfaces;
using Environment = Adyen.Model.Environment;

namespace Adyen
{
    public class Client
    {
        public Config Config { get; set; }

        public string ApplicationName { get; set; }

        public delegate void CallbackLogHandler(string message);

        public event CallbackLogHandler LogCallback;

        [Obsolete("Providing username and password are obsolete, please use Config instead.")]
        public Client(string username, string password, Environment environment, string liveEndpointUrlPrefix = null)
        {
            Config = new Config
            {
                Username = username,
                Password = password,
                Environment = environment
            };
            SetEnvironment(environment, liveEndpointUrlPrefix);
            
            HttpClient = new HttpClientWrapper(Config, GetHttpClient());
        }
        
        [Obsolete("Providing x-api-key is obsolete, please use Config instead.")]
        public Client(string xapikey, Environment environment, string liveEndpointUrlPrefix = null)
        {
            Config = new Config
            {
                XApiKey = xapikey,
                Environment = environment,
                LiveEndpointUrlPrefix = liveEndpointUrlPrefix
            };
            SetEnvironment(environment, Config.LiveEndpointUrlPrefix);

            HttpClient = new HttpClientWrapper(Config, GetHttpClient());
        }

        public Client(Config config)
        {
            Config = config;
            SetEnvironment(Config.Environment, Config.LiveEndpointUrlPrefix);
            
            HttpClient = new HttpClientWrapper(Config, GetHttpClient());
        }

        public Client(Config config, System.Net.Http.HttpClient httpClient)
        {
            Config = config;
            SetEnvironment(Config.Environment, Config.LiveEndpointUrlPrefix);
            HttpClient = new HttpClientWrapper(Config, httpClient);
        }

        public Client(Config config, IHttpClientFactory factory, string clientName = null)
        {
            Config = config;
            SetEnvironment(config.Environment, Config.LiveEndpointUrlPrefix);
            HttpClient = clientName != null ? new HttpClientWrapper(Config, factory.CreateClient(clientName)) : new HttpClientWrapper(Config, factory.CreateClient());
        }

        public void SetEnvironment(Environment environment, string liveEndpointUrlPrefix)
        {
            switch (environment)
            {
                case Environment.Test:
                    Config.Endpoint = ClientConfig.EndpointTest;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointTest;
                    Config.CheckoutEndpoint = ClientConfig.CheckoutEndpointTest;
                    Config.MarketPayEndpoint = ClientConfig.MarketpayEndPointTest;
                    Config.PosTerminalManagementEndpoint = ClientConfig.PosTerminalManagementEndpointTest;
                    Config.LegalEntityManagementEndpoint = ClientConfig.LegalEntityManagementEndpointTest;
                    Config.StoredValueEndpoint = ClientConfig.StoredValueEndpointTest;
                    Config.ManagementEndpoint = ClientConfig.ManagementEndpointTest;
                    Config.TransfersEndpoint = ClientConfig.TransfersEndpointTest;
                    Config.DataProtectionEndpoint = ClientConfig.DataProtectionEndpointTest;
                    break;
                case Environment.Live:
                    if (string.IsNullOrEmpty(liveEndpointUrlPrefix))
                    {
                        throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix);
                    }

                    Config.Endpoint = ClientConfig.EndpointProtocol + liveEndpointUrlPrefix + ClientConfig.EndpointLiveSuffix;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointEULive;
                    Config.CheckoutEndpoint = ClientConfig.EndpointProtocol + liveEndpointUrlPrefix + ClientConfig.CheckoutEndpointLiveSuffix;
                    Config.MarketPayEndpoint = ClientConfig.MarketpayEndPointLive;
                    Config.PosTerminalManagementEndpoint = ClientConfig.PosTerminalManagementEndpointLive;
                    Config.LegalEntityManagementEndpoint = ClientConfig.LegalEntityManagementEndpointLive;
                    Config.StoredValueEndpoint = ClientConfig.StoredValueEndpointLive;
                    Config.ManagementEndpoint = ClientConfig.ManagementEndpointLive;
                    Config.TransfersEndpoint = ClientConfig.TransfersEndpointLive;
                    Config.DataProtectionEndpoint = ClientConfig.DataProtectionEndpointLive;
                    break;
            }
        }

        // Get a new HttpClient and set a timeout
        private System.Net.Http.HttpClient GetHttpClient()
        {
            // Set Timeout for HttpClient
            var httpClient = new System.Net.Http.HttpClient(HttpClientExtensions.ConfigureHttpMessageHandler(Config));
            if (Config.Timeout != default)
            {
                httpClient.Timeout = TimeSpan.FromMilliseconds(Config.Timeout);
            }
            return httpClient;
        }

        public IClient HttpClient { get; set; }

        public string ApiVersion => ClientConfig.ApiVersion;

        public string RecurringApiVersion => ClientConfig.RecurringApiVersion;

        public string LibraryVersion => ClientConfig.LibVersion;

        public void LogLine(string message)
        {
            if (LogCallback != null)
            {
                LogCallback(message);
            }
        }
    }
}
