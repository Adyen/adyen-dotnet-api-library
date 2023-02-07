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
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountCompanyLevelApi : AbstractService
    {
        public AccountCompanyLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of company accounts
        /// </summary>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListCompanyResponse</returns>
        public ListCompanyResponse ListCompanyAccounts(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListCompanyAccountsAsync(pageNumber, pageSize, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of company accounts
        /// </summary>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListCompanyResponse</returns>
        public async Task<ListCompanyResponse> ListCompanyAccountsAsync(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = "/companies" + ToQueryString(queryParams);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListCompanyResponse>(jsonResult);
        }

        /// <summary>
        /// Get a company account
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Company</returns>
        public Company GetCompanyAccount(string companyId, RequestOptions requestOptions = default)
        {
            return GetCompanyAccountAsync(companyId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a company account
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Company</returns>
        public async Task<Company> GetCompanyAccountAsync(string companyId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Company>(jsonResult);
        }

        /// <summary>
        /// Get a list of merchant accounts
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListMerchantResponse</returns>
        public ListMerchantResponse ListMerchantAccounts(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListMerchantAccountsAsync(companyId, pageNumber, pageSize, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of merchant accounts
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListMerchantResponse</returns>
        public async Task<ListMerchantResponse> ListMerchantAccountsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = $"/companies/{companyId}/merchants" + ToQueryString(queryParams);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListMerchantResponse>(jsonResult);
        }

    }
}
