using Adyen.Core.Options;
using Adyen.Payment.Extensions;
using Adyen.Payment.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.Constants;
using Adyen.Payment.Models;

namespace Adyen.Test.Payment
{
    /// <summary>
    /// Classic Payments - Payment. 
    /// </summary>
    [TestClass]
    public class PaymentTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PaymentTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePayment((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_Result_Is_Authorised()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authorise-success.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(result.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.AreEqual("411111", GetAdditionalData(result.AdditionalData, "cardBin"));
            Assert.AreEqual("43733", GetAdditionalData(result.AdditionalData, "authCode"));
            Assert.AreEqual("4 AVS not supported for this card type", GetAdditionalData(result.AdditionalData, "avsResult"));
            Assert.AreEqual("1 Matches", GetAdditionalData(result.AdditionalData, "cvcResult"));
            Assert.AreEqual("visa", GetAdditionalData(result.AdditionalData, "paymentMethod"));
        }


        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_3D_Result_Is_Authorise_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authorise-success-3d.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result.Md);
            Assert.IsNotNull(result.IssuerUrl);
            Assert.IsNotNull(result.PaRequest);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_3DS_IdentifyShopper_Result_Is_IdentifyShopper()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/threedsecure2/authorise-response-identifyshopper.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(result.ResultCode, PaymentResult.ResultCodeEnum.IdentifyShopper);
            Assert.IsNotNull(result.PspReference);
            Assert.AreEqual("74044f6c-7d79-4dd1-9859-3b2879a32fb0", GetAdditionalData(result.AdditionalData, "threeds2.threeDSServerTransID"));
            Assert.AreEqual(@"https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", GetAdditionalData(result.AdditionalData, "threeds2.threeDSMethodURL"));
            Assert.AreEqual("[token]", GetAdditionalData(result.AdditionalData, "threeds2.threeDS2Token"));
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_3DS2_ChallengeShopper_Result_Is_ChallengerShopper()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/threedsecure2/authorise3ds2-response-challengeshopper.json");
            
            // Act
            var paymentResult = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
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
        public void Given_Deserialize_When_PaymentResult_Authorise_3DS2_Result_Is_Authorised()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/threedsecure2/authorise3ds2-success.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(result.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.IsNotNull(result.PspReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_Authorise_3D_Result_Is_Authorised()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authorise3d-success.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(result.ResultCode, PaymentResult.ResultCodeEnum.Authorised);
            Assert.IsNotNull(result.PspReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_CVC_Declined_Result_Is_Refused()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authorise-error-cvc-declined.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentResult.ResultCodeEnum.Refused, result.ResultCode);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentResult_CSE_Result_Is_Authorised()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authorise-success-cse.json");
            
            // Act
            var result = JsonSerializer.Deserialize<PaymentResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentResult.ResultCodeEnum.Authorised, result.ResultCode);
        }

        [TestMethod]
        public void Given_CreatePaymentRequest_When_AdyenLibraryName_And_AdyenLibraryVersion_Are_Set_Returns_ApplicationInfo()
        {
            // Arrange
            // Act
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            
            // Assert
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }

        [TestMethod]
        public void Given_CreatePaymentRequest3D_When_AdyenLibraryName_And_AdyenLibraryVersion_Are_Set_Returns_ApplicationInfo()
        {
            // Arrange
            // Act
            PaymentRequest3d paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            
            // Assert
            Assert.IsNotNull(paymentRequest.ApplicationInfo);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Name, ClientConfig.LibName);
            Assert.AreEqual(paymentRequest.ApplicationInfo.AdyenLibrary.Version, ClientConfig.LibVersion);
        }
        
        [TestMethod]
        public void Given_Serialize_When_PaymentRequest3D_With_CaptureDelaysHours_And_FraudOffSet_Result_Should_Contain_0()
        {
            // Arrange
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest3D();
            
            // Act
            string target = JsonSerializer.Serialize(paymentRequest);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            Assert.AreEqual(0, root.GetProperty("captureDelayHours").GetInt32());
            Assert.AreEqual(0, root.GetProperty("fraudOffset").GetInt32());
        }

        [TestMethod]
        public void Given_Deserialize_When_AuthenticationResultResponse_Result_3DS1_Success_And_3DS2_Is_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authentication-result-success-3ds1.json");
            
            // Act
            var authenticationResultResponse = JsonSerializer.Deserialize<AuthenticationResultResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Arrange
            Assert.IsNotNull(authenticationResultResponse);
            Assert.IsNotNull(authenticationResultResponse.ThreeDS1Result);
            Assert.IsNull(authenticationResultResponse.ThreeDS2Result);
        }

        [TestMethod]
        public void Given_Deserialize_When_AuthenticationResultResponse_Result_3DS2_Is_Success_And_3DS1_Is_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/authentication-result-success-3ds2.json");
            
            // Act
            var authenticationResultResponse = JsonSerializer.Deserialize<AuthenticationResultResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(authenticationResultResponse);
            Assert.IsNull(authenticationResultResponse.ThreeDS1Result);
            Assert.IsNotNull(authenticationResultResponse.ThreeDS2Result);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_AuthenticationResultResponse_Result_ThreeDSServerTransId_And_Ds_TransID_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/ThreeDS2Result.json");
            
            // Act
            var threeDs2Result = JsonSerializer.Deserialize<AuthenticationResultResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(threeDs2Result);
            Assert.AreEqual("f04ec32b-f46b-46ef-9ccd-44be42fb0d7e", threeDs2Result.ThreeDS2Result.ThreeDSServerTransID);
            Assert.AreEqual("80a16fa0-4eea-43c9-8de5-b0470d09d14d", threeDs2Result.ThreeDS2Result.DsTransID);
        }
        
        [TestMethod]
        public void Given_Serialize_When_PaymentRequest_With_ShopperInteraction_Moto_Result_Should_Be_Moto()
        {
            // Arrange
            var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(PaymentRequest.ShopperInteractionEnum.Moto);
            
            // Act
            string target = JsonSerializer.Serialize(paymentRequest);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            Assert.AreEqual("Moto", root.GetProperty("shopperInteraction").GetString());
        }
        
        [TestMethod]
        public void Given_Serialize_When_PaymentRequest_With_ShopperInteraction_Result_Should_Be_Null()
        {
            // Arrange
            var paymentRequest = MockPaymentData.CreateFullPaymentRequestWithShopperInteraction(null);
            
            // Act
            string target = JsonSerializer.Serialize(paymentRequest);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            Assert.IsNull(root.GetProperty("shopperInteraction").GetString());
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

        public static PaymentRequest CreateFullPaymentRequest()
        {
            PaymentRequest paymentRequest = new PaymentRequest(
                applicationInfo: new ApplicationInfo(adyenLibrary: new CommonField(name: ClientConfig.LibName, version: ClientConfig.LibVersion)),
                merchantAccount: "MerchantAccount",
                amount: new Amount("EUR", 1500), card: CreateTestCard(), 
                reference: "payment - " + DateTime.Now.ToString("yyyyMMdd"), 
                additionalData: CreateAdditionalData());
            return paymentRequest;
        }

        public static PaymentRequest3ds2 CreateFullPaymentRequest3DS2()
        {
            PaymentRequest3ds2 paymentRequest = new PaymentRequest3ds2(
                amount: new Amount("EUR", 1500),
                merchantAccount: "MerchantAccount",
                reference: "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                additionalData: CreateAdditionalData(),
                threeDS2RequestData: new ThreeDS2RequestData(threeDSCompInd: "Y",
                deviceChannel: "browser"),
                browserInfo: CreateMockBrowserInfo() );
            return paymentRequest;
        }

        public static PaymentRequest CreateFullPaymentRequestWithShopperInteraction(PaymentRequest.ShopperInteractionEnum shopperInteraction)
        {
            PaymentRequest paymentRequest = CreateFullPaymentRequest();
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
            PaymentRequest3d paymentRequest = new PaymentRequest3d(
                md: "md", 
                merchantAccount: "MerchantAccount",
                paResponse: "paResponse",
                applicationInfo: new ApplicationInfo(adyenLibrary: new CommonField(name: ClientConfig.LibName, version: ClientConfig.LibVersion)), 
                browserInfo: CreateMockBrowserInfo(), 
                reference: "payment - " + DateTime.Now.ToString("yyyyMMdd"), 
                captureDelayHours: 0,
                fraudOffset: 0);
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
