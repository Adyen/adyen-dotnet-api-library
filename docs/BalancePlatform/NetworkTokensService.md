## Adyen.BalancePlatform.Services.NetworkTokensService

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
    INetworkTokensService networkTokensService = host.Services.GetRequiredService<INetworkTokensService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetNetworkToken**](NetworkTokensService.md#getnetworktoken) | **GET** /networkTokens/{networkTokenId} | Get a network token |
| [**UpdateNetworkToken**](NetworkTokensService.md#updatenetworktoken) | **PATCH** /networkTokens/{networkTokenId} | Update a network token |

<a id="getnetworktoken"></a>
### **GET** **/networkTokens/{networkTokenId}**

Get a network token

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **networkTokenId** | [string] | The unique identifier of the network token. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `NetworkTokensService.GetNetworkToken` usage:
// Provide the following values: networkTokenId.
IGetNetworkTokenResponse response = await networkTokensService.GetNetworkTokenAsync(
    string networkTokenId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetNetworkTokenResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetNetworkTokenResponse]()


<a id="updatenetworktoken"></a>
### **PATCH** **/networkTokens/{networkTokenId}**

Update a network token

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **networkTokenId** | [string] | The unique identifier of the network token. |
| **updateNetworkTokenRequest** | **UpdateNetworkTokenRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `NetworkTokensService.UpdateNetworkToken` usage:
// Provide the following values: networkTokenId, updateNetworkTokenRequest.
I response = await networkTokensService.UpdateNetworkTokenAsync(
    string networkTokenId,
    UpdateNetworkTokenRequest updateNetworkTokenRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


