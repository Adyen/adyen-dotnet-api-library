// using System.Collections.Generic;
// using Adyen.Model.Notification;
// using Adyen.Model.Payment;
// using Adyen.Util;
// using Adyen.Util.TerminalApi;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Newtonsoft.Json;
//
// namespace Adyen.Test
// {
//     [TestClass]
//     public class UtilTest : BaseTest
//     {
//         [TestMethod]
//         public void TestHmac()
//         {
//             var data = "countryCode:currencyCode:merchantAccount:merchantReference:paymentAmount:sessionValidity:skinCode:NL:EUR:MagentoMerchantTest2:TEST-PAYMENT-2017-02-01-14\\:02\\:05:199:2017-02-02T14\\:02\\:05+01\\:00:PKz2KML1";
//             var hmacKey = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
//             var hmacValidator = new HmacValidator();
//             var hmacSignature = hmacValidator.CalculateHmac(data, hmacKey);
//             Assert.IsTrue(string.Equals(hmacSignature, "34oR8T1whkQWTv9P+SzKyp8zhusf9n0dpqrm9nsqSJs="));
//         }
//
//         [TestMethod]
//         public void TestBalancePlatformHmac()
//         {
//             var notification =
//                 "{\"data\":{\"balancePlatform\":\"Integration_tools_test\",\"accountId\":\"BA32272223222H5HVKTBK4MLB\",\"sweep\":{\"id\":\"SWPC42272223222H5HVKV6H8C64DP5\",\"schedule\":{\"type\":\"balance\"},\"status\":\"active\",\"targetAmount\":{\"currency\":\"EUR\",\"value\":0},\"triggerAmount\":{\"currency\":\"EUR\",\"value\":0},\"type\":\"pull\",\"counterparty\":{\"balanceAccountId\":\"BA3227C223222H5HVKT3H9WLC\"},\"currency\":\"EUR\"}},\"environment\":\"test\",\"type\":\"balancePlatform.balanceAccountSweep.updated\"}";
//             var hmacKey = "D7DD5BA6146493707BF0BE7496F6404EC7A63616B7158EC927B9F54BB436765F";
//             var hmacSignature = "9Qz9S/0xpar1klkniKdshxpAhRKbiSAewPpWoxKefQA=";
//             var hmacValidator = new HmacValidator();
//             bool response = hmacValidator.IsValidWebhook(hmacSignature, hmacKey, notification);
//             Assert.IsTrue(response); 
//         }
//
//         [TestMethod]
//         public void TestSerializationShopperInteractionDefaultIsZero()
//         {
//             var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(default);
//             var serializedPaymentRequest = paymentRequest.ToJson();
//             Assert.IsTrue(serializedPaymentRequest.Contains("\"shopperInteraction\": 0,"));
//         }
//         
//         [TestMethod]
//         public void TestNotificationRequestItemHmac()
//         {
//             var hmacKey = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
//             var expectedSign = "ipnxGCaUZ4l8TUW75a71/ghd2Fe5ffvX0pV4TLTntIc=";
//             var additionalData = new Dictionary<string, string>
//             {
//                 { "hmacSignature", expectedSign }
//             };
//             var notificationRequestItem = new NotificationRequestItem
//             {
//                 PspReference = "pspReference",
//                 OriginalReference = "originalReference",
//                 MerchantAccountCode = "merchantAccount",
//                 MerchantReference = "reference",
//                 Amount = new Model.Checkout.Amount("EUR", 1000),
//                 EventCode = "EVENT",
//                 Success = true,
//                 AdditionalData = additionalData
//             };
//             var hmacValidator = new HmacValidator();
//             var data = hmacValidator.GetDataToSign(notificationRequestItem);
//             Assert.AreEqual("pspReference:originalReference:merchantAccount:reference:1000:EUR:EVENT:true", data);
//             var encrypted = hmacValidator.CalculateHmac(notificationRequestItem, hmacKey);
//             Assert.AreEqual(expectedSign, encrypted);
//             Assert.IsTrue(hmacValidator.IsValidHmac(notificationRequestItem, hmacKey));
//             notificationRequestItem.AdditionalData["hmacSignature"] = "notValidSign";
//             Assert.IsFalse(hmacValidator.IsValidHmac(notificationRequestItem, hmacKey));
//         }
//         
//         [TestMethod]
//         public void TestHmacCalculationNotificationRequestWithSpecialChars()
//         {
//             string hmacKey = "66B61474A0AA3736BA8789EDC6D6CD9EBA0C4F414A554E32A407F849C045C69D";
//             var mockPath = GetMockFilePath("mocks/notification-response-refund-fail.json");
//             var response = MockFileToString(mockPath);
//             var hmacValidator = new HmacValidator();
//             var notificationRequest = JsonOperation.Deserialize<NotificationRequest>(response);
//             var notificationItem = notificationRequest.NotificationItemContainers[0].NotificationItem;
//             var isValidHmac = hmacValidator.IsValidHmac(notificationItem, hmacKey);
//             Assert.IsTrue(isValidHmac);
//         }
//
//         [TestMethod]
//         public void TestSerializationShopperInteractionMoto()
//         {
//             var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(PaymentRequest.ShopperInteractionEnum.Moto);
//             var serializedPaymentRequest = JsonOperation.SerializeRequest(paymentRequest);
//             StringAssert.Contains(serializedPaymentRequest, nameof(PaymentRequest.ShopperInteractionEnum.Moto));
//         }
//
//         [TestMethod]
//         public void TestNullHmacValidator()
//         {
//             var hmacValidator = new HmacValidator();
//             var notificationRequestItem = new NotificationRequestItem
//             {
//                 PspReference = "pspReference",
//                 OriginalReference = "originalReference",
//                 MerchantAccountCode = "merchantAccount",
//                 MerchantReference = "reference",
//                 Amount = new Model.Checkout.Amount("EUR", 1000),
//                 EventCode = "EVENT",
//                 Success = true,
//                 AdditionalData = null
//             };
//             var isValidHmacAdditionalDataNull = hmacValidator.IsValidHmac(notificationRequestItem, "hmacKey");
//             Assert.IsFalse(isValidHmacAdditionalDataNull);
//             notificationRequestItem.AdditionalData = new Dictionary<string, string>();
//             var isValidHmacAdditionalDataEmpty = hmacValidator.IsValidHmac(notificationRequestItem, "hmacKey");
//             Assert.IsFalse(isValidHmacAdditionalDataEmpty);
//         }
//         
//         [TestMethod]
//         public void TestColonAndBackslashHmacValidator()
//         {
//             var hmacValidator = new HmacValidator();
//             var jsonNotification = @"{
//               'additionalData': {
//                         'acquirerCode': 'TestPmmAcquirer',
//                         'acquirerReference': 'J8DXDJ2PV6P',
//                         'authCode': '052095',
//                         'avsResult': '5 No AVS data provided',
//                         'avsResultRaw': '5',
//                         'cardSummary': '1111',
//                         'checkout.cardAddedBrand': 'visa',
//                         'cvcResult': '1 Matches',
//                         'cvcResultRaw': 'M',
//                         'expiryDate': '03/2030',
//                         'hmacSignature': 'CZErGCNQaSsxbaQfZaJlakqo7KPP+mIa8a+wx3yNs9A=',
//                         'paymentMethod': 'visa',
//                         'refusalReasonRaw': 'AUTHORISED',
//                         'retry.attempt1.acquirer': 'TestPmmAcquirer',
//                         'retry.attempt1.acquirerAccount': 'TestPmmAcquirerAccount',
//                         'retry.attempt1.avsResultRaw': '5',
//                         'retry.attempt1.rawResponse': 'AUTHORISED',
//                         'retry.attempt1.responseCode': 'Approved',
//                         'retry.attempt1.scaExemptionRequested': 'lowValue',
//                         'scaExemptionRequested': 'lowValue'
//                     },
//                     'amount': {
//                         'currency': 'EUR',
//                         'value': 1000
//                     },
//                 'eventCode': 'AUTHORISATION',
//                 'eventDate': '2023-01-10T13:42:29+01:00',
//                 'merchantAccountCode': 'AntoniStroinski',
//                 'merchantReference': '\\:/\\/slashes are fun',
//                 'operations': [
//                 'CANCEL',
//                 'CAPTURE',
//                 'REFUND'
//                     ],
//                 'paymentMethod': 'visa',
//                 'pspReference': 'ZVWN7D3WSMK2WN82',
//                 'reason': '052095:1111:03/2030',
//                 'success': 'true'
//             }";
//             var notificationRequestItem = JsonConvert.DeserializeObject<NotificationRequestItem>(jsonNotification);
//             var isValidHmac = hmacValidator.IsValidHmac(notificationRequestItem, "74F490DD33F7327BAECC88B2947C011FC02D014A473AAA33A8EC93E4DC069174");
//             Assert.IsTrue(isValidHmac);
//         }
//
//         [TestMethod]
//         public void TestCardAcquisitionAdditionalResponse()
//         {
//             string jsonString = @"{
//             ""additionalData"": {
//                 ""PaymentAccountReference"": ""Yv6zs1234567890ASDFGHJKL"",
//                 ""alias"": ""G12345678"",
//                 ""aliasType"": ""Default"",
//                 ""applicationLabel"": ""ASDFGHJKL"",
//                 ""applicationPreferredName"": ""ASDFGHJKL"",
//                 ""backendGiftcardIndicator"": ""false"",
//                 ""cardBin"": ""4111111"",
//                 ""cardHolderName"": ""John Smith""
//             },
//             ""message"": ""CARD_ACQ_COMPLETED"",
//             ""store"": ""NL""
//          }";
//             string responseBased64 = "ewoiYWRkaXRpb25hbERhdGEiOnsKICJQYXltZW50QWNjb3VudFJlZmVyZW5jZSI6Ill2NnpzMTIzNDU2Nzg5MEFTREZHSEpLTCIsCiJhbGlhcyI6IkcxMjM0NTY3OCIsCiJhbGlhc1R5cGUiOiJEZWZhdWx0IiwKImFwcGxpY2F0aW9uTGFiZWwiOiJBU0RGR0hKS0wiLAoiYXBwbGljYXRpb25QcmVmZXJyZWROYW1lIjoiQVNERkdISktMIiwKICJiYWNrZW5kR2lmdGNhcmRJbmRpY2F0b3IiOiJmYWxzZSIsCiJjYXJkQmluIjoiNDExMTExMSIsCiJjYXJkSG9sZGVyTmFtZSI6IkpvaG4gU21pdGgiCgp9LAoibWVzc2FnZSI6IkNBUkRfQUNRX0NPTVBMRVRFRCIsCiJzdG9yZSI6Ik5MIgp9";
//             var additionalResponse = CardAcquisitionUtil.AdditionalResponse(responseBased64);
//             Assert.AreEqual(additionalResponse.Message,"CARD_ACQ_COMPLETED");
//             Assert.AreEqual(additionalResponse.Store,"NL");
//             Assert.AreEqual(additionalResponse.AdditionalData["PaymentAccountReference"],"Yv6zs1234567890ASDFGHJKL");
//             Assert.AreEqual(additionalResponse.AdditionalData["alias"],"G12345678");
//             Assert.AreEqual(additionalResponse.AdditionalData["aliasType"],"Default");
//             Assert.AreEqual(additionalResponse.AdditionalData["applicationLabel"],"ASDFGHJKL");
//             Assert.AreEqual(additionalResponse.AdditionalData["applicationPreferredName"],"ASDFGHJKL");
//             Assert.AreEqual(additionalResponse.AdditionalData["backendGiftcardIndicator"],"false");
//             Assert.AreEqual(additionalResponse.AdditionalData["cardHolderName"],"John Smith");
//             Assert.AreEqual(additionalResponse.AdditionalData["cardBin"],"4111111");
//             
//             var additionalResponseFromJson = CardAcquisitionUtil.AdditionalResponse(jsonString);
//             Assert.AreEqual(additionalResponseFromJson.Message,"CARD_ACQ_COMPLETED");
//             Assert.AreEqual(additionalResponseFromJson.Store,"NL");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["PaymentAccountReference"],"Yv6zs1234567890ASDFGHJKL");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["alias"],"G12345678");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["aliasType"],"Default");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["applicationLabel"],"ASDFGHJKL");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["applicationPreferredName"],"ASDFGHJKL");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["backendGiftcardIndicator"],"false");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["cardHolderName"],"John Smith");
//             Assert.AreEqual(additionalResponseFromJson.AdditionalData["cardBin"],"4111111");
//             
//         }
//         
//     }
// }
