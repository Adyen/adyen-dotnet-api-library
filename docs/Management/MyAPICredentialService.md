## Adyen.Management.Services.MyAPICredentialService

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
    IMyAPICredentialService myAPICredentialService = host.Services.GetRequiredService<IMyAPICredentialService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAllowedOrigin**](MyAPICredentialService.md#addallowedorigin) | **POST** /me/allowedOrigins | Add allowed origin |
| [**GenerateClientKey**](MyAPICredentialService.md#generateclientkey) | **POST** /me/generateClientKey | Generate a client key |
| [**GetAllowedOriginDetails**](MyAPICredentialService.md#getallowedorigindetails) | **GET** /me/allowedOrigins/{originId} | Get allowed origin details |
| [**GetAllowedOrigins**](MyAPICredentialService.md#getallowedorigins) | **GET** /me/allowedOrigins | Get allowed origins |
| [**GetApiCredentialDetails**](MyAPICredentialService.md#getapicredentialdetails) | **GET** /me | Get API credential details |
| [**RemoveAllowedOrigin**](MyAPICredentialService.md#removeallowedorigin) | **DELETE** /me/allowedOrigins/{originId} | Remove allowed origin |

<a id="addallowedorigin"></a>
### **POST** **/me/allowedOrigins**

Add allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createAllowedOriginRequest** | **CreateAllowedOriginRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `MyAPICredentialService.AddAllowedOrigin` usage:
// Provide the following values: createAllowedOriginRequest.
IAllowedOrigin response = await myAPICredentialService.AddAllowedOriginAsync(
    CreateAllowedOriginRequest createAllowedOriginRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AllowedOrigin result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AllowedOrigin]()


<a id="generateclientkey"></a>
### **POST** **/me/generateClientKey**

Generate a client key

#### Parameters
This endpoint does not need any parameter.
#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `MyAPICredentialService.GenerateClientKey` usage:
// Provide the following values: .
IGenerateClientKeyResponse response = await myAPICredentialService.GenerateClientKeyAsync(
    , 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GenerateClientKeyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GenerateClientKeyResponse]()


<a id="getallowedorigindetails"></a>
### **GET** **/me/allowedOrigins/{originId}**

Get allowed origin details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **originId** | [string] | Unique identifier of the allowed origin. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `MyAPICredentialService.GetAllowedOriginDetails` usage:
// Provide the following values: originId.
IAllowedOrigin response = await myAPICredentialService.GetAllowedOriginDetailsAsync(
    string originId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AllowedOrigin result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AllowedOrigin]()


<a id="getallowedorigins"></a>
### **GET** **/me/allowedOrigins**

Get allowed origins

#### Parameters
This endpoint does not need any parameter.
#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `MyAPICredentialService.GetAllowedOrigins` usage:
// Provide the following values: .
IAllowedOriginsResponse response = await myAPICredentialService.GetAllowedOriginsAsync(
    , 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AllowedOriginsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AllowedOriginsResponse]()


<a id="getapicredentialdetails"></a>
### **GET** **/me**

Get API credential details

#### Parameters
This endpoint does not need any parameter.
#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `MyAPICredentialService.GetApiCredentialDetails` usage:
// Provide the following values: .
IMeApiCredential response = await myAPICredentialService.GetApiCredentialDetailsAsync(
    , 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out MeApiCredential result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[MeApiCredential]()


<a id="removeallowedorigin"></a>
### **DELETE** **/me/allowedOrigins/{originId}**

Remove allowed origin

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **originId** | [string] | Unique identifier of the allowed origin. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `MyAPICredentialService.RemoveAllowedOrigin` usage:
// Provide the following values: originId.
I response = await myAPICredentialService.RemoveAllowedOriginAsync(
    string originId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


