using Adyen.CloudApiSerialization;
using Adyen.Model.Nexo;
using Adyen.Security;
using Adyen.Service.Resource.Payment;

namespace Adyen.Service
{
    public class PosPaymentCloudApi : AbstractService
    {
        private readonly TerminalApi _terminalApiAsync;
        private readonly TerminalApi _terminalApiSync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
       
        public PosPaymentCloudApi(Client client)
            : base(client)
        {
            IsApiKeyRequired = true;
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _terminalApiAsync = new TerminalApi(this, true);
            _terminalApiSync = new TerminalApi(this, false);
        }

        /// <summary>
        /// CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        public string TerminalApiCloudAsync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var response = _terminalApiAsync.Request(serializedMessage);
            this.Client.LogLine("Response: \n" + response);
            return response;
        }

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        public SaleToPOIResponse TerminalApiCloudSync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            this.Client.LogLine("Request: \n"+ serializedMessage);
            var response = _terminalApiSync.Request(serializedMessage);
            this.Client.LogLine("Response: \n"+ response);
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
    }
}
