using System;
using System.Collections.Generic;
using Adyen.Constants;
using Adyen.Model.ApplicationInformation;
using Adyen.Model.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class SaleToAcquirerDataTest
    {
        private readonly string _base64 = "eyJtZXRhZGF0YSI6eyJrZXkiOiJ2YWx1ZSJ9LCJzaG9wcGVyRW1haWwiOiJteWVtYWlsQG1haWwuY29tIiwic2hvcHBlclJlZmVyZW5jZSI6IjEzMTY0MzA4IiwicmVjdXJyaW5nUHJvY2Vzc2luZ01vZGVsIjoiU3Vic2NyaXB0aW9uIiwicmVjdXJyaW5nQ29udHJhY3QiOiJSRUNVUlJJTkcsT05FQ0xJQ0siLCJzaG9wcGVyU3RhdGVtZW50IjoiWU9VUiBTSE9QUEVSIFNUQVRFTUVOVCIsInJlY3VycmluZ0RldGFpbE5hbWUiOiJWQUxVRSIsInJlY3VycmluZ1Rva2VuU2VydmljZSI6IlZBTFVFIiwic3RvcmUiOiJzdG9yZSB2YWx1ZSIsInNjYyI6bnVsbCwibWVyY2hhbnRBY2NvdW50IjoibWVyY2hhbnRBY2NvdW50IiwiY3VycmVuY3kiOiJFVVIiLCJhcHBsaWNhdGlvbkluZm8iOnsiYWR5ZW5MaWJyYXJ5Ijp7Im5hbWUiOiJhZHllbi1kb3RuZXQtYXBpLWxpYnJhcnkiLCJ2ZXJzaW9uIjoiMTQuMi4xIn0sImV4dGVybmFsUGxhdGZvcm0iOnsiaW50ZWdyYXRvciI6ImV4dGVybmFsUGxhdGZvcm1JbnRlZ3JhdG9yIiwibmFtZSI6ImV4dGVybmFsUGxhdGZvcm1OYW1lIiwidmVyc2lvbiI6IjIuMC4wIn0sIm1lcmNoYW50RGV2aWNlIjp7Im9zIjoibWVyY2hhbnREZXZpY2VPUyIsIm9zVmVyc2lvbiI6IjEwLjEyLjYiLCJyZWZlcmVuY2UiOiI0YzMyNzU5ZmFhYTcifX0sInRlbmRlck9wdGlvbiI6IlJlY2VpcHRIYW5kbGVyLEFsbG93UGFydGlhbEF1dGhvcmlzYXRpb24sQXNrR3JhdHVpdHkiLCJhdXRob3Jpc2F0aW9uVHlwZSI6IlByZUF1dGgiLCJhZGRpdGlvbmFsRGF0YSI6eyJrZXkua2V5IjoidmFsdWUiLCJrZXkua2V5VHdvIjoidmFsdWUyIn19";

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
            Assert.AreEqual(saleToAcquirerData.ToBase64(), _base64);
        }
    }
}