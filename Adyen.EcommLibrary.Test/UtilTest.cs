using Adyen.EcommLibrary.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class UtilTest : BaseTest
    {
        [TestMethod]
        public void TestDataSign()
        {
            var postParameters = new Dictionary<string, string>
            {
                {Constants.HPPConstants.Fields.MerchantAccount, "ACC"},
                {Constants.HPPConstants.Fields.CurrencyCode, "EUR"}
            };

            var hmacValidator = new HmacValidator();
            var buildSigningString = hmacValidator.BuildSigningString(postParameters);
            Assert.IsTrue(string.Equals("currencyCode:merchantAccount:EUR:ACC", buildSigningString));

            postParameters = new Dictionary<string, string>
            {
                {Constants.HPPConstants.Fields.CurrencyCode, "EUR"},
                {Constants.HPPConstants.Fields.MerchantAccount, "ACC:\\"}
            };

            buildSigningString = hmacValidator.BuildSigningString(postParameters);
            Assert.IsTrue(string.Equals("currencyCode:merchantAccount:EUR:ACC\\:\\\\", buildSigningString));
        }

        [TestMethod]
        public void TestHmac()
        {
            var data = "countryCode:currencyCode:merchantAccount:merchantReference:paymentAmount:sessionValidity:skinCode:NL:EUR:MagentoMerchantTest2:TEST-PAYMENT-2017-02-01-14\\:02\\:05:199:2017-02-02T14\\:02\\:05+01\\:00:PKz2KML1";
            var key = "DFB1EB5485895CFA84146406857104ABB4CBCABDC8AAF103A624C8F6A3EAAB00";
            var hmacValidator = new HmacValidator();
            var ecnrypted = hmacValidator.CalculateHmac(data, key);
            Assert.IsTrue(string.Equals(ecnrypted, "34oR8T1whkQWTv9P+SzKyp8zhusf9n0dpqrm9nsqSJs="));
        }

        [TestMethod]
        public void TestSerializationShopperInteractionDefault()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(default(Model.Enum.ShopperInteraction));
            var serializedPaymentRequest = JsonOperation.SerializeRequest(paymentRequest);
            Assert.IsFalse(serializedPaymentRequest.Contains("shopperInteraction"));
        }

        [TestMethod]
        public void TestSerializationShopperInteractionMoto()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(Model.Enum.ShopperInteraction.Moto);
            var serializedPaymentRequest = JsonOperation.SerializeRequest(paymentRequest);
            StringAssert.Contains(serializedPaymentRequest, nameof(Model.Enum.ShopperInteraction.Moto));
        }
    }
}