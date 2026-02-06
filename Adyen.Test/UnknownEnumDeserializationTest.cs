using Adyen.Model.Checkout;
using Adyen.Model.TransferWebhooks;
using Adyen.Util;
using Adyen.Webhooks;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class UnknownEnumDeserializationTest
    {
        [TestMethod]
        public void TestUnknownEnumValueDeserializesToNull()
        {
            // Test JSON with an unknown enum value
            var json = @"{ 
                ""channel"": ""UnknownChannelValue"",
                ""amount"": {
                    ""value"": 1000,
                    ""currency"": ""EUR""
                },
                ""reference"": ""test-ref"",
                ""merchantAccount"": ""test-merchant""
            }";

            // This should not throw an exception when using JsonOperation.Deserialize
            var paymentRequest = JsonOperation.Deserialize<PaymentRequest>(json);
            
            // The unknown enum value should deserialize to null
            Assert.IsNotNull(paymentRequest);
            Assert.IsNull(paymentRequest.Channel);
        }

        [TestMethod]
        public void TestKnownEnumValueDeserializesCorrectly()
        {
            // Test JSON with a known enum value
            var json = @"{ 
                ""channel"": ""Web"",
                ""amount"": {
                    ""value"": 1000,
                    ""currency"": ""EUR""
                },
                ""reference"": ""test-ref"",
                ""merchantAccount"": ""test-merchant""
            }";

            var paymentRequest = JsonOperation.Deserialize<PaymentRequest>(json);
            
            Assert.IsNotNull(paymentRequest);
            Assert.IsNotNull(paymentRequest.Channel);
            Assert.AreEqual(PaymentRequest.ChannelEnum.Web, paymentRequest.Channel);
        }

        [TestMethod]
        public void TestMissingEnumValueDeserializesToNull()
        {
            // Test JSON without the enum field
            var json = @"{ 
                ""amount"": {
                    ""value"": 1000,
                    ""currency"": ""EUR""
                },
                ""reference"": ""test-ref"",
                ""merchantAccount"": ""test-merchant""
            }";

            var paymentRequest = JsonOperation.Deserialize<PaymentRequest>(json);
            
            Assert.IsNotNull(paymentRequest);
            Assert.IsNull(paymentRequest.Channel);
        }

        [TestMethod]
        public void TestMultipleUnknownEnumValues()
        {
            // Test JSON with multiple unknown enum values
            var json = @"{ 
                ""channel"": ""FutureChannel"",
                ""entityType"": ""UnknownEntityType"",
                ""industryUsage"": ""newUsageType"",
                ""amount"": {
                    ""value"": 1000,
                    ""currency"": ""EUR""
                },
                ""reference"": ""test-ref"",
                ""merchantAccount"": ""test-merchant""
            }";

            var paymentRequest = JsonOperation.Deserialize<PaymentRequest>(json);
            
            Assert.IsNotNull(paymentRequest);
            Assert.IsNull(paymentRequest.Channel);
            Assert.IsNull(paymentRequest.EntityType);
            Assert.IsNull(paymentRequest.IndustryUsage);
        }

        [TestMethod]
        public void TestSerializationOfNullEnumValue()
        {
            // Create a payment request with null enum values
            var paymentRequest = new PaymentRequest
            {
                Channel = null,
                EntityType = null
            };

            var json = JsonConvert.SerializeObject(paymentRequest);
            
            // Null values should not be serialized (based on EmitDefaultValue = false)
            Assert.IsFalse(json.Contains("\"channel\""));
            Assert.IsFalse(json.Contains("\"entityType\""));
        }

        [TestMethod]
        public void TestWebhookHandlerWithUnknownEnumValues()
        {
            // Test the actual webhook handler path
            var json = @"{ 
                ""live"": ""false"",
                ""notificationItems"": []
            }";

            var webhookHandler = new Adyen.Webhooks.WebhookHandler();
            var notificationRequest = webhookHandler.HandleNotificationRequest(json);
            
            Assert.IsNotNull(notificationRequest);
        }
        
        [TestMethod]
        public void TestTransferWebhookWithUnknownReasonEnum()
        {
            var json = @"{ 
              ""data"": {
                ""balancePlatform"": ""N2F_SANDBOX"",
                ""creationDate"": ""2026-01-14T14:26:59+01:00"",
                ""id"": ""38EBJS69NWKG7GSL"",
                ""accountHolder"": {
                  ""description"": ""AccountId : 9819 - LegalEntityId : 58019 - LegalEntityName : Sandbox 01"",
                  ""id"": ""AH32CM322322995MS737SFD8T"",
                  ""reference"": ""dd92c730-ae54-47c5-9c5f-25307e13efd4""
                },
                ""amount"": { ""currency"": ""EUR"", ""value"": 100 },
                ""balanceAccount"": {
                  ""description"": ""AccountId : 9819 - LegalEntityId : 58019 - LegalEntityName : Sandbox 01"",
                  ""id"": ""BA32CM322322995MS737TFDPH"",
                  ""reference"": ""dd92c730-ae54-47c5-9c5f-25307e13efd4""
                },
                ""category"": ""issuedCard"",
                ""categoryData"": {
                  ""authorisationType"": ""finalAuthorisation"",
                  ""panEntryMode"": ""manual"",
                  ""processingType"": ""ecommerce"",
                  ""relayedAuthorisationData"": { ""metadata"": { ""RefusedByN2F"": ""RefusedByRelayedRules"" }, ""reference"": """" },
                  ""schemeUniqueTransactionId"": ""MCS9S6YGY0114"",
                  ""type"": ""issuedCard"",
                  ""validationFacts"": [
                    { ""result"": ""valid"", ""type"": ""accountLookup"" },
                    { ""result"": ""valid"", ""type"": ""cardAuthentication"" },
                    { ""result"": ""notValidated"", ""type"": ""mitAllowedMerchant"" },
                    { ""result"": ""valid"", ""type"": ""paymentInstrumentFound"" },
                    { ""result"": ""valid"", ""type"": ""transactionValidation"" },
                    { ""result"": ""notApplicable"", ""type"": ""authorisedPaymentInstrumentUser"" },
                    { ""result"": ""valid"", ""type"": ""screening"" },
                    { ""result"": ""valid"", ""type"": ""partyScreening"" },
                    { ""result"": ""valid"", ""type"": ""transactionRules"" },
                    { ""result"": ""invalid"", ""type"": ""relayedAuthorisation"" },
                    { ""result"": ""valid"", ""type"": ""inputExpiryDateCheck"" },
                    { ""result"": ""valid"", ""type"": ""paymentInstrument"" },
                    { ""result"": ""valid"", ""type"": ""cardholderAuthentication"" },
                    { ""result"": ""valid"", ""type"": ""paymentInstrumentExpirationCheck"" },
                    { ""result"": ""valid"", ""type"": ""balanceCheck"" },
                    { ""result"": ""valid"", ""type"": ""paymentInstrumentActive"" },
                    { ""result"": ""valid"", ""type"": ""realBalanceAvailable"" }
                  ]
                },
                ""counterparty"": {
                  ""merchant"": {
                    ""acquirerId"": ""013445"",
                    ""mcc"": ""7999"",
                    ""merchantId"": ""526567789012346"",
                    ""nameLocation"": { ""city"": ""Amsterdam"", ""country"": ""NL"", ""name"": ""N2F_FR_SANDBOX_TEST"" },
                    ""postalCode"": ""1011 DJ"",
                    ""city"": ""Amsterdam"",
                    ""country"": ""NETHERLANDS"",
                    ""name"": ""N2F_FR_SANDBOX_TEST"" 
                  }
                },
                ""createdAt"": ""2026-01-14T14:26:58+01:00"",
                ""direction"": ""outgoing"",
                ""paymentInstrument"": { ""id"": ""PI32CM722322B35NR3F6RBNN8"", ""reference"": ""dd92c730-ae54-47c5-9c5f-25307e13efd4"" },
                ""reason"": ""UNKNWON_REASON_HERE_000"",
                ""reference"": ""229BZZ4LB5LGGWS5-MCS9S6YGY"",
                ""status"": ""refused"",
                ""type"": ""payment"",
                ""balances"": [{ ""currency"": ""EUR"", ""received"": -100 }],
                ""eventId"": ""EVJN4295V223223W5NR3GPKDS32BBH"",
                ""events"": [
                  {
                    ""amount"": { ""currency"": ""EUR"", ""value"": -100 },
                    ""bookingDate"": ""2026-01-14T14:26:59+01:00"",
                    ""id"": ""EVJN42CSX223223W5NR3GPKDNB4DBC"",
                    ""mutations"": [{ ""currency"": ""EUR"", ""received"": -100 }],
                    ""originalAmount"": { ""currency"": ""EUR"", ""value"": -100 },
                    ""status"": ""received"",
                    ""type"": ""accounting"" 
                  },
                  {
                    ""amount"": { ""currency"": ""EUR"", ""value"": 100 },
                    ""bookingDate"": ""2026-01-14T14:26:59+01:00"",
                    ""id"": ""EVJN4295V223223W5NR3GPKDS32BBH"",
                    ""mutations"": [{ ""currency"": ""EUR"", ""received"": 100 }],
                    ""originalAmount"": { ""currency"": ""EUR"", ""value"": 100 },
                    ""status"": ""refused"",
                    ""type"": ""accounting"" 
                  }
                ],
                ""sequenceNumber"": 2,
                ""transactionRulesResult"": { ""allHardBlockRulesPassed"": true, ""score"": 0 },
                ""updatedAt"": ""2026-01-14T14:26:59+01:00""
              },
              ""environment"": ""test"",
              ""timestamp"": ""2026-01-14T13:27:01.805Z"",
              ""type"": ""balancePlatform.transfer.updated""
            }";
            
            var handler = new BalancePlatformWebhookHandler();
            var transferNotificationRequest = handler.GetGenericBalancePlatformWebhook(json) as TransferNotificationRequest;

            Assert.IsNotNull(transferNotificationRequest);
            Assert.IsNotNull(transferNotificationRequest.Data);
            Assert.IsNull(transferNotificationRequest.Data.Reason); // Issue #1228
            Assert.AreEqual(TransferData.StatusEnum.Refused, transferNotificationRequest.Data.Status);
        }
    }
}