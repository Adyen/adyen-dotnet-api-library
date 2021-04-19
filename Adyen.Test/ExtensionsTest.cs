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
 * Copyright (c) 2020 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using Adyen.Model.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Adyen.Util;

namespace Adyen.Test
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void TestDeviceRenderOptionsObjectListToString()
        {
            var deviceRenderOptions = new DeviceRenderOptions
            {
                SdkInterface = DeviceRenderOptions.SdkInterfaceEnum.Native,
                SdkUiType = new List<DeviceRenderOptions.SdkUiTypeEnum> { DeviceRenderOptions.SdkUiTypeEnum.MultiSelect, DeviceRenderOptions.SdkUiTypeEnum.OtherHtml }
            };
            var expected = "class DeviceRenderOptions {\n  SdkInterface: Native\n  SdkUiType: \n\t{  MultiSelect\n OtherHtml\n }\n}\n";
            Assert.AreEqual(expected, deviceRenderOptions.ToString());
        }

        [TestMethod]
        public void TestFraudCheckResultObjectListToString()
        {
            //List <FraudREsults> = FraudResults.Result
            var fraudCheckResult1 = new FraudCheckResultContainer
            {
                FraudCheckResult = new FraudCheckResult(AccountScore: 1, Name: "test1", CheckId: 1)
            };
            var fraudCheckResult2 = new FraudCheckResultContainer
            {
                FraudCheckResult = new FraudCheckResult(AccountScore: 2, Name: "test2", CheckId: 2)
            };
            var fraudCheckResultContainers = new List<FraudCheckResultContainer>() { fraudCheckResult1, fraudCheckResult2 };
            var fraudResult = new FraudResult(AccountScore:25, Results: fraudCheckResultContainers);
            var expectedString = "class FraudResult {\n  AccountScore: 25\n  Results: \n\t{  class FraudResults {\n  FraudCheckResult: class FraudCheckResult {\n  AccountScore: 1\n  CheckId: 1\n  Name: test1\n}\n\n}\n\n class FraudResults {\n  FraudCheckResult: class FraudCheckResult {\n  AccountScore: 2\n  CheckId: 2\n  Name: test2\n}\n\n}\n\n }\n}\n";
            Assert.AreEqual(expectedString, fraudResult.ToString());
        }

        [TestMethod]
        public void TestToCollectionsStringEmpty()
        {
            var paymentResultResponse = new PaymentResultResponse(merchantReference:"ref",shopperLocale:"NL", paymentMethod:"applepay");
            var expected = "class PaymentResultResponse {\n  AdditionalData: \n  FraudResult: \n  MerchantReference: ref\n  Order: \n  PaymentMethod: applepay\n  PspReference: \n  RefusalReason: \n  RefusalReasonCode: \n  ResultCode: \n  ServiceError: \n  ShopperLocale: NL\n}\n";
            Assert.AreEqual(expected, paymentResultResponse.ToString());
        }

        [TestMethod]
        public void TestToCollectionsString()
        {
            var paymentResultResponse = new PaymentResultResponse(merchantReference: "ref", shopperLocale: "NL", paymentMethod: "applepay")
            {
                AdditionalData = new Dictionary<string, string> { { "test1", "test1" }, { "test2", "test2" } }
            };
            var expected = "class PaymentResultResponse {\n  AdditionalData: {test1=test1,test2=test2}\n  FraudResult: \n  MerchantReference: ref\n  Order: \n  PaymentMethod: applepay\n  PspReference: \n  RefusalReason: \n  RefusalReasonCode: \n  ResultCode: \n  ServiceError: \n  ShopperLocale: NL\n}\n";
            Assert.AreEqual(expected, paymentResultResponse.ToString());
        }
    }
}
