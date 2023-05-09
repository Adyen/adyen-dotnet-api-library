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
    /// MyAPICredentialService Interface
    /// </summary>
    public interface IMyAPICredentialService
    {
        /// <summary>
        /// Remove allowed origin
        /// </summary>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void RemoveAllowedOrigin(string originId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Remove allowed origin
        /// </summary>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task RemoveAllowedOriginAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get API credential details
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="MeApiCredential"/>.</returns>
        MeApiCredential GetApiCredentialDetails(RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get API credential details
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="MeApiCredential"/>.</returns>
        Task<MeApiCredential> GetApiCredentialDetailsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get allowed origins
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOriginsResponse"/>.</returns>
        AllowedOriginsResponse GetAllowedOrigins(RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get allowed origins
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOriginsResponse"/>.</returns>
        Task<AllowedOriginsResponse> GetAllowedOriginsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get allowed origin details
        /// </summary>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOrigin"/>.</returns>
        AllowedOrigin GetAllowedOriginDetails(string originId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get allowed origin details
        /// </summary>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOrigin"/>.</returns>
        Task<AllowedOrigin> GetAllowedOriginDetailsAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Add allowed origin
        /// </summary>
        /// <param name="createAllowedOriginRequest"><see cref="CreateAllowedOriginRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOrigin"/>.</returns>
        AllowedOrigin AddAllowedOrigin(CreateAllowedOriginRequest createAllowedOriginRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Add allowed origin
        /// </summary>
        /// <param name="createAllowedOriginRequest"><see cref="CreateAllowedOriginRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOrigin"/>.</returns>
        Task<AllowedOrigin> AddAllowedOriginAsync(CreateAllowedOriginRequest createAllowedOriginRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the MyAPICredentialService API endpoints
    /// </summary>
    public class MyAPICredentialService : AbstractService, IMyAPICredentialService
    {
        private readonly string _baseUrl;
        
        public MyAPICredentialService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public void RemoveAllowedOrigin(string originId, RequestOptions requestOptions = default)
        {
            RemoveAllowedOriginAsync(originId, requestOptions).GetAwaiter().GetResult();
        }

        public async Task RemoveAllowedOriginAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/me/allowedOrigins/{originId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken);
        }
        
        public MeApiCredential GetApiCredentialDetails(RequestOptions requestOptions = default)
        {
            return GetApiCredentialDetailsAsync(requestOptions).GetAwaiter().GetResult();
        }

        public async Task<MeApiCredential> GetApiCredentialDetailsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<MeApiCredential>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public AllowedOriginsResponse GetAllowedOrigins(RequestOptions requestOptions = default)
        {
            return GetAllowedOriginsAsync(requestOptions).GetAwaiter().GetResult();
        }

        public async Task<AllowedOriginsResponse> GetAllowedOriginsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me/allowedOrigins";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AllowedOriginsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public AllowedOrigin GetAllowedOriginDetails(string originId, RequestOptions requestOptions = default)
        {
            return GetAllowedOriginDetailsAsync(originId, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<AllowedOrigin> GetAllowedOriginDetailsAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/me/allowedOrigins/{originId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AllowedOrigin>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public AllowedOrigin AddAllowedOrigin(CreateAllowedOriginRequest createAllowedOriginRequest, RequestOptions requestOptions = default)
        {
            return AddAllowedOriginAsync(createAllowedOriginRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<AllowedOrigin> AddAllowedOriginAsync(CreateAllowedOriginRequest createAllowedOriginRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me/allowedOrigins";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AllowedOrigin>(createAllowedOriginRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }
    }
}