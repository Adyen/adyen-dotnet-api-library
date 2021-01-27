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
            var fraudCheckResults = new List<FraudCheckResult> { new FraudCheckResult(AccountScore: 1, Name: "test1", CheckId: 1), new FraudCheckResult(AccountScore: 2, Name: "test2", CheckId: 1) };
            var fraudResult = new FraudResult(Results: fraudCheckResults, AccountScore: 1);
            var expected = "class FraudResult {\n  AccountScore: 1\n  Results: \n\t{  class FraudCheckResult {\n  AccountScore: 1\n  CheckId: 1\n  Name: test1\n}\n\n class FraudCheckResult {\n  AccountScore: 2\n  CheckId: 1\n  Name: test2\n}\n\n }\n}\n";
            Assert.AreEqual(expected, fraudResult.ToString());
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
