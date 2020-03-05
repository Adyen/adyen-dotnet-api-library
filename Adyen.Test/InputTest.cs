using Adyen.Service;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Test
{
    [TestClass]
    public class InputTest : BaseTest
    {
        [TestMethod]
        public void InpturequestTest()
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
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}
