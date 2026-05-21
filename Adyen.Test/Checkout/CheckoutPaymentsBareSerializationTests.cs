using System.Text;
using System.Text.Json;
using Adyen.Checkout.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    /// <summary>
    /// Verifies that Checkout models can be serialized and deserialized using bare
    /// <see cref="JsonSerializer"/> calls without supplying any <see cref="JsonSerializerOptions"/>.
    /// All Checkout models carry a class-level <c>[JsonConverter]</c> attribute that STJ discovers
    /// automatically, so behaviour is identical to the DI-based path tested in
    /// <see cref="PaymentsTest"/>.
    /// </summary>
    [TestClass]
    public class CheckoutPaymentsBareSerializationTests
    {
        #region PaymentMethodsResponse

        [TestMethod]
        public void Given_PaymentMethodsResponse_When_BareDeserialize_Then_Returns_29_PaymentMethods()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-methods-response.json");

            var result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json);

            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNull(result.StoredPaymentMethods);
            Assert.AreEqual(29, result.PaymentMethods.Count);
        }

        [TestMethod]
        public void Given_PaymentMethodsResponse_With_StoredPaymentMethods_When_BareDeserialize_Then_All_Properties_Are_Populated()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/paymentmethods-storedpaymentmethods.json");

            var result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json);

            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNotNull(result.StoredPaymentMethods);
            Assert.AreEqual(3, result.PaymentMethods.Count);
            Assert.AreEqual(4, result.StoredPaymentMethods.Count);
        }

        #endregion

        #region Serialization edge cases

        [TestMethod]
        public void Given_CreateCheckoutSessionRequest_When_BareSerialize_Long_Then_Result_Contains_Zeros()
        {
            var request = new CreateCheckoutSessionRequest
            {
                Amount = new Amount { Currency = "EUR", Value = 10000L },
                MerchantAccount = "merchantAccount",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Channel = CreateCheckoutSessionRequest.ChannelEnum.Web,
                CountryCode = "NL",
                LineItems = new List<LineItem>
                {
                    new LineItem { Quantity = 1, AmountIncludingTax = 5000, Description = "description1", AmountExcludingTax = 0 },
                    new LineItem { Quantity = 1, AmountIncludingTax = 5000, Description = "description2", TaxAmount = 0 },
                },
            };

            string result = JsonSerializer.Serialize(request);

            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement lineItems = json.RootElement.GetProperty("lineItems");
            lineItems[0].TryGetProperty("amountExcludingTax", out JsonElement amountExcludingTax);
            lineItems[1].TryGetProperty("taxAmount", out JsonElement taxAmount);
            Assert.AreEqual(0, amountExcludingTax.GetInt32());
            Assert.AreEqual(0, taxAmount.GetInt32());
        }

        [TestMethod]
        public void Given_CreateCheckoutSessionResponse_When_BareDeserialize_Then_Id_IsNotNull()
        {
            string json = @"{""mode"":""embedded"",""amount"":{""currency"":""EUR"",""value"":10000},""expiresAt"":""2023-04-06T17:11:15+02:00"",""id"":""CS0068299CB8DA273A"",""merchantAccount"":""TestMerchantAccount"",""reference"":""TestReference"",""returnUrl"":""http://test-url.com"",""sessionData"":""test-session-data"",""shopperLocale"":""en-US""}";

            var result = JsonSerializer.Deserialize<CreateCheckoutSessionResponse>(json);

            Assert.IsNotNull(result.Id);
            Assert.AreEqual("CS0068299CB8DA273A", result.Id);
        }

        [TestMethod]
        public void Given_DeviceRenderOptions_When_BareSerialize_Then_SdkUiType_Contains_MultiSelect_And_OtherHtml()
        {
            var deviceRenderOptions = new DeviceRenderOptions
            {
                SdkInterface = DeviceRenderOptions.SdkInterfaceEnum.Native,
                SdkUiType = new List<DeviceRenderOptions.SdkUiTypeEnum>
                {
                    DeviceRenderOptions.SdkUiTypeEnum.MultiSelect,
                    DeviceRenderOptions.SdkUiTypeEnum.OtherHtml,
                },
            };

            string result = JsonSerializer.Serialize(deviceRenderOptions);

            using JsonDocument json = JsonDocument.Parse(result);
            Assert.AreEqual("native", json.RootElement.GetProperty("sdkInterface").GetString());
            JsonElement sdkUiTypes = json.RootElement.GetProperty("sdkUiType");
            Assert.AreEqual("multiSelect", sdkUiTypes[0].GetString());
            Assert.AreEqual("otherHtml", sdkUiTypes[1].GetString());
        }

        [TestMethod]
        public void Given_ThreeDSecureData_When_BareSerialize_Then_ByteArray_IsCorrect()
        {
            byte[] base64Bytes = Encoding.ASCII.GetBytes(Convert.ToBase64String(Encoding.ASCII.GetBytes("Bytes-To-Be-Encoded")));
            var threeDSecure = new ThreeDSecureData { Cavv = base64Bytes, Xid = base64Bytes };

            string result = JsonSerializer.Serialize(threeDSecure);

            Assert.AreEqual("{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}", result);
        }

        [TestMethod]
        public void Given_ThreeDSecureData_When_BareDeserialize_Then_ByteArray_IsCorrect()
        {
            string json = "{\"cavv\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\",\"xid\":\"Qnl0ZXMtVG8tQmUtRW5jb2RlZA==\"}";

            var result = JsonSerializer.Deserialize<ThreeDSecureData>(json);

            Assert.AreEqual("Qnl0ZXMtVG8tQmUtRW5jb2RlZA==", Encoding.ASCII.GetString(result.Cavv));
            Assert.AreEqual("Qnl0ZXMtVG8tQmUtRW5jb2RlZA==", Encoding.ASCII.GetString(result.Xid));
        }

        #endregion

        #region PaymentRequest with payment methods

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_AchDetails_Then_Type_IsAch()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ACH test",
                PaymentMethod = new CheckoutPaymentMethod(new AchDetails
                {
                    Type = AchDetails.TypeEnum.Ach,
                    BankAccountNumber = "1234567",
                    BankLocationId = "1234567",
                    EncryptedBankAccountNumber = "1234asdfg",
                    OwnerName = "John Smith",
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("ach", json.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("1234567", json.RootElement.GetProperty("paymentMethod").GetProperty("bankAccountNumber").GetString());
            Assert.AreEqual("1234asdfg", json.RootElement.GetProperty("paymentMethod").GetProperty("encryptedBankAccountNumber").GetString());
            Assert.AreEqual("John Smith", json.RootElement.GetProperty("paymentMethod").GetProperty("ownerName").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_ApplePayDetails_Then_Type_IsApplepay()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "apple pay test",
                PaymentMethod = new CheckoutPaymentMethod(new ApplePayDetails
                {
                    Type = ApplePayDetails.TypeEnum.Applepay,
                    ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...",
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("applepay", json.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...", json.RootElement.GetProperty("paymentMethod").GetProperty("applePayToken").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_GooglePayDetails_Then_Type_IsGooglepay()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "google pay test",
                PaymentMethod = new CheckoutPaymentMethod(new GooglePayDetails
                {
                    Type = GooglePayDetails.TypeEnum.Googlepay,
                    GooglePayToken = "==Payload==",
                    FundingSource = GooglePayDetails.FundingSourceEnum.Debit,
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("googlepay", json.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.AreEqual("debit", json.RootElement.GetProperty("paymentMethod").GetProperty("fundingSource").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_IdealDetails_Then_Type_IsIdeal()
        {
            var request = new PaymentRequest
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

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("ideal", json.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
            Assert.IsFalse(json.RootElement.TryGetProperty("accountInfo", out _));
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_BacsDirectDebitDetails_Then_Type_IsDirectDebitGB()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "GBP", Value = 1000 },
                Reference = "bacs direct debit test",
                PaymentMethod = new CheckoutPaymentMethod(new BacsDirectDebitDetails
                {
                    Type = BacsDirectDebitDetails.TypeEnum.DirectdebitGB,
                    BankAccountNumber = "NL0123456789",
                    BankLocationId = "121000358",
                    HolderName = "John Smith",
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            JsonElement pm = json.RootElement.GetProperty("paymentMethod");
            Assert.AreEqual("directdebit_GB", pm.GetProperty("type").GetString());
            Assert.AreEqual("NL0123456789", pm.GetProperty("bankAccountNumber").GetString());
            Assert.AreEqual("John Smith", pm.GetProperty("holderName").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_PayPalDetails_Then_Type_IsPaypal()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "USD", Value = 1000 },
                Reference = "paypal test",
                PaymentMethod = new CheckoutPaymentMethod(new PayPalDetails
                {
                    Type = PayPalDetails.TypeEnum.Paypal,
                    Subtype = PayPalDetails.SubtypeEnum.Sdk,
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            JsonElement pm = json.RootElement.GetProperty("paymentMethod");
            Assert.AreEqual("paypal", pm.GetProperty("type").GetString());
            Assert.AreEqual("sdk", pm.GetProperty("subtype").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_With_ZipDetails_Then_Type_IsZip()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "USD", Value = 1000 },
                Reference = "zip test",
                PaymentMethod = new CheckoutPaymentMethod(new ZipDetails { Type = ZipDetails.TypeEnum.Zip }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("zip", json.RootElement.GetProperty("paymentMethod").GetProperty("type").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_AccountInfo_IsExplicitNull_Then_KeyIsPresent()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ref",
                PaymentMethod = new CheckoutPaymentMethod(new CardDetails { Type = CardDetails.TypeEnum.Card }),
                ReturnUrl = "https://your-company.com/",
                AccountInfo = null,
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual(null, json.RootElement.GetProperty("accountInfo").GetString());
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareSerialize_AccountInfo_NotSet_Then_KeyIsAbsent()
        {
            var request = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount { Currency = "EUR", Value = 1000 },
                Reference = "ref",
                PaymentMethod = new CheckoutPaymentMethod(new CardDetails { Type = CardDetails.TypeEnum.Card }),
                ReturnUrl = "https://your-company.com/",
            };

            string result = JsonSerializer.Serialize(request);

            using var json = JsonDocument.Parse(result);
            Assert.IsFalse(json.RootElement.TryGetProperty("accountInfo", out _));
        }

        [TestMethod]
        public void Given_PaymentRequest_When_BareDeserialize_Ideal_Then_PaymentMethod_IsIdeal()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-request-ideal.json");

            var result = JsonSerializer.Deserialize<PaymentRequest>(json);

            Assert.IsNotNull(result.PaymentMethod);
            Assert.IsNotNull(result.PaymentMethod.IdealDetails);
            Assert.AreEqual(IdealDetails.TypeEnum.Ideal, result.PaymentMethod.IdealDetails.Type);
        }

        #endregion

        #region PaymentResponse actions

        [TestMethod]
        public void Given_PaymentResponse_When_BareDeserialize_ThreeDS2Fingerprint_Then_Action_IsPopulated()
        {
            string json = @"{""action"":{""type"":""threeDS2"",""subtype"":""fingerprint"",""paymentData"":""test-payment-data"",""paymentMethodType"":""scheme"",""authorisationToken"":""test-authorisation-token"",""token"":""test-token""},""resultCode"":""IdentifyShopper""}";

            var result = JsonSerializer.Deserialize<PaymentResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.IdentifyShopper, result.ResultCode);
            Assert.IsNotNull(result.Action?.CheckoutThreeDS2Action);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, result.Action.CheckoutThreeDS2Action.Type);
            Assert.AreEqual("fingerprint", result.Action.CheckoutThreeDS2Action.Subtype);
            Assert.AreEqual("test-payment-data", result.Action.CheckoutThreeDS2Action.PaymentData);
            Assert.AreEqual("scheme", result.Action.CheckoutThreeDS2Action.PaymentMethodType);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareSerialize_ThreeDS2Fingerprint_Then_Json_IsCorrect()
        {
            var response = new PaymentResponse
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
                }),
            };

            string result = JsonSerializer.Serialize(response);

            using var json = JsonDocument.Parse(result);
            JsonElement action = json.RootElement.GetProperty("action");
            Assert.AreEqual("IdentifyShopper", json.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("threeDS2", action.GetProperty("type").GetString());
            Assert.AreEqual("fingerprint", action.GetProperty("subtype").GetString());
            Assert.AreEqual("test-payment-data", action.GetProperty("paymentData").GetString());
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareDeserialize_RedirectShopper_Then_Action_IsPopulated()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-response-redirect-action.json");

            var result = JsonSerializer.Deserialize<PaymentResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.RedirectShopper, result.ResultCode);
            Assert.IsNotNull(result.Action?.CheckoutRedirectAction);
            Assert.IsNull(result.Action.CheckoutThreeDS2Action);
            Assert.AreEqual(CheckoutRedirectAction.TypeEnum.Redirect, result.Action.CheckoutRedirectAction.Type);
            Assert.AreEqual("scheme", result.Action.CheckoutRedirectAction.PaymentMethodType);
            Assert.AreEqual("GET", result.Action.CheckoutRedirectAction.Method);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareSerialize_RedirectShopper_Then_Json_IsCorrect()
        {
            var response = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.RedirectShopper,
                Action = new PaymentResponseAction(new CheckoutRedirectAction
                {
                    Type = CheckoutRedirectAction.TypeEnum.Redirect,
                    PaymentMethodType = "scheme",
                    Url = "https://checkoutshopper-test.adyen.com/redirect",
                    Method = "GET",
                }),
            };

            string result = JsonSerializer.Serialize(response);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("RedirectShopper", json.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("redirect", json.RootElement.GetProperty("action").GetProperty("type").GetString());
            Assert.AreEqual("GET", json.RootElement.GetProperty("action").GetProperty("method").GetString());
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareDeserialize_ThreeDS2Challenge_Then_Action_IsPopulated()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-response-threeDS2-action.json");

            var result = JsonSerializer.Deserialize<PaymentResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.IdentifyShopper, result.ResultCode);
            Assert.IsNotNull(result.Action?.CheckoutThreeDS2Action);
            Assert.IsNull(result.Action.CheckoutRedirectAction);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, result.Action.CheckoutThreeDS2Action.Type);
            Assert.AreEqual("scheme", result.Action.CheckoutThreeDS2Action.PaymentMethodType);
            Assert.IsNotNull(result.Action.CheckoutThreeDS2Action.Token);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareSerialize_ThreeDS2Challenge_Then_Json_IsCorrect()
        {
            var response = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.ChallengeShopper,
                Action = new PaymentResponseAction(new CheckoutThreeDS2Action
                {
                    Type = CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    Subtype = "challenge",
                    PaymentData = "test-payment-data",
                    PaymentMethodType = "scheme",
                }),
            };

            string result = JsonSerializer.Serialize(response);

            using var json = JsonDocument.Parse(result);
            JsonElement action = json.RootElement.GetProperty("action");
            Assert.AreEqual("ChallengeShopper", json.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("threeDS2", action.GetProperty("type").GetString());
            Assert.AreEqual("challenge", action.GetProperty("subtype").GetString());
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareDeserialize_Authorised_Then_Action_IsNull()
        {
            string json = @"{""resultCode"":""Authorised"",""pspReference"":""test-psp-reference"",""merchantReference"":""test-merchant-reference""}";

            var result = JsonSerializer.Deserialize<PaymentResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentResponse.ResultCodeEnum.Authorised, result.ResultCode);
            Assert.AreEqual("test-psp-reference", result.PspReference);
            Assert.IsNull(result.Action);
        }

        [TestMethod]
        public void Given_PaymentResponse_When_BareSerialize_Authorised_Then_ActionIsAbsent()
        {
            var response = new PaymentResponse
            {
                ResultCode = PaymentResponse.ResultCodeEnum.Authorised,
                PspReference = "test-psp-reference",
            };

            string result = JsonSerializer.Serialize(response);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("Authorised", json.RootElement.GetProperty("resultCode").GetString());
            Assert.IsFalse(json.RootElement.TryGetProperty("action", out _));
        }

        #endregion

        #region PaymentDetailsResponse actions

        [TestMethod]
        public void Given_PaymentDetailsResponse_When_BareDeserialize_Authorised_Then_ResultCode_IsAuthorised()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-details-response-authorised.json");

            var result = JsonSerializer.Deserialize<PaymentDetailsResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentDetailsResponse.ResultCodeEnum.Authorised, result.ResultCode);
            Assert.IsNull(result.Action);
        }

        [TestMethod]
        public void Given_PaymentDetailsResponse_When_BareDeserialize_ThreeDS2Action_Then_Action_IsPopulated()
        {
            string json = TestUtilities.GetTestFileContent("mocks/checkout/payment-details-response-threeDS2-action.json");

            var result = JsonSerializer.Deserialize<PaymentDetailsResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(PaymentDetailsResponse.ResultCodeEnum.ChallengeShopper, result.ResultCode);
            Assert.IsNotNull(result.Action);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, result.Action.Type);
            Assert.AreEqual("scheme", result.Action.PaymentMethodType);
            Assert.IsNotNull(result.Action.Token);
        }

        [TestMethod]
        public void Given_PaymentDetailsResponse_When_BareSerialize_ThreeDS2Action_Then_Json_IsCorrect()
        {
            var response = new PaymentDetailsResponse
            {
                ResultCode = PaymentDetailsResponse.ResultCodeEnum.ChallengeShopper,
                Action = new CheckoutThreeDS2Action
                {
                    Type = CheckoutThreeDS2Action.TypeEnum.ThreeDS2,
                    PaymentMethodType = "scheme",
                    PaymentData = "test-payment-data",
                },
            };

            string result = JsonSerializer.Serialize(response);

            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("ChallengeShopper", json.RootElement.GetProperty("resultCode").GetString());
            Assert.AreEqual("threeDS2", json.RootElement.GetProperty("action").GetProperty("type").GetString());
            Assert.AreEqual("scheme", json.RootElement.GetProperty("action").GetProperty("paymentMethodType").GetString());
        }

        #endregion
    }
}
