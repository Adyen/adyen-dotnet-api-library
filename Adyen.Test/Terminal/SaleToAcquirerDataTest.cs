using System;
using System.Collections.Generic;
using System.Text;
using Adyen.Constants;
using Adyen.Model.ApplicationInformation;
using Adyen.Model.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test.Terminal
{
    [TestClass]
    public class SaleToAcquirerDataTest
    {
        private readonly string json =
            "{\"metadata\":{\"key\":\"value\"},\"shopperEmail\":\"myemail@mail.com\",\"shopperReference\":\"13164308\",\"recurringProcessingModel\":\"Subscription\",\"recurringContract\":\"RECURRING,ONECLICK\",\"shopperStatement\":\"YOUR SHOPPER STATEMENT\",\"recurringDetailName\":\"VALUE\",\"recurringTokenService\":\"VALUE\",\"store\":\"store value\",\"scc\":null,\"merchantAccount\":\"merchantAccount\",\"currency\":\"EUR\",\"applicationInfo\":{\"adyenLibrary\":{\"name\":\"adyen-dotnet-api-library\",\"version\":\"" +
            ClientConfig.LibVersion +
            "\"},\"externalPlatform\":{\"integrator\":\"externalPlatformIntegrator\",\"name\":\"externalPlatformName\",\"version\":\"2.0.0\"},\"merchantDevice\":{\"os\":\"merchantDeviceOS\",\"osVersion\":\"10.12.6\",\"reference\":\"4c32759faaa7\"}},\"tenderOption\":\"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\"authorisationType\":\"PreAuth\",\"additionalData\":{\"key.key\":\"value\",\"key.keyTwo\":\"value2\"},\"split\":null,\"operatorID\":\"1\",\"shiftNumber\":\"2\"}";

        [TestMethod]
        public void SerializationTest()
        {
            SaleToAcquirerData saleToAcquirerData = new SaleToAcquirerData
            {
                Metadata = new SortedDictionary<string, string> { { "key", "value" } },
                ShopperEmail = "myemail@mail.com",
                ShopperReference = "13164308",
                RecurringContract = "RECURRING,ONECLICK",
                ShopperStatement = "YOUR SHOPPER STATEMENT",
                RecurringDetailName = "VALUE",
                RecurringTokenService = "VALUE",
                RecurringProcessingModel = "Subscription",
                Store = "store value",
                Ssc = null,
                MerchantAccount = "merchantAccount",
                Currency = "EUR",
                AuthorisationType = "PreAuth",
                ShiftNumber = "2",
                OperatorID = "1"
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
            saleToAcquirerData.AdditionalData = new Dictionary<string, string> { { "key.key", "value" }, { "key.keyTwo", "value2" } };

            string serializedJson = JsonConvert.SerializeObject(saleToAcquirerData);

            Assert.AreEqual(json, serializedJson);
        }

        [TestMethod]
        public void ToBase64Test()
        {
            SaleToAcquirerData saleToAcquirerData = new SaleToAcquirerData
            {
                Metadata = new SortedDictionary<string, string> { { "key", "value" } },
                ShopperEmail = "myemail@mail.com",
                ShopperReference = "13164308",
                RecurringContract = "RECURRING,ONECLICK",
                ShopperStatement = "YOUR SHOPPER STATEMENT",
                RecurringDetailName = "VALUE",
                RecurringTokenService = "VALUE",
                RecurringProcessingModel = "Subscription",
                Store = "store value",
                Ssc = null,
                MerchantAccount = "merchantAccount",
                Currency = "EUR",
                AuthorisationType = "PreAuth",
                ShiftNumber = "2",
                OperatorID = "1"
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
            saleToAcquirerData.AdditionalData = new Dictionary<string, string> { { "key.key", "value" }, { "key.keyTwo", "value2" } };

            string actual = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

            Assert.AreEqual(saleToAcquirerData.ToBase64(), actual);
        }
    }
}