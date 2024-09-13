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
                ITerminalApiAsyncService asyncService = new TerminalApiAsyncService(client);
                string response = await asyncService.RequestEncryptedAsync(saleToPoiRequest, encryptionCredentialDetails);
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
                ITerminalApiAsyncService asyncService = new TerminalApiAsyncService(client);
                string response = await asyncService.RequestAsync(saleToPoiRequest);
                Assert.AreEqual(response, "ok");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        

        [TestMethod]
        public void TestDecryptNotification()
        {
            try
            {
                EncryptionCredentialDetails encryptionCredentialDetails = new EncryptionCredentialDetails
                {
                    AdyenCryptoVersion = 1,
                    KeyIdentifier = "ncrkey",
                    Password = "ncrpass"
                };
                string encryptedNotification = @"{""SaleToPOIRequest"":{""SecurityTrailer"":{""AdyenCryptoVersion"":1,""Nonce"":""Be6rAx+vRju2aCHwPh6lrg=="",""KeyIdentifier"":""ncrkey"",""Hmac"":""LG8A9Re1M8xLMr7rDUk0NwsnvAOX+VLjHv9sPHWTl34="",""KeyVersion"":1},""NexoBlob"":""x2DY8J2M9ZCyjOZ8Gt7JdLBA\/6bT\/KXvvAbJf9kzguqO8dWp1I1pPLQpLstpdIiAVqSwG3PR0PrP\/lF82UmhmCnUJGCuEXilqvBNF1tF\/yEgnFOklNc1myR2IPW\/+2oZOWKFXlTo\/gX89EbODXOOGUqaJfSdpDhlqjyMz7mGczobTPvPGqCVx2BDHU8VTxI9nicwQv+QV48GqVZzxnP8ZOdQOQ5cac+bcS0Y3l7SmWpIoQsoicnjahTY9ICosLJmN4DvDHsN4Kh2DAetFO5b9I9Lqgm\/dvnXUVhb9tPbM7Pn+ratjYpaNbonbO5M+Tm8rDEIyKoUUuFXPWISymrCXtCDVKEb2B5S5pilUmokrXVa9Ldtsv3BKG7rbrglYEuql4WVs6kzr6ybgAKh1Q0LsAXEve3pydt72ay4U3FOJSBxJ3gNqmnG8mVW2HCXQVo1RgVaZmP5TBWYuksCKXYypnMulu1PlRI++oeW\/J2qjQU="",""MessageHeader"":{""ProtocolVersion"":""3.0"",""SaleID"":""null"",""MessageClass"":""Event"",""MessageCategory"":""Event"",""POIID"":""P400Plus-275102806"",""MessageType"":""Notification"",""DeviceID"":""5""}}}";
                string expectedDecryption = @"{ ""SaleToPOIRequest"": { ""EventNotification"": { ""EventDetails"": ""reference_id=9876"", ""TimeStamp"": ""2020-11-13T09:02:35.697Z"", ""EventToNotify"": ""SaleWakeUp"" }, ""MessageHeader"": { ""ProtocolVersion"": ""3.0"", ""SaleID"": ""null"", ""MessageClass"": ""Event"", ""MessageCategory"": ""Event"", ""POIID"": ""P400Plus-275102806"", ""MessageType"": ""Notification"", ""DeviceID"": ""5"" } } }";

                Client client = CreateMockTestClientPosLocalApiRequest("mocks/terminalapi/pospayment-encrypted-success.json");
                TerminalApiAsyncService asyncService = new TerminalApiAsyncService(client);
                string decryptedNotification = asyncService.DecryptNotification(encryptedNotification, encryptionCredentialDetails);
                Assert.AreEqual(decryptedNotification, expectedDecryption);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}