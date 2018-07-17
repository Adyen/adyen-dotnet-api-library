using Adyen.EcommLibrary.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CloudApiPosSecurityTest : BaseTest
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
        public void TestCloudAPiPosEncryption()
        {
            //dummy header
            var messageHeader = MockNexoMessageHeaderRequest();
            //dummy json message
            var saleToPoiRequest = MockCloudApiPosRequest.MockNexoJsonRequest();
            var saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequest, messageHeader, _encryptionCredentialDetails);

            Assert.IsNotNull(saleToPoiMessageSecured);
        }

        [TestMethod]
        public void TestCloudApiPosDecryptionTest()
        {
            //dummy header
            var messageHeader = MockNexoMessageHeaderRequest();
            //dummy json message
            var saleToPoiRequest = MockCloudApiPosRequest.MockNexoJsonRequest();
            var saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequest, messageHeader, _encryptionCredentialDetails);
            var saleToPoiRequestDecrypt = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, _encryptionCredentialDetails);

            Assert.IsNotNull(saleToPoiRequestDecrypt);
            Assert.AreEqual(saleToPoiRequest, saleToPoiRequestDecrypt);
        }
    }
}
