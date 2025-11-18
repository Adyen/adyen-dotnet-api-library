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
            SetEnvironment(environment, liveEndpointUrlPrefix, Config.TerminalApiRegion, Config.CloudApiEndPoint);
            
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
            SetEnvironment(environment, Config.LiveEndpointUrlPrefix, Config.TerminalApiRegion, Config.CloudApiEndPoint);
            HttpClient = new HttpClientWrapper(Config, GetHttpClient());
        }

        public Client(Config config)
        {
            Config = config;
            SetEnvironment(config.Environment, config.LiveEndpointUrlPrefix, config.TerminalApiRegion, config.CloudApiEndPoint);
            HttpClient = new HttpClientWrapper(config, GetHttpClient());
        }

        public Client(Config config, System.Net.Http.HttpClient httpClient)
        {
            Config = config;
            SetEnvironment(config.Environment, config.LiveEndpointUrlPrefix, config.TerminalApiRegion, config.CloudApiEndPoint);
            HttpClient = new HttpClientWrapper(config, httpClient);
        }

        public Client(Config config, IHttpClientFactory factory, string clientName = null)
        {
            Config = config;
            SetEnvironment(config.Environment, config.LiveEndpointUrlPrefix, config.TerminalApiRegion, config.CloudApiEndPoint);
            HttpClient = clientName != null ? new HttpClientWrapper(config, factory.CreateClient(clientName)) : new HttpClientWrapper(Config, factory.CreateClient());
        }

        /// <summary>
        /// Configures the environment.
        /// </summary>
        /// <param name="environment">Specifies whether the <see cref="Environment"/> is Test or Live.</param>
        /// <param name="liveEndpointUrlPrefix"> The prefix for live endpoint URLs. Required for live configurations, see: https://docs.adyen.com/development-resources/live-endpoints".</param>
        /// <param name="region">Specifies the geographical region for the Terminal API integration, the passed <see cref="Region"/> is used to automatically determine this endpoint URL, see: https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#live-endpoints.</param>
        /// <param name="cloudApiEndpoint">Specifies the cloud endpoint for the Terminal API integration. This URL is where your SaleToPOIMessage(s) are sent. You can override this value for (mock) testing purposes.</param>
        public void SetEnvironment(Environment environment, string liveEndpointUrlPrefix = "", Region region = Region.EU, string cloudApiEndpoint = null)
        {
            Config.Environment = environment;
            Config.LiveEndpointUrlPrefix = liveEndpointUrlPrefix;
            Config.TerminalApiRegion = region;
            Config.CloudApiEndPoint = cloudApiEndpoint;
            Config.CloudApiEndPoint = GetCloudApiEndpoint();
        }

        /// <summary>
        /// Retrieves the current terminal-api endpoint URL for sending the SaleToPoiMessage(s).
        /// </summary>
        /// <returns>The full terminal-api endpoint URL for the Cloud Terminal API integration.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the specified <see cref="Region"/> is not part of <see cref="RegionMapping.TERMINAL_API_ENDPOINTS_MAPPING"/>.</exception>
        public string GetCloudApiEndpoint()
        {
            // Check if the cloud API endpoint has already been set
            if (Config.CloudApiEndPoint != null)
            {
                return Config.CloudApiEndPoint;
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
            
            // Default to test endpoint if the environment is TEST (default).
            return ClientConfig.CloudApiEndPointTest;
        }

        // Get a new HttpClient and set a timeout
        private System.Net.Http.HttpClient GetHttpClient()
        {
            if (_httpClient == null)
            {
                _httpClient = new System.Net.Http.HttpClient(HttpClientExtensions.ConfigureHttpMessageHandler(Config))
                {
                    Timeout = TimeSpan.FromMilliseconds(Config.Timeout)
                };
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
