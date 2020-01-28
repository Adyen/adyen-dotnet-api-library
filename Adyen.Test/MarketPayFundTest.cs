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
using System.IO;
using Adyen.Model.MarketPay;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

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
            Assert.AreEqual(42058L, accountHolderBalanceResponse.TotalBalance.PendingBalance[0].Amount.Value);
            Assert.AreEqual(99792L, accountHolderBalanceResponse.TotalBalance.Balance[0].Amount.Value);
            Assert.AreEqual("9914719436100053", accountHolderBalanceResponse.PspReference);
            Assert.AreEqual("Success", accountHolderBalanceResponse.ResultCode);
            Assert.AreEqual(42058L, accountHolderBalanceResponse.BalancePerAccount[0].AccountDetailBalance.DetailBalance.PendingBalance[0].Amount.Value);
            Assert.AreEqual(99792L, accountHolderBalanceResponse.BalancePerAccount[0].AccountDetailBalance.DetailBalance.Balance[0].Amount.Value);
            Assert.AreEqual("118731451", accountHolderBalanceResponse.BalancePerAccount[0].AccountDetailBalance.AccountCode);
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
            var transactions = accountHolderTransactionListResponse.AccountTransactionLists[0].AccountTransactionList.Transactions;
            Assert.AreEqual(4, transactions.Count);
            Assert.AreEqual("9914716081770032", transactions[0].Transaction.PspReference);
            Assert.AreEqual("9914716081760025", transactions[1].Transaction.PspReference);
            Assert.AreEqual("9914716081730010", transactions[2].Transaction.PspReference);
            Assert.AreEqual("9914716006590028", transactions[3].Transaction.PspReference);
            Assert.AreEqual("testReference", transactions[0].Transaction.MerchantReference);
            Assert.AreEqual("testReference2", transactions[1].Transaction.MerchantReference);
            Assert.AreEqual("testReference3", transactions[2].Transaction.MerchantReference);
            Assert.AreEqual("testReference4", transactions[3].Transaction.MerchantReference);
            Assert.AreEqual(Transaction.TransactionStatusEnum.PendingCredit,  transactions[0].Transaction.TransactionStatus);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Credited, transactions[1].Transaction.TransactionStatus);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Credited, transactions[2].Transaction.TransactionStatus);
            Assert.AreEqual(Transaction.TransactionStatusEnum.Debited, transactions[3].Transaction.TransactionStatus);

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
