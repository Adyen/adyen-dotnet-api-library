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

using System;
using Adyen.ApiSerialization;
using Adyen.Model.Nexo;

namespace Adyen.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Notification;
    using System.Linq;

    [TestClass]
    public class NotificationTest : BaseTest
    {
        [TestMethod]
        public void TestAuthorisationSuccess()
        {
            var mockPath = GetMockFilePath("Mocks/notification/authorisation-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItems.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationRequestItem;
            Assert.AreEqual("AUTHORISATION", notificationItem.EventCode);
            Assert.AreEqual("1234", notificationItem.AdditionalData["authCode"]);
            Assert.AreEqual("123456789", notificationItem.PspReference);
        }

        [TestMethod]
        public void TestCaptureSuccess()
        {
            var mockPath = GetMockFilePath("Mocks/notification/capture-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItems.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationRequestItem;
            Assert.AreEqual("CAPTURE", notificationItem.EventCode);
            Assert.AreEqual("qvS6I3Gdi1jx+jSh7IopAgcHtMoxvXlNL7DYQ+j1hd0=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(23623, notificationItem.Amount.Value);
            Assert.IsTrue(bool.Parse(notificationItem.Success));
        }

        [TestMethod]
        public void TestCaptureFail()
        {
            var mockPath = GetMockFilePath("Mocks/notification/capture-false.json");
            var jsonRequest = MockFileToString(mockPath);
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItems.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationRequestItem;
            Assert.AreEqual("CAPTURE", notificationItem.EventCode);
            Assert.AreEqual("KujHNqpyCAMdGefj7lfQ8AeD0Jke9Zs2bVAqScQDWi4=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(23623, notificationItem.Amount.Value);
            Assert.IsFalse(bool.Parse(notificationItem.Success));
            Assert.AreEqual("Insufficient balance on payment", notificationItem.Reason);
        }

        [TestMethod]
        public void TestRefundSuccess()
        {
            var mockPath = GetMockFilePath("Mocks/notification/refund-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItems.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationRequestItem;
            Assert.AreEqual("REFUND", notificationItem.EventCode);
            Assert.AreEqual("KJFhURWP8Pv9m8k+7NGHNJAupBj6X6J/VWAikFxeWhA=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(1500, notificationItem.Amount.Value);
            Assert.AreEqual("MagentoMerchantTest2", notificationItem.MerchantAccountCode);
            Assert.IsTrue(bool.Parse(notificationItem.Success));
        }

        [TestMethod]
        public void TestRefundFail()
        {
            var mockPath = GetMockFilePath("Mocks/notification/refund-false.json");
            var jsonRequest = MockFileToString(mockPath);
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItems.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationRequestItem;
            Assert.AreEqual("REFUND", notificationItem.EventCode);
            Assert.AreEqual("HZXziBYopfDIzDhk49iC//yCfxmy/z0xWuvvTxFNUSA=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(1500, notificationItem.Amount.Value);
            Assert.IsFalse(bool.Parse(notificationItem.Success));
            Assert.AreEqual("Insufficient balance on payment", notificationItem.Reason);
        }

        [TestMethod]
        public void TestPOSDisplayNotification()
        {
            var notification =
                "{\"SaleToPOIRequest\":{\"DisplayRequest\":{\"DisplayOutput\":[{\"Device\": \"CashierDisplay\",\"InfoQualify\": \"Status\",\"OutputContent\": {\"OutputFormat\": \"MessageRef\",\"PredefinedContent\": {\"ReferenceID\": \"TransactionID=oLkO001517998574000&TimeStamp=2018-02-07T10%3a16%3a14.000Z&event=TENDER_CREATED\"}},\"ResponseRequiredFlag\": false}]},\"MessageHeader\":{\"SaleID\":\"POSSystemID12345\",\"ProtocolVersion\":\"3.0\",\"MessageType\":\"Request\",\"POIID\":\"V400m-324688179\",\"ServiceID\":\"0207111617\",\"MessageClass\":\"Device\",\"MessageCategory\":\"Display\",\"DeviceID\":\"1517998562\"}}}";
            var serializer = new SaleToPoiMessageSerializer();
            var saleToPoiRequest = serializer.DeserializeNotification(notification);
            var displayRequest = (DisplayRequest)saleToPoiRequest.MessagePayload;
            Assert.AreEqual(displayRequest.DisplayOutput[0].OutputContent.OutputFormat, OutputFormatType.MessageRef);
            Assert.AreEqual(displayRequest.DisplayOutput[0].Device, DeviceType.CashierDisplay);
        }
        
        [TestMethod]
        public void TestPOSEventNotification()
        {
            var notification = @"{
                'SaleToPOIRequest':{
                    'EventNotification':{
                        'EventDetails':'newstate=IDLE&oldstate=START',
                        'EventToNotify':'Shutdown',
                        'TimeStamp':'2019-08-07T10:16:10.000Z'
                        },
                    'MessageHeader':{
                        'SaleID':'POSSystemID12345',
                        'ProtocolVersion':'3.0',
                        'MessageType':'Notification',
                        'POIID':'V400m-324688179',
                        'MessageClass':'Event',
                        'MessageCategory':'Event',
                        'DeviceID':'1517998561'
                        }
                    }
            }";
            var serializer = new SaleToPoiMessageSerializer();
            var saleToPoiRequest = serializer.DeserializeNotification(notification);
            var eventNotification = (EventNotification)saleToPoiRequest.MessagePayload;
            Assert.AreEqual(eventNotification.EventDetails, "newstate=IDLE&oldstate=START");
            Assert.AreEqual(eventNotification.TimeStamp, new DateTime(2019, 8, 7, 10, 16, 10));
        }
    }
}

