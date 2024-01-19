using System;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Model.Terminal;
using Adyen.Security;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    public interface ITerminalLocalApi
    {
        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        TerminalApiResponse TerminalRequest(TerminalApiRequest terminalApiRequest, EncryptionCredentialDetails encryptionCredentialDetails);
    
        /// <summary>
        /// Terminal Api async https call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        Task<TerminalApiResponse> TerminalRequestAsync(TerminalApiRequest terminalApiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="terminalApiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <param name="remoteCertificateValidationCallback"></param>
        /// <returns></returns>
        TerminalApiResponse TerminalRequest(TerminalApiRequest terminalApiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback);

        /// <summary>
        /// Used to decrypt the notification received
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails);
    }
    
    public class TerminalLocalApi: AbstractService, ITerminalLocalApi
    {
        private readonly TerminalApiLocal _terminalApiLocal;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        public TerminalLocalApi(Client client)
            : base(client)
        {
            _terminalApiLocal = new TerminalApiLocal(this);
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
        }

        public TerminalApiResponse TerminalRequest(TerminalApiRequest terminalApiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiRequestMessageSerialized = terminalApiRequest.ToJson();
            Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, terminalApiRequest.SaleToPOIRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = saleToPoiRequestMessageSecured.ToJson();
            var response = _terminalApiLocal.Request(serializeSaleToPoiRequestMessageSecured);
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            Client.LogLine("Response: \n" + decryptResponse);
            return TerminalApiResponse.FromJson(decryptResponse);
        }

        public async Task<TerminalApiResponse> TerminalRequestAsync(TerminalApiRequest terminalApiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default)
        {
            var saleToPoiRequestMessageSerialized = terminalApiRequest.ToJson();
            Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, terminalApiRequest.SaleToPOIRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = saleToPoiRequestMessageSecured.ToJson();
            var response = await _terminalApiLocal.RequestAsync(serializeSaleToPoiRequestMessageSecured, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            Client.LogLine("Response: \n" + decryptResponse);
            return TerminalApiResponse.FromJson(decryptResponse);
        }

        [Obsolete("Use the overload of the method without passing RemoteCertificateValidationCallback. The terminal certificate validation is handled at the http request the adyen library")]
        public TerminalApiResponse TerminalRequest(TerminalApiRequest terminalApiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback)
        {
            return TerminalRequest(terminalApiRequest: terminalApiRequest, encryptionCredentialDetails: encryptionCredentialDetails);
        }

        public string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiMessageSecured = _saleToPoiMessageSecuredSerializer.Deserialize(notification);
            var decryptNotification = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, encryptionCredentialDetails);
            return decryptNotification;
        }
    }
}