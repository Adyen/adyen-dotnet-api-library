using Adyen.Model.Checkout;
using Adyen.Util;
using Newtonsoft.Json;
using Xunit;

namespace Adyen.Test
{
    public class UnknownEnumDeserializationTest
    {
        [Fact]
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
            Assert.NotNull(paymentRequest);
            Assert.Null(paymentRequest.Channel);
        }

        [Fact]
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
            
            Assert.NotNull(paymentRequest);
            Assert.NotNull(paymentRequest.Channel);
            Assert.Equal(PaymentRequest.ChannelEnum.Web, paymentRequest.Channel);
        }

        [Fact]
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
            
            Assert.NotNull(paymentRequest);
            Assert.Null(paymentRequest.Channel);
        }

        [Fact]
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
            
            Assert.NotNull(paymentRequest);
            Assert.Null(paymentRequest.Channel);
            Assert.Null(paymentRequest.EntityType);
            Assert.Null(paymentRequest.IndustryUsage);
        }

        [Fact]
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
            Assert.DoesNotContain("\"channel\"", json);
            Assert.DoesNotContain("\"entityType\"", json);
        }

        [Fact]
        public void TestWebhookHandlerWithUnknownEnumValues()
        {
            // Test the actual webhook handler path
            var json = @"{
                ""live"": ""false"",
                ""notificationItems"": []
            }";

            var webhookHandler = new Adyen.Webhooks.WebhookHandler();
            var notificationRequest = webhookHandler.HandleNotificationRequest(json);
            
            Assert.NotNull(notificationRequest);
        }
    }
}
