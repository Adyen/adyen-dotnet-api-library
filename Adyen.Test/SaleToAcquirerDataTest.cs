using Adyen.Model.ApplicationInformation;
using Adyen.Model.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.Test
{
    [TestClass]
    public class SaleToAcquirerDataTest
    {
       private string json = "{\r\n  \"metadata\": {\r\n    \"key\": \"value\"\r\n  },\r\n  \"shopperEmail\": \"myemail@mail.com\",\r\n  \"shopperReference\": \"13164308\",\r\n  \"recurringContract\": \"RECURRING,ONECLICK\",\r\n  \"shopperStatement\": \"YOUR SHOPPER STATEMENT\",\r\n  \"recurringDetailName\": \"VALUE\",\r\n  \"recurringTokenService\": \"VALUE\",\r\n  \"store\": \"store value\",\r\n  \"merchantAccount\": \"merchantAccount\",\r\n  \"currency\": \"EUR\",\r\n  \"applicationInfo\": {\r\n    \"adyenLibrary\": {\r\n      \"name\": \"adyen-dotnet-api-library\",\r\n      \"version\": \"3.5.0\"\r\n    },\r\n    \"externalPlatform\": {\r\n      \"integrator\": \"externalPlatformIntegrator\",\r\n      \"name\": \"externalPlatformName\",\r\n      \"version\": \"2.0.0\"\r\n    },\r\n    \"merchantDevice\": {\r\n      \"os\": \"merchantDeviceOS\",\r\n      \"osVersion\": \"10.12.6\",\r\n      \"reference\": \"4c32759faaa7\"\r\n    }\r\n  },\r\n  \"tenderOption\": \"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\r\n  \"additionalData\": {\r\n    \"key.key\": \"value\",\r\n    \"key.keyTwo\": \"value2\"\r\n  }\r\n}";
        
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