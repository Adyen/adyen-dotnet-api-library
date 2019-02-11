using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public string Request(string json, string idempotencyKey = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
            return clientInterface.Request(Endpoint, json, config, _abstractService.IsApiKeyRequired, idempotencyKey);
        }

        public Task<string> RequestAsync(string json, string idempotencyKey = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
            return clientInterface.RequestAsync(Endpoint, json, config,false, idempotencyKey);
        }
    }
}