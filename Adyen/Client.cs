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
        private static System.Net.Http.HttpClient _httpClient;

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

        public void SetEnvironment(Environment environment, string liveEndpointUrlPrefix = "")
        {
            Config.Environment = environment;
            Config.LiveEndpointUrlPrefix = liveEndpointUrlPrefix;
    
            // Check if the cloud api endpoint has not already been set
            if (Config.CloudApiEndPoint != null)
            {
                return;
            }
            // If not switch through environment and set default EU
            switch (environment)
            {
                case Environment.Test:
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointTest;
                    break;
                case Environment.Live:
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointEULive;
                    break;
            }
        }
        
        // Get a new HttpClient and set a timeout
        private System.Net.Http.HttpClient GetHttpClient()
        {
            if (_httpClient == null)
                _httpClient = new System.Net.Http.HttpClient(HttpClientExtensions.ConfigureHttpMessageHandler(Config));
            // Set Timeout for HttpClient
            if (Config.Timeout != default)
            {
                _httpClient.Timeout = TimeSpan.FromMilliseconds(Config.Timeout);
            }
            return _httpClient;
        }

        public IClient HttpClient { get; set; }

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
