using System;
using System.Threading.Tasks;
using Adyen.Model.StoredValue;

namespace Adyen.Service
{
    public class StoredValue : AbstractService
    {
        private readonly ServiceResource _issue;
        private readonly ServiceResource _changeStatus;
        private readonly ServiceResource _load;
        private readonly ServiceResource _checkBalance;
        private readonly ServiceResource _mergeBalance;
        private readonly ServiceResource _voidTransaction;
        
        public StoredValue(Client client) :  base(client)
        {
            var baseUrl = client.Config.StoredValueEndpoint + "/" + Constants.ClientConfig.StoredValueVersion;
            _issue = new ServiceResource(this, baseUrl + "/issue", null);
            _changeStatus = new ServiceResource(this, baseUrl + "/changeStatus", null);
            _load = new ServiceResource(this, baseUrl + "/load", null);
            _checkBalance = new ServiceResource(this, baseUrl + "/checkBalance", null);
            _mergeBalance = new ServiceResource(this, baseUrl + "/mergeBalance", null);
            _voidTransaction = new ServiceResource(this, baseUrl + "/voidTransaction", null);
        }

        /// <summary>
        /// Post /issue API call
        /// </summary>
        /// <param name="storedValueIssueRequest"></param>
        /// <returns>StoredValueIssueResponse</returns>
        public async Task<StoredValueIssueResponse> Issue(StoredValueIssueRequest storedValueIssueRequest)
        {
            var jsonRequest = storedValueIssueRequest.ToJson();
            return await _issue.RequestAsync<StoredValueIssueResponse>(jsonRequest);
        }

        /// <summary>
        /// Post /issue API call
        /// </summary>
        /// <param name="storedValueIssueRequest"></param>
        /// <returns>StoredValueIssueResponse</returns>
        public StoredValueIssueResponse IssueSync(StoredValueIssueRequest storedValueIssueRequest)
        {
            return Issue(storedValueIssueRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /changeStatus API call
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"></param>
        /// <returns>StoredValueStatusChangeResponse</returns>
        public async Task<StoredValueStatusChangeResponse> ChangeStatus(StoredValueStatusChangeRequest storedValueStatusChangeRequest)
        {
            var jsonRequest = storedValueStatusChangeRequest.ToJson();
            return await _changeStatus.RequestAsync<StoredValueStatusChangeResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /changeStatus API call
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"></param>
        /// <returns>StoredValueStatusChangeResponse</returns>
        public StoredValueStatusChangeResponse ChangeStatusSync(StoredValueStatusChangeRequest storedValueStatusChangeRequest)
        {
            return ChangeStatus(storedValueStatusChangeRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /load API call
        /// </summary>
        /// <param name="storedValueLoadRequest"></param>
        /// <returns>StoredValueLoadResponse</returns>
        public async Task<StoredValueLoadResponse> Load(StoredValueLoadRequest storedValueLoadRequest)
        {
            var jsonRequest = storedValueLoadRequest.ToJson();
            return await _load.RequestAsync<StoredValueLoadResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /load API call
        /// </summary>
        /// <param name="storedValueLoadRequest"></param>
        /// <returns>StoredValueLoadResponse</returns>
        public StoredValueLoadResponse LoadSync(StoredValueLoadRequest storedValueLoadRequest)
        {
            return Load(storedValueLoadRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /checkBalance API call
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"></param>
        /// <returns>StoredValueBalanceCheckResponse</returns>
        public async Task<StoredValueBalanceCheckResponse> CheckBalance(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest)
        {
            var jsonRequest = storedValueBalanceCheckRequest.ToJson();
            return await _checkBalance.RequestAsync<StoredValueBalanceCheckResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /checkBalance API call
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"></param>
        /// <returns>StoredValueBalanceCheckResponse</returns>
        public StoredValueBalanceCheckResponse CheckBalanceSync(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest)
        {
            return CheckBalance(storedValueBalanceCheckRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /mergeBalance API call
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"></param>
        /// <returns>StoredValueBalanceMergeResponse</returns>
        public async Task<StoredValueBalanceMergeResponse> MergeBalance(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest)
        {
            var jsonRequest = storedValueBalanceMergeRequest.ToJson();
            return await _mergeBalance.RequestAsync<StoredValueBalanceMergeResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /mergeBalance API call
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"></param>
        /// <returns>StoredValueBalanceMergeResponse</returns>
        public StoredValueBalanceMergeResponse MergeBalanceSync(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest)
        {
            return MergeBalance(storedValueBalanceMergeRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /voidTransaction API call
        /// </summary>
        /// <param name="storedValueVoidRequest"></param>
        /// <returns>StoredValueVoidResponse</returns>
        public async Task<StoredValueVoidResponse> VoidTransaction(StoredValueVoidRequest storedValueVoidRequest)
        {
            var jsonRequest = storedValueVoidRequest.ToJson();
            return await _voidTransaction.RequestAsync<StoredValueVoidResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /voidTransaction API call
        /// </summary>
        /// <param name="storedValueVoidRequest"></param>
        /// <returns>StoredValueVoidResponse</returns>
        public StoredValueVoidResponse VoidTransactionSync(StoredValueVoidRequest storedValueVoidRequest)
        {
            return VoidTransaction(storedValueVoidRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}