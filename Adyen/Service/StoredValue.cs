using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.StoredValue;

namespace Adyen.Service
{
   /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoredValue : AbstractService
    {
        private readonly string _baseUrl;
        
        public StoredValue(Client client) : base(client)
        {
            _baseUrl = client.Config.StoredValueEndpoint + "/" + ClientConfig.StoredValueVersion;
        }
    
        /// <summary>
        /// Changes the status of the payment method.
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StoredValueStatusChangeResponse</returns>
        public StoredValueStatusChangeResponse ChangesStatusOfPaymentMethod(StoredValueStatusChangeRequest storedValueStatusChangeRequest, RequestOptions requestOptions = default)
        {
            return ChangesStatusOfPaymentMethodAsync(storedValueStatusChangeRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Changes the status of the payment method.
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of StoredValueStatusChangeResponse</returns>
        public async Task<StoredValueStatusChangeResponse> ChangesStatusOfPaymentMethodAsync(StoredValueStatusChangeRequest storedValueStatusChangeRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/changeStatus";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredValueStatusChangeResponse>(storedValueStatusChangeRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Checks the balance.
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StoredValueBalanceCheckResponse</returns>
        public StoredValueBalanceCheckResponse ChecksBalance(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest, RequestOptions requestOptions = default)
        {
            return ChecksBalanceAsync(storedValueBalanceCheckRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Checks the balance.
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of StoredValueBalanceCheckResponse</returns>
        public async Task<StoredValueBalanceCheckResponse> ChecksBalanceAsync(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/checkBalance";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredValueBalanceCheckResponse>(storedValueBalanceCheckRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Issues a new card.
        /// </summary>
        /// <param name="storedValueIssueRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StoredValueIssueResponse</returns>
        public StoredValueIssueResponse IssuesNewCard(StoredValueIssueRequest storedValueIssueRequest, RequestOptions requestOptions = default)
        {
            return IssuesNewCardAsync(storedValueIssueRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Issues a new card.
        /// </summary>
        /// <param name="storedValueIssueRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of StoredValueIssueResponse</returns>
        public async Task<StoredValueIssueResponse> IssuesNewCardAsync(StoredValueIssueRequest storedValueIssueRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/issue";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredValueIssueResponse>(storedValueIssueRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Loads the payment method.
        /// </summary>
        /// <param name="storedValueLoadRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StoredValueLoadResponse</returns>
        public StoredValueLoadResponse LoadsPaymentMethod(StoredValueLoadRequest storedValueLoadRequest, RequestOptions requestOptions = default)
        {
            return LoadsPaymentMethodAsync(storedValueLoadRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Loads the payment method.
        /// </summary>
        /// <param name="storedValueLoadRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of StoredValueLoadResponse</returns>
        public async Task<StoredValueLoadResponse> LoadsPaymentMethodAsync(StoredValueLoadRequest storedValueLoadRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/load";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredValueLoadResponse>(storedValueLoadRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Merge the balance of two cards.
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StoredValueBalanceMergeResponse</returns>
        public StoredValueBalanceMergeResponse MergeBalanceOfTwoCards(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest, RequestOptions requestOptions = default)
        {
            return MergeBalanceOfTwoCardsAsync(storedValueBalanceMergeRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Merge the balance of two cards.
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of StoredValueBalanceMergeResponse</returns>
        public async Task<StoredValueBalanceMergeResponse> MergeBalanceOfTwoCardsAsync(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/mergeBalance";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredValueBalanceMergeResponse>(storedValueBalanceMergeRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Voids a transaction.
        /// </summary>
        /// <param name="storedValueVoidRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StoredValueVoidResponse</returns>
        public StoredValueVoidResponse VoidsTransaction(StoredValueVoidRequest storedValueVoidRequest, RequestOptions requestOptions = default)
        {
            return VoidsTransactionAsync(storedValueVoidRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Voids a transaction.
        /// </summary>
        /// <param name="storedValueVoidRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of StoredValueVoidResponse</returns>
        public async Task<StoredValueVoidResponse> VoidsTransactionAsync(StoredValueVoidRequest storedValueVoidRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/voidTransaction";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredValueVoidResponse>(storedValueVoidRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }
    }
}