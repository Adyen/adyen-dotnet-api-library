using System;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Security;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    [Obsolete("Use ITerminalApiLocalService instead.")]
    public interface ITerminalLocalApi
    {
        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiLocalService instead.")]
        SaleToPOIResponse TerminalRequest(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails);
    
        /// <summary>
        /// Terminal Api async https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiLocalService instead.")]
        Task<SaleToPOIResponse> TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <param name="remoteCertificateValidationCallback"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiLocalService instead.")]
        SaleToPOIResponse TerminalRequest(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback);

        /// <summary>
        /// Used to decrypt the notification received
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        [Obsolete("Use ITerminalApiLocalService instead.")]
        string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails);
    }
    
    [Obsolete("Use TerminalApiLocalService instead.")]
    public class TerminalLocalApi: AbstractService, ITerminalLocalApi
    {
        private readonly TerminalApiLocal _terminalApiLocal;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        [Obsolete("Use TerminalApiLocalService instead.")]
        public TerminalLocalApi(Client client)
            : base(client)
        {
            _terminalApiLocal = new TerminalApiLocal(this);
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
        }

        [Obsolete("Use TerminalApiLocalService instead.")]
        public SaleToPOIResponse TerminalRequest(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);
            var response = _terminalApiLocal.Request(serializeSaleToPoiRequestMessageSecured);
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            Client.LogLine("Response: \n" + decryptResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptResponse);
        }

        [Obsolete("Use TerminalApiLocalService instead.")]
        public async Task<SaleToPOIResponse> TerminalRequestAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default)
        {
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);
            var response = await _terminalApiLocal.RequestAsync(serializeSaleToPoiRequestMessageSecured, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            Client.LogLine("Response: \n" + decryptResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptResponse);
        }

        [Obsolete("Use the overload of the method without passing RemoteCertificateValidationCallback. The terminal certificate validation is handled at the http request the adyen library")]
        public SaleToPOIResponse TerminalRequest(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback)
        {
            return TerminalRequest(saleToPoiRequest: saleToPoiRequest, encryptionCredentialDetails: encryptionCredentialDetails);
        }

        [Obsolete("Use TerminalApiLocalService instead.")]
        public string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiMessageSecured = _saleToPoiMessageSecuredSerializer.Deserialize(notification);
            var decryptNotification = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, encryptionCredentialDetails);
            return decryptNotification;
        }
    }
}
