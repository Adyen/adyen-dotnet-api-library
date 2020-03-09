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

using Adyen.Model;
using System;
using System.Collections.Generic;
using Adyen.Model.Checkout;
using Adyen.Model.Enum;
using Amount = Adyen.Model.Amount;
using BrowserInfo = Adyen.Model.BrowserInfo;
using Card = Adyen.Model.Card;
using Environment = Adyen.Model.Enum.Environment;
using PaymentRequest = Adyen.Model.PaymentRequest;

namespace Adyen.Test
{
    internal class MockPaymentData
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

        public static Config CreateConfingApiKeyBasedMock()
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
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData()
            };
            return paymentRequest;
        }

        public static PaymentRequestThreeDS2 CreateFullPaymentRequest3DS2()
        {
            var paymentRequest = new PaymentRequestThreeDS2
            {
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData(),
                ThreeDS2RequestData = new ThreeDS2RequestData
                {
                    ThreeDSCompInd = DeviceFingerprintCompletedEnum.Y,
                    DeviceChannel = DeviceChannelEnum.Browser
                },
                BrowserInfo = CreateMockBrowserInfo(),
            };
            return paymentRequest;
        }

        public static PaymentRequest CreateFullPaymentRequestWithShopperInteraction(Model.Enum.ShopperInteraction shopperInteraction)
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

        public static Adyen.Model.Checkout.PaymentRequest CreateApplePayPaymentRequest()
        {
            var paymentRequest = new Adyen.Model.Checkout.PaymentRequest
            {
                MerchantAccount = "MerchantAccount",
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                PaymentMethod = new DefaultPaymentMethodDetails
                {
                    Type = "applepay",
                    ApplePayToken = "ApplePayToken"
                }
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
