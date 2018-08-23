<<<<<<< HEAD
﻿using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
=======
﻿using System;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class CloudApiPosRequestTest : BaseTest
    {
        private readonly string _apiKey = "AQEyhmfxK....LAG84XwzP5pSpVd";//mock api key

        [TestMethod]
        public void TestCloudApiRequest()
        {
            try
            {
<<<<<<< HEAD
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                var client = CreateMockTestClientPosApiRequest("Mocks/pospayment-success.json");
=======
                var config = new Config
                {
                    XApiKey = _apiKey
                };
                //Create a mock pos payment request
                var paymentRequest = MockCloudApiPosRequest.CreatePosPaymentRequest("Request");
                var client = CreateMockTestClientCloudAPiRequest("Mocks/pospayment-success.json", config);
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
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
<<<<<<< HEAD
    
=======
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
