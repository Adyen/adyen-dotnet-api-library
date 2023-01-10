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
            byte[] plainTextBytes = Encoding.ASCII.GetBytes("Bytes-To-Be-Encoded");
            string base64String = System.Convert.ToBase64String(plainTextBytes);
            byte[] base64Bytes = Encoding.ASCII.GetBytes(base64String);
            ThreeDSecureData threeDSecure = new ThreeDSecureData
            {
                Cavv = base64Bytes,
                Xid = base64Bytes
            };
            string jsonRequest = Util.JsonOperation.SerializeRequest(threeDSecure);
            string json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            Assert.AreEqual(json, jsonRequest);
        }

        [TestMethod]
        public void DeserializeByteArrayTest()
        {
            string json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            ThreeDSecureData jsonRequest = Util.JsonOperation.Deserialize<ThreeDSecureData>(json);
            string xid = Encoding.ASCII.GetString(jsonRequest.Xid);
            string cavv = Encoding.ASCII.GetString(jsonRequest.Cavv);
            string jsonElementBase64 = "Qnl0ZXMtVG8tQmUtRW5jb2RlZA==";
            Assert.AreEqual(jsonElementBase64, xid);
            Assert.AreEqual(jsonElementBase64, cavv);
        }

        [TestMethod]
        public void EnumSerializerTest()
        {
            SaleToPoiMessageSerializer saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
            SaleToPOIResponse saleToMessageOnLine = saleToPoiMessageSerializer.Deserialize(GetSaleToPoiMessage("OnlinePin"));
            SaleToPOIResponse saleToMessageOnline = saleToPoiMessageSerializer.Deserialize(GetSaleToPoiMessage("OnLinePin"));
            PaymentResponse paymentResponseOnLine = (PaymentResponse)saleToMessageOnLine.MessagePayload;
            PaymentResponse paymentResponseOnline = (PaymentResponse)saleToMessageOnline.MessagePayload;
            Assert.AreEqual(paymentResponseOnline.PaymentResult.AuthenticationMethod[0], AuthenticationMethodType.OnLinePIN);
            Assert.AreEqual(paymentResponseOnLine.PaymentResult.AuthenticationMethod[0], AuthenticationMethodType.OnLinePIN);
        }

        private static string GetSaleToPoiMessage(string online)
        {
            return "{\"SaleToPOIResponse\": {\"PaymentResponse\": {\"POIData\": {},\"PaymentResult\": {\"AuthenticationMethod\": [\"" + online + "\"],\"PaymentAcquirerData\": {\"AcquirerPOIID\": \"MX925-260390740\",\"MerchantID\": \"PME_POS\"},\"PaymentType\": \"Normal\"},\"Response\": {\"Result\": \"Success\"}},\"MessageHeader\": {\"ProtocolVersion\": \"3.0\",\"SaleID\": \"Appie\",\"MessageClass\": \"Service\",\"MessageCategory\": \"Payment\",\"ServiceID\": \"20095135\",\"POIID\": \"MX925-260390740\",\"MessageType\": \"Response\"}}}";
        }
    }
}
