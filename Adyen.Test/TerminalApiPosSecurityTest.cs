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

using Adyen.ApiSerialization;
using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;
using Adyen.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiPosSecurityTest : BaseTest
    {
        private SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyIdentifier = "CryptoKeyIdentifier12345",
                Password = "p@ssw0rd123456"
            };
        }

        [TestMethod]
        public void TestTerminalAPiPosEncryption()
        {
            //dummy header
            MessageHeader messageHeader = MockNexoMessageHeaderRequest();
            //dummy json message
            string saleToPoiRequest = MockPosApiRequest.MockNexoJsonRequest();
            SaleToPoiMessageSecured saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequest, messageHeader, _encryptionCredentialDetails);

            Assert.IsNotNull(saleToPoiMessageSecured);
        }
        
        [TestMethod]
        public void TestTerminalApiPosDecryption()
        {
            //dummy header
            MessageHeader messageHeader = MockNexoMessageHeaderRequest();
            //dummy json message
            string saleToPoiRequest = MockPosApiRequest.MockNexoJsonRequest();
            SaleToPoiMessageSecured saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequest, messageHeader, _encryptionCredentialDetails);
            string saleToPoiRequestDecrypt = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, _encryptionCredentialDetails);

            Assert.IsNotNull(saleToPoiRequestDecrypt);
            Assert.AreEqual(saleToPoiRequest, saleToPoiRequestDecrypt);
        }

        [TestMethod]
        public void TestSaleToPoiMessageEscapeStringDecryption()
        { 
            SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreateSaleToPOIPrintRequestEscape();
            MessageHeader messageHeader = MockPosApiRequest.CreateSaleToPOIPrintRequestEscape().MessageHeader;
            SaleToPoiMessageSerializer saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            string saleToPoiRequestMessageSerialized = saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            SaleToPoiMessageSecured saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequestMessageSerialized, messageHeader, _encryptionCredentialDetails);
            string saleToPoiRequestDecrypt = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, _encryptionCredentialDetails);
            Assert.IsNotNull(saleToPoiRequestDecrypt);
            Assert.AreEqual(MockPosApiRequest.MockNexoJsonPrintRequest(), saleToPoiRequestDecrypt);
        } 
    }
}
