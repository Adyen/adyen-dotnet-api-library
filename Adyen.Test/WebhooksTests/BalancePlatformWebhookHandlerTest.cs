using Adyen.Model.ConfigurationNotification;
using Adyen.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Webhooks.Test
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

        // TODO: Add other tests for BalanceAccount, CardOrder, PaymentInstrument, BalanceAccountSweep, Report, and Transfer.


        // POC integration
        public void POC_Integration()
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
            try
            {
                if (handler.GetPaymentNotificationRequest(jsonPayload, out var paymentInstrumentNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //paymentInstrumentNotificationRequest.Data.BalancePlatform.
                    return;
                }

                if (handler.GetReportNotificationRequest(jsonPayload, out var reportNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //reportNotificationRequest.Data.  
                    return;
                }

                if (handler.GetTransferNotificationRequest(jsonPayload, out var transferNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //transferNotificationRequest.Data. 
                    return;
                }

                if (handler.GetAccountHolderNotificationRequest(jsonPayload, out var accountHolderNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //accountHolderNotificationRequest.Data. 
                    return;
                }

                if (handler.GetBalanceAccountNotificationRequest(jsonPayload, out var balanceAccountNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //balanceAccountNotificationRequest.Data. 
                    return;
                }

                if (handler.GetCardOrderNotificationRequest(jsonPayload, out var cardOrderNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //cardOrderNotificationRequest.Data. 
                    return;
                }

                if (handler.GetSweepConfigurationNotificationRequest(jsonPayload, out var sweepConfigurationNotificationRequest))
                {
                    // Do work, valid hmac etc.
                    //sweepConfigurationNotificationRequest.Data. 
                    return;
                }
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.ToString());
            }
        }

        /// Even better: 
        // POC -> It would be nice to deserialize to a generic webhook with a "type", and based off the type write a Converter that can deserialize accordingly
        //[HttpPost("api/webhooks/notifications")]
        //public async Task<ActionResult<string>> Webhooks(IPlatformWebhook webhook) // public Type {get;set;}
        //{
        //    var handler = new BalancePlatformWebhookHandler();
        //    _logger.LogInformation($"Webhook received: \n{webhook}\n");
        //    // Do a switch statement here
        //    if (webhook.Type == "balancePlatform.paymentInstrument.updated")
        //        PaymentNotificationRequest paymentInstrument = handler.GetPaymentInstrumentNotificationRequestFrom(webhook).... etc.
        //    else if (webhook.Type == "balancePlatform.cardorder.crated") ...
        //}

        // vs. Now developers need to do something like this with the current implementation.
        //[HttpPost("api/webhooks/notifications")]
        //public async Task<ActionResult<string>> Webhooks(string jsonPayload) // public Type {get;set;}
        //{
        //    _logger.LogInformation($"Webhook received: \n{jsonPayload}\n");
        //}
    }
}