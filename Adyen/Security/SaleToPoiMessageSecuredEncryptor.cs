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

using Adyen.Model.Nexo.Message;
using System;
using System.Text;
using Adyen.Model.Nexo;

namespace Adyen.Security
{
    public class SaleToPoiMessageSecuredEncryptor
    {
        private readonly EncryptionDerivedKeyGenerator _encryptionDerivedKeyGenerator;
        private readonly AesEncryptor _aesEncryptor;
        private readonly HmacSha256Wrapper _hmacSha256Wrapper;
        private readonly IvModGenerator _ivModGenerator;


        public SaleToPoiMessageSecuredEncryptor()
        {
            _encryptionDerivedKeyGenerator = new EncryptionDerivedKeyGenerator();
            _aesEncryptor = new AesEncryptor();
            _hmacSha256Wrapper = new HmacSha256Wrapper();
            _ivModGenerator = new IvModGenerator();
           
        }

        public SaleToPoiMessageSecured Encrypt(string saleToPoiMessage, MessageHeader messageHeader,
                                                 EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var encryptionDerivedKey = _encryptionDerivedKeyGenerator.Generate(encryptionCredentialDetails);
            var saleToPoiMessageJson = saleToPoiMessage;
            var saleToPoiMessageByteArray = Encoding.ASCII.GetBytes(saleToPoiMessageJson);
            var ivMod = _ivModGenerator.GenerateRandomMod();
            var saleToPoiMessageAesEncrypted = _aesEncryptor.Encrypt(saleToPoiMessageByteArray,
                                                                     encryptionDerivedKey,
                                                                     ivMod);
            var saleToPoiMessageAesEncryptedHmac = _hmacSha256Wrapper.HMac(saleToPoiMessageByteArray,
                                                                           encryptionDerivedKey.HmacKey);


            var saleToPoiMessageSecured = new SaleToPoiRequestSecured
            {
                MessageHeader = messageHeader,
                NexoBlob = Convert.ToBase64String(saleToPoiMessageAesEncrypted),
                SecurityTrailer = new SecurityTrailer
                {
                    KeyVersion = encryptionCredentialDetails.KeyVersion,
                    KeyIdentifier = encryptionCredentialDetails.KeyIdentifier,
                    Hmac = saleToPoiMessageAesEncryptedHmac,
                    Nonce = ivMod,
                    AdyenCryptoVersion = encryptionCredentialDetails.AdyenCryptoVersion
                }
            };
            
            return saleToPoiMessageSecured;
        }

        public string Decrypt(SaleToPoiMessageSecured saleToPoiMessageSecured, EncryptionCredentialDetails encryptionCredentialDetails)
        {
            var encryptedSaleToPoiMessageByteArray = Convert.FromBase64String(saleToPoiMessageSecured.NexoBlob);
            var encryptionDerivedKey = _encryptionDerivedKeyGenerator.Generate(encryptionCredentialDetails);

            var decryptedSaleToPoiMessageByteArray = _aesEncryptor.Decrypt(encryptedSaleToPoiMessageByteArray,
                                                                           encryptionDerivedKey,
                                                                           saleToPoiMessageSecured.SecurityTrailer.Nonce);
            return System.Text.Encoding.UTF8.GetString(decryptedSaleToPoiMessageByteArray);
        }
    }
}
