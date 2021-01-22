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
using System.Text;

namespace Adyen.Test
{
    [TestClass]
    public class NotificationDecryptionTest : BaseTest
    {
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
            _encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyIdentifier = "ncrkey",
                Password = "ncrpass"
            };
        }

        [TestMethod]
        public void TestNotificationDecryption()
        {
            try
            {
                var encryptedNotification = @"{""SaleToPOIRequest"":{""SecurityTrailer"":{""AdyenCryptoVersion"":1,""Nonce"":""Be6rAx+vRju2aCHwPh6lrg=="",""KeyIdentifier"":""ncrkey"",""Hmac"":""LG8A9Re1M8xLMr7rDUk0NwsnvAOX+VLjHv9sPHWTl34="",""KeyVersion"":1},""NexoBlob"":""x2DY8J2M9ZCyjOZ8Gt7JdLBA\/6bT\/KXvvAbJf9kzguqO8dWp1I1pPLQpLstpdIiAVqSwG3PR0PrP\/lF82UmhmCnUJGCuEXilqvBNF1tF\/yEgnFOklNc1myR2IPW\/+2oZOWKFXlTo\/gX89EbODXOOGUqaJfSdpDhlqjyMz7mGczobTPvPGqCVx2BDHU8VTxI9nicwQv+QV48GqVZzxnP8ZOdQOQ5cac+bcS0Y3l7SmWpIoQsoicnjahTY9ICosLJmN4DvDHsN4Kh2DAetFO5b9I9Lqgm\/dvnXUVhb9tPbM7Pn+ratjYpaNbonbO5M+Tm8rDEIyKoUUuFXPWISymrCXtCDVKEb2B5S5pilUmokrXVa9Ldtsv3BKG7rbrglYEuql4WVs6kzr6ybgAKh1Q0LsAXEve3pydt72ay4U3FOJSBxJ3gNqmnG8mVW2HCXQVo1RgVaZmP5TBWYuksCKXYypnMulu1PlRI++oeW\/J2qjQU="",""MessageHeader"":{""ProtocolVersion"":""3.0"",""SaleID"":""null"",""MessageClass"":""Event"",""MessageCategory"":""Event"",""POIID"":""P400Plus-275102806"",""MessageType"":""Notification"",""DeviceID"":""5""}}}";
                var expectedDecryption = @"{ ""SaleToPOIRequest"": { ""EventNotification"": { ""EventDetails"": ""reference_id=9876"", ""TimeStamp"": ""2020-11-13T09:02:35.697Z"", ""EventToNotify"": ""SaleWakeUp"" }, ""MessageHeader"": { ""ProtocolVersion"": ""3.0"", ""SaleID"": ""null"", ""MessageClass"": ""Event"", ""MessageCategory"": ""Event"", ""POIID"": ""P400Plus-275102806"", ""MessageType"": ""Notification"", ""DeviceID"": ""5"" } } }";

                //create a mock client
                var client = CreateMockTestClientPosLocalApiRequest("Mocks/terminalapi/pospayment-encrypted-success.json");
                var posPaymentLocalApi = new PosPaymentLocalApi(client);
                var decryptedNotification = posPaymentLocalApi.DecryptNotification(encryptedNotification, _encryptionCredentialDetails);
                Assert.AreEqual(decryptedNotification, expectedDecryption);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}