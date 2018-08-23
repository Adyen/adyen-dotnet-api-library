<<<<<<< HEAD
﻿using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class TerminalApiPosRequestTest : BaseTest
    {
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
<<<<<<< HEAD
=======
          
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
            _encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyIdentifier = "CryptoKeyIdentifier12345",
                Password = "p@ssw0rd123456"
            };
        }
        
        [TestMethod]
        public void TestTerminalApiRequest()
        {
<<<<<<< HEAD
=======
            var config = new Config();
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
            try
            {
                //dummy header
                var messageHeader = MockNexoMessageHeaderRequest();
               
                //encrypt the request using encryption credentials
<<<<<<< HEAD
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                //create a mock client
                var client = CreateMockTestClientPosApiRequest("Mocks/pospayment-encrypted-success.json");
=======
                var paymentRequest = MockCloudApiPosRequest.CreatePosPaymentRequest("Request");
                //create a mock client
                var client = CreateMockTestClientCloudAPiRequest("Mocks/pospayment-encrypted-success.json", config);
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
                var payment = new PosPayment(client);
                var saleToPoiResponse = payment.RunLocalTenderASync(paymentRequest, messageHeader, _encryptionCredentialDetails);

                Assert.IsNotNull(saleToPoiResponse);
<<<<<<< HEAD
                //assert amount merchantaccount etc
=======
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
