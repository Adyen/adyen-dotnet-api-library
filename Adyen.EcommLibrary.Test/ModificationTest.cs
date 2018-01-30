using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class ModificationTest : BaseTest
    {
        [TestMethod]
        public void TestCaptureMockedSuccess()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = base.CreateMockTestClientRequest("Mocks/capture-success.json");
            var modification = new Modification(client);
            //Send capture call with psp refernce
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Response, Adyen.EcommLibrary.Model.Enum.ResponseEnum.CaptureReceived);
        }

       
        [TestMethod]
        public void TestCaptureError167()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = base.CreateMockTestClientRequest("Mocks/capture-error-167.json");
            var modification = new Modification(client);
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Status, "422");
            Assert.AreEqual(captureResult.ErrorCode, "167");
        }


        [TestMethod]
        public void TestCancelOrRefundReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = base.CreateMockTestClientRequest("Mocks/cancelOrRefund-received.json");
            var modification = new Modification(client);
            var cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            var cancelOrRefundResult = modification.CancelOrRefund(cancelOrRefundRequest);
            Assert.AreEqual(cancelOrRefundResult.Response, Adyen.EcommLibrary.Model.Enum.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void TestRefundReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = base.CreateMockTestClientRequest("Mocks/refund-received.json");
            var modification = new Modification(client);
            var refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Refund(refundRequest);
            Assert.AreEqual(refundResult.Response, Adyen.EcommLibrary.Model.Enum.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void TestCancelReceivedMocked()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            var client = base.CreateMockTestClientRequest("Mocks/cancel-received.json");
            var modification = new Modification(client);
            var cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Cancel(cancelRequest);
            Assert.AreEqual(refundResult.Response, Adyen.EcommLibrary.Model.Enum.ResponseEnum.CancelReceived);
        }
    }
}
