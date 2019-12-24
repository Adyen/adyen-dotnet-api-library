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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Constants;
using Adyen.Model.Enum;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.Test
{
    [TestClass]
    public class PaymentTest : BaseTest
    {
        [TestMethod]
        public void TestAuthoriseBasicAuthenticationSuccessMockedResponse()
        {
            var paymentResult = CreatePaymentResultFromFile("Mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseApiKeyBasedSuccessMockedResponse()
        {
            var paymentResult = CreatePaymentApiKeyBasedResultFromFile("Mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseSuccess3DMocked()
        {
            var client = CreateMockTestClientRequest("Mocks/authorise-success-3d.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);
            Assert.IsNotNull(paymentResult.Md);
            Assert.IsNotNull(paymentResult.IssuerUrl);
            Assert.IsNotNull(paymentResult.PaRequest);
        }

        [TestMethod]
        public void TestAuthorise3DS2IdentifyShopperMocked()
        {
            var client = CreateMockTestClientRequest("Mocks/threedsecure2/authorise-response-identifyshopper.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            var paymentResult = payment.Authorise(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.IdentifyShopper);
            Assert.IsNotNull(paymentResult.PspReference);

            Assert.AreEqual("74044f6c-7d79-4dd1-9859-3b2879a32fb0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDSServerTransID"));
            Assert.AreEqual(@"https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDSMethodURL"));
            Assert.AreEqual("[token]", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2Token"));
        }

        [TestMethod]
        public void TestAuthorise3DS2ChallengeShopperMocked()
        {
            var client = CreateMockTestClientRequest("Mocks/threedsecure2/authorise3ds2-response-challengeshopper.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            var paymentResult = payment.Authorise3DS2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.ChallengeShopper);
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
            var client = CreateMockTestClientRequest("Mocks/threedsecure2/authorise3ds2-success.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            var paymentResult = payment.Authorise3DS2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }

        [TestMethod]
        public void TestAuthorise3DSuccessMocked()
        {
            var client = CreateMockTestClientRequest("Mocks/authorise3d-success.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            var paymentResult = payment.Authorise3D(paymentRequest);
            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }



        [TestMethod]
        public void TestAuthoriseErrorCvcDeclinedMocked()
        {
            var paymentResult = CreatePaymentResultFromFile("Mocks/authorise-error-cvc-declined.json");
            Assert.AreEqual(ResultCodeEnum.Refused, paymentResult.ResultCode);
        }

        [TestMethod]
        public void TestAuthoriseCseSuccessMocked()
        {
            var paymentResult = CreatePaymentResultFromFile("Mocks/authorise-success-cse.json");
            Assert.AreEqual(ResultCodeEnum.Authorised, paymentResult.ResultCode);
        }

        [TestMethod]
        public void TestOpenInvoice()
        {
            var client = CreateMockTestClientRequest("Mocks/authorise-success-klarna.json");
            var payment = new Payment(client);
            var paymentRequest = MockOpenInvoicePayment.CreateOpenInvoicePaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);
            Assert.AreEqual("2374421290", paymentResult.AdditionalData["additionalData.acquirerReference"]);
            Assert.AreEqual("klarna", paymentResult.AdditionalData["paymentMethodVariant"]);
        }

        [TestMethod]
        public void TestPaymentRequestApplicationInfo()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();



            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }
        [TestMethod]
        public void TestPaymentRequest3DApplicationInfo()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
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
