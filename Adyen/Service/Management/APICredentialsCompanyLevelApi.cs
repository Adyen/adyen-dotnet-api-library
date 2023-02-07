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
    public class APICredentialsCompanyLevelApi : AbstractService
    {
        public APICredentialsCompanyLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListCompanyApiCredentialsResponse</returns>
        public ListCompanyApiCredentialsResponse ListApiCredentials(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListApiCredentialsAsync(companyId, pageNumber, pageSize, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListCompanyApiCredentialsResponse</returns>
        public async Task<ListCompanyApiCredentialsResponse> ListApiCredentialsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = $"/companies/{companyId}/apiCredentials" + ToQueryString(queryParams);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListCompanyApiCredentialsResponse>(jsonResult);
        }

        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CompanyApiCredential</returns>
        public CompanyApiCredential GetApiCredential(string companyId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            return GetApiCredentialAsync(companyId, apiCredentialId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CompanyApiCredential</returns>
        public async Task<CompanyApiCredential> GetApiCredentialAsync(string companyId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials/{apiCredentialId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<CompanyApiCredential>(jsonResult);
        }

        /// <summary>
        /// Update an API credential.
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="updateCompanyApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CompanyApiCredential</returns>
        public CompanyApiCredential UpdateApiCredential(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, RequestOptions requestOptions = default)
        {
            return UpdateApiCredentialAsync(companyId, apiCredentialId, updateCompanyApiCredentialRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an API credential.
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="updateCompanyApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CompanyApiCredential</returns>
        public async Task<CompanyApiCredential> UpdateApiCredentialAsync(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials/{apiCredentialId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updateCompanyApiCredentialRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<CompanyApiCredential>(jsonResult);
        }

        /// <summary>
        /// Create an API credential.
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="createCompanyApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CreateCompanyApiCredentialResponse</returns>
        public CreateCompanyApiCredentialResponse CreateApiCredential(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, RequestOptions requestOptions = default)
        {
            return CreateApiCredentialAsync(companyId, createCompanyApiCredentialRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an API credential.
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="createCompanyApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CreateCompanyApiCredentialResponse</returns>
        public async Task<CreateCompanyApiCredentialResponse> CreateApiCredentialAsync(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(createCompanyApiCredentialRequest.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<CreateCompanyApiCredentialResponse>(jsonResult);
        }

    }
}
