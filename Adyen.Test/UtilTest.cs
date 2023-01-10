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
using Adyen.Model.Notification;
using Adyen.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using Adyen.Model.MarketPay;
using Adyen.Model.Payments;
using Account = Adyen.Service.Account;

namespace Adyen.Test
{
    [TestClass]
    public class UtilTest : BaseTest
    {
        [TestMethod]
        public void TestDataSign()
        {
            Dictionary<string, string> postParameters = new Dictionary<string, string>
            {
                {Constants.HPPConstants.Fields.MerchantAccount, "ACC"},
                {Constants.HPPConstants.Fields.CurrencyCode, "EUR"}
            };
            HmacValidator hmacValidator = new HmacValidator();
            string buildSigningString = hmacValidator.BuildSigningString(postParameters);
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
            string data = "countryCode:currencyCode:merchantAccount:merchantReference:paymentAmount:sessionValidity:skinCode:NL:EUR:MagentoMerchantTest2:TEST-PAYMENT-2017-02-01-14\\:02\\:05:199:2017-02-02T14\\:02\\:05+01\\:00:PKz2KML1";
            string key = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            HmacValidator hmacValidator = new HmacValidator();
            string ecnrypted = hmacValidator.CalculateHmac(data, key);
            Assert.IsTrue(string.Equals(ecnrypted, "34oR8T1whkQWTv9P+SzKyp8zhusf9n0dpqrm9nsqSJs="));
        }

        [TestMethod]
        public void TestSerializationShopperInteractionDefaultIsZero()
        {
            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(default);
            string serializedPaymentRequest = paymentRequest.ToJson();
            Assert.IsTrue(serializedPaymentRequest.Contains("\"shopperInteraction\": 0,"));
        }
        
        [TestMethod]
        public void TestNotificationRequestItemHmac()
        {
            string key = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            string expectedSign = "ipnxGCaUZ4l8TUW75a71/ghd2Fe5ffvX0pV4TLTntIc=";
            Dictionary<string, string> additionalData = new Dictionary<string, string>
            {
                { Constants.AdditionalData.HmacSignature, expectedSign }
            };
            NotificationRequestItem notificationRequestItem = new NotificationRequestItem
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
            HmacValidator hmacValidator = new HmacValidator();
            string data = hmacValidator.GetDataToSign(notificationRequestItem);
            Assert.AreEqual("pspReference:originalReference:merchantAccount:reference:1000:EUR:EVENT:true", data);
            string encrypted = hmacValidator.CalculateHmac(notificationRequestItem, key);
            Assert.AreEqual(expectedSign, encrypted);
            Assert.IsTrue(hmacValidator.IsValidHmac(notificationRequestItem, key));
            notificationRequestItem.AdditionalData[Constants.AdditionalData.HmacSignature] = "notValidSign";
            Assert.IsFalse(hmacValidator.IsValidHmac(notificationRequestItem, key));
        }
        
        [TestMethod]
        public void TestHmacCalculationNotificationRequestWithSpecialChars()
        {
            string key = "66B61474A0AA3736BA8789EDC6D6CD9EBA0C4F414A554E32A407F849C045C69D";
            string mockPath = GetMockFilePath("Mocks/notification-response-refund-fail.json");
            string response = MockFileToString(mockPath);
            HmacValidator hmacValidator = new HmacValidator();
            NotificationRequest notificationRequest = JsonOperation.Deserialize<NotificationRequest>(response);
            NotificationRequestItem notificationItem = notificationRequest.NotificationItemContainers[0].NotificationItem;
            bool isValidHmac = hmacValidator.IsValidHmac(notificationItem, key);
            Assert.IsTrue(isValidHmac);
        }

        [TestMethod]
        public void TestSerializationShopperInteractionMoto()
        {
            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(PaymentRequest.ShopperInteractionEnum.Moto);
            string serializedPaymentRequest = JsonOperation.SerializeRequest(paymentRequest);
            StringAssert.Contains(serializedPaymentRequest, nameof(PaymentRequest.ShopperInteractionEnum.Moto));
        }

        [TestMethod]
        public void TestNullHmacValidator()
        {
            HmacValidator hmacValidator = new HmacValidator();
            NotificationRequestItem notificationRequestItem = new NotificationRequestItem
            {
                PspReference = "pspReference",
                OriginalReference = "originalReference",
                MerchantAccountCode = "merchantAccount",
                MerchantReference = "reference",
                Amount = new Model.Amount("EUR", 1000),
                EventCode = "EVENT",
                Success = true,
                AdditionalData = null
            };
            bool isValidHmacAdditionalDataNull = hmacValidator.IsValidHmac(notificationRequestItem, "key");
            Assert.IsFalse(isValidHmacAdditionalDataNull);
            notificationRequestItem.AdditionalData = new Dictionary<string, string>();
            bool isValidHmacAdditionalDataEmpty = hmacValidator.IsValidHmac(notificationRequestItem, "key");
            Assert.IsFalse(isValidHmacAdditionalDataEmpty);
        }
        
        [TestMethod]
        public void TestByteArrayConverter()
        {
            // Encoding UTF8 characters to assess if they get serialised as UTF8 Characters
            byte[] content = Encoding.UTF8.GetBytes("√√√123456789");
            DocumentDetail detail = new DocumentDetail(accountHolderCode: "123456789", filename: "filename");
            UploadDocumentRequest request =
                new UploadDocumentRequest(documentContent: content, documentDetail: detail);
            
            string jsonstring = JsonOperation.SerializeRequest(request);
            Assert.AreEqual(jsonstring,
                "{\"documentContent\":\"√√√123456789\",\"documentDetail\":{\"accountHolderCode\":\"123456789\",\"filename\":\"filename\"}}");
        }
    }
}
