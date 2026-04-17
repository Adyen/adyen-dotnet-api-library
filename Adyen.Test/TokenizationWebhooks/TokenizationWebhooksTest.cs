using System.Globalization;
using Adyen.TokenizationWebhooks.Extensions;
using Adyen.TokenizationWebhooks.Models;
using Adyen.TokenizationWebhooks.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;

namespace Adyen.Test.TokenizationWebhooks
{
    [TestClass]
    public class TokenizationWebhooksTest
    {
        private static IHost _host;
        private static ITokenizationWebhooksHandler _tokenizationWebhooksHandler;
        private const string TestHmacKey = "D7DD5BA6146493707BF0BE7496F6404EC7A63616B7158EC927B9F54BB436765F";

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureTokenizationWebhooks((ctx, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenHmacKey = TestHmacKey;
                    });
                    services.AddTokenizationWebhooksHandler();
                })
                .Build();

            _tokenizationWebhooksHandler = _host.Services.GetRequiredService<ITokenizationWebhooksHandler>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
        }

        [TestMethod]
        public void Given_Deserialize_Tokenization_Webhook_When_Event_Is_RecurringToken_Created()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/tokenizationwebhooks/recurring.token.created.json");

            // Act
            TokenizationCreatedDetailsNotificationRequest r = _tokenizationWebhooksHandler.DeserializeTokenizationCreatedDetailsNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TokenizationCreatedDetailsNotificationRequest.TypeEnum.RecurringTokenCreated, r.Type);
            Assert.AreEqual(TokenizationCreatedDetailsNotificationRequest.EnvironmentEnum.Test, r.Environment);
            Assert.AreEqual("QBQQ9DLNRHHKGK38", r.EventId);
            Assert.AreEqual(DateTimeOffset.Parse("2025-06-30T16:40:23+02:00", CultureInfo.InvariantCulture), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", r.Data.MerchantAccount);
            Assert.AreEqual("M5N7TQ4TG5PFWR50", r.Data.StoredPaymentMethodId);
            Assert.AreEqual("visastandarddebit", r.Data.Type);
            Assert.AreEqual("alreadyExisting", r.Data.Operation);
            Assert.AreEqual("YOUR_SHOPPER_REFERENCE", r.Data.ShopperReference);
        }

        [TestMethod]
        public void Given_Deserialize_Tokenization_Webhook_When_Event_Is_RecurringToken_Updated()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/tokenizationwebhooks/recurring.token.updated.json");

            // Act
            TokenizationUpdatedDetailsNotificationRequest r = _tokenizationWebhooksHandler.DeserializeTokenizationUpdatedDetailsNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TokenizationUpdatedDetailsNotificationRequest.TypeEnum.RecurringTokenUpdated, r.Type);
            Assert.AreEqual(TokenizationUpdatedDetailsNotificationRequest.EnvironmentEnum.Test, r.Environment);
            Assert.AreEqual("QBQQ9DLNRHHKGK38", r.EventId);
            Assert.AreEqual(DateTimeOffset.Parse("2025-06-30T16:40:23+02:00", CultureInfo.InvariantCulture), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", r.Data.MerchantAccount);
            Assert.AreEqual("M5N7TQ4TG5PFWR50", r.Data.StoredPaymentMethodId);
            Assert.AreEqual("visastandarddebit", r.Data.Type);
            Assert.AreEqual("alreadyExisting", r.Data.Operation);
            Assert.AreEqual("YOUR_SHOPPER_REFERENCE", r.Data.ShopperReference);
        }

        [TestMethod]
        public void Given_Deserialize_Tokenization_Webhook_When_Event_Is_RecurringToken_Disabled()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/tokenizationwebhooks/recurring.token.disabled.json");

            // Act
            TokenizationDisabledDetailsNotificationRequest r = _tokenizationWebhooksHandler.DeserializeTokenizationDisabledDetailsNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TokenizationDisabledDetailsNotificationRequest.TypeEnum.RecurringTokenDisabled, r.Type);
            Assert.AreEqual(TokenizationDisabledDetailsNotificationRequest.EnvironmentEnum.Test, r.Environment);
            Assert.AreEqual("QBQQ9DLNRHHKGK38", r.EventId);
            Assert.AreEqual(DateTimeOffset.Parse("2025-06-30T16:40:23+02:00", CultureInfo.InvariantCulture), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", r.Data.MerchantAccount);
            Assert.AreEqual("M5N7TQ4TG5PFWR50", r.Data.StoredPaymentMethodId);
            Assert.AreEqual("visastandarddebit", r.Data.Type);
            Assert.AreEqual("YOUR_SHOPPER_REFERENCE", r.Data.ShopperReference);
        }

        [TestMethod]
        public void Given_Deserialize_Tokenization_Webhook_When_Event_Is_RecurringToken_AlreadyExisting()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/tokenizationwebhooks/recurring.token.alreadyExisting.json");

            // Act
            TokenizationAlreadyExistingDetailsNotificationRequest r = _tokenizationWebhooksHandler.DeserializeTokenizationAlreadyExistingDetailsNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TokenizationAlreadyExistingDetailsNotificationRequest.TypeEnum.RecurringTokenAlreadyExisting, r.Type);
            Assert.AreEqual(TokenizationAlreadyExistingDetailsNotificationRequest.EnvironmentEnum.Test, r.Environment);
            Assert.AreEqual("QBQQ9DLNRHHKGK38", r.EventId);
            Assert.AreEqual(DateTimeOffset.Parse("2025-06-30T16:40:23+02:00", CultureInfo.InvariantCulture), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", r.Data.MerchantAccount);
            Assert.AreEqual("M5N7TQ4TG5PFWR50", r.Data.StoredPaymentMethodId);
            Assert.AreEqual("visastandarddebit", r.Data.Type);
            Assert.AreEqual("alreadyExisting", r.Data.Operation);
            Assert.AreEqual("YOUR_SHOPPER_REFERENCE", r.Data.ShopperReference);
        }

        [TestMethod]
        public void Given_Webhook_When_HmacSignatureIsInvalid_Then_ReturnsFalse()
        {
            // Arrange
            string json = "{ \"test\": \"value\" }";
            string invalidHmacSignature = "Qz9S/0xpar1klkniKdshxpAhRKbiSAewPpWoxKefQA=";

            // Act
            bool isValid = _tokenizationWebhooksHandler.IsValidHmacSignature(json, invalidHmacSignature);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Given_Webhook_When_HmacSignatureIsValid_Then_ReturnsTrue()
        {
            // Arrange
            // The signature is computed from the same raw JSON string that IsValidHmacSignature receives,
            // mirroring how Adyen generates and sends the HMAC header alongside the webhook payload.
            string json = TestUtilities.GetTestFileContent("mocks/tokenizationwebhooks/recurring.token.disabled.json");
            string hmacSignatureFromHeader = Adyen.Core.Utilities.HmacValidatorUtility.GenerateBase64Sha256HmacSignature(json, TestHmacKey);

            // Act - Step 1: validate HMAC on the raw JSON
            bool isValid = _tokenizationWebhooksHandler.IsValidHmacSignature(json, hmacSignatureFromHeader);

            // Step 2: only deserialize after the signature is verified
            TokenizationDisabledDetailsNotificationRequest r = _tokenizationWebhooksHandler.DeserializeTokenizationDisabledDetailsNotificationRequest(json);

            // Assert
            Assert.IsTrue(isValid);
            Assert.IsNotNull(r);
        }
    }
}
