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

using Adyen.Constants;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adyen.Model.Payments;
namespace Adyen.Test
{
    [TestClass]
    public class ModificationTest : BaseTest
    {
        [TestMethod]
        public void TestCaptureMockedSuccess()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            Client client = base.CreateMockTestClientRequest("Mocks/capture-success.json");
            Payment modification = new Payment(client);
            //Send capture call with psp refernce
            CaptureRequest captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            ModificationResult captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Response, ModificationResult.ResponseEnum.CaptureReceived);
            Assert.AreEqual(captureRequest.AdditionalData["authorisationType"],"PreAuth");
        }

        [TestMethod]
        public void TestCancelOrRefundReceivedMocked()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            Client client = base.CreateMockTestClientRequest("Mocks/cancelOrRefund-received.json");
            Payment modification = new Payment(client);
            CancelOrRefundRequest cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            ModificationResult cancelOrRefundResult = modification.CancelOrRefund(cancelOrRefundRequest);
            Assert.AreEqual(cancelOrRefundResult.Response, ModificationResult.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void TestRefundReceivedMocked()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            Client client = base.CreateMockTestClientRequest("Mocks/refund-received.json");
            Payment modification = new Payment(client);
            RefundRequest refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);
            ModificationResult refundResult = modification.Refund(refundRequest);
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void TestCancelReceivedMocked()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            Client client = base.CreateMockTestClientRequest("Mocks/cancel-received.json");
            Payment modification = new Payment(client);
            CancelRequest cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            ModificationResult cancelResult = modification.Cancel(cancelRequest);
            Assert.AreEqual(cancelResult.Response, ModificationResult.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void TestAdjustAuthorisationReceivedMocked()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            //Call authorization test
            Client client = base.CreateMockTestClientRequest("Mocks/adjustAuthorisation-received.json");
            Payment modification = new Payment(client);
            AdjustAuthorisationRequest authorisationRequest = base.CreateAdjustAuthorisationRequest(pspReference: paymentResultPspReference);
            ModificationResult adjustAuthorisationResult = modification.AdjustAuthorisation(authorisationRequest);
            Assert.AreEqual(adjustAuthorisationResult.Response, ModificationResult.ResponseEnum.AdjustAuthorisationReceived);
            Assert.AreEqual(adjustAuthorisationResult.PspReference, "853569123456789D");
            Assert.AreEqual(adjustAuthorisationResult.AdditionalData["merchantReference"], "payment - 20190901");
        }

        [TestMethod]
        public void TestCaptureRequest()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            CaptureRequest captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            Assert.IsNotNull(captureRequest.AdditionalData);
        }

        [TestMethod]
        public void TestCancelOrRefundRequest()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            CancelOrRefundRequest cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            Assert.IsNull(cancelOrRefundRequest.AdditionalData);
            Assert.AreEqual(cancelOrRefundRequest.MerchantAccount, "MerchantAccount");
        }
        
        [TestMethod]
        public void TestRefundRequest()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            RefundRequest refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);          
            Assert.IsNull(refundRequest.AdditionalData);
            Assert.AreEqual(refundRequest.MerchantAccount, "MerchantAccount");
        }

        [TestMethod]
        public void TestAdjustAuthorisationRequest()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            AdjustAuthorisationRequest authorisationRequest = base.CreateAdjustAuthorisationRequest(pspReference: paymentResultPspReference);
            Assert.IsNull(authorisationRequest.AdditionalData);
            Assert.AreEqual(authorisationRequest.ModificationAmount, new Amount("EUR",150));
        }

        [TestMethod]
        public void TestCancelRequest()
        {
            string paymentResultPspReference = MockPaymentData.GetTestPspReferenceMocked();
            CancelRequest cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            Assert.IsNull(cancelRequest.AdditionalData);
            Assert.AreEqual(cancelRequest.MerchantAccount, "MerchantAccount");
        }

        [TestMethod]
        public void TestPendingRefundReceived()
        {
            Client client = CreateMockTestClientApiKeyBasedRequest("Mocks/voidPendingRefund-received.json");
            Checkout checkout = new Checkout(client);
            Payment modification = new Payment(client);
            VoidPendingRefundRequest voidPendingRefundRequest = new VoidPendingRefundRequest();
            ModificationResult modificationResult = modification.VoidPendingRefund(voidPendingRefundRequest);
            Assert.AreEqual(modificationResult.Response, ModificationResult.ResponseEnum.VoidPendingRefundReceived);
        }
    }
}
