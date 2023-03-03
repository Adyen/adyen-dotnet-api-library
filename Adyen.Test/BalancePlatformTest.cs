using System;
using System.Net.Http;
using Adyen.Model.BalancePlatform;
using Adyen.Service.BalancePlatform;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class BalancePlatformTest : BaseTest
    {
        #region AccountHolders

        /// <summary>
        /// Test GetAccountHoldersId
        /// </summary>
        [TestMethod]
        public void GetAccountHoldersIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/AccountHolder.json");
            var service = new AccountHoldersService(client);
            
            var response = service.Retrieve("AH32272223222B5CM4MWJ892H");
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        /// <summary>
        /// Test PostAccountHolders
        /// </summary>
        [TestMethod]
        public void PostAccountHoldersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/AccountHolder.json");
            var service = new AccountHoldersService(client);
            var accountHolder = new AccountHolderInfo()
            {
                BalancePlatform = "balance"
            };
            var response = service.Create(accountHolder);
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        /// <summary>
        /// Test PatchAccountHoldersId
        /// </summary>
        [TestMethod]
        public void PatchAccountHoldersIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/AccountHolder.json");
            var service = new AccountHoldersService(client);
            var accountHolder = new AccountHolder()
            {
                BalancePlatform = "balance"
            };
            var response = service.Update("AH32272223222B5CM4MWJ892H", accountHolder);
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        /// <summary>
        /// Test GetAccountHoldersIdBalanceAccountsAsync
        /// </summary>
        [TestMethod]
        public void GetAccountHoldersIdBalanceAccountsAsyncTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaginatedBalanceAccountsResponse.json");
            var service = new AccountHoldersService(client);
            
            var response = service.ListBalanceAccountsAsync("id", offset: 1, limit: 3).Result;
            Assert.AreEqual("BA32272223222B59K6ZXHBFN6", response.BalanceAccounts[0].Id);
            Assert.AreEqual(BalanceAccount.StatusEnum.Closed, response.BalanceAccounts[1].Status);
            ClientInterfaceMock.Verify(mock => mock.RequestAsync("/v2/accountHolders/id/balanceAccounts?offset=1&limit=3", null, null, HttpMethod.Get));
        }

        #endregion

        #region BalanceAccounts

        /// <summary>
        /// Test GetBalanceAccountsId
        /// </summary>
        [TestMethod]
        public void GetBalanceAccountsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/BalanceAccount.json");
            var service = new  BalanceAccountsService(client);
            
            var response = service.Retrieve("AH32272223222B5CM4MWJ892H");
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222B5BLP6JQC3FD");
        }
        
        /// <summary>
        /// Test GetBalanceAccountsId
        /// </summary>
        [TestMethod]
        public void PostBalanceAccountsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/BalanceAccount.json");
            var service = new BalanceAccountsService(client);
            var balanceAccountInfo = new BalanceAccountInfo()
            {
                AccountHolderId = "accountHolderId"
            };
            var response = service.Create(balanceAccountInfo);
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222B5BLP6JQC3FD");
        }
        
        /// <summary>
        /// Test PatchBalanceAccountsIdAsync
        /// </summary>
        [TestMethod]
        public void PatchBalanceAccountsIdAsyncTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/BalanceAccount.json");
            var service = new BalanceAccountsService(client);
            var response = service.UpdateAsync("BA3227C223222B5BLP6JQC3FD", new BalanceAccountUpdateRequest()).Result;
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222B5BLP6JQC3FD");
        }
        
        /// <summary>
        /// Test PostBalanceAccountsBalanceAccountIdSweeps
        /// </summary>
        [TestMethod]
        public void PostBalanceAccountsBalanceAccountIdSweepsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/SweepConfiguration.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.CreateSweep("1245yhgeswkrw", new SweepConfigurationV2());
            Assert.AreEqual(response.Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Type, SweepConfigurationV2.TypeEnum.Pull);
        }
        
        /// <summary>
        /// Test GetBalanceAccountsBalanceAccountIdSweeps
        /// </summary>
        [TestMethod]
        public void GetBalanceAccountsBalanceAccountIdSweepsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/BalanceSweepConfigurationsResponse.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.ListSweeps("balanceAccountId");
            Assert.AreEqual(response.Sweeps[0].Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Sweeps[0].Id, "SWPC4227C224555B5FTD2NT2JV4WN5");
            var schedule = response.Sweeps[0].Schedule.GetCronSweepSchedule();
            Assert.AreEqual(schedule.Type, CronSweepSchedule.TypeEnum.Daily);
        }
        
        /// <summary>
        /// Test PatchBalanceAccountsBalanceAccountIdSweepsSweepId
        /// </summary>
        [TestMethod]
        public void PatchBalanceAccountsBalanceAccountIdSweepsSweepIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/SweepConfiguration.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.UpdateSweep("balanceID", "sweepId",new SweepConfigurationV2());
            Assert.AreEqual(response.Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Type, SweepConfigurationV2.TypeEnum.Pull);
        }

        /// <summary>
        /// Test DeleteBalanceAccountsBalanceAccountIdSweepsSweepId
        /// </summary>
        [TestMethod]
        public void DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/SweepConfiguration.json");
            var service = new BalanceAccountsService(client);
            service.DeleteSweep("balanceID", "sweepId");
        }
        
        /// <summary>
        /// Test PatchBalanceAccountsBalanceAccountIdSweepsSweepId
        /// </summary>
        [TestMethod]
        public void GetBalanceAccountsIdPaymentInstrumentsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaginatedPaymentInstrumentsResponse.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.ListPaymentInstruments("balanceID");
            Assert.AreEqual(response.PaymentInstruments[0].Status, PaymentInstrument.StatusEnum.Active);
            Assert.AreEqual(response.PaymentInstruments[0].Id, "PI32272223222B59M5TM658DT");
        }
        #endregion

        #region General

        /// <summary>
        /// Test GetBalancePlatformsId
        /// </summary>
        [TestMethod]
        public void GetBalancePlatformsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/BalancePlatform.json");
            var service = new PlatformService(client);
            
            var response = service.Retrieve("uniqueIdentifier");
            Assert.AreEqual(response.Status, "Active");
            Assert.AreEqual(response.Id, "YOUR_BALANCE_PLATFORM");
        }
        
        /// <summary>
        /// Test GetBalancePlatformsIdAccountHolders
        /// </summary>
        [TestMethod]
        public void GetBalancePlatformsIdAccountHoldersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaginatedAccountHoldersResponse.json");
            var service = new PlatformService(client);
            
            var response = service.ListAccountHolders("uniqueIdentifier");
            Assert.AreEqual(response.AccountHolders[0].Id, "AH32272223222B59DDWSCCMP7");
            Assert.AreEqual(response.AccountHolders[0].Status, AccountHolder.StatusEnum.Active);
        }

        #endregion

        #region PaymentInstrumentGroups

        /// <summary>
        /// Test GetPaymentInstrumentGroupsId
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentGroupsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaymentInstrumentGroup.json");
            var service = new PaymentInstrumentGroupsService(client);
            
            var response = service.Retrieve("uniqueIdentifier");
            Assert.AreEqual(response.Id, "PG3227C223222B5CMD3FJFKGZ");
            Assert.AreEqual(response.BalancePlatform, "YOUR_BALANCE_PLATFORM");
        }
        
        /// <summary>
        /// Test PostPaymentInstrumentGroups
        /// </summary>
        [TestMethod]
        public void PostPaymentInstrumentGroupsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaymentInstrumentGroup.json");
            var service = new PaymentInstrumentGroupsService(client);
            
            var response = service.Create(new PaymentInstrumentGroupInfo());
            Assert.AreEqual(response.Id, "PG3227C223222B5CMD3FJFKGZ");
            Assert.AreEqual(response.BalancePlatform, "YOUR_BALANCE_PLATFORM");
        }
        
        /// <summary>
        /// Test GetPaymentInstrumentGroupsIdTransactionRules
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentGroupsIdTransactionRulesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/TransactionRulesResponse.json");
            var service = new PaymentInstrumentGroupsService(client);
            
            var response = service.ListTransactionRules("id");
            Assert.AreEqual(response.TransactionRules[0].Type, TransactionRule.TypeEnum.Velocity);
            Assert.AreEqual(response.TransactionRules[0].Id, "TR32272223222B5CMDGMC9F4F");
        }

        #endregion

        #region PaymenInstruments

        /// <summary>
        /// Test GetPaymentInstrumentGroupsId
        /// </summary>
        [TestMethod]
        public void PostPaymentInstrumentsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaymentInstrument.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.Create(new PaymentInstrumentInfo());
            Assert.AreEqual(response.BalanceAccountId, "BA3227C223222B5CTBLR8BWJB");
            Assert.AreEqual(response.Type, PaymentInstrument.TypeEnum.BankAccount);
        }
        
        /// <summary>
        /// Test PatchPaymentInstrumentsId
        /// </summary>
        [TestMethod]
        public void PatchPaymentInstrumentsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaymentInstrument.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.Update("id", new PaymentInstrumentUpdateRequest());
            Assert.AreEqual(response.BalanceAccountId, "BA3227C223222B5CTBLR8BWJB");
            Assert.AreEqual(response.Type, PaymentInstrument.TypeEnum.BankAccount);
        }
        
        /// <summary>
        /// Test GetPaymentInstrumentsId
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/PaymentInstrument.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.Retrieve("id");
            Assert.AreEqual(response.BalanceAccountId, "BA3227C223222B5CTBLR8BWJB");
            Assert.AreEqual(response.Type, PaymentInstrument.TypeEnum.BankAccount);
        }
        
        /// <summary>
        /// Test GetPaymentInstrumentsIdTransactionRules
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentsIdTransactionRulesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/TransactionRulesResponse.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.ListTransactionRules("id");
            Assert.AreEqual(response.TransactionRules[0].Id, "TR32272223222B5CMDGMC9F4F");
            Assert.AreEqual(response.TransactionRules[0].Type, TransactionRule.TypeEnum.Velocity);
        }

        #endregion

        #region TransactionRules

        /// <summary>
        /// Test PostTransactionRules
        /// </summary>
        [TestMethod]
        public void PostTransactionRulesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/TransactionRule.json");
            var service = new TransactionRulesService(client);
            
            var response = service.Create(new TransactionRuleInfo());
            Assert.AreEqual(response.EntityKey.EntityReference, "PI3227C223222B5BPCMFXD2XG");
            Assert.AreEqual(response.EntityKey.EntityType, "paymentInstrument");
            Assert.AreEqual(response.Interval.Type, TransactionRuleInterval.TypeEnum.PerTransaction);
        }
        
        /// <summary>
        /// Test PatchTransactionRulesTransactionRuleId
        /// </summary>
        [TestMethod]
        public void PatchTransactionRulesTransactionRuleIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/TransactionRule.json");
            var service = new TransactionRulesService(client);
            
            var response = service.Update("transactionRuleId", new TransactionRuleInfo());
            Assert.AreEqual(response.EntityKey.EntityReference, "PI3227C223222B5BPCMFXD2XG");
            Assert.AreEqual(response.EntityKey.EntityType, "paymentInstrument");
            Assert.AreEqual(response.Interval.Type, TransactionRuleInterval.TypeEnum.PerTransaction);
        }
        
        /// <summary>
        /// Test GetTransactionRulesTransactionRuleId
        /// </summary>
        [TestMethod]
        public void GetTransactionRulesTransactionRuleIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/TransactionRuleResponse.json");
            var service = new TransactionRulesService(client);
            
            var response = service.Retrieve("transactionRuleId");
            Assert.AreEqual(response.TransactionRule.Id, "TR32272223222B5CMD3V73HXG");
            Assert.AreEqual(response.TransactionRule.Interval.Type, TransactionRuleInterval.TypeEnum.Monthly);
        }
        
        /// <summary>
        /// Test DeleteTransactionRulesTransactionRuleId
        /// </summary>
        [TestMethod]
        public void DeleteTransactionRulesTransactionRuleIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/balanceplatform/TransactionRuleResponse.json");
            var service = new TransactionRulesService(client);
            var response = service.Delete("transactionRuleId");
            
        }
        #endregion
    }
}