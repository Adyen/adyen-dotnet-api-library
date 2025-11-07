## Adyen.Payment.Services.ModificationsService

#### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payment/v68**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Payment.Extensions;
using Adyen.Payment.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigurePayment((context, services, config) =>
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
    IModificationsService modificationsService = host.Services.GetRequiredService<IModificationsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustAuthorisation**](ModificationsService.md#adjustauthorisation) | **POST** /adjustAuthorisation | Change the authorised amount |
| [**Cancel**](ModificationsService.md#cancel) | **POST** /cancel | Cancel an authorisation |
| [**CancelOrRefund**](ModificationsService.md#cancelorrefund) | **POST** /cancelOrRefund | Cancel or refund a payment |
| [**Capture**](ModificationsService.md#capture) | **POST** /capture | Capture an authorisation |
| [**Donate**](ModificationsService.md#donate) | **POST** /donate | Create a donation |
| [**Refund**](ModificationsService.md#refund) | **POST** /refund | Refund a captured payment |
| [**TechnicalCancel**](ModificationsService.md#technicalcancel) | **POST** /technicalCancel | Cancel an authorisation using your reference |
| [**VoidPendingRefund**](ModificationsService.md#voidpendingrefund) | **POST** /voidPendingRefund | Cancel an in-person refund |

<a id="adjustauthorisation"></a>
### **POST** **/adjustAuthorisation**

Change the authorised amount

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **adjustAuthorisationRequest** | **AdjustAuthorisationRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.AdjustAuthorisation` usage:
// Provide the following values: adjustAuthorisationRequest.
IModificationResult response = await modificationsService.AdjustAuthorisationAsync(
    AdjustAuthorisationRequest adjustAuthorisationRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="cancel"></a>
### **POST** **/cancel**

Cancel an authorisation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **cancelRequest** | **CancelRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.Cancel` usage:
// Provide the following values: cancelRequest.
IModificationResult response = await modificationsService.CancelAsync(
    CancelRequest cancelRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="cancelorrefund"></a>
### **POST** **/cancelOrRefund**

Cancel or refund a payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **cancelOrRefundRequest** | **CancelOrRefundRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.CancelOrRefund` usage:
// Provide the following values: cancelOrRefundRequest.
IModificationResult response = await modificationsService.CancelOrRefundAsync(
    CancelOrRefundRequest cancelOrRefundRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="capture"></a>
### **POST** **/capture**

Capture an authorisation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **captureRequest** | **CaptureRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.Capture` usage:
// Provide the following values: captureRequest.
IModificationResult response = await modificationsService.CaptureAsync(
    CaptureRequest captureRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="donate"></a>
### **POST** **/donate**

Create a donation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **donationRequest** | **DonationRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.Donate` usage:
// Provide the following values: donationRequest.
IModificationResult response = await modificationsService.DonateAsync(
    DonationRequest donationRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="refund"></a>
### **POST** **/refund**

Refund a captured payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **refundRequest** | **RefundRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.Refund` usage:
// Provide the following values: refundRequest.
IModificationResult response = await modificationsService.RefundAsync(
    RefundRequest refundRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="technicalcancel"></a>
### **POST** **/technicalCancel**

Cancel an authorisation using your reference

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **technicalCancelRequest** | **TechnicalCancelRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.TechnicalCancel` usage:
// Provide the following values: technicalCancelRequest.
IModificationResult response = await modificationsService.TechnicalCancelAsync(
    TechnicalCancelRequest technicalCancelRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


<a id="voidpendingrefund"></a>
### **POST** **/voidPendingRefund**

Cancel an in-person refund

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **voidPendingRefundRequest** | **VoidPendingRefundRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `ModificationsService.VoidPendingRefund` usage:
// Provide the following values: voidPendingRefundRequest.
IModificationResult response = await modificationsService.VoidPendingRefundAsync(
    VoidPendingRefundRequest voidPendingRefundRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ModificationResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ModificationResult]()


