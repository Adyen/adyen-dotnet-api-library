using System.Collections.Generic;
using Adyen.Constants;
using Adyen.Model.Payment;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class PaymentTest : BaseTest
    {
        [TestMethod]
        public void TestAuthoriseBasicAuthenticationSuccessMockedResponse()
        {
            var paymentResult = CreatePaymentResultFromFile("mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseApiKeyBasedSuccessMockedResponse()
        {
            var paymentResult = CreatePaymentApiKeyBasedResultFromFile("mocks/authorise-success.json");
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(paymentResult.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(paymentResult.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(paymentResult.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(paymentResult.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(paymentResult.AdditionalData, "paymentMethod"));
        }

        [TestMethod]
        public void TestAuthoriseSuccess3DMocked()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/authorise-success-3d.json");
            var payment = new PaymentService(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);
            Assert.IsNotNull(paymentResult.Md);
            Assert.IsNotNull(paymentResult.IssuerUrl);
            Assert.IsNotNull(paymentResult.PaRequest);
        }

        [TestMethod]
        public void TestAuthorise3DS2IdentifyShopperMocked()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/threedsecure2/authorise-response-identifyshopper.json");
            var payment = new PaymentService(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            var paymentResult = payment.Authorise3ds2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.IdentifyShopper);
            Assert.IsNotNull(paymentResult.PspReference);

            Assert.AreEqual("74044f6c-7d79-4dd1-9859-3b2879a32fb0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDSServerTransID"));
            Assert.AreEqual(@"https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDSMethodURL"));
            Assert.AreEqual("[token]", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2Token"));
        }

        [TestMethod]
        public void TestAuthorise3DS2ChallengeShopperMocked()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/threedsecure2/authorise3ds2-response-challengeshopper.json");
            var payment = new PaymentService(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            var paymentResult = payment.Authorise3ds2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.ChallengeShopper);
            Assert.IsNotNull(paymentResult.PspReference);

            Assert.AreEqual("C", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.transStatus"));
            Assert.AreEqual("Y", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsChallengeMandated"));
            Assert.AreEqual("https://pal-test.adyen.com/threeds2simulator/acs/challenge.shtml", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsURL"));
            Assert.AreEqual("74044f6c-7d79-4dd1-9859-3b2879a32fb1", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.threeDSServerTransID"));
            Assert.AreEqual("01", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.authenticationType"));
            Assert.AreEqual("2.1.0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.messageVersion"));
            Assert.AreEqual("[token]", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2Token"));
            Assert.AreEqual("ba961c4b-33f2-4830-3141-744b8586aeb0", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsTransID"));
            Assert.AreEqual("ADYEN-ACS-SIMULATOR", GetAdditionalData(paymentResult.AdditionalData, "threeds2.threeDS2ResponseData.acsReferenceNumber"));
        }

        [TestMethod]
        public void TestAuthorise3DS2SuccessMocked()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/threedsecure2/authorise3ds2-success.json");
            var payment = new PaymentService(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3DS2();
            var paymentResult = payment.Authorise3ds2(paymentRequest);

            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }

        [TestMethod]
        public void TestAuthorise3DSuccessMocked()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/authorise3d-success.json");
            var payment = new PaymentService(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            var paymentResult = payment.Authorise3d(paymentRequest);
            Assert.AreEqual(paymentResult.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.IsNotNull(paymentResult.PspReference);
        }

        [TestMethod]
        public void TestAuthoriseErrorCvcDeclinedMocked()
        {
            var paymentResult = CreatePaymentResultFromFile("mocks/authorise-error-cvc-declined.json");
            Assert.AreEqual(PaymentResult.ResultCodeEnum.Refused, paymentResult.ResultCode);
        }

        [TestMethod]
        public void TestAuthoriseCseSuccessMocked()
        {
            var paymentResult = CreatePaymentResultFromFile("mocks/authorise-success-cse.json");
            Assert.AreEqual(PaymentResult.ResultCodeEnum.Authorised, paymentResult.ResultCode);
        }
        
        [Ignore] // Fix this test -> not sure how to add additionalDataOpenInvoice class to paymentrequest
        [TestMethod]
        public void TestOpenInvoice()
        {
            var client = CreateMockTestClientRequest("mocks/authorise-success-klarna.json");
            var payment = new PaymentService(client);
            PaymentRequest paymentRequest = CreateOpenInvoicePaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);
            Assert.AreEqual("2374421290", paymentResult.AdditionalData["additionalData.acquirerReference"]);
            Assert.AreEqual("klarna", paymentResult.AdditionalData["paymentMethodVariant"]);
        }
        
        private static PaymentRequest CreateOpenInvoicePaymentRequest()
        {

            DateTime dateOfBirth = DateTime.Parse("1970-07-10");

            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequest();

            // Set Shopper Data
            paymentRequest.ShopperEmail = "youremail@email.com";
            paymentRequest.DateOfBirth = dateOfBirth;
            paymentRequest.TelephoneNumber = "0612345678";
            paymentRequest.ShopperReference = "4";

            // Set Shopper Info
            Name shopperName = new Name
            {
                FirstName = "Testperson-nl",
                LastName = "Approved"
            };
            paymentRequest.ShopperName = shopperName;

            // Set Billing and Delivery address
            Address address = new Address
            {
                City = "Gravenhage",
                Country = "NL",
                HouseNumberOrName = "1",
                PostalCode = "2521VA",
                StateOrProvince = "Zuid-Holland",
                Street = "Neherkade"
            };
            paymentRequest.DeliveryAddress = address;
            paymentRequest.BillingAddress = address;

            // Use OpenInvoice Provider (klarna, ratepay)
            paymentRequest.SelectedBrand = "klarna";

            long itemAmount = long.Parse("9000");
            long itemVatAmount = long.Parse("1000");
            long itemVatPercentage = long.Parse("1000");

            List<AdditionalDataOpenInvoice> invoiceLines = new List<AdditionalDataOpenInvoice>();

            // invoiceLine1
            AdditionalDataOpenInvoice invoiceLine = new AdditionalDataOpenInvoice
            {
                OpeninvoicedataLineItemNrCurrencyCode = ("EUR"),
                OpeninvoicedataLineItemNrDescription = ("Test product"),
                OpeninvoicedataLineItemNrItemVatAmount = ("1000"),
                OpeninvoicedataLineItemNrItemAmount = (itemAmount).ToString(),
                OpeninvoicedataLineItemNrItemVatPercentage = (itemVatPercentage).ToString(),
                OpeninvoicedataLineItemNrNumberOfItems = (1).ToString(),
                OpeninvoicedataLineItemNrItemId = ("1234")
            };

            // invoiceLine2
            // invoiceLine1
            AdditionalDataOpenInvoice invoiceLine2 = new AdditionalDataOpenInvoice
            {
                OpeninvoicedataLineItemNrCurrencyCode = ("EUR"),
                OpeninvoicedataLineItemNrDescription = ("Test product2"),
                OpeninvoicedataLineItemNrItemVatAmount = (itemVatAmount).ToString(),
                OpeninvoicedataLineItemNrItemAmount = (itemAmount).ToString(),
                OpeninvoicedataLineItemNrItemVatPercentage = (itemVatPercentage).ToString(),
                OpeninvoicedataLineItemNrNumberOfItems = (1).ToString(),
                OpeninvoicedataLineItemNrItemId = ("456")
            };
            
            invoiceLines.Add(invoiceLine);
            invoiceLines.Add(invoiceLine2);
            
            /*paymentRequest.AdditionalData(invoiceLines);*/

            return paymentRequest;
        }
        

        [TestMethod]
        public void TestPaymentRequestApplicationInfo()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }

        [TestMethod]
        public void TestPaymentRequest3DApplicationInfo()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }
        
        [TestMethod]
        public void TestCaptureDelaySerialization()
        {
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            string jsonString = paymentRequest.ToJson();
            Assert.IsTrue(jsonString.Contains("\"captureDelayHours\": 0,"));
            Assert.IsFalse(jsonString.Contains("\"fraudOffset\": 0"));
        }

        [TestMethod]
        public void TestAuthenticationResult3ds1Success()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/authentication-result-success-3ds1.json");
            var payment = new PaymentService(client);
            var authenticationResultRequest = new AuthenticationResultRequest();
            var authenticationResultResponse = payment.GetAuthenticationResult(authenticationResultRequest);
            Assert.IsNotNull(authenticationResultResponse);
            Assert.IsNotNull(authenticationResultResponse.ThreeDS1Result);
            Assert.IsNull(authenticationResultResponse.ThreeDS2Result);
        }

        [TestMethod]
        public void TestAuthenticationResult3ds2Success()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/authentication-result-success-3ds2.json");
            var payment = new PaymentService(client);
            var authenticationResultRequest = new AuthenticationResultRequest();
            var authenticationResultResponse = payment.GetAuthenticationResult(authenticationResultRequest);
            Assert.IsNotNull(authenticationResultResponse);
            Assert.IsNull(authenticationResultResponse.ThreeDS1Result);
            Assert.IsNotNull(authenticationResultResponse.ThreeDS2Result);
        }
        
        [TestMethod]
        public void TestRetrieve3ds2ResultSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/ThreeDS2Result.json");
            var payment = new PaymentService(client);
            var authenticationResultRequest = new AuthenticationResultRequest();
            var ThreeDSTwoResult = payment.GetAuthenticationResult(authenticationResultRequest);
            Assert.AreEqual("f04ec32b-f46b-46ef-9ccd-44be42fb0d7e", ThreeDSTwoResult.ThreeDS2Result.ThreeDSServerTransID);
            Assert.AreEqual("80a16fa0-4eea-43c9-8de5-b0470d09d14d", ThreeDSTwoResult.ThreeDS2Result.DsTransID);
            Assert.IsNotNull(ThreeDSTwoResult);
        }
        
        private string GetAdditionalData(Dictionary<string, string> additionalData, string assertKey)
        {
            string result = "";
            if (additionalData.ContainsKey(assertKey))
            {
                result = additionalData[assertKey];
            }
            return result;
        }
    }
    
    internal class MockPaymentData
    {
        #region Mock payment data 

        public static Config CreateConfigApiKeyBasedMock()
        {
            return new Config
            {
                Environment = Adyen.Model.Environment.Test,
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"//mock api key
            };
        }

        public static PaymentRequest CreateFullPaymentRequest()
        {
            var paymentRequest = new PaymentRequest
            {
                ApplicationInfo = new ApplicationInfo
                {
                    AdyenLibrary = new CommonField(name: ClientConfig.LibName, version: ClientConfig.LibVersion)
                },
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData()
            };
            return paymentRequest;
        }

        public static PaymentRequest3ds2 CreateFullPaymentRequest3DS2()
        {
            var paymentRequest = new PaymentRequest3ds2
            {
                MerchantAccount = "MerchantAccount",
                Amount = new Amount("EUR", 1500),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData(),
                ThreeDS2RequestData = new ThreeDS2RequestData(threeDSCompInd: "Y",
                    deviceChannel: "browser"),
                BrowserInfo = CreateMockBrowserInfo(),
            };
            return paymentRequest;
        }

        public static PaymentRequest CreateFullPaymentRequestWithShopperInteraction(PaymentRequest.ShopperInteractionEnum shopperInteraction)
        {
            var paymentRequest = CreateFullPaymentRequest();
            paymentRequest.ShopperInteraction = shopperInteraction;
            return paymentRequest;
        }

        protected static Dictionary<string, string> CreateAdditionalData()
        {
            return new Dictionary<string, string>
            {
                { "liabilityShift", "true"},
                { "fraudResultType", "GREEN"},
                { "authCode", "43733"},
                { "avsResult", "4 AVS not supported for this card type"}
            };
        }

        public static PaymentRequest3d CreateFullPaymentRequest3D()
        {
            var paymentRequest = new PaymentRequest3d
            {
                ApplicationInfo = new ApplicationInfo
                {
                    AdyenLibrary = new CommonField(name: ClientConfig.LibName, version: ClientConfig.LibVersion)
                },
                MerchantAccount = "MerchantAccount",
                BrowserInfo = CreateMockBrowserInfo(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                CaptureDelayHours = 0
            };
            return paymentRequest;
        }


        public static BrowserInfo CreateMockBrowserInfo()
        {
            return new BrowserInfo
            {
                UserAgent = "User-Agent:Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.95 Safari/537.36",
                AcceptHeader = "*/*"
            };
        }

        public static Card CreateTestCard()
        {
            return new Card(number: "4111111111111111", expiryMonth: "08", expiryYear: "2018", cvc: "737", holderName: "John Smith");
        }

        public static Card CreateTestCard3D()
        {
            return new Card(number: "5212345678901234", expiryMonth: "08", expiryYear: "2018", cvc: "737", holderName: "John Smith");
        }

        public static string GetTestPspReferenceMocked()
        {
            return "8514836072314693";
        }
        #endregion
    }
}
