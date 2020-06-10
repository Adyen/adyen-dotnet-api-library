using Adyen.Model.Nexo;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiInputTest : BaseTest
    {
        [TestMethod]
        public void InputRequestTest()
        {
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/input-request-response.json");
                var posPaymentLocalApi = new PosPaymentCloudApi(client);
                var configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                var saleToPoiResponse = posPaymentLocalApi.TerminalApiCloudSync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                var inputResponse = (InputResponse)saleToPoiResponse.MessagePayload;
                Assert.AreEqual(inputResponse.InputResult.Input.MenuEntryNumber.Length,2);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void RepeatedResponseTest()
        {
            try
            {
                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                var client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/repeated-response-message.json");
                var posPaymentCloudApiApi = new PosPaymentCloudApi(client);

                var saleToPoiResponse = posPaymentCloudApiApi.TerminalApiCloudAsync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                var repeatedMessageResponse = (TransactionStatusResponse)saleToPoiResponse.MessagePayload;
                Assert.IsNotNull(repeatedMessageResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

      

    }
}
