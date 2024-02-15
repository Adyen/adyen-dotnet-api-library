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
    /// CapitalService Interface
    /// </summary>
    public interface ICapitalService
    {
        /// <summary>
        /// Get a capital account
        /// </summary>
        /// <param name="counterpartyAccountHolderId"><see cref="string"/> - The counterparty account holder id.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CapitalGrants"/>.</returns>
        Model.Transfers.CapitalGrants GetCapitalAccount(string counterpartyAccountHolderId = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a capital account
        /// </summary>
        /// <param name="counterpartyAccountHolderId"><see cref="string"/> - The counterparty account holder id.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CapitalGrants"/>.</returns>
        Task<Model.Transfers.CapitalGrants> GetCapitalAccountAsync(string counterpartyAccountHolderId = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get grant reference details
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the grant.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CapitalGrant"/>.</returns>
        Model.Transfers.CapitalGrant GetGrantReferenceDetails(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get grant reference details
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the grant.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CapitalGrant"/>.</returns>
        Task<Model.Transfers.CapitalGrant> GetGrantReferenceDetailsAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Request a grant payout
        /// </summary>
        /// <param name="capitalGrantInfo"><see cref="CapitalGrantInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CapitalGrant"/>.</returns>
        Model.Transfers.CapitalGrant RequestGrantPayout(CapitalGrantInfo capitalGrantInfo = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Request a grant payout
        /// </summary>
        /// <param name="capitalGrantInfo"><see cref="CapitalGrantInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CapitalGrant"/>.</returns>
        Task<Model.Transfers.CapitalGrant> RequestGrantPayoutAsync(CapitalGrantInfo capitalGrantInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the CapitalService API endpoints
    /// </summary>
    public class CapitalService : AbstractService, ICapitalService
    {
        private readonly string _baseUrl;
        
        public CapitalService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/btl/v4");
        }
        
        public Model.Transfers.CapitalGrants GetCapitalAccount(string counterpartyAccountHolderId = default, RequestOptions requestOptions = default)
        {
            return GetCapitalAccountAsync(counterpartyAccountHolderId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Transfers.CapitalGrants> GetCapitalAccountAsync(string counterpartyAccountHolderId = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (counterpartyAccountHolderId != null) queryParams.Add("counterpartyAccountHolderId", counterpartyAccountHolderId);
            var endpoint = _baseUrl + "/grants" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Transfers.CapitalGrants>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Transfers.CapitalGrant GetGrantReferenceDetails(string id, RequestOptions requestOptions = default)
        {
            return GetGrantReferenceDetailsAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Transfers.CapitalGrant> GetGrantReferenceDetailsAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/grants/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Transfers.CapitalGrant>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Transfers.CapitalGrant RequestGrantPayout(CapitalGrantInfo capitalGrantInfo = default, RequestOptions requestOptions = default)
        {
            return RequestGrantPayoutAsync(capitalGrantInfo, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Transfers.CapitalGrant> RequestGrantPayoutAsync(CapitalGrantInfo capitalGrantInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/grants";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Transfers.CapitalGrant>(capitalGrantInfo.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}
