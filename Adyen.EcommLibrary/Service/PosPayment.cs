using Adyen.EcommLibrary.CloudApiSerialization;
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Service.Resource.Payment;

namespace Adyen.EcommLibrary.Service
{
    public class PosPayment : ApiKeyAuthenticatedService
    {
        private readonly TerminalCloudApi _terminalCloudApiAsync;
        private readonly TerminalCloudApi _terminalCloudApiSync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;

        public PosPayment(Client client)
            : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _terminalCloudApiAsync = new TerminalCloudApi(this, false);
            _terminalCloudApiSync = new TerminalCloudApi(this, true);
        }

        public SaleToPOIResponse RunTenderAsync(SaleToPOIRequest saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var response = _terminalCloudApiAsync.Request(serializedMessage);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(response);
            return saleToPoiResponse;
        }

        public SaleToPOIResponse RunTenderSync(SaleToPOIRequest saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var response = _terminalCloudApiSync.Request(serializedMessage);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(response);
            return saleToPoiResponse;
        }
    }
}
