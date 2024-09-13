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
    public class TerminalApiSyncClientTest : BaseTest
    {
        [TestMethod]
        public async Task TestEncryptedPaymentSyncSuccess() {
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
                Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
                ITerminalApiSyncService syncService = new TerminalApiSyncService(client);
                SaleToPOIResponse response = await syncService.RequestEncryptedAsync(saleToPoiRequest, encryptionCredentialDetails);
                Assert.IsNotNull(response);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public async Task TestPaymentSyncSuccess() {
            try
            {
                SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
                Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
                ITerminalApiSyncService syncService = new TerminalApiSyncService(client);
                SaleToPOIResponse response = await syncService.RequestAsync(saleToPoiRequest);
                Assert.IsNotNull(response);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
 