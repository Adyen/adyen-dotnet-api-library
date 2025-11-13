## Adyen.PosMobile.Services.PosMobileService

#### API Base-Path: **https://checkout-test.adyen.com/checkout/possdk/v68**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.PosMobile.Extensions;
using Adyen.PosMobile.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigurePosMobile((context, services, config) =>
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
    IPosMobileService posMobileService = host.Services.GetRequiredService<IPosMobileService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCommunicationSession**](PosMobileService.md#createcommunicationsession) | **POST** /sessions | Create a communication session |

<a id="createcommunicationsession"></a>
### **POST** **/sessions**

Create a communication session

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createSessionRequest** | **CreateSessionRequest** |  |

#### Example usage

```csharp
using Adyen.PosMobile.Models;
using Adyen.PosMobile.Services;

// Example `PosMobileService.CreateCommunicationSession` usage:
// Provide the following values: createSessionRequest
ICreateSessionResponse response = await posMobileService.CreateCommunicationSessionAsync(
    CreateSessionRequest createSessionRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateSessionResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateSessionResponse]()


