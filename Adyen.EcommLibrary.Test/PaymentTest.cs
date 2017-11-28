using Adyen.EcommLibrary.Model.Enum;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class PaymentTest : BaseTest
    {
        [TestMethod]
        public void TestAuthoriseSuccessMockedResponse()
        {
            var paymentResult = CreatePaymentResultFromFile("Mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseSuccess3DMocked()
        {
            var client = CreateMockTestClientRequest("Mocks/authorise-success-3d.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);

            Assert.IsNotNull(paymentResult.Md);
            Assert.IsNotNull(paymentResult.IssuerUrl);
            Assert.IsNotNull(paymentResult.PaRequest);
        }

        [TestMethod]
        public void TestAuthorise3DSuccessMocked()
        {
            var client = CreateMockTestClientRequest("Mocks/authorise3d-success.json");
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            var paymentResult = payment.Authorise3D(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }


        [TestMethod]
        public void TestAuthoriseErrorCvcDeclinedMocked()
        {
            var paymentResult = CreatePaymentResultFromFile("Mocks/authorise-error-cvc-declined.json");
            Assert.AreEqual(ResultCodeEnum.Refused, paymentResult.ResultCode);
        }


        [TestMethod]
        public void TestAuthoriseCseSuccessMocked()
        {
            var paymentResult = CreatePaymentResultFromFile("Mocks/authorise-success-cse.json");
            Assert.AreEqual(ResultCodeEnum.Authorised, paymentResult.ResultCode);
        }


        [TestMethod]
        public void TestOpenInvoice()
        {

            var client = CreateMockTestClientRequest("mocks/authorise-success-klarna.json");
            var payment = new Payment(client);
            var paymentRequest = MockOpenInvoicePayment.CreateOpenInvoicePaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);


            Assert.AreEqual("2374421290", paymentResult.AdditionalData["additionalData.acquirerReference"]);
            Assert.AreEqual("klarna", paymentResult.AdditionalData["paymentMethodVariant"]);

        }


        private string GetAdditionalData(Dictionary<string, string> additionalData, string assertKey)
        {
            string result = "";
            if (additionalData.ContainsKey(assertKey))
            {
                result = additionalData[assertKey];
            }
            return result;
        }
    }
}
