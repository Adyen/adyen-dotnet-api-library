## Adyen.Checkout.Services.RecurringService

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
    IRecurringService recurringService = host.Services.GetRequiredService<IRecurringService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTokenForStoredPaymentDetails**](RecurringService.md#deletetokenforstoredpaymentdetails) | **DELETE** /storedPaymentMethods/{storedPaymentMethodId} | Delete a token for stored payment details |
| [**GetTokensForStoredPaymentDetails**](RecurringService.md#gettokensforstoredpaymentdetails) | **GET** /storedPaymentMethods | Get tokens for stored payment details |
| [**StoredPaymentMethods**](RecurringService.md#storedpaymentmethods) | **POST** /storedPaymentMethods | Create a token to store payment details |

<a id="deletetokenforstoredpaymentdetails"></a>
### **DELETE** **/storedPaymentMethods/{storedPaymentMethodId}**

Delete a token for stored payment details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedPaymentMethodId** | [string] | The unique identifier of the token. |
| **shopperReference** | [string] | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address. |
| **merchantAccount** | [string] | Your merchant account. |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `RecurringService.DeleteTokenForStoredPaymentDetails` usage:
// Provide the following values: storedPaymentMethodId, shopperReference, merchantAccount
await recurringService.DeleteTokenForStoredPaymentDetailsAsync(
    string storedPaymentMethodId,
    string shopperReference,
    string merchantAccount, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="gettokensforstoredpaymentdetails"></a>
### **GET** **/storedPaymentMethods**

Get tokens for stored payment details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **shopperReference** | [string] | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address. |
| **merchantAccount** | [string] | Your merchant account. |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `RecurringService.GetTokensForStoredPaymentDetails` usage:
// Provide the following values: shopperReference, merchantAccount
IListStoredPaymentMethodsResponse response = await recurringService.GetTokensForStoredPaymentDetailsAsync(
    string shopperReference,
    string merchantAccount, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListStoredPaymentMethodsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListStoredPaymentMethodsResponse]()


<a id="storedpaymentmethods"></a>
### **POST** **/storedPaymentMethods**

Create a token to store payment details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **storedPaymentMethodRequest** | **StoredPaymentMethodRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `RecurringService.StoredPaymentMethods` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, storedPaymentMethodRequest
IStoredPaymentMethodResource response = await recurringService.StoredPaymentMethodsAsync(
    StoredPaymentMethodRequest storedPaymentMethodRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredPaymentMethodResource result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredPaymentMethodResource]()


