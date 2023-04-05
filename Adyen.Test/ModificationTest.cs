using Adyen.Model.Payments;
using Adyen.Service.Payments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class ModificationTest : BaseTest
    {
        [TestMethod]
        public void TestCaptureMockedSuccess()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/capture-success.json");
            var modification = new ModificationsService(client);
            //Send capture call with psp refernce
            var captureRequest = CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Response, ModificationResult.ResponseEnum.CaptureReceived);
            Assert.AreEqual(captureRequest.AdditionalData["authorisationType"],"PreAuth");
        }

        [TestMethod]
        public void TestCancelOrRefundReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/cancelOrRefund-received.json");
            var modification = new ModificationsService(client);
            var cancelOrRefundRequest = CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            var cancelOrRefundResult = modification.CancelOrRefund(cancelOrRefundRequest);
            Assert.AreEqual(cancelOrRefundResult.Response, ModificationResult.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void TestRefundReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/refund-received.json");
            var modification = new ModificationsService(client);
            var refundRequest = CreateRefundTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Refund(refundRequest);
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void TestCancelReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/cancel-received.json");
            var modification = new ModificationsService(client);
            var cancelRequest = CreateCancelTestRequest(pspReference: paymentResultPspReference);
            var cancelResult = modification.Cancel(cancelRequest);
            Assert.AreEqual(cancelResult.Response, ModificationResult.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void TestAdjustAuthorisationReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/adjustAuthorisation-received.json");
            var modification = new ModificationsService(client);
            var authorisationRequest = CreateAdjustAuthorisationRequest(pspReference: paymentResultPspReference);
            var adjustAuthorisationResult = modification.AdjustAuthorisation(authorisationRequest);
            Assert.AreEqual(adjustAuthorisationResult.Response, ModificationResult.ResponseEnum.AdjustAuthorisationReceived);
            Assert.AreEqual(adjustAuthorisationResult.PspReference, "853569123456789D");
            Assert.AreEqual(adjustAuthorisationResult.AdditionalData["merchantReference"], "payment - 20190901");
        }

        [TestMethod]
        public void TestCaptureRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var captureRequest = CreateCaptureTestRequest(paymentResultPspReference);
            Assert.IsNotNull(captureRequest.AdditionalData);
        }

        [TestMethod]
        public void TestCancelOrRefundRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var cancelOrRefundRequest = CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            Assert.IsNull(cancelOrRefundRequest.AdditionalData);
            Assert.AreEqual(cancelOrRefundRequest.MerchantAccount, "MerchantAccount");
        }
        
        [TestMethod]
        public void TestRefundRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var refundRequest = CreateRefundTestRequest(pspReference: paymentResultPspReference);          
            Assert.IsNull(refundRequest.AdditionalData);
            Assert.AreEqual(refundRequest.MerchantAccount, "MerchantAccount");
        }

        [TestMethod]
        public void TestAdjustAuthorisationRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var authorisationRequest = CreateAdjustAuthorisationRequest(pspReference: paymentResultPspReference);
            Assert.IsNull(authorisationRequest.AdditionalData);
            Assert.AreEqual(authorisationRequest.ModificationAmount, new Amount("EUR",150));
        }

        [TestMethod]
        public void TestCancelRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var cancelRequest = CreateCancelTestRequest(pspReference: paymentResultPspReference);
            Assert.IsNull(cancelRequest.AdditionalData);
            Assert.AreEqual(cancelRequest.MerchantAccount, "MerchantAccount");
        }

        [TestMethod]
        public void TestPendingRefundReceived()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/voidPendingRefund-received.json");
            var checkout = new ModificationsService(client);
            var modification = new ModificationsService(client);
            var voidPendingRefundRequest = new VoidPendingRefundRequest();
            var modificationResult = modification.VoidPendingRefund(voidPendingRefundRequest);
            Assert.AreEqual(modificationResult.Response, ModificationResult.ResponseEnum.VoidPendingRefundReceived);
        }
    }
}
