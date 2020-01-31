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

using Adyen.CloudApiSerialization;
using Adyen.Model.Nexo;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.Test
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
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/pospayment-success.json");
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
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/pospayment-success.json");
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
            var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
            var client =
                CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/pospayment-transaction-status-response.json");
            var payment = new PosPaymentCloudApi(client);
            var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);

            try
            {
                var transactionStatusResponse = (TransactionStatusResponse) saleToPoiResponse.MessagePayload;
                var messagePayloadResponse = transactionStatusResponse.RepeatedMessageResponse
                    .RepeatedResponseMessageBody.MessagePayload;
                Assert.IsNotNull(saleToPoiResponse);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.ServiceID, "35543420");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.SaleID, "TOSIM_1_1_6");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.POIID, "P400Plus-12345678");
                Assert.AreEqual(transactionStatusResponse.Response.Result, ResultType.Success);
                Assert.AreEqual(messagePayloadResponse.PaymentResult.PaymentInstrumentData.CardData.EntryMode[0],
                    EntryModeType.ICC);
                Assert.AreEqual(messagePayloadResponse.POIData.POIReconciliationID, "1000");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiSyncRequestEmptyResponse()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client = CreateMockTestClientPosCloudApiRequest("");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);
                Assert.IsNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiSyncErrorResponse()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client =
                    CreateMockTestClientPosCloudApiRequest(
                        "Mocks/terminalapi/pospayment-notification-error-response.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);
                var messagePayload = (EventNotification) saleToPoiResponse.MessagePayload;
                Assert.AreEqual(saleToPoiResponse.MessageHeader.MessageClass, MessageClassType.Event);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.MessageCategory, MessageCategoryType.Event);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.SaleID, "POSSystemID12345");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.POIID, "P400Plus-12345678");
                Assert.AreEqual(messagePayload.EventToNotify, EventToNotifyType.Reject);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestCloudApiDisplaySuccessResponse()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client =
                    CreateMockTestClientPosCloudApiRequest(
                        "Mocks/terminalapi/display-response-success.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                var response = (DisplayResponse)saleToPoiResponse.MessagePayload;
                Assert.AreEqual(response.OutputResult[0].InfoQualify, InfoQualifyType.Display);
                Assert.AreEqual(response.OutputResult[0].Device, DeviceType.CustomerDisplay);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiReversalResponse()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client =
                    CreateMockTestClientPosCloudApiRequest(
                        "Mocks/terminalapi/pospayment-reversal-response-success.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                var response = (ReversalResponse)saleToPoiResponse.MessagePayload;
                Assert.AreEqual(response.Response.Result, ResultType.Success);
                Assert.AreEqual(response.Response.AdditionalResponse, "store=Store1234&currency=EUR");
                Assert.AreEqual(response.POIData.POITransactionID.TransactionID, "8515661234567890C");
                Assert.AreEqual(response.Response.Result, ResultType.Success);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.MessageClass, MessageClassType.Service);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.MessageCategory, MessageCategoryType.Reversal);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.SaleID, "POSSystemID123456");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.POIID, "P400Plus-1234567890");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiCardAcquisition()
        {
            try
            {
                var mockPath = GetMockFilePath("Mocks/terminalapi/pospayment-card-acquisition-request.json");
                var message = MockFileToString(mockPath);
                var saleToPoiMessageSerializer = new SaleToPoiMessageSerializer();
                var saleToMessage = saleToPoiMessageSerializer.Deserialize(message);
                var messagePayload = (CardAcquisitionRequest)saleToMessage.MessagePayload;
                Assert.IsNotNull(messagePayload);
                Assert.IsNotNull(messagePayload.CardAcquisitionTransaction.ForceEntryMode);
                Assert.AreEqual(messagePayload.CardAcquisitionTransaction.ForceEntryMode[0],ForceEntryModeType.MagStripe);
                Assert.AreEqual(messagePayload.CardAcquisitionTransaction.ForceEntryMode[1], ForceEntryModeType.Contactless);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
