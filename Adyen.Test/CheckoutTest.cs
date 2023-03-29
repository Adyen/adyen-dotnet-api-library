using Adyen.Model.Checkout;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Adyen.Service.Checkout;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Adyen.Model.Checkout.PaymentResponse;
using Amount = Adyen.Model.Checkout.Amount;
using ApplicationInfo = Adyen.Model.ApplicationInformation.ApplicationInfo;
using Environment = Adyen.Model.Environment;
using RecurringService = Adyen.Service.Checkout.RecurringService;

namespace Adyen.Test
{
    [TestClass]
    public class CheckoutTest : BaseTest
    {

        /// <summary>
        /// Tests successful checkout client Test URL generation.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointTestEnvironmentSuccessTest()
        {
            var config = new Config();
            var client = new Client(config);
            client.SetEnvironment(Environment.Test, "companyUrl");
            Assert.AreEqual(config.CheckoutEndpoint, @"https://checkout-test.adyen.com");
            Assert.AreEqual(config.Endpoint, @"https://pal-test.adyen.com");
        }

        /// <summary>
        /// Tests successful checkout client Live URL generation.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointLiveEnvironmentSuccessTest()
        {
            var config = new Config();
            var client = new Client(config);
            client.SetEnvironment(Environment.Live, "companyUrl");
            Assert.AreEqual(config.CheckoutEndpoint, @"https://companyUrl-checkout-live.adyenpayments.com/checkout");
            Assert.AreEqual(config.Endpoint, @"https://companyUrl-pal-live.adyenpayments.com");
        }

        /// <summary>
        /// Tests unsuccessful checkout client Live URL generation.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointLiveErrorTest()
        {
            var config = new Config();
            var client = new Client(config);
            Assert.ThrowsException<InvalidOperationException>(() => client.SetEnvironment(Environment.Live, null));
        }
        
        /// <summary>
        /// Tests unsuccessful checkout client Live URL generation.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointLiveWithBasicAuthErrorTest()
        {
            Assert.ThrowsException<InvalidOperationException>(() => new Client("ws_*******", "******", Environment.Live));
        }
        
        /// <summary>
        /// Tests successful checkout client Live URL generation with basic auth.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointLiveWithBasicAuthTest()
        {
            var client = new Client("ws_*******", "******", Environment.Live, "live-url");
            Assert.AreEqual(client.Config.CheckoutEndpoint, "https://live-url-checkout-live.adyenpayments.com/checkout");
        }
        
        /// <summary>
        /// Tests successful checkout client Live URL generation with API key.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointLiveWithAPIKeyTest()
        {
            var client = new Client("xapikey", Environment.Live, "live-url");
            Assert.AreEqual(client.Config.CheckoutEndpoint, "https://live-url-checkout-live.adyenpayments.com/checkout");
        }

        /// <summary>
        /// Test success flow for
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void PaymentsAdditionalDataParsingTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/payments-success.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.Payments(paymentRequest);
            Assert.AreEqual("8535296650153317", paymentResponse.PspReference);
            Assert.AreEqual(ResultCodeEnum.Authorised, paymentResponse.ResultCode);
            Assert.IsNotNull(paymentResponse.AdditionalData);
            Assert.AreEqual(9, paymentResponse.AdditionalData.Count);
            Assert.AreEqual("8/2018", paymentResponse.AdditionalData["expiryDate"]);
            Assert.AreEqual("GREEN", paymentResponse.AdditionalData["fraudResultType"]);
            Assert.AreEqual("411111", paymentResponse.AdditionalData["cardBin"]);
            Assert.AreEqual("1111", paymentResponse.AdditionalData["cardSummary"]);
            Assert.AreEqual("false", paymentResponse.AdditionalData["fraudManualReview"]);
            Assert.AreEqual("Default", paymentResponse.AdditionalData["aliasType"]);
            Assert.AreEqual("H167852639363479", paymentResponse.AdditionalData["alias"]);
            Assert.AreEqual("visa", paymentResponse.AdditionalData["cardPaymentMethod"]);
            Assert.AreEqual("NL", paymentResponse.AdditionalData["cardIssuingCountry"]);
        }

        /// <summary>
        /// Test success flow for async
        /// POST /payments
        /// </summary>
        [TestMethod]
        public async Task PaymentsAsyncAdditionalDataParsingTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/payments-success.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = await checkout.PaymentsAsync(paymentRequest);
            Assert.AreEqual("8535296650153317", paymentResponse.PspReference);
            Assert.AreEqual(ResultCodeEnum.Authorised, paymentResponse.ResultCode);
            Assert.IsNotNull(paymentResponse.AdditionalData);
            Assert.AreEqual(9, paymentResponse.AdditionalData.Count);
            Assert.AreEqual("8/2018", paymentResponse.AdditionalData["expiryDate"]);
            Assert.AreEqual("GREEN", paymentResponse.AdditionalData["fraudResultType"]);
            Assert.AreEqual("411111", paymentResponse.AdditionalData["cardBin"]);
            Assert.AreEqual("1111", paymentResponse.AdditionalData["cardSummary"]);
            Assert.AreEqual("false", paymentResponse.AdditionalData["fraudManualReview"]);
            Assert.AreEqual("Default", paymentResponse.AdditionalData["aliasType"]);
            Assert.AreEqual("H167852639363479", paymentResponse.AdditionalData["alias"]);
            Assert.AreEqual("visa", paymentResponse.AdditionalData["cardPaymentMethod"]);
            Assert.AreEqual("NL", paymentResponse.AdditionalData["cardIssuingCountry"]);
        }

        /// <summary>
        /// Test success flow for 3DS2
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void Payments3DS2Test()
        {
            var payment3DS2Request = CreatePaymentRequest3DS2();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/payments-3DS2-IdentifyShopper.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.Payments(payment3DS2Request);
            Assert.AreEqual(paymentResponse.ResultCode, ResultCodeEnum.IdentifyShopper);
            Assert.AreEqual(paymentResponse.Action.GetCheckoutThreeDS2Action().Type.ToString(), "ThreeDS2");
            Assert.IsNotNull(paymentResponse.Action.GetCheckoutThreeDS2Action().PaymentData);
        }

        /// <summary>
        /// Test 3ds success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsAuthorise3ds2ResultSuccessTest()
        {
            var paymentResultRequest = CreatePaymentVerificationRequest();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/threedsecure2/authorise3ds2-success.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentResultResponse = checkout.VerifyPaymentResult(paymentResultRequest);
            Assert.IsNotNull(paymentResultResponse.AdditionalData);
            Assert.AreEqual(paymentResultResponse.AdditionalData["cvcResult"], "1 Matches");
            Assert.AreEqual(paymentResultResponse.MerchantReference, "your_merchantReference");
            Assert.AreEqual(paymentResultResponse.ResultCode, PaymentVerificationResponse.ResultCodeEnum.Authorised);
        }

        /// <summary>
        /// Test error flow for
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void PaymentsErrorTest()
        {
            var paymentMethodsRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/payments-error-invalid-data-422.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.Payments(paymentMethodsRequest);
            Assert.IsNull(paymentResponse.PspReference);
        }

        /// <summary>
        /// Test success flow for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details = new PaymentCompletionDetails(payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsdetails-success.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.PaymentsDetails(detailsRequest);
            Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

        /// <summary>
        /// Test success flow for async
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public async Task PaymentDetailsAsyncTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details =
                new PaymentCompletionDetails(
                    payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsdetails-success.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = await checkout.PaymentsDetailsAsync(detailsRequest);
            Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

        /// <summary>
        /// Test error flow for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsErrorTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details =
                new PaymentCompletionDetails(
                    payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client =
                CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsdetails-error-invalid-data-422.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.PaymentsDetails(detailsRequest);
            Assert.IsNull(paymentResponse.ResultCode);
        }

        /// <summary>
        /// Test success deserialization for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsResponseDeserializeTest()
        {
            var detailsRequest = CreateDetailsRequest();
            detailsRequest.Details =
                new PaymentCompletionDetails(
                    payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsdetails-action-success.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.PaymentsDetails(detailsRequest);
            Assert.AreEqual(paymentResponse.PspReference, "8515232733321252");
            Assert.AreEqual(paymentResponse.ResultCode, PaymentDetailsResponse.ResultCodeEnum.Authorised);
        }

        /// <summary>
        /// Test success flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-success.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 32);
        }

        /// <summary>
        /// Test success flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsIssuersTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-success.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsNotNull(paymentMethodsResponse.PaymentMethods[12].Issuers);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[12].Issuers[0].Id, "66");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[12].Issuers[0].Name, "Bank Nowy BFG S.A.");
        }

        /// <summary>
        /// Test success flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsStoreValueTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            paymentMethodsRequest.Store = "MerchantStore";
            Assert.AreEqual(paymentMethodsRequest.Store, "MerchantStore");
        }

        /// <summary>
        /// Test success flow for async
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public async Task PaymentMethodsAsyncTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-success.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsResponse = await checkout.PaymentMethodsAsync(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 32);
        }

        /// <summary>
        /// Test error flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsErrorTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-error-forbidden-403.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsNull(paymentMethodsResponse.PaymentMethods);
        }

        /// <summary>
        /// Test success flow including brands check for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsWithBrandsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-brands-success.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 7);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Brands.Count, 5);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Brands[0], "visa");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Brands[1], "mc");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Brands[2], "amex");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Brands[3], "bcmc");
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods[0].Brands[4], "maestro");
        }

        /// <summary>
        /// Test flow without including brands check for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsWithoutBrandsTest()
        {
            var paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-without-brands-success.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 50);
        }


        /// <summary>
        /// Test success flow for
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public void PaymentSessionSuccessTest()
        {
            var paymentSessionRequest = CreatePaymentSetupRequest();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsession-success.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentSessionResponse = checkout.PaymentSession(paymentSessionRequest);
            Assert.IsNotNull(paymentSessionResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for async
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public async Task PaymentSessionAsyncSuccessTest()
        {
            var paymentSetupRequest = CreatePaymentSetupRequest();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsession-success.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentSetupResponse = await checkout.PaymentSessionAsync(paymentSetupRequest);
            Assert.IsNotNull(paymentSetupResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public void PaymentSessionErrorTest()
        {
            var paymentSetupRequest = CreatePaymentSetupRequest();
            var client =
                CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsession-error-invalid-data-422.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentSetupResponse = checkout.PaymentSession(paymentSetupRequest);
            Assert.IsNull(paymentSetupResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsResultSuccessTest()
        {
            var paymentResultRequest = CreatePaymentVerificationRequest();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsresult-success.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentResultResponse = checkout.VerifyPaymentResult(paymentResultRequest);
            Assert.AreEqual(paymentResultResponse.ResultCode, PaymentVerificationResponse.ResultCodeEnum.Authorised);
        }

        /// <summary>
        /// Test success flow for async
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public async Task PaymentsResultAsyncSuccessTest()
        {
            var paymentVerificationRequest = CreatePaymentVerificationRequest();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsresult-success.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentVerificationResponse = await checkout.VerifyPaymentResultAsync(paymentVerificationRequest);
            Assert.AreEqual(paymentVerificationResponse.ResultCode, PaymentVerificationResponse.ResultCodeEnum.Authorised);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsResultErrorTest()
        {
            var paymentResultRequest = CreatePaymentVerificationRequest();
            var client =
                CreateMockTestClientApiKeyBasedRequestAsync(
                    "Mocks/checkout/paymentsresult-error-invalid-data-payload-422.json");
            var checkout = new ClassicCheckoutSDKService(client);
            var paymentResultResponse = checkout.VerifyPaymentResult(paymentResultRequest);
            Assert.IsNull(paymentResultResponse.ResultCode);
        }

        [TestMethod]
        public void ApplicationInfoTest()
        {
            ApplicationInfo applicationInfo = new ApplicationInfo();
            Assert.AreEqual(applicationInfo.AdyenLibrary.Name, Constants.ClientConfig.LibName);
            Assert.AreEqual(applicationInfo.AdyenLibrary.Version, Constants.ClientConfig.LibVersion);
        }

        [TestMethod]
        public void ClientEndpointsSetTest()
        {
            var client = new Client(new Config());
            Assert.IsNotNull(client.Config.Endpoint);
        }

        [Ignore] // The adyen library info will not be added anymore by default, let's investigate if we should.
        [TestMethod]
        public void PaymentRequestApplicationInfoTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var name = paymentRequest.ApplicationInfo.AdyenLibrary.Name;
            var version = paymentRequest.ApplicationInfo.AdyenLibrary.Version;
            Assert.AreEqual(version, Constants.ClientConfig.LibVersion);
            Assert.AreEqual(name, Constants.ClientConfig.LibName);
        }

        [TestMethod]
        public void PaymentRequestAppInfoExternalTest()
        {
            var externalPlatform = new Model.Checkout.ExternalPlatform();
            var merchantApplication = new Model.Checkout.CommonField();
            externalPlatform.Integrator = "TestExternalPlatformIntegration";
            externalPlatform.Name = "TestExternalPlatformName";
            externalPlatform.Version = "TestExternalPlatformVersion";
            merchantApplication.Name = "MerchantApplicationName";
            merchantApplication.Version = "MerchantApplicationVersion";
            var paymentRequest = CreatePaymentRequestCheckout();
            paymentRequest.ApplicationInfo = new Model.Checkout.ApplicationInfo()
                {
                    ExternalPlatform = externalPlatform,
                    MerchantApplication = merchantApplication
                };
            Assert.AreEqual(paymentRequest.ApplicationInfo.ExternalPlatform.Integrator,
                "TestExternalPlatformIntegration");
            Assert.AreEqual(paymentRequest.ApplicationInfo.ExternalPlatform.Name, "TestExternalPlatformName");
            Assert.AreEqual(paymentRequest.ApplicationInfo.ExternalPlatform.Version, "TestExternalPlatformVersion");
            Assert.AreEqual(paymentRequest.ApplicationInfo.MerchantApplication.Name, "MerchantApplicationName");
            Assert.AreEqual(paymentRequest.ApplicationInfo.MerchantApplication.Version, "MerchantApplicationVersion");
        }


        [TestMethod]
        public void PaymentsOriginTest()
        {
            var paymentMethodsRequest = CreatePaymentRequestCheckout();
            paymentMethodsRequest.Origin = "https://localhost:8080";
            Assert.AreEqual(paymentMethodsRequest.Origin, "https://localhost:8080");
        }

        /// <summary>
        /// Test CreatePaymentLinkRequest
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void CreatePaymentLinkSuccess()
        {
            var createPaymentLinkRequest = new CreatePaymentLinkRequest(store: "TheDemoStore",
                amount: new Amount(currency: "EUR", 1000), merchantAccount: "MerchantAccount", reference: "reference");
            Assert.AreEqual(createPaymentLinkRequest.Store, "TheDemoStore");
        }

        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentLinksSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/payment-links-success.json");
            var checkout = new PaymentLinksService(client);
            var createPaymentLinkRequest = new CreatePaymentLinkRequest(amount: new Amount(currency: "EUR", 1000),
                merchantAccount: "MerchantAccount", reference: "YOUR_ORDER_NUMBER");
            var paymentLinksResponse = checkout.CreatePaymentLink(createPaymentLinkRequest);
            Assert.AreEqual(paymentLinksResponse.Url,
                "https://checkoutshopper-test.adyen.com/checkoutshopper/payByLink.shtml?d=YW1vdW50TWlub3JW...JRA");
            Assert.AreEqual(paymentLinksResponse.ExpiresAt, "2019-12-17T10:05:29Z");
            Assert.AreEqual(paymentLinksResponse.Reference, "YOUR_ORDER_NUMBER");
            Assert.IsNotNull(paymentLinksResponse.Amount);
        }

        /// <summary>
        /// Test success flow for creation of a payment link with recurring payment
        /// POST /paymentLinks
        /// </summary>
        [TestMethod]
        public void CreateRecurringPaymentLinkSuccessTest()
        {
            var client =
                CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentlinks-recurring-payment-success.json");
            var checkout = new PaymentLinksService(client);

            var createPaymentLinkRequest = new CreatePaymentLinkRequest(amount: new Amount(currency: "EUR", 100),
                merchantAccount: "MerchantAccount", reference: "REFERENCE_NUMBER")
            {
                CountryCode = "GR",
                ShopperLocale = "GR",
                ShopperReference = "ShopperReference",
                StorePaymentMethodMode = CreatePaymentLinkRequest.StorePaymentMethodModeEnum.Enabled,
                RecurringProcessingModel = CreatePaymentLinkRequest.RecurringProcessingModelEnum.Subscription
            };

            var paymentLinksResponse = checkout.CreatePaymentLink(createPaymentLinkRequest);

            Assert.AreEqual(createPaymentLinkRequest.Reference, paymentLinksResponse.Reference);
            Assert.AreEqual(
                "https://checkoutshopper-test.adyen.com/checkoutshopper/payByLink.shtml?d=YW1vdW50TWlub3JW...JRA",
                paymentLinksResponse.Url);
            Assert.AreEqual(createPaymentLinkRequest.Amount.Currency, paymentLinksResponse.Amount.Currency);
            Assert.AreEqual(createPaymentLinkRequest.Amount.Value, paymentLinksResponse.Amount.Value);
        }

        /// <summary>
        /// Test success flow for multibanco
        /// Post /payments 
        /// </summary>
        [Ignore]
        [TestMethod]
        public void MultibancoPaymentSuccessMockedTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentsresult-multibanco-success.json");
            var checkout = new PaymentsService(client);
            var paymentRequest = CreatePaymentRequestCheckout();
            var paymentResponse = checkout.Payments(paymentRequest);
            var paymentResponseAction = paymentResponse.Action.GetCheckoutVoucherAction();
            Assert.AreEqual(paymentResponseAction.PaymentMethodType, "multibanco");
            Assert.AreEqual(paymentResponseAction.ExpiresAt, "01/12/2020 09:37:49");
            Assert.AreEqual(paymentResponseAction.Reference, "501 422 944");
            Assert.AreEqual(paymentResponseAction.Entity, "12101");
        }

        /// <summary>
        /// Test RiskData - Clientdata flow for
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void PaymentClientdataParsingTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var riskdata = new RiskData
            {
                ClientData = "IOfW3k9G2PvXFu2j"
            };
            paymentRequest.RiskData = riskdata;
            Assert.AreEqual(paymentRequest.RiskData.ClientData, "IOfW3k9G2PvXFu2j");
        }

        /// <summary>
        /// Test success flow for paypal
        /// Post /payments 
        /// </summary>
        [TestMethod]
        public void PaypalPaymentSuccessTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/payments-success-paypal.json");
            var checkout = new PaymentsService(client);
            var paymentRequest = CreatePaymentRequestCheckout();
            var paymentResponse = checkout.Payments(paymentRequest);
            var result = paymentResponse.Action.GetCheckoutSDKAction();
            Assert.IsNotNull(result);
            Assert.AreEqual("EC-42N19135GM6949000", result.SdkData["orderID"]);
            Assert.AreEqual("Ab02b4c0!BQABAgARb1TvUJa4nwS0Z1nOmxoYfD9+z...", result.PaymentData);
            Assert.AreEqual("paypal", result.PaymentMethodType);
        }

        [TestMethod]
        public void ApplePayDetailsDeserializationTest()
        {
            var json = "{\"type\": \"applepay\",\"applePayToken\": \"VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...\"}";
            var result = JsonSerializer.Deserialize<ApplePayDetails>(json);
            Assert.IsInstanceOfType<ApplePayDetails>(result);
            Assert.AreEqual(result.Type, ApplePayDetails.TypeEnum.Applepay);
        }

        [TestMethod]
        public void BlikDetailsDeserializationTest()
        {
            var json = "{\"type\":\"blik\",\"blikCode\":\"blikCode\"}";
            var result = JsonSerializer.Deserialize<BlikDetails>(json);
            Assert.IsInstanceOfType<BlikDetails>(result);
            Assert.AreEqual(result.Type, BlikDetails.TypeEnum.Blik);
        }

        [TestMethod]
        public void DragonpayDetailsDeserializationTest()
        {
            var json =
                "{\"issuer\":\"issuer\",\"shopperEmail\":\"test@test.com\",\"type\":\"dragonpay_ebanking\"}";
            var result = Util.JsonOperation.Deserialize<DragonpayDetails>(json);
            Assert.IsInstanceOfType<DragonpayDetails>(result);
            Assert.AreEqual(result.Type, DragonpayDetails.TypeEnum.Ebanking);
        }
        
        [TestMethod]
        public void AfterPayDetailsDeserializationTest()
        {
            var json = @"{
                ""resultCode"":""RedirectShopper"",
                ""action"":{
                    ""paymentMethodType"":""afterpaytouch"",
                    ""method"":""GET"",
                    ""url"":""https://checkoutshopper-test.adyen.com/checkoutshopper/checkoutPaymentRedirect?redirectData=..."",
                    ""type"":""redirect""
                }
            }";
            var result = JsonSerializer.Deserialize<PaymentResponse>(json);
            Assert.IsInstanceOfType<CheckoutRedirectAction>(result.Action.GetCheckoutRedirectAction());
            Assert.AreEqual(result.Action.GetCheckoutRedirectAction().PaymentMethodType, "afterpaytouch");
        }
        
        [TestMethod]
        public void AfterPayDetailsSerializationTest()
        {
            var json = @"{
              ""paymentMethod"":{
                        ""type"":""afterpaytouch""
                    },
                    ""amount"":{
                        ""value"":1000,
                        ""currency"":""AUD""
                    },
                ""shopperName"":{
                    ""firstName"":""Simon"",
                    ""lastName"":""Hopper""
                },
                ""shopperEmail"":""s.hopper@example.com"",
                ""shopperReference"":""YOUR_UNIQUE_SHOPPER_ID"",
                ""reference"":""YOUR_ORDER_REFERENCE"",
                ""merchantAccount"":""YOUR_MERCHANT_ACCOUNT"",
                ""returnUrl"":""https://your-company.com/checkout?shopperOrder=12xy.."",
                ""countryCode"":""AU"",
                ""telephoneNumber"":""+61 2 8520 3890"",
                ""billingAddress"":{
                    ""city"":""Sydney"",
                    ""country"":""AU"",
                    ""houseNumberOrName"":""123"",
                    ""postalCode"":""2000"",
                    ""stateOrProvince"":""NSW"",
                    ""street"":""Happy Street""
                },
                ""deliveryAddress"":{
                    ""city"":""Sydney"",
                    ""country"":""AU"",
                    ""houseNumberOrName"":""123"",
                    ""postalCode"":""2000"",
                    ""stateOrProvince"":""NSW"",
                    ""street"":""Happy Street""
                },
                ""lineItems"":[
                { 
                    ""description"":""Shoes"",
                    ""quantity"":""1"",
                    ""amountIncludingTax"":""400"",
                    ""amountExcludingTax"": ""331"",
                    ""taxAmount"": ""69"",
                    ""id"":""Item #1""
                },
                {
                ""description"":""Socks"",
                ""quantity"":""2"",
                ""amountIncludingTax"":""300"",
                ""amountExcludingTax"": ""248"",
                ""taxAmount"": ""52"",
                ""id"":""Item #2""
                 }
                 ]
                 }";
            
            var result = JsonSerializer.Deserialize<PaymentRequest>(json);
            Assert.IsInstanceOfType<AfterpayDetails>(result.PaymentMethod.GetAfterpayDetails());
            Assert.AreEqual(result.PaymentMethod.GetAfterpayDetails().Type, AfterpayDetails.TypeEnum.Afterpaytouch);
        }

        /// <summary>
        /// Test toJson() that includes the type in the action
        /// </summary>
        [TestMethod]
        public void PaymentsResponseToJsonTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var client =
                CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentResponse-3DS-ChallengeShopper.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.Payments(paymentRequest);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, paymentResponse.Action.GetCheckoutThreeDS2Action().Type);
        }

        [TestMethod]
        public void StoredPaymentMethodsTest()
        {
            var client =
                CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-storedpaymentmethods.json");
            var checkout = new PaymentsService(client);
            var paymentMethodsRequest = new PaymentMethodsRequest(merchantAccount: "TestMerchant");
            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(4, paymentMethodsResponse.StoredPaymentMethods.Count);
            Assert.AreEqual("NL32ABNA0515071439", paymentMethodsResponse.StoredPaymentMethods[0].Iban);
            Assert.AreEqual("Adyen", paymentMethodsResponse.StoredPaymentMethods[0].OwnerName);
            Assert.AreEqual("sepadirectdebit", paymentMethodsResponse.StoredPaymentMethods[0].Type);
        }

        /// <summary>
        /// Test if the fraud result are properly deseriazed
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void ThreeDS2Test()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentResponse-3DS2-Action.json");
            var checkout = new PaymentsService(client);
            var paymentResponse = checkout.Payments(paymentRequest);
            var paymentResponseThreeDs2Action = paymentResponse.Action.GetCheckoutThreeDS2Action();
            Assert.AreEqual(ResultCodeEnum.IdentifyShopper, paymentResponse.ResultCode);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, paymentResponseThreeDs2Action.Type);
        }
        
        [TestMethod]
        public void CheckoutLocalDateSerializationTest()
        {
            var checkoutSessionRequest = new CreateCheckoutSessionRequest
            {
                MerchantAccount = "merchant",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Amount = new Amount("EUR", 10000L),
                DateOfBirth = new DateTime(1998, 1, 1, 1, 1, 1),
                ExpiresAt = new DateTime(2023, 4, 1 ,1, 1, 1)
            };
            var json = checkoutSessionRequest.ToJson();
            // Create a DateTime object with minutes and seconds and verify it gets omitted
            Assert.IsTrue(json.Contains("1998-01-01"));
            // Opposite; check that it keeps full ISO string for other Date parameters
            Assert.IsTrue(checkoutSessionRequest.ToJson().Contains("2023-04-01T01:01:01"));
        }

        /// <summary>
        /// Test success sessions
        /// POST /sessions
        /// </summary>
        [TestMethod]
        public void CheckoutSessionSuccessTest()
        {
            var checkoutSessionRequest = new CreateCheckoutSessionRequest
            {
                MerchantAccount = "TestMerchant",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Amount = new Amount("EUR", 10000L),
                Store = "My Store"
            };
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/sessions-success.json");
            var checkout = new PaymentsService(client);
            var checkoutSessionResponse = checkout.Sessions(checkoutSessionRequest);
            Assert.AreEqual("session-test-id", checkoutSessionResponse.Id);
            Assert.AreEqual("TestMerchant", checkoutSessionResponse.MerchantAccount);
            Assert.AreEqual("TestReference", checkoutSessionResponse.Reference);
            Assert.AreEqual("http://test-url.com", checkoutSessionResponse.ReturnUrl);
            Assert.AreEqual("EUR", checkoutSessionResponse.Amount.Currency);
            Assert.AreEqual("1000", checkoutSessionResponse.Amount.Value.ToString());
            Assert.AreEqual("My Store", checkoutSessionResponse.Store);

        }

        /// <summary>
        /// Test success orders
        /// POST /paymentMethods/balance
        /// </summary>
        [TestMethod]
        public void CheckoutPaymentMethodsBalanceSuccessTest()
        {
            var checkoutBalanceCheckRequest = new CheckoutBalanceCheckRequest
            (amount: new Amount("EUR", 10000L),
                merchantAccount: "TestMerchant",
                reference: "TestReference",
                paymentMethod: new Dictionary<string, string>
                {
                    {"type", "givex"},
                    {"number", "4126491073027401"},
                    {"cvc", "737"}
                });
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/paymentmethods-balance-success.json");
            var checkout = new OrdersService(client);
            var checkoutBalanceCheckResponse = checkout.GetBalanceOfGiftCard(checkoutBalanceCheckRequest);
            Assert.AreEqual(CheckoutBalanceCheckResponse.ResultCodeEnum.Success,
                checkoutBalanceCheckResponse.ResultCode);
            Assert.AreEqual("EUR", checkoutBalanceCheckResponse.Balance.Currency);
            Assert.AreEqual("2500", checkoutBalanceCheckResponse.Balance.Value.ToString());
        }

        /// <summary>
        /// Test success orders
        /// POST /orders
        /// </summary>
        [TestMethod]
        public void CheckoutOrderSuccessTest()
        {
            var checkoutCreateOrderRequest = new CheckoutCreateOrderRequest
            (amount: new Amount("EUR", 10000L),
                merchantAccount: "TestMerchant",
                reference: "TestReference");
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/orders-success.json");
            var checkout = new OrdersService(client);
            var checkoutOrdersResponse = checkout.CreateOrder(checkoutCreateOrderRequest);
            Assert.AreEqual(CheckoutCreateOrderResponse.ResultCodeEnum.Success, checkoutOrdersResponse.ResultCode);
            Assert.AreEqual("8515930288670953", checkoutOrdersResponse.PspReference);
            Assert.AreEqual("Ab02b4c0!BQABAgBqxSuFhuXUF7IvIRvSw5bDPHN...", checkoutOrdersResponse.OrderData);
            Assert.AreEqual("EUR", checkoutOrdersResponse.RemainingAmount.Currency);
            Assert.AreEqual("2500", checkoutOrdersResponse.RemainingAmount.Value.ToString());
        }
        
        /// <summary>
        /// Test success orders cancel
        /// POST /orders/cancel
        /// </summary>
        [TestMethod]
        public void CheckoutOrdersCancelSuccessTest()
        {
            var checkoutCancelOrderRequest = new CheckoutCancelOrderRequest
            (merchantAccount: "TestMerchant",
                order: new CheckoutOrder(orderData: "823fh892f8f18f4...148f13f9f3f", pspReference: "8815517812932012"));
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/orders-cancel-success.json");
            var checkout = new OrdersService(client);
            var checkoutOrdersCancelResponse = checkout.CancelOrder(checkoutCancelOrderRequest);
            Assert.AreEqual("Received", checkoutOrdersCancelResponse.ResultCode.ToString());
            Assert.AreEqual("8515931182066678", checkoutOrdersCancelResponse.PspReference);
        }
        
        /// <summary>
        /// Test success orders cancel
        /// GET /storedPaymentMethods
        /// </summary>
        [TestMethod]
        public void GetStoredPaymentMethodsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/get-storedPaymentMethod-success.json");
            var checkout = new RecurringService(client);
            var listStoredPaymentMethodsResponse = checkout.GetTokensForStoredPaymentDetails("shopperRef", "merchantAccount");
            Assert.AreEqual("string", listStoredPaymentMethodsResponse.StoredPaymentMethods[0].Type);
            Assert.AreEqual("merchantAccount", listStoredPaymentMethodsResponse.MerchantAccount);
        }
        
        /// <summary>
        /// Test success orders cancel
        /// GET /storedPaymentMethods
        /// </summary>
        [TestMethod]
        public void DeleteStoredPaymentMethodsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/get-storedPaymentMethod-success.json");
            var checkout = new RecurringService(client);
            checkout.DeleteTokenForStoredPaymentDetails("shopperRef", "merchantAccount");
        }
        
        #region  Modification endpoints tests
        /// <summary>
        /// Test success capture
        /// POST /payments/{paymentPspReference}/captures
        /// </summary>
        [TestMethod]
        public void PaymentsCapturesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/captures-success.json");
            var checkout = new ModificationsService(client);
            var createPaymentCaptureRequest = new CreatePaymentCaptureRequest(amount: new Amount("EUR", 1000L),
                merchantAccount: "test_merchant_account");
            var paymentCaptureResource = checkout.CaptureAuthorisedPayment("12321A", createPaymentCaptureRequest);
            Assert.AreEqual(PaymentCaptureResource.StatusEnum.Received, paymentCaptureResource.Status);
            Assert.AreEqual("my_reference", paymentCaptureResource.Reference);
        }

        /// <summary>
        /// Test success payments cancels
        /// POST /payments/{paymentPspReference}/cancels
        /// </summary>
        [TestMethod]
        public void PaymentsCancelsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/cancels-success.json");
            var checkout = new ModificationsService(client);
            var createPaymentCancelRequest = new CreatePaymentCancelRequest(merchantAccount: "test_merchant_account");
            var paymentCancelResource = checkout.CancelAuthorisedPaymentByPspReference("12321A", createPaymentCancelRequest);
            Assert.AreEqual(PaymentCancelResource.StatusEnum.Received, paymentCancelResource.Status);
            Assert.AreEqual("my_reference", paymentCancelResource.Reference);
        }

        /// <summary>
        /// Test success cancels
        /// POST /cancels
        /// </summary>
        [TestMethod]
        public void CancelsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/standalone-cancels-success.json");
            var checkout = new ModificationsService(client);
            var createStandalonePaymentCancelRequest =
                new CreateStandalonePaymentCancelRequest(merchantAccount: "test_merchant_account");
            var standalonePaymentCancelResource = checkout.CancelAuthorisedPayment(createStandalonePaymentCancelRequest);
            Assert.AreEqual(StandalonePaymentCancelResource.StatusEnum.Received,
                standalonePaymentCancelResource.Status);
            Assert.AreEqual("861633338418518C", standalonePaymentCancelResource.PspReference);
        }

        /// <summary>
        /// Test success payments refunds
        /// POST /payments/{paymentPspReference}/refunds
        /// </summary>
        [TestMethod]
        public void TestPaymentsRefunds()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/refunds-success.json");
            var checkout = new ModificationsService(client);
            var createPaymentRefundRequest = new CreatePaymentRefundRequest(amount: new Amount("EUR", 1000L),
                merchantAccount: "test_merchant_account");
            var paymentRefundResource = checkout.RefundCapturedPayment("12321A", createPaymentRefundRequest);
            Assert.AreEqual(PaymentRefundResource.StatusEnum.Received, paymentRefundResource.Status);
            Assert.AreEqual("my_reference", paymentRefundResource.Reference);
        }

        /// <summary>
        /// Test success payments reversals
        /// POST /payments/{paymentPspReference}/reversals
        /// </summary>
        [TestMethod]
        public void PaymentsReversalsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/reversals-success.json");
            var checkout = new ModificationsService(client);
            var createPaymentReversalRequest =
                new CreatePaymentReversalRequest(merchantAccount: "test_merchant_account");
            var paymentReversalResource = checkout.RefundOrCancelPayment("12321A", createPaymentReversalRequest);
            Assert.AreEqual(PaymentReversalResource.StatusEnum.Received, paymentReversalResource.Status);
            Assert.AreEqual("my_reference", paymentReversalResource.Reference);
        }
        
        /// <summary>
        /// Test success payments cancels
        /// POST /payments/{paymentPspReference}/amountUpdates
        /// </summary>
        [TestMethod]
        public void PaymentsAmountUpdatesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/amount-updates-success.json");
            var checkout = new ModificationsService(client);
            var createPaymentAmountUpdateRequest = new CreatePaymentAmountUpdateRequest(
                amount: new Amount("EUR", 1000L),
                merchantAccount: "test_merchant_account");
            var paymentAmountUpdateResource =
                checkout.UpdateAuthorisedAmount("12321A", createPaymentAmountUpdateRequest);
            Assert.AreEqual(PaymentAmountUpdateResource.StatusEnum.Received, paymentAmountUpdateResource.Status);
            Assert.AreEqual("my_reference", paymentAmountUpdateResource.Reference);
        }

        /// <summary>
        /// Test success donations
        /// POST /donations
        /// </summary>
        [TestMethod]
        public void DonationsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/donations-success.json");
            var checkout = new PaymentsService(client);
            var paymentDonationRequest =
                new PaymentDonationRequest(
                    merchantAccount: "test_merchant_account",
                    amount: new Amount("USD", 5),
                    donationAccount: "Charity_TEST",
                    paymentMethod: new PaymentDonationRequestPaymentMethod(new CardDetails()),
                    reference: "179761FE-1913-4226-9F43-E475DE634BBA",
                    returnUrl: "https://your-company.com/...");
            var donationResponse = checkout.Donations(paymentDonationRequest);
            Assert.AreEqual(DonationResponse.StatusEnum.Completed,
                donationResponse.Status);
            Assert.AreEqual("10720de4-7c5d-4a17-9161-fa4abdcaa5c4", donationResponse.Reference);
        }
        
        /// <summary>
        /// Test success donations
        /// POST /donations
        /// </summary>
        [TestMethod]
        public void CardDetailsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/card-details-success.json");
            var checkout = new PaymentsService(client);
            var cardDetailRequest =
                new CardDetailsRequest
                {
                    MerchantAccount = "TestMerchant",
                    CardNumber = "1234567890",
                    CountryCode = "NL"
                };
            var cardDetailResponse = checkout.ListBrandsOnCard(cardDetailRequest);
            Assert.AreEqual("visa",cardDetailResponse.Brands[0].Type);
            Assert.AreEqual("cartebancaire", cardDetailResponse.Brands[1].Type);
        }
        
        /// <summary>
        /// Test success donations
        /// POST /donations
        /// </summary>
        [TestMethod]
        public void ApplePaySessionsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/checkout/apple-pay-sessions-success.json");
            var checkout = new UtilityService(client);
            var applePaySessionRequest = new CreateApplePaySessionRequest
            {
                DisplayName = "YOUR_MERCHANT_NAME",
                DomainName = "domainName",
                MerchantIdentifier = "234tvsadh34fsghlker3..w35sgfs"
                    
            };
            var applePayResponse = checkout.GetApplePaySessionAsync(applePaySessionRequest).Result;
            Assert.AreEqual("eyJ2Z...340278gdflkaswer",applePayResponse.Data);
        }

        #endregion
    }
}
