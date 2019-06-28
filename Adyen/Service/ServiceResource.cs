using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.Service
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

        public string Request(string json, RequestOptions requestOptions = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
            return clientInterface.Request(Endpoint, json, config, _abstractService.IsApiKeyRequired, requestOptions);
        }

        public string Request(string json, RemoteCertificateValidationCallback remoteCertificateValidationCallback, RequestOptions requestOptions = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
            return clientInterface.Request(Endpoint, json, config, _abstractService.IsApiKeyRequired, requestOptions, remoteCertificateValidationCallback);
        }

        public Task<string> RequestAsync(string json, RequestOptions requestOptions = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var config = _abstractService.Client.Config;
            return clientInterface.RequestAsync(Endpoint, json, config,false, requestOptions);
        }
    }
}