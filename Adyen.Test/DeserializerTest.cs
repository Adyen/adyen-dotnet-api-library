using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class DeserializerTest
    {
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