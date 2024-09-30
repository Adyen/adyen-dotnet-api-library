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
    /// <summary>
    /// Service that sends requests to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`).
    /// </summary>
    public interface ITerminalApiLocalService
    {
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`).
        /// To protect local communications, you need to add and validate Adyen's certificate (see docs) and encrypt your messages.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="SaleToPOIResponse"/>.</returns>
        Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`).
        /// To protect local communications, you need to add and validate Adyen's certificate (see docs) and encrypt your messages.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse RequestEncrypted(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails);

        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`) .
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="SaleToPOIResponse"/>.</returns>
        Task<SaleToPOIResponse> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`) .
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse Request(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        /// Decrypts a <see cref="SaleToPoiMessageSecured"/> and returns the <see cref="SaleToPOIResponse"/>.
        /// </summary>
        /// <param name="secureMessage"><see cref="SaleToPoiMessageSecured"/> from <see cref="SaleToPoiMessageSecuredSerializer"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse DecryptSecuredMessage(SaleToPoiMessageSecured secureMessage, EncryptionCredentialDetails encryptionCredentialDetails);
    }
    
    /// <summary>
    /// Service that sends requests to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`).
    /// </summary>
    public class TerminalApiLocalService: AbstractService, ITerminalApiLocalService
    {
        private readonly TerminalApiLocalClient _localClient;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;
        
        /// <summary>
        /// Service that sends requests to the endpoint specified in <see cref="Config.LocalTerminalApiEndpoint"/> (e.g. `https://198.51.100.1:8443/nexo`).
        /// </summary>
        public TerminalApiLocalService(Client client, SaleToPoiMessageSerializer saleToPoiMessageSerializer, SaleToPoiMessageSecuredEncryptor saleToPoiMessageSecuredEncryptor, SaleToPoiMessageSecuredSerializer saleToPoiMessageSecuredSerializer) : base(client)
        {
            _saleToPoiMessageSerializer = saleToPoiMessageSerializer;
            _saleToPoiMessageSecuredEncryptor = saleToPoiMessageSecuredEncryptor;
            _saleToPoiMessageSecuredSerializer = saleToPoiMessageSecuredSerializer;
            _localClient = new TerminalApiLocalClient(this);
        }
        
        /// <inheritdoc/>
        public async Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = await _localClient.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            SaleToPoiMessageSecured saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            string decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            Client.LogLine("Response: \n" + decryptedResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }
           
        /// <inheritdoc/>
        public SaleToPOIResponse RequestEncrypted(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = _localClient.Request(serializedSecuredMessage);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            SaleToPoiMessageSecured saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            string decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            Client.LogLine("Response: \n" + decryptedResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }
        
        /// <inheritdoc/>
        public async Task<SaleToPOIResponse> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = await _localClient.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        /// <inheritdoc/>
        public SaleToPOIResponse Request(SaleToPOIMessage saleToPoiRequest)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = _localClient.Request(serializedMessage);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        /// <inheritdoc/>
        public SaleToPOIResponse DecryptSecuredMessage(SaleToPoiMessageSecured saleToPoiMessageSecured, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            string decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, encryptionCredentialDetails);            
            if (string.IsNullOrEmpty(decryptedResponse))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }
    }
}