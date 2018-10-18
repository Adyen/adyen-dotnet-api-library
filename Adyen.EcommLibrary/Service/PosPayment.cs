using System;
using Adyen.EcommLibrary.CloudApiSerialization;
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Model.Nexo.Message;
using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service.Resource.Payment;

namespace Adyen.EcommLibrary.Service
{
    public class PosPayment : ApiKeyAuthenticatedService
    {
        private readonly TerminalApi _terminalApiAsync;
        private readonly TerminalApi _terminalApiSync;
        private readonly TerminalApiLocal _terminalApiLocal;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        public PosPayment(Client client)
            : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
            _terminalApiAsync = new TerminalApi(this, true);
            _terminalApiSync = new TerminalApi(this, false);
            _terminalApiLocal=new TerminalApiLocal(this);
        }

        /// <summary>
        /// CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        public string TerminalApiCloudAsync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            return _terminalApiAsync.Request(serializedMessage);
        }

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        public SaleToPOIResponse TerminalApiCloudSync(SaleToPOIMessage saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var response = _terminalApiSync.Request(serializedMessage);
            return _saleToPoiMessageSerializer.Deserialize(response);
        }

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="messageHeader"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        public SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);

            var response = _terminalApiLocal.Request(serializeSaleToPoiRequestMessageSecured);
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);

            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(decryptResponse);
            return saleToPoiResponse;
        }
    }
}
