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
            string GetDiagnosisRequest(string poiStatusJson)
            {
                var diagnosisTemplate = "{\"SaleToPOIMessage\":{\"MessageHeader\":{\"MessageClass\":\"Service\",\"MessageCategory\":\"Diagnosis\",\"MessageType\":\"Response\",\"ServiceID\":\"12345678\",\"SaleID\":\"POSSystemID12345\",\"POIID\":\"V400m-284251016\",\"ProtocolVersion\":\"3.0\"},\"DiagnosisResponse\":{\"Response\":{\"Result\":\"Success\"},POI_STATUS,\"HostStatus\":[{\"IsReachableFlag\":true}]}}}";
                return diagnosisTemplate.Replace("POI_STATUS", poiStatusJson);
            }

            var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();

            var poiStatusPrinterOk = "\"POIStatus\":{\"CommunicationOKFlag\":true,\"GlobalStatus\":\"OK\",\"PrinterStatus\":\"OK\"}";
            var poiStatusPrinterAbsent = "\"POIStatus\":{\"CommunicationOKFlag\":true,\"GlobalStatus\":\"OK\"}";

            var parsedPrinterOk = saleToPoiMessageSerializer.Deserialize(GetDiagnosisRequest(poiStatusPrinterOk));
            var parsedPrinterAbsent = saleToPoiMessageSerializer.Deserialize(GetDiagnosisRequest(poiStatusPrinterAbsent));

            Assert.IsNotNull((parsedPrinterOk.MessagePayload as DiagnosisResponse).POIStatus.PrinterStatus);
            Assert.AreEqual(PrinterStatusType.OK, (parsedPrinterOk.MessagePayload as DiagnosisResponse).POIStatus.PrinterStatus);
            Assert.IsNull((parsedPrinterAbsent.MessagePayload as DiagnosisResponse).POIStatus.PrinterStatus);
        }
    }
}