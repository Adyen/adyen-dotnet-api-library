## Adyen.Checkout.Services.ModificationsService

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
    IModificationsService modificationsService = host.Services.GetRequiredService<IModificationsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelAuthorisedPayment**](ModificationsService.md#cancelauthorisedpayment) | **POST** /cancels | Cancel an authorised payment |
| [**CancelAuthorisedPaymentByPspReference**](ModificationsService.md#cancelauthorisedpaymentbypspreference) | **POST** /payments/{paymentPspReference}/cancels | Cancel an authorised payment |
| [**CaptureAuthorisedPayment**](ModificationsService.md#captureauthorisedpayment) | **POST** /payments/{paymentPspReference}/captures | Capture an authorised payment |
| [**RefundCapturedPayment**](ModificationsService.md#refundcapturedpayment) | **POST** /payments/{paymentPspReference}/refunds | Refund a captured payment |
| [**RefundOrCancelPayment**](ModificationsService.md#refundorcancelpayment) | **POST** /payments/{paymentPspReference}/reversals | Refund or cancel a payment |
| [**UpdateAuthorisedAmount**](ModificationsService.md#updateauthorisedamount) | **POST** /payments/{paymentPspReference}/amountUpdates | Update an authorised amount |

<a id="cancelauthorisedpayment"></a>
### **POST** **/cancels**

Cancel an authorised payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **standalonePaymentCancelRequest** | **StandalonePaymentCancelRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `ModificationsService.CancelAuthorisedPayment` usage:
// Provide the following values: idempotencyKey, standalonePaymentCancelRequest.
IStandalonePaymentCancelResponse response = await modificationsService.CancelAuthorisedPaymentAsync(
    string idempotencyKey,
    StandalonePaymentCancelRequest standalonePaymentCancelRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StandalonePaymentCancelResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StandalonePaymentCancelResponse]()


<a id="cancelauthorisedpaymentbypspreference"></a>
### **POST** **/payments/{paymentPspReference}/cancels**

Cancel an authorised payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | [string] | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to cancel.  |
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentCancelRequest** | **PaymentCancelRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `ModificationsService.CancelAuthorisedPaymentByPspReference` usage:
// Provide the following values: paymentPspReference, idempotencyKey, paymentCancelRequest.
IPaymentCancelResponse response = await modificationsService.CancelAuthorisedPaymentByPspReferenceAsync(
    string paymentPspReference,
    string idempotencyKey,
    PaymentCancelRequest paymentCancelRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentCancelResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentCancelResponse]()


<a id="captureauthorisedpayment"></a>
### **POST** **/payments/{paymentPspReference}/captures**

Capture an authorised payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | [string] | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to capture. |
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentCaptureRequest** | **PaymentCaptureRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `ModificationsService.CaptureAuthorisedPayment` usage:
// Provide the following values: paymentPspReference, idempotencyKey, paymentCaptureRequest.
IPaymentCaptureResponse response = await modificationsService.CaptureAuthorisedPaymentAsync(
    string paymentPspReference,
    string idempotencyKey,
    PaymentCaptureRequest paymentCaptureRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentCaptureResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentCaptureResponse]()


<a id="refundcapturedpayment"></a>
### **POST** **/payments/{paymentPspReference}/refunds**

Refund a captured payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | [string] | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to refund. |
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentRefundRequest** | **PaymentRefundRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `ModificationsService.RefundCapturedPayment` usage:
// Provide the following values: paymentPspReference, idempotencyKey, paymentRefundRequest.
IPaymentRefundResponse response = await modificationsService.RefundCapturedPaymentAsync(
    string paymentPspReference,
    string idempotencyKey,
    PaymentRefundRequest paymentRefundRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentRefundResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentRefundResponse]()


<a id="refundorcancelpayment"></a>
### **POST** **/payments/{paymentPspReference}/reversals**

Refund or cancel a payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | [string] | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to reverse.  |
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentReversalRequest** | **PaymentReversalRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `ModificationsService.RefundOrCancelPayment` usage:
// Provide the following values: paymentPspReference, idempotencyKey, paymentReversalRequest.
IPaymentReversalResponse response = await modificationsService.RefundOrCancelPaymentAsync(
    string paymentPspReference,
    string idempotencyKey,
    PaymentReversalRequest paymentReversalRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentReversalResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentReversalResponse]()


<a id="updateauthorisedamount"></a>
### **POST** **/payments/{paymentPspReference}/amountUpdates**

Update an authorised amount

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | [string] | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment. |
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentAmountUpdateRequest** | **PaymentAmountUpdateRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `ModificationsService.UpdateAuthorisedAmount` usage:
// Provide the following values: paymentPspReference, idempotencyKey, paymentAmountUpdateRequest.
IPaymentAmountUpdateResponse response = await modificationsService.UpdateAuthorisedAmountAsync(
    string paymentPspReference,
    string idempotencyKey,
    PaymentAmountUpdateRequest paymentAmountUpdateRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentAmountUpdateResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentAmountUpdateResponse]()


