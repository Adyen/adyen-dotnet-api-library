## Adyen.Capital.Services.GrantAccountsService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/capital/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Capital.Extensions;
using Adyen.Capital.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureCapital((context, services, config) =>
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
| [**GetGrantAccountInformation**](GrantAccountsService.md#getgrantaccountinformation) | **GET** /grantAccounts/{id} | Get the information of your grant account |

<a id="getgrantaccountinformation"></a>
### **GET** **/grantAccounts/{id}**

Get the information of your grant account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the grant account. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantAccountsService.GetGrantAccountInformation` usage:
// Provide the following values: id
IGrantAccount response = await grantAccountsService.GetGrantAccountInformationAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GrantAccount result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GrantAccount]()


