using System.Text.Json;
using Adyen.AcsWebhooks.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.AcsWebhooks
{
    /// <summary>
    /// Verifies that AcsWebhooks models can be deserialized using a bare
    /// <see cref="JsonSerializer.Deserialize{T}(string)"/> call without supplying any
    /// <see cref="JsonSerializerOptions"/>. Enum types carry class-level <c>[JsonConverter]</c>
    /// attributes that STJ discovers automatically; plain model properties are resolved via
    /// <c>[JsonPropertyName]</c> attributes through STJ's default reflection path.
    /// </summary>
    [TestClass]
    public class AcsBareSerializationTests
    {
        [TestMethod]
        public void Given_AuthenticationNotificationJson_When_BareDeserialize_Then_Returns_CorrectTopLevelFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/acswebhooks/balancePlatform.authentication.created.json");

            var r = JsonSerializer.Deserialize<AuthenticationNotificationRequest>(json);

            Assert.IsNotNull(r);
            Assert.AreEqual(AuthenticationNotificationRequest.TypeEnum.BalancePlatformAuthenticationCreated, r.Type);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(DateTimeOffset.Parse("2022-12-22T15:42:03+01:00"), r.Timestamp);
        }

        [TestMethod]
        public void Given_AuthenticationNotificationJson_When_BareDeserialize_Then_Returns_CorrectDataFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/acswebhooks/balancePlatform.authentication.created.json");

            var r = JsonSerializer.Deserialize<AuthenticationNotificationRequest>(json);

            Assert.IsNotNull(r?.Data);
            Assert.AreEqual("497f6eca-6276-4993-bfeb-53cbbbba6f08", r.Data.Id);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
            Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", r.Data.PaymentInstrumentId);
            Assert.AreEqual(AuthenticationNotificationData.StatusEnum.Authenticated, r.Data.Status);
        }

        [TestMethod]
        public void Given_AuthenticationNotificationJson_When_BareDeserialize_Then_Returns_CorrectPurchaseFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/acswebhooks/balancePlatform.authentication.created.json");

            var r = JsonSerializer.Deserialize<AuthenticationNotificationRequest>(json);

            Assert.IsNotNull(r?.Data?.Purchase);
            Assert.AreEqual("2022-12-22T15:49:03+01:00", r.Data.Purchase.Date);
            Assert.AreEqual("MyShop", r.Data.Purchase.MerchantName);
            Assert.IsNotNull(r.Data.Purchase.OriginalAmount);
            Assert.AreEqual("EUR", r.Data.Purchase.OriginalAmount.Currency);
            Assert.AreEqual(1000, r.Data.Purchase.OriginalAmount.Value);
        }

        [TestMethod]
        public void Given_AuthenticationNotificationJson_When_BareDeserialize_Then_Returns_CorrectAuthenticationFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/acswebhooks/balancePlatform.authentication.created.json");

            var r = JsonSerializer.Deserialize<AuthenticationNotificationRequest>(json);

            Assert.IsNotNull(r?.Data?.Authentication);
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
        }

        [TestMethod]
        public void Given_AuthenticationNotificationJson_When_BareDeserialize_Then_Returns_CorrectChallengeFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/acswebhooks/balancePlatform.authentication.created.json");

            var r = JsonSerializer.Deserialize<AuthenticationNotificationRequest>(json);

            Assert.IsNotNull(r?.Data?.Authentication?.Challenge);
            Assert.AreEqual(ChallengeInfo.FlowEnum.OOBTRIGGERFL, r.Data.Authentication.Challenge.Flow);
            Assert.AreEqual(DateTimeOffset.Parse("2022-12-22T15:49:03+01:00"), r.Data.Authentication.Challenge.LastInteraction);
        }

        [TestMethod]
        public void Given_InvalidJson_When_BareDeserialize_Then_Throws_JsonException()
        {
            string json = "{ invalid,.json; }";

            Assert.ThrowsException<JsonException>(() =>
            {
                JsonSerializer.Deserialize<AuthenticationNotificationRequest>(json);
            });
        }

        [TestMethod]
        public void Given_AuthenticationNotificationObject_When_BareSerialize_Then_DoesNotThrow()
        {
            var request = new AuthenticationNotificationRequest
            {
                Type = AuthenticationNotificationRequest.TypeEnum.BalancePlatformAuthenticationCreated,
                Environment = "test",
            };

            string json = JsonSerializer.Serialize(request);

            Assert.IsNotNull(json);
        }
    }
}
