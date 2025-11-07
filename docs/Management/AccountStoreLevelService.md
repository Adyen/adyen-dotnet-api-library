## Adyen.Management.Services.AccountStoreLevelService

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
    IAccountStoreLevelService accountStoreLevelService = host.Services.GetRequiredService<IAccountStoreLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateStore**](AccountStoreLevelService.md#createstore) | **POST** /stores | Create a store |
| [**CreateStoreByMerchantId**](AccountStoreLevelService.md#createstorebymerchantid) | **POST** /merchants/{merchantId}/stores | Create a store |
| [**GetStore**](AccountStoreLevelService.md#getstore) | **GET** /merchants/{merchantId}/stores/{storeId} | Get a store |
| [**GetStoreById**](AccountStoreLevelService.md#getstorebyid) | **GET** /stores/{storeId} | Get a store |
| [**ListStores**](AccountStoreLevelService.md#liststores) | **GET** /stores | Get a list of stores |
| [**ListStoresByMerchantId**](AccountStoreLevelService.md#liststoresbymerchantid) | **GET** /merchants/{merchantId}/stores | Get a list of stores |
| [**UpdateStore**](AccountStoreLevelService.md#updatestore) | **PATCH** /merchants/{merchantId}/stores/{storeId} | Update a store |
| [**UpdateStoreById**](AccountStoreLevelService.md#updatestorebyid) | **PATCH** /stores/{storeId} | Update a store |

<a id="createstore"></a>
### **POST** **/stores**

Create a store

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeCreationWithMerchantCodeRequest** | **StoreCreationWithMerchantCodeRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.CreateStore` usage:
// Provide the following values: storeCreationWithMerchantCodeRequest.
IStore response = await accountStoreLevelService.CreateStoreAsync(
    StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Store result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Store]()


<a id="createstorebymerchantid"></a>
### **POST** **/merchants/{merchantId}/stores**

Create a store

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **storeCreationRequest** | **StoreCreationRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.CreateStoreByMerchantId` usage:
// Provide the following values: merchantId, storeCreationRequest.
IStore response = await accountStoreLevelService.CreateStoreByMerchantIdAsync(
    string merchantId,
    StoreCreationRequest storeCreationRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Store result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Store]()


<a id="getstore"></a>
### **GET** **/merchants/{merchantId}/stores/{storeId}**

Get a store

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **storeId** | [string] | The unique identifier of the store. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.GetStore` usage:
// Provide the following values: merchantId, storeId.
IStore response = await accountStoreLevelService.GetStoreAsync(
    string merchantId,
    string storeId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Store result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Store]()


<a id="getstorebyid"></a>
### **GET** **/stores/{storeId}**

Get a store

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | [string] | The unique identifier of the store. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.GetStoreById` usage:
// Provide the following values: storeId.
IStore response = await accountStoreLevelService.GetStoreByIdAsync(
    string storeId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Store result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Store]()


<a id="liststores"></a>
### **GET** **/stores**

Get a list of stores

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| **reference** | [string] | The reference of the store. |
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.ListStores` usage:
// Provide the following values: pageNumber, pageSize, reference, merchantId.
IListStoresResponse response = await accountStoreLevelService.ListStoresAsync(
    int pageNumber,
    int pageSize,
    string reference,
    string merchantId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListStoresResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListStoresResponse]()


<a id="liststoresbymerchantid"></a>
### **GET** **/merchants/{merchantId}/stores**

Get a list of stores

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| **reference** | [string] | The reference of the store. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.ListStoresByMerchantId` usage:
// Provide the following values: merchantId, pageNumber, pageSize, reference.
IListStoresResponse response = await accountStoreLevelService.ListStoresByMerchantIdAsync(
    string merchantId,
    int pageNumber,
    int pageSize,
    string reference, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListStoresResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListStoresResponse]()


<a id="updatestore"></a>
### **PATCH** **/merchants/{merchantId}/stores/{storeId}**

Update a store

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **storeId** | [string] | The unique identifier of the store. |
| **updateStoreRequest** | **UpdateStoreRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.UpdateStore` usage:
// Provide the following values: merchantId, storeId, updateStoreRequest.
IStore response = await accountStoreLevelService.UpdateStoreAsync(
    string merchantId,
    string storeId,
    UpdateStoreRequest updateStoreRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Store result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Store]()


<a id="updatestorebyid"></a>
### **PATCH** **/stores/{storeId}**

Update a store

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | [string] | The unique identifier of the store. |
| **updateStoreRequest** | **UpdateStoreRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountStoreLevelService.UpdateStoreById` usage:
// Provide the following values: storeId, updateStoreRequest.
IStore response = await accountStoreLevelService.UpdateStoreByIdAsync(
    string storeId,
    UpdateStoreRequest updateStoreRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Store result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Store]()


