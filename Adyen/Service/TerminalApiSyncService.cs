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
    /// Service that sends requests to the Adyen Cloud Terminal API `https://terminal-api-test.adyen.com/sync` endpoint.
    /// </summary>
    public interface ITerminalApiSyncService
    {
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> to the terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="SaleToPOIResponse"/>.</returns>
        Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> to the terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse RequestEncrypted(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails);

        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> to the terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="SaleToPOIResponse"/>.</returns>
        Task<SaleToPOIResponse> RequestAsync(SaleToPOIRequest saleToPoiRequest, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> to the terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/>.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse Request(SaleToPOIRequest saleToPoiRequest);

        /// <summary>
        /// Decrypts a <see cref="SaleToPoiMessageSecured"/> and returns the <see cref="SaleToPOIResponse"/>.
        /// </summary>
        /// <param name="secureMessage"><see cref="SaleToPoiMessageSecured"/> from <see cref="SaleToPoiMessageSecuredSerializer"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse DecryptSecuredMessage(SaleToPoiMessageSecured secureMessage, EncryptionCredentialDetails encryptionCredentialDetails);
    }
    
    /// <summary>
    /// Service that sends requests to the Adyen Cloud Terminal API `https://terminal-api-test.adyen.com/sync` endpoint.
    /// </summary>
    public class TerminalApiSyncService : AbstractService, ITerminalApiSyncService
    {
        private readonly TerminalApiSyncClient _syncClient;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;

        /// <summary>
        /// Service that sends requests to the Adyen Cloud Terminal API `https://terminal-api-test.adyen.com/sync` endpoint.
        /// </summary>
        public TerminalApiSyncService(AdyenClient adyenClient, SaleToPoiMessageSerializer saleToPoiMessageSerializer, SaleToPoiMessageSecuredEncryptor saleToPoiMessageSecuredEncryptor, SaleToPoiMessageSecuredSerializer saleToPoiMessageSecuredSerializer) : base(adyenClient)
        {
            _saleToPoiMessageSerializer = saleToPoiMessageSerializer;
            _saleToPoiMessageSecuredEncryptor = saleToPoiMessageSecuredEncryptor;
            _saleToPoiMessageSecuredSerializer = saleToPoiMessageSecuredSerializer;
            _syncClient = new TerminalApiSyncClient(this);
        }
        
        /// <inheritdoc/>
        public async Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            AdyenClient.LogLine("Request: \n" + serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = await _syncClient.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            SaleToPoiMessageSecured saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            string decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            AdyenClient.LogLine("Response: \n" + decryptedResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }
           
        /// <inheritdoc/>
        public SaleToPOIResponse RequestEncrypted(SaleToPOIRequest saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            AdyenClient.LogLine("Request: \n" + serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = _syncClient.Request(serializedSecuredMessage);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            SaleToPoiMessageSecured saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            string decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            AdyenClient.LogLine("Response: \n" + decryptedResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }
        
        /// <inheritdoc/>
        public async Task<SaleToPOIResponse> RequestAsync(SaleToPOIRequest saleToPoiRequest, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            AdyenClient.LogLine("Request: \n" + serializedMessage);
            string response = await _syncClient.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            AdyenClient.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            return _saleToPoiMessageSerializer.Deserialize(response);
        }
        
        /// <inheritdoc/>
        public SaleToPOIResponse Request(SaleToPOIRequest saleToPoiRequest)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            AdyenClient.LogLine("Request: \n" + serializedMessage);
            string response = _syncClient.Request(serializedMessage);
            AdyenClient.LogLine("Response: \n" + response);
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