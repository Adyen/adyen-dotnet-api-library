using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Security;
using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.Service
{
    public class ServiceResource
    {
        private readonly AbstractService _abstractService;
        protected string Endpoint;
       
        public ServiceResource(AbstractService abstractService, string endpoint)
        {
            _abstractService = abstractService;
            Endpoint = endpoint;
        }

        public string Request(string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            return clientInterface.Request(Endpoint, json, requestOptions, httpMethod);
        }

        public Task<string> RequestAsync(string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            return clientInterface.RequestAsync(Endpoint, json, requestOptions, httpMethod);
        }
    }
}