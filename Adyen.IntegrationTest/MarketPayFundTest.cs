using Adyen.Model.MarketPay;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class MarketPayFundTest : BaseTest
    {
        private Client _client;
        private Fund _fund;

        [TestInitialize]
        public void Init()
        {
            _client = new Client(ClientConstants.CaUsername, ClientConstants.CaPassword, Model.Enum.Environment.Test);
            _fund = new Fund(_client);
        }

        /// <summary>
        ///  test /accountHoldertransactionList
        /// </summary>
        [TestMethod]
        public void AccountHoldertransactionListResponseSuccess()
        {
            var accountHolderTransactionListRequest = new AccountHolderTransactionListRequest(accountHolderCode: "LiableAccountHolderPluginDemoMirakl");
            var accountHolderTransactionListResponse = _fund.AccountHolderTransactionList(accountHolderTransactionListRequest);
            Assert.IsNotNull(accountHolderTransactionListResponse.PspReference);
            Assert.AreEqual("Success", accountHolderTransactionListResponse.ResultCode);
            Assert.AreEqual(3, accountHolderTransactionListResponse.AccountTransactionLists.Count);
        }
        /// <summary>
        ///  test /accountHolderBalance 
        /// </summary>
        [TestMethod]
        public void AccountHolderBalanceResponse()
        {
            var accountHolderBalanceRequest = new AccountHolderBalanceRequest(accountHolderCode: "LiableAccountHolderPluginDemoMirakl");
            var accountHolderBalanceResponse = _fund.AccountHolderBalance(accountHolderBalanceRequest);
            Assert.IsNotNull(accountHolderBalanceResponse.PspReference);
            Assert.AreEqual("112548519", accountHolderBalanceResponse.BalancePerAccount[0].AccountCode);
            Assert.AreEqual("128653506", accountHolderBalanceResponse.BalancePerAccount[1].AccountCode);
            Assert.AreEqual("162991090", accountHolderBalanceResponse.BalancePerAccount[2].AccountCode);
        }

        /// <summary>
        /// test /refundNotPaidOutTransfers
        /// </summary>
        [TestMethod]
        public void TestRefundNotPaidOutTransfersSuccess()
        {
            var refundNotPaidOutTransfersRequest = new RefundNotPaidOutTransfersRequest(accountCode: "112548519", accountHolderCode: "LiableAccountHolderPluginDemoMirakl");
            var refundNotPaidOutTransfersResponse = _fund.RefundNotPaidOutTransfers(refundNotPaidOutTransfersRequest);
            Assert.IsNotNull(refundNotPaidOutTransfersResponse.PspReference);
            Assert.AreEqual("Received", refundNotPaidOutTransfersResponse.ResultCode);
        }

        /// <summary>
        /// test /transferFunds
        /// Account holder 138423083 has beneficiary setup. Fund transfer is not allowed. it can 
        /// </summary>
        public void TestTransferFundsSuccess()
        {
            var amount = new Amount("EUR", 1000);
            var transferFundsRequest = new TransferFundsRequest(amount: amount, destinationAccountCode: "112548519", merchantReference: "merchantReference", sourceAccountCode: "138423083", transferCode: "SUBSCRIPTION");
            var transferFundsResponse = _fund.TransferFunds(transferFundsRequest);
            Assert.IsNotNull( transferFundsResponse.PspReference);
            Assert.AreEqual("merchantReference", transferFundsResponse.MerchantReference);
            Assert.AreEqual("Received", transferFundsResponse.ResultCode);
        }
        
        /// <summary>
        /// test /setup beneficiary
        /// it can be done only once
        /// </summary>
        public void TestSetupBeneficiary()
        {
            var setupBeneficiaryRequest = new SetupBeneficiaryRequest(destinationAccountCode: "128653506", merchantReference: "LiableAccountHolderPluginDemoMirakl", sourceAccountCode: "138423083");
            var setupBeneficiaryResponse = _fund.SetupBeneficiary(setupBeneficiaryRequest);
            Assert.IsNotNull(setupBeneficiaryResponse.PspReference);
            Assert.AreEqual("Received", setupBeneficiaryResponse.ResultCode);
        }

        /// <summary>
        /// test /payoutAccountHolder
        /// </summary>
        [TestMethod]
        public void TestPayoutAccountHolderSuccess()
        {
            var amount = new Amount("EUR", 5700);
            var payoutAccountHolderRequest = new PayoutAccountHolderRequest(
                accountCode: "128653506", accountHolderCode: "LiableAccountHolderPluginDemoMirakl", amount: amount);
            var payoutAccountHolderResponse = _fund.PayoutAccountHolder(payoutAccountHolderRequest);
            Assert.IsNotNull(payoutAccountHolderResponse.PspReference);
            Assert.AreEqual("Received", payoutAccountHolderResponse.ResultCode);
        }

        /// <summary>
        /// test /refundFundsTransfer
        /// </summary>
        [TestMethod]
        public void TestRefundFundsTransferSuccess()
        {
            var amount = new Amount("EUR", 5700);
            var refundFundsTransferRequest = new RefundFundsTransferRequest(
              originalReference:"reference", amount: amount);
            var payoutAccountHolderResponse = _fund.RefundFundsTransfer(refundFundsTransferRequest);
            Assert.IsNotNull(payoutAccountHolderResponse.PspReference);
            Assert.AreEqual("Received", payoutAccountHolderResponse.ResultCode);
        }
    }
}
