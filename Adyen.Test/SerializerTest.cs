using Adyen.CloudApiSerialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Adyen.Model.Nexo;

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

        private static string GetSaleToPoiMessage(string online)
        {
            return "{\"SaleToPOIResponse\": {\"PaymentResponse\": {\"POIData\": {},\"PaymentResult\": {\"AuthenticationMethod\": [\""+ online+"\"],\"PaymentAcquirerData\": {\"AcquirerPOIID\": \"MX925-260390740\",\"MerchantID\": \"PME_POS\"},\"PaymentType\": \"Normal\"},\"Response\": {\"Result\": \"Success\"}},\"MessageHeader\": {\"ProtocolVersion\": \"3.0\",\"SaleID\": \"Appie\",\"MessageClass\": \"Service\",\"MessageCategory\": \"Payment\",\"ServiceID\": \"20095135\",\"POIID\": \"MX925-260390740\",\"MessageType\": \"Response\"}}}";
        }
    }
}
