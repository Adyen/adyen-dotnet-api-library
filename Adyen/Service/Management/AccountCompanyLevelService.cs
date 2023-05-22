/*
* Management API
*
*
* The version of the OpenAPI document: 1
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
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// AccountCompanyLevelService Interface
    /// </summary>
    public interface IAccountCompanyLevelService
    {
        /// <summary>
        /// Get a company account
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Company"/>.</returns>
        Company GetCompanyAccount(string companyId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a company account
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Company"/>.</returns>
        Task<Company> GetCompanyAccountAsync(string companyId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of company accounts
        /// </summary>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListCompanyResponse"/>.</returns>
        ListCompanyResponse ListCompanyAccounts(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of company accounts
        /// </summary>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListCompanyResponse"/>.</returns>
        Task<ListCompanyResponse> ListCompanyAccountsAsync(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of merchant accounts
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListMerchantResponse"/>.</returns>
        ListMerchantResponse ListMerchantAccounts(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of merchant accounts
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListMerchantResponse"/>.</returns>
        Task<ListMerchantResponse> ListMerchantAccountsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the AccountCompanyLevelService API endpoints
    /// </summary>
    public class AccountCompanyLevelService : AbstractService, IAccountCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public AccountCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Company GetCompanyAccount(string companyId, RequestOptions requestOptions = default)
        {
            return GetCompanyAccountAsync(companyId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Company> GetCompanyAccountAsync(string companyId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Company>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public ListCompanyResponse ListCompanyAccounts(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListCompanyAccountsAsync(pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListCompanyResponse> ListCompanyAccountsAsync(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + "/companies" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListCompanyResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public ListMerchantResponse ListMerchantAccounts(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListMerchantAccountsAsync(companyId, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListMerchantResponse> ListMerchantAccountsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/companies/{companyId}/merchants" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListMerchantResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
    }
}