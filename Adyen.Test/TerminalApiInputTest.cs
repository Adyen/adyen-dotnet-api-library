using System;
using Adyen.Model.Nexo;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                var client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/input-request-response.json");
                var terminalCloudApi = new TerminalCloudApi(client);
                var configEndpoint = terminalCloudApi.Client.Config.Endpoint;
                var saleToPoiResponse = terminalCloudApi.TerminalRequestSync(paymentRequest);
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
                var client = CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/repeated-response-message.json");
                var terminalCloudApi = new TerminalCloudApi(client);
                var saleToPoiResponse = terminalCloudApi.TerminalRequestAsync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                var repeatedMessageResponse = (TransactionStatusResponse)saleToPoiResponse.MessagePayload;
                Assert.IsNotNull(repeatedMessageResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTerminalApiCardAcquisitionResponse()
        {
            try
            {
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client =
                    CreateMockTestClientPosCloudApiRequest("mocks/terminalapi/cardAcquisitionResponse-success.json");
                var terminalCloudApi = new TerminalCloudApi(client);
                var saleToPoiResponse = terminalCloudApi.TerminalRequestAsync(paymentRequest);
                var payloadResponse = (CardAcquisitionResponse) saleToPoiResponse.MessagePayload;
                Assert.IsNotNull(payloadResponse.LoyaltyAccount);
                Assert.AreEqual(payloadResponse.LoyaltyAccount[0].LoyaltyAccountID.LoyaltyID, "aaaa:aa:11111:a");
                Assert.AreEqual(payloadResponse.LoyaltyAccount[0].LoyaltyAccountID.EntryMode[0], EntryModeType.Tapped);
                Assert.AreEqual(payloadResponse.LoyaltyAccount[0].LoyaltyAccountID.IdentificationType, IdentificationType.AccountNumber);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
      

    }
}
