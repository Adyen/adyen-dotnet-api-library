using System;
using Adyen.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]

    public class ByteArrayToStringTest
    {
        [TestMethod]
        public void TestSerialize()
        {
            var json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            var bytesArray = Convert.FromBase64String("Qnl0ZXMtVG8tQmUtRW5jb2RlZA==");
            var threeDSecure = new ThreeDSecureData
            {
                Cavv = bytesArray,
                Xid = bytesArray
            };
            var jsonRequest = Util.JsonOperation.SerializeRequest(threeDSecure);
            Assert.AreEqual(json, jsonRequest);
        }
        
        [TestMethod]
        public void TestDeserialize()
        {
            var json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            var jsonElementBase64 = "Qnl0ZXMtVG8tQmUtRW5jb2RlZA==";
            var jsonRequest = Util.JsonOperation.Deserialize<ThreeDSecureData>(json);
            var xid = Convert.ToBase64String(jsonRequest.Xid);
            var cavv = Convert.ToBase64String(jsonRequest.Cavv);
            Assert.AreEqual(xid,jsonElementBase64);
            Assert.AreEqual(cavv, jsonElementBase64);
        }
    }
}
