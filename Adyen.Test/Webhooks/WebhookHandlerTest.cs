using System;
using System.Linq;
using System.Text.Json;
using Adyen.Webhooks.Extensions;
using Adyen.Webhooks.Handlers;
using Adyen.ApiSerialization;
using Adyen.Model.TerminalApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;

namespace Adyen.Test.Webhooks
{
    [TestClass]
    public class WebhookHandlerTest : BaseTest
    {
        private const string TestHmacKey = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
        private readonly IWebhooksHandler _webhooksHandler;

        public WebhookHandlerTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureWebhooks((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.AdyenHmacKey = TestHmacKey; });
                    services.AddWebhooksHandler();
                })
                .Build();

            _webhooksHandler = host.Services.GetRequiredService<IWebhooksHandler>();
        }

        [TestMethod]
        public void TestAuthorisationSuccess()
        {
            var mockPath = GetMockFilePath("mocks/notification/authorisation-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var handleNotificationRequest = _webhooksHandler.DeserializeNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("AUTHORISATION", notificationItem.EventCode);
            Assert.AreEqual("1234", notificationItem.AdditionalData["authCode"]);
            Assert.AreEqual("123456789", notificationItem.PspReference);
        }
        
        [TestMethod]
        public void TestMerchantWebhookPayload()
        {
            var mockPath = GetMockFilePath("mocks/notification/merchant-webhook-payload.json");
            var jsonRequest = MockFileToString(mockPath);
            var handleNotificationRequest = _webhooksHandler.DeserializeNotificationRequest(jsonRequest);
            var json1 = JsonSerializer.Serialize(handleNotificationRequest);
            var json2 = jsonRequest;
            Assert.IsTrue(JToken.DeepEquals(JToken.Parse(json1.ToLower()), JToken.Parse(json2.ToLower())));
        }

        [TestMethod]
        public void TestCaptureSuccess()
        {
            var mockPath = GetMockFilePath("mocks/notification/capture-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var handleNotificationRequest = _webhooksHandler.DeserializeNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("CAPTURE", notificationItem.EventCode);
            Assert.AreEqual("qvS6I3Gdi1jx+jSh7IopAgcHtMoxvXlNL7DYQ+j1hd0=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(23623, notificationItem.Amount.Value);
            Assert.IsTrue(notificationItem.Success);
        }

        [TestMethod]
        public void TestCaptureFail()
        {
            var mockPath = GetMockFilePath("mocks/notification/capture-false.json");
            var jsonRequest = MockFileToString(mockPath);
            var handleNotificationRequest = _webhooksHandler.DeserializeNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("CAPTURE", notificationItem.EventCode);
            Assert.AreEqual("KujHNqpyCAMdGefj7lfQ8AeD0Jke9Zs2bVAqScQDWi4=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(23623, notificationItem.Amount.Value);
            Assert.IsFalse(notificationItem.Success);
            Assert.AreEqual("Insufficient balance on payment", notificationItem.Reason);
        }

        [TestMethod]
        public void TestRefundSuccess()
        {
            var mockPath = GetMockFilePath("mocks/notification/refund-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var handleNotificationRequest = _webhooksHandler.DeserializeNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("REFUND", notificationItem.EventCode);
            Assert.AreEqual("KJFhURWP8Pv9m8k+7NGHNJAupBj6X6J/VWAikFxeWhA=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(1500, notificationItem.Amount.Value);
            Assert.AreEqual("MagentoMerchantTest2", notificationItem.MerchantAccountCode);
            Assert.IsTrue(notificationItem.Success);
        }

        [TestMethod]
        public void TestRefundFail()
        {
            var mockPath = GetMockFilePath("mocks/notification/refund-false.json");
            var jsonRequest = MockFileToString(mockPath);
            var handleNotificationRequest = _webhooksHandler.DeserializeNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("REFUND", notificationItem.EventCode);
            Assert.AreEqual("HZXziBYopfDIzDhk49iC//yCfxmy/z0xWuvvTxFNUSA=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(1500, notificationItem.Amount.Value);
            Assert.IsFalse(notificationItem.Success);
            Assert.AreEqual("Insufficient balance on payment", notificationItem.Reason);
        }

        [TestMethod]
        public void TestIsValidHmacSignature()
        {
            var notificationItem = new Adyen.Webhooks.Models.NotificationRequestItem
            {
                PspReference = "pspReference",
                OriginalReference = "originalReference",
                MerchantAccountCode = "merchantAccount",
                MerchantReference = "reference",
                Amount = new Adyen.Webhooks.Models.Amount("EUR", 1000),
                EventCode = "EVENT",
                Success = true,
                AdditionalData = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "hmacSignature", "ipnxGCaUZ4l8TUW75a71/ghd2Fe5ffvX0pV4TLTntIc=" }
                }
            };

            Assert.IsTrue(_webhooksHandler.IsValidHmacSignature(notificationItem));
        }

        [TestMethod]
        public void TestIsNotValidHmacSignature()
        {
            var notificationItem = new Adyen.Webhooks.Models.NotificationRequestItem
            {
                PspReference = "pspReference",
                OriginalReference = "originalReference",
                MerchantAccountCode = "merchantAccount",
                MerchantReference = "reference",
                Amount = new Adyen.Webhooks.Models.Amount("EUR", 1000),
                EventCode = "EVENT",
                Success = true,
                AdditionalData = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "hmacSignature", "invalid" }
                }
            };

            Assert.IsFalse(_webhooksHandler.IsValidHmacSignature(notificationItem));
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
            var eventNotification = (EventNotification) saleToPoiRequest.MessagePayload;
            Assert.AreEqual(eventNotification.EventDetails, "newstate=IDLE&oldstate=START");
            Assert.AreEqual(eventNotification.TimeStamp, new DateTime(2019, 8, 7, 10, 16, 10));
        }
    }
}
