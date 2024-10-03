using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiSyncClientTest : BaseTest
    {
        [TestMethod]
        public async Task RequestEncryptedAsync_Success()
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
            ITerminalApiSyncService syncService = new TerminalApiSyncService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = await syncService.RequestEncryptedAsync(saleToPoiRequest, encryptionCredentialDetails, new CancellationToken());
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }


        [TestMethod]
        public void RequestEncrypted_Success()
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
            ITerminalApiSyncService syncService = new TerminalApiSyncService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = syncService.RequestEncrypted(saleToPoiRequest, encryptionCredentialDetails);
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }

        [TestMethod]
        public async Task RequestAsync_Success()
        {
            SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
            Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
            ITerminalApiSyncService syncService = new TerminalApiSyncService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = await syncService.RequestAsync(saleToPoiRequest, new CancellationToken());
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }

        [TestMethod]
        public void Request_Success()
        {
            SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
            Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
            ITerminalApiSyncService syncService = new TerminalApiSyncService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = syncService.Request(saleToPoiRequest);
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }
    }
}
 