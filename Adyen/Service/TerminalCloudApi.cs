using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    public interface ITerminalCloudApi
    {
        /// <summary>
        /// CloudApi asynchronous call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <returns></returns>
        TerminalApiResponse TerminalRequestAsync(TerminalApiRequest terminalApiRequest);

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <returns></returns>
        TerminalApiResponse TerminalRequestSync(TerminalApiRequest terminalApiRequest);

        /// <summary>
        ///  Task async CloudApi asynchronous call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TerminalApiResponse> TerminalRequestAsynchronousAsync(TerminalApiRequest terminalApiRequest, CancellationToken cancellationToken = default);

        /// <summary>
        ///  Task async CloudApi synchronous call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TerminalApiResponse> TerminalRequestSynchronousAsync(TerminalApiRequest terminalApiRequest, CancellationToken cancellationToken = default);
    }
    public class TerminalCloudApi : AbstractService, ITerminalCloudApi 
    {
        private readonly TerminalApi _terminalApiAsync;
        private readonly TerminalApi _terminalApiSync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly string _baseUrl;

       
        public TerminalCloudApi(Client client)
            : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _terminalApiAsync = new TerminalApi(this, true);
            _terminalApiSync = new TerminalApi(this, false);
            _baseUrl = client.GetCloudApiEndpoint();

        }

        public TerminalApiResponse TerminalRequestAsync(TerminalApiRequest terminalApiRequest)
        {
            var serializedMessage = terminalApiRequest.ToJson();
            Client.LogLine("Request: \n" + serializedMessage);
            var response = _terminalApiAsync.Request(serializedMessage);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return TerminalApiResponse.FromJson(response);
        }
        
        public TerminalApiResponse TerminalRequestSync(TerminalApiRequest terminalApiRequest)
        {
            var serializedMessage = terminalApiRequest.ToJson();
            Client.LogLine("Request: \n"+ serializedMessage);
            var response = _terminalApiSync.Request(serializedMessage);
            Client.LogLine("Response: \n"+ response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return TerminalApiResponse.FromJson(response);
        }
        
        public async Task<TerminalApiResponse> TerminalRequestAsynchronousAsync(TerminalApiRequest terminalApiRequest, CancellationToken cancellationToken = default)
        {
            var serializedMessage = terminalApiRequest.ToJson();
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiAsync.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return TerminalApiResponse.FromJson(response);
        }
        
        public async Task<TerminalApiResponse> TerminalRequestSynchronousAsync(TerminalApiRequest terminalApiRequest, CancellationToken cancellationToken = default)
        {
            var serializedMessage = terminalApiRequest.ToJson();
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiSync.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return TerminalApiResponse.FromJson(response);
        }
    }
}