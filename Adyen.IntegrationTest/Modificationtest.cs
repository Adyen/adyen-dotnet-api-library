using System.Net.Http;
using Adyen.HttpClient;
using Adyen.Model.ClassicPayments;
using Adyen.Service;
using Adyen.Service.ClassicPayments;
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
            var modification = new ModificationsService(client);
            //Send capture call with psp refernce
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.CaptureAuthorisation(captureRequest);
            Assert.AreEqual(captureResult.Response, ModificationResult.ResponseEnum.CaptureReceived);
        }

        [TestMethod]
        public void TestCancelOrRefundReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new ModificationsService(client);
            var cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            var cancelOrRefundResult = modification.CancelOrRefundPayment(cancelOrRefundRequest);
            Assert.AreEqual(cancelOrRefundResult.Response, ModificationResult.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void TestRefundReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new ModificationsService(client);
            var refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.RefundCapturedPayment(refundRequest);
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void TestCancelReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new ModificationsService(client);
            var cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.CancelAuthorisation(cancelRequest);
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void TestAdjustAuthorisationReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new ModificationsService(client);
            var adjustAuthorisationtestRequest = base.CreateAdjustAuthorisationtestRequest(pspReference: paymentResultPspReference);
            var adjustAuthorisationtestResult = modification.ChangeTheAuthorisedAmount(adjustAuthorisationtestRequest);
            Assert.AreEqual(adjustAuthorisationtestResult.Response, ModificationResult.ResponseEnum.AdjustAuthorisationReceived);
        }
        
        [TestMethod]
        public void TestTechnicalCancelReceived()
        {
            var pspRef = GetTestPspReference();
            var client = base.CreateApiKeyTestClient();
            var modification = new ModificationsService(client);
            var technicalCancelRequest = new TechnicalCancelRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                OriginalMerchantReference = pspRef,
                Reference = "reference123"
            };
            var techCancelResponse = modification.CancelAuthorisationUsingYourReference(technicalCancelRequest);
            Assert.AreEqual(techCancelResponse.Response, ModificationResult.ResponseEnum.TechnicalCancelReceived);
        }
        
        [TestMethod]
        public void TestDonationReceived()
        {
            var pspRef = GetTestPspReference();
            var client = base.CreateApiKeyTestClient();
            var modification = new ModificationsService(client);
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
                modification.CreateDonationAsync(donationRequest).GetAwaiter().GetResult();
            }
            catch (HttpClientException e)
            {
                Assert.AreEqual(403, e.Code);
            }
        }
    }
}
