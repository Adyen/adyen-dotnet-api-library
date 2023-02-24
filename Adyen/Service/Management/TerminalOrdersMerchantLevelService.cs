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
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TerminalOrdersMerchantLevelService : AbstractService
    {
        private readonly string _baseUrl;
        
        public TerminalOrdersMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = client.Config.ManagementEndpoint + "/" + ClientConfig.ManagementVersion;
        }
    
        /// <summary>
        /// Get a list of billing entities
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="name">The name of the billing entity.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>BillingEntitiesResponse</returns>
        public BillingEntitiesResponse ListBillingEntities(string merchantId, string name = default, RequestOptions requestOptions = default)
        {
            return ListBillingEntitiesAsync(merchantId, name, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of billing entities
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="name">The name of the billing entity.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of BillingEntitiesResponse</returns>
        public async Task<BillingEntitiesResponse> ListBillingEntitiesAsync(string merchantId, string name = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (name != null) queryParams.Add("name", name);
            var endpoint = _baseUrl + $"/merchants/{merchantId}/billingEntities" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<BillingEntitiesResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get a list of shipping locations
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="name">The name of the shipping location.</param>
        /// <param name="offset">The number of locations to skip.</param>
        /// <param name="limit">The number of locations to return.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ShippingLocationsResponse</returns>
        public ShippingLocationsResponse ListShippingLocations(string merchantId, string name = default, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return ListShippingLocationsAsync(merchantId, name, offset, limit, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of shipping locations
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="name">The name of the shipping location.</param>
        /// <param name="offset">The number of locations to skip.</param>
        /// <param name="limit">The number of locations to return.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ShippingLocationsResponse</returns>
        public async Task<ShippingLocationsResponse> ListShippingLocationsAsync(string merchantId, string name = default, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (name != null) queryParams.Add("name", name);
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = _baseUrl + $"/merchants/{merchantId}/shippingLocations" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ShippingLocationsResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get a list of terminal models
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalModelsResponse</returns>
        public TerminalModelsResponse ListTerminalModels(string merchantId, RequestOptions requestOptions = default)
        {
            return ListTerminalModelsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of terminal models
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalModelsResponse</returns>
        public async Task<TerminalModelsResponse> ListTerminalModelsAsync(string merchantId, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalModels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalModelsResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get a list of orders
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="customerOrderReference">Your purchase order number.</param>
        /// <param name="status">The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.</param>
        /// <param name="offset">The number of orders to skip.</param>
        /// <param name="limit">The number of orders to return.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrdersResponse</returns>
        public TerminalOrdersResponse ListOrders(string merchantId, string customerOrderReference = default, string status = default, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return ListOrdersAsync(merchantId, customerOrderReference, status, offset, limit, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of orders
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="customerOrderReference">Your purchase order number.</param>
        /// <param name="status">The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.</param>
        /// <param name="offset">The number of orders to skip.</param>
        /// <param name="limit">The number of orders to return.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrdersResponse</returns>
        public async Task<TerminalOrdersResponse> ListOrdersAsync(string merchantId, string customerOrderReference = default, string status = default, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (customerOrderReference != null) queryParams.Add("customerOrderReference", customerOrderReference);
            if (status != null) queryParams.Add("status", status);
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalOrders" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalOrdersResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder GetOrder(string merchantId, string orderId, RequestOptions requestOptions = default)
        {
            return GetOrderAsync(merchantId, orderId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> GetOrderAsync(string merchantId, string orderId, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalOrders/{orderId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalOrder>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get a list of terminal products
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="country">The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US**</param>
        /// <param name="terminalModelId">The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels) response. For example, **Verifone.M400**</param>
        /// <param name="offset">The number of products to skip.</param>
        /// <param name="limit">The number of products to return.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalProductsResponse</returns>
        public TerminalProductsResponse ListTerminalProducts(string merchantId, string country, string terminalModelId = default, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return ListTerminalProductsAsync(merchantId, country, terminalModelId, offset, limit, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of terminal products
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="country">The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US**</param>
        /// <param name="terminalModelId">The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels) response. For example, **Verifone.M400**</param>
        /// <param name="offset">The number of products to skip.</param>
        /// <param name="limit">The number of products to return.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalProductsResponse</returns>
        public async Task<TerminalProductsResponse> ListTerminalProductsAsync(string merchantId, string country, string terminalModelId = default, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (country != null) queryParams.Add("country", country);
            if (terminalModelId != null) queryParams.Add("terminalModelId", terminalModelId);
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalProducts" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalProductsResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Update an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder UpdateOrder(string merchantId, string orderId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = default)
        {
            return UpdateOrderAsync(merchantId, orderId, terminalOrderRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> UpdateOrderAsync(string merchantId, string orderId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalOrders/{orderId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalOrder>(terminalOrderRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
        }

        /// <summary>
        /// Create a shipping location
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="shippingLocation"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ShippingLocation</returns>
        public ShippingLocation CreateShippingLocation(string merchantId, ShippingLocation shippingLocation, RequestOptions requestOptions = default)
        {
            return CreateShippingLocationAsync(merchantId, shippingLocation, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a shipping location
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="shippingLocation"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ShippingLocation</returns>
        public async Task<ShippingLocation> CreateShippingLocationAsync(string merchantId, ShippingLocation shippingLocation, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/shippingLocations";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ShippingLocation>(shippingLocation.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder CreateOrder(string merchantId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = default)
        {
            return CreateOrderAsync(merchantId, terminalOrderRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="terminalOrderRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> CreateOrderAsync(string merchantId, TerminalOrderRequest terminalOrderRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalOrders";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalOrder>(terminalOrderRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalOrder</returns>
        public TerminalOrder CancelOrder(string merchantId, string orderId, RequestOptions requestOptions = default)
        {
            return CancelOrderAsync(merchantId, orderId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalOrder</returns>
        public async Task<TerminalOrder> CancelOrderAsync(string merchantId, string orderId, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalOrders/{orderId}/cancel";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalOrder>(null, requestOptions, new HttpMethod("POST"));
        }

    }
}