#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Collections.Generic;
using Adyen.Model.MarketPay;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class MarketPayFundTest : BaseTest
    {
        [TestMethod]
        public void TestAccountHolderBalanceSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/account-holder-balance-success.json");
            var fund = new Fund(client);
            var accountHolderBalanceRequest = new AccountHolderBalanceRequest("TestAccountHolder877209");
            var accountHolderBalanceResponse = fund.AccountHolderBalance(accountHolderBalanceRequest);
            Assert.AreEqual(42058L,accountHolderBalanceResponse.TotalBalance);
            Assert.AreEqual(99792L, accountHolderBalanceResponse.BalancePerAccount[0].AccountCode);
        }

        [TestMethod]
        public void TestAccountHolderTransactionListSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/account-holder-transaction-list-success.json");
            var fund = new Fund(client);
            var accountHolderTransactionListRequest =
                new AccountHolderTransactionListRequest(accountHolderCode: "TestAccountHolder423978")
                {
                    TransactionStatuses = new List<AccountHolderTransactionListRequest.TransactionStatusesEnum>
                    {
                        AccountHolderTransactionListRequest.TransactionStatusesEnum.PendingCredit,
                        AccountHolderTransactionListRequest.TransactionStatusesEnum.Credited,
                        AccountHolderTransactionListRequest.TransactionStatusesEnum.Debited
                    }
                };
            var transactionListForAccount = new TransactionListForAccount("2e64b396-1200-4474-b848-0cb06b52b3c7", 2);
            accountHolderTransactionListRequest.TransactionListsPerAccount = new List<TransactionListForAccount> { transactionListForAccount };
            var accountHolderTransactionListResponse = fund.AccountHolderTransactionList(accountHolderTransactionListRequest);
            Assert.AreEqual("", "");
        }

        /*
         
         public void TestAccountHolderTransactionListSuccess() throws Exception {
        // setup client
        Client client = createMockClientFromFile("mocks/marketpay/fund/account-holder-transaction-list-success.json");

        // use Fund service
        Fund fund = new Fund(client);

        // create AccountHolderTransactionList Request
        AccountHolderTransactionListRequest accountHolderTransactionListRequest = new AccountHolderTransactionListRequest();
        accountHolderTransactionListRequest.setAccountHolderCode("TestAccountHolder423978");
        accountHolderTransactionListRequest.addTransactionStatusesItem(AccountHolderTransactionListRequest.TransactionStatusesEnum.PENDINGCREDIT);
        accountHolderTransactionListRequest.addTransactionStatusesItem(AccountHolderTransactionListRequest.TransactionStatusesEnum.CREDITED);
        accountHolderTransactionListRequest.addTransactionStatusesItem(AccountHolderTransactionListRequest.TransactionStatusesEnum.DEBITED);
        TransactionListForAccount transactionListForAccount = new TransactionListForAccount();
        transactionListForAccount.setAccountCode("2e64b396-1200-4474-b848-0cb06b52b3c7");
        transactionListForAccount.setPage(2);
        accountHolderTransactionListRequest.addTransactionListsPerAccountItem(transactionListForAccount);
        AccountHolderTransactionListResponse accountHolderTransactionListResponse = fund.accountHolderTransactionList(accountHolderTransactionListRequest);

        assertEquals("12345 - Test", accountHolderTransactionListResponse.getAccountTransactionLists().get(0).getTransactions().get(0).getDescription());
    }
         */


    }
}
