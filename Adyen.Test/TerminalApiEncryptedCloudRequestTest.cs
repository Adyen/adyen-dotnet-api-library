using System;
using System.Net.Http;
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
    public class TerminalApiEncryptedCloudRequestTest : BaseTest
    {
        private TerminalApi _terminalApi;
        private SaleToPOIRequest _paymentRequest;
        // private SaleToPoiMessageSecuredSerializer _saleToPoiMessageSecuredSerializer;

        [TestInitialize]
        public void Init()
        {
            var config = new Config() {
                LocalTerminalApiEndpoint = @"https://192.168.47.5:8443/nexo",
                Environment = Environment.Test,
                XApiKey = "AQEthmfxLo/HaxBFw0m/n3Q5qf3VZYpKCJ1eV0FTy3dvbXD6iiPz02Lhp8Zbr/YDEMFdWw2+5HzctViMSCJMYAc=-yobXNnz1y2CJhTy10KgkdB/gDnambqs1l1uqK2D1Tis=-9(@5~g{@dz]]B#H=",
            };

            var client = new Client(config);
            var abstractService = new AbstractService(client);
            _terminalApi = new TerminalApi(abstractService, false);
        }

        public SaleToPOIRequest CreateTestPaymentRequest()
        {
            var saleToPoiRequest = new SaleToPOIRequest() {
                MessageHeader = new MessageHeader() {
                    MessageType = MessageType.Request,
                    MessageClass = MessageClassType.Service,//which parameters?
                    MessageCategory = MessageCategoryType.Payment,//which parameters? documentation, hub, welke pijnpunten, suggesties voor documentaties opschrijven
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
        public async Task Test2CloudApiAsyncRequest() {
            var encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyIdentifier = "CryptoKeyIdentifier12345",
                Password = "p@ssw0rd123456"
            };
            var saleToPoiRequest = CreateTestPaymentRequest();
            var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            var serializedOutput= saleToPoiMessageSerializer.Serialize(saleToPoiRequest);
            var messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            var securedMessage =
                messageSecuredEncryptor.Encrypt(serializedOutput, saleToPoiRequest.MessageHeader, encryptionCredentialDetails);
            var serializedSecuredMessage = saleToPoiMessageSerializer.Serialize(securedMessage);
            var response = await _terminalApi.RequestAsync(serializedSecuredMessage);
            Assert.IsNotNull(response);
        }
    }
}
 