/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Transfers;

namespace Adyen.Service.Transfers
{
    /// <summary>
    /// TransactionsService Interface
    /// </summary>
    public interface ITransactionsService
    {
        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <param name="balancePlatform"><see cref="string"/> - The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60;.</param>
        /// <param name="paymentInstrumentId"><see cref="string"/> - The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).  To use this parameter, you must also provide a &#x60;balanceAccountId&#x60;, &#x60;accountHolderId&#x60;, or &#x60;balancePlatform&#x60;.  The &#x60;paymentInstrumentId&#x60; must be related to the &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60; that you provide.</param>
        /// <param name="accountHolderId"><see cref="string"/> - The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;balancePlatform&#x60;.  If you provide a &#x60;balanceAccountId&#x60;, the &#x60;accountHolderId&#x60; must be related to the &#x60;balanceAccountId&#x60;.</param>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).  Required if you don&#39;t provide an &#x60;accountHolderId&#x60; or &#x60;balancePlatform&#x60;.  If you provide an &#x60;accountHolderId&#x60;, the &#x60;balanceAccountId&#x60; must be related to the &#x60;accountHolderId&#x60;.</param>
        /// <param name="cursor"><see cref="string"/> - The &#x60;cursor&#x60; returned in the links of the previous response.</param>
        /// <param name="createdSince"><see cref="DateTime"/> - Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**.</param>
        /// <param name="createdUntil"><see cref="DateTime"/> - Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TransactionSearchResponse"/>.</returns>
        Model.Transfers.TransactionSearchResponse GetAllTransactions(DateTime createdSince, DateTime createdUntil, string balancePlatform = default, string paymentInstrumentId = default, string accountHolderId = default, string balanceAccountId = default, string cursor = default, int? limit = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <param name="balancePlatform"><see cref="string"/> - The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60;.</param>
        /// <param name="paymentInstrumentId"><see cref="string"/> - The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).  To use this parameter, you must also provide a &#x60;balanceAccountId&#x60;, &#x60;accountHolderId&#x60;, or &#x60;balancePlatform&#x60;.  The &#x60;paymentInstrumentId&#x60; must be related to the &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60; that you provide.</param>
        /// <param name="accountHolderId"><see cref="string"/> - The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;balancePlatform&#x60;.  If you provide a &#x60;balanceAccountId&#x60;, the &#x60;accountHolderId&#x60; must be related to the &#x60;balanceAccountId&#x60;.</param>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).  Required if you don&#39;t provide an &#x60;accountHolderId&#x60; or &#x60;balancePlatform&#x60;.  If you provide an &#x60;accountHolderId&#x60;, the &#x60;balanceAccountId&#x60; must be related to the &#x60;accountHolderId&#x60;.</param>
        /// <param name="cursor"><see cref="string"/> - The &#x60;cursor&#x60; returned in the links of the previous response.</param>
        /// <param name="createdSince"><see cref="DateTime"/> - Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**.</param>
        /// <param name="createdUntil"><see cref="DateTime"/> - Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TransactionSearchResponse"/>.</returns>
        Task<Model.Transfers.TransactionSearchResponse> GetAllTransactionsAsync(DateTime createdSince, DateTime createdUntil, string balancePlatform = default, string paymentInstrumentId = default, string accountHolderId = default, string balanceAccountId = default, string cursor = default, int? limit = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a transaction
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the transaction.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Transaction"/>.</returns>
        Model.Transfers.Transaction GetTransaction(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a transaction
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the transaction.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Transaction"/>.</returns>
        Task<Model.Transfers.Transaction> GetTransactionAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TransactionsService API endpoints
    /// </summary>
    public class TransactionsService : AbstractService, ITransactionsService
    {
        private readonly string _baseUrl;
        
        public TransactionsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/btl/v4");
        }
        
        public Model.Transfers.TransactionSearchResponse GetAllTransactions(DateTime createdSince, DateTime createdUntil, string balancePlatform = default, string paymentInstrumentId = default, string accountHolderId = default, string balanceAccountId = default, string cursor = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return GetAllTransactionsAsync(createdSince, createdUntil, balancePlatform, paymentInstrumentId, accountHolderId, balanceAccountId, cursor, limit, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Transfers.TransactionSearchResponse> GetAllTransactionsAsync(DateTime createdSince, DateTime createdUntil, string balancePlatform = default, string paymentInstrumentId = default, string accountHolderId = default, string balanceAccountId = default, string cursor = default, int? limit = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (balancePlatform != null) queryParams.Add("balancePlatform", balancePlatform);
            if (paymentInstrumentId != null) queryParams.Add("paymentInstrumentId", paymentInstrumentId);
            if (accountHolderId != null) queryParams.Add("accountHolderId", accountHolderId);
            if (balanceAccountId != null) queryParams.Add("balanceAccountId", balanceAccountId);
            if (cursor != null) queryParams.Add("cursor", cursor);
            queryParams.Add("createdSince", createdSince.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            queryParams.Add("createdUntil", createdUntil.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = _baseUrl + "/transactions" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Transfers.TransactionSearchResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Transfers.Transaction GetTransaction(string id, RequestOptions requestOptions = default)
        {
            return GetTransactionAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Transfers.Transaction> GetTransactionAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/transactions/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Transfers.Transaction>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
    }
}