## Adyen.Management.Services.APICredentialsMerchantLevelService

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
    IAPICredentialsMerchantLevelService aPICredentialsMerchantLevelService = host.Services.GetRequiredService<IAPICredentialsMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiCredential**](APICredentialsMerchantLevelService.md#createapicredential) | **POST** /merchants/{merchantId}/apiCredentials | Create an API credential |
| [**GetApiCredential**](APICredentialsMerchantLevelService.md#getapicredential) | **GET** /merchants/{merchantId}/apiCredentials/{apiCredentialId} | Get an API credential |
| [**ListApiCredentials**](APICredentialsMerchantLevelService.md#listapicredentials) | **GET** /merchants/{merchantId}/apiCredentials | Get a list of API credentials |
| [**UpdateApiCredential**](APICredentialsMerchantLevelService.md#updateapicredential) | **PATCH** /merchants/{merchantId}/apiCredentials/{apiCredentialId} | Update an API credential |

<a id="createapicredential"></a>
### **POST** **/merchants/{merchantId}/apiCredentials**

Create an API credential

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **createMerchantApiCredentialRequest** | **CreateMerchantApiCredentialRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsMerchantLevelService.CreateApiCredential` usage:
// Provide the following values: merchantId, createMerchantApiCredentialRequest
ICreateApiCredentialResponse response = await aPICredentialsMerchantLevelService.CreateApiCredentialAsync(
    string merchantId, CreateMerchantApiCredentialRequest createMerchantApiCredentialRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateApiCredentialResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateApiCredentialResponse]()


<a id="getapicredential"></a>
### **GET** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}**

Get an API credential

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsMerchantLevelService.GetApiCredential` usage:
// Provide the following values: merchantId, apiCredentialId
IApiCredential response = await aPICredentialsMerchantLevelService.GetApiCredentialAsync(
    string merchantId, string apiCredentialId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ApiCredential result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ApiCredential]()


<a id="listapicredentials"></a>
### **GET** **/merchants/{merchantId}/apiCredentials**

Get a list of API credentials

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsMerchantLevelService.ListApiCredentials` usage:
// Provide the following values: merchantId, pageNumber, pageSize
IListMerchantApiCredentialsResponse response = await aPICredentialsMerchantLevelService.ListApiCredentialsAsync(
    string merchantId, Option<int> pageNumber = default, Option<int> pageSize = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListMerchantApiCredentialsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListMerchantApiCredentialsResponse]()


<a id="updateapicredential"></a>
### **PATCH** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}**

Update an API credential

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **updateMerchantApiCredentialRequest** | **UpdateMerchantApiCredentialRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsMerchantLevelService.UpdateApiCredential` usage:
// Provide the following values: merchantId, apiCredentialId, updateMerchantApiCredentialRequest
IApiCredential response = await aPICredentialsMerchantLevelService.UpdateApiCredentialAsync(
    string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest updateMerchantApiCredentialRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ApiCredential result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ApiCredential]()


