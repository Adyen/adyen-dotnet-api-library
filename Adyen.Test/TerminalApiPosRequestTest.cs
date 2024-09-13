using System;
using System.Threading.Tasks;
using Adyen.Exceptions;
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
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
                TerminalApiLocalService terminalApiLocalService = new TerminalApiLocalService(client);
                string configEndpoint = terminalApiLocalService.Client.Config.LocalTerminalApiEndpoint;
                SaleToPOIResponse saleToPoiResponse = terminalApiLocalService.TerminalRequest(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public async Task TestTerminalApiAsyncRequest()
        {
            try
            {
                //encrypt the request using encryption credentials
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
                TerminalApiLocalService terminalApiLocalService = new TerminalApiLocalService(client);
                string configEndpoint = terminalApiLocalService.Client.Config.LocalTerminalApiEndpoint;
                SaleToPOIResponse saleToPoiResponse = await terminalApiLocalService.TerminalRequestAsync(paymentRequest, _encryptionCredentialDetails);
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
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("");
                TerminalApiLocalService terminalApiLocalService = new TerminalApiLocalService(client);
                SaleToPOIResponse saleToPoiResponse = terminalApiLocalService.TerminalRequest(paymentRequest, _encryptionCredentialDetails);
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
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequestEmptySecurityTrailer();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-no-security-trailer.json");
                TerminalApiLocalService terminalApiLocalService = new TerminalApiLocalService(client);
                string configEndpoint = terminalApiLocalService.Client.Config.LocalTerminalApiEndpoint;
                terminalApiLocalService.TerminalRequest(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message,"NexoBlob is empty in the response");
            }
        }
    }
}
