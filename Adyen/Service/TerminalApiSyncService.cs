using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    /// <summary>
    /// Service that sends requests to the Adyen Cloud Terminal API `/sync` endpoint.
    /// </summary>
    public interface ITerminalApiSyncService
    {
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="SaleToPOIResponse"/>.</returns>
        Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="SaleToPOIResponse"/>.</returns>
        Task<SaleToPOIResponse> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Decrypts a <see cref="SaleToPoiMessageSecured"/> and returns the <see cref="SaleToPOIResponse"/>.
        /// </summary>
        /// <param name="secureMessage"><see cref="SaleToPoiMessageSecured"/> from <see cref="SaleToPoiMessageSecuredSerializer"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>.</param>
        /// <returns><see cref="SaleToPOIResponse"/>.</returns>
        SaleToPOIResponse DecryptSecuredMessage(SaleToPoiMessageSecured secureMessage, EncryptionCredentialDetails encryptionCredentialDetails);
    }
    
    public class TerminalApiSyncService : AbstractService, ITerminalApiSyncService
    {
        private readonly TerminalApiSyncClient _terminalApiSyncClient;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;

        public TerminalApiSyncService(Client client) : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _saleToPoiMessageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
            _terminalApiSyncClient = new TerminalApiSyncClient(this);
        }
        
        /// <inheritdoc/>
        public async Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = await _terminalApiSyncClient.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);//test success failure
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }
            SaleToPoiMessageSecured saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            string decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);//test same as before encryption
            Client.LogLine("Response: \n" + decryptedResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }

        /// <inheritdoc/>
        public async Task<SaleToPOIResponse> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalApiSyncClient.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
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
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }
    }
}