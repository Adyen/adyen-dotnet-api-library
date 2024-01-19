using System;
using Adyen.Model.Terminal;
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
                var terminalApiResponse = terminalCloudApi.TerminalRequestSync(paymentRequest);
                Assert.IsNotNull(terminalApiResponse);
                var inputResponse = terminalApiResponse.SaleToPOIResponse.InputResponse;
                Assert.AreEqual(inputResponse.InputResult.Input.MenuEntryNumber.Count,2);
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
                var terminalApiResponse = terminalCloudApi.TerminalRequestAsync(paymentRequest);
                Assert.IsNotNull(terminalApiResponse);
                var repeatedMessageResponse = terminalApiResponse.SaleToPOIResponse.TransactionStatusResponse;
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
                var terminalApiResponse = terminalCloudApi.TerminalRequestAsync(paymentRequest);
                var payloadResponse = terminalApiResponse.SaleToPOIResponse.CardAcquisitionResponse;
                Assert.IsNotNull(payloadResponse.LoyaltyAccount);
                Assert.AreEqual(payloadResponse.LoyaltyAccount[0].LoyaltyAccountID.LoyaltyID, "aaaa:aa:11111:a");
                Assert.AreEqual(payloadResponse.LoyaltyAccount[0].LoyaltyAccountID.EntryMode[0], LoyaltyAccountID.EntryModeEnum.Tapped);
                Assert.AreEqual(payloadResponse.LoyaltyAccount[0].LoyaltyAccountID.IdentificationType, IdentificationType.AccountNumber);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
      

    }
}
