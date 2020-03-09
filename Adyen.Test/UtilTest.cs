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
using Adyen.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.Test
{
    [TestClass]
    public class UtilTest : BaseTest
    {
        [TestMethod]
        public void TestDataSign()
        {
            var postParameters = new Dictionary<string, string>
            {
                {Constants.HPPConstants.Fields.MerchantAccount, "ACC"},
                {Constants.HPPConstants.Fields.CurrencyCode, "EUR"}
            };
            var hmacValidator = new HmacValidator();
            var buildSigningString = hmacValidator.BuildSigningString(postParameters);
            Assert.IsTrue(string.Equals("currencyCode:merchantAccount:EUR:ACC", buildSigningString));
            postParameters = new Dictionary<string, string>
            {
                {Constants.HPPConstants.Fields.CurrencyCode, "EUR"},
                {Constants.HPPConstants.Fields.MerchantAccount, "ACC:\\"}
            };

            buildSigningString = hmacValidator.BuildSigningString(postParameters);
            Assert.IsTrue(string.Equals("currencyCode:merchantAccount:EUR:ACC\\:\\\\", buildSigningString));
        }
        
        [TestMethod]
        public void TestHmac()
        {
            var data = "countryCode:currencyCode:merchantAccount:merchantReference:paymentAmount:sessionValidity:skinCode:NL:EUR:MagentoMerchantTest2:TEST-PAYMENT-2017-02-01-14\\:02\\:05:199:2017-02-02T14\\:02\\:05+01\\:00:PKz2KML1";
            var key = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            var hmacValidator = new HmacValidator();
            var ecnrypted = hmacValidator.CalculateHmac(data, key);
            Assert.IsTrue(string.Equals(ecnrypted, "34oR8T1whkQWTv9P+SzKyp8zhusf9n0dpqrm9nsqSJs="));
        }

        [TestMethod]
        public void TestSerializationShopperInteractionDefault()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(default(Model.Enum.ShopperInteraction));
            var serializedPaymentRequest = JsonOperation.SerializeRequest(paymentRequest);
            Assert.IsFalse(serializedPaymentRequest.Contains("shopperInteraction"));
        }
        
        [TestMethod]
        public void TestNotificationRequestItemHmac()
        {
            string key = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            var expectedSign = "ipnxGCaUZ4l8TUW75a71/ghd2Fe5ffvX0pV4TLTntIc=";
            var additionalData = new Dictionary<string, string>
            {
                { Constants.AdditionalData.HmacSignature, expectedSign }
            };
            var notificationRequestItem = new NotificationRequestItem
            {
                PspReference = "pspReference",
                OriginalReference = "originalReference",
                MerchantAccountCode = "merchantAccount",
                MerchantReference = "reference",
                Amount = new Model.Amount("EUR", 1000),
                EventCode = "EVENT",
                Success = true,
                AdditionalData = additionalData
            };
            var hmacValidator = new HmacValidator();
            var data = hmacValidator.GetDataToSign(notificationRequestItem);
            Assert.AreEqual("pspReference:originalReference:merchantAccount:reference:1000:EUR:EVENT:true", data);
            var encrypted = hmacValidator.CalculateHmac(notificationRequestItem, key);
            Assert.AreEqual(expectedSign, encrypted);
            notificationRequestItem.AdditionalData[Constants.AdditionalData.HmacSignature] = expectedSign;
            Assert.IsTrue(hmacValidator.IsValidHmac(notificationRequestItem, key));
            notificationRequestItem.AdditionalData[Constants.AdditionalData.HmacSignature] = "notValidSign";
            Assert.IsFalse(hmacValidator.IsValidHmac(notificationRequestItem, key));
        }
        
        [TestMethod]
        public void TestHmacCalculationNotificationRequestWithSpecialChars()
        {
            string key = "66B61474A0AA3736BA8789EDC6D6CD9EBA0C4F414A554E32A407F849C045C69D";
            var mockPath = GetMockFilePath("Mocks/notification-response-refund-fail.json");
            var response = MockFileToString(mockPath);
            var hmacValidator = new HmacValidator();
            var notificationRequest = JsonOperation.Deserialize<NotificationRequest>(response);
            var notificationItem = notificationRequest.NotificationItemContainers[0].NotificationItem;
            var isValidHmac = hmacValidator.IsValidHmac(notificationItem, key);
            Assert.IsTrue(isValidHmac);
        }

        [TestMethod]
        public void TestSerializationShopperInteractionMoto()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(Model.Enum.ShopperInteraction.Moto);
            var serializedPaymentRequest = JsonOperation.SerializeRequest(paymentRequest);
            StringAssert.Contains(serializedPaymentRequest, nameof(Model.Enum.ShopperInteraction.Moto));
        }
    }
}
