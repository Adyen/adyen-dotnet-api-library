using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using System.Text;
using System.Text.Json;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class PaymentsServiceTest
    {
        private readonly IHost _hostTestEnv;
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PaymentsServiceTest()
        {
            _hostTestEnv = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            _jsonSerializerOptionsProvider = _hostTestEnv.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public async Task Given_PaymentMethodsResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-methods-response.json");
            // Act
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNull(result.StoredPaymentMethods);
            Assert.AreEqual(29, result.PaymentMethods.Count);
        }
        
        [TestMethod]
        public void Given_CreateCheckoutSessionRequest_When_Serialize_Long__Result_Contains_Zeros()
        {
            // Arrange
            CreateCheckoutSessionRequest checkoutSessionRequest = new CreateCheckoutSessionRequest(
                amount: new Amount("EUR", 10000L),
                merchantAccount: "merchantAccount",
                reference: "TestReference",
                returnUrl: "http://test-url.com",
                channel: CreateCheckoutSessionRequest.ChannelEnum.Web,
                countryCode: "NL",
                lineItems: new List<LineItem>() {
                    new LineItem(quantity: 1, amountIncludingTax: 5000, description: "description1", amountExcludingTax: 0),
                    new LineItem(quantity: 1, amountIncludingTax: 5000, description: "description2", taxAmount: 0)
                }
            );
            
            // Act
            string result = JsonSerializer.Serialize(checkoutSessionRequest, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement lineItems = json.RootElement.GetProperty("lineItems");

            lineItems[0].TryGetProperty("amountExcludingTax", out JsonElement amountExcludingTax);
            lineItems[1].TryGetProperty("taxAmount", out JsonElement taxAmount);
                
            Assert.AreEqual(0, amountExcludingTax.GetInt32());
            Assert.AreEqual(0, taxAmount.GetInt32());
        }
        
        [TestMethod]
        public void Given_CreateCheckoutSessionResponse_When_Deserialize_Returns_Not_Null()
        {
            // Arrange
            string json = @"{""mode"": ""embedded"",""amount"": {""currency"": ""EUR"",""value"": 10000},""expiresAt"": ""2023-04-06T17:11:15+02:00"",""id"": ""CS0068299CB8DA273A"",""merchantAccount"": ""TestMerchantAccount"",""reference"": ""TestReference"",""returnUrl"": ""http://test-url.com"",""sessionData"": ""Ab02b4c0!BQABAgBoacRJuRbNM/typUKATopkZ3V+cINm0WTAvwl9uQJ2e8I00P2KFemlwp4nb1bOqqYh1zx48gDAHt0QDs2JTiQIqDQRizqopLFRk/wAJHFoCuam/GvOHflg9vwS3caHbkBToIolxcYcJoJheIN9o1fGmNIHZb9VrWfiKsXMgmYsSUifenayS2tkKCTquF7vguaAwk7q5ES1GDwzP/J2mChJGH04jGrVL4szPHGmznr897wIcFQyBSZe4Uifqoe0fpiIxZLNWadLMya6SnvQYNAQL1V6ti+7F4wHHyLwHWTCua993sttue70TE4918EV80HcAWx0LE1+uW6J5KBHCKdYNi9ESlGSZreRwLCpdNbmumB6MlyHZlz2umLiw0ZZJAEpdrwXA2NiyHzJDKDKfbAhd8uoTSACrbgwbrAXI1cvb1WjiOQjLn9MVW++fuJCq6vIeX+rUKMeltBAHMeBZyC54ndAucw9nS03uyckjphunE4tl4WTT475VkfUiyJCTT3S2IOVYS9V9M8pMQ1/GlDVNCLBJJfrYlVXoC8VX68QW1HERkhNYQbTgLQ9kI3cDeMP5d4TuUL3XR2Q6sNiOMdIPGDYQ9QFKFdOE3OQ5X9wxUYbX6j88wR2gRGJcS5agqFHOR1ZTNrjumOYrEkjL8ehFXEs/KluhURllfi0POUPGAwlUWBjDCZcKaeeR0kASnsia2V5IjoiQUYwQUFBMTAzQ0E1MzdFQUVEODdDMjRERDUzOTA5QjgwQTc4QTkyM0UzODIzRDY4REFDQzk0QjlGRjgzMDVEQyJ9E0Gs1T0RaO7NluuXP59fegcW6SQKq4BhC3ZzEKPm1vJuwAJ2gZUaicaXbRPW3IyadavKRlfGdFeAYt2B3ik8fGiK3ZkKU0CrZ0qL0IO5rrWrOg74HMnpxRAn1RhAHRHfGEk67FFPNjr0aLBJXSia7xZWiyKA+i4QU63roY2sxMI/q41mvJjRUz0rPKT3SbVDt1Of7K7BP8cmiboBkWexFBD/mkJyMOpYAOoFp/tKOUHTWZYcc1GpbyV1jInXVfEUhHROYCtS4p/xwF6DdT3bI0+HRU35/xNBTZH2yJN55u9i42Vb0ddCyhzOLZYQ3JVgglty6hLgVeQzuN4b2MoalhfTl11HsElJT1kB0mznVX8CL7UMTUp/2uSgL8DN6kB4owEZ45nWRxIR/2sCidMJ1tnSI1uSqkeqXRf1vat5qPq+BzpYE0Urn2ZZEmgJyb2u0ZLn2x1tfJyPtv+hqBoT7iqJ224dSbuB4HMT49YtcheUtR0jnrImJXm+M1TeIjWB3XWOScrNV8sWEJMAiIU="",""shopperLocale"": ""en-US""}";
            
            // Act
            CreateCheckoutSessionResponse response = JsonSerializer.Deserialize<CreateCheckoutSessionResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response.Id);
        }
        
        
        [TestMethod]
        public void Given_Byte_Array_When_Serialize_Returns_Not_Null()
        {
            // Arrange
            byte[] plainTextBytes = Encoding.ASCII.GetBytes("Bytes-To-Be-Encoded");
            string base64String = System.Convert.ToBase64String(plainTextBytes);
            byte[] base64Bytes = Encoding.ASCII.GetBytes(base64String);
            var threeDSecure = new ThreeDSecureData
            {
                Cavv = base64Bytes,
                Xid = base64Bytes
            };
            
            // Act
            string jsonRequest = JsonSerializer.Serialize(threeDSecure, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            string json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            Assert.AreEqual(json, jsonRequest);
        }

        [TestMethod]
        public void Given_Byte_Array_When_Deserialize_Result_ThreeDSecureData_Should_Deserialize_Correctly()
        {
            // Arrange
            string json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";
            
            // Act
            ThreeDSecureData jsonRequest = JsonSerializer.Deserialize<ThreeDSecureData>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            string xid = Encoding.ASCII.GetString(jsonRequest.Xid);
            string cavv = Encoding.ASCII.GetString(jsonRequest.Cavv);
            string jsonElementBase64 = "Qnl0ZXMtVG8tQmUtRW5jb2RlZA==";
            Assert.AreEqual(jsonElementBase64, xid);
            Assert.AreEqual(jsonElementBase64, cavv);
        }
        
        [TestMethod]
        public async Task Given_Empty_ConfigureCheckout_When_No_AdyenOptions_Provided_Then_IPaymentService_Should_Throw_InvalidOperationException()
        {
            // Arrange
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    // Empty
                })
                .Build();

            // Act
            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // No ApiKey provided, cannot instantiate the ApiKeyToken object
                testHost.Services.GetRequiredService<IPaymentsService>();
            });
        }
    }
}