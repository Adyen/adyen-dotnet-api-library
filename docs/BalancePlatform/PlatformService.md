## Adyen.BalancePlatform.Services.PlatformService

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
    IPlatformService platformService = host.Services.GetRequiredService<IPlatformService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllAccountHoldersUnderBalancePlatform**](PlatformService.md#getallaccountholdersunderbalanceplatform) | **GET** /balancePlatforms/{id}/accountHolders | Get all account holders under a balance platform |
| [**GetAllTransactionRulesForBalancePlatform**](PlatformService.md#getalltransactionrulesforbalanceplatform) | **GET** /balancePlatforms/{id}/transactionRules | Get all transaction rules for a balance platform |
| [**GetBalancePlatform**](PlatformService.md#getbalanceplatform) | **GET** /balancePlatforms/{id} | Get a balance platform |

<a id="getallaccountholdersunderbalanceplatform"></a>
### **GET** **/balancePlatforms/{id}/accountHolders**

Get all account holders under a balance platform

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |
| **offset** | [int] | The number of items that you want to skip. |
| **limit** | [int] | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PlatformService.GetAllAccountHoldersUnderBalancePlatform` usage:
// Provide the following values: id, offset, limit
IPaginatedAccountHoldersResponse response = await platformService.GetAllAccountHoldersUnderBalancePlatformAsync(
    string id, Option<int> offset = default, Option<int> limit = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaginatedAccountHoldersResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaginatedAccountHoldersResponse]()


<a id="getalltransactionrulesforbalanceplatform"></a>
### **GET** **/balancePlatforms/{id}/transactionRules**

Get all transaction rules for a balance platform

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PlatformService.GetAllTransactionRulesForBalancePlatform` usage:
// Provide the following values: id
ITransactionRulesResponse response = await platformService.GetAllTransactionRulesForBalancePlatformAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRulesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRulesResponse]()


<a id="getbalanceplatform"></a>
### **GET** **/balancePlatforms/{id}**

Get a balance platform

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance platform. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PlatformService.GetBalancePlatform` usage:
// Provide the following values: id
IBalancePlatform response = await platformService.GetBalancePlatformAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalancePlatform result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalancePlatform]()


