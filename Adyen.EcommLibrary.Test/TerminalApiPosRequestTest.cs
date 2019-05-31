using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class TerminalApiPosRequestTest : BaseTest
    {
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
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
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                //create a mock client
                var client = CreateMockTestClientPosApiRequest("Mocks/terminalapi/pospayment-encrypted-success.json");
                var payment = new PosPaymentLocalApi(client);
                var configEndpoint = payment.Client.Config.Endpoint;
                var saleToPoiResponse = payment.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails);

                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}