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
    /// Service that sends requests to the Adyen Cloud Terminal API `/async` endpoint.
    /// </summary>
    public interface ITerminalApiAsyncService
    {
        /// <summary>
        /// Sends an encrypted <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/>. These must match the credentials that you configured in the Customer Area. Make sure your terminal is updated to latest version.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="string"/>.</returns>
        Task<string> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Sends a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/> to the terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIMessage"/>.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task{TValue}"/> that represents the <see cref="string"/>.</returns>
        Task<string> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
    }

    public class TerminalApiAsyncService : AbstractService, ITerminalApiAsyncService
    {
        private readonly TerminalApiAsyncClient _terminalApiAsyncClient;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        
        public TerminalApiAsyncService(Client client) : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _saleToPoiMessageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _terminalApiAsyncClient = new TerminalApiAsyncClient(this);
        }
        
        /// <inheritdoc/>
        public async Task<string> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            SaleToPoiMessageSecured securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            string serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            string response = await _terminalApiAsyncClient.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            return response;
        }

        /// <inheritdoc/> 
        public async Task<string> RequestAsync(SaleToPOIMessage saleToPoiRequest,
            CancellationToken cancellationToken = default)
        {
            string serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            string response = await _terminalApiAsyncClient.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            return response;
        }
    }
}