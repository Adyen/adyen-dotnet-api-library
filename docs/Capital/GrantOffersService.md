## Adyen.Capital.Services.GrantOffersService

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
    IGrantOffersService grantOffersService = host.Services.GetRequiredService<IGrantOffersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllGrantOffers**](GrantOffersService.md#getallgrantoffers) | **GET** /grantOffers | Get all available grant offers |
| [**GetGrantOffer**](GrantOffersService.md#getgrantoffer) | **GET** /grantOffers/{id} | Get the details of a grant offer |

<a id="getallgrantoffers"></a>
### **GET** **/grantOffers**

Get all available grant offers

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **accountHolderId** | [string] | The unique identifier of the account holder for which you want to get the available grant offers. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantOffersService.GetAllGrantOffers` usage:
// Provide the following values: accountHolderId
IGrantOffers response = await grantOffersService.GetAllGrantOffersAsync(
    Option<string> accountHolderId = default, 
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
### **GET** **/grantOffers/{id}**

Get the details of a grant offer

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the grant offer. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantOffersService.GetGrantOffer` usage:
// Provide the following values: id
IGrantOffer response = await grantOffersService.GetGrantOfferAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GrantOffer result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GrantOffer]()


