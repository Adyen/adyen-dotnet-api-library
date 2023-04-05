using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.Service.Resource
{
    public class Resource
    {
        private readonly AbstractService _abstractService;
        protected string Endpoint;

        public Resource(AbstractService abstractService, string endpoint)
        {
            _abstractService = abstractService;
            Endpoint = endpoint;
        }
        
        public string Request(string json, RequestOptions requestOptions = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            return clientInterface.Request(Endpoint, json, requestOptions);
        }

        public async Task<string> RequestAsync(string json, RequestOptions requestOptions = null)
        {
            var clientInterface = _abstractService.Client.HttpClient;
            return await clientInterface.RequestAsync(Endpoint, json, requestOptions);
        }
    }
}