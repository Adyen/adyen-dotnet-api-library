using Adyen.ConfigurationWebhooks.Extensions;
using Adyen.ConfigurationWebhooks.Handlers;
using Adyen.ConfigurationWebhooks.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountHolder = Adyen.ConfigurationWebhooks.Models.AccountHolder;
using BalanceAccount = Adyen.ConfigurationWebhooks.Models.BalanceAccount;
using Phone = Adyen.ConfigurationWebhooks.Models.Phone;

namespace Adyen.Test.ConfigurationWebhooks
{
    [TestClass]
    public class ConfigurationWebhooksTest
    {
        private readonly IConfigurationWebhooksHandler _configurationWebhooksHandler;

        public ConfigurationWebhooksTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureConfigurationWebhooks((context, services, config) => { })
                .Build();

            _configurationWebhooksHandler = host.Services.GetRequiredService<IConfigurationWebhooksHandler>();
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_NetworkToken_Created()
        {
            // Arrange
            string json =
                TestUtilities.GetTestFileContent("mocks/configurationwebhooks/network-token-notification.json");

            // Act
            var r = _configurationWebhooksHandler.DeserializeNetworkTokenNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(NetworkTokenNotificationRequest.TypeEnum.BalancePlatformNetworkTokenCreated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2025-05-20T07:44:26.101Z"), r.Timestamp);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_AccountHolder_Created()
        {
            // Arrange
            string json =
                TestUtilities.GetTestFileContent("mocks/configurationwebhooks/account-holder-notification.json");

            // Act
            var r = _configurationWebhooksHandler.DeserializeAccountHolderNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(AccountHolderNotificationRequest.TypeEnum.BalancePlatformAccountHolderCreated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2024-12-15T15:42:03+01:00"), r.Timestamp);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);

            Assert.IsNotNull(r.Data.AccountHolder);
            Assert.AreEqual("Shelly Eller", r.Data.AccountHolder.Description);
            Assert.AreEqual("LE00000000000000000001", r.Data.AccountHolder.LegalEntityId);
            Assert.AreEqual("YOUR_REFERENCE-2412C", r.Data.AccountHolder.Reference);
            Assert.AreEqual("AH00000000000000000001", r.Data.AccountHolder.Id);
            Assert.AreEqual(AccountHolder.StatusEnum.Active, r.Data.AccountHolder.Status);

            Assert.IsNotNull(r.Data.AccountHolder.ContactDetails);
            Assert.AreEqual("test@adyen.com", r.Data.AccountHolder.ContactDetails.Email);

            Assert.IsNotNull(r.Data.AccountHolder.ContactDetails.Phone);
            Assert.AreEqual("0612345678", r.Data.AccountHolder.ContactDetails.Phone.Number);
            Assert.AreEqual(Phone.TypeEnum.Mobile, r.Data.AccountHolder.ContactDetails.Phone.Type);

            Assert.IsNotNull(r.Data.AccountHolder.ContactDetails.Address);
            Assert.AreEqual("23", r.Data.AccountHolder.ContactDetails.Address.HouseNumberOrName);
            Assert.AreEqual("Amsterdam", r.Data.AccountHolder.ContactDetails.Address.City);
            Assert.AreEqual("NL", r.Data.AccountHolder.ContactDetails.Address.Country);
            Assert.AreEqual("12345", r.Data.AccountHolder.ContactDetails.Address.PostalCode);
            Assert.AreEqual("Main Street 1", r.Data.AccountHolder.ContactDetails.Address.Street);

            Assert.IsNotNull(r.Data.AccountHolder.Capabilities);
            Assert.IsTrue(r.Data.AccountHolder.Capabilities["issueCard"].Enabled);
            Assert.IsFalse(r.Data.AccountHolder.Capabilities["issueCard"].Allowed);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_BalanceAccount_Updated()
        {
            // Arrange
            string json =
                TestUtilities.GetTestFileContent("mocks/configurationwebhooks/balance-account-notification.json");

            // Act
            var r = _configurationWebhooksHandler.DeserializeBalanceAccountNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(BalanceAccountNotificationRequest.TypeEnum.BalancePlatformBalanceAccountUpdated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2024-12-15T15:42:03+01:00"), r.Timestamp);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);

            Assert.IsNotNull(r.Data.BalanceAccount);
            Assert.AreEqual("AH00000000000000000001", r.Data.BalanceAccount.AccountHolderId);
            Assert.AreEqual("EUR", r.Data.BalanceAccount.DefaultCurrencyCode);
            Assert.AreEqual("BA00000000000000000001", r.Data.BalanceAccount.Id);
            Assert.AreEqual(BalanceAccount.StatusEnum.Active, r.Data.BalanceAccount.Status);
            Assert.AreEqual("Europe/Amsterdam", r.Data.BalanceAccount.TimeZone);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_CardOlder_Created()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/configurationwebhooks/card-order-notification.json");

            // Act
            var r = _configurationWebhooksHandler.DeserializeCardOrderNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(CardOrderNotificationRequest.TypeEnum.BalancePlatformCardorderCreated, r.Type);
            // Assert.AreEqual(DateTimeOffset.Parse("2024-01-01T12:00:00Z"), r.Timestamp); // Timestamp is not in the new payload.

            Assert.IsNotNull(r.Data);

            Assert.IsNotNull(r.Data.Card);
            Assert.AreEqual(CardOrderItemDeliveryStatus.StatusEnum.Processing, r.Data.Card.Status);

            Assert.AreEqual("OI00000000000000000000001", r.Data.CardOrderItemId);
            Assert.AreEqual("PI00000000000000000000001", r.Data.PaymentInstrumentId);

            Assert.IsNotNull(r.Data.Pin);
            Assert.AreEqual(CardOrderItemDeliveryStatus.StatusEnum.Processing, r.Data.Pin.Status);

            Assert.AreEqual("dhlInternationalExpressBulk", r.Data.ShippingMethod);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_Score_Triggered()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/configurationwebhooks/score-notification.json");

            // Act
            var r = _configurationWebhooksHandler.DeserializeScoreNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(ScoreNotificationRequest.TypeEnum.BalancePlatformScoreTriggered, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2023-03-16T13:58:31+01:00"), r.Timestamp);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
            Assert.AreEqual(DateTimeOffset.Parse("2023-03-16T13:58:31+01:00"), r.Data.CreationDate);
            Assert.AreEqual("V4HZ4RBFJGXXGN82", r.Data.Id);

            Assert.IsNotNull(r.Data.AccountHolder);
            Assert.AreEqual("YOUR_ACCOUNT_HOLDER_REFERENCE", r.Data.AccountHolder.Reference);
            Assert.AreEqual("S.Hopper - Staff 123", r.Data.AccountHolder.Description);
            Assert.AreEqual("AH00000000000000000000001", r.Data.AccountHolder.Id);

            Assert.AreEqual(47, r.Data.RiskScore);

            Assert.IsNotNull(r.Data.ScoreSignalsTriggered);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_PaymentInstrument_Created()
        {
            // Arrange
            string json =
                TestUtilities.GetTestFileContent(
                    "mocks/configurationwebhooks/balancePlatform.paymentInstrument.created.json");

            // Act
            var r = _configurationWebhooksHandler.DeserializePaymentNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(PaymentNotificationRequest.TypeEnum.BalancePlatformPaymentInstrumentCreated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2024-12-15T15:42:03+01:00"), r.Timestamp);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);

            Assert.IsNotNull(r.Data.PaymentInstrument);
            Assert.AreEqual("BA00000000000000000001", r.Data.PaymentInstrument.BalanceAccountId);
            Assert.AreEqual("C. Holden - card", r.Data.PaymentInstrument.Description);
            Assert.AreEqual("GB", r.Data.PaymentInstrument.IssuingCountryCode);
            Assert.AreEqual(PaymentInstrument.StatusEnum.Active, r.Data.PaymentInstrument.Status);
            Assert.AreEqual(PaymentInstrument.TypeEnum.Card, r.Data.PaymentInstrument.Type);
            Assert.AreEqual("PI00000000000000000001", r.Data.PaymentInstrument.Id);

            Assert.IsNotNull(r.Data.PaymentInstrument.Card);
            Assert.AreEqual("Carl Holden", r.Data.PaymentInstrument.Card.CardholderName);
        }
    }
}