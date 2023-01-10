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

using Adyen.Model.Notification;

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
            string mockPath = GetMockFilePath("Mocks/notification/authorisation-true.json");
            string jsonRequest = MockFileToString(mockPath);
            NotificationHandler notificationHandler = new NotificationHandler();
            NotificationRequest handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            NotificationRequestItemContainer notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            NotificationRequestItem notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("AUTHORISATION", notificationItem.EventCode);
            Assert.AreEqual("1234", notificationItem.AdditionalData["authCode"]);
            Assert.AreEqual("123456789", notificationItem.PspReference);
        }

        [TestMethod]
        public void TestCaptureSuccess()
        {
            string mockPath = GetMockFilePath("Mocks/notification/capture-true.json");
            string jsonRequest = MockFileToString(mockPath);
            NotificationHandler notificationHandler = new NotificationHandler();
            NotificationRequest handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            NotificationRequestItemContainer notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            NotificationRequestItem notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("CAPTURE", notificationItem.EventCode);
            Assert.AreEqual("qvS6I3Gdi1jx+jSh7IopAgcHtMoxvXlNL7DYQ+j1hd0=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(23623, notificationItem.Amount.Value);
            Assert.IsTrue(notificationItem.Success);
        }

        [TestMethod]
        public void TestCaptureFail()
        {
            string mockPath = GetMockFilePath("Mocks/notification/capture-false.json");
            string jsonRequest = MockFileToString(mockPath);
            NotificationHandler notificationHandler = new NotificationHandler();
            NotificationRequest handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            NotificationRequestItemContainer notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            NotificationRequestItem notificationItem = notificationRequestItemContainer.NotificationItem;
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
            string mockPath = GetMockFilePath("Mocks/notification/refund-true.json");
            string jsonRequest = MockFileToString(mockPath);
            NotificationHandler notificationHandler = new NotificationHandler();
            NotificationRequest handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            NotificationRequestItemContainer notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            NotificationRequestItem notificationItem = notificationRequestItemContainer.NotificationItem;
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
            string mockPath = GetMockFilePath("Mocks/notification/refund-false.json");
            string jsonRequest = MockFileToString(mockPath);
            NotificationHandler notificationHandler = new NotificationHandler();
            NotificationRequest handleNotificationRequest = notificationHandler.HandleNotificationRequest(jsonRequest);
            NotificationRequestItemContainer notificationRequestItemContainer = handleNotificationRequest.NotificationItemContainers.FirstOrDefault();
            if (notificationRequestItemContainer == null)
                Assert.Fail("NotificationRequestItemContainer is null");
            NotificationRequestItem notificationItem = notificationRequestItemContainer.NotificationItem;
            Assert.AreEqual("REFUND", notificationItem.EventCode);
            Assert.AreEqual("HZXziBYopfDIzDhk49iC//yCfxmy/z0xWuvvTxFNUSA=", notificationItem.AdditionalData["hmacSignature"]);
            Assert.AreEqual("PSP_REFERENCE", notificationItem.PspReference);
            Assert.AreEqual(1500, notificationItem.Amount.Value);
            Assert.IsFalse(notificationItem.Success);
            Assert.AreEqual("Insufficient balance on payment", notificationItem.Reason);
        }
    }
}

