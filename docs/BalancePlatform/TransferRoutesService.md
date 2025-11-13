## Adyen.BalancePlatform.Services.TransferRoutesService

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
    ITransferRoutesService transferRoutesService = host.Services.GetRequiredService<ITransferRoutesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateTransferRoutes**](TransferRoutesService.md#calculatetransferroutes) | **POST** /transferRoutes/calculate | Calculate transfer routes |

<a id="calculatetransferroutes"></a>
### **POST** **/transferRoutes/calculate**

Calculate transfer routes

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transferRouteRequest** | **TransferRouteRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransferRoutesService.CalculateTransferRoutes` usage:
// Provide the following values: transferRouteRequest
ITransferRouteResponse response = await transferRoutesService.CalculateTransferRoutesAsync(
    TransferRouteRequest transferRouteRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferRouteResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferRouteResponse]()


