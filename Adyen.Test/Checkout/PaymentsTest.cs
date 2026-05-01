using System.Net;
using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text;
using System.Text.Json;
using Adyen.Core;
using Adyen.Core.Client;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class PaymentsTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PaymentsTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
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
        public async Task Given_CreateCheckoutSessionRequest_When_Serialize_Long__Result_Contains_Zeros()
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
        public async Task Given_CreateCheckoutSessionResponse_When_Deserialize_Returns_Not_Null()
        {
            // Arrange
            string json = @"{""mode"": ""embedded"",""amount"": {""currency"": ""EUR"",""value"": 10000},""expiresAt"": ""2023-04-06T17:11:15+02:00"",""id"": ""CS0068299CB8DA273A"",""merchantAccount"": ""TestMerchantAccount"",""reference"": ""TestReference"",""returnUrl"": ""http://test-url.com"",""sessionData"": ""Ab02b4c0!BQABAgBoacRJuRbNM/typUKATopkZ3V+cINm0WTAvwl9uQJ2e8I00P2KFemlwp4nb1bOqqYh1zx48gDAHt0QDs2JTiQIqDQRizqopLFRk/wAJHFoCuam/GvOHflg9vwS3caHbkBToIolxcYcJoJheIN9o1fGmNIHZb9VrWfiKsXMgmYsSUifenayS2tkKCTquF7vguaAwk7q5ES1GDwzP/J2mChJGH04jGrVL4szPHGmznr897wIcFQyBSZe4Uifqoe0fpiIxZLNWadLMya6SnvQYNAQL1V6ti+7F4wHHyLwHWTCua993sttue70TE4918EV80HcAWx0LE1+uW6J5KBHCKdYNi9ESlGSZreRwLCpdNbmumB6MlyHZlz2umLiw0ZZJAEpdrwXA2NiyHzJDKDKfbAhd8uoTSACrbgwbrAXI1cvb1WjiOQjLn9MVW++fuJCq6vIeX+rUKMeltBAHMeBZyC54ndAucw9nS03uyckjphunE4tl4WTT475VkfUiyJCTT3S2IOVYS9V9M8pMQ1/GlDVNCLBJJfrYlVXoC8VX68QW1HERkhNYQbTgLQ9kI3cDeMP5d4TuUL3XR2Q6sNiOMdIPGDYQ9QFKFdOE3OQ5X9wxUYbX6j88wR2gRGJcS5agqFHOR1ZTNrjumOYrEkjL8ehFXEs/KluhURllfi0POUPGAwlUWBjDCZcKaeeR0kASnsia2V5IjoiQUYwQUFBMTAzQ0E1MzdFQUVEODdDMjRERDUzOTA5QjgwQTc4QTkyM0UzODIzRDY4REFDQzk0QjlGRjgzMDVEQyJ9E0Gs1T0RaO7NluuXP59fegcW6SQKq4BhC3ZzEKPm1vJuwAJ2gZUaicaXbRPW3IyadavKRlfGdFeAYt2B3ik8fGiK3ZkKU0CrZ0qL0IO5rrWrOg74HMnpxRAn1RhAHRHfGEk67FFPNjr0aLBJXSia7xZWiyKA+i4QU63roY2sxMI/q41mvJjRUz0rPKT3SbVDt1Of7K7BP8cmiboBkWexFBD/mkJyMOpYAOoFp/tKOUHTWZYcc1GpbyV1jInXVfEUhHROYCtS4p/xwF6DdT3bI0+HRU35/xNBTZH2yJN55u9i42Vb0ddCyhzOLZYQ3JVgglty6hLgVeQzuN4b2MoalhfTl11HsElJT1kB0mznVX8CL7UMTUp/2uSgL8DN6kB4owEZ45nWRxIR/2sCidMJ1tnSI1uSqkeqXRf1vat5qPq+BzpYE0Urn2ZZEmgJyb2u0ZLn2x1tfJyPtv+hqBoT7iqJ224dSbuB4HMT49YtcheUtR0jnrImJXm+M1TeIjWB3XWOScrNV8sWEJMAiIU="",""shopperLocale"": ""en-US""}";
            
            // Act
            CreateCheckoutSessionResponse response = JsonSerializer.Deserialize<CreateCheckoutSessionResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response.Id);
        }
        
        [TestMethod]
        public async Task Given_Serialize_When_DeviceRenderOptions_Returns_MultiSelect_And_OtherHtml()
        {
            // Arrange
            DeviceRenderOptions deviceRenderOptions = new DeviceRenderOptions
            {
                SdkInterface = DeviceRenderOptions.SdkInterfaceEnum.Native, 
                SdkUiType = new List<DeviceRenderOptions.SdkUiTypeEnum>()
                {
                    DeviceRenderOptions.SdkUiTypeEnum.MultiSelect, 
                    DeviceRenderOptions.SdkUiTypeEnum.OtherHtml
                }
            };
            
            // Act
            string result = JsonSerializer.Serialize(deviceRenderOptions, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement root = json.RootElement;
            
            JsonElement sdkInterface = root.GetProperty("sdkInterface");
            Assert.AreEqual("native", sdkInterface.GetString());
            
            JsonElement sdkUiTypes = root.GetProperty("sdkUiType");
            Assert.AreEqual("multiSelect", sdkUiTypes[0].GetString());
            Assert.AreEqual("otherHtml", sdkUiTypes[1].GetString());
        }
        
        [TestMethod]
        public async Task Given_Byte_Array_When_Serialize_Returns_Not_Null()
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
        public async Task Given_Byte_Array_When_Deserialize_Result_ThreeDSecureData_Should_Deserialize_Correctly()
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
        public async Task Given_ConfigureCheckout_When_Timeout_Is_Provided_Then_Timeout_Is_Set()
        {
            // Arrange
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });

                    services.AddPaymentsService(httpClientOptions: 
                        clientOptions => clientOptions.Timeout = TimeSpan.FromSeconds(42));
                })
                .Build();

            // Act
            var httpClient = testHost.Services.GetService<IPaymentsService>().HttpClient;
            
            // Assert
            Assert.AreEqual(httpClient.Timeout, TimeSpan.FromSeconds(42));
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

        [TestMethod]
        public async Task Given_IPaymentsService_When_Live_Url_And_Prefix_Are_Set_Returns_Correct_Live_Url_Endpoint_And_No_Prefix()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "your-live-api-key";
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                    
                    services.AddPaymentsService();
                })
                .Build();
            
            // Act
            var paymentsService = liveHost.Services.GetRequiredService<IPaymentsService>();

            // Assert
            Assert.AreEqual("https://prefix-checkout-live.adyenpayments.com/checkout/v71", paymentsService.HttpClient.BaseAddress.ToString());
        }
         
        [TestMethod]
        public async Task Given_IPaymentsService_When_Test_Url_Returns_Correct_Test_Url_Endpoint_And_No_Prefix()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    
                    services.AddPaymentsService();
                })
                .Build();
            
            // Act
            var paymentsService = liveHost.Services.GetRequiredService<IPaymentsService>();

            // Assert
            Assert.AreEqual("https://checkout-test.adyen.com/v71", paymentsService.HttpClient.BaseAddress.ToString());
        }
        
        [TestMethod]
        public async Task Given_IPaymentsService_When_Live_Url_And_Prefix_Not_Set_Throws_InvalidOperationException()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "your-live-api-key";
                        options.Environment = AdyenEnvironment.Live;
                    });
                })
                .Build();
            
            // Act
            // Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                liveHost.Services.GetRequiredService<IPaymentsService>();
            });
        }
        
        [TestMethod]
        public async Task Given_ConfigureCheckout_When_Live_Url_And_Prefix_Not_Set_Throws_InvalidOperationException()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                    });
                })
                .Build();
            
            // Act
            // Assert
            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IDonationsService>()
                );

            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IModificationsService>()
                );

            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IOrdersService>()
                );

            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IPaymentLinksService>()
                );

            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IPaymentsService>()
                );

            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IRecurringService>()
                );

            Assert.Throws<InvalidOperationException>(() =>
                liveHost.Services.GetRequiredService<IUtilityService>()
                );
        }
        
        [TestMethod]
        public async Task Given_Serialize_When_PaymentRequest_AccountInfo_Is_Set_To_Null_Explicitly_Result_Is_Null()
        {
            // Arrange
            var cardDetails = new CardDetails
            {
                Type = CardDetails.TypeEnum.Card
            };

            var accountInfoNullObject = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000), reference: "ACH test",
                paymentMethod: new CheckoutPaymentMethod(cardDetails),
                shopperIP: "192.0.2.1",
                channel: PaymentRequest.ChannelEnum.Web, origin: "https://your-company.com",
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy..",
                accountInfo: null // Set `AccountInfo` explicitly to null
            );
            
            
            var accountInfoNotPresentObject = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000), reference: "ACH test",
                paymentMethod: new CheckoutPaymentMethod(cardDetails),
                shopperIP: "192.0.2.1",
                channel: PaymentRequest.ChannelEnum.Web, origin: "https://your-company.com",
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy.."
                //accountInfo: ... // AccountInfo (key) is not present
            );
            
            // Act
            string accountInfoNullSerializedObject = JsonSerializer.Serialize(accountInfoNullObject, _jsonSerializerOptionsProvider.Options);
            string accountInfoNotPresentSerializedObject = JsonSerializer.Serialize(accountInfoNotPresentObject, _jsonSerializerOptionsProvider.Options);
            using var accountInfoNull = JsonDocument.Parse(accountInfoNullSerializedObject);
            using var accountInfoNotPresent = JsonDocument.Parse(accountInfoNotPresentSerializedObject);

            // Assert
            // AccountInfo is set, so the key `accountInfo` should have the value of { "accountInfo": null }
            Assert.AreEqual(null, accountInfoNull.RootElement.GetProperty("accountInfo").GetString());
            
            // AccountInfo is not set, so the key `accountInfo` should not be present in the serialized result.
            Assert.IsFalse(accountInfoNotPresent.RootElement.TryGetProperty("accountInfo", out _));
        }
        
        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_AchDetails_Result_Is_Not_Null()
        {
            // Arrange
            var achDetails = new AchDetails
            {
                Type = AchDetails.TypeEnum.Ach,
                BankAccountNumber = "1234567",
                BankLocationId = "1234567",
                EncryptedBankAccountNumber = "1234asdfg",
                OwnerName = "John Smith"
            };

            var paymentRequest = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000), reference: "ACH test",
                paymentMethod: new CheckoutPaymentMethod(achDetails),
                shopperIP: "192.0.2.1",
                channel: PaymentRequest.ChannelEnum.Web, origin: "https://your-company.com",
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy.."
            );
            
            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("ach", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("1234567", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("bankAccountNumber").GetString());
            Assert.AreEqual("1234567", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("bankLocationId").GetString());
            Assert.AreEqual("1234asdfg", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("encryptedBankAccountNumber").GetString());
            Assert.AreEqual("John Smith", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("ownerName").GetString());

            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("ACH test", jsonDoc.RootElement.GetProperty("reference").GetString());
            Assert.AreEqual("https://your-company.com/checkout?shopperOrder=12xy..", jsonDoc.RootElement.GetProperty("returnUrl").GetString());
        }

        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_ApplePayDetails_Result_Is_Not_Null()
        {
            // Arrange
            var applePay = new ApplePayDetails(
                type: ApplePayDetails.TypeEnum.Applepay,
                applePayToken: "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU..."
            );

            var paymentRequest = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000),
                reference: "apple pay test",
                paymentMethod: new CheckoutPaymentMethod(applePay),
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy.."
            );
            
            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("applepay", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("applePayToken").GetString());

            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("apple pay test", jsonDoc.RootElement.GetProperty("reference").GetString());
            Assert.AreEqual("https://your-company.com/checkout?shopperOrder=12xy..", jsonDoc.RootElement.GetProperty("returnUrl").GetString());
        }

        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_GooglePayDetails_Result_Is_Not_Null()
        {
            // Arrange
            var paymentRequest = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000),
                reference: "google pay test",
                paymentMethod: new CheckoutPaymentMethod(
                    new GooglePayDetails(
                        type: GooglePayDetails.TypeEnum.Googlepay,
                        googlePayToken: "==Payload as retrieved from Google Pay response==",
                        fundingSource: GooglePayDetails.FundingSourceEnum.Debit
                    )
                ),
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy..");

            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("googlepay", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("==Payload as retrieved from Google Pay response==", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("googlePayToken").GetString());
            Assert.AreEqual("debit", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("fundingSource").GetString());

            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("google pay test", jsonDoc.RootElement.GetProperty("reference").GetString());
            Assert.AreEqual("https://your-company.com/checkout?shopperOrder=12xy..", jsonDoc.RootElement.GetProperty("returnUrl").GetString());
        }

        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_iDEAL_Result_Is_Not_Null()
        {
            // Arrange
            var paymentRequest = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000),
                reference: "ideal test",
                paymentMethod: new CheckoutPaymentMethod(new IdealDetails(
                    type: IdealDetails.TypeEnum.Ideal,
                    issuer: "1121")
                ),
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy..");

            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("ideal", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("ideal test", jsonDoc.RootElement.GetProperty("reference").GetString());
            Assert.AreEqual("https://your-company.com/checkout?shopperOrder=12xy..", jsonDoc.RootElement.GetProperty("returnUrl").GetString());
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("accountInfo", out _)); // null
        }

        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_BacsDirectDebitDetails_Result_Is_Not_Null()
        {
            // Arrange
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("GBP", 1000),
                Reference = "bacs direct debit test",
                PaymentMethod = new CheckoutPaymentMethod(new BacsDirectDebitDetails
                {
                    Type = BacsDirectDebitDetails.TypeEnum.DirectdebitGB,
                    BankAccountNumber = "NL0123456789",
                    BankLocationId = "121000358",
                    HolderName = "John Smith"
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            JsonElement element = jsonDoc.RootElement.GetProperty("paymentMethod");
            Assert.AreEqual("directdebit_GB", element.GetProperty("type").GetString());
            Assert.AreEqual("NL0123456789", element.GetProperty("bankAccountNumber").GetString());
            Assert.AreEqual("121000358", element.GetProperty("bankLocationId").GetString());
            Assert.AreEqual("John Smith", element.GetProperty("holderName").GetString());

            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("bacs direct debit test", jsonDoc.RootElement.GetProperty("reference").GetString());
            Assert.AreEqual("https://your-company.com/checkout?shopperOrder=12xy..", jsonDoc.RootElement.GetProperty("returnUrl").GetString());
        }

        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_PayPalDetails_Result_Is_Not_Null()
        {
            // Arrange
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("USD", 1000),
                Reference = "paypal test",
                PaymentMethod = new CheckoutPaymentMethod(new PayPalDetails
                {
                    Type = PayPalDetails.TypeEnum.Paypal,
                    Subtype = PayPalDetails.SubtypeEnum.Sdk,
                    StoredPaymentMethodId = "2345654212345432345"
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            JsonElement element = jsonDoc.RootElement.GetProperty("paymentMethod");

            Assert.AreEqual("paypal", element.GetProperty("type").GetString());
            Assert.AreEqual("sdk", element.GetProperty("subtype").GetString());
        }

        [TestMethod]
        public async Task Given_Serialize_When_PaymentMethod_Is_ZipDetails_Result_Is_Not_Null()
        {
            // Arrange
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("USD", 1000),
                Reference = "zip test",
                PaymentMethod = new CheckoutPaymentMethod(new ZipDetails
                {
                    Type = ZipDetails.TypeEnum.Zip
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentRequest, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("zip", jsonDoc.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", jsonDoc.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("zip test", jsonDoc.RootElement.GetProperty("reference").GetString());
            Assert.AreEqual("https://your-company.com/checkout?shopperOrder=12xy..", jsonDoc.RootElement.GetProperty("returnUrl").GetString());
        }

        // test oneOf deserialization in CheckoutPaymentRequest
        [TestMethod]
        public async Task Given_Deserialize_When_PaymentRequest_OneOf_Then_Result_Is_PaymentRequestIdeal()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-request-ideal.json");
            
            // Act
            PaymentRequest result = JsonSerializer.Deserialize<PaymentRequest>(json, _jsonSerializerOptionsProvider.Options);

            // Act
            Assert.IsNotNull(result.PaymentMethod);
            Assert.IsNotNull(result.PaymentMethod.IdealDetails);
            Assert.AreEqual(IdealDetails.TypeEnum.Ideal, result.PaymentMethod.IdealDetails.Type);
        }
    
        [TestMethod]
        public void Given_NameValueCollectionWithNullValue_When_ParameterToString_Then_KeyIsPreserved()
        {
            // Arrange - add a key with an explicit null value to simulate a bare parameter
            var nvc = new System.Collections.Specialized.NameValueCollection();
            nvc.Add("param", null);
            nvc.Add("key", "value");

            // Act
            var result = ClientUtils.ParameterToString(nvc);

            // Assert - null-valued parameter should appear as 'param=' rather than being dropped
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains("param="), $"Expected 'param=' to be present, but result was: {result}");
            Assert.IsTrue(result.Contains("key=value"), $"Expected 'key=value' to be present, but result was: {result}");
        }

        [TestMethod]
        public void Given_NameValueCollectionWithSpecialChars_When_ParameterToString_Then_StructuralCharsAreEncoded()
        {
            // Arrange - only structural characters (&, =, #, space) should be percent-encoded;
            // other characters like +, /, ! must remain unencoded (minimal encoding approach,
            // matching Java's URIBuilder.addParameter behaviour).
            var nvc = new System.Collections.Specialized.NameValueCollection();
            nvc.Add("account", "test&merchant=1");
            nvc.Add("ref", "order 123");
            nvc.Add("token", "abc+def/ghi!jkl#end");

            // Act
            var result = ClientUtils.ParameterToString(nvc);

            // Assert - & = # and space are percent-encoded
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains("account=test%26merchant%3D1"),
                $"Expected '&' and '=' to be percent-encoded in value, but result was: {result}");
            Assert.IsTrue(result.Contains("ref=order%20123"),
                $"Expected space to be percent-encoded in value, but result was: {result}");
            Assert.IsTrue(result.Contains("token=abc+def/ghi!jkl%23end"),
                $"Expected +, /, ! to remain unencoded and # to be encoded, but result was: {result}");
        }

        [TestMethod]
        public void Given_NameValueCollectionWithPercentEncoded_When_ParameterToString_Then_PercentIsPassedThrough()
        {
            // Arrange - values that already contain percent-encoded sequences (e.g. from opaque
            // tokens) must not be double-encoded: %26 should stay as %26, not become %2526.
            var nvc = new System.Collections.Specialized.NameValueCollection();
            nvc.Add("token", "already%26encoded%20value");

            // Act
            var result = ClientUtils.ParameterToString(nvc);

            // Assert - % is not encoded, so existing percent sequences pass through unchanged
            Assert.IsNotNull(result);
            Assert.AreEqual("token=already%26encoded%20value", result,
                $"Expected percent-encoded sequences to pass through unchanged, but result was: {result}");
        }

        [TestMethod]
        public void Given_NameValueCollectionWithEmptyValue_When_ParameterToString_Then_KeyIsPreservedWithEquals()
        {
            // Arrange - empty string value should produce "key=" in the query string
            var nvc = new System.Collections.Specialized.NameValueCollection();
            nvc.Add("emptyParam", "");
            nvc.Add("normalParam", "hello");

            // Act
            var result = ClientUtils.ParameterToString(nvc);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("emptyParam=&normalParam=hello", result,
                $"Expected 'emptyParam=' followed by 'normalParam=hello', but result was: {result}");
        }

        [TestMethod]
        public void Given_NameValueCollectionWithMultipleValuesForSameKey_When_ParameterToString_Then_ValuesAreMerged()
        {
            // Arrange - NameValueCollection merges multiple values for the same key with commas
            var nvc = new System.Collections.Specialized.NameValueCollection();
            nvc.Add("status", "active");
            nvc.Add("status", "pending");

            // Act
            var result = ClientUtils.ParameterToString(nvc);

            // Assert - NameValueCollection joins multiple values with comma
            Assert.IsNotNull(result);
            Assert.AreEqual("status=active,pending", result,
                $"Expected comma-separated values for duplicate key, but result was: {result}");
        }

        [TestMethod]
        public void Given_PaymentResponse_When_ActionIsThreeDS2Fingerprint_Then_Deserializes_Correctly()
        {
            // Arrange
            string json = @"{
                ""action"": {
                    ""type"": ""threeDS2"",
                    ""subtype"": ""fingerprint"",
                    ""paymentData"": ""test-payment-data"",
                    ""paymentMethodType"": ""scheme"",
                    ""authorisationToken"": ""test-authorisation-token"",
                    ""token"": ""test-token""
                },
                ""resultCode"": ""IdentifyShopper""
            }";

            // Act
            PaymentResponse result = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.IdentifyShopper, result.ResultCode);
            Assert.IsNotNull(result.Action);
            Assert.IsNotNull(result.Action.CheckoutThreeDS2Action);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, result.Action.CheckoutThreeDS2Action.Type);
            Assert.AreEqual("fingerprint", result.Action.CheckoutThreeDS2Action.Subtype);
            Assert.AreEqual("test-payment-data", result.Action.CheckoutThreeDS2Action.PaymentData);
            Assert.AreEqual("scheme", result.Action.CheckoutThreeDS2Action.PaymentMethodType);
            Assert.AreEqual("test-authorisation-token", result.Action.CheckoutThreeDS2Action.AuthorisationToken);
            Assert.AreEqual("test-token", result.Action.CheckoutThreeDS2Action.Token);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_ActionIsRedirectShopper_Then_Deserializes_Correctly()
        {
            // Arrange
            string json = @"{
                ""resultCode"": ""RedirectShopper"",
                ""action"": {
                    ""paymentMethodType"": ""scheme"",
                    ""url"": ""https://checkoutshopper-test.adyen.com/checkoutshopper/identifyShopper.shtml"",
                    ""data"": {
                        ""MD"": ""test-md-value"",
                        ""PaReq"": ""test-pareq-value""
                    },
                    ""method"": ""POST"",
                    ""type"": ""redirect""
                }
            }";

            // Act
            PaymentResponse result = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.RedirectShopper, result.ResultCode);
            Assert.IsNotNull(result.Action);
            Assert.IsNotNull(result.Action.CheckoutRedirectAction);
            Assert.AreEqual(CheckoutRedirectAction.TypeEnum.Redirect, result.Action.CheckoutRedirectAction.Type);
            Assert.AreEqual("scheme", result.Action.CheckoutRedirectAction.PaymentMethodType);
            Assert.AreEqual("https://checkoutshopper-test.adyen.com/checkoutshopper/identifyShopper.shtml", result.Action.CheckoutRedirectAction.Url);
            Assert.AreEqual("POST", result.Action.CheckoutRedirectAction.Method);
            Assert.IsNotNull(result.Action.CheckoutRedirectAction.Data);
            Assert.AreEqual("test-md-value", result.Action.CheckoutRedirectAction.Data["MD"]);
            Assert.AreEqual("test-pareq-value", result.Action.CheckoutRedirectAction.Data["PaReq"]);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_ActionIsThreeDS2Fingerprint_Then_Serializes_Correctly()
        {
            // Arrange
            var paymentResponse = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.IdentifyShopper,
                Action = new PaymentResponseAction(new CheckoutThreeDS2Action(
                    type: CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    subtype: new Option<string?>("fingerprint"),
                    paymentData: new Option<string?>("test-payment-data"),
                    paymentMethodType: new Option<string?>("scheme"),
                    authorisationToken: new Option<string?>("test-authorisation-token"),
                    token: new Option<string?>("test-token")
                ))
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentResponse, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);
            JsonElement action = jsonDoc.RootElement.GetProperty("action");

            // Assert
            Assert.AreEqual("IdentifyShopper", jsonDoc.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("threeDS2", action.GetProperty("type").GetString());
            Assert.AreEqual("fingerprint", action.GetProperty("subtype").GetString());
            Assert.AreEqual("test-payment-data", action.GetProperty("paymentData").GetString());
            Assert.AreEqual("scheme", action.GetProperty("paymentMethodType").GetString());
            Assert.AreEqual("test-authorisation-token", action.GetProperty("authorisationToken").GetString());
            Assert.AreEqual("test-token", action.GetProperty("token").GetString());
        }

        [TestMethod]
        public void Given_PaymentResponse_When_ActionIsRedirectShopper_Then_Serializes_Correctly()
        {
            // Arrange
            var paymentResponse = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.RedirectShopper,
                Action = new PaymentResponseAction(new CheckoutRedirectAction(
                    type: CheckoutRedirectAction.TypeEnum.Redirect,
                    paymentMethodType: new Option<string?>("scheme"),
                    url: new Option<string?>("https://checkoutshopper-test.adyen.com/checkoutshopper/identifyShopper.shtml"),
                    method: new Option<string?>("POST"),
                    data: new Option<Dictionary<string, string>?>(new Dictionary<string, string>
                    {
                        { "MD", "test-md-value" },
                        { "PaReq", "test-pareq-value" }
                    })
                ))
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentResponse, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);
            JsonElement action = jsonDoc.RootElement.GetProperty("action");

            // Assert
            Assert.AreEqual("RedirectShopper", jsonDoc.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("redirect", action.GetProperty("type").GetString());
            Assert.AreEqual("scheme", action.GetProperty("paymentMethodType").GetString());
            Assert.AreEqual("https://checkoutshopper-test.adyen.com/checkoutshopper/identifyShopper.shtml", action.GetProperty("url").GetString());
            Assert.AreEqual("POST", action.GetProperty("method").GetString());
            Assert.AreEqual("test-md-value", action.GetProperty("data").GetProperty("MD").GetString());
            Assert.AreEqual("test-pareq-value", action.GetProperty("data").GetProperty("PaReq").GetString());
        }

        [TestMethod]
        public void Given_PaymentResponse_When_ActionIsThreeDS2Challenge_Then_Deserializes_Correctly()
        {
            // Arrange
            string json = @"{
                ""action"": {
                    ""type"": ""threeDS2"",
                    ""subtype"": ""challenge"",
                    ""paymentData"": ""test-payment-data"",
                    ""paymentMethodType"": ""scheme"",
                    ""authorisationToken"": ""test-authorisation-token"",
                    ""token"": ""test-token""
                },
                ""resultCode"": ""ChallengeShopper""
            }";

            // Act
            PaymentResponse result = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.ChallengeShopper, result.ResultCode);
            Assert.IsNotNull(result.Action);
            Assert.IsNotNull(result.Action.CheckoutThreeDS2Action);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, result.Action.CheckoutThreeDS2Action.Type);
            Assert.AreEqual("challenge", result.Action.CheckoutThreeDS2Action.Subtype);
            Assert.AreEqual("test-payment-data", result.Action.CheckoutThreeDS2Action.PaymentData);
            Assert.AreEqual("scheme", result.Action.CheckoutThreeDS2Action.PaymentMethodType);
            Assert.AreEqual("test-authorisation-token", result.Action.CheckoutThreeDS2Action.AuthorisationToken);
            Assert.AreEqual("test-token", result.Action.CheckoutThreeDS2Action.Token);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_ActionIsThreeDS2Challenge_Then_Serializes_Correctly()
        {
            // Arrange
            var paymentResponse = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.ChallengeShopper,
                Action = new PaymentResponseAction(new CheckoutThreeDS2Action(
                    type: CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    subtype: new Option<string?>("challenge"),
                    paymentData: new Option<string?>("test-payment-data"),
                    paymentMethodType: new Option<string?>("scheme"),
                    authorisationToken: new Option<string?>("test-authorisation-token"),
                    token: new Option<string?>("test-token")
                ))
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentResponse, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);
            JsonElement action = jsonDoc.RootElement.GetProperty("action");

            // Assert
            Assert.AreEqual("ChallengeShopper", jsonDoc.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("threeDS2", action.GetProperty("type").GetString());
            Assert.AreEqual("challenge", action.GetProperty("subtype").GetString());
            Assert.AreEqual("test-payment-data", action.GetProperty("paymentData").GetString());
            Assert.AreEqual("scheme", action.GetProperty("paymentMethodType").GetString());
            Assert.AreEqual("test-authorisation-token", action.GetProperty("authorisationToken").GetString());
            Assert.AreEqual("test-token", action.GetProperty("token").GetString());
        }

        [TestMethod]
        public void Given_PaymentResponse_When_Authorised_Then_Deserializes_Correctly()
        {
            // Arrange
            string json = @"{
                ""resultCode"": ""Authorised"",
                ""pspReference"": ""test-psp-reference"",
                ""merchantReference"": ""test-merchant-reference""
            }";

            // Act
            PaymentResponse result = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.Authorised, result.ResultCode);
            Assert.AreEqual("test-psp-reference", result.PspReference);
            Assert.AreEqual("test-merchant-reference", result.MerchantReference);
            Assert.IsNull(result.Action);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_Authorised_Then_Serializes_Correctly()
        {
            // Arrange
            var paymentResponse = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.Authorised,
                PspReference = "test-psp-reference",
                MerchantReference = "test-merchant-reference"
            };

            // Act
            string serialized = JsonSerializer.Serialize(paymentResponse, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(serialized);

            // Assert
            Assert.AreEqual("Authorised", jsonDoc.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("test-psp-reference", jsonDoc.RootElement.GetProperty("pspReference").GetString());
            Assert.AreEqual("test-merchant-reference", jsonDoc.RootElement.GetProperty("merchantReference").GetString());
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("action", out _),
                "action must not be present when not set");
        }

        [TestMethod]
        public void Given_PaymentResponse_When_RoundTrip_ThreeDS2_Then_ActionIsFlatAndNullFieldsAreOmitted()
        {
            // Arrange - minimal JSON as returned by the Adyen API
            string apiJson = @"{
                ""resultCode"": ""IdentifyShopper"",
                ""action"": {
                    ""type"": ""threeDS2"",
                    ""subtype"": ""fingerprint"",
                    ""paymentData"": ""test-payment-data"",
                    ""paymentMethodType"": ""scheme"",
                    ""authorisationToken"": ""test-authorisation-token"",
                    ""token"": ""test-token""
                },
                ""pspReference"": ""test-psp-reference""
            }";

            // Act
            PaymentResponse deserialized = JsonSerializer.Deserialize<PaymentResponse>(apiJson, _jsonSerializerOptionsProvider.Options);
            string reserialized = JsonSerializer.Serialize(deserialized, _jsonSerializerOptionsProvider.Options);
            using var jsonDoc = JsonDocument.Parse(reserialized);
            JsonElement action = jsonDoc.RootElement.GetProperty("action");

            // Assert - action must be flat (type at root), not nested under checkoutThreeDS2Action
            Assert.AreEqual("threeDS2", action.GetProperty("type").GetString());
            Assert.IsFalse(action.TryGetProperty("checkoutThreeDS2Action", out _),
                "action must not have a nested 'checkoutThreeDS2Action' property");

            // Assert - optional null fields must be omitted, not serialized as null
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("amount", out _));
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("donationToken", out _));
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("fraudResult", out _));
            Assert.IsFalse(jsonDoc.RootElement.TryGetProperty("merchantReference", out _));
        }

    }
}