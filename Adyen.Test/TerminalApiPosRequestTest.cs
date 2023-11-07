using System;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
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
                var client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
                var terminalLocalApi = new TerminalLocalApi(client);
                var configEndpoint = terminalLocalApi.Client.Config.LocalTerminalApiEndpoint;
                var saleToPoiResponse = terminalLocalApi.TerminalRequest(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public void TestTerminalApiAsyncRequest()
        {
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
                var terminalLocalApi = new TerminalLocalApi(client);
                var configEndpoint = terminalLocalApi.Client.Config.LocalTerminalApiEndpoint;
                var saleToPoiResponse = terminalLocalApi.TerminalRequestAsync(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTerminalApiCardAcquisitionResponse()
        {
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("");
                var terminalLocalApi = new TerminalLocalApi(client);
                var saleToPoiResponse = terminalLocalApi.TerminalRequest(paymentRequest, _encryptionCredentialDetails);
                Assert.IsNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public void TestTerminalApiRequestEmptySecurityTrailer()
        {
            try
            {
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequestEmptySecurityTrailer();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-no-security-trailer.json");
                var terminalLocalApi = new TerminalLocalApi(client);
                var configEndpoint = terminalLocalApi.Client.Config.LocalTerminalApiEndpoint;
                var saleToPoiResponse = terminalLocalApi.TerminalRequest(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}
