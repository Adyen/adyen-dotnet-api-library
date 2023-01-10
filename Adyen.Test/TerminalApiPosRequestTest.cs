#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Security;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalApiPosRequestTest : BaseTest
    {
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
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
            try
            {
               //encrypt the request using encryption credentials
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/pospayment-encrypted-success.json");
                PosPaymentLocalApi posPaymentLocalApi = new PosPaymentLocalApi(client);
                string configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                SaleToPOIResponse saleToPoiResponse = posPaymentLocalApi.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public void TestTerminalApiAsyncRequest()
        {
            try
            {
                //encrypt the request using encryption credentials
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/pospayment-encrypted-success.json");
                PosPaymentLocalApi posPaymentLocalApi = new PosPaymentLocalApi(client);
                string configEndpoint = posPaymentLocalApi.Client.Config.Endpoint;
                Task<SaleToPOIResponse> saleToPoiResponse = posPaymentLocalApi.TerminalApiLocalAsync(paymentRequest, _encryptionCredentialDetails);
                Assert.AreEqual(configEndpoint, @"https://_terminal_:8443/nexo/");
                Assert.IsNotNull(saleToPoiResponse);
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
                //encrypt the request using encryption credentials
                SaleToPOIRequest paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                //create a mock client
                Client client = CreateMockTestClientPosLocalApiRequest("");
                PosPaymentLocalApi posPaymentLocalApi = new PosPaymentLocalApi(client);
                SaleToPOIResponse saleToPoiResponse = posPaymentLocalApi.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails);
                Assert.IsNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }      
    }
}
