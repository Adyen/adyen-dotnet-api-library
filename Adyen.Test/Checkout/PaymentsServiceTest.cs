using System.Text;
using System.Text.Json;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
            string json = @"
{
  ""paymentMethods"": [
    {
      ""name"": ""AliPay"",
      ""type"": ""alipay""
    },
    {
      ""brands"": [
        ""cartebancaire"",
        ""amex"",
        ""mc"",
        ""visa""
      ],
      ""configuration"": {
        ""mcDpaId"": ""6d41d4d6-45b1-42c3-a5d0-a28c0e69d4b1_dpa2"",
        ""visaSrcInitiatorId"": ""B9SECVKIQX2SOBQ6J9X721dVBBKHhJJl1nxxVbemHGn5oB6S8"",
        ""mcSrcClientId"": ""6d41d4d6-45b1-42c3-a5d0-a28c0e69d4b1"",
        ""visaSrciDpaId"": ""8e6e347c-254e-863f-0e6a-196bf2d9df02""
      },
      ""name"": ""Cards"",
      ""type"": ""scheme""
    },
    {
      ""configuration"": {
        ""merchantId"": ""000000000202326"",
        ""merchantName"": ""TestMerchantAccount""
      },
      ""name"": ""Apple Pay"",
      ""type"": ""applepay""
    },
    {
      ""name"": ""Payconiq by Bancontact"",
      ""type"": ""bcmc_mobile""
    },
    {
      ""name"": ""Boleto Bancario"",
      ""type"": ""boletobancario""
    },
    {
      ""name"": ""Online bank transfer."",
      ""type"": ""directEbanking""
    },
    {
      ""name"": ""DOKU"",
      ""type"": ""doku""
    },
    {
      ""name"": ""DOKU wallet"",
      ""type"": ""doku_wallet""
    },
    {
      ""brand"": ""***************"",
      ""name"": ""Generic GiftCard"",
      ""type"": ""giftcard""
    },
    {
      ""brand"": ""*****"",
      ""name"": ""Givex"",
      ""type"": ""giftcard""
    },
    {
      ""name"": ""GoPay Wallet"",
      ""type"": ""gopay_wallet""
    },
    {
      ""name"": ""GrabPay"",
      ""type"": ""grabpay_SG""
    },
    {
      ""issuers"": [
        {
          ""id"": ""************"",
          ""name"": ""*****""
        }
      ],
      ""name"": ""iDEAL"",
      ""type"": ""ideal""
    },
    {
      ""name"": ""Korea–issued cards"",
      ""type"": ""kcp_creditcard""
    },
    {
      ""name"": ""Pay later with Klarna."",
      ""type"": ""klarna""
    },
    {
      ""name"": ""Pay over time with Klarna."",
      ""type"": ""klarna_account""
    },
    {
      ""name"": ""Pay now with Klarna."",
      ""type"": ""klarna_paynow""
    },
    {
      ""name"": ""MB WAY"",
      ""type"": ""mbway""
    },
    {
      ""name"": ""MobilePay"",
      ""type"": ""mobilepay""
    },
    {
      ""configuration"": {
        ""merchantId"": ""50"",
        ""gatewayMerchantId"": ""TestMerchantAccount""
      },
      ""name"": ""Google Pay"",
      ""type"": ""paywithgoogle""
    },
    {
      ""name"": ""pix"",
      ""type"": ""pix""
    },
    {
      ""name"": ""SEPA Direct Debit"",
      ""type"": ""sepadirectdebit""
    },
    {
      ""brand"": ""***"",
      ""name"": ""SVS"",
      ""type"": ""giftcard""
    },
    {
      ""name"": ""UPI Collect"",
      ""type"": ""upi_collect""
    },
    {
      ""name"": ""UPI Intent"",
      ""type"": ""upi_intent""
    },
    {
      ""name"": ""UPI QR"",
      ""type"": ""upi_qr""
    },
    {
      ""brand"": ""*********"",
      ""name"": ""Valuelink"",
      ""type"": ""giftcard""
    },
    {
      ""name"": ""Vipps"",
      ""type"": ""vipps""
    },
    {
      ""brand"": ""***********"",
      ""name"": ""VVV Giftcard"",
      ""type"": ""giftcard""
    }
  ]
}
";

            // Act
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNull(result.StoredPaymentMethods);
            Assert.AreEqual(29, result.PaymentMethods.Count);
        }
        
        [TestMethod]
        public void Given_CreateCheckoutSessionRequest_When_Serialize_Result_Contains_Zeros()
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
            
            // Assert that long parameters set to zero are actually serialised (just like Int)
            
            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement lineItems = json.RootElement.GetProperty("lineItems");

            lineItems[0].TryGetProperty("amountExcludingTax", out JsonElement amountExcludingTaxProp);
            lineItems[1].TryGetProperty("taxAmount", out JsonElement taxAmountProp);
                
            Assert.AreEqual(0, amountExcludingTaxProp.GetInt32());
            Assert.AreEqual(0, taxAmountProp.GetInt32());
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
        
        #region Tests Live URL and LiveUrlPrefix 
        
        [TestMethod]
        public async Task Given_ConfigureCheckout_When_Environment_Is_Live_Then_HttpClient_BaseUrl_Is_Correct()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                })
                .Build();
            
            // Act
            IPaymentsService paymentsApiService = liveHost.Services.GetRequiredService<IPaymentsService>();
            string baseAddress = paymentsApiService.HttpClient.BaseAddress!.ToString();
            
            // Assert
            Assert.IsTrue(baseAddress.Contains("live"));
            Assert.IsTrue(baseAddress.Contains("prefix"));
        }

        [TestMethod]
        public async Task Given_ConfigureCheckout_When_Environment_Is_Test_And_Prefix_Given_Then_HttpClient_BaseUrl_Does_Not_Contain_Prefix()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                })
                .Build();
            
            // Act
            IPaymentsService paymentsApiService = testHost.Services.GetRequiredService<IPaymentsService>();
            string baseAddress = paymentsApiService.HttpClient.BaseAddress!.ToString();
            
            // Assert
            Assert.IsTrue(baseAddress.Contains("test"));
            Assert.IsFalse(baseAddress.Contains("prefix"));
        }
        
        [TestMethod]
        public async Task Given_ConfigureCheckout_When_No_Options_Provided_Then_HttpClient_Should_Contain_Test_Url_And_No_Prefix()
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
        #endregion
    }
}