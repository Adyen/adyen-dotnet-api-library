using System.Net.Http;
using Adyen.HttpClient;
using Adyen.Model.Payments;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class ModificationTest : BaseTest
    {
        [TestMethod]
        public void TestCaptureSuccess()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            //Send capture call with psp refernce
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Response, ModificationResult.ResponseEnum.CaptureReceived);
        }

        [TestMethod]
        public void TestCancelOrRefundReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            var cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            var cancelOrRefundResult = modification.CancelOrRefund(cancelOrRefundRequest);
            Assert.AreEqual(cancelOrRefundResult.Response, ModificationResult.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void TestRefundReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            var refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Refund(refundRequest);
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void TestCancelReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            var cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Cancel(cancelRequest);
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void TestAdjustAuthorisationReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            var adjustAuthorisationtestRequest = base.CreateAdjustAuthorisationtestRequest(pspReference: paymentResultPspReference);
            var adjustAuthorisationtestResult = modification.AdjustAuthorisation(adjustAuthorisationtestRequest);
            Assert.AreEqual(adjustAuthorisationtestResult.Response, ModificationResult.ResponseEnum.AdjustAuthorisationReceived);
        }
        
        [TestMethod]
        public void TestTechnicalCancelReceived()
        {
            var pspRef = GetTestPspReference();
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            var technicalCancelRequest = new TechnicalCancelRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                OriginalMerchantReference = pspRef,
                Reference = "reference123"
            };
            var techCancelResponse = modification.TechnicalCancel(technicalCancelRequest);
            Assert.AreEqual(techCancelResponse.Response, ModificationResult.ResponseEnum.TechnicalCancelReceived);
        }
        
        [TestMethod]
        public void TestDonationReceived()
        {
            var pspRef = GetTestPspReference();
            var client = base.CreateApiKeyTestClient();
            var modification = new Payment(client);
            var donationRequest = new DonationRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                OriginalReference = pspRef,
                Reference = "reference123",
                ModificationAmount = new Amount("EUR",1),
                DonationAccount = "MyCharity_Giving_TEST"

            };
            try
            {
                modification.DonateAsync(donationRequest).GetAwaiter().GetResult();
            }
            catch (HttpClientException e)
            {
                Assert.AreEqual(403, e.Code);
            }
        }
    }
}
