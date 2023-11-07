using System;
using Adyen.Model.ConfigurationWebhooks;
using Adyen.Model.ManagementWebhooks;
using Adyen.Model.TransactionWebhooks;
using Adyen.Webhooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test.WebhooksTests
{
    [TestClass]
    public class NewWebhookHandlerTest : BaseTest
    {
        private readonly BalancePlatformWebhookHandler _target;
        private readonly ManagementWebhookHandler _managementWebhookHandler;

        public NewWebhookHandlerTest()
        {
            _target = new BalancePlatformWebhookHandler();
            _managementWebhookHandler = new ManagementWebhookHandler();
        }

        [TestMethod]
        [DataRow("balancePlatform.accountHolder.created", AccountHolderNotificationRequest.TypeEnum.Created)]
        [DataRow("balancePlatform.accountHolder.updated", AccountHolderNotificationRequest.TypeEnum.Updated)]
        public void Given_AccountHolder_Webhook_When_Type_Is_Provided_Result_Should_Deserialize(string type, AccountHolderNotificationRequest.TypeEnum expected)
        {
            string jsonPayload =
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
                'type': '" + type + "'" +
            "}";
            bool isSuccess = _target.GetAccountHolderNotificationRequest(jsonPayload, out AccountHolderNotificationRequest target);
            Assert.IsTrue(isSuccess);
            Assert.IsNotNull(target);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", target.Data.BalancePlatform);
            Assert.AreEqual("NL", target.Data.AccountHolder.ContactDetails.Address.Country);
            Assert.AreEqual("274", target.Data.AccountHolder.ContactDetails.Address.HouseNumberOrName);
            Assert.AreEqual("1020CD", target.Data.AccountHolder.ContactDetails.Address.PostalCode);
            Assert.AreEqual("Brannan Street", target.Data.AccountHolder.ContactDetails.Address.Street);
            Assert.AreEqual("s.hopper@example.com", target.Data.AccountHolder.ContactDetails.Email);
            Assert.AreEqual("+315551231234", target.Data.AccountHolder.ContactDetails.Phone.Number);
            Assert.AreEqual(Phone.TypeEnum.Mobile, target.Data.AccountHolder.ContactDetails.Phone.Type);
            Assert.AreEqual("S.Hopper - Staff 123", target.Data.AccountHolder.Description);
            Assert.AreEqual("AH00000000000000000000001", target.Data.AccountHolder.Id);
            Assert.AreEqual(AccountHolder.StatusEnum.Active, target.Data.AccountHolder.Status);
            Assert.AreEqual("test", target.Environment);
            Assert.AreEqual(expected, target.Type);
        }

        [TestMethod]
        public void Given_AccountHolder_Webhook_When_Type_Is_Unknown_Result_Should_Be_Null()
        {
            string jsonPayload = @"
            {
                'type': 'unknowntype'
            }";
            var isSuccess = _target.GetAccountHolderNotificationRequest(jsonPayload, out var target);
            Assert.IsFalse(isSuccess);
            Assert.IsNull(target);
        }

        [TestMethod]
        public void Given_AccountHolder_Webhook_When_Invalid_Json_Result_Should_Throw_JsonReaderException()
        {
            string jsonPayload = "{ invalid,.json; }";
            Assert.ThrowsException<JsonReaderException>(() => _target.GetAccountHolderNotificationRequest(jsonPayload, out var _));
        }
        
        [TestMethod]
        public void Test_POC_Integration()
        {
            string jsonPayload =
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
            }";

            var handler = new BalancePlatformWebhookHandler();
            var response = handler.GetGenericBalancePlatformWebhook(jsonPayload);
            try
            {
                if (response.GetType() == typeof(AccountHolderNotificationRequest))
                {
                    var accountHolderNotificationRequest = (AccountHolderNotificationRequest)response;
                    Assert.AreEqual(accountHolderNotificationRequest.Environment, "test");
                }

                if (response.GetType() == typeof(BalanceAccountNotificationRequest))
                {
                    var balanceAccountNotificationRequest = (BalanceAccountNotificationRequest)response;
                    Assert.Fail(balanceAccountNotificationRequest.Data.BalancePlatform);
                }
            }
            catch (System.Exception e)
            {
                Assert.Fail();
                throw new System.Exception(e.ToString());
            }
        }

        [TestMethod]
        public void Test_Management_Webhook_PaymentMethodCreated()
        {
            const string jsonPayload = @"{
              'createdAt': '2022-01-24T14:59:11+01:00',
                'data': {
                    'id': 'PM3224R223224K5FH4M2K9B86',
                    'merchantId': 'MERCHANT_ACCOUNT',
                    'result': 'SUCCESS',
                    'storeId': 'ST322LJ223223K5F4SQNR9XL5',
                    'type': 'visa'
                },
                'environment': 'test',
                'type': 'paymentMethod.created'
            }";
            var response = _managementWebhookHandler.GetPaymentMethodCreatedNotificationRequest(jsonPayload, out var webhook);
            if (response)
            {
                Assert.AreEqual(webhook.Type, PaymentMethodCreatedNotificationRequest.TypeEnum.PaymentMethodCreated);
                Assert.AreEqual(webhook.Data.Id, "PM3224R223224K5FH4M2K9B86");
            }
        }
        
        [TestMethod]
        public void Test_Management_Webhook_MerchantUpdated()
        {
            const string jsonPayload = @"{
                'type': 'merchant.updated',
                'environment': 'test',
                'createdAt': '2022-09-20T13:42:31+02:00',
                'data': {
                    'capabilities': {
                        'receivePayments': {
                            'allowed': true,
                            'requested': true,
                            'requestedLevel': 'notApplicable',
                            'verificationStatus': 'valid'
                        }
                    },
                    'legalEntityId': 'LE322KH223222F5GNNW694PZN',
                    'merchantId': 'YOUR_MERCHANT_ID',
                    'status': 'PreActive'
                }
            }";
            var response = _managementWebhookHandler.GetMerchantUpdatedNotificationRequest(jsonPayload, out var webhook);
            Assert.IsTrue(response);
            Assert.AreEqual(webhook.Type, MerchantUpdatedNotificationRequest.TypeEnum.MerchantUpdated);
            Assert.IsTrue(webhook.Data.Capabilities.TryGetValue("receivePayments", out var data));
            Assert.AreEqual(data.RequestedLevel, "notApplicable");
            Assert.AreEqual(data.Requested, true);
        }
        
        [TestMethod]
        public void Test_Management_Webhook_MerchantCreated()
        {
            const string jsonPayload = @"{
                'type': 'merchant.created',
                'environment': 'test',
                'createdAt': '2022-08-12T10:50:01+02:00',
                'data': {
                    'capabilities': {
                        'sendToTransferInstrument': {
                            'requested': true,
                            'requestedLevel': 'notApplicable'
                        }
                    },
                    'companyId': 'YOUR_COMPANY_ID',
                    'merchantId': 'MC3224X22322535GH8D537TJR',
                    'status': 'PreActive'
                }
            }";
            Assert.IsFalse(_managementWebhookHandler.GetMerchantUpdatedNotificationRequest(jsonPayload, out var dummy));
            var response = _managementWebhookHandler.GetMerchantCreatedNotificationRequest(jsonPayload, out var webhook);
            Assert.IsTrue(response);
            Assert.AreEqual(webhook.Type, MerchantCreatedNotificationRequest.TypeEnum.MerchantCreated);
            Assert.IsTrue(webhook.Data.Capabilities.TryGetValue("sendToTransferInstrument", out var data));
            Assert.AreEqual(data.RequestedLevel, "notApplicable");
            Assert.AreEqual(data.Requested, true);
        }
        
        [TestMethod]
        public void Test_TransactionWebhook_V4()
        {
            const string jsonPayload = @"{
                'data': {
                'id': 'EVJN42272224222B5JB8BRC84N686ZEUR',
                'amount': {
                    'value': 7000,
                    'currency': 'EUR'
                },
                'status': 'booked',
                'transfer': {
                    'id': 'JN4227222422265',
                    'reference': 'Split_item_1',
                },
                'valueDate': '2023-03-01T00:00:00+02:00',
                'bookingDate': '2023-02-28T13:30:20+02:00',
                'creationDate': '2023-02-28T13:30:05+02:00',
                'accountHolder': {
                    'id': 'AH00000000000000000000001',
                    'description': 'Your description for the account holder',
                    'reference': 'Your reference for the account holder'
                },
                'balanceAccount': {
                    'id': 'BA00000000000000000000001',
                    'description': 'Your description for the balance account',
                    'reference': 'Your reference for the balance account'
                },
                'balancePlatform': 'YOUR_BALANCE_PLATFORM'
                },
                'type': 'balancePlatform.transaction.created',
                'environment': 'test'
            }";
            Assert.IsFalse(_target.GetPaymentNotificationRequest(jsonPayload, out var dummy));
            var response = _target.GetTransactionNotificationRequestV4(jsonPayload, out var webhook);
            Assert.IsTrue(response);
            Assert.AreEqual(webhook.Type, TransactionNotificationRequestV4.TypeEnum.BalancePlatformTransactionCreated);
            Assert.IsTrue(webhook.Data.ValueDate.Equals(DateTime.Parse("2023-03-01T00:00:00+02:00")));
            Assert.AreEqual(webhook.Data.BalanceAccount.Id, "BA00000000000000000000001");
            Assert.AreEqual(webhook.Data.Status, Transaction.StatusEnum.Booked);
        }
    }
}