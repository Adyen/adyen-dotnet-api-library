using System;
using System.Net.Http;
using Adyen.Constants;
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
            
            // Always use GetCloudApiEndpoint to determine the correct endpoint
            Config.CloudApiEndPoint = GetCloudApiEndpoint();
        }
        
        public string GetCloudApiEndpoint()
        {
            // Check if the cloud API endpoint has already been set
            if (Config.CloudApiEndPoint != null)
            {
                return Config.CloudApiEndPoint;
            }
            
            if (Config.Environment == Environment.Test)
            {
                return ClientConfig.CloudApiEndPointTest;
            }

            // For LIVE environment, handle region mapping
            if (Config.Environment == Environment.Live)
            {
                if (!RegionMapping.TERMINAL_API_ENDPOINTS_MAPPING.TryGetValue(Config.TerminalApiRegion, out string endpointUrl))
                {
                    throw new ArgumentOutOfRangeException($"Currently not supported: {Config.TerminalApiRegion}");
                }
                return endpointUrl;
            }
            
            // Default to test endpoint if the environment is not set
            return ClientConfig.CloudApiEndPointTest;
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
