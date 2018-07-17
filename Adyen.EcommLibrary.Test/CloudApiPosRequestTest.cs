using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Adyen.EcommLibrary.CloudApiSerialization;
using Adyen.EcommLibrary.HttpClientHandler;
using Adyen.EcommLibrary.HttpClientHandler.Interfaces;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CloudApiPosRequestTest : BaseTest
    {
        private readonly string _apiKey = "AQEyhmfxK....LAG84XwzP5pSpVd";//mock api key

        [TestMethod]
        public void CloudApiRequestTest()
        {
            try
            {
                var config = new Config
                {
                    XApiKey = _apiKey
                };
                //Create a mock pos payment request
                var paymentRequest = MockCloudApiPosRequest.CreatePosPaymentRequest("Request");
                var client = CreateMockTestClientCloudAPiRequest("Mocks/pospayment-success.json", config);
                var payment = new PosPayment(client);
                var saleToPoiResponse = payment.RunTenderAsync(paymentRequest);
                
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
