/*
* Management API
*
*
* The version of the OpenAPI document: 3
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
        Model.Management.MeApiCredential GetApiCredentialDetails(RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get API credential details
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="MeApiCredential"/>.</returns>
        Task<Model.Management.MeApiCredential> GetApiCredentialDetailsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get allowed origins
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOriginsResponse"/>.</returns>
        Model.Management.AllowedOriginsResponse GetAllowedOrigins(RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get allowed origins
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOriginsResponse"/>.</returns>
        Task<Model.Management.AllowedOriginsResponse> GetAllowedOriginsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get allowed origin details
        /// </summary>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOrigin"/>.</returns>
        Model.Management.AllowedOrigin GetAllowedOriginDetails(string originId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get allowed origin details
        /// </summary>
        /// <param name="originId"><see cref="string"/> - Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOrigin"/>.</returns>
        Task<Model.Management.AllowedOrigin> GetAllowedOriginDetailsAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Add allowed origin
        /// </summary>
        /// <param name="createAllowedOriginRequest"><see cref="CreateAllowedOriginRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AllowedOrigin"/>.</returns>
        Model.Management.AllowedOrigin AddAllowedOrigin(CreateAllowedOriginRequest createAllowedOriginRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Add allowed origin
        /// </summary>
        /// <param name="createAllowedOriginRequest"><see cref="CreateAllowedOriginRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AllowedOrigin"/>.</returns>
        Task<Model.Management.AllowedOrigin> AddAllowedOriginAsync(CreateAllowedOriginRequest createAllowedOriginRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Generate a client key
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GenerateClientKeyResponse"/>.</returns>
        Model.Management.GenerateClientKeyResponse GenerateClientKey(RequestOptions requestOptions = default);
        
        /// <summary>
        /// Generate a client key
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GenerateClientKeyResponse"/>.</returns>
        Task<Model.Management.GenerateClientKeyResponse> GenerateClientKeyAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the MyAPICredentialService API endpoints
    /// </summary>
    public class MyAPICredentialService : AbstractService, IMyAPICredentialService
    {
        private readonly string _baseUrl;
        
        public MyAPICredentialService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v3");
        }
        
        public void RemoveAllowedOrigin(string originId, RequestOptions requestOptions = default)
        {
            RemoveAllowedOriginAsync(originId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task RemoveAllowedOriginAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/me/allowedOrigins/{originId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.MeApiCredential GetApiCredentialDetails(RequestOptions requestOptions = default)
        {
            return GetApiCredentialDetailsAsync(requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.MeApiCredential> GetApiCredentialDetailsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.MeApiCredential>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.AllowedOriginsResponse GetAllowedOrigins(RequestOptions requestOptions = default)
        {
            return GetAllowedOriginsAsync(requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.AllowedOriginsResponse> GetAllowedOriginsAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me/allowedOrigins";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.AllowedOriginsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.AllowedOrigin GetAllowedOriginDetails(string originId, RequestOptions requestOptions = default)
        {
            return GetAllowedOriginDetailsAsync(originId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.AllowedOrigin> GetAllowedOriginDetailsAsync(string originId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/me/allowedOrigins/{originId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.AllowedOrigin>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.AllowedOrigin AddAllowedOrigin(CreateAllowedOriginRequest createAllowedOriginRequest = default, RequestOptions requestOptions = default)
        {
            return AddAllowedOriginAsync(createAllowedOriginRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.AllowedOrigin> AddAllowedOriginAsync(CreateAllowedOriginRequest createAllowedOriginRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me/allowedOrigins";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.AllowedOrigin>(createAllowedOriginRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.GenerateClientKeyResponse GenerateClientKey(RequestOptions requestOptions = default)
        {
            return GenerateClientKeyAsync(requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.GenerateClientKeyResponse> GenerateClientKeyAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/me/generateClientKey";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.GenerateClientKeyResponse>(null, requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}