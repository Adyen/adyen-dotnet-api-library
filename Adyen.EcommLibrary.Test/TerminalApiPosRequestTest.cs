using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class TerminalApiPosRequestTest : BaseTest
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
        public void TestTerminalApiRequest()
        {
            var config = new Config();
            try
            {
                //dummy header
                var messageHeader = MockNexoMessageHeaderRequest();
               
                //encrypt the request using encryption credentials
                var paymentRequest = MockCloudApiPosRequest.CreatePosPaymentRequest("Request");
                //create a mock client
                var client = CreateMockTestClientCloudAPiRequest("Mocks/pospayment-encrypted-success.json", config);
                var payment = new PosPayment(client);
                var saleToPoiResponse = payment.RunLocalTenderASync(paymentRequest, messageHeader, _encryptionCredentialDetails);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
