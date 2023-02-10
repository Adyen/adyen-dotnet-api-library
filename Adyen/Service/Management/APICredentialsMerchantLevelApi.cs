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
    public class APICredentialsMerchantLevelApi : AbstractService
    {
        public APICredentialsMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListMerchantApiCredentialsResponse</returns>
        public ListMerchantApiCredentialsResponse ListApiCredentials(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListApiCredentialsAsync(merchantId, pageNumber, pageSize, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListMerchantApiCredentialsResponse</returns>
        public async Task<ListMerchantApiCredentialsResponse> ListApiCredentialsAsync(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = $"/merchants/{merchantId}/apiCredentials" + ToQueryString(queryParams);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListMerchantApiCredentialsResponse>(jsonResult);
        }

        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ApiCredential</returns>
        public ApiCredential GetApiCredential(string merchantId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            return GetApiCredentialAsync(merchantId, apiCredentialId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ApiCredential</returns>
        public async Task<ApiCredential> GetApiCredentialAsync(string merchantId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ApiCredential>(jsonResult);
        }

        /// <summary>
        /// Update an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="updateMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ApiCredential</returns>
        public ApiCredential UpdateApiCredential(string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest updateMerchantApiCredentialRequest, RequestOptions requestOptions = default)
        {
            return UpdateApiCredentialAsync(merchantId, apiCredentialId, updateMerchantApiCredentialRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="updateMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ApiCredential</returns>
        public async Task<ApiCredential> UpdateApiCredentialAsync(string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest updateMerchantApiCredentialRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updateMerchantApiCredentialRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<ApiCredential>(jsonResult);
        }

        /// <summary>
        /// Create an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CreateApiCredentialResponse</returns>
        public CreateApiCredentialResponse CreateApiCredential(string merchantId, CreateMerchantApiCredentialRequest createMerchantApiCredentialRequest, RequestOptions requestOptions = default)
        {
            return CreateApiCredentialAsync(merchantId, createMerchantApiCredentialRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CreateApiCredentialResponse</returns>
        public async Task<CreateApiCredentialResponse> CreateApiCredentialAsync(string merchantId, CreateMerchantApiCredentialRequest createMerchantApiCredentialRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(createMerchantApiCredentialRequest.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<CreateApiCredentialResponse>(jsonResult);
        }

    }
}