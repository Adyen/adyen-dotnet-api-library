using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.HttpClient;
using Adyen.EcommLibrary.HttpClient.Interfaces;
using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary
{
    public class Client
    {
        public Config Config { get; set; }
        private IClient _client;
        
        public Client(string username, string password, Environment environment, string applicationName)
        {
            Config = new Config
            {
                Username = username,
                Password = password,
                ApplicationName = applicationName,
                Environment = environment
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
                    break;

                case Environment.Live:
                    Config.Endpoint = ClientConfig.EndpointLive;
                    Config.HppEndpoint = ClientConfig.HppLive;
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
        
    }

}
