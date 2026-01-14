using System;
using System.Collections.Generic;
using System.Text;
using Adyen.ApiSerialization;
using Adyen.Constants;
using Adyen.Model.Terminal;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ApplicationInfo = Adyen.Model.ApplicationInformation.ApplicationInfo;
using CommonField = Adyen.Model.ApplicationInformation.CommonField;
using PaymentRequest = Adyen.Model.TerminalApi.PaymentRequest;
using PaymentResponse = Adyen.Model.TerminalApi.PaymentResponse;

namespace Adyen.Test
{
    [TestClass]
    public class SerializerTest
    {
        [TestMethod]
        public void EnumSerializerTest()
        {
            var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            var saleToMessageOnLine = saleToPoiMessageSerializer.Deserialize(GetSaleToPoiMessage("OnlinePin"));
            var saleToMessageOnline = saleToPoiMessageSerializer.Deserialize(GetSaleToPoiMessage("OnLinePin"));
            var paymentResponseOnLine = (PaymentResponse)saleToMessageOnLine.MessagePayload;
            var paymentResponseOnline = (PaymentResponse)saleToMessageOnline.MessagePayload;
            Assert.AreEqual(paymentResponseOnline.PaymentResult.AuthenticationMethod[0], AuthenticationMethodType.OnLinePIN);
            Assert.AreEqual(paymentResponseOnLine.PaymentResult.AuthenticationMethod[0], AuthenticationMethodType.OnLinePIN);
        }
        
        [TestMethod]
        public void SaleToPoiMessageSerializationTest()
        {
            SaleToPOIRequest saleToPoiMessage = CreatePosPaymentRequest();
            string serialized = SerializeSaleToPoiMessage(saleToPoiMessage);
            Assert.AreEqual(serialized, ExpectedSaleToPoiMessageJson);
        }

        [TestMethod]
        public void SaleToPoiMessageWithUpdatedJsonConvertDefaultSettingsSerializationTest()
        {
            SaleToPOIRequest saleToPoiMessage = CreatePosPaymentRequest();

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };

            string serialized = SerializeSaleToPoiMessage(saleToPoiMessage);
            try
            {
                Assert.AreEqual(serialized, ExpectedSaleToPoiMessageJson);
            }
            finally
            {
                JsonConvert.DefaultSettings = null;
            }
        }

        [TestMethod]
        public void SaleToPoiMessageSecuredSerializationTest()
        {
            SaleToPOIRequest saleToPoiMessage = CreatePosPaymentRequest();
            string serialized = SerializeSaleToPoiMessageSecured(saleToPoiMessage);
            Assert.AreEqual(serialized, ExpectedSaleToPoiMessageSecuredJson);
        }

        [TestMethod]
        public void SaleToPoiMessageSecuredWithUpdatedJsonConvertDefaultSettingsSerializationTest()
        {
            SaleToPOIRequest saleToPoiMessage = CreatePosPaymentRequest();

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };

            try
            {
                string serialized = SerializeSaleToPoiMessageSecured(saleToPoiMessage);

                Assert.AreEqual(serialized, ExpectedSaleToPoiMessageSecuredJson);
            }
            finally
            {
                JsonConvert.DefaultSettings = null;
            }
        }

        private static string GetSaleToPoiMessage(string online)
        {
            return "{\"SaleToPOIResponse\": {\"PaymentResponse\": {\"POIData\": {},\"PaymentResult\": {\"AuthenticationMethod\": [\"" + online + "\"],\"PaymentAcquirerData\": {\"AcquirerPOIID\": \"MX925-260390740\",\"MerchantID\": \"PME_POS\"},\"PaymentType\": \"Normal\"},\"Response\": {\"Result\": \"Success\"}},\"MessageHeader\": {\"ProtocolVersion\": \"3.0\",\"SaleID\": \"Appie\",\"MessageClass\": \"Service\",\"MessageCategory\": \"Payment\",\"ServiceID\": \"20095135\",\"POIID\": \"MX925-260390740\",\"MessageType\": \"Response\"}}}";
        }

        private static string SerializeSaleToPoiMessage(SaleToPOIMessage saleToPoiMessage)
        {
            var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            return saleToPoiMessageSerializer.Serialize(saleToPoiMessage);
        }

        private static string SerializeSaleToPoiMessageSecured(SaleToPOIMessage saleToPoiMessage)
        {
            var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            var serializedSaleToPoiMessage = saleToPoiMessageSerializer.Serialize(saleToPoiMessage);

            var encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyVersion = 1,
                KeyIdentifier = "CryptoKeyIdentifier12345",
                Password = "p@ssw0rd123456"
            };
            var messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            var saleToPoiMessageSecured = messageSecuredEncryptor.Encrypt(
                serializedSaleToPoiMessage,
                saleToPoiMessage.MessageHeader,
                encryptionCredentialDetails);

            // Clear SecurityTrailer.Nonce and NexoBlob as they are randomly generated every run
            saleToPoiMessageSecured.NexoBlob = null;
            saleToPoiMessageSecured.SecurityTrailer.Nonce = null;

            return saleToPoiMessageSerializer.Serialize(saleToPoiMessageSecured);
        }

        /// <summary>
        /// Returns a POS Payment Request for our serialization tests.
        /// Hardcode the version so that we can test the hardcoded hmac (after encryption) and SaleToAcquirerData:
        /// <see cref="ExpectedSaleToPoiMessageJson"/> and <see cref="ExpectedSaleToPoiMessageSecuredJson"/> can be
        /// <returns><see cref="SaleToPOIRequest"/>.</returns>
        /// </summary>
        private static SaleToPOIRequest CreatePosPaymentRequest()
        {
            ApplicationInfo applicationInfo = new ApplicationInfo();
            applicationInfo.AdyenLibrary.Version = "26.1.0";
            
            return new SaleToPOIRequest
            {
                MessageHeader = new MessageHeader
                {
                    MessageType = MessageType.Request,
                    MessageClass = MessageClassType.Service,
                    MessageCategory = MessageCategoryType.Payment,
                    SaleID = "POSSystemID12345",
                    POIID = "MX915-284251016",
                    ServiceID = "12345678"
                },
                MessagePayload = new PaymentRequest
                { 
                    SaleData = new SaleData
                    {
                        SaleToAcquirerData = new SaleToAcquirerData()
                        {
                            ApplicationInfo = applicationInfo
                        },
                        SaleTransactionID = new TransactionIdentification
                        {
                            TransactionID = "PosAuth",
                            TimeStamp = new DateTime(2025, 1, 1)
                        },
                        TokenRequestedType = TokenRequestedType.Customer,
                    },
                    PaymentTransaction = new PaymentTransaction
                    {
                        AmountsReq = new AmountsReq
                        {
                            Currency = "EUR",
                            RequestedAmount = 10100
                        }
                    },
                    PaymentData = new PaymentData
                    {
                        PaymentType = PaymentType.Normal
                    }
                }
            };
        }

        private static string ExpectedSaleToPoiMessageJson => @"{""SaleToPOIRequest"":{""MessageHeader"":{""MessageClass"":""Service"",""MessageCategory"":""Payment"",""MessageType"":""Request"",""ServiceID"":""12345678"",""SaleID"":""POSSystemID12345"",""POIID"":""MX915-284251016"",""ProtocolVersion"":""3.0""},""PaymentRequest"":{""SaleData"":{""SaleTransactionID"":{""TransactionID"":""PosAuth"",""TimeStamp"":""2025-01-01T00:00:00""},""SaleToAcquirerData"":""eyJhcHBsaWNhdGlvbkluZm8iOnsiYWR5ZW5MaWJyYXJ5Ijp7Im5hbWUiOiJhZHllbi1kb3RuZXQtYXBpLWxpYnJhcnkiLCJ2ZXJzaW9uIjoiMjYuMS4wIn19fQ=="",""TokenRequestedType"":""Customer""},""PaymentTransaction"":{""AmountsReq"":{""Currency"":""EUR"",""RequestedAmount"":10100.0}},""PaymentData"":{""PaymentType"":""Normal""}}}}";

        private static string ExpectedSaleToPoiMessageSecuredJson => @"{""SaleToPOIRequest"":{""MessageHeader"":{""MessageClass"":""Service"",""MessageCategory"":""Payment"",""MessageType"":""Request"",""ServiceID"":""12345678"",""SaleID"":""POSSystemID12345"",""POIID"":""MX915-284251016"",""ProtocolVersion"":""3.0""},""NexoBlob"":null,""SecurityTrailer"":{""AdyenCryptoVersion"":1,""KeyIdentifier"":""CryptoKeyIdentifier12345"",""KeyVersion"":1,""Hmac"":""mBUD3BeMrloo5aPlwUCFIa87YW8hY9/i3AcrOa2qbhk=""}}}";
    }
}
