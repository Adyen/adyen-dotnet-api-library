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
using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;

namespace Adyen.Test
{
    [TestClass]
    public class SaleToAcquirerDataTest
    {
        private readonly string exptectedSaleToAcquiredataJson = "{\"metadata\":{\"key\":\"value\"},\"shopperEmail\":\"myemail@mail.com\",\"shopperReference\":\"13164308\",\"recurringContract\":\"RECURRING,ONECLICK\",\"shopperStatement\":\"YOUR SHOPPER STATEMENT\",\"recurringDetailName\":\"VALUE\",\"recurringTokenService\":\"VALUE\",\"store\":\"store value\",\"merchantAccount\":\"merchantAccount\",\"currency\":\"EUR\",\"applicationInfo\":{\"adyenLibrary\":{\"name\":\"adyen-dotnet-api-library\",\"version\":\""+ClientConfig.LibVersion+ "\"},\"externalPlatform\":{\"integrator\":\"externalPlatformIntegrator\",\"name\":\"externalPlatformName\",\"version\":\"2.0.0\"},\"merchantDevice\":{\"os\":\"merchantDeviceOS\",\"osVersion\":\"10.12.6\",\"reference\":\"4c32759faaa7\"}},\"tenderOption\":\"ReceiptHandler,AllowPartialAuthorisation,AskGratuity\",\"authorisationType\":\"PreAuth\",\"additionalData\":{\"key.key\":\"value\",\"key.keyTwo\":\"value2\"}}";

        [TestMethod]
        public void SerializationTest()
        {
               Assert.AreEqual(CreateSaleToAcquireData().ToBase64(), JsonToBase64());
        }

        [TestMethod]
        public void SaleToPoiRequestSaleDataTest()
        {
            var saleToPoiRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeader
                {
                    MessageType = MessageType.Request,
                    MessageClass = MessageClassType.Service,
                    MessageCategory = MessageCategoryType.Payment,
                    SaleID = "POSSystemID12345",
                    POIID = "MX915-284251016",
                    ServiceID = DateTime.Now.ToString("ddHHmmss") //this should be unique
                },
                MessagePayload = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleToAcquirerData = CreateSaleToAcquireData().ToBase64(),
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = "PosAuth",
                            TimeStamp = DateTime.Now
                        },
                    },
                    PaymentTransaction = new PaymentTransaction()
                    {
                        AmountsReq = new AmountsReq()
                        {
                            Currency = "EUR",
                            RequestedAmount = 10100
                        }
                    },
                }
            };
            var paymentRequest = (PaymentRequest)saleToPoiRequest.MessagePayload;
            Assert.AreEqual(JsonToBase64(), paymentRequest.SaleData.SaleToAcquirerData);
        }

        private SaleToAcquirerData CreateSaleToAcquireData()
        {
            SaleToAcquirerData saleToAcquirerData = new SaleToAcquirerData
            {
                Metadata = new SortedDictionary<string, string> {{"key", "value"}},
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
            var additionalData = new Dictionary<string, string> {{"key.key", "value"}, {"key.keyTwo", "value2"}};
            saleToAcquirerData.AdditionalData = additionalData;
            return saleToAcquirerData;
        }
        private string JsonToBase64()
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(exptectedSaleToAcquiredataJson));
        }
    }
}