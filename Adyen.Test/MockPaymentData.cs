using System;
using System.Collections.Generic;
using Adyen.Constants;
using Adyen.Model.Payments;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    internal class MockPaymentData
    {
        #region Mock payment data 

        public static Config CreateConfigMock()
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

        public static Config CreateConfigApiKeyBasedMock()
        {
            return new Config
            {
                Environment = Environment.Test,
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"//mock api key
            };
        }

        public static PaymentRequest CreateFullPaymentRequest()
        {
            var paymentRequest = new PaymentRequest
            {
                ApplicationInfo = new ApplicationInfo
                {
                    AdyenLibrary = new CommonField(name: ClientConfig.LibName, version: ClientConfig.LibVersion)
                },
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData()
            };
            return paymentRequest;
        }

        public static PaymentRequest3ds2 CreateFullPaymentRequest3DS2()
        {
            var paymentRequest = new PaymentRequest3ds2
            {
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData(),
                ThreeDS2RequestData = new ThreeDS2RequestData(threeDSCompInd: "Y",
                    deviceChannel: "browser"),
                BrowserInfo = CreateMockBrowserInfo(),
            };
            return paymentRequest;
        }

        public static PaymentRequest CreateFullPaymentRequestWithShopperInteraction(PaymentRequest.ShopperInteractionEnum shopperInteraction)
        {
            var paymentRequest = CreateFullPaymentRequest();
            paymentRequest.ShopperInteraction = shopperInteraction;
            return paymentRequest;
        }

        protected static Dictionary<string, string> CreateAdditionalData()
        {
            return new Dictionary<string, string>
            {
                { "liabilityShift", "true"},
                { "fraudResultType", "GREEN"},
                { "authCode", "43733"},
                { "avsResult", "4 AVS not supported for this card type"}
            };
        }

        public static PaymentRequest3d CreateFullPaymentRequest3D()
        {
            var paymentRequest = new PaymentRequest3d
            {
                ApplicationInfo = new ApplicationInfo
                {
                    AdyenLibrary = new CommonField(name: ClientConfig.LibName, version: ClientConfig.LibVersion)
                },
                MerchantAccount = "MerchantAccount",
                BrowserInfo = CreateMockBrowserInfo(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                CaptureDelayHours = 0
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
            return new Card(number: "4111111111111111", expiryMonth: "08", expiryYear: "2018", cvc: "737", holderName: "John Smith");
        }

        public static Card CreateTestCard3D()
        {
            return new Card(number: "5212345678901234", expiryMonth: "08", expiryYear: "2018", cvc: "737", holderName: "John Smith");
        }

        public static string GetTestPspReferenceMocked()
        {
            return "8514836072314693";
        }
        #endregion
    }
}
