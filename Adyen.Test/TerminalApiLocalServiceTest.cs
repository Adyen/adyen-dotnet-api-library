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
                ITerminalApiLocalService localService = new TerminalApiLocalService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
                SaleToPOIResponse response = await localService.RequestEncryptedAsync(saleToPoiRequest, encryptionCredentialDetails, new CancellationToken());
                Assert.IsNotNull(response);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void RequestEncrypted_Success()
        {
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
                ITerminalApiLocalService localService = new TerminalApiLocalService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
                SaleToPOIResponse response = localService.RequestEncrypted(saleToPoiRequest, encryptionCredentialDetails);
                Assert.IsNotNull(response);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public async Task RequestAsync_Success()
        {
            try
            {
                SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
                Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
                ITerminalApiLocalService localService = new TerminalApiLocalService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
                SaleToPOIResponse response = await localService.RequestAsync(saleToPoiRequest, new CancellationToken());
                Assert.IsNotNull(response);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Request_Success()
        {
            try
            {
                SaleToPOIRequest saleToPoiRequest = MockPosApiRequest.CreatePosPaymentRequest();
                Client client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
                ITerminalApiLocalService localService = new TerminalApiLocalService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
                SaleToPOIResponse response = localService.Request(saleToPoiRequest);
                Assert.IsNotNull(response);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}