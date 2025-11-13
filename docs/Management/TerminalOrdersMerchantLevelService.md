## Adyen.Management.Services.TerminalOrdersMerchantLevelService

#### API Base-Path: **https://management-test.adyen.com/v3**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureManagement((context, services, config) =>
    {
        config.ConfigureAdyenOptions(options =>
        {
            // Set your ADYEN_API_KEY or use get it from your environment using context.Configuration["ADYEN_API_KEY"].
            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];

            // Set your environment, e.g. `Test` or `Live`.
            options.Environment = AdyenEnvironment.Test;

            // For the Live environment, additionally include your LiveEndpointUrlPrefix.
            options.LiveEndpointUrlPrefix = "your-live-endpoint-url-prefix";
        });
    })
    .Build();

    // You can inject this service in your constructor.
    ITerminalOrdersMerchantLevelService terminalOrdersMerchantLevelService = host.Services.GetRequiredService<ITerminalOrdersMerchantLevelService>();
```

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
### **POST** **/merchants/{merchantId}/terminalOrders/{orderId}/cancel**

Cancel an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **orderId** | [string] | The unique identifier of the order. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.CancelOrder` usage:
// Provide the following values: merchantId, orderId
ITerminalOrder response = await terminalOrdersMerchantLevelService.CancelOrderAsync(
    string merchantId,
    string orderId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


<a id="createorder"></a>
### **POST** **/merchants/{merchantId}/terminalOrders**

Create an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **terminalOrderRequest** | **TerminalOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.CreateOrder` usage:
// Provide the following values: merchantId, terminalOrderRequest
ITerminalOrder response = await terminalOrdersMerchantLevelService.CreateOrderAsync(
    string merchantId,
    TerminalOrderRequest terminalOrderRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


<a id="createshippinglocation"></a>
### **POST** **/merchants/{merchantId}/shippingLocations**

Create a shipping location

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **shippingLocation** | **ShippingLocation** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.CreateShippingLocation` usage:
// Provide the following values: merchantId, shippingLocation
IShippingLocation response = await terminalOrdersMerchantLevelService.CreateShippingLocationAsync(
    string merchantId,
    ShippingLocation shippingLocation, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ShippingLocation result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ShippingLocation]()


<a id="getorder"></a>
### **GET** **/merchants/{merchantId}/terminalOrders/{orderId}**

Get an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **orderId** | [string] | The unique identifier of the order. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.GetOrder` usage:
// Provide the following values: merchantId, orderId
ITerminalOrder response = await terminalOrdersMerchantLevelService.GetOrderAsync(
    string merchantId,
    string orderId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


<a id="listbillingentities"></a>
### **GET** **/merchants/{merchantId}/billingEntities**

Get a list of billing entities

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **name** | [string] | The name of the billing entity. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.ListBillingEntities` usage:
// Provide the following values: merchantId, name
IBillingEntitiesResponse response = await terminalOrdersMerchantLevelService.ListBillingEntitiesAsync(
    string merchantId,
    string name, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BillingEntitiesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BillingEntitiesResponse]()


<a id="listorders"></a>
### **GET** **/merchants/{merchantId}/terminalOrders**

Get a list of orders

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] |  |
| **customerOrderReference** | [string] | Your purchase order number. |
| **status** | [string] | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| **offset** | [int] | The number of orders to skip. |
| **limit** | [int] | The number of orders to return. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.ListOrders` usage:
// Provide the following values: merchantId, customerOrderReference, status, offset, limit
ITerminalOrdersResponse response = await terminalOrdersMerchantLevelService.ListOrdersAsync(
    string merchantId,
    string customerOrderReference,
    string status,
    int offset,
    int limit, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrdersResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrdersResponse]()


<a id="listshippinglocations"></a>
### **GET** **/merchants/{merchantId}/shippingLocations**

Get a list of shipping locations

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **name** | [string] | The name of the shipping location. |
| **offset** | [int] | The number of locations to skip. |
| **limit** | [int] | The number of locations to return. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.ListShippingLocations` usage:
// Provide the following values: merchantId, name, offset, limit
IShippingLocationsResponse response = await terminalOrdersMerchantLevelService.ListShippingLocationsAsync(
    string merchantId,
    string name,
    int offset,
    int limit, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ShippingLocationsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ShippingLocationsResponse]()


<a id="listterminalmodels"></a>
### **GET** **/merchants/{merchantId}/terminalModels**

Get a list of terminal models

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.ListTerminalModels` usage:
// Provide the following values: merchantId
ITerminalModelsResponse response = await terminalOrdersMerchantLevelService.ListTerminalModelsAsync(
    string merchantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalModelsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalModelsResponse]()


<a id="listterminalproducts"></a>
### **GET** **/merchants/{merchantId}/terminalProducts**

Get a list of terminal products

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **country** | [string] | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| **terminalModelId** | [string] | The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels) response. For example, **Verifone.M400** |
| **offset** | [int] | The number of products to skip. |
| **limit** | [int] | The number of products to return. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.ListTerminalProducts` usage:
// Provide the following values: merchantId, country, terminalModelId, offset, limit
ITerminalProductsResponse response = await terminalOrdersMerchantLevelService.ListTerminalProductsAsync(
    string merchantId,
    string country,
    string terminalModelId,
    int offset,
    int limit, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalProductsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalProductsResponse]()


<a id="updateorder"></a>
### **PATCH** **/merchants/{merchantId}/terminalOrders/{orderId}**

Update an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **orderId** | [string] | The unique identifier of the order. |
| **terminalOrderRequest** | **TerminalOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersMerchantLevelService.UpdateOrder` usage:
// Provide the following values: merchantId, orderId, terminalOrderRequest
ITerminalOrder response = await terminalOrdersMerchantLevelService.UpdateOrderAsync(
    string merchantId,
    string orderId,
    TerminalOrderRequest terminalOrderRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


