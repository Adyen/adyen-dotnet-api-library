using Adyen.Util;
using Adyen.Webhooks;
using Adyen.Webhooks.Models;
using Adyen.Util.TerminalApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test.Webhooks
{
    [TestClass]
    public class HmacValidatorTest : BaseTest
    {
        [TestMethod]
        public void TestHmac()
        {
            string data = "countryCode:currencyCode:merchantAccount:merchantReference:paymentAmount:sessionValidity:skinCode:NL:EUR:MagentoMerchantTest2:TEST-PAYMENT-2017-02-01-14\\:02\\:05:199:2017-02-02T14\\:02\\:05+01\\:00:PKz2KML1";
            string hmacKey = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            var hmacValidator = new HmacValidator();
            string hmacSignature = hmacValidator.CalculateHmac(data, hmacKey);
            Assert.IsTrue(string.Equals(hmacSignature, "34oR8T1whkQWTv9P+SzKyp8zhusf9n0dpqrm9nsqSJs="));
        }
        
        [TestMethod]
        public void TestNotificationRequestItemHmac()
        {
            string hmacKey = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            string expectedSign = "ipnxGCaUZ4l8TUW75a71/ghd2Fe5ffvX0pV4TLTntIc=";
            var additionalData = new Dictionary<string, string>
            {
                { "hmacSignature", expectedSign }
            };
            var notificationRequestItem = new NotificationRequestItem
            {
                PspReference = "pspReference",
                OriginalReference = "originalReference",
                MerchantAccountCode = "merchantAccount",
                MerchantReference = "reference",
                Amount = new Amount("EUR", 1000),
                EventCode = "EVENT",
                Success = true,
                AdditionalData = additionalData
            };
            var hmacValidator = new HmacValidator();
            string data = hmacValidator.GetDataToSign(notificationRequestItem);
            Assert.AreEqual("pspReference:originalReference:merchantAccount:reference:1000:EUR:EVENT:true", data);
            string encrypted = hmacValidator.CalculateHmac(notificationRequestItem, hmacKey);
            Assert.AreEqual(expectedSign, encrypted);
            Assert.IsTrue(hmacValidator.IsValidHmac(notificationRequestItem, hmacKey));
            notificationRequestItem.AdditionalData["hmacSignature"] = "notValidSign";
            Assert.IsFalse(hmacValidator.IsValidHmac(notificationRequestItem, hmacKey));
        }
        
        [TestMethod]
        public void TestHmacCalculationNotificationRequestWithSpecialChars()
        {
            string hmacKey = "66B61474A0AA3736BA8789EDC6D6CD9EBA0C4F414A554E32A407F849C045C69D";
            string mockPath = GetMockFilePath("mocks/notification-response-refund-fail.json");
            string response = MockFileToString(mockPath);
            var hmacValidator = new HmacValidator();
            NotificationRequest notificationRequest = JsonConvert.DeserializeObject<NotificationRequest>(response);
            NotificationRequestItem notificationItem = notificationRequest.NotificationItemContainers[0].NotificationItem;
            bool isValidHmac = hmacValidator.IsValidHmac(notificationItem, hmacKey);
            Assert.IsTrue(isValidHmac);
        }
        
        [TestMethod]
        public void TestNullHmacValidator()
        {
            var hmacValidator = new HmacValidator();
            var notificationRequestItem = new NotificationRequestItem
            {
                PspReference = "pspReference",
                OriginalReference = "originalReference",
                MerchantAccountCode = "merchantAccount",
                MerchantReference = "reference",
                Amount = new Amount("EUR", 1000),
                EventCode = "EVENT",
                Success = true,
                AdditionalData = null
            };
            bool isValidHmacAdditionalDataNull = hmacValidator.IsValidHmac(notificationRequestItem, "hmacKey");
            Assert.IsFalse(isValidHmacAdditionalDataNull);
            notificationRequestItem.AdditionalData = new Dictionary<string, string>();
            bool isValidHmacAdditionalDataEmpty = hmacValidator.IsValidHmac(notificationRequestItem, "hmacKey");
            Assert.IsFalse(isValidHmacAdditionalDataEmpty);
        }
        
        [TestMethod]
        public void TestColonAndBackslashHmacValidator()
        {
            var hmacValidator = new HmacValidator();
            string jsonNotification = @"{
              'additionalData': {
                        'acquirerCode': 'TestPmmAcquirer',
                        'acquirerReference': 'J8DXDJ2PV6P',
                        'authCode': '052095',
                        'avsResult': '5 No AVS data provided',
                        'avsResultRaw': '5',
                        'cardSummary': '1111',
                        'checkout.cardAddedBrand': 'visa',
                        'cvcResult': '1 Matches',
                        'cvcResultRaw': 'M',
                        'expiryDate': '03/2030',
                        'hmacSignature': 'CZErGCNQaSsxbaQfZaJlakqo7KPP+mIa8a+wx3yNs9A=',
                        'paymentMethod': 'visa',
                        'refusalReasonRaw': 'AUTHORISED',
                        'retry.attempt1.acquirer': 'TestPmmAcquirer',
                        'retry.attempt1.acquirerAccount': 'TestPmmAcquirerAccount',
                        'retry.attempt1.avsResultRaw': '5',
                        'retry.attempt1.rawResponse': 'AUTHORISED',
                        'retry.attempt1.responseCode': 'Approved',
                        'retry.attempt1.scaExemptionRequested': 'lowValue',
                        'scaExemptionRequested': 'lowValue'
                    },
                    'amount': {
                        'currency': 'EUR',
                        'value': 1000
                    },
                'eventCode': 'AUTHORISATION',
                'eventDate': '2023-01-10T13:42:29+01:00',
                'merchantAccountCode': 'AntoniStroinski',
                'merchantReference': '\\:/\\/slashes are fun',
                'operations': [
                'CANCEL',
                'CAPTURE',
                'REFUND'
                    ],
                'paymentMethod': 'visa',
                'pspReference': 'ZVWN7D3WSMK2WN82',
                'reason': '052095:1111:03/2030',
                'success': 'true'
            }";
            NotificationRequestItem notificationRequestItem = JsonConvert.DeserializeObject<NotificationRequestItem>(jsonNotification);
            bool isValidHmac = hmacValidator.IsValidHmac(notificationRequestItem, "74F490DD33F7327BAECC88B2947C011FC02D014A473AAA33A8EC93E4DC069174");
            Assert.IsTrue(isValidHmac);
        }

        [TestMethod]
        public void TestCardAcquisitionAdditionalResponse()
        {
            string jsonString = @"{
            ""additionalData"": {
                ""PaymentAccountReference"": ""Yv6zs1234567890ASDFGHJKL"",
                ""alias"": ""G12345678"",
                ""aliasType"": ""Default"",
                ""applicationLabel"": ""ASDFGHJKL"",
                ""applicationPreferredName"": ""ASDFGHJKL"",
                ""backendGiftcardIndicator"": ""false"",
                ""cardBin"": ""4111111"",
                ""cardHolderName"": ""John Smith""
            },
            ""message"": ""CARD_ACQ_COMPLETED"",
            ""store"": ""NL""
         }";
            string responseBased64 = "ewoiYWRkaXRpb25hbERhdGEiOnsKICJQYXltZW50QWNjb3VudFJlZmVyZW5jZSI6Ill2NnpzMTIzNDU2Nzg5MEFTREZHSEpLTCIsCiJhbGlhcyI6IkcxMjM0NTY3OCIsCiJhbGlhc1R5cGUiOiJEZWZhdWx0IiwKImFwcGxpY2F0aW9uTGFiZWwiOiJBU0RGR0hKS0wiLAoiYXBwbGljYXRpb25QcmVmZXJyZWROYW1lIjoiQVNERkdISktMIiwKICJiYWNrZW5kR2lmdGNhcmRJbmRpY2F0b3IiOiJmYWxzZSIsCiJjYXJkQmluIjoiNDExMTExMSIsCiJjYXJkSG9sZGVyTmFtZSI6IkpvaG4gU21pdGgiCgp9LAoibWVzc2FnZSI6IkNBUkRfQUNRX0NPTVBMRVRFRCIsCiJzdG9yZSI6Ik5MIgp9";
            AdditionalResponse additionalResponse = CardAcquisitionUtil.AdditionalResponse(responseBased64);
            Assert.AreEqual(additionalResponse.Message,"CARD_ACQ_COMPLETED");
            Assert.AreEqual(additionalResponse.Store,"NL");
            Assert.AreEqual(additionalResponse.AdditionalData["PaymentAccountReference"],"Yv6zs1234567890ASDFGHJKL");
            Assert.AreEqual(additionalResponse.AdditionalData["alias"],"G12345678");
            Assert.AreEqual(additionalResponse.AdditionalData["aliasType"],"Default");
            Assert.AreEqual(additionalResponse.AdditionalData["applicationLabel"],"ASDFGHJKL");
            Assert.AreEqual(additionalResponse.AdditionalData["applicationPreferredName"],"ASDFGHJKL");
            Assert.AreEqual(additionalResponse.AdditionalData["backendGiftcardIndicator"],"false");
            Assert.AreEqual(additionalResponse.AdditionalData["cardHolderName"],"John Smith");
            Assert.AreEqual(additionalResponse.AdditionalData["cardBin"],"4111111");
            
            AdditionalResponse additionalResponseFromJson = CardAcquisitionUtil.AdditionalResponse(jsonString);
            Assert.AreEqual(additionalResponseFromJson.Message,"CARD_ACQ_COMPLETED");
            Assert.AreEqual(additionalResponseFromJson.Store,"NL");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["PaymentAccountReference"],"Yv6zs1234567890ASDFGHJKL");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["alias"],"G12345678");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["aliasType"],"Default");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["applicationLabel"],"ASDFGHJKL");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["applicationPreferredName"],"ASDFGHJKL");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["backendGiftcardIndicator"],"false");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["cardHolderName"],"John Smith");
            Assert.AreEqual(additionalResponseFromJson.AdditionalData["cardBin"],"4111111");
        }
    }
}
