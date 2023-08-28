using Adyen.Model.ConfigurationWebhooks;
using Adyen.Webhooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test.WebhooksTests
{
    [TestClass]
    public class BalancePlatformWebhookHandlerTest : BaseTest
    {
        private readonly BalancePlatformWebhookHandler _target;

        public BalancePlatformWebhookHandlerTest()
        {
            _target = new BalancePlatformWebhookHandler();
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
    }
}