using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.Nexo;
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
        SaleToPOIResponse TerminalApiCloudAsync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalApiCloudSync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        ///  Task async CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        Task<SaleToPOIResponse> TerminalApiCloudAsynchronousAsync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        ///  Task async CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        Task<SaleToPOIResponse> TerminalApiCloudSynchronousAsync(SaleToPOIMessage saleToPoiRequest);
    }
    public class TerminalCloudApi : AbstractService, ITerminalCloudApi 
    {
        private readonly TerminalApi _terminalApiAsync;
        private readonly TerminalApi _terminalApiSync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
       
        public TerminalCloudApi(Client client)
            : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _terminalApiAsync = new TerminalApi(this, true);
            _terminalApiSync = new TerminalApi(this, false);
        }

        public SaleToPOIResponse TerminalApiCloudAsync(SaleToPOIMessage saleToPoiRequest)
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
        
        public SaleToPOIResponse TerminalApiCloudSync(SaleToPOIMessage saleToPoiRequest)
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
        
        public async Task<SaleToPOIResponse> TerminalApiCloudAsynchronousAsync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiAsync.RequestAsync(serializedMessage);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        public async Task<SaleToPOIResponse> TerminalApiCloudSynchronousAsync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiSync.RequestAsync(serializedMessage);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
    }
}