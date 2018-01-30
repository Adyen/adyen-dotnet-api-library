using Adyen.EcommLibrary.Model;
using System;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Test
{
    internal class MockPaymentData:BaseTest
    {
        #region Mock payment data 

        public static Config CreateConfingMock()
        {
            return new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname",
                MerchantAccount = "TestMerchant",
                Endpoint = "endpoint",
                HmacKey = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00"
            };
        }

        public static PaymentRequest CreateFullPaymentRequest()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData()
            };

            return paymentRequest;
        }

        public static PaymentRequest3D CreateFullPaymentRequest3D()
        {
            var paymentRequest = new PaymentRequest3D
            {
                MerchantAccount = "MerchantAccount",
                BrowserInfo = CreateMockBrowserInfo(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
            };

            return paymentRequest;
        }

        public static BrowserInfo CreateMockBrowserInfo()
        {
            return new BrowserInfo
            {
                UserAgent = "User-Agent:Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.95 Safari/537.36",
                AcceptHeader = "*/*"
            };
        }

        public static Card CreateTestCard()
        {
            return new Card(Number: "4111111111111111", ExpiryMonth: "08", ExpiryYear: "2018", Cvc: "737", HolderName: "John Smith");
        }

        public static Card CreateTestCard3D()
        {
            return new Card(Number: "5212345678901234", ExpiryMonth: "08", ExpiryYear: "2018", Cvc: "737", HolderName: "John Smith");
        }

        public static string GetTestPspReferenceMocked()
        {
            return "8514836072314693";
        }

       

        #endregion
    }
}
