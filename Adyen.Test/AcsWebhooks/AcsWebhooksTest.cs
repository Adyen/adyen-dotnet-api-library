using Adyen.AcsWebhooks.Extensions;
using Adyen.AcsWebhooks.Models;
using Adyen.AcsWebhooks.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.AcsWebhooks.Handlers;
using Adyen.Checkout.Extensions;
using Adyen.Core.Auth;
using Adyen.Core.Options;

namespace Adyen.Test.AcsWebhooks
{
    [TestClass]
    public class AcsWebhooksTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IAcsWebhooksHandler _acsWebhooksHandler;
        private readonly string _testHmacKey = "D7DD5BA6146493707BF0BE7496F6404EC7A63616B7158EC927B9F54BB436765F"; // Test key

        public AcsWebhooksTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureAcsWebhooks((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenHmacKey = "ADYEN_HMAC_KEY";
                    });
                    services.AddAcsWebhooksHandler();
                })
                .Build();

              _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
              _acsWebhooksHandler = host.Services.GetRequiredService<IAcsWebhooksHandler>();
        }

        [TestMethod]
        public void Given_ConfigureAdyenOptions_When_HmacTokenIsProvided_Then_HmacToken_Is_Not_Null()
        {
            // Arrange
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureAcsWebhooks((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenHmacKey = "ADYEN_HMAC_KEY";
                    });

                })
                .Build();

            // Act
            ITokenProvider<HmacKeyToken> hmacToken = testHost.Services.GetRequiredService<ITokenProvider<HmacKeyToken>>();
            
            // Assert
            Assert.IsNotNull(hmacToken.Get());
        }
        
        [TestMethod]
        public async Task Given_Deserialize_Authentication_Webhook_When_Event_Is_BalancePlatform_Authentication_Created()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/acswebhooks/balancePlatform.authentication.created.json");
            
            // Act
            AuthenticationNotificationRequest r = _acsWebhooksHandler.DeserializeAuthenticationNotificationRequest(json);
            
            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(AuthenticationNotificationRequest.TypeEnum.BalancePlatformAuthenticationCreated, r.Type);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(DateTimeOffset.Parse("2022-12-22T15:42:03+01:00"), r.Timestamp);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("497f6eca-6276-4993-bfeb-53cbbbba6f08", r.Data.Id);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
            Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", r.Data.PaymentInstrumentId);
            Assert.AreEqual(AuthenticationNotificationData.StatusEnum.Authenticated, r.Data.Status);

            Assert.IsNotNull(r.Data.Purchase);
            Assert.AreEqual("2022-12-22T15:49:03+01:00", r.Data.Purchase.Date);
            Assert.AreEqual("MyShop", r.Data.Purchase.MerchantName);
            Assert.AreEqual("EUR", r.Data.Purchase.OriginalAmount.Currency);
            Assert.AreEqual(1000, r.Data.Purchase.OriginalAmount.Value);

            Assert.IsNotNull(r.Data.Authentication);
            Assert.AreEqual("6a4c1709-a42e-4c7f-96c7-1043adacfc97", r.Data.Authentication.AcsTransId);
            Assert.AreEqual(AuthenticationInfo.ChallengeIndicatorEnum._01, r.Data.Authentication.ChallengeIndicator);
            Assert.AreEqual(DateTimeOffset.Parse("2022-12-22T15:45:03+01:00"), r.Data.Authentication.CreatedAt);
            Assert.AreEqual(AuthenticationInfo.DeviceChannelEnum.App, r.Data.Authentication.DeviceChannel);
            Assert.AreEqual("a3b86754-444d-46ca-95a2-ada351d3f42c", r.Data.Authentication.DsTransID);
            Assert.AreEqual(AuthenticationInfo.ExemptionIndicatorEnum.LowValue, r.Data.Authentication.ExemptionIndicator);
            Assert.IsTrue(r.Data.Authentication.InPSD2Scope);
            Assert.AreEqual(AuthenticationInfo.MessageCategoryEnum.Payment, r.Data.Authentication.MessageCategory);
            Assert.AreEqual("2.2.0", r.Data.Authentication.MessageVersion);
            Assert.AreEqual(0, r.Data.Authentication.RiskScore);
            Assert.AreEqual("6edcc246-23ee-4e94-ac5d-8ae620bea7d9", r.Data.Authentication.ThreeDSServerTransID);
            Assert.AreEqual(AuthenticationInfo.TransStatusEnum.Y, r.Data.Authentication.TransStatus);
            Assert.AreEqual(AuthenticationInfo.TypeEnum.Challenge, r.Data.Authentication.Type);

            Assert.IsNotNull(r.Data.Authentication.Challenge);
            Assert.AreEqual(ChallengeInfo.FlowEnum.OOBTRIGGERFL, r.Data.Authentication.Challenge.Flow);
            Assert.AreEqual(DateTimeOffset.Parse("2022-12-22T15:49:03+01:00"), r.Data.Authentication.Challenge.LastInteraction);
        }
        
        [TestMethod]
        public void Given_AccountHolder_Webhook_When_Required_Fields_Are_Unspecified_Result_Should_Throw_ArgumentException()
        {
            // Arrange
            string json = @"{ ""type"": ""unknowntype"" }"; // No Data, no Environment values (which are required)!
            
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                _acsWebhooksHandler.DeserializeAuthenticationNotificationRequest(json);
            });
        }

        [TestMethod]
        public void Given_AccountHolder_Webhook_When_Invalid_Json_Result_Should_Throw_JsonException()
        {
            // Arrange
            string json = "{ invalid,.json; }";
          
            // Act
            // Assert
            Assert.Throws<JsonException>(() =>
            {
                _acsWebhooksHandler.DeserializeAuthenticationNotificationRequest(json);
            });
        }
        
        [TestMethod]
        public void Given_Webhook_When_HmacSignatureIsInvalid_Then_ReturnsFalse()
        {
            // Arrange
            string json = "{ \"test\": \"value\" }";
            string invalidHmacSignature = "Qz9S/0xpar1klkniKdshxpAhRKbiSAewPpWoxKefQA=";

            // Act
            bool isValid = _acsWebhooksHandler.IsValidHmacSignature(json, invalidHmacSignature);

            // Assert
            Assert.IsFalse(isValid);
        }

    }
}