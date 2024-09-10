using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Adyen.ApiSerialization;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.Management;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Adyen.Service;
using Adyen.Service.Resource.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalCloudAsyncTest : BaseTest //mock api key
    {
        private readonly ITerminalCloudAsyncApi _terminalCloudAsyncApi;
        
        public TerminalCloudAsyncTest()
        {
            var config = new Config() {
                Environment = Environment.Test,
                XApiKey = "your-api-key"
            };
            var client = new Client(config);
            _terminalCloudAsyncApi = new TerminalCloudAsyncApi(client);
        }

        public SaleToPOIRequest CreateTestPaymentRequest()
        {
            var saleToPoiRequest = new SaleToPOIRequest() {
                MessageHeader = new MessageHeader() {
                    MessageType = MessageType.Request,
                    MessageClass = MessageClassType.Service,
                    MessageCategory = MessageCategoryType.Payment,
                    SaleID = "POSSystemID124",
                    POIID = "V400m-383034820",
                    ServiceID = DateTime.Now.ToString("ddHHmmss"),
                },
                MessagePayload = new PaymentRequest() {
                SaleData = new SaleData() {
                    SaleTransactionID = new TransactionIdentification {
                            TransactionID = "23423",
                            TimeStamp = DateTime.Now
                        },
                        TokenRequestedType = TokenRequestedType.Customer,
                },
                PaymentTransaction = new PaymentTransaction {
                    AmountsReq = new AmountsReq {
                        Currency = "EUR",
                        RequestedAmount = 1000
                    }
                },
                PaymentData = new PaymentData {
                        PaymentType = PaymentType.Normal
                    }
                }
            };
            return saleToPoiRequest;
        }

        [TestMethod]
        public async Task TestPaymentSuccess2() { // rename
            var encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyVersion = 1,
                KeyIdentifier = "keyID",
                Password = "keyPW1234"
            };
            var saleToPoiRequest = CreateTestPaymentRequest();
            var response = await _terminalCloudAsyncApi.RequestAsync(saleToPoiRequest, encryptionCredentialDetails);
            Assert.AreEqual(response, "ok");
        }
        
        [TestMethod]
        public async Task TestPaymentFaillure() {
            var encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyVersion = 1,
                KeyIdentifier = "keyID",
                Password = "keyPW1234"
            };
            var saleToPoiRequest = CreateTestPaymentRequest();
            var response = await _terminalCloudAsyncApi.RequestAsync(saleToPoiRequest, encryptionCredentialDetails);
            Assert.AreEqual(response, "null");
        }
    }
}
 