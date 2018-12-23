using Adyen.EcommLibrary.CloudApiSerialization;
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service.Resource.Payment;

namespace Adyen.EcommLibrary.Service
{
   public class PosPaymentLocalApi: AbstractService
    {
        private readonly TerminalApiLocal _terminalApiLocal;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        public PosPaymentLocalApi(Client client)
            : base(client)
        {
            _terminalApiLocal = new TerminalApiLocal(this);
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
        }

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="messageHeader"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        public SaleToPoiResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            this.Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);
            this.Client.LogLine("Encrypted Request: \n" + serializeSaleToPoiRequestMessageSecured);
            var response = _terminalApiLocal.Request(serializeSaleToPoiRequestMessageSecured);
            this.Client.LogLine("Response: \n" + response);
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
          
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            this.Client.LogLine("Response: \n" + decryptResponse);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(decryptResponse);
            return saleToPoiResponse;
        }    
    }
}
