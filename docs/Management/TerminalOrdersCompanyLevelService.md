## Adyen.Management.Services.TerminalOrdersCompanyLevelService

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
    ITerminalOrdersCompanyLevelService terminalOrdersCompanyLevelService = host.Services.GetRequiredService<ITerminalOrdersCompanyLevelService>();
```

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
### **POST** **/companies/{companyId}/terminalOrders/{orderId}/cancel**

Cancel an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **orderId** | [string] | The unique identifier of the order. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.CancelOrder` usage:
// Provide the following values: companyId, orderId.
ITerminalOrder response = await terminalOrdersCompanyLevelService.CancelOrderAsync(
    string companyId,
    string orderId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


<a id="createorder"></a>
### **POST** **/companies/{companyId}/terminalOrders**

Create an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **terminalOrderRequest** | **TerminalOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.CreateOrder` usage:
// Provide the following values: companyId, terminalOrderRequest.
ITerminalOrder response = await terminalOrdersCompanyLevelService.CreateOrderAsync(
    string companyId,
    TerminalOrderRequest terminalOrderRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


<a id="createshippinglocation"></a>
### **POST** **/companies/{companyId}/shippingLocations**

Create a shipping location

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **shippingLocation** | **ShippingLocation** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.CreateShippingLocation` usage:
// Provide the following values: companyId, shippingLocation.
IShippingLocation response = await terminalOrdersCompanyLevelService.CreateShippingLocationAsync(
    string companyId,
    ShippingLocation shippingLocation, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ShippingLocation result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ShippingLocation]()


<a id="getorder"></a>
### **GET** **/companies/{companyId}/terminalOrders/{orderId}**

Get an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **orderId** | [string] | The unique identifier of the order. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.GetOrder` usage:
// Provide the following values: companyId, orderId.
ITerminalOrder response = await terminalOrdersCompanyLevelService.GetOrderAsync(
    string companyId,
    string orderId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


<a id="listbillingentities"></a>
### **GET** **/companies/{companyId}/billingEntities**

Get a list of billing entities

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **name** | [string] | The name of the billing entity. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.ListBillingEntities` usage:
// Provide the following values: companyId, name.
IBillingEntitiesResponse response = await terminalOrdersCompanyLevelService.ListBillingEntitiesAsync(
    string companyId,
    string name, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BillingEntitiesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BillingEntitiesResponse]()


<a id="listorders"></a>
### **GET** **/companies/{companyId}/terminalOrders**

Get a list of orders

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **customerOrderReference** | [string] | Your purchase order number. |
| **status** | [string] | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| **offset** | [int] | The number of orders to skip. |
| **limit** | [int] | The number of orders to return. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.ListOrders` usage:
// Provide the following values: companyId, customerOrderReference, status, offset, limit.
ITerminalOrdersResponse response = await terminalOrdersCompanyLevelService.ListOrdersAsync(
    string companyId,
    string customerOrderReference,
    string status,
    int offset,
    int limit, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrdersResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrdersResponse]()


<a id="listshippinglocations"></a>
### **GET** **/companies/{companyId}/shippingLocations**

Get a list of shipping locations

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **name** | [string] | The name of the shipping location. |
| **offset** | [int] | The number of locations to skip. |
| **limit** | [int] | The number of locations to return. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.ListShippingLocations` usage:
// Provide the following values: companyId, name, offset, limit.
IShippingLocationsResponse response = await terminalOrdersCompanyLevelService.ListShippingLocationsAsync(
    string companyId,
    string name,
    int offset,
    int limit, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ShippingLocationsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ShippingLocationsResponse]()


<a id="listterminalmodels"></a>
### **GET** **/companies/{companyId}/terminalModels**

Get a list of terminal models

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.ListTerminalModels` usage:
// Provide the following values: companyId.
ITerminalModelsResponse response = await terminalOrdersCompanyLevelService.ListTerminalModelsAsync(
    string companyId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalModelsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalModelsResponse]()


<a id="listterminalproducts"></a>
### **GET** **/companies/{companyId}/terminalProducts**

Get a list of terminal products

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **country** | [string] | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| **terminalModelId** | [string] | The terminal model to return products for. Use the ID returned in the [GET &#x60;/terminalModels&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) response. For example, **Verifone.M400** |
| **offset** | [int] | The number of products to skip. |
| **limit** | [int] | The number of products to return. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.ListTerminalProducts` usage:
// Provide the following values: companyId, country, terminalModelId, offset, limit.
ITerminalProductsResponse response = await terminalOrdersCompanyLevelService.ListTerminalProductsAsync(
    string companyId,
    string country,
    string terminalModelId,
    int offset,
    int limit, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalProductsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalProductsResponse]()


<a id="updateorder"></a>
### **PATCH** **/companies/{companyId}/terminalOrders/{orderId}**

Update an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **orderId** | [string] | The unique identifier of the order. |
| **terminalOrderRequest** | **TerminalOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalOrdersCompanyLevelService.UpdateOrder` usage:
// Provide the following values: companyId, orderId, terminalOrderRequest.
ITerminalOrder response = await terminalOrdersCompanyLevelService.UpdateOrderAsync(
    string companyId,
    string orderId,
    TerminalOrderRequest terminalOrderRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalOrder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalOrder]()


