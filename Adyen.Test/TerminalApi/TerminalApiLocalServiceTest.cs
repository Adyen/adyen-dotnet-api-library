using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiLocalServiceTest : BaseTest
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
            AdyenClient adyenClient = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
            ITerminalApiLocalService localService = new TerminalApiLocalService(adyenClient, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = await localService.RequestEncryptedAsync(saleToPoiRequest, encryptionCredentialDetails, new CancellationToken());
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
            AdyenClient adyenClient = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
            ITerminalApiLocalService localService = new TerminalApiLocalService(adyenClient, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = localService.RequestEncrypted(saleToPoiRequest, encryptionCredentialDetails);
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }

        [TestMethod]
        public async Task RequestAsync_Success()
        {
            SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
            AdyenClient adyenClient = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-success.json");
            ITerminalApiLocalService localService = new TerminalApiLocalService(adyenClient, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = await localService.RequestAsync(saleToPoiRequest, new CancellationToken());
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }

        [TestMethod]
        public void Request_Success()
        {
            SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
            AdyenClient adyenClient = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-success.json");
            ITerminalApiLocalService localService = new TerminalApiLocalService(adyenClient, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = localService.Request(saleToPoiRequest);
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Assert.AreEqual(paymentResponse?.Response.Result, ResultType.Success);
        }
    }
}