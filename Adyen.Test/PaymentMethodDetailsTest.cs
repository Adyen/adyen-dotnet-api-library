#region Licence
// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.
#endregion

using Adyen.Model.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
   public class PaymentMethodDetailsTest
    {
        [TestMethod]
        public void TestAchPaymentMethod()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "ACH test",
                PaymentMethodDetails = new AchDetails
                {
                    BankAccountNumber = "1234567",
                    BankLocationId = "1234567",
                    EncryptedBankAccountNumber = "1234asdfg",
                    OwnerName = "John Smith"
                },
                ShopperIP = "192.0.2.1",
                Channel = PaymentRequest.ChannelEnum.Web,
                Origin = "https://your-company.com",
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",

            };
            var paymentMethodDetails = (AchDetails)paymentRequest.PaymentMethodDetails;
            Assert.AreEqual(paymentMethodDetails.Type, "ach");
            Assert.AreEqual(paymentMethodDetails.BankAccountNumber, "1234567");
            Assert.AreEqual(paymentMethodDetails.BankLocationId, "1234567");
            Assert.AreEqual(paymentMethodDetails.EncryptedBankAccountNumber, "1234asdfg");
            Assert.AreEqual(paymentMethodDetails.OwnerName, "John Smith");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "ACH test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

       
        [TestMethod]
        public void TestApplePayPaymentMethod()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "apple pay test",
                PaymentMethodDetails = new ApplePayDetails
                {
                    ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU..."
                },
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (ApplePayDetails)paymentRequest.PaymentMethodDetails;
            Assert.AreEqual(paymentMethodDetails.Type, "applepay");
            Assert.AreEqual(paymentMethodDetails.ApplePayToken, "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "apple pay test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void TestGiropayPaymentMethod()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "giro pay test",
                PaymentMethodDetails = new GiropayDetails(),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (GiropayDetails)paymentRequest.PaymentMethodDetails;
            Assert.AreEqual(paymentMethodDetails.Type, "giropay");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "giro pay test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void TestGooglePayPaymentMethod()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "google pay test",
                PaymentMethodDetails = new GooglePayDetails
                {
                    GooglePayToken = "==Payload as retrieved from Google Pay response==",
                    FundingSource = GooglePayDetails.FundingSourceEnum.Credit
                },
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (GooglePayDetails)paymentRequest.PaymentMethodDetails;
            Assert.AreEqual(paymentMethodDetails.Type, "paywithgoogle");
            Assert.AreEqual(paymentMethodDetails.GooglePayToken, "==Payload as retrieved from Google Pay response==");
            Assert.AreEqual(paymentMethodDetails.FundingSource, GooglePayDetails.FundingSourceEnum.Credit);
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "google pay test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void TestIdealPaymentMethod()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "ideal test",
                PaymentMethodDetails = new IdealDetails
                {
                    Issuer = "1121"
                },
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (IdealDetails)paymentRequest.PaymentMethodDetails;
            Assert.AreEqual(paymentMethodDetails.Type, "ideal");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "ideal test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }
    }
}
