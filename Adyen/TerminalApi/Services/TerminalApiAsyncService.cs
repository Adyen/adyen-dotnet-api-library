using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service.Resource.Terminal;
using System.Threading;
using System.Threading.Tasks;

namespace Adyen.Service
{
    /// <summary>
    /// Service that sends requests to the Adyen Cloud Terminal API `https://terminal-api-test.adyen.com/async` endpoint.
    /// </summary>
    public interface ITerminalApiAsyncService
    {
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="string"/>.</returns>
        Task<string> RequestEncryptedAsync(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <returns>Response <see cref="string"/>.</returns>
        string RequestEncrypted(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="string"/>.</returns>
        Task<string> RequestAsync(SaleToPOIRequest saleToPoiRequest, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <returns>Response <see cref="string"/>.</returns>
        string Request(SaleToPOIRequest saleToPoiRequest);

        /// <summary>
        /// Used to decrypt the notification received.
        /// </summary>
        /// <param name="notification">Notification.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>.</param>
        /// <returns>Decrypted notification <see cref="string"/>.</returns>
        string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails);
    }

    /// <summary>
    /// Service that sends requests to the Adyen Cloud Terminal API `https://terminal-api-test.adyen.com/async` endpoint.
    /// </summary>
    public class TerminalApiAsyncService : AbstractService, ITerminalApiAsyncService
    {
        private readonly TerminalApiAsyncClient _asyncClient;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;
        
        /// <summary>
        /// Service that sends requests to the Adyen Cloud Terminal API `https://terminal-api-test.adyen.com/async` endpoint.
        /// </summary>
        public TerminalApiAsyncService(Client client, SaleToPoiMessageSerializer saleToPoiMessageSerializer, SaleToPoiMessageSecuredEncryptor saleToPoiMessageSecuredEncryptor, SaleToPoiMessageSecuredSerializer saleToPoiMessageSecuredSerializer) : base(client)
        {
            _saleToPoiMessageSerializer = saleToPoiMessageSerializer;
            _saleToPoiMessageSecuredEncryptor = saleToPoiMessageSecuredEncryptor;
            _saleToPoiMessageSecuredSerializer = saleToPoiMessageSecuredSerializer;
            _asyncClient = new TerminalApiAsyncClient(this);
        }
        
        /// <inheritdoc/>
        public async Task<string> RequestEncryptedAsync(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = await _asyncClient.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            return response;
        }
        
        /// <inheritdoc/>
        public  string RequestEncrypted(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = _asyncClient.Request(serializedSecuredMessage);
            Client.LogLine("Response: \n" + response);
            return response;
        }

        /// <inheritdoc/> 
        public async Task<string> RequestAsync(SaleToPOIRequest saleToPoiRequest, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = await _asyncClient.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            return response;
        }
        
        /// <inheritdoc/> 
        public string Request(SaleToPOIRequest saleToPoiRequest)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = _asyncClient.Request(serializedMessage);
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