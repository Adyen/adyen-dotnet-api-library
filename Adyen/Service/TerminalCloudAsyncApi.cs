using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Security;
using Adyen.Service.Resource.Terminal;

namespace Adyen.Service
{
    public interface ITerminalCloudAsyncApi
    {
        /// <summary>
        /// This service calls the Adyen terminal /async endpoint. 
        /// </summary>
        /// <param name="saleToPoiRequest"><see cref="SaleToPOIMessage"/></param>
        /// <param name="encryptionCredentialDetails"><see cref="EncryptionCredentialDetails"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns>Response string.</returns>
        Task<string> RequestAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default);
      }
    
    public class TerminalCloudAsyncApi : AbstractService, ITerminalCloudAsyncApi
    {
        private readonly TerminalApi _terminalAsyncApi;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _saleToPoiMessageSecuredEncryptor;
        
        public TerminalCloudAsyncApi(Client client) : base(client)
        {
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _saleToPoiMessageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _terminalAsyncApi = new TerminalApi(this, true);
        }
        
        public async Task<string> RequestAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken)
        {
            var serializedMessage = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            Client.LogLine("Request: \n"+ serializedMessage);
            var securedMessage = _saleToPoiMessageSecuredEncryptor.Encrypt(serializedMessage, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializedSecuredMessage = _saleToPoiMessageSerializer.Serialize(securedMessage);
            var response = await _terminalAsyncApi.RequestAsync(serializedSecuredMessage, cancellationToken: cancellationToken);
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            return response;
        }
    }
}