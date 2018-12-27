using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CloudApiPosRequestTest : BaseTest
    {

        [TestMethod]
        public void TestCloudApiSyncRequest()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                var client = CreateMockTestClientPosApiRequest("Mocks/terminalapi/pospayment-success.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiAsyncRequest()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                var client = CreateMockTestClientPosApiRequest("Mocks/terminalapi/pospayment-success.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudAsync(paymentRequest);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiTransactionStatusResponseSuccess()
        {
            var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
            var client = CreateMockTestClientPosApiRequest("Mocks/terminalapi/pospayment-transaction-status-response.json");
            var payment = new PosPaymentCloudApi(client);
            var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);

            try
            {
                var transactionStatusResponse = (TransactionStatusResponse)saleToPoiResponse.MessagePayload;
                var messagePayload = transactionStatusResponse.RepeatedMessageResponse.RepeatedResponseMessageBody.MessagePayload;
                var messagePayloadResponse = (dynamic)messagePayload;

                Assert.IsNotNull(saleToPoiResponse);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.ServiceID, "35543420");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.SaleID, "TOSIM_1_1_6");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.POIID, "P400Plus-12345678");
                Assert.AreEqual(transactionStatusResponse.Response.Result, "Success");
                Assert.AreEqual(messagePayloadResponse.PaymentResult.PaymentInstrumentData.CardData.EntryMode[0], "ICC");
                Assert.AreEqual(messagePayloadResponse.POIData.POIReconciliationID, "1000");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
