using System;
using System.Linq;
using Adyen.ApiSerialization;
using Adyen.Model.ConfigurationNotification;
using Adyen.Model.Nexo;
using Adyen.Util;
using Adyen.Webhooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class WebhookTest : BaseTest
    {
        [TestMethod]
        public void TestAuthorisationSuccess()
        {
            var mockPath = GetMockFilePath("mocks/notification/authorisation-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var webhookHandler = new WebhookHandler();
            var handleNotificationRequest = webhookHandler.HandleNotificationRequest(jsonRequest);
            var notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            var notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("AUTHORISATION", notificationItem.EventCode);
            Assert.AreEqual("1234", notificationItem.AdditionalData["authCode"]);
            Assert.AreEqual("123456789", notificationItem.PspReference);
        }

        [TestMethod]
        public void TestCaptureSuccess()
        {
            var mockPath = GetMockFilePath("mocks/notification/capture-true.json");
            var jsonRequest = MockFileToString(mockPath);
            var webhookHandler = new WebhookHandler();
            var handleNotificationRequest = webhookHandler.HandleNotificationRequest(jsonRequest);
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
            var webhookHandler = new WebhookHandler();
            var handleNotificationRequest = webhookHandler.HandleNotificationRequest(jsonRequest);
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
            var webhookHandler = new WebhookHandler();
            var handleNotificationRequest = webhookHandler.HandleNotificationRequest(jsonRequest);
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
            var webhookHandler = new WebhookHandler();
            var handleNotificationRequest = webhookHandler.HandleNotificationRequest(jsonRequest);
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
        
        [TestMethod]
        public void Given_BalancePlatformBalanceAccountSweep_When_Is_Valid_Hmac_Then_Result_Should_Be_True()
        {
            var notification = "{\"data\":{\"balancePlatform\":\"Integration_tools_test\",\"accountId\":\"BA32272223222H5HVKTBK4MLB\",\"sweep\":{\"id\":\"SWPC42272223222H5HVKV6H8C64DP5\",\"schedule\":{\"type\":\"balance\"},\"status\":\"active\",\"targetAmount\":{\"currency\":\"EUR\",\"value\":0},\"triggerAmount\":{\"currency\":\"EUR\",\"value\":0},\"type\":\"pull\",\"counterparty\":{\"balanceAccountId\":\"BA3227C223222H5HVKT3H9WLC\"},\"currency\":\"EUR\"}},\"environment\":\"test\",\"type\":\"balancePlatform.balanceAccountSweep.updated\"}";
            var signKey = "D7DD5BA6146493707BF0BE7496F6404EC7A63616B7158EC927B9F54BB436765F";
            var hmacKey = "9Qz9S/0xpar1klkniKdshxpAhRKbiSAewPpWoxKefQA=";
            var hmacValidator = new HmacValidator();
            bool response = hmacValidator.IsValidBankingHmac(hmacKey, signKey, notification);
            Assert.IsTrue(response);
        }
        
        [TestMethod]
        public void Given_BalancePlatformBalanceAccountHolderCreated_When_Valid_Webhook_Then_Result_Should_Deserialize()
        {
            var handler = new BankingWebhookHandler(
                @"{ 'data': {
                    'balancePlatform': 'YOUR_BALANCE_PLATFORM',
                    'accountHolder': {
                        'contactDetails': {
                            'address': {
                                'country': 'NL',
                                'houseNumberOrName': '274',
                                'postalCode': '1020CD',
                                'street': 'Brannan Street'
                            },
                            'email': 's.hopper@example.com',
                            'phone': {
                                'number': '+315551231234',
                                'type': 'Mobile'
                            }
                        },
                        'description': 'S.Hopper - Staff 123',
                        'id': 'AH00000000000000000000001',
                        'status': 'Active'
                    }
                },
                'environment': 'test',
                'type': 'balancePlatform.accountHolder.created'
            }");
            AccountHolderNotificationRequest webhook = handler.GetAccountHolderNotificationRequest();
            Assert.IsNotNull(webhook);
            Assert.AreEqual(webhook.Data.BalancePlatform, "YOUR_BALANCE_PLATFORM");

        }
    }
}
