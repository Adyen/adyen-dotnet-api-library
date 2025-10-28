# Adyen.Management.Services.TerminalOrdersMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](TerminalOrdersMerchantLevelService.md#cancelorder) | **POST** /merchants/{merchantId}/terminalOrders/{orderId}/cancel | Cancel an order |
| [**CreateOrder**](TerminalOrdersMerchantLevelService.md#createorder) | **POST** /merchants/{merchantId}/terminalOrders | Create an order |
| [**CreateShippingLocation**](TerminalOrdersMerchantLevelService.md#createshippinglocation) | **POST** /merchants/{merchantId}/shippingLocations | Create a shipping location |
| [**GetOrder**](TerminalOrdersMerchantLevelService.md#getorder) | **GET** /merchants/{merchantId}/terminalOrders/{orderId} | Get an order |
| [**ListBillingEntities**](TerminalOrdersMerchantLevelService.md#listbillingentities) | **GET** /merchants/{merchantId}/billingEntities | Get a list of billing entities |
| [**ListOrders**](TerminalOrdersMerchantLevelService.md#listorders) | **GET** /merchants/{merchantId}/terminalOrders | Get a list of orders |
| [**ListShippingLocations**](TerminalOrdersMerchantLevelService.md#listshippinglocations) | **GET** /merchants/{merchantId}/shippingLocations | Get a list of shipping locations |
| [**ListTerminalModels**](TerminalOrdersMerchantLevelService.md#listterminalmodels) | **GET** /merchants/{merchantId}/terminalModels | Get a list of terminal models |
| [**ListTerminalProducts**](TerminalOrdersMerchantLevelService.md#listterminalproducts) | **GET** /merchants/{merchantId}/terminalProducts | Get a list of terminal products |
| [**UpdateOrder**](TerminalOrdersMerchantLevelService.md#updateorder) | **PATCH** /merchants/{merchantId}/terminalOrders/{orderId} | Update an order |

<a id="cancelorder"></a>
# **POST** **/merchants/{merchantId}/terminalOrders/{orderId}/cancel**

Cancel an order

```csharp 
ITerminalOrder CancelOrderAsync(string merchantId, string orderId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **orderId** | **string** | The unique identifier of the order. |

### Return type

[**TerminalOrder**](TerminalOrder.md)

<a id="createorder"></a>
# **POST** **/merchants/{merchantId}/terminalOrders**

Create an order

```csharp 
ITerminalOrder CreateOrderAsync(string merchantId, TerminalOrderRequest terminalOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **terminalOrderRequest** | [**TerminalOrderRequest**](TerminalOrderRequest.md) |  |

### Return type

[**TerminalOrder**](TerminalOrder.md)

<a id="createshippinglocation"></a>
# **POST** **/merchants/{merchantId}/shippingLocations**

Create a shipping location

```csharp 
IShippingLocation CreateShippingLocationAsync(string merchantId, ShippingLocation shippingLocation = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **shippingLocation** | [**ShippingLocation**](ShippingLocation.md) |  |

### Return type

[**ShippingLocation**](ShippingLocation.md)

<a id="getorder"></a>
# **GET** **/merchants/{merchantId}/terminalOrders/{orderId}**

Get an order

```csharp 
ITerminalOrder GetOrderAsync(string merchantId, string orderId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **orderId** | **string** | The unique identifier of the order. |

### Return type

[**TerminalOrder**](TerminalOrder.md)

<a id="listbillingentities"></a>
# **GET** **/merchants/{merchantId}/billingEntities**

Get a list of billing entities

```csharp 
IBillingEntitiesResponse ListBillingEntitiesAsync(string merchantId, string name = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **name** | **string** | The name of the billing entity. |

### Return type

[**BillingEntitiesResponse**](BillingEntitiesResponse.md)

<a id="listorders"></a>
# **GET** **/merchants/{merchantId}/terminalOrders**

Get a list of orders

```csharp 
ITerminalOrdersResponse ListOrdersAsync(string merchantId, string customerOrderReference = null, string status = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** |  |
| **customerOrderReference** | **string** | Your purchase order number. |
| **status** | **string** | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| **offset** | **int** | The number of orders to skip. |
| **limit** | **int** | The number of orders to return. |

### Return type

[**TerminalOrdersResponse**](TerminalOrdersResponse.md)

<a id="listshippinglocations"></a>
# **GET** **/merchants/{merchantId}/shippingLocations**

Get a list of shipping locations

```csharp 
IShippingLocationsResponse ListShippingLocationsAsync(string merchantId, string name = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **name** | **string** | The name of the shipping location. |
| **offset** | **int** | The number of locations to skip. |
| **limit** | **int** | The number of locations to return. |

### Return type

[**ShippingLocationsResponse**](ShippingLocationsResponse.md)

<a id="listterminalmodels"></a>
# **GET** **/merchants/{merchantId}/terminalModels**

Get a list of terminal models

```csharp 
ITerminalModelsResponse ListTerminalModelsAsync(string merchantId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**TerminalModelsResponse**](TerminalModelsResponse.md)

<a id="listterminalproducts"></a>
# **GET** **/merchants/{merchantId}/terminalProducts**

Get a list of terminal products

```csharp 
ITerminalProductsResponse ListTerminalProductsAsync(string merchantId, string country, string terminalModelId = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **country** | **string** | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| **terminalModelId** | **string** | The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels) response. For example, **Verifone.M400** |
| **offset** | **int** | The number of products to skip. |
| **limit** | **int** | The number of products to return. |

### Return type

[**TerminalProductsResponse**](TerminalProductsResponse.md)

<a id="updateorder"></a>
# **PATCH** **/merchants/{merchantId}/terminalOrders/{orderId}**

Update an order

```csharp 
ITerminalOrder UpdateOrderAsync(string merchantId, string orderId, TerminalOrderRequest terminalOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **orderId** | **string** | The unique identifier of the order. |
| **terminalOrderRequest** | [**TerminalOrderRequest**](TerminalOrderRequest.md) |  |

### Return type

[**TerminalOrder**](TerminalOrder.md)

