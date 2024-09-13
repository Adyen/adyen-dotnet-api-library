using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiAsyncServiceTest : BaseTest
    {
        [TestMethod]
        public async Task TestEncryptedPaymentAsyncSuccess() {
            try
            {
                SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
                EncryptionCredentialDetails encryptionCredentialDetails = new EncryptionCredentialDetails
                {
                    KeyVersion = 1,
                    AdyenCryptoVersion = 1,
                    KeyIdentifier = "CryptoKeyIdentifier12345",
                    Password = "p@ssw0rd123456"
                };
                Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-async-success.json");
                ITerminalApiAsyncService terminalApiSyncService = new TerminalApiAsyncService(client);
                string response = await terminalApiSyncService.RequestEncryptedAsync(saleToPoiRequest, encryptionCredentialDetails);
                Assert.AreEqual(response, "ok");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public async Task TestPaymentAsyncSuccess() {
            try
            {
                SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
                Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-async-success.json");
                ITerminalApiAsyncService terminalApiSyncService = new TerminalApiAsyncService(client);
                string response = await terminalApiSyncService.RequestAsync(saleToPoiRequest);
                Assert.AreEqual(response, "ok");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}