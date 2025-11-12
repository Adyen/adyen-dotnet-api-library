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
using NSubstitute;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class PaymentsTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IPaymentsService _paymentsService;

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
            _paymentsService = Substitute.For<IPaymentsService>();
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
                }, client =>
                {
                    client.Timeout = TimeSpan.FromSeconds(42);
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
        public void Given_PaymentRequest_When_PaymentMethod_Is_AchDetails_Result_Is_Not_Null()
        {
            // Arrange
            // Act
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
            
            // Assert
            AchDetails paymentMethodDetails = paymentRequest.PaymentMethod.AchDetails;
            Assert.AreEqual(paymentMethodDetails.Type, AchDetails.TypeEnum.Ach);
            Assert.AreEqual(paymentMethodDetails.BankAccountNumber, "1234567");
            Assert.AreEqual(paymentMethodDetails.BankLocationId, "1234567");
            Assert.AreEqual(paymentMethodDetails.EncryptedBankAccountNumber, "1234asdfg");
            Assert.AreEqual(paymentMethodDetails.OwnerName, "John Smith");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "ACH test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }
        
        [TestMethod]
        public void Given_PaymentRequest_When_PaymentMethod_Is_ApplePayDetails_Result_Is_Not_Null()
        {
            // Arrange
            // Act
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
            
            // Assert
            ApplePayDetails paymentMethodDetails = paymentRequest.PaymentMethod.ApplePayDetails;
            Assert.AreEqual(paymentMethodDetails.Type, ApplePayDetails.TypeEnum.Applepay);
            Assert.AreEqual(paymentMethodDetails.ApplePayToken, "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "apple pay test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void Given_PaymentRequest_When_PaymentMethod_Is_GooglePayDetails_Result_Is_Not_Null()
        {
            // Arrange
            // Act
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
            
            // Assert
            GooglePayDetails paymentMethodDetails = paymentRequest.PaymentMethod.GooglePayDetails;
            Assert.AreEqual(paymentMethodDetails.Type, GooglePayDetails.TypeEnum.Googlepay);
            Assert.AreEqual(paymentMethodDetails.GooglePayToken, "==Payload as retrieved from Google Pay response==");
            Assert.AreEqual(paymentMethodDetails.FundingSource, GooglePayDetails.FundingSourceEnum.Debit);
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "google pay test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void Given_PaymentRequest_When_PaymentMethod_Is_iDEAL_Result_Is_Not_Null()
        {
            // Arrange
            // Act
            var paymentRequest = new PaymentRequest(
                merchantAccount: "YOUR_MERCHANT_ACCOUNT",
                amount: new Amount("EUR", 1000),
                reference: "ideal test",
                paymentMethod: new CheckoutPaymentMethod(new IdealDetails(
                    type: IdealDetails.TypeEnum.Ideal,
                    issuer: "1121")
                ),
                returnUrl: "https://your-company.com/checkout?shopperOrder=12xy.." );
            
            // Assert
            IdealDetails paymentMethodDetails = paymentRequest.PaymentMethod.IdealDetails;
            Assert.AreEqual(paymentMethodDetails.Type, IdealDetails.TypeEnum.Ideal);
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "ideal test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void Given_PaymentRequest_When_PaymentMethod_Is_BacsDirectDebitDetails_Result_Is_Not_Null()
        {
            // Arrange
            // Act
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
            
            // Assert
            BacsDirectDebitDetails paymentMethodDetails = paymentRequest.PaymentMethod.BacsDirectDebitDetails;
            Assert.AreEqual(paymentMethodDetails.Type, BacsDirectDebitDetails.TypeEnum.DirectdebitGB);
            Assert.AreEqual(paymentMethodDetails.BankAccountNumber, "NL0123456789");
            Assert.AreEqual(paymentMethodDetails.BankLocationId, "121000358");
            Assert.AreEqual(paymentMethodDetails.HolderName, "John Smith");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "bacs direct debit test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }


        [TestMethod]
        public void Given_PaymentRequest_When_PaymentMethod_Is_PayPalDetails_Result_Is_Not_Null()
        {
            // Arrange
            // Act
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
            
            // Assert
            PayPalDetails paymentMethodDetails = paymentRequest.PaymentMethod.PayPalDetails;
            Assert.AreEqual(paymentMethodDetails.Type, PayPalDetails.TypeEnum.Paypal);
            Assert.AreEqual(paymentMethodDetails.Subtype, PayPalDetails.SubtypeEnum.Sdk);
        }
        
        [TestMethod]
        public void Given_PaymentRequest_When_PaymentMethod_Is_ZipDetails_Result_Is_Not_Null()
        {
            // Arrange
            // Act
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
            
            // Assert
            ZipDetails paymentMethodDetails = paymentRequest.PaymentMethod.ZipDetails;
            Assert.AreEqual(paymentMethodDetails.Type, ZipDetails.TypeEnum.Zip);
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "zip test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }
        
        // test oneOf deserialization in CheckoutPaymentRequest
        [TestMethod]
        public async Task Given_PaymentRequest_When_Deserialized_Then_Result_Is_PaymentRequestIdeal()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-request-ideal.json");
            // Act
            PaymentRequest result = JsonSerializer.Deserialize<PaymentRequest>(json, _jsonSerializerOptionsProvider.Options);

            /// Act
            Assert.IsNotNull(result.PaymentMethod);
            Assert.IsNotNull(result.PaymentMethod.IdealDetails);
            Assert.AreEqual(IdealDetails.TypeEnum.Ideal, result.PaymentMethod.IdealDetails.Type);
        }
    
        [TestMethod]
        public void SessionsAsyncTest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/sessions-success.json");
            
            var createCheckoutSessionRequest = new CreateCheckoutSessionRequest(
                amount: new Amount("EUR", 10000L),
                merchantAccount: "TestMerchantAccount",
                reference: "TestReference",
                returnUrl: "http://test-url.com",
                channel: CreateCheckoutSessionRequest.ChannelEnum.Web,
                countryCode: "NL"
            );

            _paymentsService.SessionsAsync(
                    Arg.Any<Option<string>>(),
                    Arg.Any<Option<CreateCheckoutSessionRequest>>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<ISessionsApiResponse>(
                        new PaymentsService.SessionsApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<PaymentsService.SessionsApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.Created },
                            json,
                            "/sessions",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = _paymentsService.SessionsAsync("idempotencyKey", new Option<CreateCheckoutSessionRequest>(createCheckoutSessionRequest), CancellationToken.None).Result;

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.IsTrue(response.IsCreated);
            var sessionResponse = response.Created();
            Assert.IsNotNull(sessionResponse);
            Assert.AreEqual("CS0068299CB8DA273A", sessionResponse.Id);
        }
    
    }
    
}