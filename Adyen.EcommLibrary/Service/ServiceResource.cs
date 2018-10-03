using System;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service
{
    public class ServiceResource
    {
        private readonly AbstractService _abstractService;
        protected string Endpoint;
       
        
        public ServiceResource(AbstractService abstractService, string endpoint, List<string> requiredFields)
        {
            _abstractService = abstractService;
            Endpoint = endpoint;
          
        }

        public string Request(string json)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
          
            return clientInterface.Request(Endpoint, json, config);
        }

    }
}