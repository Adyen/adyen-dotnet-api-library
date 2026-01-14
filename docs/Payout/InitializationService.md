## Adyen.Payout.Services.InitializationService

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
    IInitializationService initializationService = host.Services.GetRequiredService<IInitializationService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StoreDetail**](InitializationService.md#storedetail) | **POST** /storeDetail | Store payout details |
| [**StoreDetailAndSubmitThirdParty**](InitializationService.md#storedetailandsubmitthirdparty) | **POST** /storeDetailAndSubmitThirdParty | Store details and submit a payout |
| [**SubmitThirdParty**](InitializationService.md#submitthirdparty) | **POST** /submitThirdParty | Submit a payout |

<a id="storedetail"></a>
### **POST** **/storeDetail**

Store payout details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeDetailRequest** | **StoreDetailRequest** |  |

#### Example usage

```csharp
using Adyen.Payout.Models;
using Adyen.Payout.Services;

// Example `InitializationService.StoreDetail` usage:
// Provide the following values: storeDetailRequest
IStoreDetailResponse response = await initializationService.StoreDetailAsync(
    StoreDetailRequest storeDetailRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoreDetailResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoreDetailResponse]()


<a id="storedetailandsubmitthirdparty"></a>
### **POST** **/storeDetailAndSubmitThirdParty**

Store details and submit a payout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeDetailAndSubmitRequest** | **StoreDetailAndSubmitRequest** |  |

#### Example usage

```csharp
using Adyen.Payout.Models;
using Adyen.Payout.Services;

// Example `InitializationService.StoreDetailAndSubmitThirdParty` usage:
// Provide the following values: storeDetailAndSubmitRequest
IStoreDetailAndSubmitResponse response = await initializationService.StoreDetailAndSubmitThirdPartyAsync(
    StoreDetailAndSubmitRequest storeDetailAndSubmitRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoreDetailAndSubmitResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoreDetailAndSubmitResponse]()


<a id="submitthirdparty"></a>
### **POST** **/submitThirdParty**

Submit a payout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **submitRequest** | **SubmitRequest** |  |

#### Example usage

```csharp
using Adyen.Payout.Models;
using Adyen.Payout.Services;

// Example `InitializationService.SubmitThirdParty` usage:
// Provide the following values: submitRequest
ISubmitResponse response = await initializationService.SubmitThirdPartyAsync(
    SubmitRequest submitRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SubmitResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SubmitResponse]()


