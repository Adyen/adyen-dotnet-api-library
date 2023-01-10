#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using Adyen.Constants;
using Adyen.Model.Payments;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading;

namespace Adyen.Test
{
    [TestClass]
    public class PaymentTest : BaseTest
    {
        [TestMethod]
        public void TestAuthoriseBasicAuthenticationSuccessMockedResponse()
        {
            PaymentResult paymentResult = CreatePaymentResultFromFile("Mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseApiKeyBasedSuccessMockedResponse()
        {
            PaymentResult paymentResult = CreatePaymentApiKeyBasedResultFromFile("Mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseSuccess3DMocked()
        {
            Client client = CreateMockTestClientRequest("Mocks/authorise-success-3d.json");
            Payment payment = new Payment(client);
            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            PaymentResult paymentResult = payment.Authorise(paymentRequest);
            Assert.IsNotNull(paymentResult.Md);
            Assert.IsNotNull(paymentResult.IssuerUrl);
            Assert.IsNotNull(paymentResult.PaRequest);
        }

        [TestMethod]
        public void TestAuthorise3DS2IdentifyShopperMocked()
        {
            Client client = CreateMockTestClientRequest("Mocks/threedsecure2/authorise-response-identifyshopper.json");
            Payment payment = new Payment(client);
            PaymentRequest3ds2 paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            PaymentResult paymentResult = payment.Authorise(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.IdentifyShopper);
            Assert.IsNotNull(paymentResult.PspReference);

            Assert.AreEqual("74044f6c-7d79-4dd1-9859-3b2879a32fb0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDSServerTransID"));
            Assert.AreEqual(@"https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDSMethodURL"));
            Assert.AreEqual("[token]", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2Token"));
        }

        [TestMethod]
        public void TestAuthorise3DS2ChallengeShopperMocked()
        {
            Client client = CreateMockTestClientRequest("Mocks/threedsecure2/authorise3ds2-response-challengeshopper.json");
            Payment payment = new Payment(client);
            PaymentRequest3ds2 paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            PaymentResult paymentResult = payment.Authorise3DS2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.ChallengeShopper);
            Assert.IsNotNull(paymentResult.PspReference);

            Assert.AreEqual("C", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.transStatus"));
            Assert.AreEqual("Y", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsChallengeMandated"));
            Assert.AreEqual("https://pal-test.adyen.com/threeds2simulator/acs/challenge.shtml", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsURL"));
            Assert.AreEqual("74044f6c-7d79-4dd1-9859-3b2879a32fb1", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.threeDSServerTransID"));
            Assert.AreEqual("01", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.authenticationType"));
            Assert.AreEqual("2.1.0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.messageVersion"));
            Assert.AreEqual("[token]", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2Token"));
            Assert.AreEqual("ba961c4b-33f2-4830-3141-744b8586aeb0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsTransID"));
            Assert.AreEqual("ADYEN-ACS-SIMULATOR", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsReferenceNumber"));
        }

        [TestMethod]
        public void TestAuthorise3DS2SuccessMocked()
        {
            Client client = CreateMockTestClientRequest("Mocks/threedsecure2/authorise3ds2-success.json");
            Payment payment = new Payment(client);
            PaymentRequest3ds2 paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            PaymentResult paymentResult = payment.Authorise3DS2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }

        [TestMethod]
        public void TestAuthorise3DSuccessMocked()
        {
            Client client = CreateMockTestClientRequest("Mocks/authorise3d-success.json");
            Payment payment = new Payment(client);
            PaymentRequest3d paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            PaymentResult paymentResult = payment.Authorise3D(paymentRequest);
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }

        [TestMethod]
        public void TestAuthoriseErrorCvcDeclinedMocked()
        {
            PaymentResult paymentResult = CreatePaymentResultFromFile("Mocks/authorise-error-cvc-declined.json");
            Assert.AreEqual(PaymentResult.ResultCodeEnum.Refused, paymentResult.ResultCode);
        }

        [TestMethod]
        public void TestAuthoriseCseSuccessMocked()
        {
            PaymentResult paymentResult = CreatePaymentResultFromFile("Mocks/authorise-success-cse.json");
            Assert.AreEqual(PaymentResult.ResultCodeEnum.Authorised, paymentResult.ResultCode);
        }
        [Ignore] // Fix this test -> not sure how to add additionalDataOpenInvoice class to paymentrequest
        [TestMethod]
        public void TestOpenInvoice()
        {
            Client client = CreateMockTestClientRequest("Mocks/authorise-success-klarna.json");
            Payment payment = new Payment(client);
            PaymentRequest paymentRequest = MockOpenInvoicePayment.CreateOpenInvoicePaymentRequest();
            PaymentResult paymentResult = payment.Authorise(paymentRequest);
            Assert.AreEqual("2374421290", paymentResult.AdditionalData["additionalData.acquirerReference"]);
            Assert.AreEqual("klarna", paymentResult.AdditionalData["paymentMethodVariant"]);
        }

        [TestMethod]
        public void TestPaymentRequestApplicationInfo()
        {
            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }

        [TestMethod]
        public void TestPaymentRequest3DApplicationInfo()
        {
            PaymentRequest3d paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }

        [TestMethod]
        public void TestAuthenticationResult3ds1Success()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/authentication-result-success-3ds1.json");
            Payment payment = new Payment(client);
            AuthenticationResultRequest authenticationResultRequest = new AuthenticationResultRequest();
            AuthenticationResultResponse authenticationResultResponse = payment.GetAuthenticationResult(authenticationResultRequest);
            Assert.IsNotNull(authenticationResultResponse);
            Assert.IsNotNull(authenticationResultResponse.ThreeDS1Result);
            Assert.IsNull(authenticationResultResponse.ThreeDS2Result);
        }

        [TestMethod]
        public void TestAuthenticationResult3ds2Success()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/authentication-result-success-3ds2.json");
            Payment payment = new Payment(client);
            AuthenticationResultRequest authenticationResultRequest = new AuthenticationResultRequest();
            AuthenticationResultResponse authenticationResultResponse = payment.GetAuthenticationResult(authenticationResultRequest);
            Assert.IsNotNull(authenticationResultResponse);
            Assert.IsNull(authenticationResultResponse.ThreeDS1Result);
            Assert.IsNotNull(authenticationResultResponse.ThreeDS2Result);
        }
        
        [TestMethod]
        public void TestRetrieve3ds2ResultSuccess()
        {
            Client client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/ThreeDS2Result.json");
            Payment payment = new Payment(client);
            AuthenticationResultRequest authenticationResultRequest = new AuthenticationResultRequest();
            ThreeDS2Result ThreeDSTwoResult = payment.Retrieve3DS2Result(authenticationResultRequest);
            Assert.AreEqual("f04ec32b-f46b-46ef-9ccd-44be42fb0d7e", ThreeDSTwoResult.ThreeDSServerTransID);
            Assert.AreEqual("80a16fa0-4eea-43c9-8de5-b0470d09d14d", ThreeDSTwoResult.DsTransID);
            Assert.IsNotNull(ThreeDSTwoResult);
        }
        
        private string GetAdditionalData(Dictionary<string, string> additionalData, string assertKey)
        {
            string result = "";
            if (additionalData.ContainsKey(assertKey))
            {
                result = additionalData[assertKey];
            }
            return result;
        }
    }
}
