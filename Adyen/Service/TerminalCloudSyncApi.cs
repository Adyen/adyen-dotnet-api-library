using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Security;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    public interface ITerminalCloudSyncApi //fix summary
    {
        /// <summary>
        /// This service calls the Adyen terminal /sync endpoint with an encrypted message.
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIMessage"/></param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="SaleToPOIResponse"/></returns>
        Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default);


        /// <summary>
        /// This service calls the Adyen terminal /sync endpoint. 
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIMessage"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="SaleToPOIResponse"/></returns>
        Task<SaleToPOIResponse> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken = default);
    }

    public class TerminalCloudSyncApi : AbstractService, ITerminalCloudSyncApi
    {
        private readonly TerminalApi _terminalSyncApi;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        public TerminalCloudSyncApi(Client client) : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _saleToPoiMessageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
            _terminalSyncApi = new TerminalApi(this, false);
        }

        public async Task<SaleToPOIResponse> RequestEncryptedAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage,
                saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            var response = await _terminalSyncApi.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);//test success failure
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            var decryptedResponse = _saleToPoiMessageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);//test same as before encryption
            Client.LogLine("Response: \n" + decryptedResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptedResponse);
        }

        public async Task<SaleToPOIResponse> RequestAsync(SaleToPOIMessage saleToPoiRequest, CancellationToken cancellationToken)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n" + serializedMessage);
            var response = await _terminalSyncApi.RequestAsync(serializedMessage, cancellationToken: cancellationToken);
            Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response) || string.Equals("ok", response))
            {
                return null;
            }

            return _saleToPoiMessageSerializer.Deserialize(response);
        }
    }
}