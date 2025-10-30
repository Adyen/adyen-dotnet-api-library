using System;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    [Obsolete("Use ITerminalApiSyncService or ITerminalApiAsyncService instead.")]
    public interface ITerminalCloudApi
    {
        /// <summary>
        /// CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiAsyncService.Request(..) instead.")]
        SaleToPOIResponse TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest);
        
        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiSyncService.Request(..) instead.")]
        SaleToPOIResponse TerminalRequestSync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        ///  Task async CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiAsyncService.RequestAsync(..) instead.")]
        Task<SaleToPOIResponse> TerminalRequestAsynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);

        /// <summary>
        ///  Task async CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiSyncService.RequestAsync(..) instead.")]
        Task<SaleToPOIResponse> TerminalRequestSynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
    }
    
    [Obsolete("Use TerminalApiSyncService or TerminalApiAsyncService instead.")]
    public class TerminalCloudApi : AbstractService, ITerminalCloudApi 
    {
        private readonly TerminalApi _terminalApiAsync;
        private readonly TerminalApi _terminalApiSync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly string _baseUrl;

        [Obsolete("Use TerminalApiSyncService or TerminalApiAsyncService instead.")]
        public TerminalCloudApi(Client client)
            : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _terminalApiAsync = new TerminalApi(this, true);
            _terminalApiSync = new TerminalApi(this, false);
            _baseUrl = client.GetCloudApiEndpoint();

        }
        
        [Obsolete("Use TerminalApiAsyncService.Request(..) instead.")]
        public SaleToPOIResponse TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = _terminalApiAsync.Request(serializedMessage);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        [Obsolete("Use TerminalApiSyncService.Request(..) instead.")]
        public SaleToPOIResponse TerminalRequestSync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            var response = _terminalApiSync.Request(serializedMessage);
            Client.LogLine("Response: \n"+ response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        [Obsolete("Use TerminalApiAsyncService.RequestAsync(..) instead.")]
        public async Task<SaleToPOIResponse> TerminalRequestAsynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiAsync.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        [Obsolete("Use TerminalApiSyncService.RequestAsync(..) instead.")]
        public async Task<SaleToPOIResponse> TerminalRequestSynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiSync.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
    }
}