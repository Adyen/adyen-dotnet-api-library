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
    public class TerminalOrdersMerchantLevelApi : AbstractService
    {
        public TerminalOrdersMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of billing entities
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>name</term>
        ///         <description>The name of the billing entity.</description>
        ///     </item>
        /// </list></param>
        /// <returns>BillingEntitiesResponse</returns>
        public BillingEntitiesResponse GetMerchantsMerchantIdBillingEntities(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdBillingEntitiesAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of billing entities
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>name</term>
        ///         <description>The name of the billing entity.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of BillingEntitiesResponse</returns>
        public async Task<BillingEntitiesResponse> GetMerchantsMerchantIdBillingEntitiesAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/billingEntities" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<BillingEntitiesResponse>(jsonResult);
        }

        /// <summary>
        /// Get a list of shipping locations
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>name</term>
        ///         <description>The name of the shipping location.</description>
        ///     </item>
        ///     <item>
        ///         <term>offset</term>
        ///         <description>The number of locations to skip.</description>
        ///     </item>
        ///     <item>
        ///         <term>limit</term>
        ///         <description>The number of locations to return.</description>
        ///     </item>
        /// </list></param>
        /// <returns>ShippingLocationsResponse</returns>
        public ShippingLocationsResponse GetMerchantsMerchantIdShippingLocations(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdShippingLocationsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of shipping locations
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>name</term>
        ///         <description>The name of the shipping location.</description>
        ///     </item>
        ///     <item>
        ///         <term>offset</term>
        ///         <description>The number of locations to skip.</description>
        ///     </item>
        ///     <item>
        ///         <term>limit</term>
        ///         <description>The number of locations to return.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of ShippingLocationsResponse</returns>
        public async Task<ShippingLocationsResponse> GetMerchantsMerchantIdShippingLocationsAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/shippingLocations" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ShippingLocationsResponse>(jsonResult);
        }

        /// <summary>
        /// Get a list of terminal models
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalModelsResponse</returns>
        public TerminalModelsResponse GetMerchantsMerchantIdTerminalModels(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdTerminalModelsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of terminal models
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalModelsResponse</returns>
        public async Task<TerminalModelsResponse> GetMerchantsMerchantIdTerminalModelsAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalModels";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalModelsResponse>(jsonResult);
        }

        /// <summary>
        /// Get a list of orders
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>customerOrderReference</term>
        ///         <description>Your purchase order number.</description>
        ///     </item>
        ///     <item>
        ///         <term>status</term>
        ///         <description>The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.</description>
        ///     </item>
        ///     <item>
        ///         <term>offset</term>
        ///         <description>The number of orders to skip.</description>
        ///     </item>
        ///     <item>
        ///         <term>limit</term>
        ///         <description>The number of orders to return.</description>
        ///     </item>
        /// </list></param>
        /// <returns>TerminalOrdersResponse</returns>
        public TerminalOrdersResponse GetMerchantsMerchantIdTerminalOrders(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdTerminalOrdersAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of orders
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>customerOrderReference</term>
        ///         <description>Your purchase order number.</description>
        ///     </item>
        ///     <item>
        ///         <term>status</term>
        ///         <description>The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.</description>
        ///     </item>
        ///     <item>
        ///         <term>offset</term>
        ///         <description>The number of orders to skip.</description>
        ///     </item>
        ///     <item>
        ///         <term>limit</term>
        ///         <description>The number of orders to return.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of TerminalOrdersResponse</returns>
        public async Task<TerminalOrdersResponse> GetMerchantsMerchantIdTerminalOrdersAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalOrders" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalOrdersResponse>(jsonResult);
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder GetMerchantsMerchantIdTerminalOrdersOrderId(string merchantId, string orderId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdTerminalOrdersOrderIdAsync(merchantId, orderId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> GetMerchantsMerchantIdTerminalOrdersOrderIdAsync(string merchantId, string orderId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalOrders/{orderId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalOrder>(jsonResult);
        }

        /// <summary>
        /// Get a list of terminal products
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>country</term>
        ///         <description>The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US**</description>
        ///     </item>
        ///     <item>
        ///         <term>terminalModelId</term>
        ///         <description>The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/terminalModels) response. For example, **Verifone.M400**</description>
        ///     </item>
        ///     <item>
        ///         <term>offset</term>
        ///         <description>The number of products to skip.</description>
        ///     </item>
        ///     <item>
        ///         <term>limit</term>
        ///         <description>The number of products to return.</description>
        ///     </item>
        /// </list></param>
        /// <returns>TerminalProductsResponse</returns>
        public TerminalProductsResponse GetMerchantsMerchantIdTerminalProducts(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdTerminalProductsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of terminal products
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>country</term>
        ///         <description>The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US**</description>
        ///     </item>
        ///     <item>
        ///         <term>terminalModelId</term>
        ///         <description>The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/terminalModels) response. For example, **Verifone.M400**</description>
        ///     </item>
        ///     <item>
        ///         <term>offset</term>
        ///         <description>The number of products to skip.</description>
        ///     </item>
        ///     <item>
        ///         <term>limit</term>
        ///         <description>The number of products to return.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of TerminalProductsResponse</returns>
        public async Task<TerminalProductsResponse> GetMerchantsMerchantIdTerminalProductsAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalProducts" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalProductsResponse>(jsonResult);
        }

        /// <summary>
        /// Update an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder PatchMerchantsMerchantIdTerminalOrdersOrderId(string merchantId, string orderId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = null)
        {
            return PatchMerchantsMerchantIdTerminalOrdersOrderIdAsync(merchantId, orderId, terminalOrderRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> PatchMerchantsMerchantIdTerminalOrdersOrderIdAsync(string merchantId, string orderId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalOrders/{orderId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(terminalOrderRequest.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<TerminalOrder>(jsonResult);
        }

        /// <summary>
        /// Create a shipping location
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="shippingLocation"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ShippingLocation</returns>
        public ShippingLocation PostMerchantsMerchantIdShippingLocations(string merchantId, ShippingLocation shippingLocation, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdShippingLocationsAsync(merchantId, shippingLocation, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a shipping location
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="shippingLocation"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ShippingLocation</returns>
        public async Task<ShippingLocation> PostMerchantsMerchantIdShippingLocationsAsync(string merchantId, ShippingLocation shippingLocation, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/shippingLocations";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(shippingLocation.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<ShippingLocation>(jsonResult);
        }

        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder PostMerchantsMerchantIdTerminalOrders(string merchantId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdTerminalOrdersAsync(merchantId, terminalOrderRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> PostMerchantsMerchantIdTerminalOrdersAsync(string merchantId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalOrders";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(terminalOrderRequest.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<TerminalOrder>(jsonResult);
        }

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(string merchantId, string orderId, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdTerminalOrdersOrderIdCancelAsync(merchantId, orderId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> PostMerchantsMerchantIdTerminalOrdersOrderIdCancelAsync(string merchantId, string orderId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/terminalOrders/{orderId}/cancel";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<TerminalOrder>(jsonResult);
        }

    }
}
