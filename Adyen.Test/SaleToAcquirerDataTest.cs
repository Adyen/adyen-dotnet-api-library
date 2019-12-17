using Adyen.Model.ApplicationInformation;
using Adyen.Model.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.Test
{
    [TestClass]
    public class SaleToAcquirerDataTest
    {
       private readonly string json = "{\"Metadata\":{\"key\":\"value\"},\"ShopperEmail\":\"myemail@mail.com\",\"ShopperReference\":\"13164308\",\"RecurringContract\":\"RECURRING,ONECLICK\",\"ShopperStatement\":\"YOUR SHOPPER STATEMENT\",\"RecurringDetailName\":\"VALUE\",\"RecurringTokenService\":\"VALUE\",\"Store\":\"store value\",\"MerchantAccount\":\"merchantAccount\",\"Currency\":\"EUR\",\"ApplicationInfo\":{\"adyenLibrary\":{\"name\":\"" + Adyen.Constants.ClientConfig.LibName + "\",\"version\":\"" + Adyen.Constants.ClientConfig.LibVersion + "\"},\"externalPlatform\":{\"integrator\":\"externalPlatformIntegrator\",\"name\":\"externalPlatformName\",\"version\":\"2.0.0\"},\"merchantDevice\":{\"os\":\"merchantDeviceOS\",\"osVersion\":\"10.12.6\",\"reference\":\"4c32759faaa7\"}},\"TenderOption\":\"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\"AdditionalData\":{\"key.key\":\"value\",\"key.keyTwo\":\"value2\"}}";

        [TestMethod]
        public void SerializationTest()
        {
            var saleToAcquirerData = new SaleToAcquirerData
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
                Currency = "EUR"
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
            applicationInfo.MerchantDevice = merchantDevice ;
            saleToAcquirerData.ApplicationInfo = applicationInfo;
            saleToAcquirerData.TenderOption = "ReceiptHandler,AllowPartialAuthorisation,AskGratuity";
            var additionalData = new Dictionary<string, string> { { "key.key", "value" },{ "key.keyTwo", "value2" } };
            saleToAcquirerData.AdditionalData = additionalData;
            
            string saleToAcquirerDataToBase64 = saleToAcquirerData.ToBase64();
            Assert.AreEqual(JsonToBase64(), saleToAcquirerDataToBase64);
        }

        private string JsonToBase64()
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(json);
            return System.Convert.ToBase64String(bytes);
        }
    }
}