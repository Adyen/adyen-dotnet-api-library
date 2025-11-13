## Adyen.Checkout.Services.PaymentsService

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
    IPaymentsService paymentsService = host.Services.GetRequiredService<IPaymentsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CardDetails**](PaymentsService.md#carddetails) | **POST** /cardDetails | Get the brands and other details of a card |
| [**GetResultOfPaymentSession**](PaymentsService.md#getresultofpaymentsession) | **GET** /sessions/{sessionId} | Get the result of a payment session |
| [**PaymentMethods**](PaymentsService.md#paymentmethods) | **POST** /paymentMethods | Get a list of available payment methods |
| [**Payments**](PaymentsService.md#payments) | **POST** /payments | Start a transaction |
| [**PaymentsDetails**](PaymentsService.md#paymentsdetails) | **POST** /payments/details | Submit details for a payment |
| [**Sessions**](PaymentsService.md#sessions) | **POST** /sessions | Create a payment session |

<a id="carddetails"></a>
### **POST** **/cardDetails**

Get the brands and other details of a card

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **cardDetailsRequest** | **CardDetailsRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentsService.CardDetails` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, cardDetailsRequest
ICardDetailsResponse response = await paymentsService.CardDetailsAsync(
    CardDetailsRequest cardDetailsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CardDetailsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CardDetailsResponse]()


<a id="getresultofpaymentsession"></a>
### **GET** **/sessions/{sessionId}**

Get the result of a payment session

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **sessionId** | [string] | A unique identifier of the session. |
| **sessionResult** | [string] | The &#x60;sessionResult&#x60; value from the Drop-in or Component. |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentsService.GetResultOfPaymentSession` usage:
// Provide the following values: sessionId, sessionResult
ISessionResultResponse response = await paymentsService.GetResultOfPaymentSessionAsync(
    string sessionId,
    string sessionResult, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SessionResultResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SessionResultResponse]()


<a id="paymentmethods"></a>
### **POST** **/paymentMethods**

Get a list of available payment methods

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentMethodsRequest** | **PaymentMethodsRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentsService.PaymentMethods` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, paymentMethodsRequest
IPaymentMethodsResponse response = await paymentsService.PaymentMethodsAsync(
    PaymentMethodsRequest paymentMethodsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentMethodsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentMethodsResponse]()


<a id="payments"></a>
### **POST** **/payments**

Start a transaction

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentRequest** | **PaymentRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentsService.Payments` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, paymentRequest
IPaymentResponse response = await paymentsService.PaymentsAsync(
    PaymentRequest paymentRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentResponse]()


<a id="paymentsdetails"></a>
### **POST** **/payments/details**

Submit details for a payment

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentDetailsRequest** | **PaymentDetailsRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentsService.PaymentsDetails` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, paymentDetailsRequest
IPaymentDetailsResponse response = await paymentsService.PaymentsDetailsAsync(
    PaymentDetailsRequest paymentDetailsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentDetailsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentDetailsResponse]()


<a id="sessions"></a>
### **POST** **/sessions**

Create a payment session

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **createCheckoutSessionRequest** | **CreateCheckoutSessionRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `PaymentsService.Sessions` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, createCheckoutSessionRequest
ICreateCheckoutSessionResponse response = await paymentsService.SessionsAsync(
    CreateCheckoutSessionRequest createCheckoutSessionRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateCheckoutSessionResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateCheckoutSessionResponse]()


