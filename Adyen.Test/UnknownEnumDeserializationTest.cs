using Adyen.Model.Checkout;
using Adyen.Util;
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
        public void TestWebhookHandlerParsesNotificationRequest()
        {
            // Test that the webhook handler can parse a basic notification request
            var json = @"{
                ""live"": ""false"",
                ""notificationItems"": []
            }";

            var webhookHandler = new Adyen.Webhooks.WebhookHandler();
            var notificationRequest = webhookHandler.HandleNotificationRequest(json);
            
            Assert.IsNotNull(notificationRequest);
        }
    }
}
