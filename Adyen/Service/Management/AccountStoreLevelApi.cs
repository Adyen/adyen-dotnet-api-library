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
    public class AccountStoreLevelApi : AbstractService
    {
        public AccountStoreLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of stores Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <param name="reference">The reference of the store. (optional)</param>
        /// <returns>ListStoresResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public ListStoresResponse GetMerchantsMerchantIdStores(string merchantId, RequestOptions requestOptions = default)
        {
            return GetMerchantsMerchantIdStoresAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of stores Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <param name="reference">The reference of the store. (optional)</param>
        /// <returns>Task of ListStoresResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<ListStoresResponse> GetMerchantsMerchantIdStoresAsync(string merchantId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListStoresResponse>(jsonResult);
        }

        /// <summary>
        /// Get a store Returns the details of the store identified in the path.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <returns>Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Store GetMerchantsMerchantIdStoresStoreId(string merchantId, string storeId, RequestOptions requestOptions = default)
        {
            return GetMerchantsMerchantIdStoresStoreIdAsync(merchantId, storeId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a store Returns the details of the store identified in the path.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <returns>Task of Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Store> GetMerchantsMerchantIdStoresStoreIdAsync(string merchantId, string storeId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{storeId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Get a list of stores Returns a list of stores. The list is grouped into pages as defined by the query parameters.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <param name="reference">The reference of the store. (optional)</param>
        /// <param name="merchantId">The unique identifier of the merchant account. (optional)</param>
        /// <returns>ListStoresResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public ListStoresResponse GetStores(RequestOptions requestOptions = default)
        {
            return GetStoresAsync(requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of stores Returns a list of stores. The list is grouped into pages as defined by the query parameters.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <param name="reference">The reference of the store. (optional)</param>
        /// <param name="merchantId">The unique identifier of the merchant account. (optional)</param>
        /// <returns>Task of ListStoresResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<ListStoresResponse> GetStoresAsync(RequestOptions requestOptions = default)
        {
            var endpoint = "/stores" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListStoresResponse>(jsonResult);
        }

        /// <summary>
        /// Get a store Returns the details of the store identified in the path.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <returns>Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Store GetStoresStoreId(string storeId, RequestOptions requestOptions = default)
        {
            return GetStoresStoreIdAsync(storeId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a store Returns the details of the store identified in the path.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <returns>Task of Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Store> GetStoresStoreIdAsync(string storeId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Update a store Updates the store identified in the path. You can only update some store parameters.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"> (optional)</param>
        /// <returns>Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Store PatchMerchantsMerchantIdStoresStoreId(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            return PatchMerchantsMerchantIdStoresStoreIdAsync(merchantId, storeId, updateStoreRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a store Updates the store identified in the path. You can only update some store parameters.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"> (optional)</param>
        /// <returns>Task of Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Store> PatchMerchantsMerchantIdStoresStoreIdAsync(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{storeId}";
            string jsonRequest = updateStoreRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Update a store Updates the store identified in the path. You can only update some store parameters.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"> (optional)</param>
        /// <returns>Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Store PatchStoresStoreId(string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            return PatchStoresStoreIdAsync(storeId, updateStoreRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a store Updates the store identified in the path. You can only update some store parameters.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"> (optional)</param>
        /// <returns>Task of Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Store> PatchStoresStoreIdAsync(string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}";
            string jsonRequest = updateStoreRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Create a store Creates a store for the merchant account identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeCreationRequest"> (optional)</param>
        /// <returns>Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Store PostMerchantsMerchantIdStores(string merchantId, StoreCreationRequest storeCreationRequest, RequestOptions requestOptions = default)
        {
            return PostMerchantsMerchantIdStoresAsync(merchantId, storeCreationRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a store Creates a store for the merchant account identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeCreationRequest"> (optional)</param>
        /// <returns>Task of Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Store> PostMerchantsMerchantIdStoresAsync(string merchantId, StoreCreationRequest storeCreationRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores";
            string jsonRequest = storeCreationRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Create a store Creates a store for the merchant account specified in the request.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeCreationWithMerchantCodeRequest"> (optional)</param>
        /// <returns>Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Store PostStores(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest, RequestOptions requestOptions = default)
        {
            return PostStoresAsync(storeCreationWithMerchantCodeRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a store Creates a store for the merchant account specified in the request.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Stores read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeCreationWithMerchantCodeRequest"> (optional)</param>
        /// <returns>Task of Store</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Store> PostStoresAsync(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest, RequestOptions requestOptions = default)
        {
            var endpoint = "/stores";
            string jsonRequest = storeCreationWithMerchantCodeRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

    }
}
