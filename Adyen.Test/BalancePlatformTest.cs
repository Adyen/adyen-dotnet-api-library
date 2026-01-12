using System;
using System.Net.Http;
using System.Threading;
using Adyen.Model.BalancePlatform;
using Adyen.Service.BalancePlatform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

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
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/AccountHolder.json");
            var service = new AccountHoldersService(client);
            
            var response = service.GetAccountHolder("AH32272223222B5CM4MWJ892H");
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        /// <summary>
        /// Test PostAccountHolders
        /// </summary>
        [TestMethod]
        public void PostAccountHoldersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/AccountHolder.json");
            var service = new AccountHoldersService(client);
            var accountHolder = new AccountHolderInfo()
            {
                BalancePlatform = "balance"
            };
            var response = service.CreateAccountHolder(accountHolder);
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        /// <summary>
        /// Test PatchAccountHoldersId
        /// </summary>
        [TestMethod]
        public void PatchAccountHoldersIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/AccountHolder.json");
            var service = new AccountHoldersService(client);
            var accountHolder = new AccountHolderUpdateRequest()
            {
                BalancePlatform = "balance"
            };
            var response = service.UpdateAccountHolder("AH32272223222B5CM4MWJ892H", accountHolder);
            Assert.AreEqual(response.Status, AccountHolder.StatusEnum.Active);
            Assert.AreEqual(response.Id, "AH32272223222B5CM4MWJ892H");
        }
        
        /// <summary>
        /// Test GetAccountHoldersIdBalanceAccountsAsync
        /// </summary>
        [TestMethod]
        public void GetAccountHoldersIdBalanceAccountsAsyncTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaginatedBalanceAccountsResponse.json");
            var service = new AccountHoldersService(client);
            
            var response = service.GetAllBalanceAccountsOfAccountHolderAsync("id", offset: 1, limit: 3).Result;
            Assert.AreEqual("BA32272223222B59K6ZXHBFN6", response.BalanceAccounts[0].Id);
            Assert.AreEqual(BalanceAccountBase.StatusEnum.Closed, response.BalanceAccounts[1].Status);
            ClientInterfaceSubstitute.Received()
                .RequestAsync(
                    "https://balanceplatform-api-test.adyen.com/bcl/v2/accountHolders/id/balanceAccounts?offset=1&limit=3",
                    null, null, HttpMethod.Get, default);
        }
        
        /// <summary>
        /// Test GetAccountHoldersId with additional attributes does not throw
        /// </summary>
        [TestMethod]
        public void GetAccountHoldersIdWithAdditionalAttributesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/AccountHolderAdditionalAttribute.json");
            var service = new AccountHoldersService(client);

            // Test that no exception is thrown when calling GetAccountHolder
            try
            {
                var response = service.GetAccountHolder("AH32272223222B5CM4MWJ892H");
                Assert.IsNotNull(response);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception, but got: {ex}");
            }
        }        

        #endregion

        #region BalanceAccounts

        /// <summary>
        /// Test GetBalanceAccountsId
        /// </summary>
        [TestMethod]
        public void GetBalanceAccountsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/BalanceAccount.json");
            var service = new  BalanceAccountsService(client);
            
            var response = service.GetBalanceAccount("AH32272223222B5CM4MWJ892H");
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222B5BLP6JQC3FD");
        }
        
        /// <summary>
        /// Test GetBalanceAccountsId
        /// </summary>
        [TestMethod]
        public void PostBalanceAccountsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/BalanceAccount.json");
            var service = new BalanceAccountsService(client);
            var balanceAccountInfo = new BalanceAccountInfo()
            {
                AccountHolderId = "accountHolderId"
            };
            var response = service.CreateBalanceAccount(balanceAccountInfo);
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222B5BLP6JQC3FD");
        }
        
        /// <summary>
        /// Test PatchBalanceAccountsIdAsync
        /// </summary>
        [TestMethod]
        public void PatchBalanceAccountsIdAsyncTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/BalanceAccount.json");
            var service = new BalanceAccountsService(client);
            var response = service.UpdateBalanceAccountAsync("BA3227C223222B5BLP6JQC3FD", new BalanceAccountUpdateRequest()).Result;
            Assert.AreEqual(response.Status, BalanceAccount.StatusEnum.Active);
            Assert.AreEqual(response.Id, "BA3227C223222B5BLP6JQC3FD");
        }
        
        /// <summary>
        /// Test PostBalanceAccountsBalanceAccountIdSweeps
        /// </summary>
        [TestMethod]
        public void PostBalanceAccountsBalanceAccountIdSweepsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/SweepConfiguration.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.CreateSweep("1245yhgeswkrw", new CreateSweepConfigurationV2());
            Assert.AreEqual(response.Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Type, SweepConfigurationV2.TypeEnum.Pull);
        }
        
        /// <summary>
        /// Test GetBalanceAccountsBalanceAccountIdSweeps
        /// </summary>
        [TestMethod]
        public void GetBalanceAccountsBalanceAccountIdSweepsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/BalanceSweepConfigurationsResponse.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.GetAllSweepsForBalanceAccount("balanceAccountId");
            Assert.AreEqual(response.Sweeps[0].Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Sweeps[0].Id, "SWPC4227C224555B5FTD2NT2JV4WN5");
            var schedule = response.Sweeps[0].Schedule.Type;
            Assert.AreEqual(schedule, SweepSchedule.TypeEnum.Daily);
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/balanceAccounts/balanceAccountId/sweeps",
                null,
                null, HttpMethod.Get, new CancellationToken());
        }
        
        /// <summary>
        /// Test PatchBalanceAccountsBalanceAccountIdSweepsSweepId
        /// </summary>
        [TestMethod]
        public void PatchBalanceAccountsBalanceAccountIdSweepsSweepIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/SweepConfiguration.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.UpdateSweep("balanceID", "sweepId",new UpdateSweepConfigurationV2());
            Assert.AreEqual(response.Status, SweepConfigurationV2.StatusEnum.Active);
            Assert.AreEqual(response.Type, SweepConfigurationV2.TypeEnum.Pull);
        }

        /// <summary>
        /// Test DeleteBalanceAccountsBalanceAccountIdSweepsSweepId
        /// </summary>
        [TestMethod]
        public void DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/SweepConfiguration.json");
            var service = new BalanceAccountsService(client);
            service.DeleteSweep("balanceID", "sweepId");
        }
        
        /// <summary>
        /// Test PatchBalanceAccountsBalanceAccountIdSweepsSweepId
        /// </summary>
        [TestMethod]
        public void GetBalanceAccountsIdPaymentInstrumentsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaginatedPaymentInstrumentsResponse.json");
            var service = new BalanceAccountsService(client);
            
            var response = service.GetPaymentInstrumentsLinkedToBalanceAccount("balanceID");
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
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/BalancePlatform.json");
            var service = new PlatformService(client);
            
            var response = service.GetBalancePlatform("uniqueIdentifier");
            Assert.AreEqual(response.Status, "Active");
            Assert.AreEqual(response.Id, "YOUR_BALANCE_PLATFORM");
        }
        
        /// <summary>
        /// Test GetBalancePlatformsIdAccountHolders
        /// </summary>
        [TestMethod]
        public void GetBalancePlatformsIdAccountHoldersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaginatedAccountHoldersResponse.json");
            var service = new PlatformService(client);
            
            var response = service.GetAllAccountHoldersUnderBalancePlatform("uniqueIdentifier");
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
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaymentInstrumentGroup.json");
            var service = new PaymentInstrumentGroupsService(client);
            
            var response = service.GetPaymentInstrumentGroup("uniqueIdentifier");
            Assert.AreEqual(response.Id, "PG3227C223222B5CMD3FJFKGZ");
            Assert.AreEqual(response.BalancePlatform, "YOUR_BALANCE_PLATFORM");
        }
        
        /// <summary>
        /// Test PostPaymentInstrumentGroups
        /// </summary>
        [TestMethod]
        public void PostPaymentInstrumentGroupsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaymentInstrumentGroup.json");
            var service = new PaymentInstrumentGroupsService(client);
            
            var response = service.CreatePaymentInstrumentGroup(new PaymentInstrumentGroupInfo());
            Assert.AreEqual(response.Id, "PG3227C223222B5CMD3FJFKGZ");
            Assert.AreEqual(response.BalancePlatform, "YOUR_BALANCE_PLATFORM");
        }
        
        /// <summary>
        /// Test GetPaymentInstrumentGroupsIdTransactionRules
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentGroupsIdTransactionRulesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRulesResponse.json");
            var service = new PaymentInstrumentGroupsService(client);
            
            var response = service.GetAllTransactionRulesForPaymentInstrumentGroup("id");
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
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaymentInstrument.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.CreatePaymentInstrument(new PaymentInstrumentInfo());
            Assert.AreEqual(response.BalanceAccountId, "BA3227C223222B5CTBLR8BWJB");
            Assert.AreEqual(response.Type, PaymentInstrument.TypeEnum.BankAccount);
        }
        
        /// <summary>
        /// Test PatchPaymentInstrumentsId
        /// </summary>
        [TestMethod]
        public void PatchPaymentInstrumentsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaymentInstrument.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.UpdatePaymentInstrument("id", new PaymentInstrumentUpdateRequest());
            Assert.AreEqual(response.BalanceAccountId, "BA3227C223222B5CTBLR8BWJB");
            Assert.AreEqual(response.Type, UpdatePaymentInstrument.TypeEnum.BankAccount);
        }
        
        /// <summary>
        /// Test GetPaymentInstrumentsId
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentsIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/PaymentInstrument.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.GetPaymentInstrument("id");
            Assert.AreEqual(response.BalanceAccountId, "BA3227C223222B5CTBLR8BWJB");
            Assert.AreEqual(response.Type, PaymentInstrument.TypeEnum.BankAccount);
        }
        
        /// <summary>
        /// Test GetPaymentInstrumentsIdTransactionRules
        /// </summary>
        [TestMethod]
        public void GetPaymentInstrumentsIdTransactionRulesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRulesResponse.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.GetAllTransactionRulesForPaymentInstrument("id");
            Assert.AreEqual(response.TransactionRules[0].Id, "TR32272223222B5CMDGMC9F4F");
            Assert.AreEqual(response.TransactionRules[0].Type, TransactionRule.TypeEnum.Velocity);
        }
        
        /// <summary>
        /// Test CreateNetworkTokenProvisioningData
        /// </summary>
        [TestMethod]
        public void CreateNetworkTokenProvisioningDataTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/networkTokenProvisioningData-success.json");
            var service = new PaymentInstrumentsService(client);
            
            var networkTokenActivationDataRequest = new NetworkTokenActivationDataRequest
            {
                SdkOutput = "...."
            };
            
            var response = service.CreateNetworkTokenProvisioningData("PI1234567890", networkTokenActivationDataRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(response.SdkInput, "....");
        }
        
        /// <summary>
        /// Test GetNetworkTokenActivationData
        /// </summary>
        [TestMethod]
        public void GetNetworkTokenActivationDataTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/NetworkTokenActivationDataResponse.json");
            var service = new PaymentInstrumentsService(client);
            
            var response = service.GetNetworkTokenActivationData("PI1234567890");
            Assert.IsNotNull(response);
            Assert.AreEqual(response.SdkInput, "....");
        }

        #endregion

        #region TransactionRules

        /// <summary>
        /// Test PostTransactionRules
        /// </summary>
        [TestMethod]
        public void PostTransactionRulesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRule.json");
            var service = new TransactionRulesService(client);
            
            var response = service.CreateTransactionRule(new TransactionRuleInfo());
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
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRule.json");
            var service = new TransactionRulesService(client);
            
            var response = service.UpdateTransactionRule("transactionRuleId", new TransactionRuleInfo());
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
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRuleResponse.json");
            var service = new TransactionRulesService(client);
            
            var response = service.GetTransactionRule("transactionRuleId");
            Assert.AreEqual(response.TransactionRule.Id, "TR32272223222B5CMD3V73HXG");
            Assert.AreEqual(response.TransactionRule.Interval.Type, TransactionRuleInterval.TypeEnum.Monthly);
        }
        
        /// <summary>
        /// Test DeleteTransactionRulesTransactionRuleId
        /// </summary>
        [TestMethod]
        public void DeleteTransactionRulesTransactionRuleIdTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRuleResponse.json");
            var service = new TransactionRulesService(client);
            var response = service.DeleteTransactionRule("transactionRuleId");
            
        }
        #endregion
        
        #region AuthorizedCardUsers

        /// <summary>
        /// Test CreateAuthorisedCardUsers
        /// </summary>
        [TestMethod]
        public void CreateAuthorisedCardUsersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/AuthorisedCardUsers-create-success.json");
            var service = new AuthorizedCardUsersService(client);
            
            var authorisedCardUsers = new AuthorisedCardUsers
            {
                LegalEntityIds = new System.Collections.Generic.List<string> { "LE1234567890" }
            };

            service.CreateAuthorisedCardUsers("PI1234567890", authorisedCardUsers);
            
            // The method is void, so we assert that the underlying HTTP call was made correctly.
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/paymentInstruments/PI1234567890/authorisedCardUsers",
                authorisedCardUsers.ToJson(),
                null,
                HttpMethod.Post,
                default
            );
        }

        /// <summary>
        /// Test GetAllAuthorisedCardUsers
        /// </summary>
        [TestMethod]
        public void GetAllAuthorisedCardUsersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/AuthorisedCardUsers-get-success.json");
            var service = new AuthorizedCardUsersService(client);
            
            var response = service.GetAllAuthorisedCardUsers("PI1234567890");
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.LegalEntityIds);
            Assert.AreEqual(1, response.LegalEntityIds.Count);
            Assert.AreEqual("LE1234567890", response.LegalEntityIds[0]);
        }

        /// <summary>
        /// Test UpdateAuthorisedCardUsers
        /// </summary>
        [TestMethod]
        public void UpdateAuthorisedCardUsersTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            var service = new AuthorizedCardUsersService(client);

            var authorisedCardUsers = new AuthorisedCardUsers
            {
                LegalEntityIds = new System.Collections.Generic.List<string> { "LE1234567890", "LE0987654321" }
            };

            service.UpdateAuthorisedCardUsers("PI1234567890", authorisedCardUsers);

            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/paymentInstruments/PI1234567890/authorisedCardUsers",
                authorisedCardUsers.ToJson(),
                null,
                Arg.Is<HttpMethod>(h => h.Method == "PATCH"),
                default
            );
        }

        /// <summary>
        /// Test DeleteAuthorisedCardUsers
        /// </summary>
        [TestMethod]
        public void DeleteAuthorisedCardUsersTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            var service = new AuthorizedCardUsersService(client);

            service.DeleteAuthorisedCardUsers("PI1234567890");

            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/paymentInstruments/PI1234567890/authorisedCardUsers",
                null,
                null,
                HttpMethod.Delete,
                default
            );
        }
        
        #endregion

        #region TransferLimitsBalanceAccountLevelApi

        [TestMethod]
        public void ApprovePendingTransferLimitsTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";
            var transferLimitId = "TRLI00000000000000000000000001";
            var approveTransferLimitRequest = new ApproveTransferLimitRequest()
            {
                TransferLimitIds = new System.Collections.Generic.List<string> { transferLimitId }
            };
            service.ApprovePendingTransferLimits(balanceAccountId, approveTransferLimitRequest);
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/balanceAccounts/BA12345677890/transferLimits/approve",
                approveTransferLimitRequest.ToJson(),
                null,
                HttpMethod.Post,
                default
            );
        }

        [TestMethod]
        public void CreateTransferLimitTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimit.json");
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";
            var createTransferLimitRequest = new CreateTransferLimitRequest
            {
                Amount = new Amount("EUR", 10000L),
                Scope = Scope.PerDay,
                Reference = "Your reference for the Transfer Limit",
                ScaInformation = new CreateScaInformation { ScaOnApproval = true },
                StartsAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                EndsAt = new DateTime(2025, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                TransferType = TransferType.All
            };

            var transferLimit = service.CreateTransferLimit(balanceAccountId, createTransferLimitRequest);
            
            Assert.IsNotNull(transferLimit);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimit.Id);
        }

        [TestMethod]
        public void DeletePendingTransferLimitTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";
            var transferLimitId = "TRLI00000000000000000000000001";

            service.DeletePendingTransferLimit(balanceAccountId, transferLimitId);
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/balanceAccounts/BA12345677890/transferLimits/TRLI00000000000000000000000001",
                null,
                null,
                HttpMethod.Delete,
                default);
        }

        [TestMethod]
        public void GetCurrentTransferLimitsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimits.json");
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";

            var transferLimits = service.GetCurrentTransferLimits(balanceAccountId);
            
            Assert.IsNotNull(transferLimits);
            Assert.AreEqual(2, transferLimits.TransferLimits.Count);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimits.TransferLimits[0].Id);
        }

        [TestMethod]
        public void GetCurrentTransferLimitsWithParametersTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimits.json");
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";

            var transferLimits = service.GetCurrentTransferLimits(balanceAccountId, Model.BalancePlatform.Scope.PerTransaction, TransferType.Instant);
            
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/balanceAccounts/BA12345677890/transferLimits/current?scope=PerTransaction&transferType=Instant",
                null,
                null,
                HttpMethod.Get,
                default
            );
            Assert.IsNotNull(transferLimits);
            Assert.AreEqual(2, transferLimits.TransferLimits.Count);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimits.TransferLimits[0].Id);
        }

        [TestMethod]
        public void GetSpecificTransferLimitTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimit.json");
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";
            var transferLimitId = "TRLI00000000000000000000000001";
            var transferLimit = service.GetSpecificTransferLimit(balanceAccountId, transferLimitId);
            
            Assert.IsNotNull(transferLimit);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimit.Id);
        }

        [TestMethod]
        public void GetTransferLimitsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimits.json");
            var service = new TransferLimitsBalanceAccountLevelService(client);
            var balanceAccountId = "BA12345677890";
            
            var transferLimits = service.GetTransferLimits(balanceAccountId);
            
            Assert.IsNotNull(transferLimits);
            Assert.AreEqual(2, transferLimits.TransferLimits.Count);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimits.TransferLimits[0].Id);
        }

        #endregion

        #region TransferLimitsBalancePlatformLevelApi
        [TestMethod]
        public void CreateTransferLimitForBalancePlatformTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimit.json");
            var service = new TransferLimitsBalancePlatformLevelService(client);
            var balancePlatformId = "BP12345677890";
            var createTransferLimitRequest = new CreateTransferLimitRequest
            {
                Amount = new Amount("EUR", 10000L),
                Scope = Scope.PerTransaction,
                Reference = "Your reference for the Transfer Limit",
                ScaInformation = new CreateScaInformation { ScaOnApproval = true },
                StartsAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                EndsAt = new DateTime(2025, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                TransferType = TransferType.All
            };

            var transferLimit = service.CreateTransferLimit(balancePlatformId, createTransferLimitRequest);
            
            Assert.IsNotNull(transferLimit);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimit.Id);
        }

        [TestMethod]
        public void DeletePendingTransferLimitForBalancePlatformTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            var service = new TransferLimitsBalancePlatformLevelService(client);
            var balancePlatformId = "BP12345677890";
            var transferLimitId = "TRLI00000000000000000000000001";

            service.DeletePendingTransferLimit(balancePlatformId, transferLimitId);
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/balancePlatforms/BP12345677890/transferLimits/TRLI00000000000000000000000001",
                null,
                null,
                HttpMethod.Delete,
                default);
        }

        [TestMethod]
        public void GetSpecificTransferLimitForBalancePlatformTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimit.json");
            var service = new TransferLimitsBalancePlatformLevelService(client);
            var balancePlatformId = "BP12345677890";
            var transferLimitId = "TRLI00000000000000000000000001";
            var transferLimit = service.GetSpecificTransferLimit(balancePlatformId, transferLimitId);
            
            Assert.IsNotNull(transferLimit);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimit.Id);
        }

        [TestMethod]
        public void GetTransferLimitsForBalancePlatformTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransferLimits.json");
            var service = new TransferLimitsBalancePlatformLevelService(client);
            var balancePlatformId = "BP12345677890";
            
            var transferLimits = service.GetTransferLimits(balancePlatformId);
            
            Assert.IsNotNull(transferLimits);
            Assert.AreEqual(2, transferLimits.TransferLimits.Count);
            Assert.AreEqual("TRLI00000000000000000000000001", transferLimits.TransferLimits[0].Id);
        }
        #endregion

        #region BankAccountValidation
        /// <summary>
        /// Test /validateBankAccountIdentification
        /// </summary>
        [TestMethod]
        public void ValidateBankAccountTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/balanceplatform/TransactionRuleResponse.json");
            var service = new BankAccountValidationService(client);
            var bankAccountIdentificationValidationRequest = new BankAccountIdentificationValidationRequest
            {
                AccountIdentification = new BankAccountIdentificationValidationRequestAccountIdentification(
                    new CZLocalAccountIdentification
                {
                    AccountNumber = "123456789",
                    BankCode = "bankCode",
                    Type = CZLocalAccountIdentification.TypeEnum.CzLocal
                })
            };
            service.ValidateBankAccountIdentification(bankAccountIdentificationValidationRequest);
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-test.adyen.com/bcl/v2/validateBankAccountIdentification",
                Arg.Any<String>(),
                null, HttpMethod.Post, new CancellationToken());
        }
        #endregion
    }
}