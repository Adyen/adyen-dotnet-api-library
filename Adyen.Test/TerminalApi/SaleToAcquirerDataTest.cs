using System;
using System.Collections.Generic;
using System.Linq;
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
            Adyen.Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryVersion +
            "\"},\"externalPlatform\":{\"integrator\":\"externalPlatformIntegrator\",\"name\":\"externalPlatformName\",\"version\":\"2.0.0\"},\"merchantDevice\":{\"os\":\"merchantDeviceOS\",\"osVersion\":\"10.12.6\",\"reference\":\"4c32759faaa7\"}},\"tenderOption\":\"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\"authorisationType\":\"PreAuth\",\"additionalData\":{\"key.key\":\"value\",\"key.keyTwo\":\"value2\"}}";


        private readonly string splitJson =
            "{\"metadata\":{\"key\":\"value\"},\"shopperEmail\":\"myemail@mail.com\",\"shopperReference\":\"13164308\",\"recurringProcessingModel\":\"Subscription\",\"recurringContract\":\"RECURRING,ONECLICK\",\"shopperStatement\":\"YOUR SHOPPER STATEMENT\",\"recurringDetailName\":\"VALUE\",\"recurringTokenService\":\"VALUE\",\"store\":\"store value\",\"scc\":null,\"merchantAccount\":\"merchantAccount\",\"currency\":\"EUR\",\"applicationInfo\":{\"adyenLibrary\":{\"name\":\"adyen-dotnet-api-library\",\"version\":\"" +
            Adyen.Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryVersion +
            "\"},\"externalPlatform\":{\"integrator\":\"externalPlatformIntegrator\",\"name\":\"externalPlatformName\",\"version\":\"2.0.0\"},\"merchantDevice\":{\"os\":\"merchantDeviceOS\",\"osVersion\":\"10.12.6\",\"reference\":\"4c32759faaa7\"}},\"tenderOption\":\"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\"authorisationType\":\"PreAuth\"," +
            "\"additionalData\":{\"key.key\":\"value\",\"key.keyTwo\":\"value2\",\"split.api\":\"1\",\"split.nrOfItems\":\"3\",\"split.totalAmount\":\"62000\",\"split.currencyCode\":\"EUR\",\"split.item1.amount\":\"60000\",\"split.item1.type\":\"BalanceAccount\",\"split.item1.account\":\"BA00000000000000000000001\",\"split.item1.reference\":\"reference_split_1\",\"split.item1.description\":\"description_split_1\",\"split.item2.amount\":\"2000\",\"split.item2.type\":\"Commission\",\"split.item2.reference\":\"reference_commission\",\"split.item2.description\":\"description_commission\",\"split.item3.type\":\"PaymentFee\",\"split.item3.account\":\"BA00000000000000000000001\",\"split.item3.reference\":\"reference_PaymentFee\",\"split.item3.description\":\"description_PaymentFee\"}}";

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
            saleToAcquirerData.AdditionalData = new Dictionary<string, string> { { "key.key", "value" }, { "key.keyTwo", "value2" } };

            string actual = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
            Assert.AreEqual(saleToAcquirerData.ToBase64(), actual);
        }

        [TestMethod]
        public void SplitToBase64Test()
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
            saleToAcquirerData.AdditionalData = new Dictionary<string, string> { { "key.key", "value" }, { "key.keyTwo", "value2" } };

            var splitItem1 = new SplitItem
            {
                Amount = 60000,
                Type = SplitItemType.BalanceAccount,
                Account = "BA00000000000000000000001",
                Reference = "reference_split_1",
                Description = "description_split_1"
            };

            var splitItem2 = new SplitItem
            {
                Amount = 2000,
                Type = SplitItemType.Commission,
                Account = "",
                Reference = "reference_commission",
                Description = "description_commission"
            };

            var splitItem3 = new SplitItem
            {
                Type = SplitItemType.PaymentFee,
                Account = "BA00000000000000000000001",
                Reference = "reference_PaymentFee",
                Description = "description_PaymentFee"
            };

            var split = new Split
            {
                Api = 1,
                TotalAmount = 62000,
                CurrencyCode = "EUR",
                NrOfItems = 3,
                Items = new List<SplitItem> { splitItem1, splitItem2, splitItem3 }
            };

            saleToAcquirerData.AddSplitToAdditionalData(split);
            string actual = Convert.ToBase64String(Encoding.UTF8.GetBytes(splitJson));
            Assert.AreEqual(saleToAcquirerData.ToBase64(), actual);
        }

        [TestMethod]
        public void ConvertToQueryString_EmptyItemsList_ReturnsQueryString()
        {
            var expected = new Dictionary<string, string>
            {
                { "split.api", "1" },
                { "split.nrOfItems", "0" },
                { "split.totalAmount", "62000" },
                { "split.currencyCode", "EUR" }
            };

            var split = new Split
            {
                Api = 1,
                TotalAmount = 62000,
                CurrencyCode = "EUR",
                NrOfItems = 0,
                Items = new List<SplitItem>()
            };
            
            Dictionary<string, string> actual = new SaleToAcquirerData().AddSplitToAdditionalData(split);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertToQueryString_SingleItemList_ReturnsQueryString()
        {
            var expected = new Dictionary<string, string>
            {
                { "split.api", "1" },
                { "split.nrOfItems", "1" },
                { "split.totalAmount", "62000" },
                { "split.currencyCode", "EUR" },
                { "split.item1.amount", "60000" },
                { "split.item1.type", "BalanceAccount" },
                { "split.item1.account", "BA00000000000000000000001" },
                { "split.item1.reference", "reference_split_1" },
                { "split.item1.description", "description_split_1" }
            };

            var split = new Split
            {
                Api = 1,
                TotalAmount = 62000,
                CurrencyCode = "EUR",
                NrOfItems = 1,
                Items = new List<SplitItem>
                {
                    new SplitItem
                    {
                        Amount = 60000,
                        Type = SplitItemType.BalanceAccount,
                        Account = "BA00000000000000000000001",
                        Reference = "reference_split_1",
                        Description = "description_split_1"
                    }
                }
            };

            Dictionary<string, string> actual = new SaleToAcquirerData().AddSplitToAdditionalData(split);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertToQueryString_SingleItemWithNullValues_ShouldNotIncludeNullProperties()
        {
            var expected = new Dictionary<string, string>
            {
                { "split.api", "1" },
                { "split.nrOfItems", "1" },
                { "split.totalAmount", "62000" },
                { "split.currencyCode", "EUR" },
                { "split.item1.type", "Commission" },
                { "split.item1.reference", "reference_split_1" }
            };
            
            var split = new Split
            {
                Api = 1,
                TotalAmount = 62000,
                CurrencyCode = "EUR",
                NrOfItems = 1,
                Items = new List<SplitItem>
                {
                    new SplitItem
                    {
                        Amount = null, // No Amount
                        Type = SplitItemType.Commission,
                        Account = null, // No Account
                        Reference = "reference_split_1",
                        Description = null // No Description
                    }
                }
            };

            Dictionary<string, string> actual = new SaleToAcquirerData().AddSplitToAdditionalData(split);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertToQueryString_MultipleItemsList_ReturnsQueryString()
        {
            var expected = new Dictionary<string, string>
            {
                { "split.api", "1" },
                { "split.nrOfItems", "3" },
                { "split.totalAmount", "62000" },
                { "split.currencyCode", "EUR" },
                { "split.item1.amount", "60000" },
                { "split.item1.type", "BalanceAccount" },
                { "split.item1.account", "BA00000000000000000000001" },
                { "split.item1.reference", "reference_split_1" },
                { "split.item1.description", "description_split_1" },
                { "split.item2.amount", "2000" },
                { "split.item2.type", "Commission" },
                { "split.item2.reference", "reference_commission" },
                { "split.item2.description", "description_commission" },
                { "split.item3.type", "PaymentFee" },
                { "split.item3.reference", "reference_PaymentFee" },
                { "split.item3.description", "description_PaymentFee" }
            };

            var split = new Split
            {
                Api = 1,
                TotalAmount = 62000,
                CurrencyCode = "EUR",
                NrOfItems = 3,
                Items = new List<SplitItem>
                {
                    new SplitItem
                    {
                        Amount = 60000,
                        Type = SplitItemType.BalanceAccount,
                        Account = "BA00000000000000000000001",
                        Reference = "reference_split_1",
                        Description = "description_split_1"
                    },
                    new SplitItem
                    {
                        Amount = 2000,
                        Type = SplitItemType.Commission,
                        Reference = "reference_commission",
                        Description = "description_commission"
                    },
                    new SplitItem
                    {
                        Type = SplitItemType.PaymentFee,
                        Reference = "reference_PaymentFee",
                        Description = "description_PaymentFee"
                    }
                }
            };
            
            Dictionary<string, string> actual = new SaleToAcquirerData().AddSplitToAdditionalData(split);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}