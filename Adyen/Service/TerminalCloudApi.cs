using System;
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
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalRequestSync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        ///  Task async CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<SaleToPOIResponse> TerminalRequestAsynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);

        /// <summary>
        ///  Task async CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<SaleToPOIResponse> TerminalRequestSynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
    }
    public class TerminalCloudApi : AbstractService, ITerminalCloudApi // refactor
    {
        private readonly ITerminalCloudSyncApi _terminalCloudSyncApi;
        private readonly ITerminalCloudAsyncApi _terminalCloudAsyncApi;
        private readonly TerminalApi _terminalApiAsync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
       
        public TerminalCloudApi(Client client)
            : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _terminalApiAsync = new TerminalApi(this, true);
            _terminalCloudSyncApi = new TerminalCloudSyncApi(client);
            _terminalCloudAsyncApi = new TerminalCloudAsyncApi(client);//need to use this 
        }
        
        [Obsolete("Use TerminalCloudSyncApi instead")]
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
                
        [Obsolete("Use TerminalCloudSyncApi instead.")]
        public SaleToPOIResponse TerminalRequestSync(SaleToPOIMessage saleToPoiRequest)
        {
            return TerminalRequestSynchronousAsync(saleToPoiRequest).GetAwaiter().GetResult();
        }
        
        [Obsolete("Use TerminalCloudSyncApi instead.")]
        public Task<SaleToPOIResponse> TerminalRequestSynchronousAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default)
        {
            return _terminalCloudSyncApi.RequestAsync(saleToPoiRequest, cancellationToken: cancellationToken);
      
        }
    }
}