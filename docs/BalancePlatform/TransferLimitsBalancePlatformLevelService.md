## Adyen.BalancePlatform.Services.TransferLimitsBalancePlatformLevelService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    ITransferLimitsBalancePlatformLevelService transferLimitsBalancePlatformLevelService = host.Services.GetRequiredService<ITransferLimitsBalancePlatformLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransferLimit**](TransferLimitsBalancePlatformLevelService.md#createtransferlimit) | **POST** /balancePlatforms/{id}/transferLimits | Create a transfer limit |
| [**DeletePendingTransferLimit**](TransferLimitsBalancePlatformLevelService.md#deletependingtransferlimit) | **DELETE** /balancePlatforms/{id}/transferLimits/{transferLimitId} | Delete a scheduled or pending transfer limit |
| [**GetSpecificTransferLimit**](TransferLimitsBalancePlatformLevelService.md#getspecifictransferlimit) | **GET** /balancePlatforms/{id}/transferLimits/{transferLimitId} | Get the details of a transfer limit |
| [**GetTransferLimits**](TransferLimitsBalancePlatformLevelService.md#gettransferlimits) | **GET** /balancePlatforms/{id}/transferLimits | Filter and view the transfer limits |

<a id="createtransferlimit"></a>
### **POST** **/balancePlatforms/{id}/transferLimits**

Create a transfer limit

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |
| **createTransferLimitRequest** | **CreateTransferLimitRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalancePlatformLevelService.CreateTransferLimit` usage:
// Provide the following values: id, createTransferLimitRequest
ITransferLimit response = await transferLimitsBalancePlatformLevelService.CreateTransferLimitAsync(
    string id, CreateTransferLimitRequest createTransferLimitRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferLimit result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferLimit]()


<a id="deletependingtransferlimit"></a>
### **DELETE** **/balancePlatforms/{id}/transferLimits/{transferLimitId}**

Delete a scheduled or pending transfer limit

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |
| **transferLimitId** | [string] | The unique identifier of the transfer limit. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalancePlatformLevelService.DeletePendingTransferLimit` usage:
// Provide the following values: id, transferLimitId
await transferLimitsBalancePlatformLevelService.DeletePendingTransferLimitAsync(
    string id, string transferLimitId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getspecifictransferlimit"></a>
### **GET** **/balancePlatforms/{id}/transferLimits/{transferLimitId}**

Get the details of a transfer limit

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |
| **transferLimitId** | [string] | The unique identifier of the transfer limit. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalancePlatformLevelService.GetSpecificTransferLimit` usage:
// Provide the following values: id, transferLimitId
ITransferLimit response = await transferLimitsBalancePlatformLevelService.GetSpecificTransferLimitAsync(
    string id, string transferLimitId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferLimit result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferLimit]()


<a id="gettransferlimits"></a>
### **GET** **/balancePlatforms/{id}/transferLimits**

Filter and view the transfer limits

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |
| **scope** | [Scope] | The scope to which the transfer limit applies. Possible values: * **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform. * **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| **transferType** | [TransferType] | The type of transfer to which the limit applies. Possible values: * **instant**: the limit applies to transfers with an **instant** priority. * **all**: the limit applies to all transfers, regardless of priority. |
| **status** | [LimitStatus] | The status of the transfer limit. Possible values:    * **active**: the limit is currently active. * **inactive**: the limit is currently inactive. * **pendingSCA**: the limit is pending until your user performs SCA. * **scheduled**: the limit is scheduled to become active at a future date. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalancePlatformLevelService.GetTransferLimits` usage:
// Provide the following values: id, scope, transferType, status
ITransferLimitListResponse response = await transferLimitsBalancePlatformLevelService.GetTransferLimitsAsync(
    string id, Option<Scope> scope = default, Option<TransferType> transferType = default, Option<LimitStatus> status = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferLimitListResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferLimitListResponse]()


