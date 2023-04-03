using Adyen.Model.MarketPay;
using Adyen.Service.Resource.Fund;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class Fund : AbstractService
    {
        private readonly AccountHolderBalance _accountHolderBalance;
        private readonly AccountHolderTransactionList _accountHolderTransactionList;
        private readonly PayoutAccountHolder _payoutAccountHolder;
        private readonly TransferFunds _transferFunds;
        private readonly RefundFundsTransfer _refundFundsTransfer;
        private readonly SetupBeneficiary _setupBeneficiary;
        private readonly RefundNotPaidOutTransfers _refundNotPaidOutTransfers;

        public Fund(Client client)
            : base(client)
        {
            _accountHolderBalance = new AccountHolderBalance(this);
            _accountHolderTransactionList = new AccountHolderTransactionList(this);
            _transferFunds = new TransferFunds(this);
            _refundFundsTransfer = new RefundFundsTransfer(this);
            _setupBeneficiary = new SetupBeneficiary(this);
            _refundNotPaidOutTransfers = new RefundNotPaidOutTransfers(this);
            _payoutAccountHolder = new PayoutAccountHolder(this);
        }

        /// <summary>
        /// Post /accountHolderBalance API call
        /// </summary>
        /// <param name="accountHolderBalanceRequest"></param>
        /// <returns>AccountHolderBalanceResponse</returns>
        /// 
        public AccountHolderBalanceResponse AccountHolderBalance(
            AccountHolderBalanceRequest accountHolderBalanceRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(accountHolderBalanceRequest);
            var jsonResponse = _accountHolderBalance.Request(jsonRequest);
            return JsonConvert.DeserializeObject<AccountHolderBalanceResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /accountHolderTransactionList API call
        /// </summary>
        /// <param name="accountHolderTransactionListRequest"></param>
        /// <returns>AccountHolderTransactionListResponse</returns>
        /// 
        public AccountHolderTransactionListResponse AccountHolderTransactionList(
            AccountHolderTransactionListRequest accountHolderTransactionListRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(accountHolderTransactionListRequest);
            string jsonResponse = _accountHolderTransactionList.Request(jsonRequest);
            return JsonConvert.DeserializeObject<AccountHolderTransactionListResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /transferFunds API call
        /// </summary>
        /// <param name="transferFundsRequest"></param>
        /// <returns>TransferFundsResponse</returns>
        /// 
        public TransferFundsResponse TransferFunds(TransferFundsRequest transferFundsRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(transferFundsRequest);
            string jsonResponse = _transferFunds.Request(jsonRequest);
            return JsonConvert.DeserializeObject<TransferFundsResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /refundFundsTransfer API call
        /// </summary>
        /// <param name="refundFundsTransferRequest"></param>
        /// <returns>RefundFundsTransferResponse</returns>
        /// 
        public RefundFundsTransferResponse RefundFundsTransfer(RefundFundsTransferRequest refundFundsTransferRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(refundFundsTransferRequest);
            string jsonResponse = _refundFundsTransfer.Request(jsonRequest);
            return JsonConvert.DeserializeObject<RefundFundsTransferResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /setupBeneficiary API call
        /// </summary>
        /// <param name="setupBeneficiaryRequest"></param>
        /// <returns>SetupBeneficiaryResponse</returns>
        /// 
        public SetupBeneficiaryResponse SetupBeneficiary(SetupBeneficiaryRequest setupBeneficiaryRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(setupBeneficiaryRequest);
            string jsonResponse = _setupBeneficiary.Request(jsonRequest);
            return JsonConvert.DeserializeObject<SetupBeneficiaryResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /refundNotPaidOutTransfers API call
        /// </summary>
        /// <param name="refundNotPaidOutTransfersRequest"></param>
        /// <returns>RefundNotPaidOutTransfersResponse</returns>
        /// 
        public RefundNotPaidOutTransfersResponse RefundNotPaidOutTransfers(
            RefundNotPaidOutTransfersRequest refundNotPaidOutTransfersRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(refundNotPaidOutTransfersRequest);
            string jsonResponse = _refundNotPaidOutTransfers.Request(jsonRequest);
            return JsonConvert.DeserializeObject<RefundNotPaidOutTransfersResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /payoutAccountHolder API call
        /// </summary>
        /// <param name="payoutAccountHolderRequest"></param>
        /// <returns>PayoutAccountHolderResponse</returns>
        /// 
        public PayoutAccountHolderResponse PayoutAccountHolder(PayoutAccountHolderRequest payoutAccountHolderRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(payoutAccountHolderRequest);
            string jsonResponse = _payoutAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PayoutAccountHolderResponse>(jsonResponse);
        }
    }
}