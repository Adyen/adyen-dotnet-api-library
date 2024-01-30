/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// BalanceAccountsService Interface
    /// </summary>
    public interface IBalanceAccountsService
    {
        /// <summary>
        /// Delete a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="sweepId"><see cref="string"/> - The unique identifier of the sweep.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void DeleteSweep(string balanceAccountId, string sweepId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Delete a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="sweepId"><see cref="string"/> - The unique identifier of the sweep.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task DeleteSweepAsync(string balanceAccountId, string sweepId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get all sweeps for a balance account
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="offset"><see cref="int?"/> - The number of items that you want to skip.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="BalanceSweepConfigurationsResponse"/>.</returns>
        Model.BalancePlatform.BalanceSweepConfigurationsResponse GetAllSweepsForBalanceAccount(string balanceAccountId, int? offset = default, int? limit = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get all sweeps for a balance account
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="offset"><see cref="int?"/> - The number of items that you want to skip.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="BalanceSweepConfigurationsResponse"/>.</returns>
        Task<Model.BalancePlatform.BalanceSweepConfigurationsResponse> GetAllSweepsForBalanceAccountAsync(string balanceAccountId, int? offset = default, int? limit = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="sweepId"><see cref="string"/> - The unique identifier of the sweep.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="SweepConfigurationV2"/>.</returns>
        Model.BalancePlatform.SweepConfigurationV2 GetSweep(string balanceAccountId, string sweepId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="sweepId"><see cref="string"/> - The unique identifier of the sweep.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="SweepConfigurationV2"/>.</returns>
        Task<Model.BalancePlatform.SweepConfigurationV2> GetSweepAsync(string balanceAccountId, string sweepId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a balance account
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="BalanceAccount"/>.</returns>
        Model.BalancePlatform.BalanceAccount GetBalanceAccount(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a balance account
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="BalanceAccount"/>.</returns>
        Task<Model.BalancePlatform.BalanceAccount> GetBalanceAccountAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get payment instruments linked to a balance account
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="offset"><see cref="int?"/> - The number of items that you want to skip.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="status"><see cref="string"/> - The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaginatedPaymentInstrumentsResponse"/>.</returns>
        Model.BalancePlatform.PaginatedPaymentInstrumentsResponse GetPaymentInstrumentsLinkedToBalanceAccount(string id, int? offset = default, int? limit = default, string status = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get payment instruments linked to a balance account
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="offset"><see cref="int?"/> - The number of items that you want to skip.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="status"><see cref="string"/> - The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaginatedPaymentInstrumentsResponse"/>.</returns>
        Task<Model.BalancePlatform.PaginatedPaymentInstrumentsResponse> GetPaymentInstrumentsLinkedToBalanceAccountAsync(string id, int? offset = default, int? limit = default, string status = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="sweepId"><see cref="string"/> - The unique identifier of the sweep.</param>
        /// <param name="updateSweepConfigurationV2"><see cref="UpdateSweepConfigurationV2"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="SweepConfigurationV2"/>.</returns>
        Model.BalancePlatform.SweepConfigurationV2 UpdateSweep(string balanceAccountId, string sweepId, UpdateSweepConfigurationV2 updateSweepConfigurationV2 = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="sweepId"><see cref="string"/> - The unique identifier of the sweep.</param>
        /// <param name="updateSweepConfigurationV2"><see cref="UpdateSweepConfigurationV2"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="SweepConfigurationV2"/>.</returns>
        Task<Model.BalancePlatform.SweepConfigurationV2> UpdateSweepAsync(string balanceAccountId, string sweepId, UpdateSweepConfigurationV2 updateSweepConfigurationV2 = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a balance account
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="balanceAccountUpdateRequest"><see cref="BalanceAccountUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="BalanceAccount"/>.</returns>
        Model.BalancePlatform.BalanceAccount UpdateBalanceAccount(string id, BalanceAccountUpdateRequest balanceAccountUpdateRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a balance account
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="balanceAccountUpdateRequest"><see cref="BalanceAccountUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="BalanceAccount"/>.</returns>
        Task<Model.BalancePlatform.BalanceAccount> UpdateBalanceAccountAsync(string id, BalanceAccountUpdateRequest balanceAccountUpdateRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a balance account
        /// </summary>
        /// <param name="balanceAccountInfo"><see cref="BalanceAccountInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="BalanceAccount"/>.</returns>
        Model.BalancePlatform.BalanceAccount CreateBalanceAccount(BalanceAccountInfo balanceAccountInfo = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a balance account
        /// </summary>
        /// <param name="balanceAccountInfo"><see cref="BalanceAccountInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="BalanceAccount"/>.</returns>
        Task<Model.BalancePlatform.BalanceAccount> CreateBalanceAccountAsync(BalanceAccountInfo balanceAccountInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="createSweepConfigurationV2"><see cref="CreateSweepConfigurationV2"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="SweepConfigurationV2"/>.</returns>
        Model.BalancePlatform.SweepConfigurationV2 CreateSweep(string balanceAccountId, CreateSweepConfigurationV2 createSweepConfigurationV2 = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a sweep
        /// </summary>
        /// <param name="balanceAccountId"><see cref="string"/> - The unique identifier of the balance account.</param>
        /// <param name="createSweepConfigurationV2"><see cref="CreateSweepConfigurationV2"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="SweepConfigurationV2"/>.</returns>
        Task<Model.BalancePlatform.SweepConfigurationV2> CreateSweepAsync(string balanceAccountId, CreateSweepConfigurationV2 createSweepConfigurationV2 = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the BalanceAccountsService API endpoints
    /// </summary>
    public class BalanceAccountsService : AbstractService, IBalanceAccountsService
    {
        private readonly string _baseUrl;
        
        public BalanceAccountsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/bcl/v2");
        }
        
        public void DeleteSweep(string balanceAccountId, string sweepId, RequestOptions requestOptions = default)
        {
            DeleteSweepAsync(balanceAccountId, sweepId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task DeleteSweepAsync(string balanceAccountId, string sweepId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.BalanceSweepConfigurationsResponse GetAllSweepsForBalanceAccount(string balanceAccountId, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return GetAllSweepsForBalanceAccountAsync(balanceAccountId, offset, limit, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.BalanceSweepConfigurationsResponse> GetAllSweepsForBalanceAccountAsync(string balanceAccountId, int? offset = default, int? limit = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = _baseUrl + $"/balanceAccounts/{balanceAccountId}/sweeps" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.BalanceSweepConfigurationsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.SweepConfigurationV2 GetSweep(string balanceAccountId, string sweepId, RequestOptions requestOptions = default)
        {
            return GetSweepAsync(balanceAccountId, sweepId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.SweepConfigurationV2> GetSweepAsync(string balanceAccountId, string sweepId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.SweepConfigurationV2>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.BalanceAccount GetBalanceAccount(string id, RequestOptions requestOptions = default)
        {
            return GetBalanceAccountAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.BalanceAccount> GetBalanceAccountAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balanceAccounts/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.BalanceAccount>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.PaginatedPaymentInstrumentsResponse GetPaymentInstrumentsLinkedToBalanceAccount(string id, int? offset = default, int? limit = default, string status = default, RequestOptions requestOptions = default)
        {
            return GetPaymentInstrumentsLinkedToBalanceAccountAsync(id, offset, limit, status, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.PaginatedPaymentInstrumentsResponse> GetPaymentInstrumentsLinkedToBalanceAccountAsync(string id, int? offset = default, int? limit = default, string status = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            if (status != null) queryParams.Add("status", status);
            var endpoint = _baseUrl + $"/balanceAccounts/{id}/paymentInstruments" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.PaginatedPaymentInstrumentsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.SweepConfigurationV2 UpdateSweep(string balanceAccountId, string sweepId, UpdateSweepConfigurationV2 updateSweepConfigurationV2 = default, RequestOptions requestOptions = default)
        {
            return UpdateSweepAsync(balanceAccountId, sweepId, updateSweepConfigurationV2, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.SweepConfigurationV2> UpdateSweepAsync(string balanceAccountId, string sweepId, UpdateSweepConfigurationV2 updateSweepConfigurationV2 = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.SweepConfigurationV2>(updateSweepConfigurationV2.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.BalanceAccount UpdateBalanceAccount(string id, BalanceAccountUpdateRequest balanceAccountUpdateRequest = default, RequestOptions requestOptions = default)
        {
            return UpdateBalanceAccountAsync(id, balanceAccountUpdateRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.BalanceAccount> UpdateBalanceAccountAsync(string id, BalanceAccountUpdateRequest balanceAccountUpdateRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balanceAccounts/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.BalanceAccount>(balanceAccountUpdateRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.BalanceAccount CreateBalanceAccount(BalanceAccountInfo balanceAccountInfo = default, RequestOptions requestOptions = default)
        {
            return CreateBalanceAccountAsync(balanceAccountInfo, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.BalanceAccount> CreateBalanceAccountAsync(BalanceAccountInfo balanceAccountInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/balanceAccounts";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.BalanceAccount>(balanceAccountInfo.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.SweepConfigurationV2 CreateSweep(string balanceAccountId, CreateSweepConfigurationV2 createSweepConfigurationV2 = default, RequestOptions requestOptions = default)
        {
            return CreateSweepAsync(balanceAccountId, createSweepConfigurationV2, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.SweepConfigurationV2> CreateSweepAsync(string balanceAccountId, CreateSweepConfigurationV2 createSweepConfigurationV2 = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balanceAccounts/{balanceAccountId}/sweeps";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.SweepConfigurationV2>(createSweepConfigurationV2.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}