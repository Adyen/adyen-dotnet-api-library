#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.ComponentModel;
using System.IO;
using System.Net.Security;
using Adyen.ApiSerialization;
using Adyen.Model.Nexo;
using Adyen.Security;
using Adyen.Service.Resource.Payment;

namespace Adyen.Service
{
   public class PosPaymentLocalApi: AbstractService
    {
        private readonly TerminalApiLocal _terminalApiLocal;
        private readonly SaleToPoiMessageSerializer _saleToPoiMessageSerializer;
        private readonly SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private readonly SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;


        public PosPaymentLocalApi(Client client)
            : base(client)
        {
            _terminalApiLocal = new TerminalApiLocal(this);
            _saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _saleToPoiMessageSecuredSerializer = new SaleToPoiMessageSecuredSerializer();
        }

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        public SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            this.Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);
            this.Client.LogLine("Encrypted Request: \n" + serializeSaleToPoiRequestMessageSecured);
            var response = _terminalApiLocal.Request(serializeSaleToPoiRequestMessageSecured);
            this.Client.LogLine("Response: \n" + response);
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }
            var saleToPoiResponseSecured = _saleToPoiMessageSecuredSerializer.Deserialize(response);
            var decryptResponse = _messageSecuredEncryptor.Decrypt(saleToPoiResponseSecured, encryptionCredentialDetails);
            this.Client.LogLine("Response: \n" + decryptResponse);
            return _saleToPoiMessageSerializer.Deserialize(decryptResponse);
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
        public string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var saleToPoiMessageSecured = _saleToPoiMessageSecuredSerializer.Deserialize(notification);
            var decryptNotification = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, encryptionCredentialDetails);
            return decryptNotification;
        }
    }
}
