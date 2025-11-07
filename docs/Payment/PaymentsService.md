## Adyen.Payment.Services.PaymentsService

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
    IPaymentsService paymentsService = host.Services.GetRequiredService<IPaymentsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Authorise**](PaymentsService.md#authorise) | **POST** /authorise | Create an authorisation |
| [**Authorise3d**](PaymentsService.md#authorise3d) | **POST** /authorise3d | Complete a 3DS authorisation |
| [**Authorise3ds2**](PaymentsService.md#authorise3ds2) | **POST** /authorise3ds2 | Complete a 3DS2 authorisation |
| [**GetAuthenticationResult**](PaymentsService.md#getauthenticationresult) | **POST** /getAuthenticationResult | Get the 3DS authentication result |
| [**Retrieve3ds2Result**](PaymentsService.md#retrieve3ds2result) | **POST** /retrieve3ds2Result | Get the 3DS2 authentication result |

<a id="authorise"></a>
### **POST** **/authorise**

Create an authorisation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentRequest** | **PaymentRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `PaymentsService.Authorise` usage:
// Provide the following values: paymentRequest.
IPaymentResult response = await paymentsService.AuthoriseAsync(
    PaymentRequest paymentRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentResult]()


<a id="authorise3d"></a>
### **POST** **/authorise3d**

Complete a 3DS authorisation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentRequest3d** | **PaymentRequest3d** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `PaymentsService.Authorise3d` usage:
// Provide the following values: paymentRequest3d.
IPaymentResult response = await paymentsService.Authorise3dAsync(
    PaymentRequest3d paymentRequest3d, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentResult]()


<a id="authorise3ds2"></a>
### **POST** **/authorise3ds2**

Complete a 3DS2 authorisation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentRequest3ds2** | **PaymentRequest3ds2** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `PaymentsService.Authorise3ds2` usage:
// Provide the following values: paymentRequest3ds2.
IPaymentResult response = await paymentsService.Authorise3ds2Async(
    PaymentRequest3ds2 paymentRequest3ds2, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentResult]()


<a id="getauthenticationresult"></a>
### **POST** **/getAuthenticationResult**

Get the 3DS authentication result

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **authenticationResultRequest** | **AuthenticationResultRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `PaymentsService.GetAuthenticationResult` usage:
// Provide the following values: authenticationResultRequest.
IAuthenticationResultResponse response = await paymentsService.GetAuthenticationResultAsync(
    AuthenticationResultRequest authenticationResultRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AuthenticationResultResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AuthenticationResultResponse]()


<a id="retrieve3ds2result"></a>
### **POST** **/retrieve3ds2Result**

Get the 3DS2 authentication result

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **threeDS2ResultRequest** | **ThreeDS2ResultRequest** |  |

#### Example usage

```csharp
using Adyen.Payment.Models;
using Adyen.Payment.Services;

// Example `PaymentsService.Retrieve3ds2Result` usage:
// Provide the following values: threeDS2ResultRequest.
IThreeDS2ResultResponse response = await paymentsService.Retrieve3ds2ResultAsync(
    ThreeDS2ResultRequest threeDS2ResultRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ThreeDS2ResultResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ThreeDS2ResultResponse]()


