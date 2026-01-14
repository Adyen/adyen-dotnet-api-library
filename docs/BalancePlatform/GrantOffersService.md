## Adyen.BalancePlatform.Services.GrantOffersService

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
    IGrantOffersService grantOffersService = host.Services.GetRequiredService<IGrantOffersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllAvailableGrantOffers**](GrantOffersService.md#getallavailablegrantoffers) | **GET** /grantOffers | Get all available grant offers |
| [**GetGrantOffer**](GrantOffersService.md#getgrantoffer) | **GET** /grantOffers/{grantOfferId} | Get a grant offer |

<a id="getallavailablegrantoffers"></a>
### **GET** **/grantOffers**

Get all available grant offers

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **accountHolderId** | [string] | The unique identifier of the grant account. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `GrantOffersService.GetAllAvailableGrantOffers` usage:
// Provide the following values: accountHolderId
IGrantOffers response = await grantOffersService.GetAllAvailableGrantOffersAsync(
    string accountHolderId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GrantOffers result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GrantOffers]()


<a id="getgrantoffer"></a>
### **GET** **/grantOffers/{grantOfferId}**

Get a grant offer

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantOfferId** | [string] | The unique identifier of the grant offer. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `GrantOffersService.GetGrantOffer` usage:
// Provide the following values: grantOfferId
IGrantOffer response = await grantOffersService.GetGrantOfferAsync(
    string grantOfferId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GrantOffer result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GrantOffer]()


