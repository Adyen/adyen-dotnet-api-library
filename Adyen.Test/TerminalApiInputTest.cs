using Adyen.Model.Nexo;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Adyen.Model.Nexo.Message;

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
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/input-request-response.json");
                PosPaymentCloudApi posPaymentLocalApi = new PosPaymentCloudApi(client);
                string configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                SaleToPOIResponse saleToPoiResponse = posPaymentLocalApi.TerminalApiCloudSync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                InputResponse inputResponse = (InputResponse)saleToPoiResponse.MessagePayload;
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
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/repeated-response-message.json");
                PosPaymentCloudApi posPaymentCloudApiApi = new PosPaymentCloudApi(client);

                SaleToPOIResponse saleToPoiResponse = posPaymentCloudApiApi.TerminalApiCloudAsync(paymentRequest);
                Assert.IsNotNull(saleToPoiResponse);
                TransactionStatusResponse repeatedMessageResponse = (TransactionStatusResponse)saleToPoiResponse.MessagePayload;
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
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                Client client =
                    CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/cardAcquisitionResponse-success.json");
                PosPaymentCloudApi posPaymentCloudApiApi = new PosPaymentCloudApi(client);
                SaleToPOIResponse saleToPoiResponse = posPaymentCloudApiApi.TerminalApiCloudAsync(paymentRequest);
                CardAcquisitionResponse payloadResponse = (CardAcquisitionResponse) saleToPoiResponse.MessagePayload;
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
