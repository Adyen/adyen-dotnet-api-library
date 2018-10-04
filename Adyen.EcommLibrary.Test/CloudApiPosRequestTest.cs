using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CloudApiPosRequestTest : BaseTest
    {

        [TestMethod]
        public void TestCloudApiRequest()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                var client = CreateMockTestClientPosApiRequest("Mocks/pospayment-success.json");
                var payment = new PosPayment(client);
                var saleToPoiResponse = payment.TerminalApiCloudAsync(paymentRequest);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
