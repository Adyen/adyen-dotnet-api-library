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
    /// APICredentialsCompanyLevelService Interface
    /// </summary>
    public interface IAPICredentialsCompanyLevelService
    {
        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListCompanyApiCredentialsResponse"/>.</returns>
        ListCompanyApiCredentialsResponse ListApiCredentials(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListCompanyApiCredentialsResponse"/>.</returns>
        Task<ListCompanyApiCredentialsResponse> ListApiCredentialsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CompanyApiCredential"/>.</returns>
        CompanyApiCredential GetApiCredential(string companyId, string apiCredentialId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CompanyApiCredential"/>.</returns>
        Task<CompanyApiCredential> GetApiCredentialAsync(string companyId, string apiCredentialId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update an API credential.
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="updateCompanyApiCredentialRequest"><see cref="UpdateCompanyApiCredentialRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CompanyApiCredential"/>.</returns>
        CompanyApiCredential UpdateApiCredential(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update an API credential.
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="updateCompanyApiCredentialRequest"><see cref="UpdateCompanyApiCredentialRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CompanyApiCredential"/>.</returns>
        Task<CompanyApiCredential> UpdateApiCredentialAsync(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create an API credential.
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="createCompanyApiCredentialRequest"><see cref="CreateCompanyApiCredentialRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreateCompanyApiCredentialResponse"/>.</returns>
        CreateCompanyApiCredentialResponse CreateApiCredential(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create an API credential.
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="createCompanyApiCredentialRequest"><see cref="CreateCompanyApiCredentialRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreateCompanyApiCredentialResponse"/>.</returns>
        Task<CreateCompanyApiCredentialResponse> CreateApiCredentialAsync(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the APICredentialsCompanyLevelService API endpoints
    /// </summary>
    public class APICredentialsCompanyLevelService : AbstractService, IAPICredentialsCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public APICredentialsCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public ListCompanyApiCredentialsResponse ListApiCredentials(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListApiCredentialsAsync(companyId, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListCompanyApiCredentialsResponse> ListApiCredentialsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListCompanyApiCredentialsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public CompanyApiCredential GetApiCredential(string companyId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            return GetApiCredentialAsync(companyId, apiCredentialId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CompanyApiCredential> GetApiCredentialAsync(string companyId, string apiCredentialId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials/{apiCredentialId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CompanyApiCredential>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public CompanyApiCredential UpdateApiCredential(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, RequestOptions requestOptions = default)
        {
            return UpdateApiCredentialAsync(companyId, apiCredentialId, updateCompanyApiCredentialRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CompanyApiCredential> UpdateApiCredentialAsync(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials/{apiCredentialId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CompanyApiCredential>(updateCompanyApiCredentialRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public CreateCompanyApiCredentialResponse CreateApiCredential(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, RequestOptions requestOptions = default)
        {
            return CreateApiCredentialAsync(companyId, createCompanyApiCredentialRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreateCompanyApiCredentialResponse> CreateApiCredentialAsync(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CreateCompanyApiCredentialResponse>(createCompanyApiCredentialRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}