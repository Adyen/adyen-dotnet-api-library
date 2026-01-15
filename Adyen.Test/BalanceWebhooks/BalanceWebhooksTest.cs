using Adyen.BalanceWebhooks.Extensions;
using Adyen.BalanceWebhooks.Handlers;
using Adyen.BalanceWebhooks.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalanceWebhooks
{
    [TestClass]
    public class BalanceWebhooksTest
    {
        private readonly IBalanceWebhooksHandler _balanceWebhooksHandler;

        public BalanceWebhooksTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalanceWebhooks((context, services, config) =>
                {

                })
                .Build();

            _balanceWebhooksHandler = host.Services.GetRequiredService<IBalanceWebhooksHandler>();
        }

        [TestMethod]
        public void Given_Deserialize_When_Released_Blocked_Balance_Returns_Not_Null()
        {
            // Arrange
            string json = @"{
              ""data"": {
                ""accountHolder"": {
                  ""description"": ""Account holder for retail operations"",
                  ""id"": ""AH00000000000000000001"",
                  ""reference"": ""Store_001""
                },
                ""amount"": {
                  ""currency"": ""EUR"",
                  ""value"": 25000
                },
                ""balanceAccount"": {
                  ""description"": ""Main operating account"",
                  ""id"": ""BA00000000000000000001"",
                  ""reference"": ""OP_ACCT_MAIN""
                },
                ""balancePlatform"": ""YOUR_BALANCE_PLATFORM"",
                ""batchReference"": ""BATCH_REF_20250925"",
                ""blockedBalanceAfter"": {
                  ""currency"": ""EUR"",
                  ""value"": -75000
                },
                ""blockedBalanceBefore"": {
                  ""currency"": ""EUR"",
                  ""value"": -100000
                },
                ""creationDate"": ""2025-09-25T14:30:00Z"",
                ""valueDate"": ""2025-09-25T14:35:00Z""
              },
              ""environment"": ""test"",
              ""timestamp"": ""2025-09-25T14:35:00Z"",
              ""type"": ""balancePlatform.balanceAccount.balance.block.released""
            }";
            
            // Act
            var r = _balanceWebhooksHandler.DeserializeReleasedBlockedBalanceNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(ReleasedBlockedBalanceNotificationRequest.TypeEnum.BalancePlatformBalanceAccountBalanceBlockReleased, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2025-09-25T14:35:00Z"), r.Timestamp);
            
            Assert.IsNotNull(r.Data);
            Assert.AreEqual("Account holder for retail operations", r.Data.AccountHolder.Description);
            Assert.AreEqual("AH00000000000000000001", r.Data.AccountHolder.Id);
            Assert.AreEqual("Store_001", r.Data.AccountHolder.Reference);
            
            Assert.AreEqual("EUR", r.Data.Amount.Currency);
            Assert.AreEqual(25000, r.Data.Amount.Value);
            
            Assert.AreEqual("Main operating account", r.Data.BalanceAccount.Description);
            Assert.AreEqual("BA00000000000000000001", r.Data.BalanceAccount.Id);
            Assert.AreEqual("OP_ACCT_MAIN", r.Data.BalanceAccount.Reference);
            
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
            Assert.AreEqual("BATCH_REF_20250925", r.Data.BatchReference);
            
            Assert.AreEqual("EUR", r.Data.BlockedBalanceAfter.Currency);
            Assert.AreEqual(-75000, r.Data.BlockedBalanceAfter.Value);
            
            Assert.AreEqual("EUR", r.Data.BlockedBalanceBefore.Currency);
            Assert.AreEqual(-100000, r.Data.BlockedBalanceBefore.Value);
            
            Assert.AreEqual(DateTimeOffset.Parse("2025-09-25T14:30:00Z"), r.Data.CreationDate);
            Assert.AreEqual(DateTimeOffset.Parse("2025-09-25T14:35:00Z"), r.Data.ValueDate);
        }

        [TestMethod]
        public void Given_Deserialize_When_Balance_Account_Balance_Notification_Returns_Not_Null()
        {
            // Arrange
            string json = @"{
              ""data"": {
                ""balanceAccountId"": ""BWHS00000000000000000000000001"",
                ""balancePlatform"": ""YOUR_BALANCE_PLATFORM"",
                ""balances"": {
                  ""available"": 499900,
                  ""pending"": 350000,
                  ""reserved"": 120000,
                  ""balance"": 470000
                },
                ""creationDate"": ""2025-01-19T13:37:38+02:00"",
                ""currency"": ""USD"",
                ""settingIds"": [""WK1"", ""WK2""]
              },
              ""environment"": ""test"",
              ""type"": ""balancePlatform.balanceAccount.balance.updated""
            }";

            // Act
            var r = _balanceWebhooksHandler.DeserializeBalanceAccountBalanceNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(BalanceAccountBalanceNotificationRequest.TypeEnum.BalancePlatformBalanceAccountBalanceUpdated, r.Type);
            
            Assert.IsNotNull(r.Data);
            Assert.AreEqual("BWHS00000000000000000000000001", r.Data.BalanceAccountId);
            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
            
            Assert.IsNotNull(r.Data.Balances);
            Assert.AreEqual(499900, r.Data.Balances.Available);
            Assert.AreEqual(350000, r.Data.Balances.Pending);
            Assert.AreEqual(120000, r.Data.Balances.Reserved);
            Assert.AreEqual(470000, r.Data.Balances.Balance);
            
            Assert.AreEqual(DateTimeOffset.Parse("2025-01-19T13:37:38+02:00"), r.Data.CreationDate);
            Assert.AreEqual("USD", r.Data.Currency);
            
            Assert.IsNotNull(r.Data.SettingIds);
            CollectionAssert.AreEqual(new string[] { "WK1", "WK2" }, r.Data.SettingIds);
        }
    }
}

