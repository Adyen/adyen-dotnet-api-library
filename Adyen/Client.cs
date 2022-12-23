#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Threading;
using Adyen.Constants;
using Adyen.HttpClient.Interfaces;
using Adyen.HttpClient;
using Adyen.Exceptions;
using Environment = Adyen.Model.Enum.Environment;

namespace Adyen
{
    public class Client
    {
        private readonly System.Net.Http.HttpClient _httpClient;
        private IClient _client;

        public Config Config { get; set; }

        public string ApplicationName { get; set; }

        public delegate void CallbackLogHandler(string message);

        public event CallbackLogHandler LogCallback;

        public Client(string username, string password, Environment environment, System.Net.Http.HttpClient httpClient = null)
        {
            Config = new Config
            {
                Username = username,
                Password = password,
                Environment = environment
            };
            _httpClient = httpClient;
            this.SetEnvironment(environment);
        }
        
        public Client(string username, string password, string liveEndpointUrlPrefix, Environment environment, System.Net.Http.HttpClient httpClient = null)
        {
            Config = new Config
            {
                Username = username,
                Password = password,
                Environment = environment
            };
            _httpClient = httpClient;
            this.SetEnvironment(environment, liveEndpointUrlPrefix);
        }

        public Client(string xapikey, Environment environment, System.Net.Http.HttpClient httpClient = null)
        {
            Config = new Config
            {
                Environment = environment,
                XApiKey = xapikey
            };
            _httpClient = httpClient;
            this.SetEnvironment(environment);
        }

        public Client(string xapikey, Environment environment, string liveEndpointUrlPrefix, System.Net.Http.HttpClient httpClient = null)
        {
            Config = new Config
            {
                Environment = environment,
                XApiKey = xapikey
            };
            _httpClient = httpClient;
            this.SetEnvironment(environment, liveEndpointUrlPrefix);
        }

        public Client(Config config, string liveEndpointUrlPrefix, System.Net.Http.HttpClient httpClient = null)
        {
            Config = config;
            _httpClient = httpClient;
            this.SetEnvironment(config.Environment, liveEndpointUrlPrefix);
        }
        
        public Client(Config config, System.Net.Http.HttpClient httpClient = null)
        {
            Config = config;
            _httpClient = httpClient;
            this.SetEnvironment(config.Environment);
        }

        public void SetEnvironment(Environment environment)
        {
            SetEnvironment(environment, null);
        }

        public void SetEnvironment(Environment environment, string liveEndpointUrlPrefix)
        {
            Config.Environment = environment;
            switch (environment)
            {
                case Environment.Test:
                    Config.Endpoint = ClientConfig.EndpointTest;
                    Config.HppEndpoint = ClientConfig.HppTest;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointTest;
                    Config.CheckoutEndpoint = ClientConfig.CheckoutEndpointTest;
                    Config.MarketPayEndpoint = ClientConfig.MarketpayEndPointTest;
                    Config.PosTerminalManagementEndpoint = ClientConfig.PosTerminalManagementEndpointTest;
                    Config.LegalEntityManagementEndpoint = ClientConfig.LegalEntityManagementEndpointTest;
                    break;
                case Environment.Live:
                    if (string.IsNullOrEmpty(liveEndpointUrlPrefix))
                    {
                        throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix);
                    }

                    Config.Endpoint = ClientConfig.EndpointProtocol + liveEndpointUrlPrefix + ClientConfig.EndpointLiveSuffix;
                    Config.HppEndpoint = ClientConfig.HppLive;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointEULive;
                    Config.CheckoutEndpoint = ClientConfig.EndpointProtocol + liveEndpointUrlPrefix + ClientConfig.CheckoutEndpointLiveSuffix;
                    Config.MarketPayEndpoint = ClientConfig.MarketpayEndPointLive;
                    Config.PosTerminalManagementEndpoint = ClientConfig.PosTerminalManagementEndpointLive;
                    Config.LegalEntityManagementEndpoint = ClientConfig.LegalEntityManagementEndpointLive;
                    break;
            }

            ReloadClient();
        }

        private void ReloadClient()
        {
            _client?.Dispose();
            _client = _httpClient != null
                ? new HttpClientWrapper(Config, _httpClient)
                : (IClient)new HttpWebRequestWrapper(Config);
        }

        public IClient HttpClient
        {
            get => _client;
            set => _client = value;
        }

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
