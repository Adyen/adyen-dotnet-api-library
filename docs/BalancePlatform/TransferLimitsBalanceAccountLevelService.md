## Adyen.BalancePlatform.Services.TransferLimitsBalanceAccountLevelService

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
    ITransferLimitsBalanceAccountLevelService transferLimitsBalanceAccountLevelService = host.Services.GetRequiredService<ITransferLimitsBalanceAccountLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApprovePendingTransferLimits**](TransferLimitsBalanceAccountLevelService.md#approvependingtransferlimits) | **POST** /balanceAccounts/{id}/transferLimits/approve | Approve pending transfer limits |
| [**CreateTransferLimit**](TransferLimitsBalanceAccountLevelService.md#createtransferlimit) | **POST** /balanceAccounts/{id}/transferLimits | Create a transfer limit |
| [**DeletePendingTransferLimit**](TransferLimitsBalanceAccountLevelService.md#deletependingtransferlimit) | **DELETE** /balanceAccounts/{id}/transferLimits/{transferLimitId} | Delete a scheduled or pending transfer limit |
| [**GetCurrentTransferLimits**](TransferLimitsBalanceAccountLevelService.md#getcurrenttransferlimits) | **GET** /balanceAccounts/{id}/transferLimits/current | Get all current transfer limits |
| [**GetSpecificTransferLimit**](TransferLimitsBalanceAccountLevelService.md#getspecifictransferlimit) | **GET** /balanceAccounts/{id}/transferLimits/{transferLimitId} | Get the details of a transfer limit |
| [**GetTransferLimits**](TransferLimitsBalanceAccountLevelService.md#gettransferlimits) | **GET** /balanceAccounts/{id}/transferLimits | Filter and view the transfer limits |

<a id="approvependingtransferlimits"></a>
### **POST** **/balanceAccounts/{id}/transferLimits/approve**

Approve pending transfer limits

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **approveTransferLimitRequest** | **ApproveTransferLimitRequest** |  |
| **wWWAuthenticate** | [string] | Header for authenticating using SCA. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalanceAccountLevelService.ApprovePendingTransferLimits` usage:
// Provide the following values: id, approveTransferLimitRequest, [HeaderParameter] wWWAuthenticate
await transferLimitsBalanceAccountLevelService.ApprovePendingTransferLimitsAsync(
    string id,
    ApproveTransferLimitRequest approveTransferLimitRequest,
    , 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="createtransferlimit"></a>
### **POST** **/balanceAccounts/{id}/transferLimits**

Create a transfer limit

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **createTransferLimitRequest** | **CreateTransferLimitRequest** |  |
| **wWWAuthenticate** | [string] | Header for authenticating through SCA |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalanceAccountLevelService.CreateTransferLimit` usage:
// Provide the following values: id, createTransferLimitRequest, [HeaderParameter] wWWAuthenticate
ITransferLimit response = await transferLimitsBalanceAccountLevelService.CreateTransferLimitAsync(
    string id,
    CreateTransferLimitRequest createTransferLimitRequest,
    , 
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
### **DELETE** **/balanceAccounts/{id}/transferLimits/{transferLimitId}**

Delete a scheduled or pending transfer limit

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **transferLimitId** | [string] | The unique identifier of the transfer limit. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalanceAccountLevelService.DeletePendingTransferLimit` usage:
// Provide the following values: id, transferLimitId
await transferLimitsBalanceAccountLevelService.DeletePendingTransferLimitAsync(
    string id,
    string transferLimitId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getcurrenttransferlimits"></a>
### **GET** **/balanceAccounts/{id}/transferLimits/current**

Get all current transfer limits

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **scope** | [Scope] | The scope to which the transfer limit applies. Possible values: * **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform. * **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| **transferType** | [TransferType] | The type of transfer to which the limit applies. Possible values: * **instant**: the limit applies to transfers with an **instant** priority. * **all**: the limit applies to all transfers, regardless of priority. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalanceAccountLevelService.GetCurrentTransferLimits` usage:
// Provide the following values: id, scope, transferType
ITransferLimitListResponse response = await transferLimitsBalanceAccountLevelService.GetCurrentTransferLimitsAsync(
    string id,
    Scope scope,
    TransferType transferType, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferLimitListResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferLimitListResponse]()


<a id="getspecifictransferlimit"></a>
### **GET** **/balanceAccounts/{id}/transferLimits/{transferLimitId}**

Get the details of a transfer limit

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **transferLimitId** | [string] | The unique identifier of the transfer limit. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalanceAccountLevelService.GetSpecificTransferLimit` usage:
// Provide the following values: id, transferLimitId
ITransferLimit response = await transferLimitsBalanceAccountLevelService.GetSpecificTransferLimitAsync(
    string id,
    string transferLimitId, 
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
### **GET** **/balanceAccounts/{id}/transferLimits**

Filter and view the transfer limits

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **scope** | [Scope] | The scope to which the transfer limit applies. Possible values: * **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform. * **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| **transferType** | [TransferType] | The type of transfer to which the limit applies. Possible values: * **instant**: the limit applies to transfers with an **instant** priority. * **all**: the limit applies to all transfers, regardless of priority. |
| **status** | [LimitStatus] | The status of the transfer limit. Possible values:    * **active**: the limit is currently active. * **inactive**: the limit is currently inactive. * **pendingSCA**: the limit is pending until your user performs SCA. * **scheduled**: the limit is scheduled to become active at a future date. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferLimitsBalanceAccountLevelService.GetTransferLimits` usage:
// Provide the following values: id, scope, transferType, status
ITransferLimitListResponse response = await transferLimitsBalanceAccountLevelService.GetTransferLimitsAsync(
    string id,
    Scope scope,
    TransferType transferType,
    LimitStatus status, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferLimitListResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferLimitListResponse]()


