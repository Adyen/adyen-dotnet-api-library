using System;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service
{
    public class ServiceResource
    {
        private readonly AbstractService _abstractService;
        protected string Endpoint;
        protected List<string> RequiredFields;
        
        public ServiceResource(AbstractService abstractService, string endpoint, List<string> requiredFields)
        {
            _abstractService = abstractService;
            Endpoint = endpoint;
            RequiredFields = requiredFields;
        }

        public string Request(string json)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
           
            return clientInterface.Request(Endpoint, json, config);
        }

        public string Request(string json,bool isApiKeyRequired)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
           
            return clientInterface.Request(Endpoint, json, config, isApiKeyRequired);
        }
    }
}