using System;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.Terminal;
using Adyen.Model.TerminalApi;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiCloudRequestTest : BaseTest
    {
        private TerminalApiRequest _paymentRequest;

        [TestInitialize]
        public void Init()
        {
            //Create a mock pos payment request
            _paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
        }

        [TestMethod]
        public void TestCloudApiSyncRequest()
        {
            try
            {
                var client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
                var payment = new TerminalCloudApi(client);
                var saleToPoiResponse = payment.TerminalRequestSync(_paymentRequest);

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
                var client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-success.json");
                var payment = new TerminalCloudApi(client);
                var saleToPoiResponse = payment.TerminalRequestAsync(_paymentRequest);

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
            var client =
                CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/pospayment-transaction-status-response.json");
            var payment = new TerminalCloudApi(client);
            var terminalApiResponse = payment.TerminalRequestSync(_paymentRequest);
        
            try
            {
                var transactionStatusResponse = terminalApiResponse.SaleToPOIResponse.TransactionStatusResponse;
                var messagePayload = transactionStatusResponse.RepeatedMessageResponse.RepeatedResponseMessageBody.PaymentResponse;
                
                 Assert.IsNotNull(terminalApiResponse);
                 Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.ServiceID, "35543420");
                 Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.SaleID, "TOSIM_1_1_6");
                 Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.POIID, "P400Plus-12345678");
                 Assert.AreEqual(transactionStatusResponse.Response.Result, Result.Success);
                Assert.AreEqual(messagePayload.PaymentResult.PaymentInstrumentData.CardData.EntryMode[0],
                    CardData.EntryModeEnum.ICC);
                Assert.AreEqual(messagePayload.POIData.POIReconciliationID, 1000);
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
                var client = CreateMockTestClientPosCloudApiRequest("");
                var payment = new TerminalCloudApi(client);
                var saleToPoiResponse = payment.TerminalRequestSync(_paymentRequest);
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
                var client =
                    CreateMockTestClientPosCloudApiRequest(
                        "mocks/terminalapi/pospayment-notification-error-response.json");
                var payment = new TerminalCloudApi(client);
                var terminalApiResponse = payment.TerminalRequestSync(_paymentRequest);
                var eventNotification = terminalApiResponse.SaleToPOIRequest.EventNotification;
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.MessageCategory, MessageCategory.Event);
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.SaleID, "POSSystemID12345");
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.POIID, "P400Plus-12345678");
                Assert.AreEqual(eventNotification.EventToNotify, EventToNotify.Reject);
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
                var client =
                    CreateMockTestClientPosCloudApiRequest(
                        "mocks/terminalapi/display-response-success.json");
                var payment = new TerminalCloudApi(client);
                var terminalApiResponse = payment.TerminalRequestSync(_paymentRequest);
                Assert.IsNotNull(terminalApiResponse);
                var response = terminalApiResponse.SaleToPOIResponse.DisplayResponse;
                Assert.AreEqual(response.OutputResult[0].InfoQualify, InfoQualify.Display);
                Assert.AreEqual(response.OutputResult[0].Device, Device.CustomerDisplay);
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
                var client =
                    CreateMockTestClientPosCloudApiRequest(
                        "mocks/terminalapi/pospayment-reversal-response-success.json");
                var payment = new TerminalCloudApi(client);
                var terminalApiResponse = payment.TerminalRequestSync(_paymentRequest);
                Assert.IsNotNull(terminalApiResponse);
                var response = terminalApiResponse.SaleToPOIResponse.ReversalResponse;
                Assert.AreEqual(response.Response.Result, Result.Success);
                Assert.AreEqual(response.Response.AdditionalResponse, "store=Store1234&currency=EUR");
                Assert.AreEqual(response.POIData.POITransactionID.TransactionID, "8515661234567890C");
                Assert.AreEqual(response.Response.Result, Result.Success);
                Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.MessageClass, MessageClass.Service);
                Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.MessageCategory, MessageCategory.Reversal);
                Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.SaleID, "POSSystemID123456");
                Assert.AreEqual(terminalApiResponse.SaleToPOIResponse.MessageHeader.POIID, "P400Plus-1234567890");
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
                var mockPath = GetMockFilePath("mocks/terminalapi/pospayment-card-acquisition-request.json");
                var message = MockFileToString(mockPath);
                var terminalApiResponse = TerminalApiResponse.FromJson(message);
                var messagePayload = terminalApiResponse.SaleToPOIRequest.CardAcquisitionRequest;
                Assert.IsNotNull(messagePayload);
                Assert.IsNotNull(messagePayload.CardAcquisitionTransaction.ForceEntryMode);
                Assert.AreEqual(messagePayload.CardAcquisitionTransaction.ForceEntryMode[0], CardAcquisitionTransaction.ForceEntryModeEnum.MagStripe);
                Assert.AreEqual(messagePayload.CardAcquisitionTransaction.ForceEntryMode[1], CardAcquisitionTransaction.ForceEntryModeEnum.Contactless);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test the async Task TerminalApiCloudSynchronousAsync
        /// </summary>
        [TestMethod]
        public void TestTerminalApiCloudSynchronousAsyncSuccess()
        {
            try
            {
                var client = CreateAsyncMockTestClientApiKeyBasedRequest("mocks/terminalapi/pospayment-success.json");
                var payment = new TerminalCloudApi(client);
                var saleToPoiResponse = payment.TerminalRequestSynchronousAsync(_paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test the async Task TerminalApiCloudAsynchronousAsync
        /// </summary>
        [TestMethod]
        public void TestTerminalApiCloudAsynchronousSuccess()
        {
            try
            {
                var client = CreateAsyncMockTestClientApiKeyBasedRequest("mocks/terminalapi/pospayment-success.json");
                var payment = new TerminalCloudApi(client);
                var saleToPoiResponse = payment.TerminalRequestAsynchronousAsync(_paymentRequest).Result;
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test the async Task TerminalApiCloudSyncronousAsync
        /// </summary>
        [TestMethod]
        public void TestTerminalApiCloudSynchronousAsyncError()
        {
            try
            {
                var client =
                    CreateAsyncMockTestClientApiKeyBasedRequest(
                        "mocks/terminalapi/pospayment-notification-error-response.json");
                var payment = new TerminalCloudApi(client);
                var terminalApiResponse = payment.TerminalRequestSynchronousAsync(_paymentRequest).Result;
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.MessageClass, MessageClass.Event);
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.MessageCategory, MessageCategory.Event);
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.SaleID, "POSSystemID12345");
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.MessageHeader.POIID, "P400Plus-12345678");
                Assert.AreEqual(terminalApiResponse.SaleToPOIRequest.EventNotification.EventToNotify, EventToNotify.Reject);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        /// <summary>
        /// TestCloudApiEndpoint 
        /// </summary>
        [TestMethod]
        public void TestTerminalCloudEndpointLiveSetRegionValue()
        {
            var config = new Config()
            {
                Environment = Environment.Live,
                CloudApiEndPoint = ClientConfig.CloudApiEndPointUSLive
            };
            var client = CreateMockForAdyenClientTest(config);
            var service = new TerminalCloudApi(client);
            service.TerminalRequestAsync(_paymentRequest);
            ClientInterfaceSubstitute.Received().Request(
                "https://terminal-api-live-us.adyen.com/async", Arg.Any<String>(), Arg.Any<RequestOptions>(), null);
        }
        
        /// <summary>
        /// TestCloudApiEndpoint 
        /// </summary>
        [TestMethod]
        public void TestTerminalCloudEndpointLiveSetCustomValue()
        {
            var config = new Config()
            {
                Environment = Environment.Live,
                CloudApiEndPoint = "https://custom-value-endpoint"
            };
            var client = CreateMockForAdyenClientTest(config);
            var service = new TerminalCloudApi(client);
            service.TerminalRequestAsync(_paymentRequest);
            ClientInterfaceSubstitute.Received().Request(
                "https://custom-value-endpoint/async", Arg.Any<String>(), Arg.Any<RequestOptions>(), null);
        }
    }
}
