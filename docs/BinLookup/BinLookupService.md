## Adyen.BinLookup.Services.BinLookupService

#### API Base-Path: **https://pal-test.adyen.com/pal/servlet/BinLookup/v54**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BinLookup.Extensions;
using Adyen.BinLookup.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBinLookup((context, services, config) =>
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
    IBinLookupService binLookupService = host.Services.GetRequiredService<IBinLookupService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get3dsAvailability**](BinLookupService.md#get3dsavailability) | **POST** /get3dsAvailability | Check if 3D Secure is available |
| [**GetCostEstimate**](BinLookupService.md#getcostestimate) | **POST** /getCostEstimate | Get a fees cost estimate |

<a id="get3dsavailability"></a>
### **POST** **/get3dsAvailability**

Check if 3D Secure is available

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **threeDSAvailabilityRequest** | **ThreeDSAvailabilityRequest** |  |

#### Example usage

```csharp
using Adyen.BinLookup.Models;
using Adyen.BinLookup.Services;

// Example `BinLookupService.Get3dsAvailability` usage:
// Provide the following values: threeDSAvailabilityRequest.
IThreeDSAvailabilityResponse response = await binLookupService.Get3dsAvailabilityAsync(
    ThreeDSAvailabilityRequest threeDSAvailabilityRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ThreeDSAvailabilityResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ThreeDSAvailabilityResponse]()


<a id="getcostestimate"></a>
### **POST** **/getCostEstimate**

Get a fees cost estimate

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **costEstimateRequest** | **CostEstimateRequest** |  |

#### Example usage

```csharp
using Adyen.BinLookup.Models;
using Adyen.BinLookup.Services;

// Example `BinLookupService.GetCostEstimate` usage:
// Provide the following values: costEstimateRequest.
ICostEstimateResponse response = await binLookupService.GetCostEstimateAsync(
    CostEstimateRequest costEstimateRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CostEstimateResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CostEstimateResponse]()


