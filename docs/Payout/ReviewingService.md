## Adyen.Payout.Services.ReviewingService

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
    IReviewingService reviewingService = host.Services.GetRequiredService<IReviewingService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfirmThirdParty**](ReviewingService.md#confirmthirdparty) | **POST** /confirmThirdParty | Confirm a payout |
| [**DeclineThirdParty**](ReviewingService.md#declinethirdparty) | **POST** /declineThirdParty | Cancel a payout |

<a id="confirmthirdparty"></a>
### **POST** **/confirmThirdParty**

Confirm a payout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **modifyRequest** | **ModifyRequest** |  |

#### Example usage

```csharp
using Adyen.Payout.Models;
using Adyen.Payout.Services;

// Example `ReviewingService.ConfirmThirdParty` usage:
// Provide the following values: modifyRequest
IModifyResponse response = await reviewingService.ConfirmThirdPartyAsync(
    ModifyRequest modifyRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModifyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModifyResponse]()


<a id="declinethirdparty"></a>
### **POST** **/declineThirdParty**

Cancel a payout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **modifyRequest** | **ModifyRequest** |  |

#### Example usage

```csharp
using Adyen.Payout.Models;
using Adyen.Payout.Services;

// Example `ReviewingService.DeclineThirdParty` usage:
// Provide the following values: modifyRequest
IModifyResponse response = await reviewingService.DeclineThirdPartyAsync(
    ModifyRequest modifyRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModifyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModifyResponse]()


