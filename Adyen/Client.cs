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
using System.Net.Http;
using Adyen.Constants;
using Adyen.HttpClient.Interfaces;
using Adyen.HttpClient;
using Adyen.Exceptions;
using Environment = Adyen.Model.Environment;

namespace Adyen
{
    public class Client
    {
        private IClient _client;

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
            _client = new HttpClientWrapper(Config, new System.Net.Http.HttpClient());
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
            _client = new HttpClientWrapper(Config, new System.Net.Http.HttpClient());
        }

        public Client(Config config)
        {
            Config = config;
            SetEnvironment(Config.Environment, Config.LiveEndpointUrlPrefix);
            _client = new HttpClientWrapper(Config, new System.Net.Http.HttpClient());
        }

        public Client(Config config, System.Net.Http.HttpClient httpClient)
        {
            Config = config;
            SetEnvironment(Config.Environment, Config.LiveEndpointUrlPrefix);
            _client = new HttpClientWrapper(Config, httpClient);
        }

        public Client(Config config, IHttpClientFactory factory, string clientName = null)
        {
            Config = config;
            SetEnvironment(config.Environment, Config.LiveEndpointUrlPrefix);
            _client = clientName != null ? new HttpClientWrapper(Config, factory.CreateClient(clientName)) : new HttpClientWrapper(Config, factory.CreateClient());
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
                    Config.ManagementEndpoint = ClientConfig.ManagementEndpointTest;
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
                    Config.ManagementEndpoint = ClientConfig.ManagementEndpointLive;
                    break;
            }
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
