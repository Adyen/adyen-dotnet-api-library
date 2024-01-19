using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    public class TerminalLocalApiUnencrypted : AbstractService
    {
        private readonly TerminalApiLocal _terminalApiLocal;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private ITerminalLocalApi _terminalLocalApiImplementation;

        /// <summary>
        /// [UNENCRYPTED] Local Terminal Api.
        /// Use this class (in TEST only) to experiment with the Local Terminal API separately from the encryption implementation required for live payments. Be sure to remove the encryption key details on the Customer Area as it will not work with encryption key details set up. 
        /// </summary>
        /// <param name="client">Client</param>
        /// <returns></returns>
        public TerminalLocalApiUnencrypted(Client client)
            : base(client)
        {
            // Set default server certificate validation to true so no certificate check is performed
            var handler = new HttpClientHandler { ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true };
            Client = new Client(Client.Config, new System.Net.Http.HttpClient(handler));
            _terminalApiLocal = new TerminalApiLocal(this);
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
        }
        
        /// <summary>
        /// [UNENCRYPTED] Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest">SaleToPOIMessage</param>
        /// <returns>SaleToPOIResponse</returns>
        public SaleToPOIResponse TerminalRequest(SaleToPOIRequest saleToPoiRequest)
        {
            var saleToPoiRequestJson = saleToPoiRequest.ToJson();
            Client.LogLine("Request: \n" + saleToPoiRequestJson);
            var response = _terminalApiLocal.Request(saleToPoiRequestJson);
            Client.LogLine("Request: \n" + response);
            return string.IsNullOrEmpty(response) ? null : SaleToPOIResponse.FromJson(response);
        }
        
        /// <summary>
        /// [UNENCRYPTED] Terminal Api https call asynchronous Unencrypted
        /// </summary>
        /// <param name="saleToPoiRequest">SaleToPOIMessage</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Task of SaleToPOIResponse</returns>
        public async Task<SaleToPOIResponse> TerminalRequestAsync(SaleToPOIRequest saleToPoiRequest, CancellationToken cancellationToken = default)
        {
            var saleToPoiRequestJson = saleToPoiRequest.ToJson();
            Client.LogLine("Request: \n" + saleToPoiRequestJson);
            var response = await _terminalApiLocal.RequestAsync(saleToPoiRequestJson, cancellationToken: cancellationToken).ConfigureAwait(false);
            Client.LogLine("Response: \n" + response);
            return string.IsNullOrEmpty(response) ? null : SaleToPOIResponse.FromJson(response);
        }
    }
}