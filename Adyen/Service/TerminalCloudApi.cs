using System;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;

namespace Adyen.Service
{
    [Obsolete("Use TerminalApiSyncService or TerminalApiAsyncService instead.")]
    public interface ITerminalCloudApi
    {
        /// <summary>
        /// Wrapper for <see cref="TerminalRequestAsynchronousAsync"/> `/async` endpoint.
        /// </summary>
        [Obsolete("Use TerminalApiAsyncService instead.")]
        SaleToPOIResponse TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest);
        
        /// <summary>
        /// Wrapper for <see cref="TerminalRequestSynchronousAsync"/> `/sync` endpoint.
        /// </summary>
        [Obsolete("Use TerminalApiSyncService instead.")]
        SaleToPOIResponse TerminalRequestSync(SaleToPOIMessage saleToPoiRequest);
        
        /// <summary>
        /// Sends request to the `/async` endpoint.
        /// </summary>
        [Obsolete("Use TerminalApiAsyncService instead.")]
        Task<SaleToPOIResponse> TerminalRequestAsynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Sends request to the `/sync` endpoint.
        /// </summary>
        [Obsolete("Use TerminalApiSyncService instead.")]
        Task<SaleToPOIResponse> TerminalRequestSynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
    }
    
    [Obsolete("Use TerminalApiSyncService or TerminalApiAsyncService instead.")]
    public class TerminalCloudApi : AbstractService, ITerminalCloudApi
    {
        private readonly ITerminalApiSyncService _syncService;
        private readonly ITerminalApiAsyncService _asyncService;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
       
        [Obsolete("Use TerminalApiSyncService or TerminalApiAsyncService instead.")]
        public TerminalCloudApi(Client client) : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _syncService = new TerminalApiSyncService(client);
            _asyncService = new TerminalApiAsyncService(client); 
        }
        
        /// <inheritdoc/>
        [Obsolete("Use TerminalApiSyncService instead.")]
        public Task<SaleToPOIResponse> TerminalRequestSynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default)
        {
            return _syncService.RequestAsync(saleToPoiRequest, cancellationToken: cancellationToken);
        }
        
        /// <inheritdoc/>
        [Obsolete("Use TerminalApiAsyncService instead.")]
        public async Task<SaleToPOIResponse> TerminalRequestAsynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default)
        {
            string response = await _asyncService.RequestAsync(saleToPoiRequest, cancellationToken: cancellationToken);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        /// <inheritdoc/>
        [Obsolete("Use TerminalApiAsyncService instead.")]
        public SaleToPOIResponse TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest)
        {
             return TerminalRequestAsynchronousAsync(saleToPoiRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <inheritdoc/>
        [Obsolete("Use TerminalApiSyncService instead.")]
        public SaleToPOIResponse TerminalRequestSync(SaleToPOIMessage saleToPoiRequest)
        {
            return TerminalRequestSynchronousAsync(saleToPoiRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}