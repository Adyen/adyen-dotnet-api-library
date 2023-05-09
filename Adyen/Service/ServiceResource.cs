using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;
using Newtonsoft.Json;

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
        
        public T Request<T>(string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var jsonResponse = clientInterface.Request(Endpoint, json, requestOptions, httpMethod);
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public async Task<string> RequestAsync(string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null, CancellationToken cancellationToken = default)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            return await clientInterface.RequestAsync(Endpoint, json, requestOptions, httpMethod, cancellationToken).ConfigureAwait(false);
        }
        
        public async Task<T> RequestAsync<T>(string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null, CancellationToken cancellationToken = default)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            var jsonResponse = await clientInterface.RequestAsync(Endpoint, json, requestOptions, httpMethod, cancellationToken).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }
    }
}