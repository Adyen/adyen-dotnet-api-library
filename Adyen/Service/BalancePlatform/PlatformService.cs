/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
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
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// PlatformService Interface
    /// </summary>
    public interface IPlatformService
    {
        /// <summary>
        /// Get a balance platform
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance platform.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="BalancePlatform"/>.</returns>
        Model.BalancePlatform.BalancePlatform GetBalancePlatform(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a balance platform
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance platform.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="BalancePlatform"/>.</returns>
        Task<Model.BalancePlatform.BalancePlatform> GetBalancePlatformAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get all account holders under a balance platform
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance platform.</param>
        /// <param name="offset"><see cref="int?"/> - The number of items that you want to skip.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaginatedAccountHoldersResponse"/>.</returns>
        PaginatedAccountHoldersResponse GetAllAccountHoldersUnderBalancePlatform(string id, int? offset = default, int? limit = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get all account holders under a balance platform
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the balance platform.</param>
        /// <param name="offset"><see cref="int?"/> - The number of items that you want to skip.</param>
        /// <param name="limit"><see cref="int?"/> - The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaginatedAccountHoldersResponse"/>.</returns>
        Task<PaginatedAccountHoldersResponse> GetAllAccountHoldersUnderBalancePlatformAsync(string id, int? offset = default, int? limit = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PlatformService API endpoints
    /// </summary>
    public class PlatformService : AbstractService, IPlatformService
    {
        private readonly string _baseUrl;
        
        public PlatformService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/bcl/v2");
        }
        
        public Model.BalancePlatform.BalancePlatform GetBalancePlatform(string id, RequestOptions requestOptions = default)
        {
            return GetBalancePlatformAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.BalancePlatform> GetBalancePlatformAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/balancePlatforms/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.BalancePlatform>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public PaginatedAccountHoldersResponse GetAllAccountHoldersUnderBalancePlatform(string id, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return GetAllAccountHoldersUnderBalancePlatformAsync(id, offset, limit, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaginatedAccountHoldersResponse> GetAllAccountHoldersUnderBalancePlatformAsync(string id, int? offset = default, int? limit = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = _baseUrl + $"/balancePlatforms/{id}/accountHolders" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaginatedAccountHoldersResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
    }
}