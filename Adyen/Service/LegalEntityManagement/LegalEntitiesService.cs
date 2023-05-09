/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
using Adyen.Model.LegalEntityManagement;

namespace Adyen.Service.LegalEntityManagement
{
    /// <summary>
    /// LegalEntitiesService Interface
    /// </summary>
    public interface ILegalEntitiesService
    {
        /// <summary>
        /// Get a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="LegalEntity"/>.</returns>
        LegalEntity GetLegalEntity(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="LegalEntity"/>.</returns>
        Task<LegalEntity> GetLegalEntityAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get all business lines under a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="BusinessLines"/>.</returns>
        BusinessLines GetAllBusinessLinesUnderLegalEntity(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get all business lines under a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="BusinessLines"/>.</returns>
        Task<BusinessLines> GetAllBusinessLinesUnderLegalEntityAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="legalEntityInfo"><see cref="LegalEntityInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="LegalEntity"/>.</returns>
        LegalEntity UpdateLegalEntity(string id, LegalEntityInfo legalEntityInfo, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="legalEntityInfo"><see cref="LegalEntityInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="LegalEntity"/>.</returns>
        Task<LegalEntity> UpdateLegalEntityAsync(string id, LegalEntityInfo legalEntityInfo, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a legal entity
        /// </summary>
        /// <param name="legalEntityInfoRequiredType"><see cref="LegalEntityInfoRequiredType"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="LegalEntity"/>.</returns>
        LegalEntity CreateLegalEntity(LegalEntityInfoRequiredType legalEntityInfoRequiredType, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a legal entity
        /// </summary>
        /// <param name="legalEntityInfoRequiredType"><see cref="LegalEntityInfoRequiredType"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="LegalEntity"/>.</returns>
        Task<LegalEntity> CreateLegalEntityAsync(LegalEntityInfoRequiredType legalEntityInfoRequiredType, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Check a legal entity's verification errors
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="VerificationErrors"/>.</returns>
        VerificationErrors CheckLegalEntitysVerificationErrors(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Check a legal entity's verification errors
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="VerificationErrors"/>.</returns>
        Task<VerificationErrors> CheckLegalEntitysVerificationErrorsAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the LegalEntitiesService API endpoints
    /// </summary>
    public class LegalEntitiesService : AbstractService, ILegalEntitiesService
    {
        private readonly string _baseUrl;
        
        public LegalEntitiesService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://kyc-test.adyen.com/lem/v3");
        }
        
        public LegalEntity GetLegalEntity(string id, RequestOptions requestOptions = default)
        {
            return GetLegalEntityAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<LegalEntity> GetLegalEntityAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<LegalEntity>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public BusinessLines GetAllBusinessLinesUnderLegalEntity(string id, RequestOptions requestOptions = default)
        {
            return GetAllBusinessLinesUnderLegalEntityAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<BusinessLines> GetAllBusinessLinesUnderLegalEntityAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/businessLines";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<BusinessLines>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public LegalEntity UpdateLegalEntity(string id, LegalEntityInfo legalEntityInfo, RequestOptions requestOptions = default)
        {
            return UpdateLegalEntityAsync(id, legalEntityInfo, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<LegalEntity> UpdateLegalEntityAsync(string id, LegalEntityInfo legalEntityInfo, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<LegalEntity>(legalEntityInfo.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken);
        }
        
        public LegalEntity CreateLegalEntity(LegalEntityInfoRequiredType legalEntityInfoRequiredType, RequestOptions requestOptions = default)
        {
            return CreateLegalEntityAsync(legalEntityInfoRequiredType, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<LegalEntity> CreateLegalEntityAsync(LegalEntityInfoRequiredType legalEntityInfoRequiredType, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/legalEntities";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<LegalEntity>(legalEntityInfoRequiredType.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }
        
        public VerificationErrors CheckLegalEntitysVerificationErrors(string id, RequestOptions requestOptions = default)
        {
            return CheckLegalEntitysVerificationErrorsAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<VerificationErrors> CheckLegalEntitysVerificationErrorsAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/checkVerificationErrors";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<VerificationErrors>(null, requestOptions, new HttpMethod("POST"), cancellationToken);
        }
    }
}