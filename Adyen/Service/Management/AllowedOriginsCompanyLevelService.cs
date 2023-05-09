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
    /// AllowedOriginsCompanyLevelService Interface
    /// </summary>
    public interface IAllowedOriginsCompanyLevelService
    {
        /// <summary>
        /// Delete an allowed origin
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void DeleteAllowedOrigin(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Delete an allowed origin
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task DeleteAllowedOriginAsync(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of allowed origins
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOriginsResponse"/>.</returns>
        AllowedOriginsResponse ListAllowedOrigins(string companyId, string apiCredentialId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of allowed origins
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOriginsResponse"/>.</returns>
        Task<AllowedOriginsResponse> ListAllowedOriginsAsync(string companyId, string apiCredentialId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get an allowed origin
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOrigin"/>.</returns>
        AllowedOrigin GetAllowedOrigin(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get an allowed origin
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOrigin"/>.</returns>
        Task<AllowedOrigin> GetAllowedOriginAsync(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create an allowed origin
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="allowedOrigin"><see cref="AllowedOrigin"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOriginsResponse"/>.</returns>
        AllowedOriginsResponse CreateAllowedOrigin(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create an allowed origin
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="allowedOrigin"><see cref="AllowedOrigin"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOriginsResponse"/>.</returns>
        Task<AllowedOriginsResponse> CreateAllowedOriginAsync(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the AllowedOriginsCompanyLevelService API endpoints
    /// </summary>
    public class AllowedOriginsCompanyLevelService : AbstractService, IAllowedOriginsCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public AllowedOriginsCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public void DeleteAllowedOrigin(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default)
        {
            DeleteAllowedOriginAsync(companyId, apiCredentialId, originId, requestOptions).GetAwaiter().GetResult();
        }

        public async Task DeleteAllowedOriginAsync(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken);
        }
        
        public AllowedOriginsResponse ListAllowedOrigins(string companyId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            return ListAllowedOriginsAsync(companyId, apiCredentialId, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<AllowedOriginsResponse> ListAllowedOriginsAsync(string companyId, string apiCredentialId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AllowedOriginsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public AllowedOrigin GetAllowedOrigin(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default)
        {
            return GetAllowedOriginAsync(companyId, apiCredentialId, originId, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<AllowedOrigin> GetAllowedOriginAsync(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AllowedOrigin>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public AllowedOriginsResponse CreateAllowedOrigin(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = default)
        {
            return CreateAllowedOriginAsync(companyId, apiCredentialId, allowedOrigin, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<AllowedOriginsResponse> CreateAllowedOriginAsync(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AllowedOriginsResponse>(allowedOrigin.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }
    }
}