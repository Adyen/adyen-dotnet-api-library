using System;
using System.Collections.Generic;
using System.Text;
using Adyen.ApiSerialization;
using Adyen.Model.Checkout;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PaymentRequest = Adyen.Model.TerminalApi.PaymentRequest;
using PaymentResponse = Adyen.Model.TerminalApi.PaymentResponse;

namespace Adyen.Test
{
    [TestClass]
    public class SerializerTest
    {
        [TestMethod]
        public void SerializeByteArrayTest()
        {
            var plainTextBytes = Encoding.ASCII.GetBytes("Bytes-To-Be-Encoded");
            string base64String = System.Convert.ToBase64String(plainTextBytes);
            var base64Bytes = Encoding.ASCII.GetBytes(base64String);
            var threeDSecure = new ThreeDSecureData
            {
                Cavv = base64Bytes,
                Xid = base64Bytes
            };
            var jsonRequest = Util.JsonOperation.SerializeRequest(threeDSecure);
            var json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            Assert.AreEqual(json, jsonRequest);
        }

        [TestMethod]
        public void DeserializeByteArrayTest()
        {
            var json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            var jsonRequest = Util.JsonOperation.Deserialize<ThreeDSecureData>(json);
            var xid = Encoding.ASCII.GetString(jsonRequest.Xid);
            var cavv = Encoding.ASCII.GetString(jsonRequest.Cavv);
            var jsonElementBase64 = "Qnl0ZXMtVG8tQmUtRW5jb2RlZA==";
            Assert.AreEqual(jsonElementBase64, xid);
            Assert.AreEqual(jsonElementBase64, cavv);
        }

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
        public void CheckoutLongSerializationTest()
        {
            var checkoutSessionRequest = new CreateCheckoutSessionRequest
            {
                MerchantAccount = "merchantAccount",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Amount = new Model.Checkout.Amount("EUR", 10000L),
                Channel = CreateCheckoutSessionRequest.ChannelEnum.Web,
                CountryCode = "NL",
                LineItems = new List<LineItem>()
                {
                    new LineItem(quantity: 1, amountIncludingTax: 5000, description: "description1",
                        amountExcludingTax: 0),
                    new LineItem(quantity: 1, amountIncludingTax: 5000, description: "description2", taxAmount: 0)
                }
            }.ToJson();
            // Assert that Long parameters set to zero are actually serialised (just like Int)
            Assert.IsTrue(checkoutSessionRequest.Contains("amountExcludingTax\": 0,"));
            Assert.IsTrue(checkoutSessionRequest.Contains("taxAmount\": 0"));
        }
        
        [TestMethod]
        public void CheckoutSessionResponseCheckForIdTest()
        {
            var sessionResponse = @"{""mode"": ""embedded"",""amount"": {""currency"": ""EUR"",""value"": 10000},""expiresAt"": ""2023-04-06T17:11:15+02:00"",""id"": ""CS0068299CB8DA273A"",""merchantAccount"": ""TestMerchantAccount"",""reference"": ""TestReference"",""returnUrl"": ""http://test-url.com"",""sessionData"": ""Ab02b4c0!BQABAgBoacRJuRbNM/typUKATopkZ3V+cINm0WTAvwl9uQJ2e8I00P2KFemlwp4nb1bOqqYh1zx48gDAHt0QDs2JTiQIqDQRizqopLFRk/wAJHFoCuam/GvOHflg9vwS3caHbkBToIolxcYcJoJheIN9o1fGmNIHZb9VrWfiKsXMgmYsSUifenayS2tkKCTquF7vguaAwk7q5ES1GDwzP/J2mChJGH04jGrVL4szPHGmznr897wIcFQyBSZe4Uifqoe0fpiIxZLNWadLMya6SnvQYNAQL1V6ti+7F4wHHyLwHWTCua993sttue70TE4918EV80HcAWx0LE1+uW6J5KBHCKdYNi9ESlGSZreRwLCpdNbmumB6MlyHZlz2umLiw0ZZJAEpdrwXA2NiyHzJDKDKfbAhd8uoTSACrbgwbrAXI1cvb1WjiOQjLn9MVW++fuJCq6vIeX+rUKMeltBAHMeBZyC54ndAucw9nS03uyckjphunE4tl4WTT475VkfUiyJCTT3S2IOVYS9V9M8pMQ1/GlDVNCLBJJfrYlVXoC8VX68QW1HERkhNYQbTgLQ9kI3cDeMP5d4TuUL3XR2Q6sNiOMdIPGDYQ9QFKFdOE3OQ5X9wxUYbX6j88wR2gRGJcS5agqFHOR1ZTNrjumOYrEkjL8ehFXEs/KluhURllfi0POUPGAwlUWBjDCZcKaeeR0kASnsia2V5IjoiQUYwQUFBMTAzQ0E1MzdFQUVEODdDMjRERDUzOTA5QjgwQTc4QTkyM0UzODIzRDY4REFDQzk0QjlGRjgzMDVEQyJ9E0Gs1T0RaO7NluuXP59fegcW6SQKq4BhC3ZzEKPm1vJuwAJ2gZUaicaXbRPW3IyadavKRlfGdFeAYt2B3ik8fGiK3ZkKU0CrZ0qL0IO5rrWrOg74HMnpxRAn1RhAHRHfGEk67FFPNjr0aLBJXSia7xZWiyKA+i4QU63roY2sxMI/q41mvJjRUz0rPKT3SbVDt1Of7K7BP8cmiboBkWexFBD/mkJyMOpYAOoFp/tKOUHTWZYcc1GpbyV1jInXVfEUhHROYCtS4p/xwF6DdT3bI0+HRU35/xNBTZH2yJN55u9i42Vb0ddCyhzOLZYQ3JVgglty6hLgVeQzuN4b2MoalhfTl11HsElJT1kB0mznVX8CL7UMTUp/2uSgL8DN6kB4owEZ45nWRxIR/2sCidMJ1tnSI1uSqkeqXRf1vat5qPq+BzpYE0Urn2ZZEmgJyb2u0ZLn2x1tfJyPtv+hqBoT7iqJ224dSbuB4HMT49YtcheUtR0jnrImJXm+M1TeIjWB3XWOScrNV8sWEJMAiIU="",""shopperLocale"": ""en-US""}";
            // Assert that readonly parameters like ID are actually deserialised and can be serialised again.
            var deserializedResponse = JsonConvert.DeserializeObject<CreateCheckoutSessionResponse>(sessionResponse);
            Assert.IsNotNull(deserializedResponse.Id);
            Assert.IsTrue(deserializedResponse.ToJson().Contains("\"id\": \"CS0068299CB8DA273A\","));
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

        private static SaleToPOIRequest CreatePosPaymentRequest()
        {
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
