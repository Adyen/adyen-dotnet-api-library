## Adyen.Checkout.Services.UtilityService

#### API Base-Path: **https://checkout-test.adyen.com/v71**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureCheckout((context, services, config) =>
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
    IUtilityService utilityService = host.Services.GetRequiredService<IUtilityService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetApplePaySession**](UtilityService.md#getapplepaysession) | **POST** /applePay/sessions | Get an Apple Pay session |
| [**OriginKeys**](UtilityService.md#originkeys) | **POST** /originKeys | Create originKey values for domains |
| [**UpdatesOrderForPaypalExpressCheckout**](UtilityService.md#updatesorderforpaypalexpresscheckout) | **POST** /paypal/updateOrder | Updates the order for PayPal Express Checkout |
| [**ValidateShopperId**](UtilityService.md#validateshopperid) | **POST** /validateShopperId | Validates shopper Id |

<a id="getapplepaysession"></a>
### **POST** **/applePay/sessions**

Get an Apple Pay session

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **applePaySessionRequest** | **ApplePaySessionRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `UtilityService.GetApplePaySession` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, applePaySessionRequest
IApplePaySessionResponse response = await utilityService.GetApplePaySessionAsync(
    ApplePaySessionRequest applePaySessionRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ApplePaySessionResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ApplePaySessionResponse]()


<a id="originkeys"></a>
### **POST** **/originKeys**

Create originKey values for domains

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **utilityRequest** | **UtilityRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `UtilityService.OriginKeys` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, utilityRequest
IUtilityResponse response = await utilityService.OriginKeysAsync(
    UtilityRequest utilityRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out UtilityResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[UtilityResponse]()


<a id="updatesorderforpaypalexpresscheckout"></a>
### **POST** **/paypal/updateOrder**

Updates the order for PayPal Express Checkout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paypalUpdateOrderRequest** | **PaypalUpdateOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `UtilityService.UpdatesOrderForPaypalExpressCheckout` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, paypalUpdateOrderRequest
IPaypalUpdateOrderResponse response = await utilityService.UpdatesOrderForPaypalExpressCheckoutAsync(
    PaypalUpdateOrderRequest paypalUpdateOrderRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaypalUpdateOrderResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaypalUpdateOrderResponse]()


<a id="validateshopperid"></a>
### **POST** **/validateShopperId**

Validates shopper Id

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **validateShopperIdRequest** | **ValidateShopperIdRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `UtilityService.ValidateShopperId` usage:
// Provide the following values: validateShopperIdRequest
IValidateShopperIdResponse response = await utilityService.ValidateShopperIdAsync(
    ValidateShopperIdRequest validateShopperIdRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ValidateShopperIdResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ValidateShopperIdResponse]()


