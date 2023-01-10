#region License

/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2022 Adyen N.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */

#endregion

using Adyen.Model;
using Adyen.Model.ApplicationInformation;
using Adyen.Model.Checkout;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Adyen.Model.Checkout.PaymentResponse;
using Amount = Adyen.Model.Checkout.Amount;
using ApplicationInfo = Adyen.Model.ApplicationInformation.ApplicationInfo;
using CommonField = Adyen.Model.Checkout.CommonField;
using Environment = Adyen.Model.Enum.Environment;
using ExternalPlatform = Adyen.Model.Checkout.ExternalPlatform;
using PaymentDetails = Adyen.Service.Resource.Checkout.PaymentDetails;
using PaymentRequest = Adyen.Model.Checkout.PaymentRequest;

namespace Adyen.Test
{
    [TestClass]
    public class CheckoutTest : BaseTest
    {
        public object CheckoutOrdersResponse { get; private set; }

        /// <summary>
        /// Tests successful checkout client Test URL generation.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointTestEnvironmentSuccessTest()
        {
            Config config = new Config();
            Client client = new Client(config);
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
            Config config = new Config();
            Client client = new Client(config);
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
            Config config = new Config();
            Client client = new Client(config);
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
            Client client = new Client("ws_*******", "******", Environment.Live, "live-url");
            Assert.AreEqual(client.Config.CheckoutEndpoint, "https://live-url-checkout-live.adyenpayments.com/checkout");
        }
        
        /// <summary>
        /// Tests successful checkout client Live URL generation with API key.
        /// </summary>
        [TestMethod]
        public void CheckoutEndpointLiveWithAPIKeyTest()
        {
            Client client = new Client("xapikey", Environment.Live, "live-url");
            Assert.AreEqual(client.Config.CheckoutEndpoint, "https://live-url-checkout-live.adyenpayments.com/checkout");
        }

        /// <summary>
        /// Test success flow for
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void PaymentsAdditionalDataParsingTest()
        {
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-success.json");
            Checkout checkout = new Checkout(client);
            PaymentResponse paymentResponse = checkout.Payments(paymentRequest);
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
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            Client client = CreateAsyncMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-success.json");
            Checkout checkout = new Checkout(client);
            PaymentResponse paymentResponse = await checkout.PaymentsAsync(paymentRequest);
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
            PaymentRequest payment3DS2Request = CreatePaymentRequest3DS2();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-3DS2-IdentifyShopper.json");
            Checkout checkout = new Checkout(client);
            PaymentResponse paymentResponse = checkout.Payments(payment3DS2Request);
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
            PaymentVerificationRequest paymentResultRequest = CreatePaymentVerificationRequest();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/threedsecure2/authorise3ds2-success.json");
            Checkout checkout = new Checkout(client);
            PaymentVerificationResponse paymentResultResponse = checkout.PaymentsResult(paymentResultRequest);
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
            PaymentRequest paymentMethodsRequest = CreatePaymentRequestCheckout();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-error-invalid-data-422.json");
            Checkout checkout = new Checkout(client);
            PaymentResponse paymentResponse = checkout.Payments(paymentMethodsRequest);
            Assert.IsNull(paymentResponse.PspReference);
        }

        /// <summary>
        /// Test success flow for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsTest()
        {
            DetailsRequest detailsRequest = CreateDetailsRequest();
            detailsRequest.Details = new PaymentCompletionDetails(payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-success.json");
            Checkout checkout = new Checkout(client);
            PaymentDetailsResponse paymentResponse = checkout.PaymentDetails(detailsRequest);
            Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

        /// <summary>
        /// Test success flow for async
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public async Task PaymentDetailsAsyncTest()
        {
            DetailsRequest detailsRequest = CreateDetailsRequest();
            detailsRequest.Details =
                new PaymentCompletionDetails(
                    payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            Client client = CreateAsyncMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-success.json");
            Checkout checkout = new Checkout(client);
            PaymentDetailsResponse paymentResponse = await checkout.PaymentDetailsAsync(detailsRequest);
            Assert.AreEqual("8515232733321252", paymentResponse.PspReference);
        }

        /// <summary>
        /// Test error flow for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsErrorTest()
        {
            DetailsRequest detailsRequest = CreateDetailsRequest();
            detailsRequest.Details =
                new PaymentCompletionDetails(
                    payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            Client client =
                CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-error-invalid-data-422.json");
            Checkout checkout = new Checkout(client);
            PaymentDetailsResponse paymentResponse = checkout.PaymentDetails(detailsRequest);
            Assert.IsNull(paymentResponse.ResultCode);
        }

        /// <summary>
        /// Test success deserialization for
        /// POST /payments/details
        /// </summary>
        [TestMethod]
        public void PaymentDetailsResponseDeserializeTest()
        {
            DetailsRequest detailsRequest = CreateDetailsRequest();
            detailsRequest.Details =
                new PaymentCompletionDetails(
                    payload: "Ab02b4c0!BQABAgBQn96RxfJHpp2RXhqQBuhQFWgE...gfGHb4IZSP4IpoCC2==RXhqQBuhQ");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsdetails-action-success.json");
            Checkout checkout = new Checkout(client);
            PaymentDetailsResponse paymentResponse = checkout.PaymentDetails(detailsRequest);
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
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-success.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsResponse paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 32);
        }

        /// <summary>
        /// Test success flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsIssuersTest()
        {
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-success.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsResponse paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
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
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
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
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            Client client = CreateAsyncMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-success.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsResponse paymentMethodsResponse = await checkout.PaymentMethodsAsync(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 32);
        }

        /// <summary>
        /// Test error flow for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsErrorTest()
        {
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-error-forbidden-403.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsResponse paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.IsNull(paymentMethodsResponse.PaymentMethods);
        }

        /// <summary>
        /// Test success flow including brands check for
        /// POST /paymentMethods
        /// </summary>
        [TestMethod]
        public void PaymentMethodsWithBrandsTest()
        {
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-brands-success.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsResponse paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
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
            PaymentMethodsRequest paymentMethodsRequest = CreatePaymentMethodRequest("YourMerchantAccount");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-without-brands-success.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsResponse paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(paymentMethodsResponse.PaymentMethods.Count, 50);
        }


        /// <summary>
        /// Test success flow for
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public void PaymentSessionSuccessTest()
        {
            PaymentSetupRequest paymentSessionRequest = CreatePaymentSetupRequest();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-success.json");
            Checkout checkout = new Checkout(client);
            PaymentSetupResponse paymentSessionResponse = checkout.PaymentSession(paymentSessionRequest);
            Assert.IsNotNull(paymentSessionResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for async
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public async Task PaymentSessionAsyncSuccessTest()
        {
            PaymentSetupRequest paymentSetupRequest = CreatePaymentSetupRequest();
            Client client = CreateAsyncMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-success.json");
            Checkout checkout = new Checkout(client);
            PaymentSetupResponse paymentSetupResponse = await checkout.PaymentSessionAsync(paymentSetupRequest);
            Assert.IsNotNull(paymentSetupResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /paymentSession
        /// </summary>
        [TestMethod]
        public void PaymentSessionErrorTest()
        {
            PaymentSetupRequest paymentSetupRequest = CreatePaymentSetupRequest();
            Client client =
                CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsession-error-invalid-data-422.json");
            Checkout checkout = new Checkout(client);
            PaymentSetupResponse paymentSetupResponse = checkout.PaymentSession(paymentSetupRequest);
            Assert.IsNull(paymentSetupResponse.PaymentSession);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsResultSuccessTest()
        {
            PaymentVerificationRequest paymentResultRequest = CreatePaymentVerificationRequest();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsresult-success.json");
            Checkout checkout = new Checkout(client);
            PaymentVerificationResponse paymentResultResponse = checkout.PaymentsResult(paymentResultRequest);
            Assert.AreEqual(paymentResultResponse.ResultCode, PaymentVerificationResponse.ResultCodeEnum.Authorised);
        }

        /// <summary>
        /// Test success flow for async
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public async Task PaymentsResultAsyncSuccessTest()
        {
            PaymentVerificationRequest paymentVerificationRequest = CreatePaymentVerificationRequest();
            Client client = CreateAsyncMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentsresult-success.json");
            Checkout checkout = new Checkout(client);
            PaymentVerificationResponse paymentVerificationResponse = await checkout.PaymentsResultAsync(paymentVerificationRequest);
            Assert.AreEqual(paymentVerificationResponse.ResultCode, PaymentVerificationResponse.ResultCodeEnum.Authorised);
        }

        /// <summary>
        /// Test success flow for
        /// POST  /payments/result
        /// </summary>
        [TestMethod]
        public void PaymentsResultErrorTest()
        {
            PaymentVerificationRequest paymentResultRequest = CreatePaymentVerificationRequest();
            Client client =
                CreateMockTestClientApiKeyBasedRequest(
                    "Mocks/checkout/paymentsresult-error-invalid-data-payload-422.json");
            Checkout checkout = new Checkout(client);
            PaymentVerificationResponse paymentResultResponse = checkout.PaymentsResult(paymentResultRequest);
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
            Client client = new Client(new Config());
            Assert.IsNotNull(client.Config.Endpoint);
        }

        [Ignore] // The adyen library info will not be added anymore by default, let's investigate if we should.
        [TestMethod]
        public void PaymentRequestApplicationInfoTest()
        {
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            string name = paymentRequest.ApplicationInfo.AdyenLibrary.Name;
            string version = paymentRequest.ApplicationInfo.AdyenLibrary.Version;
            Assert.AreEqual(version, Constants.ClientConfig.LibVersion);
            Assert.AreEqual(name, Constants.ClientConfig.LibName);
        }

        [TestMethod]
        public void PaymentRequestAppInfoExternalTest()
        {
            ExternalPlatform externalPlatform = new Model.Checkout.ExternalPlatform();
            CommonField merchantApplication = new Model.Checkout.CommonField();
            externalPlatform.Integrator = "TestExternalPlatformIntegration";
            externalPlatform.Name = "TestExternalPlatformName";
            externalPlatform.Version = "TestExternalPlatformVersion";
            merchantApplication.Name = "MerchantApplicationName";
            merchantApplication.Version = "MerchantApplicationVersion";
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
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
            PaymentRequest paymentMethodsRequest = CreatePaymentRequestCheckout();
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
            CreatePaymentLinkRequest createPaymentLinkRequest = new CreatePaymentLinkRequest(store: "TheDemoStore",
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payment-links-success.json");
            Checkout checkout = new Checkout(client);
            CreatePaymentLinkRequest createPaymentLinkRequest = new CreatePaymentLinkRequest(amount: new Amount(currency: "EUR", 1000),
                merchantAccount: "MerchantAccount", reference: "YOUR_ORDER_NUMBER");
            PaymentLinkResponse paymentLinksResponse = checkout.PaymentLinks(createPaymentLinkRequest);
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
            Client client =
                CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentlinks-recurring-payment-success.json");
            Checkout checkout = new Checkout(client);

            CreatePaymentLinkRequest createPaymentLinkRequest = new CreatePaymentLinkRequest(amount: new Amount(currency: "EUR", 100),
                merchantAccount: "MerchantAccount", reference: "REFERENCE_NUMBER")
            {
                CountryCode = "GR",
                ShopperLocale = "GR",
                ShopperReference = "ShopperReference",
                StorePaymentMethodMode = CreatePaymentLinkRequest.StorePaymentMethodModeEnum.Enabled,
                RecurringProcessingModel = CreatePaymentLinkRequest.RecurringProcessingModelEnum.Subscription
            };

            PaymentLinkResponse paymentLinksResponse = checkout.PaymentLinks(createPaymentLinkRequest);

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
            Client client = CreateMockTestClientRequest("Mocks/checkout/paymentsresult-multibanco-success.json");
            Checkout checkout = new Checkout(client);
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            PaymentResponse paymentResponse = checkout.Payments(paymentRequest);
            CheckoutVoucherAction paymentResponseAction = paymentResponse.Action.GetCheckoutVoucherAction();
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
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            RiskData riskdata = new RiskData
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
            Client client = CreateMockTestClientRequest("Mocks/checkout/payments-success-paypal.json");
            Checkout checkout = new Checkout(client);
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            PaymentResponse paymentResponse = checkout.Payments(paymentRequest);
            CheckoutSDKAction result = paymentResponse.Action.GetCheckoutSDKAction();
            Assert.IsNotNull(result);
            Assert.AreEqual("EC-42N19135GM6949000", result.SdkData["orderID"]);
            Assert.AreEqual("Ab02b4c0!BQABAgARb1TvUJa4nwS0Z1nOmxoYfD9+z...", result.PaymentData);
            Assert.AreEqual("paypal", result.PaymentMethodType);
        }

        [TestMethod]
        public void ApplePayDetailsDeserializationTest()
        {
            string json = "{\"type\": \"applepay\",\"applePayToken\": \"VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...\"}";
            ApplePayDetails result = Util.JsonOperation.Deserialize<ApplePayDetails>(json);
            Assert.IsInstanceOfType<ApplePayDetails>(result);
            Assert.AreEqual(result.Type, ApplePayDetails.TypeEnum.Applepay);
        }

        [TestMethod]
        public void BlikDetailsDeserializationTest()
        {
            string json = "{\"type\":\"blik\",\"blikCode\":\"blikCode\"}";
            BlikDetails result = JsonConvert.DeserializeObject<BlikDetails>(json);
            Assert.IsInstanceOfType<BlikDetails>(result);
            Assert.AreEqual(result.Type, BlikDetails.TypeEnum.Blik);
        }

        [TestMethod]
        public void DragonpayDetailsDeserializationTest()
        {
            string json =
                "{\"issuer\":\"issuer\",\"shopperEmail\":\"test@test.com\",\"type\":\"dragonpay_ebanking\"}";
            DragonpayDetails result = Util.JsonOperation.Deserialize<DragonpayDetails>(json);
            Assert.IsInstanceOfType<DragonpayDetails>(result);
            Assert.AreEqual(result.Type, DragonpayDetails.TypeEnum.Ebanking);
        }

        [TestMethod]
        public void LianLianPayDetailsDeserializationTest()
        {
            string json = "{\"type\":\"lianlianpay_ebanking_credit\"}";
            CardDetails result = JsonConvert.DeserializeObject<CardDetails>(json);
            Assert.IsInstanceOfType<CardDetails>(result);
            Assert.AreEqual(result.Type, CardDetails.TypeEnum.LianlianpayEbankingCredit);
        }

        /// <summary>
        /// Test toJson() that includes the type in the action
        /// </summary>
        [TestMethod]
        public void PaymentsResponseToJsonTest()
        {
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            Client client =
                CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentResponse-3DS-ChallengeShopper.json");
            Checkout checkout = new Checkout(client);
            PaymentResponse paymentResponse = checkout.Payments(paymentRequest);
            string paymentResponseToJson = paymentResponse.ToJson();
            JObject jObject = JObject.Parse(paymentResponseToJson);
            Assert.AreEqual(jObject["action"]["type"], "threeDS2");
        }

        [TestMethod]
        public void StoredPaymentMethodsTest()
        {
            Client client =
                CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-storedpaymentmethods.json");
            Checkout checkout = new Checkout(client);
            PaymentMethodsRequest paymentMethodsRequest = new PaymentMethodsRequest(merchantAccount: "TestMerchant");
            PaymentMethodsResponse paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
            Assert.AreEqual(4, paymentMethodsResponse.StoredPaymentMethods.Count);
            Assert.AreEqual("NL32ABNA0515071439", paymentMethodsResponse.StoredPaymentMethods[0].Iban);
            Assert.AreEqual("Adyen", paymentMethodsResponse.StoredPaymentMethods[0].OwnerName);
            Assert.AreEqual("sepadirectdebit", paymentMethodsResponse.StoredPaymentMethods[0].Type);
        }

        /*/// <summary>
        /// Test if the fraud result are properly deseriazed
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void FraudResultParsingTest()
        {
            var paymentRequest = CreatePaymentRequestCheckout();
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/payments-success.json");
            var checkout = new Checkout(client);
            var paymentResponse = checkout.Payments(paymentRequest);
            Assert.AreEqual(25, paymentResponse.FraudResult.AccountScore);
            var fraudResults = paymentResponse.FraudResult.Results;
            Assert.IsNotNull(fraudResults);
            Assert.AreEqual(11, fraudResults.Count);
            Assert.AreEqual("CardChunkUsage", fraudResults[0].FraudCheckResult.Name);
            Assert.AreEqual(0, fraudResults[0].FraudCheckResult.AccountScore);
            Assert.AreEqual(2, fraudResults[0].FraudCheckResult.CheckId);
            Assert.AreEqual("PaymentDetailUsage", fraudResults[1].FraudCheckResult.Name);
            Assert.AreEqual(0, fraudResults[1].FraudCheckResult.AccountScore);
            Assert.AreEqual(3, fraudResults[1].FraudCheckResult.CheckId);
        }*/

        /// <summary>
        /// Test if the fraud result are properly deseriazed
        /// POST /payments
        /// </summary>
        [TestMethod]
        public void ThreeDS2Test()
        {
            PaymentRequest paymentRequest = CreatePaymentRequestCheckout();
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentResponse-3DS2-Action.json");
            Checkout checkout = new Checkout(client);
            PaymentResponse paymentResponse = checkout.Payments(paymentRequest);
            CheckoutThreeDS2Action paymentResponseThreeDs2Action = paymentResponse.Action.GetCheckoutThreeDS2Action();
            Assert.AreEqual(ResultCodeEnum.IdentifyShopper, paymentResponse.ResultCode);
            Assert.AreEqual(CheckoutThreeDS2Action.TypeEnum.ThreeDS2, paymentResponseThreeDs2Action.Type);
        }

        /// <summary>
        /// Test success sessions
        /// POST /sessions
        /// </summary>
        [TestMethod]
        public void CheckoutSessionSuccessTest()
        {
            CreateCheckoutSessionRequest checkoutSessionRequest = new CreateCheckoutSessionRequest
            {
                MerchantAccount = "TestMerchant",
                Reference = "TestReference",
                ReturnUrl = "http://test-url.com",
                Amount = new Amount("EUR", 10000L),
                Store = "My Store"
            };
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/sessions-success.json");
            Checkout checkout = new Checkout(client);
            CreateCheckoutSessionResponse checkoutSessionResponse = checkout.Sessions(checkoutSessionRequest);
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
            CheckoutBalanceCheckRequest checkoutBalanceCheckRequest = new CheckoutBalanceCheckRequest
            (amount: new Amount("EUR", 10000L),
                merchantAccount: "TestMerchant",
                reference: "TestReference",
                paymentMethod: new Dictionary<string, string>
                {
                    {"type", "givex"},
                    {"number", "4126491073027401"},
                    {"cvc", "737"}
                });
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/paymentmethods-balance-success.json");
            Checkout checkout = new Checkout(client);
            CheckoutBalanceCheckResponse checkoutBalanceCheckResponse = checkout.PaymentMethodsBalance(checkoutBalanceCheckRequest);
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
            CheckoutCreateOrderRequest checkoutCreateOrderRequest = new CheckoutCreateOrderRequest
            (amount: new Amount("EUR", 10000L),
                merchantAccount: "TestMerchant",
                reference: "TestReference");
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/orders-success.json");
            Checkout checkout = new Checkout(client);
            CheckoutCreateOrderResponse checkoutOrdersResponse = checkout.Orders(checkoutCreateOrderRequest);
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
            CheckoutCancelOrderRequest checkoutCancelOrderRequest = new CheckoutCancelOrderRequest
            (merchantAccount: "TestMerchant",
                order: new CheckoutOrder(orderData: "823fh892f8f18f4...148f13f9f3f", pspReference: "8815517812932012"));
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/orders-cancel-success.json");
            Checkout checkout = new Checkout(client);
            CheckoutCancelOrderResponse checkoutOrdersCancelResponse = checkout.OrdersCancel(checkoutCancelOrderRequest);
            Assert.AreEqual("Received", checkoutOrdersCancelResponse.ResultCode.ToString());
            Assert.AreEqual("8515931182066678", checkoutOrdersCancelResponse.PspReference);
        }
        
        #region  Modification endpoints tests
        /// <summary>
        /// Test success capture
        /// POST /payments/{paymentPspReference}/captures
        /// </summary>
        [TestMethod]
        public void PaymentsCapturesTest()
        {
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/captures-success.json");
            Checkout checkout = new Checkout(client);
            CreatePaymentCaptureRequest createPaymentCaptureRequest = new CreatePaymentCaptureRequest(amount: new Amount("EUR", 1000L),
                merchantAccount: "test_merchant_account");
            PaymentCaptureResource paymentCaptureResource = checkout.PaymentsCaptures("12321A", createPaymentCaptureRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/cancels-success.json");
            Checkout checkout = new Checkout(client);
            CreatePaymentCancelRequest createPaymentCancelRequest = new CreatePaymentCancelRequest(merchantAccount: "test_merchant_account");
            PaymentCancelResource paymentCancelResource = checkout.PaymentsCancels("12321A", createPaymentCancelRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/standalone-cancels-success.json");
            Checkout checkout = new Checkout(client);
            CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest =
                new CreateStandalonePaymentCancelRequest(merchantAccount: "test_merchant_account");
            StandalonePaymentCancelResource standalonePaymentCancelResource = checkout.Cancels(createStandalonePaymentCancelRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/refunds-success.json");
            Checkout checkout = new Checkout(client);
            CreatePaymentRefundRequest createPaymentRefundRequest = new CreatePaymentRefundRequest(amount: new Amount("EUR", 1000L),
                merchantAccount: "test_merchant_account");
            PaymentRefundResource paymentRefundResource = checkout.PaymentsRefunds("12321A", createPaymentRefundRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/reversals-success.json");
            Checkout checkout = new Checkout(client);
            CreatePaymentReversalRequest createPaymentReversalRequest =
                new CreatePaymentReversalRequest(merchantAccount: "test_merchant_account");
            PaymentReversalResource paymentReversalResource = checkout.PaymentsReversals("12321A", createPaymentReversalRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/amount-updates-success.json");
            Checkout checkout = new Checkout(client);
            CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest = new CreatePaymentAmountUpdateRequest(
                amount: new Amount("EUR", 1000L),
                merchantAccount: "test_merchant_account");
            PaymentAmountUpdateResource paymentAmountUpdateResource =
                checkout.PaymentsAmountUpdates("12321A", createPaymentAmountUpdateRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/donations-success.json");
            Checkout checkout = new Checkout(client);
            PaymentDonationRequest paymentDonationRequest =
                new PaymentDonationRequest(
                    merchantAccount: "test_merchant_account",
                    amount: new Amount("USD", 5),
                    donationAccount: "Charity_TEST",
                    paymentMethod: new PaymentDonationRequestPaymentMethod(new CardDetails()),
                    reference: "179761FE-1913-4226-9F43-E475DE634BBA",
                    returnUrl: "https://your-company.com/...");
            DonationResponse donationResponse = checkout.Donations(paymentDonationRequest);
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
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkout/card-details-success.json");
            Checkout checkout = new Checkout(client);
            CardDetailsRequest cardDetailRequest =
                new CardDetailsRequest
                {
                    MerchantAccount = "TestMerchant",
                    CardNumber = "1234567890",
                    CountryCode = "NL"
                };
            CardDetailsResponse cardDetailResponse = checkout.CardDetails(cardDetailRequest);
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
            Client client = CreateAsyncMockTestClientApiKeyBasedRequest("Mocks/checkout/apple-pay-sessions-success.json");
            Checkout checkout = new Checkout(client);
            CreateApplePaySessionRequest applePaySessionRequest = new CreateApplePaySessionRequest
            {
                DisplayName = "YOUR_MERCHANT_NAME",
                DomainName = "domainName",
                MerchantIdentifier = "234tvsadh34fsghlker3..w35sgfs"
                    
            };
            ApplePaySessionResponse applePayResponse = checkout.ApplePaySessions(applePaySessionRequest);
            Assert.AreEqual("eyJ2Z...340278gdflkaswer",applePayResponse.Data);
        }

        #endregion
    }
}