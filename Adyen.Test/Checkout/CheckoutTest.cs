using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class CheckoutTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public CheckoutTest()
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
        public void Given_Deserialize_When_Payment_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payments-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("8535296650153317", response.PspReference);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.Authorised, response.ResultCode);
            Assert.IsNotNull(response.AdditionalData);
            Assert.AreEqual(9, response.AdditionalData.Count);
            Assert.AreEqual("8/2018", response.AdditionalData["expiryDate"]);
            Assert.AreEqual("GREEN", response.AdditionalData["fraudResultType"]);
            Assert.AreEqual("411111", response.AdditionalData["cardBin"]);
            Assert.AreEqual("1111", response.AdditionalData["cardSummary"]);
            Assert.AreEqual("false", response.AdditionalData["fraudManualReview"]);
            Assert.AreEqual("Default", response.AdditionalData["aliasType"]);
            Assert.AreEqual("H167852639363479", response.AdditionalData["alias"]);
            Assert.AreEqual("visa", response.AdditionalData["cardPaymentMethod"]);
            Assert.AreEqual("NL", response.AdditionalData["cardIssuingCountry"]);
        }

        [TestMethod]
        public void Given_Deserialize_When_Payment3DS2_CheckoutThreeDS2Action_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payments-3DS2-IdentifyShopper.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.IdentifyShopper, response.ResultCode);
            Assert.AreEqual("threeDS2", response.Action.CheckoutThreeDS2Action.Type.ToString());
            Assert.IsNotNull(response.Action.CheckoutThreeDS2Action.PaymentData);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentError_Result_ServiceError_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payments-error-invalid-data-422.json");
            
            // Act
            var serviceErrorResponse = JsonSerializer.Deserialize<ServiceError>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNull(serviceErrorResponse.PspReference);
            Assert.AreEqual("Reference Missing", serviceErrorResponse.Message);
            Assert.AreEqual("validation", serviceErrorResponse.ErrorType);
            Assert.AreEqual("130", serviceErrorResponse.ErrorCode);
            Assert.AreEqual(422, serviceErrorResponse.Status);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentDetailsResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentsdetails-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentDetailsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("8515232733321252", response.PspReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentDetailsActionResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentsdetails-action-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentDetailsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("8515232733321252", response.PspReference);
            Assert.AreEqual(PaymentDetailsResponse.ResultCodeEnum.Authorised, response.ResultCode);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethods_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.PaymentMethods.Count, 32);
            Assert.IsNotNull(response.PaymentMethods[12].Issuers);
            Assert.AreEqual(response.PaymentMethods[12].Issuers[0].Id, "66");
            Assert.AreEqual(response.PaymentMethods[12].Issuers[0].Name, "Bank Nowy BFG S.A.");
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethods__Result_Brands_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-brands-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(7, response.PaymentMethods.Count);
            Assert.AreEqual(5, response.PaymentMethods[0].Brands.Count);
            Assert.AreEqual("visa", response.PaymentMethods[0].Brands[0]);
            Assert.AreEqual("mc", response.PaymentMethods[0].Brands[1]);
            Assert.AreEqual("amex", response.PaymentMethods[0].Brands[2]);
            Assert.AreEqual("bcmc", response.PaymentMethods[0].Brands[3]);
            Assert.AreEqual("maestro", response.PaymentMethods[0].Brands[4]);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethods_Result_Without_Brands_Is_Exactly_50()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-without-brands-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.PaymentMethods.Count, 50);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentLinks_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-links-success.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentLinkResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("your-id", response.Id);
            Assert.AreEqual(PaymentLinkResponse.StatusEnum.Active, response.Status);
            Assert.AreEqual("https://checkoutshopper-test.adyen.com/checkoutshopper/payByLink.shtml?d=YW1vdW50TWlub3JW...JRA", response.Url);
            Assert.AreEqual(new DateTimeOffset(2019, 12, 17, 10, 05, 29, TimeSpan.Zero), response.ExpiresAt);
            Assert.AreEqual("YOUR_ORDER_NUMBER", response.Reference);
            Assert.AreEqual(1250, response.Amount.Value);
            Assert.AreEqual("BRL", response.Amount.Currency);
        }

        [TestMethod]
        public void Given_Deserialize_When_Payments_PayPal_Result_CheckoutSDKAction_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payments-success-paypal.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response.Action.CheckoutSDKAction);
            Assert.AreEqual("EC-42N19135GM6949000", response.Action.CheckoutSDKAction.SdkData["orderID"]);
            Assert.AreEqual("Ab02b4c0!BQABAgARb1TvUJa4nwS0Z1nOmxoYfD9+z...", response.Action.CheckoutSDKAction.PaymentData);
            Assert.AreEqual("paypal", response.Action.CheckoutSDKAction.PaymentMethodType);
        }

        [TestMethod]
        public void Given_Deserialize_When_ApplePayDetails_Result_Is_Not_Null()
        {
            // Arrange
            string json = "{\"type\": \"applepay\",\"applePayToken\": \"VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...\"}";
            
            // Act
            var response = JsonSerializer.Deserialize<ApplePayDetails>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual( ApplePayDetails.TypeEnum.Applepay, response.Type);
            Assert.AreEqual("VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...", response.ApplePayToken);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_ApplePayDetails_With_Unknown_Value_Result_Is_Not_Null()
        {
            // Arrange
            string json = "{\"type\": \"applepay\",\"someValue\": \"notInSpec\",\"applePayToken\": \"VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...\"}";
            
            // Act
            var response = JsonSerializer.Deserialize<ApplePayDetails>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(ApplePayDetails.TypeEnum.Applepay, response.Type);
            Assert.AreEqual("VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...", response.ApplePayToken);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_PayWithGoogleDetails_Returns_Not_Null()
        {
            // Arrange
            string json = "{\"type\": \"paywithgoogle\",\"someValue\": \"notInSpec\",\"googlePayToken\": \"==Payload as retrieved from Google Pay response==\"}";
            
            // Act
            var response = JsonSerializer.Deserialize<PayWithGoogleDetails>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(PayWithGoogleDetails.TypeEnum.Paywithgoogle, response.Type);
            Assert.AreEqual(response.GooglePayToken, "==Payload as retrieved from Google Pay response==");
        }

        [TestMethod]
        public void Given_Deserialize_When_BlikCode_Result_Is_Not_Null()
        {
            // Arrange
            string json = "{\"type\":\"blik\",\"blikCode\":\"blikCode\"}";
            
            // Act
            var response = JsonSerializer.Deserialize<BlikDetails>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(BlikDetails.TypeEnum.Blik, response.Type);
            Assert.AreEqual("blikCode", response.BlikCode);
        }

        [TestMethod]
        public void Given_Deserialize_When_DragonpayDetails_Result_Is_Not_Null()
        {
            // Arrange
            string json = "{\"issuer\":\"issuer\",\"shopperEmail\":\"test@adyen.com\",\"type\":\"dragonpay_ebanking\"}";
            
            // Act
            var result = JsonSerializer.Deserialize<DragonpayDetails>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(DragonpayDetails.TypeEnum.DragonpayEbanking, result.Type);
            Assert.AreEqual("issuer", result.Issuer);
            Assert.AreEqual("test@adyen.com", result.ShopperEmail);
        }

        [TestMethod]
        public void Given_Deserialize_When_AfterPayDetails_Result_Is_Not_Null()
        {
            // Arrange
            string json = @"
{
    ""resultCode"":""RedirectShopper"",
    ""action"":{
        ""paymentMethodType"":""afterpaytouch"",
        ""method"":""GET"",
        ""url"":""https://checkoutshopper-test.adyen.com/checkoutshopper/checkoutPaymentRedirect?redirectData=..."",
        ""type"":""redirect""
    }
}";
            // Act
            var result = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.RedirectShopper, result.ResultCode);
            Assert.AreEqual("afterpaytouch", result.Action.CheckoutRedirectAction.PaymentMethodType);
            Assert.AreEqual(CheckoutRedirectAction.TypeEnum.Redirect, result.Action.CheckoutRedirectAction.Type);
            Assert.AreEqual("https://checkoutshopper-test.adyen.com/checkoutshopper/checkoutPaymentRedirect?redirectData=...", result.Action.CheckoutRedirectAction.Url);
            Assert.AreEqual("GET", result.Action.CheckoutRedirectAction.Method);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResponse_3DS_ChallengeShopper_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentResponse-3DS-ChallengeShopper.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, response.Action.CheckoutThreeDS2Action.Type);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethodsResponse_StoredPaymentMethods_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-storedpaymentmethods.json");
                  
            // Act
            var response = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(4, response.StoredPaymentMethods.Count);
            Assert.AreEqual("NL32ABNA0515071439", response.StoredPaymentMethods[0].Iban);
            Assert.AreEqual("Adyen", response.StoredPaymentMethods[0].OwnerName);
            Assert.AreEqual("sepadirectdebit", response.StoredPaymentMethods[0].Type);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResponse_3DS2_IdentifyShopper_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentResponse-3DS2-Action.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.IdentifyShopper, response.ResultCode);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, response.Action.CheckoutThreeDS2Action.Type);
        }

        [TestMethod]
        public void Given_Serialize_When_CheckoutSessionRequest_Result_Contains_DateOnly_And_DateTimeOffset()
        {
            // Arrange
            CreateCheckoutSessionRequest checkoutSessionRequest = new CreateCheckoutSessionRequest(
                merchantAccount: "TestMerchant",
                reference: "TestReference",
                returnUrl: "http://test-url.com",
                amount: new Amount("EUR", 10000L),
                dateOfBirth: new DateOnly(1998, 1, 1),
                expiresAt: new DateTimeOffset(2023, 4, 1, 1, 1, 1, TimeSpan.Zero)
            );
            
            // Act
            string target = JsonSerializer.Serialize(checkoutSessionRequest, _jsonSerializerOptionsProvider.Options);
            
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("TestMerchant", root.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("TestReference", root.GetProperty("reference").GetString());
            Assert.AreEqual("http://test-url.com", root.GetProperty("returnUrl").GetString());
            Assert.AreEqual("1998-01-01", root.GetProperty("dateOfBirth").GetString());
            Assert.AreEqual("2023-04-01T01:01:01.0000000+00:00", root.GetProperty("expiresAt").GetString());
            // does not serialise null fields
            Assert.IsFalse(target.Contains(":null"));
            Assert.IsFalse(target.Contains("threeDSAuthenticationOnly"));
        }
        
        [TestMethod]
        public void Given_Serialize_When_CheckoutSessionRequest_Is_Filled_Result_Returns_No_Null_Values()
        {
            // Arrange
            CreateCheckoutSessionRequest checkoutSessionRequest = new CreateCheckoutSessionRequest(
                merchantAccount: "TestMerchant",
                reference: "TestReference",
                returnUrl: "http://test-url.com",
                amount: new Amount("EUR", 10000L),
                dateOfBirth: new DateOnly(1998, 1, 1),
                expiresAt: new DateTimeOffset(2023, 4, 1, 1, 1, 1, TimeSpan.Zero)
                );
            
            // Act
            string target = JsonSerializer.Serialize(checkoutSessionRequest, _jsonSerializerOptionsProvider.Options);
            
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;

            // Ensure that no elements contain null
            foreach (JsonProperty property in root.EnumerateObject())
            {
                Assert.AreNotEqual(JsonValueKind.Null, property.Value.ValueKind, $"Property {property.Name} is null");
            }
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethodsBalance_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-balance-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<BalanceCheckResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(BalanceCheckResponse.ResultCodeEnum.Success, response.ResultCode);
            Assert.AreEqual("EUR", response.Balance.Currency);
            Assert.AreEqual("2500", response.Balance.Value.ToString());
        }
        
        [TestMethod]
        public void Given_Deserialize_When_CreateOrderResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/orders-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<CreateOrderResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(CreateOrderResponse.ResultCodeEnum.Success, response.ResultCode);
            Assert.AreEqual("8515930288670953", response.PspReference);
            Assert.AreEqual("Ab02b4c0!BQABAgBqxSuFhuXUF7IvIRvSw5bDPHN...", response.OrderData);
            Assert.AreEqual("EUR", response.RemainingAmount.Currency);
            Assert.AreEqual("2500", response.RemainingAmount.Value.ToString());
        }

        [TestMethod]
        public void Given_Deserialize_When_CancelOrderResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/orders-cancel-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<CancelOrderResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("Received", response.ResultCode.ToString());
            Assert.AreEqual("8515931182066678", response.PspReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_GetStoredPaymentMethods_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/get-storedPaymentMethod-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ListStoredPaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("string", response.StoredPaymentMethods[0].Type);
            Assert.AreEqual("merchantAccount", response.MerchantAccount);
        }
    }
}
