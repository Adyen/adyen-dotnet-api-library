#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.ApiSerialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adyen.Model.Nexo;
using System.Text;
using Adyen.Model;

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

        private static string GetSaleToPoiMessage(string online)
        {
            return "{\"SaleToPOIResponse\": {\"PaymentResponse\": {\"POIData\": {},\"PaymentResult\": {\"AuthenticationMethod\": [\"" + online + "\"],\"PaymentAcquirerData\": {\"AcquirerPOIID\": \"MX925-260390740\",\"MerchantID\": \"PME_POS\"},\"PaymentType\": \"Normal\"},\"Response\": {\"Result\": \"Success\"}},\"MessageHeader\": {\"ProtocolVersion\": \"3.0\",\"SaleID\": \"Appie\",\"MessageClass\": \"Service\",\"MessageCategory\": \"Payment\",\"ServiceID\": \"20095135\",\"POIID\": \"MX925-260390740\",\"MessageType\": \"Response\"}}}";
        }
    }
}
