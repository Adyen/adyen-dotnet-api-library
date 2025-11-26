// using System;
// using System.Text.Json;
// using Adyen.AcsWebhooks.Extensions;
// using Adyen.AcsWebhooks.Handlers;
// using Adyen.ConfigurationWebhooks.Client;
// using Adyen.ConfigurationWebhooks.Handlers;
// using Adyen.Model.AcsWebhooks;
// using Adyen.Model.ConfigurationWebhooks;
// using Adyen.Model.NegativeBalanceWarningWebhooks;
// using Adyen.Model.ReportWebhooks;
// using Adyen.Model.TransactionWebhooks;
// using Adyen.Webhooks;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Newtonsoft.Json;
// using CapabilityProblemEntity = Adyen.Model.ConfigurationWebhooks.CapabilityProblemEntity;
//
// namespace Adyen.Test.ConfigurationWebhooks
// {
//     [TestClass]
//     public class ConfigurationWebhookHandlerTest
//     {
//         private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
//         private readonly IConfigurationWebhooksHandler _configurationWebhooksHandler;
//
//         public ConfigurationWebhookHandlerTest()
//         {
//             IHost host = Host.CreateDefaultBuilder()
//                 .ConfigureAcsWebhooks((context, services, config) =>
//                 {
//                 })
//                 .Build();
//
//             _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
//             _configurationWebhooksHandler = host.Services.GetRequiredService<IConfigurationWebhooksHandler>();
//         }
//         
//
//         [TestMethod]
//
//         public void Test_BalancePlatform_AccountHolderUpdated_LEM_V3()
//         {
//             // Note: We're using double-quotes here as some descriptions in the JSON payload contain single quotes '
//             // Assert
//             const string jsonPayload = @"
// {
//   ""data"": {
//     ""balancePlatform"": ""YOUR_BALANCE_PLATFORM"",
//     ""accountHolder"": {
//       ""legalEntityId"": ""LE00000000000000000001"",
//       ""reference"": ""YOUR_REFERENCE-2412C"",
//       ""capabilities"": {
//         ""sendToTransferInstrument"": {
//           ""enabled"": true,
//           ""requested"": true,
//           ""allowed"": false,
//           ""problems"": [
//             {
//               ""entity"": {
//                 ""id"": ""LE00000000000000000001"",
//                 ""type"": ""LegalEntity""
//               },
//               ""verificationErrors"": [
//                 {
//                   ""code"": ""2_902"",
//                   ""message"": ""Terms Of Service forms are not accepted."",
//                   ""remediatingActions"": [
//                     {
//                       ""code"": ""2_902"",
//                       ""message"": ""Accept TOS""
//                     }
//                   ],
//                   ""type"": ""invalidInput""
//                 }
//               ]
//             },
//             {
//               ""entity"": {
//                 ""id"": ""SE00000000000000000001"",
//                 ""type"": ""BankAccount""
//               },
//               ""verificationErrors"": [
//                 {
//                   ""code"": ""2_8037"",
//                   ""message"": ""'bankStatement' was missing."",
//                   ""remediatingActions"": [
//                     {
//                       ""code"": ""1_703"",
//                       ""message"": ""Upload a bank statement""
//                     }
//                   ],
//                   ""type"": ""dataMissing""
//                 }
//               ]
//             },
//             {
//               ""entity"": {
//                 ""id"": ""SE00000000000000000002"",
//                 ""type"": ""BankAccount""
//               },
//               ""verificationErrors"": [
//                 {
//                   ""code"": ""2_8037"",
//                   ""message"": ""'bankStatement' was missing."",
//                   ""remediatingActions"": [
//                     {
//                       ""code"": ""1_703"",
//                       ""message"": ""Upload a bank statement""
//                     }
//                   ],
//                   ""type"": ""dataMissing""
//                 }
//               ]
//             },
//             {
//               ""entity"": {
//                 ""id"": ""LE00000000000000000001"",
//                 ""type"": ""LegalEntity""
//               },
//               ""verificationErrors"": [
//                 {
//                   ""code"": ""2_8189"",
//                   ""message"": ""'UBO through control' was missing."",
//                   ""remediatingActions"": [
//                     {
//                       ""code"": ""2_151"",
//                       ""message"": ""Add 'organization.entityAssociations' of type 'uboThroughControl' to legal entity""
//                     }
//                   ],
//                   ""type"": ""dataMissing""
//                 },
//                 {
//                   ""code"": ""1_50"",
//                   ""message"": ""Organization details couldn't be verified"",
//                   ""subErrors"": [
//                     {
//                       ""code"": ""1_5016"",
//                       ""message"": ""The tax ID number couldn't be verified"",
//                       ""remediatingActions"": [
//                         {
//                           ""code"": ""1_500"",
//                           ""message"": ""Update organization details""
//                         },
//                         {
//                           ""code"": ""1_501"",
//                           ""message"": ""Upload a registration document""
//                         }
//                       ],
//                       ""type"": ""invalidInput""
//                     }
//                   ],
//                   ""type"": ""invalidInput""
//                 },
//                 {
//                   ""code"": ""2_8067"",
//                   ""message"": ""'Signatory' was missing."",
//                   ""remediatingActions"": [
//                     {
//                       ""code"": ""2_124"",
//                       ""message"": ""Add 'organization.entityAssociations' of type 'signatory' to legal entity""
//                     }
//                   ],
//                   ""type"": ""dataMissing""
//                 }
//               ]
//             }
//           ],
//           ""transferInstruments"": [
//             {
//               ""enabled"": true,
//               ""requested"": true,
//               ""allowed"": false,
//               ""id"": ""SE00000000000000000001"",
//               ""verificationStatus"": ""pending""
//             },
//             {
//               ""enabled"": true,
//               ""requested"": true,
//               ""allowed"": false,
//               ""id"": ""SE00000000000000000002"",
//               ""verificationStatus"": ""pending""
//             }
//           ],
//           ""verificationStatus"": ""pending""
//         }
//       },
//       ""id"": ""AH00000000000000000001"",
//       ""status"": ""active""
//     }
//   },
//   ""environment"": ""live"",
//   ""timestamp"": ""2024-12-15T15:42:03+01:00"",
//   ""type"": ""balancePlatform.accountHolder.updated""
// }";
//
//             _balancePlatformWebhookHandler.GetAccountHolderNotificationRequest(jsonPayload, out AccountHolderNotificationRequest accountHolderUpdatedWebhook);
//
//             Assert.IsNotNull(accountHolderUpdatedWebhook);
//             Assert.AreEqual(accountHolderUpdatedWebhook.Type, AccountHolderNotificationRequest.TypeEnum.Updated);
//             Assert.AreEqual("YOUR_BALANCE_PLATFORM", accountHolderUpdatedWebhook.Data.BalancePlatform);
//             Assert.AreEqual("AH00000000000000000001", accountHolderUpdatedWebhook.Data.AccountHolder.Id);
//             Assert.AreEqual("LE00000000000000000001", accountHolderUpdatedWebhook.Data.AccountHolder.LegalEntityId);
//             Assert.AreEqual("YOUR_REFERENCE-2412C", accountHolderUpdatedWebhook.Data.AccountHolder.Reference);
//             Assert.AreEqual(AccountHolder.StatusEnum.Active, accountHolderUpdatedWebhook.Data.AccountHolder.Status);
//             Assert.IsTrue(accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities.TryGetValue("sendToTransferInstrument", out AccountHolderCapability capabilitiesData));
//             Assert.AreEqual(true, capabilitiesData.Enabled);
//             Assert.AreEqual(true, capabilitiesData.Requested);
//             Assert.AreEqual(false, capabilitiesData.Allowed);
//             Assert.AreEqual(AccountHolderCapability.VerificationStatusEnum.Pending, capabilitiesData.VerificationStatus);
//             Assert.AreEqual(4, accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems.Count);
//             Assert.AreEqual("LE00000000000000000001", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[0].Entity.Id);
//             Assert.AreEqual(CapabilityProblemEntity.TypeEnum.LegalEntity, accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[0].Entity.Type);
//             Assert.AreEqual("2_902", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[0].VerificationErrors[0].Code);
//             Assert.AreEqual("Terms Of Service forms are not accepted.", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[0].VerificationErrors[0].Message);
//             Assert.AreEqual("Accept TOS", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[0].VerificationErrors[0].RemediatingActions[0].Message);
//             Assert.AreEqual("SE00000000000000000001", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[1].Entity.Id);
//             Assert.AreEqual(CapabilityProblemEntity.TypeEnum.BankAccount, accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[1].Entity.Type);
//             Assert.AreEqual("2_8037", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[1].VerificationErrors[0].Code);
//             Assert.AreEqual("'bankStatement' was missing.", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[1].VerificationErrors[0].Message);
//             Assert.AreEqual("Upload a bank statement", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[1].VerificationErrors[0].RemediatingActions[0].Message);
//             Assert.AreEqual("SE00000000000000000002", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[2].Entity.Id);
//             Assert.AreEqual(CapabilityProblemEntity.TypeEnum.BankAccount, accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[2].Entity.Type);
//             Assert.AreEqual("2_8037", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[2].VerificationErrors[0].Code);
//             Assert.AreEqual("'bankStatement' was missing.", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[2].VerificationErrors[0].Message);
//             Assert.AreEqual("Upload a bank statement", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[2].VerificationErrors[0].RemediatingActions[0].Message);
//             Assert.AreEqual("LE00000000000000000001", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[3].Entity.Id);
//             Assert.AreEqual(CapabilityProblemEntity.TypeEnum.LegalEntity, accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[3].Entity.Type);
//             Assert.AreEqual("2_8189", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[3].VerificationErrors[0].Code);
//             Assert.AreEqual("'UBO through control' was missing.", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[3].VerificationErrors[0].Message);
//             Assert.AreEqual("Add 'organization.entityAssociations' of type 'uboThroughControl' to legal entity", accountHolderUpdatedWebhook.Data.AccountHolder.Capabilities["sendToTransferInstrument"].Problems[3].VerificationErrors[0].RemediatingActions[0].Message);
//             Assert.AreEqual("live", accountHolderUpdatedWebhook.Environment);
//             Assert.AreEqual(DateTime.Parse("2024-12-15T15:42:03+01:00"), accountHolderUpdatedWebhook.Timestamp);
//         }
//
//         [TestMethod]
//         public void Test_POC_Integration()
//         {
//             string jsonPayload = @"
// { 
//     'data': {
//         'balancePlatform': 'YOUR_BALANCE_PLATFORM',
//         'accountHolder': {
//             'contactDetails': {
//                 'address': {
//                     'country': 'NL',
//                     'houseNumberOrName': '274',
//                     'postalCode': '1020CD',
//                     'street': 'Brannan Street'
//                 },
//                 'email': 's.hopper@example.com',
//                 'phone': {
//                     'number': '+315551231234',
//                     'type': 'Mobile'
//                 }
//             },
//             'description': 'S.Hopper - Staff 123',
//             'id': 'AH00000000000000000000001',
//             'status': 'Active'
//         }
//     },
//     'environment': 'test',
//     'type': 'balancePlatform.accountHolder.created'
// }";
//
//             var handler = new BalancePlatformWebhookHandler();
//             var response = handler.GetGenericBalancePlatformWebhook(jsonPayload);
//             try
//             {
//                 if (response.GetType() == typeof(AccountHolderNotificationRequest))
//                 {
//                     var accountHolderNotificationRequest = (AccountHolderNotificationRequest)response;
//                     Assert.AreEqual(accountHolderNotificationRequest.Environment, "test");
//                 }
//
//                 if (response.GetType() == typeof(BalanceAccountNotificationRequest))
//                 {
//                     var balanceAccountNotificationRequest = (BalanceAccountNotificationRequest)response;
//                     Assert.Fail(balanceAccountNotificationRequest.Data.BalancePlatform);
//                 }
//             }
//             catch (System.Exception e)
//             {
//                 Assert.Fail();
//                 throw new System.Exception(e.ToString());
//             }
//         }
//
//         [TestMethod]
//         public void Test_TransactionWebhook_V4()
//         {
//             // Arrange
//             const string jsonPayload = @"
// {
//     'data': {
//     'id': 'EVJN42272224222B5JB8BRC84N686ZEUR',
//     'amount': {
//         'value': 7000,
//         'currency': 'EUR'
//     },
//     'status': 'booked',
//     'transfer': {
//         'id': 'JN4227222422265',
//         'reference': 'Split_item_1',
//     },
//     'valueDate': '2023-03-01T00:00:00+02:00',
//     'bookingDate': '2023-02-28T13:30:20+02:00',
//     'creationDate': '2023-02-28T13:30:05+02:00',
//     'accountHolder': {
//         'id': 'AH00000000000000000000001',
//         'description': 'Your description for the account holder',
//         'reference': 'Your reference for the account holder'
//     },
//     'balanceAccount': {
//         'id': 'BA00000000000000000000001',
//         'description': 'Your description for the balance account',
//         'reference': 'Your reference for the balance account'
//     },
//     'balancePlatform': 'YOUR_BALANCE_PLATFORM'
//     },
//     'type': 'balancePlatform.transaction.created',
//     'environment': 'test'
// }";
//             Assert.IsFalse(_balancePlatformWebhookHandler.GetPaymentNotificationRequest(jsonPayload, out var _));
//             
//             // Act
//             _balancePlatformWebhookHandler.GetTransactionNotificationRequestV4(jsonPayload, out TransactionNotificationRequestV4 target);
//             
//             // Assert
//             Assert.IsNotNull(target);
//             Assert.AreEqual(TransactionNotificationRequestV4.TypeEnum.BalancePlatformTransactionCreated, target.Type);
//             Assert.AreEqual(Transaction.StatusEnum.Booked, target.Data.Status);
//             Assert.AreEqual("BA00000000000000000000001", target.Data.BalanceAccount.Id);
//             Assert.IsTrue(target.Data.ValueDate.Equals(DateTime.Parse("2023-03-01T00:00:00+02:00")));
//             Assert.AreEqual("YOUR_BALANCE_PLATFORM", target.Data.BalancePlatform);
//             Assert.AreEqual("AH00000000000000000000001", target.Data.AccountHolder.Id);
//             Assert.AreEqual("Your description for the account holder", target.Data.AccountHolder.Description);
//             Assert.AreEqual("Your reference for the account holder", target.Data.AccountHolder.Reference);
//             Assert.AreEqual("JN4227222422265", target.Data.Transfer.Id);
//             Assert.AreEqual("Split_item_1", target.Data.Transfer.Reference);
//             Assert.AreEqual(DateTime.Parse("2023-02-28T13:30:05+02:00"), target.Data.CreationDate);
//             Assert.AreEqual(DateTime.Parse("2023-02-28T13:30:20+02:00"), target.Data.BookingDate);
//             Assert.AreEqual(7000, target.Data.Amount.Value);
//             Assert.AreEqual("EUR", target.Data.Amount.Currency);
//             Assert.AreEqual("test", target.Environment);
//         }
//
//         [TestMethod]
//         public void Test_ReportCreatedWebhook()
//         {
//             // Arrange
//             const string jsonPayload = @"
// {
//   'data': {
//     'balancePlatform': 'YOUR_BALANCE_PLATFORM',
//     'creationDate': '2024-07-02T02:01:08+02:00',
//     'id': 'balanceplatform_accounting_report_2024_07_01.csv',
//     'downloadUrl': 'https://balanceplatform-test.adyen.com/balanceplatform/.../.../.../balanceplatform_accounting_report_2024_07_01.csv',
//     'fileName': 'balanceplatform_accounting_report_2024_07_01.csv',
//     'reportType': 'balanceplatform_accounting_report'
//   },
//   'environment': 'test',
//   'timestamp': '2024-07-02T02:01:05+02:00',
//   'type': 'balancePlatform.report.created'
// }";
//
//             // Act
//             _balancePlatformWebhookHandler.GetReportNotificationRequest(jsonPayload, out ReportNotificationRequest target);
//
//             // Assert
//             Assert.IsNotNull(target);
//             Assert.AreEqual(target.Type, ReportNotificationRequest.TypeEnum.BalancePlatformReportCreated);
//             Assert.AreEqual("YOUR_BALANCE_PLATFORM", target.Data.BalancePlatform);
//             Assert.AreEqual("balanceplatform_accounting_report_2024_07_01.csv", target.Data.Id);
//             Assert.AreEqual("balanceplatform_accounting_report_2024_07_01.csv", target.Data.FileName);
//             Assert.AreEqual("balanceplatform_accounting_report", target.Data.ReportType);
//             Assert.AreEqual(DateTime.Parse("2024-07-02T02:01:08+02:00"), target.Data.CreationDate);
//             Assert.AreEqual("https://balanceplatform-test.adyen.com/balanceplatform/.../.../.../balanceplatform_accounting_report_2024_07_01.csv", target.Data.DownloadUrl);
//             Assert.AreEqual("test", target.Environment);
//             Assert.AreEqual(DateTime.Parse("2024-07-02T02:01:05+02:00"), target.Timestamp);
//         }
//         
//         [TestMethod]
//         public void Test_AuthenticationCreatedWebhook()
//         {
//             // Arrange
//             const string jsonPayload = @"
// {
//   'data': {
//     'authentication': {
//       'acsTransId': '6a4c1709-a42e-4c7f-96c7-1043adacfc97',
//       'challenge': {
//         'flow': 'OOB_TRIGGER_FL',
//         'lastInteraction': '2022-12-22T15:49:03+01:00'
//       },
//       'challengeIndicator': '01',
//       'createdAt': '2022-12-22T15:45:03+01:00',
//       'deviceChannel': 'app',
//       'dsTransID': 'a3b86754-444d-46ca-95a2-ada351d3f42c',
//       'exemptionIndicator': 'lowValue',
//       'inPSD2Scope': true,
//       'messageCategory': 'payment',
//       'messageVersion': '2.2.0',
//       'riskScore': 0,
//       'threeDSServerTransID': '6edcc246-23ee-4e94-ac5d-8ae620bea7d9',
//       'transStatus': 'Y',
//       'type': 'challenge'
//     },
//     'balancePlatform': 'YOUR_BALANCE_PLATFORM',
//     'id': '497f6eca-6276-4993-bfeb-53cbbbba6f08',
//     'paymentInstrumentId': 'PI3227C223222B5BPCMFXD2XG',
//     'purchase': {
//       'date': '2022-12-22T15:49:03+01:00',
//       'merchantName': 'MyShop',
//       'originalAmount': {
//         'currency': 'EUR',
//         'value': 1000
//       }
//     },
//     'status': 'authenticated'
//   },
//   'environment': 'test',
//   'timestamp': '2022-12-22T15:42:03+01:00',
//   'type': 'balancePlatform.authentication.created'
// }";
//
//             // Act
//             _balancePlatformWebhookHandler.GetAuthenticationNotificationRequest(jsonPayload, out AuthenticationNotificationRequest target);
//
//             // Assert
//             Assert.IsNotNull(target);
//             Assert.AreEqual(target.Type, AuthenticationNotificationRequest.TypeEnum.BalancePlatformAuthenticationCreated);
//             Assert.AreEqual("YOUR_BALANCE_PLATFORM", target.Data.BalancePlatform);
//             Assert.AreEqual("497f6eca-6276-4993-bfeb-53cbbbba6f08", target.Data.Id);
//             Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", target.Data.PaymentInstrumentId);
//             Assert.AreEqual(AuthenticationNotificationData.StatusEnum.Authenticated, target.Data.Status);
//             Assert.AreEqual("MyShop", target.Data.Purchase.MerchantName);
//             Assert.AreEqual("2022-12-22T15:49:03+01:00", target.Data.Purchase.Date);
//             Assert.AreEqual("EUR", target.Data.Purchase.OriginalAmount.Currency);
//             Assert.AreEqual(1000, target.Data.Purchase.OriginalAmount.Value);
//             Assert.AreEqual(DateTime.Parse("2022-12-22T15:45:03+01:00"), target.Data.Authentication.CreatedAt);
//             Assert.AreEqual(AuthenticationInfo.DeviceChannelEnum.App, target.Data.Authentication.DeviceChannel);
//             Assert.AreEqual(ChallengeInfo.FlowEnum.OOBTRIGGERFL, target.Data.Authentication.Challenge.Flow);
//             Assert.AreEqual(DateTime.Parse("2022-12-22T15:49:03+01:00"), target.Data.Authentication.Challenge.LastInteraction);
//             Assert.AreEqual(AuthenticationInfo.ChallengeIndicatorEnum._01, target.Data.Authentication.ChallengeIndicator);
//             Assert.AreEqual(AuthenticationInfo.ExemptionIndicatorEnum.LowValue, target.Data.Authentication.ExemptionIndicator);
//             Assert.AreEqual(true, target.Data.Authentication.InPSD2Scope);
//             Assert.AreEqual(AuthenticationInfo.MessageCategoryEnum.Payment, target.Data.Authentication.MessageCategory);
//             Assert.AreEqual("2.2.0", target.Data.Authentication.MessageVersion);
//             Assert.AreEqual(0, target.Data.Authentication.RiskScore);
//             Assert.AreEqual("6edcc246-23ee-4e94-ac5d-8ae620bea7d9", target.Data.Authentication.ThreeDSServerTransID);
//             Assert.AreEqual(AuthenticationInfo.TransStatusEnum.Y, target.Data.Authentication.TransStatus);
//             Assert.AreEqual("test", target.Environment);
//             Assert.AreEqual(DateTime.Parse("2022-12-22T15:42:03+01:00"), target.Timestamp);
//         }
//
//         [TestMethod]
//         public void Test_NegativeBalanceCompensationWarningWebhook()
//         {
//             // Arrange
//             const string jsonPayload = @"
// {
//   'data': {
//     'balancePlatform': 'YOUR_BALANCE_PLATFORM',
//     'creationDate': '2024-07-02T02:01:08+02:00',
//     'id': 'BA00000000000000000001',
//     'accountHolder': {
//       'description': 'Description for the account holder.',
//       'reference': 'YOUR_REFERENCE',
//       'id': 'AH00000000000000000001'
//     },
//     'amount': {
//       'currency': 'EUR',
//       'value': -145050
//     },
//     'liableBalanceAccountId': 'BA11111111111111111111',
//     'negativeBalanceSince': '2024-10-19T00:33:13+02:00',
//     'scheduledCompensationAt': '2024-12-01T01:00:00+01:00'
//   },
//   'environment': 'test',
//   'timestamp': '2024-10-22T00:00:00+02:00',
//   'type': 'balancePlatform.negativeBalanceCompensationWarning.scheduled'
// }";
//
//             // Act
//             _balancePlatformWebhookHandler.GetNegativeBalanceCompensationWarningNotificationRequest(jsonPayload, out NegativeBalanceCompensationWarningNotificationRequest target);
//             
//             // Assert
//             Assert.IsNotNull(target);
//             Assert.AreEqual(NegativeBalanceCompensationWarningNotificationRequest.TypeEnum.BalancePlatformNegativeBalanceCompensationWarningScheduled, target.Type);
//             Assert.AreEqual("YOUR_BALANCE_PLATFORM", target.Data.BalancePlatform);
//             Assert.AreEqual(DateTime.Parse("2024-07-02T02:01:08+02:00"), target.Data.CreationDate);
//             Assert.AreEqual("BA00000000000000000001", target.Data.Id);
//             Assert.AreEqual("YOUR_REFERENCE", target.Data.AccountHolder.Reference);
//             Assert.AreEqual("EUR", target.Data.Amount.Currency);
//             Assert.AreEqual(-145050, target.Data.Amount.Value);
//             Assert.AreEqual("BA11111111111111111111", target.Data.LiableBalanceAccountId);
//             Assert.AreEqual(DateTime.Parse("2024-10-19T00:33:13+02:00"), target.Data.NegativeBalanceSince);
//             Assert.AreEqual(DateTime.Parse("2024-12-01T01:00:00+01:00"), target.Data.ScheduledCompensationAt);
//             Assert.AreEqual("test", target.Environment);
//             Assert.AreEqual(DateTime.Parse("2024-10-22T00:00:00+02:00"), target.Timestamp);
//         }
//     }
// }