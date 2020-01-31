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
//  * Copyright (c) 2020 Adyen B.V.
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
        /// <summary>
        /// test /accountHolderBalance
        /// </summary>
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

        /// <summary>
        /// test /accountHolderTransactionList 
        /// </summary>
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
                    }
                };
            var transactionListForAccount = new TransactionListForAccount("2e64b396-1200-4474-b848-0cb06b52b3c7", 2);
            accountHolderTransactionListRequest.TransactionListsPerAccount = new List<TransactionListForAccount> { transactionListForAccount };
            var accountHolderTransactionListResponse = fund.AccountHolderTransactionList(accountHolderTransactionListRequest);
            Assert.AreEqual("881580394403000", accountHolderTransactionListResponse.PspReference);
            Assert.AreEqual("Success", accountHolderTransactionListResponse.ResultCode);
            Assert.AreEqual(3, accountHolderTransactionListResponse.AccountTransactionLists.Count);
            Assert.AreEqual("112548561", accountHolderTransactionListResponse.AccountTransactionLists[0].AccountCode);
            var transactions = accountHolderTransactionListResponse.AccountTransactionLists[0].Transactions;
            Assert.AreEqual(50, transactions.Count);
            Assert.AreEqual(new Amount("USD",-35000), transactions[0].Amount);
            Assert.AreEqual("PluginDemo - 126", transactions[0].Description);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Debited, transactions[0].TransactionStatus);
            Assert.AreEqual(new Amount("USD", -17500), transactions[1].Amount);
            Assert.AreEqual("PluginDemo - 125", transactions[1].Description);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Debited, transactions[1].TransactionStatus);
            Assert.AreEqual("162991091", accountHolderTransactionListResponse.AccountTransactionLists[1].AccountCode);
            Assert.AreEqual(false, accountHolderTransactionListResponse.AccountTransactionLists[1].HasNextPage);
            Assert.AreEqual("128653501", accountHolderTransactionListResponse.AccountTransactionLists[2].AccountCode);
            Assert.AreEqual(false, accountHolderTransactionListResponse.AccountTransactionLists[2].HasNextPage);
        }

        /// <summary>
        /// test /transferFunds
        /// </summary>
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

        /// <summary>
        /// test /refundNotPaidOutTransfers
        /// </summary>
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

        /// <summary>
        /// test /setupBeneficiar
        /// </summary>
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

        /// <summary>
        /// test /payoutAccountHolder
        /// </summary>
        [TestMethod]
        public void TestPayoutAccountHolderSuccess()
        {
            var amount = new Amount("EUR", 1000);
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/payout-account-holder-success.json");
            var fund = new Fund(client);
            var payoutAccountHolderRequest = new PayoutAccountHolderRequest(accountCode: "189184578", accountHolderCode: "TestAccountHolder502924", amount: amount);
            var payoutAccountHolderResponse = fund.PayoutAccountHolder(payoutAccountHolderRequest);
            Assert.AreEqual("9915090894325643", payoutAccountHolderResponse.PspReference);
            Assert.AreEqual("testbankaccount", payoutAccountHolderResponse.BankAccountUUID);
            Assert.AreEqual("MerchantReference", payoutAccountHolderResponse.MerchantReference);
        }

        /// <summary>
        /// test /refundFundsTransfer
        /// </summary>
        [TestMethod]
        public void TestRefundFundsTransferSuccess()
        {
            var amount = new Amount("EUR", 1000);
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/fund/refund-funds-transfer.json");
            var fund = new Fund(client);
            var refundFundsTransferRequest = new RefundFundsTransferRequest(originalReference: "reference", amount: amount);
            var refundFundsTransferResponse = fund.RefundFundsTransfer(refundFundsTransferRequest);
            Assert.AreEqual("9915090893984580", refundFundsTransferResponse.PspReference);
            Assert.AreEqual("Received", refundFundsTransferResponse.ResultCode);
        }
    }
}
