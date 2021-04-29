#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using Adyen.Model.MarketPay.Notification;
using Adyen.Notification;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Test.MarketPay
{
    [TestClass]
    public class MarketPayNotificationTest : BaseTest
    {
        [TestMethod]
        public void MarketPayAccountClosedNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-closed-test.json");
            NotificationHandler notificationHandler = new NotificationHandler();
            IGenericNotification notificationMessage = notificationHandler.HandleMarketpayNotificationJson(json);
            AccountCloseNotification accountCloseNotification = (AccountCloseNotification)notificationMessage;
            Assert.AreEqual(accountCloseNotification.EventType, "ACCOUNT_CLOSED");
            Assert.AreEqual(accountCloseNotification.PspReference, "TSTPSPR0001");
            Assert.AreEqual(accountCloseNotification.Content.ResultCode, "Success");
        }


    }


    //@Test
    //public void testMarketPayAccountClosedNotification()
    //{
    //    String json = getFileContents("mocks/marketpay/notification/account-closed-test.json");
    //    NotificationHandler notificationHandler = new NotificationHandler();

    //    GenericNotification notificationMessage = notificationHandler.handleMarketpayNotificationJson(json);

    //    assertEquals(GenericNotification.EventTypeEnum.ACCOUNT_CLOSED, notificationMessage.getEventType());
    //    AccountCloseNotification notification = (AccountCloseNotification)notificationMessage;
    //    assertNotNull(notification.getContent());
    //    assertEquals(1, notification.getContent().getInvalidFields().size());
    //}
}
