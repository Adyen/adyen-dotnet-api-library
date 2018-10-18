using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.HttpClient.Interfaces;
using Adyen.EcommLibrary.HttpClient;
using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary
{
    public class Client
    {
        public Config Config { get; set; }
        private IClient _client;

        public string ApplicationName { get; set; }

        public delegate void CallbackLogHandler(string message);

        public event CallbackLogHandler LogCallback;

        public Client(string username, string password, Environment environment)
        {
            Config = new Config
            {
                Username = username,
                Password = password,
                Environment = environment
            };
            this.SetEnviroment(environment);
        }

        public Client(string xapikey, Environment environment)
        {
            Config = new Config
            {
                Environment = environment,
                XApiKey = xapikey
            };
            this.SetEnviroment(environment);
        }

        public Client(Config config)
        {
            Config = config;
        }

        public void SetEnviroment(Environment environment)
        {
            Config.Environment = environment;
            switch (environment)
            {
                case Environment.Test:
                    Config.Endpoint = ClientConfig.EndpointTest;
                    Config.HppEndpoint = ClientConfig.HppTest;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointTest;
                    break;
                case Environment.Live:
                    Config.Endpoint = ClientConfig.EndpointLive;
                    Config.HppEndpoint = ClientConfig.HppLive;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointLive;
                    break;
            }
        }

        public IClient HttpClient
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpUrlConnectionClient();
                }
                return _client;
            }
            set
            {
                _client = value;
            }
        }

        public string ApiVersion
        {
            get
            {
                return ClientConfig.ApiVersion;
            }
        }

        public string LibraryVersion
        {
            get
            {
                return ClientConfig.LibVersion;

            }
        }

        public void LogLine(string message)
        {
            if (LogCallback != null)
            {
                LogCallback(message);
            }
        }
    }
}
