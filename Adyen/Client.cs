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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using Adyen.Constants;
using Adyen.HttpClient.Interfaces;
using Adyen.HttpClient;
using Adyen.Exceptions;
using Environment = Adyen.Model.Enum.Environment;

namespace Adyen
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
            this.SetEnvironment(environment);
        }
        
        public Client(string xapikey, Environment environment)
        {
            Config = new Config
            {
                Environment = environment,
                XApiKey = xapikey
            };
            this.SetEnvironment(environment);
        }

        public Client(string xapikey, Environment environment, string liveEndpointUrlPrefix)
        {
            Config = new Config
            {
                Environment = environment,
                XApiKey = xapikey
            };
            this.SetEnvironment(environment,liveEndpointUrlPrefix);
        }

        public Client(Config config)
        {
            Config = config;
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
                    break;
                case Environment.Live:
                    if (string.IsNullOrEmpty(liveEndpointUrlPrefix))
                    {
                        throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix);
                    }

                    Config.Endpoint = ClientConfig.EndpointProtocol + liveEndpointUrlPrefix + ClientConfig.EndpointLiveSuffix;
                    Config.HppEndpoint = ClientConfig.HppLive;
                    Config.CloudApiEndPoint = ClientConfig.CloudApiEndPointLive;
                    Config.CheckoutEndpoint = ClientConfig.EndpointProtocol + liveEndpointUrlPrefix + ClientConfig.CheckoutEndpointLiveSuffix;
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

        public string RecurringApiVersion
        {
            get
            {
                return ClientConfig.RecurringApiVersion;
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
