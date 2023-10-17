using System;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model.TerminalApi;
using Adyen.Security;

namespace Adyen.Service
{
    public class PosPaymentLocalApi: AbstractService, IPosPaymentLocalApi
   {
       private readonly TerminalLocalApi _terminalLocalApi;
       
       [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalLocalApi.cs")]
        public PosPaymentLocalApi(Client client)
            : base(client)
        {
            _terminalLocalApi = new TerminalLocalApi(client);
        }

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalLocalApi.cs")]
        public SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            return _terminalLocalApi.TerminalRequest(saleToPoiRequest, encryptionCredentialDetails);
        }
        
        /// <summary>
        /// Terminal Api https call asynchronous
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalLocalApi.cs")]
        public async Task<SaleToPOIResponse> TerminalApiLocalAsync(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, CancellationToken cancellationToken = default)
        {
            return await _terminalLocalApi.TerminalRequestAsync(saleToPoiRequest, encryptionCredentialDetails, cancellationToken);
        }

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <param name="remoteCertificateValidationCallback"></param>
        /// <returns></returns>
        [Obsolete("Use the overload of the method without passing RemoteCertificateValidationCallback. The terminal certificate validation is handled at the http request the adyen library")]
        public SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback)
        {
            return TerminalApiLocal(saleToPoiRequest: saleToPoiRequest, encryptionCredentialDetails: encryptionCredentialDetails);
        }
        
        /// <summary>
        /// Used to decrypt the notification received
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalLocalApi.cs")]
        public string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            return _terminalLocalApi.DecryptNotification(notification, encryptionCredentialDetails);
        }
    }
}
