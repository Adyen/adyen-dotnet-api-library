## Adyen.Checkout.Services.PaymentLinksService

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
    IPaymentLinksService paymentLinksService = host.Services.GetRequiredService<IPaymentLinksService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPaymentLink**](PaymentLinksService.md#getpaymentlink) | **GET** /paymentLinks/{linkId} | Get a payment link |
| [**PaymentLinks**](PaymentLinksService.md#paymentlinks) | **POST** /paymentLinks | Create a payment link |
| [**UpdatePaymentLink**](PaymentLinksService.md#updatepaymentlink) | **PATCH** /paymentLinks/{linkId} | Update the status of a payment link |

<a id="getpaymentlink"></a>
### **GET** **/paymentLinks/{linkId}**

Get a payment link

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **linkId** | [string] | Unique identifier of the payment link. |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentLinksService.GetPaymentLink` usage:
// Provide the following values: linkId.
IPaymentLinkResponse response = await paymentLinksService.GetPaymentLinkAsync(
    string linkId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentLinkResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentLinkResponse]()


<a id="paymentlinks"></a>
### **POST** **/paymentLinks**

Create a payment link

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentLinkRequest** | **PaymentLinkRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentLinksService.PaymentLinks` usage:
// Provide the following values: idempotencyKey, paymentLinkRequest.
IPaymentLinkResponse response = await paymentLinksService.PaymentLinksAsync(
    string idempotencyKey,
    PaymentLinkRequest paymentLinkRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentLinkResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentLinkResponse]()


<a id="updatepaymentlink"></a>
### **PATCH** **/paymentLinks/{linkId}**

Update the status of a payment link

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **linkId** | [string] | Unique identifier of the payment link. |
| **updatePaymentLinkRequest** | **UpdatePaymentLinkRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentLinksService.UpdatePaymentLink` usage:
// Provide the following values: linkId, updatePaymentLinkRequest.
IPaymentLinkResponse response = await paymentLinksService.UpdatePaymentLinkAsync(
    string linkId,
    UpdatePaymentLinkRequest updatePaymentLinkRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentLinkResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentLinkResponse]()


