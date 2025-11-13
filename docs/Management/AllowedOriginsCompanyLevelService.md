## Adyen.Management.Services.AllowedOriginsCompanyLevelService

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
    IAllowedOriginsCompanyLevelService allowedOriginsCompanyLevelService = host.Services.GetRequiredService<IAllowedOriginsCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAllowedOrigin**](AllowedOriginsCompanyLevelService.md#createallowedorigin) | **POST** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins | Create an allowed origin |
| [**DeleteAllowedOrigin**](AllowedOriginsCompanyLevelService.md#deleteallowedorigin) | **DELETE** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Delete an allowed origin |
| [**GetAllowedOrigin**](AllowedOriginsCompanyLevelService.md#getallowedorigin) | **GET** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Get an allowed origin |
| [**ListAllowedOrigins**](AllowedOriginsCompanyLevelService.md#listallowedorigins) | **GET** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins | Get a list of allowed origins |

<a id="createallowedorigin"></a>
### **POST** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Create an allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **allowedOrigin** | **AllowedOrigin** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsCompanyLevelService.CreateAllowedOrigin` usage:
// Provide the following values: companyId, apiCredentialId, allowedOrigin
IAllowedOrigin response = await allowedOriginsCompanyLevelService.CreateAllowedOriginAsync(
    string companyId,
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
### **DELETE** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Delete an allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **originId** | [string] | Unique identifier of the allowed origin. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsCompanyLevelService.DeleteAllowedOrigin` usage:
// Provide the following values: companyId, apiCredentialId, originId
await allowedOriginsCompanyLevelService.DeleteAllowedOriginAsync(
    string companyId,
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
### **GET** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Get an allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **originId** | [string] | Unique identifier of the allowed origin. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsCompanyLevelService.GetAllowedOrigin` usage:
// Provide the following values: companyId, apiCredentialId, originId
IAllowedOrigin response = await allowedOriginsCompanyLevelService.GetAllowedOriginAsync(
    string companyId,
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
### **GET** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Get a list of allowed origins

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AllowedOriginsCompanyLevelService.ListAllowedOrigins` usage:
// Provide the following values: companyId, apiCredentialId
IAllowedOriginsResponse response = await allowedOriginsCompanyLevelService.ListAllowedOriginsAsync(
    string companyId,
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


