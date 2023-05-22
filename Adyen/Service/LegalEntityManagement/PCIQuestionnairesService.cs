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
    /// PCIQuestionnairesService Interface
    /// </summary>
    public interface IPCIQuestionnairesService
    {
        /// <summary>
        /// Generate PCI questionnaire
        /// </summary>
        /// <param name="id"><see cref="string"/> - The legal entity ID of the individual who will sign the PCI questionnaire.</param>
        /// <param name="generatePciDescriptionRequest"><see cref="GeneratePciDescriptionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GeneratePciDescriptionResponse"/>.</returns>
        GeneratePciDescriptionResponse GeneratePciQuestionnaire(string id, GeneratePciDescriptionRequest generatePciDescriptionRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Generate PCI questionnaire
        /// </summary>
        /// <param name="id"><see cref="string"/> - The legal entity ID of the individual who will sign the PCI questionnaire.</param>
        /// <param name="generatePciDescriptionRequest"><see cref="GeneratePciDescriptionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GeneratePciDescriptionResponse"/>.</returns>
        Task<GeneratePciDescriptionResponse> GeneratePciQuestionnaireAsync(string id, GeneratePciDescriptionRequest generatePciDescriptionRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get PCI questionnaire
        /// </summary>
        /// <param name="id"><see cref="string"/> - The legal entity ID of the individual who signed the PCI questionnaire.</param>
        /// <param name="pciid"><see cref="string"/> - The unique identifier of the signed PCI questionnaire.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GetPciQuestionnaireResponse"/>.</returns>
        GetPciQuestionnaireResponse GetPciQuestionnaire(string id, string pciid, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get PCI questionnaire
        /// </summary>
        /// <param name="id"><see cref="string"/> - The legal entity ID of the individual who signed the PCI questionnaire.</param>
        /// <param name="pciid"><see cref="string"/> - The unique identifier of the signed PCI questionnaire.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GetPciQuestionnaireResponse"/>.</returns>
        Task<GetPciQuestionnaireResponse> GetPciQuestionnaireAsync(string id, string pciid, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get PCI questionnaire details
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity to get PCI questionnaire information.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GetPciQuestionnaireInfosResponse"/>.</returns>
        GetPciQuestionnaireInfosResponse GetPciQuestionnaireDetails(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get PCI questionnaire details
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity to get PCI questionnaire information.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GetPciQuestionnaireInfosResponse"/>.</returns>
        Task<GetPciQuestionnaireInfosResponse> GetPciQuestionnaireDetailsAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Sign PCI questionnaire
        /// </summary>
        /// <param name="id"><see cref="string"/> - The legal entity ID of the individual who signed the PCI questionnaire.</param>
        /// <param name="pciSigningRequest"><see cref="PciSigningRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PciSigningResponse"/>.</returns>
        PciSigningResponse SignPciQuestionnaire(string id, PciSigningRequest pciSigningRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Sign PCI questionnaire
        /// </summary>
        /// <param name="id"><see cref="string"/> - The legal entity ID of the individual who signed the PCI questionnaire.</param>
        /// <param name="pciSigningRequest"><see cref="PciSigningRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PciSigningResponse"/>.</returns>
        Task<PciSigningResponse> SignPciQuestionnaireAsync(string id, PciSigningRequest pciSigningRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PCIQuestionnairesService API endpoints
    /// </summary>
    public class PCIQuestionnairesService : AbstractService, IPCIQuestionnairesService
    {
        private readonly string _baseUrl;
        
        public PCIQuestionnairesService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://kyc-test.adyen.com/lem/v3");
        }
        
        public GeneratePciDescriptionResponse GeneratePciQuestionnaire(string id, GeneratePciDescriptionRequest generatePciDescriptionRequest, RequestOptions requestOptions = default)
        {
            return GeneratePciQuestionnaireAsync(id, generatePciDescriptionRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GeneratePciDescriptionResponse> GeneratePciQuestionnaireAsync(string id, GeneratePciDescriptionRequest generatePciDescriptionRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/pciQuestionnaires/generatePciTemplates";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GeneratePciDescriptionResponse>(generatePciDescriptionRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public GetPciQuestionnaireResponse GetPciQuestionnaire(string id, string pciid, RequestOptions requestOptions = default)
        {
            return GetPciQuestionnaireAsync(id, pciid, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetPciQuestionnaireResponse> GetPciQuestionnaireAsync(string id, string pciid, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/pciQuestionnaires/{pciid}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GetPciQuestionnaireResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public GetPciQuestionnaireInfosResponse GetPciQuestionnaireDetails(string id, RequestOptions requestOptions = default)
        {
            return GetPciQuestionnaireDetailsAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetPciQuestionnaireInfosResponse> GetPciQuestionnaireDetailsAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/pciQuestionnaires";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GetPciQuestionnaireInfosResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public PciSigningResponse SignPciQuestionnaire(string id, PciSigningRequest pciSigningRequest, RequestOptions requestOptions = default)
        {
            return SignPciQuestionnaireAsync(id, pciSigningRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PciSigningResponse> SignPciQuestionnaireAsync(string id, PciSigningRequest pciSigningRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/pciQuestionnaires/signPciTemplates";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PciSigningResponse>(pciSigningRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}