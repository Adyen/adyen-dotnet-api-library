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
    public interface ITerminalApiLocalService
    {
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="string"/>.</returns>
        Task<string> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <returns>Response <see cref="string"/>.</returns>
        string RequestEncrypted(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="string"/>.</returns>
        Task<string> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <returns>Response <see cref="string"/>.</returns>
        string Request(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        /// Used to decrypt the notification received.
        /// </summary>
        /// <param name="notification">Notification.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>.</param>
        /// <returns>Decrypted notification <see cref="string"/>.</returns>
        string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails);
    }
    
    public class TerminalApiLocalService: AbstractService, ITerminalApiLocalService
    {
        private readonly TerminalApiLocalClient _localClient;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;
        
        public TerminalApiLocalService(Client client) : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _saleToPoiMessageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
            _localClient = new TerminalApiLocalClient(this);
        }
        
        /// <inheritdoc/>
        public async Task<string> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = await _localClient.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            return response;
        }
        
        /// <inheritdoc/>
        public  string RequestEncrypted(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = _localClient.Request(serializedSecuredMessage);
            Client.LogLine("Response: \n" + response);
            return response;
        }

        /// <inheritdoc/> 
        public async Task<string> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = await _localClient.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            return response;
        }
        
        /// <inheritdoc/> 
        public string Request(SaleToPOIMessage saleToPoiRequest)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = _localClient.Request(serializedMessage);
            Client.LogLine("Response: \n" + response);
            return response;
        }
        
        /// <inheritdoc/> 
        public string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            SaleToPoiMessageSecured saleToPoiMessageSecured = _saleToPoiMessageSecuredSerializer.Deserialize(notification);
            string decryptNotification = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, encryptionCredentialDetails);
            return decryptNotification;
        }
    }
}