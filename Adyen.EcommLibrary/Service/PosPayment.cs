using Adyen.EcommLibrary.CloudApiSerialization;
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service.Resource.Payment;

namespace Adyen.EcommLibrary.Service
{
    public class PosPayment : ApiKeyAuthenticatedService
    {
        private readonly TerminalCloudApi _terminalCloudApiAsync;
        private readonly TerminalCloudApi _terminalCloudApiSync;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        public PosPayment(Client client)
            : base(client)
        {
<<<<<<< HEAD
            client.Config.RequiresXApiKey = RequiresApiKey;
=======
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
            _terminalCloudApiAsync = new TerminalCloudApi(this, false);
            _terminalCloudApiSync = new TerminalCloudApi(this, true);
        }

<<<<<<< HEAD
        /// <summary>
        /// CloudApi asyncronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
=======
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
        public SaleToPOIResponse RunTenderAsync(SaleToPOIRequest saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var response = _terminalCloudApiAsync.Request(serializedMessage);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(response);
            return saleToPoiResponse;
        }

<<<<<<< HEAD
        /// <summary>
        /// CloudApi syncronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
=======
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
        public SaleToPOIResponse RunTenderSync(SaleToPOIRequest saleToPoiRequest)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var response = _terminalCloudApiSync.Request(serializedMessage);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(response);
            return saleToPoiResponse;
        }
<<<<<<< HEAD

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="messageHeader"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
=======
        
        //Local https call
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
        public SaleToPOIResponse RunLocalTenderASync(SaleToPOIRequest saleToPoiRequest, MessageHeader  messageHeader, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, messageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);

            var response = _terminalCloudApiSync.Request(serializeSaleToPoiRequestMessageSecured);
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            var saleToPoiResponse = _saleToPoiMessageSerializer.Deserialize(decryptResponse);
            return saleToPoiResponse;
        }
    }
}
