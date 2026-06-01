using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class DeserializerTest
    {
        // Regression test for https://github.com/Adyen/adyen-dotnet-api-library/issues/1771
        // DeserializeNotification should handle responses that include an "eventType" field at the root level.
        [TestMethod]
        public void DeserializeNotification_WithEventTypeAtRootLevel_ShouldNotThrow()
        {
            var serializer = new SaleToPoiMessageSerializer();
            const string json = @"{
                ""eventType"": ""REJECT"",
                ""SaleToPOIRequest"": {
                    ""MessageHeader"": {
                        ""DeviceID"": ""device123"",
                        ""MessageCategory"": ""Event"",
                        ""MessageClass"": ""Event"",
                        ""MessageType"": ""Notification"",
                        ""POIID"": ""S1EL-device123"",
                        ""ProtocolVersion"": ""3.0"",
                        ""SaleID"": ""000"",
                        ""ServiceID"": ""89bd8837e0""
                    },
                    ""EventNotification"": {
                        ""RejectedMessage"": ""c29tZSBtZXNzYWdl"",
                        ""EventToNotify"": ""Reject"",
                        ""TimeStamp"": ""2026-06-01T12:51:26.438Z"",
                        ""EventDetails"": ""message=Failed+to+send+message+to+POI.""
                    }
                }
            }";

            var result = serializer.DeserializeNotification(json);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.MessageHeader);
            Assert.IsNotNull(result.MessagePayload);
            Assert.IsInstanceOfType(result.MessagePayload, typeof(EventNotification));
        }

        // Regression test for https://github.com/Adyen/adyen-dotnet-api-library/issues/1771
        // Deserialize should handle responses that include an "eventType" field at the root level.
        [TestMethod]
        public void Deserialize_WithEventTypeAtRootLevel_ShouldNotThrow()
        {
            var serializer = new SaleToPoiMessageSerializer();
            const string json = @"{
                ""eventType"": ""REJECT"",
                ""SaleToPOIResponse"": {
                    ""MessageHeader"": {
                        ""ProtocolVersion"": ""3.0"",
                        ""SaleID"": ""POSSystemID12345"",
                        ""MessageClass"": ""Service"",
                        ""MessageCategory"": ""Payment"",
                        ""ServiceID"": ""20095135"",
                        ""POIID"": ""MX925-260390740"",
                        ""MessageType"": ""Response""
                    },
                    ""PaymentResponse"": {
                        ""POIData"": {},
                        ""PaymentResult"": {
                            ""PaymentType"": ""Normal""
                        },
                        ""Response"": {
                            ""Result"": ""Success""
                        }
                    }
                }
            }";

            var result = serializer.Deserialize(json);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.MessageHeader);
            Assert.IsNotNull(result.MessagePayload);
            Assert.IsInstanceOfType(result.MessagePayload, typeof(PaymentResponse));
        }

        // Regression test for https://github.com/Adyen/adyen-dotnet-api-library/issues/1771
        // SaleToPoiMessageSecuredSerializer.Deserialize should handle responses with an "eventType" field at the root level.
        [TestMethod]
        public void SecuredDeserialize_WithEventTypeAtRootLevel_ShouldNotThrow()
        {
            var serializer = new SaleToPoiMessageSecuredSerializer();
            const string json = @"{
                ""eventType"": ""REJECT"",
                ""SaleToPOIResponse"": {
                    ""MessageHeader"": {
                        ""ProtocolVersion"": ""3.0"",
                        ""SaleID"": ""John"",
                        ""MessageClass"": ""Service"",
                        ""MessageCategory"": ""Payment"",
                        ""ServiceID"": ""9739"",
                        ""POIID"": ""MX915-284251016"",
                        ""MessageType"": ""Response""
                    },
                    ""NexoBlob"": ""dummyblob"",
                    ""SecurityTrailer"": {
                        ""AdyenCryptoVersion"": 1,
                        ""Nonce"": ""YIyJBzjWFCAZn31QfAvGLA=="",
                        ""KeyIdentifier"": ""testkey"",
                        ""Hmac"": ""hpptt0KfxlALCMSo35tTwtgw6fDNbQEESOTdD0AD9Sg="",
                        ""KeyVersion"": 1
                    }
                }
            }";

            var result = serializer.Deserialize(json);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.MessageHeader);
            Assert.AreEqual("dummyblob", result.NexoBlob);
        }

        [TestMethod]
        public void PrinterStatusSerializerTest()
        {
            var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            string GetDiagnosisResponse(string poiStatusJson)
            {
                var diagnosisResponseMessage = new SaleToPOIMessage()
                {
                    MessageHeader = new MessageHeader() { 
                        MessageClass = MessageClassType.Service, 
                        MessageCategory = MessageCategoryType.Diagnosis, 
                        MessageType = MessageType.Response, 
                        ServiceID = "12345678", 
                        SaleID = "POSSystemID12345", 
                        POIID = "V400m-284251016" 
                    },
                    MessagePayload = new DiagnosisResponse() 
                };
                var diagnosisTemplate = saleToPoiMessageSerializer.Serialize(diagnosisResponseMessage);
                var diagnosisStart = @"""DiagnosisResponse"":{";
                var insertIndex = diagnosisTemplate.IndexOf(diagnosisStart) + diagnosisStart.Length;
                return diagnosisTemplate.Insert(insertIndex, poiStatusJson);
            }
            var poiStatusPrinterOk = @"""POIStatus"":{""CommunicationOKFlag"":true,""GlobalStatus"":""OK"",""PrinterStatus"":""OK""}";
            var poiStatusPrinterAbsent = @"""POIStatus"":{""CommunicationOKFlag"":true,""GlobalStatus"":""OK""}";

            var parsedPrinterOk = saleToPoiMessageSerializer.Deserialize(GetDiagnosisResponse(poiStatusPrinterOk));
            var parsedPrinterAbsent = saleToPoiMessageSerializer.Deserialize(GetDiagnosisResponse(poiStatusPrinterAbsent));

            Assert.IsNotNull((parsedPrinterOk.MessagePayload as DiagnosisResponse).POIStatus.PrinterStatus);
            Assert.AreEqual(PrinterStatusType.OK, (parsedPrinterOk.MessagePayload as DiagnosisResponse).POIStatus.PrinterStatus);
            Assert.IsNull((parsedPrinterAbsent.MessagePayload as DiagnosisResponse).POIStatus.PrinterStatus);
        }
    }
}