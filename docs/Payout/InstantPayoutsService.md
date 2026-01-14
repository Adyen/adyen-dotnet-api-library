## Adyen.Payout.Services.InstantPayoutsService

#### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payout/v68**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Payout.Extensions;
using Adyen.Payout.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigurePayout((context, services, config) =>
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
    IInstantPayoutsService instantPayoutsService = host.Services.GetRequiredService<IInstantPayoutsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Payout**](InstantPayoutsService.md#payout) | **POST** /payout | Make an instant card payout |

<a id="payout"></a>
### **POST** **/payout**

Make an instant card payout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **payoutRequest** | **PayoutRequest** |  |

#### Example usage

```csharp
using Adyen.Payout.Models;
using Adyen.Payout.Services;

// Example `InstantPayoutsService.Payout` usage:
// Provide the following values: payoutRequest
IPayoutResponse response = await instantPayoutsService.PayoutAsync(
    PayoutRequest payoutRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PayoutResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PayoutResponse]()


