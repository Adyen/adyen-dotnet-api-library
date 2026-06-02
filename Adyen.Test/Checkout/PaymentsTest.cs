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
            CreateCheckoutSessionRequest checkoutSessionRequest = new CreateCheckoutSessionRequest
            {
                Amount = new Amount { Currency = "EUR", Value = 10000L },
                MerchantAccount = "merchantAccount",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Channel = CreateCheckoutSessionRequest.ChannelEnum.Web,
                CountryCode = "NL",
                LineItems = new List<LineItem>() {
                    new LineItem { Quantity = 1, AmountIncludingTax = 5000, Description = "description1", AmountExcludingTax = 0 },
                    new LineItem { Quantity = 1, AmountIncludingTax = 5000, Description = "description2", TaxAmount = 0 }
                },
            };
            
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
            string json = @"{""mode"": ""embedded"",""amount"": {""currency"": ""EUR"",""value"": 10000},""expiresAt"": ""2023-04-06T17:11:15+02:00"",""id"": ""CS0068299CB8DA273A"",""merchantAccount"": ""TestMerchantAccount"",""reference"": ""TestReference"",""returnUrl"": ""http://test-url.com"",""sessionData"": ""test-session-data"",""shopperLocale"": ""en-US""}";
            
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

            var accountInfoNullObject = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ACH test",
                PaymentMethod = new CheckoutPaymentMethod(cardDetails),
                ShopperIP = "192.0.2.1",
                Channel = PaymentRequest.ChannelEnum.Web,
                Origin = "https://your-company.com",
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
                AccountInfo = null // Set `AccountInfo` explicitly to null,
            };
            
            
            var accountInfoNotPresentObject = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ACH test",
                PaymentMethod = new CheckoutPaymentMethod(cardDetails),
                ShopperIP = "192.0.2.1",
                Channel = PaymentRequest.ChannelEnum.Web,
                Origin = "https://your-company.com",
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
                //accountInfo: ... // AccountInfo (key) is not present,
            };
            
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

            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ACH test",
                PaymentMethod = new CheckoutPaymentMethod(achDetails),
                ShopperIP = "192.0.2.1",
                Channel = PaymentRequest.ChannelEnum.Web,
                Origin = "https://your-company.com",
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };
            
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
            var applePay = new ApplePayDetails
            {
                Type = ApplePayDetails.TypeEnum.Applepay,
                ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...",
            };

            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "apple pay test",
                PaymentMethod = new CheckoutPaymentMethod(applePay),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };
            
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
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "google pay test",
                PaymentMethod = new CheckoutPaymentMethod(
                    new GooglePayDetails
                    {
                        Type = GooglePayDetails.TypeEnum.Googlepay,
                        GooglePayToken = "==Payload as retrieved from Google Pay response==",
                        FundingSource = GooglePayDetails.FundingSourceEnum.Debit,
                    }
                ),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

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
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ideal test",
                PaymentMethod = new CheckoutPaymentMethod(new IdealDetails
                {
                    Type = IdealDetails.TypeEnum.Ideal,
                    Issuer = "1121",
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

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
                Amount = new Amount { Currency = "GBP", Value = 1000 },
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
                Amount = new Amount { Currency = "USD", Value = 1000 },
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
                Amount = new Amount { Currency = "USD", Value = 1000 },
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
                Action = new PaymentResponseAction(new CheckoutThreeDS2Action
                {
                    Type = CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    Subtype = "fingerprint",
                    PaymentData = "test-payment-data",
                    PaymentMethodType = "scheme",
                    AuthorisationToken = "test-authorisation-token",
                    Token = "test-token",
                })
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
                Action = new PaymentResponseAction(new CheckoutRedirectAction
                {
                    Type = CheckoutRedirectAction.TypeEnum.Redirect,
                    PaymentMethodType = "scheme",
                    Url = "https://checkoutshopper-test.adyen.com/checkoutshopper/identifyShopper.shtml",
                    Method = "POST",
                    Data = new Dictionary<string, string>
                    {
                        { "MD", "test-md-value" },
                        { "PaReq", "test-pareq-value" }
                    },
                })
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
                Action = new PaymentResponseAction(new CheckoutThreeDS2Action
                {
                    Type = CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    Subtype = "challenge",
                    PaymentData = "test-payment-data",
                    PaymentMethodType = "scheme",
                    AuthorisationToken = "test-authorisation-token",
                    Token = "test-token",
                })
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

        /// <summary>
        /// Regression test for GitHub issue #1474.
        /// Verifies that <see cref="PaymentMethodsResponse"/> can be deserialized using default
        /// <see cref="JsonSerializerOptions"/> without throwing <see cref="InvalidOperationException"/>.
        /// The root cause was a <c>[JsonConstructor]</c> attribute on a constructor whose parameters
        /// used <c>Option&lt;T&gt;</c> types that STJ could not bind to the plain <c>T</c> properties.
        /// </summary>
        [TestMethod]
        public void Given_PaymentMethodsResponse_When_Deserialized_With_Default_Options_Then_Does_Not_Throw()
        {
            // Arrange - minimal repro from issue #1474
            string json = "{\"paymentMethods\":[],\"storedPaymentMethods\":[]}";

            // Act - previously threw InvalidOperationException about [JsonConstructor] parameter binding
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNotNull(result.StoredPaymentMethods);
            Assert.AreEqual(0, result.PaymentMethods.Count);
            Assert.AreEqual(0, result.StoredPaymentMethods.Count);
        }

        /// <summary>
        /// Verifies that <see cref="PaymentMethodsResponse"/> with both payment methods and stored
        /// payment methods deserializes all properties correctly using the SDK's <see cref="JsonSerializerOptions"/>.
        /// </summary>
        [TestMethod]
        public void Given_PaymentMethodsResponse_With_StoredPaymentMethods_When_Deserialized_Then_All_Properties_Are_Populated()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-storedpaymentmethods.json");

            // Act
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNotNull(result.StoredPaymentMethods);
            Assert.AreEqual(3, result.PaymentMethods.Count);
            Assert.AreEqual(4, result.StoredPaymentMethods.Count);
        }

        /// <summary>
        /// Regression test for GitHub issue #1474.
        /// Verifies that <see cref="PaymentMethod"/> can be deserialized using default
        /// <see cref="JsonSerializerOptions"/> without throwing. The <c>[JsonConstructor]</c> regression
        /// affected all Checkout models with optional fields, not only <see cref="PaymentMethodsResponse"/>.
        /// </summary>
        [TestMethod]
        public void Given_PaymentMethod_When_Deserialized_With_Default_Options_Then_Does_Not_Throw()
        {
            // Arrange
            string json = "{\"name\":\"VISA\",\"type\":\"scheme\",\"brands\":[\"visa\",\"mc\"]}";

            // Act
            PaymentMethod result = JsonSerializer.Deserialize<PaymentMethod>(json);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("VISA", result.Name);
            Assert.AreEqual("scheme", result.Type);
            Assert.IsNotNull(result.Brands);
            Assert.AreEqual(2, result.Brands.Count);
        }

        /// <summary>
        /// Verifies that an optional field absent from JSON has <c>Option&lt;T&gt;.IsSet = false</c>,
        /// meaning it is omitted when the object is re-serialized with the SDK's custom converter.
        /// This proves that the property-setter path (used when deserializing without the SDK's
        /// registered converters) correctly tracks which fields were present in the source JSON.
        /// </summary>
        [TestMethod]
        public void Given_PaymentMethodsResponse_When_OptionalFieldAbsent_With_Default_Options_Then_Field_Is_Omitted_On_Reserialize()
        {
            // Arrange - storedPaymentMethods intentionally absent
            string json = "{\"paymentMethods\":[]}";

            // Act - deserialize with default options (no custom converter), then re-serialize with SDK options
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json);
            string reserialized = JsonSerializer.Serialize(result, _jsonSerializerOptionsProvider.Options);

            // Assert - absent field must not appear in the re-serialized output
            using var doc = JsonDocument.Parse(reserialized);
            Assert.IsFalse(doc.RootElement.TryGetProperty("storedPaymentMethods", out _),
                "storedPaymentMethods must be omitted when it was absent in the source JSON");
        }

        /// <summary>
        /// Verifies that an optional field present in JSON has <c>Option&lt;T&gt;.IsSet = true</c>,
        /// meaning it is preserved when the object is re-serialized with the SDK's custom converter.
        /// </summary>
        [TestMethod]
        public void Given_PaymentMethodsResponse_When_OptionalFieldPresent_With_Default_Options_Then_Field_Is_Preserved_On_Reserialize()
        {
            // Arrange - storedPaymentMethods explicitly present as empty array
            string json = "{\"paymentMethods\":[],\"storedPaymentMethods\":[]}";

            // Act - deserialize with default options, then re-serialize with SDK options
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json);
            string reserialized = JsonSerializer.Serialize(result, _jsonSerializerOptionsProvider.Options);

            // Assert - present field must appear in the re-serialized output
            using var doc = JsonDocument.Parse(reserialized);
            Assert.IsTrue(doc.RootElement.TryGetProperty("storedPaymentMethods", out _),
                "storedPaymentMethods must be present when it was in the source JSON");
        }

        /// <summary>
        /// Verifies that an optional field set to JSON <c>null</c> does not throw and yields a
        /// null property value. The property setter must be called (not skipped) for null values.
        /// </summary>
        [TestMethod]
        public void Given_PaymentMethodsResponse_When_OptionalFieldIsExplicitNull_With_Default_Options_Then_Does_Not_Throw()
        {
            // Arrange
            string json = "{\"paymentMethods\":[],\"storedPaymentMethods\":null}";

            // Act
            PaymentMethodsResponse result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.StoredPaymentMethods);
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

        #region PaymentResponse discriminator

        [TestMethod]
        public void Given_Deserialize_When_PaymentResponse_WithRedirectAction_Then_CheckoutRedirectAction_IsPopulated()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-response-redirect-action.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.RedirectShopper, response.ResultCode);
            Assert.IsNotNull(response.Action);
            Assert.IsNotNull(response.Action.CheckoutRedirectAction);
            Assert.IsNull(response.Action.CheckoutThreeDS2Action);
            Assert.IsNull(response.Action.CheckoutSDKAction);
            Assert.AreEqual(CheckoutRedirectAction.TypeEnum.Redirect, response.Action.CheckoutRedirectAction.Type);
            Assert.AreEqual("scheme", response.Action.CheckoutRedirectAction.PaymentMethodType);
            Assert.AreEqual("GET", response.Action.CheckoutRedirectAction.Method);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResponse_WithThreeDS2Action_Then_CheckoutThreeDS2Action_IsPopulated()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-response-threeDS2-action.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.IdentifyShopper, response.ResultCode);
            Assert.IsNotNull(response.Action);
            Assert.IsNotNull(response.Action.CheckoutThreeDS2Action);
            Assert.IsNull(response.Action.CheckoutRedirectAction);
            Assert.IsNull(response.Action.CheckoutSDKAction);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, response.Action.CheckoutThreeDS2Action.Type);
            Assert.AreEqual("scheme", response.Action.CheckoutThreeDS2Action.PaymentMethodType);
            Assert.IsNotNull(response.Action.CheckoutThreeDS2Action.Token);
        }

        [TestMethod]
        public void Given_Serialize_When_PaymentResponse_WithRedirectAction_Then_TypeIsPreserved()
        {
            // Arrange
            var action = new PaymentResponseAction(new CheckoutRedirectAction
            {
                Type = CheckoutRedirectAction.TypeEnum.Redirect,
                PaymentMethodType = "scheme",
                Url = "https://checkoutshopper-test.adyen.com/redirect",
                Method = "GET"
            });
            var response = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.RedirectShopper,
                Action = action
            };

            // Act
            string json = JsonSerializer.Serialize(response, _jsonSerializerOptionsProvider.Options);
            var jsonDoc = JsonDocument.Parse(json);

            // Assert
            Assert.AreEqual("RedirectShopper", jsonDoc.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("redirect", jsonDoc.RootElement.GetProperty("action").GetProperty("type").GetString());
            Assert.AreEqual("scheme", jsonDoc.RootElement.GetProperty("action").GetProperty("paymentMethodType").GetString());
            Assert.AreEqual("GET", jsonDoc.RootElement.GetProperty("action").GetProperty("method").GetString());
        }

        #endregion

        #region PaymentDetailsResponse discriminator

        [TestMethod]
        public void Given_Deserialize_When_PaymentDetailsResponse_WithoutAction_Then_ResultCode_IsAuthorised()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-details-response-authorised.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentDetailsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(PaymentDetailsResponse.ResultCodeEnum.Authorised, response.ResultCode);
            Assert.IsNull(response.Action);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentDetailsResponse_WithThreeDS2Action_Then_CheckoutThreeDS2Action_IsPopulated()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-details-response-threeDS2-action.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentDetailsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(PaymentDetailsResponse.ResultCodeEnum.ChallengeShopper, response.ResultCode);
            Assert.IsNotNull(response.Action);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, response.Action.Type);
            Assert.AreEqual("scheme", response.Action.PaymentMethodType);
            Assert.IsNotNull(response.Action.Token);
        }

        [TestMethod]
        public void Given_Serialize_When_PaymentDetailsResponse_WithThreeDS2Action_Then_TypeIsPreserved()
        {
            // Arrange
            var response = new PaymentDetailsResponse
            {
                ResultCode = PaymentDetailsResponse.ResultCodeEnum.ChallengeShopper,
                Action = new CheckoutThreeDS2Action
                {
                    Type = CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    PaymentMethodType = "scheme",
                    PaymentData = "test-payment-data"
                }
            };

            // Act
            string json = JsonSerializer.Serialize(response, _jsonSerializerOptionsProvider.Options);
            var jsonDoc = JsonDocument.Parse(json);

            // Assert
            Assert.AreEqual("ChallengeShopper", jsonDoc.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("threeDS2", jsonDoc.RootElement.GetProperty("action").GetProperty("type").GetString());
            Assert.AreEqual("scheme", jsonDoc.RootElement.GetProperty("action").GetProperty("paymentMethodType").GetString());
        }

        #endregion

        #region allOf unknown type

        [TestMethod]
        public void Given_ShopperIdPaymentMethod_With_Unknown_Type_When_Deserialized_Then_ReturnsBaseInstance()
        {
            // Arrange
            string json = @"{""type"":""unknown_shopper_id_method"",""someField"":""someValue""}";

            // Act
            var result = JsonSerializer.Deserialize<ShopperIdPaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(typeof(ShopperIdPaymentMethod), result.GetType());
        }

        #endregion

        #region allOf discriminator wire values (regression #1717)

        [TestMethod]
        public void Given_PayToPaymentMethodJson_When_DeserializeAsShopperIdPaymentMethod_Then_Returns_PayToPaymentMethod()
        {
            // Arrange
            string json = @"{""type"":""payTo""}";

            // Act
            var result = JsonSerializer.Deserialize<ShopperIdPaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(PayToPaymentMethod),
                "Expected PayToPaymentMethod but got: " + result.GetType().Name);
        }

        [TestMethod]
        public void Given_UPIPaymentMethodJson_When_DeserializeAsShopperIdPaymentMethod_Then_Returns_UPIPaymentMethod()
        {
            // Arrange
            string json = @"{""type"":""upi_collect""}";

            // Act
            var result = JsonSerializer.Deserialize<ShopperIdPaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UPIPaymentMethod),
                "Expected UPIPaymentMethod but got: " + result.GetType().Name);
        }

        [TestMethod]
        public void Given_PayToPaymentMethod_When_Serialize_Then_TypeIsApiWireValue()
        {
            // Arrange
            var payTo = new PayToPaymentMethod();

            // Act
            string json = JsonSerializer.Serialize<ShopperIdPaymentMethod>(payTo, _jsonSerializerOptionsProvider.Options);

            // Assert
            using var doc = JsonDocument.Parse(json);
            Assert.AreEqual("payTo", doc.RootElement.GetProperty("type").GetString(),
                "Expected wire value 'payTo' but got: " + json);
        }

        [TestMethod]
        public void Given_UPIPaymentMethod_When_Serialize_Then_TypeIsApiWireValue()
        {
            // Arrange
            var upi = new UPIPaymentMethod();

            // Act
            string json = JsonSerializer.Serialize<ShopperIdPaymentMethod>(upi, _jsonSerializerOptionsProvider.Options);

            // Assert
            using var doc = JsonDocument.Parse(json);
            Assert.AreEqual("upi_collect", doc.RootElement.GetProperty("type").GetString(),
                "Expected wire value 'upi_collect' but got: " + json);
        }

        #endregion

        #region oneOf unknown type

        [TestMethod]
        public void Given_CheckoutPaymentMethod_With_Unknown_Type_When_Deserialized_Then_ReturnsNull()
        {
            // Arrange
            string json = @"{""type"":""unknown_payment_method"",""someField"":""someValue""}";

            // Act
            var result = JsonSerializer.Deserialize<CheckoutPaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Given_PaymentResponseAction_With_Unknown_Type_When_Deserialized_Then_ReturnsNull()
        {
            // Arrange
            string json = @"{""type"":""unknown_action"",""url"":""https://example.com""}";

            // Act
            var result = JsonSerializer.Deserialize<PaymentResponseAction>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNull(result);
        }

        #endregion
    }
}