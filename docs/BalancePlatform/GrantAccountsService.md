## Adyen.BalancePlatform.Services.GrantAccountsService

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
    IGrantAccountsService grantAccountsService = host.Services.GetRequiredService<IGrantAccountsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGrantAccount**](GrantAccountsService.md#getgrantaccount) | **GET** /grantAccounts/{id} | Get a grant account |

<a id="getgrantaccount"></a>
### **GET** **/grantAccounts/{id}**

Get a grant account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the grant account. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `GrantAccountsService.GetGrantAccount` usage:
// Provide the following values: id.
ICapitalGrantAccount response = await grantAccountsService.GetGrantAccountAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CapitalGrantAccount result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CapitalGrantAccount]()


