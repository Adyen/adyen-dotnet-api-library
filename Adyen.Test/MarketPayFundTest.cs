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
            Assert.AreEqual("8515803871979158", accountHolderBalanceResponse.PspReference);
            Assert.AreEqual("112548519", accountHolderBalanceResponse.BalancePerAccount[0].AccountCode);
            Assert.AreEqual("128653506", accountHolderBalanceResponse.BalancePerAccount[1].AccountCode);
            Assert.AreEqual("162991090", accountHolderBalanceResponse.BalancePerAccount[2].AccountCode);
            Assert.AreEqual("EUR", accountHolderBalanceResponse.BalancePerAccount[0].DetailBalance.Balance[0].Currency);
            Assert.AreEqual(-1080670, accountHolderBalanceResponse.BalancePerAccount[0].DetailBalance.Balance[0].Value);
            Assert.AreEqual("USD", accountHolderBalanceResponse.BalancePerAccount[0].DetailBalance.Balance[1].Currency);
            Assert.AreEqual(-1085000, accountHolderBalanceResponse.BalancePerAccount[0].DetailBalance.Balance[1].Value);
            Assert.AreEqual("GBP", accountHolderBalanceResponse.BalancePerAccount[0].DetailBalance.Balance[2].Currency);
            Assert.AreEqual(-1085000, accountHolderBalanceResponse.BalancePerAccount[0].DetailBalance.Balance[2].Value);
            Assert.AreEqual(0 ,accountHolderBalanceResponse.TotalBalance.PendingBalance.Count);
            Assert.AreEqual(0, accountHolderBalanceResponse.TotalBalance.OnHoldBalance.Count);
            Assert.AreEqual(3, accountHolderBalanceResponse.TotalBalance.Balance.Count);
            Assert.AreEqual(-1080670, accountHolderBalanceResponse.TotalBalance.Balance[0].Value);
            Assert.AreEqual("EUR", accountHolderBalanceResponse.TotalBalance.Balance[0].Currency);
            Assert.AreEqual(-1085000, accountHolderBalanceResponse.TotalBalance.Balance[1].Value);
            Assert.AreEqual("USD", accountHolderBalanceResponse.TotalBalance.Balance[1].Currency);
            Assert.AreEqual(-1085000, accountHolderBalanceResponse.TotalBalance.Balance[2].Value);
            Assert.AreEqual("GBP", accountHolderBalanceResponse.TotalBalance.Balance[2].Currency);
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
            Assert.AreEqual("9914721175530029", accountHolderTransactionListResponse.PspReference);
            Assert.AreEqual("Success", accountHolderTransactionListResponse.ResultCode);
            var transactions = accountHolderTransactionListResponse.AccountTransactionLists[0].Transactions;
            Assert.AreEqual(4, transactions.Count);
            Assert.AreEqual("9914716081770032", transactions[0].PspReference);
            Assert.AreEqual("9914716081760025", transactions[1].PspReference);
            Assert.AreEqual("9914716081730010", transactions[2].PspReference);
            Assert.AreEqual("9914716006590028", transactions[3].PspReference);
            Assert.AreEqual("testReference", transactions[0].MerchantReference);
            Assert.AreEqual("testReference2", transactions[1].MerchantReference);
            Assert.AreEqual("testReference3", transactions[2].MerchantReference);
            Assert.AreEqual("testReference4", transactions[3].MerchantReference);
            Assert.AreEqual(Transaction.TransactionStatusEnum.PendingCredit,  transactions[0].TransactionStatus);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Credited, transactions[1].TransactionStatus);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Credited, transactions[2].TransactionStatus);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Debited, transactions[3].TransactionStatus);

        }

        [TestMethod]
        public void TestTransferFundsSuccess()
        {
            var amount = new Amount("EUR", 1000);
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/transfer-funds-success.json");
            var fund = new Fund(client);
            var transferFundsRequest = new TransferFundsRequest(amount: amount, destinationAccountCode: "190324759", merchantReference: "merchantReference", sourceAccountCode: "00000", transferCode: "1235");
            var transferFundsResponse = fund.TransferFunds(transferFundsRequest);
            Assert.AreEqual("9915090893984580", transferFundsResponse.PspReference);
            Assert.AreEqual("MerchantReference", transferFundsResponse.MerchantReference);
            Assert.AreEqual("Received", transferFundsResponse.ResultCode);
        }

        [TestMethod]
        public void TestRefundNotPaidOutTransfersSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/refund-not-paid-out-transfers-success.json");
            var fund = new Fund(client);
            var refundNotPaidOutTransfersRequest = new RefundNotPaidOutTransfersRequest(accountCode: "189184578", accountHolderCode: "TestAccountHolder502924");
            var refundNotPaidOutTransfersResponse = fund.RefundNotPaidOutTransfers(refundNotPaidOutTransfersRequest);
            Assert.AreEqual("9915090894215323", refundNotPaidOutTransfersResponse.PspReference);
            Assert.AreEqual("Failed", refundNotPaidOutTransfersResponse.ResultCode);
        }

        [TestMethod]
        public void TestSetupBeneficiary()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/setup-beneficiary-success.json");
            var fund = new Fund(client);
            var setupBeneficiaryRequest = new SetupBeneficiaryRequest(destinationAccountCode: "128952522", merchantReference: "TestMerchantReference", sourceAccountCode: "134498192");
            var setupBeneficiaryResponse = fund.SetupBeneficiary(setupBeneficiaryRequest);
            Assert.AreEqual("9914860354282596", setupBeneficiaryResponse.PspReference);
            Assert.AreEqual("Success", setupBeneficiaryResponse.ResultCode);
        }

        [TestMethod]
        public void TestPayoutAccountHolderSuccess()
        {
            var amount = new Amount("EUR", 1000);
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/payout-account-holder-success.json");
            var fund = new Fund(client);
            PayoutAccountHolderRequest payoutAccountHolderRequest = new PayoutAccountHolderRequest(accountCode: "189184578", accountHolderCode: "TestAccountHolder502924", amount: amount);
            var payoutAccountHolderResponse = fund.PayoutAccountHolder(payoutAccountHolderRequest);
            Assert.AreEqual("9915090894325643", payoutAccountHolderResponse.PspReference);
            Assert.AreEqual("testbankaccount", payoutAccountHolderResponse.BankAccountUUID);
            Assert.AreEqual("MerchantReference", payoutAccountHolderResponse.MerchantReference);
        }
    }
}
