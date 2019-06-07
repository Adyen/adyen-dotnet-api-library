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
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/pospayment-encrypted-success.json");
                var posPaymentLocalApi = new PosPaymentLocalApi(client);
                var configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                var saleToPoiResponse = posPaymentLocalApi.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails,
                    (sender, certificate, chain, errors) => { return true;});
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTerminalApiRequestEmptyResponse()
        {
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("");
                var posPaymentLocalApi = new PosPaymentLocalApi(client);
                var configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                var saleToPoiResponse = posPaymentLocalApi.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails,
                    (sender, certificate, chain, errors) => { return true; });
                Assert.IsNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTerminalApiRequestRemoteCertificationException()
        {
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/pospayment-encrypted-success.json");
                var posPaymentLocalApi = new PosPaymentLocalApi(client);
                var configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                var saleToPoiResponse = posPaymentLocalApi.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails,
                    null);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "RemoteCertificateValidationCallback is a required property for TerminalApiLocal and cannot be null");
            }
        }
    }
}
