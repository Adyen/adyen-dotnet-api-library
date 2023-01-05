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
            var achDetails = new AchDetails
            {
                BankAccountNumber = "1234567",
                BankLocationId = "1234567",
                EncryptedBankAccountNumber = "1234asdfg",
                OwnerName = "John Smith"
            };
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "ACH test",
                PaymentMethod = new PaymentDonationRequestPaymentMethod(achDetails),
                ShopperIP = "192.0.2.1",
                Channel = PaymentRequest.ChannelEnum.Web,
                Origin = "https://your-company.com",
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",

            };
            var paymentMethodDetails = paymentRequest.PaymentMethod.GetAchDetails();
            Assert.AreEqual(paymentMethodDetails.Type, AchDetails.TypeEnum.Ach);
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
            var applePay = new ApplePayDetails()
            {
                ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU..."
            };
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("EUR", 1000),
                Reference = "apple pay test",
                PaymentMethod = new PaymentDonationRequestPaymentMethod(applePay),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = paymentRequest.PaymentMethod.GetApplePayDetails();
            Assert.AreEqual(paymentMethodDetails.Type, ApplePayDetails.TypeEnum.Applepay);
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
                PaymentMethod = new PaymentDonationRequestPaymentMethod(new GiropayDetails()),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (GiropayDetails)paymentRequest.PaymentMethod.ActualInstance;
            Assert.AreEqual(paymentMethodDetails.Type, GiropayDetails.TypeEnum.Giropay);
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
                PaymentMethod = new PaymentDonationRequestPaymentMethod(new GooglePayDetails
                {
                    GooglePayToken = "==Payload as retrieved from Google Pay response==",
                    FundingSource = GooglePayDetails.FundingSourceEnum.Debit
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (GooglePayDetails)paymentRequest.PaymentMethod.ActualInstance;
            Assert.AreEqual(paymentMethodDetails.Type, GooglePayDetails.TypeEnum.Googlepay);
            Assert.AreEqual(paymentMethodDetails.GooglePayToken, "==Payload as retrieved from Google Pay response==");
            Assert.AreEqual(paymentMethodDetails.FundingSource, GooglePayDetails.FundingSourceEnum.Debit);
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
                PaymentMethod = new PaymentDonationRequestPaymentMethod(new IdealDetails()
                {
                    Issuer = "1121"
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = paymentRequest.PaymentMethod.GetIdealDetails();
            Assert.AreEqual(paymentMethodDetails.Type, IdealDetails.TypeEnum.Ideal);
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "ideal test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }

        [TestMethod]
        public void TestBacsDirectDebitDetails()
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("GBP", 1000),
                Reference = "bacs direct debit test",
                PaymentMethod = new PaymentDonationRequestPaymentMethod(new BacsDirectDebitDetails
                {
                    BankAccountNumber = "NL0123456789",
                    BankLocationId = "121000358",
                    HolderName = "John Smith"
                }),
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = paymentRequest.PaymentMethod.GetBacsDirectDebitDetails();
            Assert.AreEqual(paymentMethodDetails.Type, BacsDirectDebitDetails.TypeEnum.DirectdebitGB);
            Assert.AreEqual(paymentMethodDetails.BankAccountNumber, "NL0123456789");
            Assert.AreEqual(paymentMethodDetails.BankLocationId, "121000358");
            Assert.AreEqual(paymentMethodDetails.HolderName, "John Smith");
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "bacs direct debit test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }


        [TestMethod]
        public void TestPaypalSuccess()
        {
            var paymentRequest = new PaymentRequest()
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("USD", 1000),
                Reference = "paypal test",
                PaymentMethod = new PaymentDonationRequestPaymentMethod( new PayPalDetails
                {
                    Subtype = PayPalDetails.SubtypeEnum.Sdk,
                    StoredPaymentMethodId = "2345654212345432345"
                }),          
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy.."
            };
            var paymentMethodDetails = (PayPalDetails)paymentRequest.PaymentMethod.ActualInstance;
            Assert.AreEqual(paymentMethodDetails.Type, PayPalDetails.TypeEnum.Paypal);
            Assert.AreEqual(paymentMethodDetails.Subtype, PayPalDetails.SubtypeEnum.Sdk);
        }
        
        [TestMethod]
        public void TestZipSuccess()
        {
            var paymentRequest = new PaymentRequest()
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Amount = new Amount("USD", 1000),
                Reference = "zip test",
                PaymentMethod = new PaymentDonationRequestPaymentMethod(new ZipDetails
                {
                    Type = ZipDetails.TypeEnum.Zip
                }),          
                ReturnUrl = "https://your-company.com/checkout?shopperOrder=12xy..",
            };
            var paymentMethodDetails = (ZipDetails)paymentRequest.PaymentMethod.ActualInstance;
            Assert.AreEqual(paymentMethodDetails.Type, ZipDetails.TypeEnum.Zip);
            Assert.AreEqual(paymentRequest.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentRequest.Reference, "zip test");
            Assert.AreEqual(paymentRequest.ReturnUrl, "https://your-company.com/checkout?shopperOrder=12xy..");
        }
    }
}
