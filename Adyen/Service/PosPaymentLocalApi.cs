﻿using System;
using System.ComponentModel;
using System.IO;
using System.Net.Security;
using Adyen.CloudApiSerialization;
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
        /// <param name="remoteCertificateValidationCallback"></param>
        /// <returns></returns>
        public SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback)
        {
            if (remoteCertificateValidationCallback == null)
            {
                throw new InvalidDataException("RemoteCertificateValidationCallback is a required property for TerminalApiLocal and cannot be null");
            }
            var saleToPoiRequestMessageSerialized = _saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            this.Client.LogLine("Request: \n" + saleToPoiRequestMessageSerialized);
            var saleToPoiRequestMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializeSaleToPoiRequestMessageSecured = _saleToPoiMessageSerializer.Serialize(saleToPoiRequestMessageSecured);
            this.Client.LogLine("Encrypted Request: \n" + serializeSaleToPoiRequestMessageSecured);
            var response = _terminalApiLocal.Request(serializeSaleToPoiRequestMessageSecured, remoteCertificateValidationCallback);
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
    }
}
