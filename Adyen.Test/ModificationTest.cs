﻿using Adyen.Constants;
using Adyen.Service;
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
            var client = base.CreateMockTestClientRequest("Mocks/capture-success.json");
            var modification = new Modification(client);
            //Send capture call with psp refernce
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Response, Adyen.Model.Enum.ResponseEnum.CaptureReceived);
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
            Assert.AreEqual(cancelOrRefundResult.Response, Adyen.Model.Enum.ResponseEnum.CancelOrRefundReceived);
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
            Assert.AreEqual(refundResult.Response, Adyen.Model.Enum.ResponseEnum.RefundReceived);
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
            Assert.AreEqual(refundResult.Response, Adyen.Model.Enum.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void TestCaptureRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            Assert.IsNotNull(captureRequest.ApplicationInfo);
            Assert.AreEqual(captureRequest.ApplicationInfo.AdyenLibrary.Name,ClientConfig.LibName);
            Assert.AreEqual(captureRequest.ApplicationInfo.AdyenLibrary.Version,ClientConfig.LibVersion);
        }

        [TestMethod]
        public void TestCancelOrRefundRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            Assert.IsNotNull(cancelOrRefundRequest.ApplicationInfo);
            Assert.AreEqual(cancelOrRefundRequest.ApplicationInfo.AdyenLibrary.Name,ClientConfig.LibName);
            Assert.AreEqual(cancelOrRefundRequest.ApplicationInfo.AdyenLibrary.Version,ClientConfig.LibVersion);
        }
        
        [TestMethod]
        public void TestRefundRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);          
            Assert.IsNotNull(refundRequest.ApplicationInfo);
            Assert.AreEqual(refundRequest.ApplicationInfo.AdyenLibrary.Name,ClientConfig.LibName);
            Assert.AreEqual(refundRequest.ApplicationInfo.AdyenLibrary.Version,ClientConfig.LibVersion);
        }

        [TestMethod]
        public void TestCancelRequest()
        {
            var paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            var cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            Assert.IsNotNull(cancelRequest.ApplicationInfo);
            Assert.AreEqual(cancelRequest.ApplicationInfo.AdyenLibrary.Name,ClientConfig.LibName);
            Assert.AreEqual(cancelRequest.ApplicationInfo.AdyenLibrary.Version,ClientConfig.LibVersion);
        }
    }
}
