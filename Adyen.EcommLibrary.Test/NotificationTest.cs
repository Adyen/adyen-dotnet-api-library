namespace Adyen.EcommLibrary.Test
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
            //var jsonRequest = base.MockFileToString("Mocks/Notification/authorisation-true.json");
            var jsonRequest = "{\"live\":\"false\",\"notificationItems\":[{\"NotificationRequestItem\":{\"additionalData\":{\"expiryDate\":\"12/2012\",\" NAME1 \":\"VALUE1\",\"authCode\":\"1234\",\"cardSummary\":\"7777\",\"totalFraudScore\":\"10\",\"hmacSignature\":\"OzDjCMZIsdtDqrZ+cl/FWC+WdESrorctXTzAzW33dXI=\",\"NAME2\":\"  VALUE2  \",\"fraudCheck-6-ShopperIpUsage\":\"10\"},\"amount\":{\"currency\":\"EUR\",\"value\":10100},\"eventCode\":\"AUTHORISATION\",\"eventDate\":\"2017-01-19T16:42:03+01:00\",\"merchantAccountCode\":\"MagentoMerchantTest2\",\"merchantReference\":\"8313842560770001\",\"operations\":[\"CANCEL\",\"CAPTURE\",\"REFUND\"],\"paymentMethod\":\"visa\",\"pspReference\":\"123456789\",\"reason\":\"1234:7777:12/2012\",\"success\":\"true\"}}]}";
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
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
            //var jsonRequest = base.MockFileToString("Mocks/Notification/capture-true.json");
            var jsonRequest = "{\"live\":\"false\",\"notificationItems\":[{\"NotificationRequestItem\":{\"additionalData\":{\"hmacSignature\":\"qvS6I3Gdi1jx+jSh7IopAgcHtMoxvXlNL7DYQ+j1hd0=\"},\"amount\":{\"currency\":\"USD\",\"value\":23623},\"eventCode\":\"CAPTURE\",\"eventDate\":\"2017-01-25T18:08:19+01:00\",\"merchantAccountCode\":\"MagentoMerchantTest2\",\"merchantReference\":\"00000001\",\"originalReference\":\"ORIGINAL_PSP\",\"paymentMethod\":\"visa\",\"pspReference\":\"PSP_REFERENCE\",\"reason\":\"\",\"success\":\"true\"}}]}";
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
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
            //var jsonRequest = base.MockFileToString("Mocks/Notification/capture-false.json");
            var jsonRequest = "{\"live\":\"false\",\"notificationItems\":[{\"NotificationRequestItem\":{\"additionalData\":{\"hmacSignature\":\"KujHNqpyCAMdGefj7lfQ8AeD0Jke9Zs2bVAqScQDWi4=\"},\"amount\":{\"currency\":\"USD\",\"value\":23623},\"eventCode\":\"CAPTURE\",\"eventDate\":\"2017-01-25T18:08:19+01:00\",\"merchantAccountCode\":\"MagentoMerchantTest2\",\"merchantReference\":\"00000001\",\"originalReference\":\"ORIGINAL_PSP\",\"paymentMethod\":\"visa\",\"pspReference\":\"PSP_REFERENCE\",\"reason\":\"Insufficient balance on payment\",\"success\":\"false\"}}]}";
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
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
            //var jsonRequest = base.MockFileToString("Mocks/Notification/refund-true.json");
            var jsonRequest = "{\"live\":\"false\",\"notificationItems\":[{\"NotificationRequestItem\":{\"additionalData\":{\"hmacSignature\":\"KJFhURWP8Pv9m8k+7NGHNJAupBj6X6J/VWAikFxeWhA=\"},\"amount\":{\"currency\":\"EUR\",\"value\":1500},\"eventCode\":\"REFUND\",\"eventDate\":\"2017-02-17T11:11:44+01:00\",\"merchantAccountCode\":\"MagentoMerchantTest2\",\"merchantReference\":\"payment-2017-1-17-11-refund\",\"originalReference\":\"ORIGINAL_PSP\",\"paymentMethod\":\"visa\",\"pspReference\":\"PSP_REFERENCE\",\"reason\":\"\",\"success\":\"true\"}}]}";
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
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
            //var jsonRequest = base.MockFileToString("Mocks/Notification/refund-false.json");
            var jsonRequest = "{\"live\":\"false\",\"notificationItems\":[{\"NotificationRequestItem\":{\"additionalData\":{\"hmacSignature\":\"HZXziBYopfDIzDhk49iC//yCfxmy/z0xWuvvTxFNUSA=\"},\"amount\":{\"currency\":\"EUR\",\"value\":1500},\"eventCode\":\"REFUND\",\"eventDate\":\"2017-02-17T11:04:07+01:00\",\"merchantAccountCode\":\"MagentoMerchantTest2\",\"merchantReference\":\"payment-2017-1-17-11-refund\",\"originalReference\":\"ORIGINAL_PSP\",\"paymentMethod\":\"visa\",\"pspReference\":\"PSP_REFERENCE\",\"reason\":\"Insufficient balance on payment\",\"success\":\"false\"}}]}";
            var notificationHandler = new NotificationHandler();
            var handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
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
    }
}

