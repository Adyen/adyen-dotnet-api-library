# Adyen.Management.Services.TerminalOrdersCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](TerminalOrdersCompanyLevelService.md#cancelorder) | **POST** /companies/{companyId}/terminalOrders/{orderId}/cancel | Cancel an order |
| [**CreateOrder**](TerminalOrdersCompanyLevelService.md#createorder) | **POST** /companies/{companyId}/terminalOrders | Create an order |
| [**CreateShippingLocation**](TerminalOrdersCompanyLevelService.md#createshippinglocation) | **POST** /companies/{companyId}/shippingLocations | Create a shipping location |
| [**GetOrder**](TerminalOrdersCompanyLevelService.md#getorder) | **GET** /companies/{companyId}/terminalOrders/{orderId} | Get an order |
| [**ListBillingEntities**](TerminalOrdersCompanyLevelService.md#listbillingentities) | **GET** /companies/{companyId}/billingEntities | Get a list of billing entities |
| [**ListOrders**](TerminalOrdersCompanyLevelService.md#listorders) | **GET** /companies/{companyId}/terminalOrders | Get a list of orders |
| [**ListShippingLocations**](TerminalOrdersCompanyLevelService.md#listshippinglocations) | **GET** /companies/{companyId}/shippingLocations | Get a list of shipping locations |
| [**ListTerminalModels**](TerminalOrdersCompanyLevelService.md#listterminalmodels) | **GET** /companies/{companyId}/terminalModels | Get a list of terminal models |
| [**ListTerminalProducts**](TerminalOrdersCompanyLevelService.md#listterminalproducts) | **GET** /companies/{companyId}/terminalProducts | Get a list of terminal products |
| [**UpdateOrder**](TerminalOrdersCompanyLevelService.md#updateorder) | **PATCH** /companies/{companyId}/terminalOrders/{orderId} | Update an order |

<a id="cancelorder"></a>
# **POST** **/companies/{companyId}/terminalOrders/{orderId}/cancel**

Cancel an order

```csharp 
ITerminalOrder CancelOrderAsync(string companyId, string orderId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **orderId** | **string** | The unique identifier of the order. |

### Return type

[**TerminalOrder**](TerminalOrder.md)

<a id="createorder"></a>
# **POST** **/companies/{companyId}/terminalOrders**

Create an order

```csharp 
ITerminalOrder CreateOrderAsync(string companyId, TerminalOrderRequest terminalOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **terminalOrderRequest** | [**TerminalOrderRequest**](TerminalOrderRequest.md) |  |

### Return type

[**TerminalOrder**](TerminalOrder.md)

<a id="createshippinglocation"></a>
# **POST** **/companies/{companyId}/shippingLocations**

Create a shipping location

```csharp 
IShippingLocation CreateShippingLocationAsync(string companyId, ShippingLocation shippingLocation = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **shippingLocation** | [**ShippingLocation**](ShippingLocation.md) |  |

### Return type

[**ShippingLocation**](ShippingLocation.md)

<a id="getorder"></a>
# **GET** **/companies/{companyId}/terminalOrders/{orderId}**

Get an order

```csharp 
ITerminalOrder GetOrderAsync(string companyId, string orderId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **orderId** | **string** | The unique identifier of the order. |

### Return type

[**TerminalOrder**](TerminalOrder.md)

<a id="listbillingentities"></a>
# **GET** **/companies/{companyId}/billingEntities**

Get a list of billing entities

```csharp 
IBillingEntitiesResponse ListBillingEntitiesAsync(string companyId, string name = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **name** | **string** | The name of the billing entity. |

### Return type

[**BillingEntitiesResponse**](BillingEntitiesResponse.md)

<a id="listorders"></a>
# **GET** **/companies/{companyId}/terminalOrders**

Get a list of orders

```csharp 
ITerminalOrdersResponse ListOrdersAsync(string companyId, string customerOrderReference = null, string status = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **customerOrderReference** | **string** | Your purchase order number. |
| **status** | **string** | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| **offset** | **int** | The number of orders to skip. |
| **limit** | **int** | The number of orders to return. |

### Return type

[**TerminalOrdersResponse**](TerminalOrdersResponse.md)

<a id="listshippinglocations"></a>
# **GET** **/companies/{companyId}/shippingLocations**

Get a list of shipping locations

```csharp 
IShippingLocationsResponse ListShippingLocationsAsync(string companyId, string name = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **name** | **string** | The name of the shipping location. |
| **offset** | **int** | The number of locations to skip. |
| **limit** | **int** | The number of locations to return. |

### Return type

[**ShippingLocationsResponse**](ShippingLocationsResponse.md)

<a id="listterminalmodels"></a>
# **GET** **/companies/{companyId}/terminalModels**

Get a list of terminal models

```csharp 
ITerminalModelsResponse ListTerminalModelsAsync(string companyId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |

### Return type

[**TerminalModelsResponse**](TerminalModelsResponse.md)

<a id="listterminalproducts"></a>
# **GET** **/companies/{companyId}/terminalProducts**

Get a list of terminal products

```csharp 
ITerminalProductsResponse ListTerminalProductsAsync(string companyId, string country, string terminalModelId = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **country** | **string** | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| **terminalModelId** | **string** | The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) response. For example, **Verifone.M400** |
| **offset** | **int** | The number of products to skip. |
| **limit** | **int** | The number of products to return. |

### Return type

[**TerminalProductsResponse**](TerminalProductsResponse.md)

<a id="updateorder"></a>
# **PATCH** **/companies/{companyId}/terminalOrders/{orderId}**

Update an order

```csharp 
ITerminalOrder UpdateOrderAsync(string companyId, string orderId, TerminalOrderRequest terminalOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **orderId** | **string** | The unique identifier of the order. |
| **terminalOrderRequest** | [**TerminalOrderRequest**](TerminalOrderRequest.md) |  |

### Return type

[**TerminalOrder**](TerminalOrder.md)

