## Adyen.Management.Services.AllowedOriginsMerchantLevelService

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
    IAllowedOriginsMerchantLevelService allowedOriginsMerchantLevelService = host.Services.GetRequiredService<IAllowedOriginsMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAllowedOrigin**](AllowedOriginsMerchantLevelService.md#createallowedorigin) | **POST** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins | Create an allowed origin |
| [**DeleteAllowedOrigin**](AllowedOriginsMerchantLevelService.md#deleteallowedorigin) | **DELETE** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Delete an allowed origin |
| [**GetAllowedOrigin**](AllowedOriginsMerchantLevelService.md#getallowedorigin) | **GET** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Get an allowed origin |
| [**ListAllowedOrigins**](AllowedOriginsMerchantLevelService.md#listallowedorigins) | **GET** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins | Get a list of allowed origins |

<a id="createallowedorigin"></a>
### **POST** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Create an allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **allowedOrigin** | **AllowedOrigin** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsMerchantLevelService.CreateAllowedOrigin` usage:
// Provide the following values: merchantId, apiCredentialId, allowedOrigin
IAllowedOrigin response = await allowedOriginsMerchantLevelService.CreateAllowedOriginAsync(
    string merchantId,
    string apiCredentialId,
    AllowedOrigin allowedOrigin, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AllowedOrigin result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AllowedOrigin]()


<a id="deleteallowedorigin"></a>
### **DELETE** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Delete an allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **originId** | [string] | Unique identifier of the allowed origin. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsMerchantLevelService.DeleteAllowedOrigin` usage:
// Provide the following values: merchantId, apiCredentialId, originId
await allowedOriginsMerchantLevelService.DeleteAllowedOriginAsync(
    string merchantId,
    string apiCredentialId,
    string originId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getallowedorigin"></a>
### **GET** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Get an allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **originId** | [string] | Unique identifier of the allowed origin. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsMerchantLevelService.GetAllowedOrigin` usage:
// Provide the following values: merchantId, apiCredentialId, originId
IAllowedOrigin response = await allowedOriginsMerchantLevelService.GetAllowedOriginAsync(
    string merchantId,
    string apiCredentialId,
    string originId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AllowedOrigin result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AllowedOrigin]()


<a id="listallowedorigins"></a>
### **GET** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Get a list of allowed origins

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsMerchantLevelService.ListAllowedOrigins` usage:
// Provide the following values: merchantId, apiCredentialId
IAllowedOriginsResponse response = await allowedOriginsMerchantLevelService.ListAllowedOriginsAsync(
    string merchantId,
    string apiCredentialId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AllowedOriginsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AllowedOriginsResponse]()


