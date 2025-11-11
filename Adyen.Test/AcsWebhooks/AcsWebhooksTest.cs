using Adyen.AcsWebhooks.Extensions;
using Adyen.AcsWebhooks.Models;
using Adyen.AcsWebhooks.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.AcsWebhooks.Handlers;

namespace Adyen.Test.AcsWebhooks
{
    [TestClass]
    public class AcsWebhooksTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IAcsWebhooksHandler _acsWebhooksHandler;

        public AcsWebhooksTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureAcsWebhooks((context, services, config) =>
                {
                })
                .Build();

              _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
              _acsWebhooksHandler = host.Services.GetRequiredService<IAcsWebhooksHandler>();
        }

      [TestMethod]
      public async Task Given_DeserializeAuthenticationNotificationRequest_When_JsonPayload_Provided_Returns_Not_Null()
      {
            // Arrange
            string json = @"
{
  ""data"": {
    ""authentication"": {
      ""acsTransId"": ""6a4c1709-a42e-4c7f-96c7-1043adacfc97"",
      ""challenge"": {
        ""flow"": ""OOB_TRIGGER_FL"",
        ""lastInteraction"": ""2022-12-22T15:49:03+01:00""
      },
      ""challengeIndicator"": ""01"",
      ""createdAt"": ""2022-12-22T15:45:03+01:00"",
      ""deviceChannel"": ""app"",
      ""dsTransID"": ""a3b86754-444d-46ca-95a2-ada351d3f42c"",
      ""exemptionIndicator"": ""lowValue"",
      ""inPSD2Scope"": true,
      ""messageCategory"": ""payment"",
      ""messageVersion"": ""2.2.0"",
      ""riskScore"": 0,
      ""threeDSServerTransID"": ""6edcc246-23ee-4e94-ac5d-8ae620bea7d9"",
      ""transStatus"": ""Y"",
      ""type"": ""challenge""
    },
    ""balancePlatform"": ""YOUR_BALANCE_PLATFORM"",
    ""id"": ""497f6eca-6276-4993-bfeb-53cbbbba6f08"",
    ""paymentInstrumentId"": ""PI3227C223222B5BPCMFXD2XG"",
    ""purchase"": {
      ""date"": ""2022-12-22T15:49:03+01:00"",
      ""merchantName"": ""MyShop"",
      ""originalAmount"": {
        ""currency"": ""EUR"",
        ""value"": 1000
      }
    },
    ""status"": ""authenticated""
  },
  ""environment"": ""test"",
  ""timestamp"": ""2022-12-22T15:42:03+01:00"",
  ""type"": ""balancePlatform.authentication.created""
}";

            AuthenticationNotificationRequest request = _acsWebhooksHandler.DeserializeAuthenticationNotificationRequest(json);
            Assert.IsNotNull(request);
        }

        [TestMethod]
        public async Task Given_Deserialize_Authentication_Webhook_WHen_OOB_TRIGGER_FL_Returns_Correct_Challenge_Flow()
        {
            // Arrange
            string json = @"
{
  ""data"": {
    ""authentication"": {
      ""acsTransId"": ""6a4c1709-a42e-4c7f-96c7-1043adacfc97"",
      ""challenge"": {
        ""flow"": ""OOB_TRIGGER_FL"",
        ""lastInteraction"": ""2022-12-22T15:49:03+01:00""
      },
      ""challengeIndicator"": ""01"",
      ""createdAt"": ""2022-12-22T15:45:03+01:00"",
      ""deviceChannel"": ""app"",
      ""dsTransID"": ""a3b86754-444d-46ca-95a2-ada351d3f42c"",
      ""exemptionIndicator"": ""lowValue"",
      ""inPSD2Scope"": true,
      ""messageCategory"": ""payment"",
      ""messageVersion"": ""2.2.0"",
      ""riskScore"": 0,
      ""threeDSServerTransID"": ""6edcc246-23ee-4e94-ac5d-8ae620bea7d9"",
      ""transStatus"": ""Y"",
      ""type"": ""challenge""
    },
    ""balancePlatform"": ""YOUR_BALANCE_PLATFORM"",
    ""id"": ""497f6eca-6276-4993-bfeb-53cbbbba6f08"",
    ""paymentInstrumentId"": ""PI3227C223222B5BPCMFXD2XG"",
    ""purchase"": {
      ""date"": ""2022-12-22T15:49:03+01:00"",
      ""merchantName"": ""MyShop"",
      ""originalAmount"": {
        ""currency"": ""EUR"",
        ""value"": 1000
      }
    },
    ""status"": ""authenticated""
  },
  ""environment"": ""test"",
  ""timestamp"": ""2022-12-22T15:42:03+01:00"",
  ""type"": ""balancePlatform.authentication.created""
}";
            
            // Act
            AuthenticationNotificationRequest r = _acsWebhooksHandler.DeserializeAuthenticationNotificationRequest(json);
            
            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(AuthenticationNotificationRequest.TypeEnum.BalancePlatformAuthenticationCreated, r.Type);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(DateTime.Parse("2022-12-22T15:42:03+01:00"), r.Timestamp);

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
            Assert.AreEqual(DateTime.Parse("2022-12-22T15:45:03+01:00"), r.Data.Authentication.CreatedAt);
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
            Assert.AreEqual(DateTime.Parse("2022-12-22T15:49:03+01:00"), r.Data.Authentication.Challenge.LastInteraction);
        }
    }
}