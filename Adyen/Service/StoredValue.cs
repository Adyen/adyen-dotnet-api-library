using System;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model.StoredValue;

namespace Adyen.Service
{
    public class StoredValue : AbstractService
    {
        private readonly string _baseUrl;
        private readonly ServiceResource _issue;
        private readonly ServiceResource _changeStatus;
        private readonly ServiceResource _load;
        private readonly ServiceResource _checkBalance;
        private readonly ServiceResource _mergeBalance;
        private readonly ServiceResource _voidTransaction;
        
        public StoredValue(Client client) :  base(client)
        {
            _baseUrl = client.Config.StoredValueEndpoint + "/" + Constants.ClientConfig.StoredValueVersion;
            _issue = new ServiceResource(this, _baseUrl + "/issue");
            _changeStatus = new ServiceResource(this, _baseUrl + "/changeStatus");
            _load = new ServiceResource(this, _baseUrl + "/load");
            _checkBalance = new ServiceResource(this, _baseUrl + "/checkBalance");
            _mergeBalance = new ServiceResource(this, _baseUrl + "/mergeBalance");
            _voidTransaction = new ServiceResource(this, _baseUrl + "/voidTransaction");
        }

        /// <summary>
        /// Post /issue API call
        /// </summary>
        /// <param name="storedValueIssueRequest"></param>
        /// <returns>StoredValueIssueResponse</returns>
        public async Task<StoredValueIssueResponse> IssueAsync(StoredValueIssueRequest storedValueIssueRequest)
        {
            var jsonRequest = storedValueIssueRequest.ToJson();
            return await _issue.RequestAsync<StoredValueIssueResponse>(jsonRequest);
        }

        /// <summary>
        /// Post /issue API call
        /// </summary>
        /// <param name="storedValueIssueRequest"></param>
        /// <returns>StoredValueIssueResponse</returns>
        public StoredValueIssueResponse Issue(StoredValueIssueRequest storedValueIssueRequest)
        {
            return IssueAsync(storedValueIssueRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /changeStatus API call
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"></param>
        /// <returns>StoredValueStatusChangeResponse</returns>
        public async Task<StoredValueStatusChangeResponse> ChangeStatusAsync(StoredValueStatusChangeRequest storedValueStatusChangeRequest)
        {
            var jsonRequest = storedValueStatusChangeRequest.ToJson();
            return await _changeStatus.RequestAsync<StoredValueStatusChangeResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /changeStatus API call
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"></param>
        /// <returns>StoredValueStatusChangeResponse</returns>
        public StoredValueStatusChangeResponse ChangeStatus(StoredValueStatusChangeRequest storedValueStatusChangeRequest)
        {
            return ChangeStatusAsync(storedValueStatusChangeRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /load API call
        /// </summary>
        /// <param name="storedValueLoadRequest"></param>
        /// <returns>StoredValueLoadResponse</returns>
        public async Task<StoredValueLoadResponse> LoadAsync(StoredValueLoadRequest storedValueLoadRequest)
        {
            var jsonRequest = storedValueLoadRequest.ToJson();
            return await _load.RequestAsync<StoredValueLoadResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /load API call
        /// </summary>
        /// <param name="storedValueLoadRequest"></param>
        /// <returns>StoredValueLoadResponse</returns>
        public StoredValueLoadResponse Load(StoredValueLoadRequest storedValueLoadRequest)
        {
            return LoadAsync(storedValueLoadRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /checkBalance API call
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"></param>
        /// <returns>StoredValueBalanceCheckResponse</returns>
        public async Task<StoredValueBalanceCheckResponse> CheckBalanceAsync(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest)
        {
            var jsonRequest = storedValueBalanceCheckRequest.ToJson();
            return await _checkBalance.RequestAsync<StoredValueBalanceCheckResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /checkBalance API call
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"></param>
        /// <returns>StoredValueBalanceCheckResponse</returns>
        public StoredValueBalanceCheckResponse CheckBalance(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest)
        {
            return CheckBalanceAsync(storedValueBalanceCheckRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /mergeBalance API call
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"></param>
        /// <returns>StoredValueBalanceMergeResponse</returns>
        public async Task<StoredValueBalanceMergeResponse> MergeBalanceAsync(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest)
        {
            var jsonRequest = storedValueBalanceMergeRequest.ToJson();
            return await _mergeBalance.RequestAsync<StoredValueBalanceMergeResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /mergeBalance API call
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"></param>
        /// <returns>StoredValueBalanceMergeResponse</returns>
        public StoredValueBalanceMergeResponse MergeBalance(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest)
        {
            return MergeBalanceAsync(storedValueBalanceMergeRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post /voidTransaction API call
        /// </summary>
        /// <param name="storedValueVoidRequest"></param>
        /// <returns>StoredValueVoidResponse</returns>
        public async Task<StoredValueVoidResponse> VoidTransactionAsync(StoredValueVoidRequest storedValueVoidRequest)
        {
            var jsonRequest = storedValueVoidRequest.ToJson();
            return await _voidTransaction.RequestAsync<StoredValueVoidResponse>(jsonRequest);
        }
        
        /// <summary>
        /// Post /voidTransaction API call
        /// </summary>
        /// <param name="storedValueVoidRequest"></param>
        /// <returns>StoredValueVoidResponse</returns>
        public StoredValueVoidResponse VoidTransaction(StoredValueVoidRequest storedValueVoidRequest)
        {
            return VoidTransactionAsync(storedValueVoidRequest).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}