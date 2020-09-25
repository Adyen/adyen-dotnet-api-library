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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion
using Adyen.Constants;
using Adyen.Model.ApplicationInformation;
using Adyen.Model.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Adyen.Test
{
    [TestClass]
    public class SaleToAcquirerDataTest
    {
        private readonly string _json = "{\"metadata\":{\"key\":\"value\"},\"shopperEmail\":\"myemail@mail.com\",\"shopperReference\":\"13164308\",\"recurringContract\":\"RECURRING,ONECLICK\",\"shopperStatement\":\"YOUR SHOPPER STATEMENT\",\"recurringDetailName\":\"VALUE\",\"recurringTokenService\":\"VALUE\",\"store\":\"store value\",\"merchantAccount\":\"merchantAccount\",\"currency\":\"EUR\",\"applicationInfo\":{\"adyenLibrary\":{\"name\":\"adyen-dotnet-api-library\",\"version\":\""+ClientConfig.LibVersion+ "\"},\"externalPlatform\":{\"integrator\":\"externalPlatformIntegrator\",\"name\":\"externalPlatformName\",\"version\":\"2.0.0\"},\"merchantDevice\":{\"os\":\"merchantDeviceOS\",\"osVersion\":\"10.12.6\",\"reference\":\"4c32759faaa7\"}},\"tenderOption\":\"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\"authorisationType\":\"PreAuth\",\"additionalData\":{\"key.key\":\"value\",\"key.keyTwo\":\"value2\"}}";

        [TestMethod]
        public void SerializationTest()
        {
            SaleToAcquirerData saleToAcquirerData = new SaleToAcquirerData
            {
                Metadata = new Dictionary<string, string> { { "key", "value" } },
                ShopperEmail = "myemail@mail.com",
                ShopperReference = "13164308",
                RecurringContract = "RECURRING,ONECLICK",
                ShopperStatement = "YOUR SHOPPER STATEMENT",
                RecurringDetailName = "VALUE",
                RecurringTokenService = "VALUE",
                Store = "store value",
                MerchantAccount = "merchantAccount",
                Currency = "EUR",
                AuthorisationType = "PreAuth"
            };
            var applicationInfo = new ApplicationInfo();
            var externalPlatform = new ExternalPlatform
            {
                Integrator = "externalPlatformIntegrator",
                Name = "externalPlatformName",
                Version = "2.0.0"
            };
            applicationInfo.ExternalPlatform = externalPlatform;
            var merchantDevice = new MerchantDevice
            {
                Os = "merchantDeviceOS",
                OsVersion = "10.12.6",
                Reference = "4c32759faaa7"
            };
            applicationInfo.MerchantDevice = merchantDevice;
            saleToAcquirerData.ApplicationInfo = applicationInfo;
            saleToAcquirerData.TenderOption = "ReceiptHandler,AllowPartialAuthorisation,AskGratuity";
            var additionalData = new Dictionary<string, string> { { "key.key", "value" }, { "key.keyTwo", "value2" } };
            saleToAcquirerData.AdditionalData = additionalData;
            Assert.AreEqual(saleToAcquirerData.ToBase64(), JsonToBase64());
        }

        private string JsonToBase64()
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(_json));
        }
    }
}