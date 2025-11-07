## Adyen.PaymentsApp.Services.PaymentsAppService

#### API Base-Path: **https://management-live.adyen.com/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.PaymentsApp.Extensions;
using Adyen.PaymentsApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigurePaymentsApp((context, services, config) =>
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
    IPaymentsAppService paymentsAppService = host.Services.GetRequiredService<IPaymentsAppService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GeneratePaymentsAppBoardingTokenForMerchant**](PaymentsAppService.md#generatepaymentsappboardingtokenformerchant) | **POST** /merchants/{merchantId}/generatePaymentsAppBoardingToken | Create a boarding token - merchant level |
| [**GeneratePaymentsAppBoardingTokenForStore**](PaymentsAppService.md#generatepaymentsappboardingtokenforstore) | **POST** /merchants/{merchantId}/stores/{storeId}/generatePaymentsAppBoardingToken | Create a boarding token - store level |
| [**ListPaymentsAppForMerchant**](PaymentsAppService.md#listpaymentsappformerchant) | **GET** /merchants/{merchantId}/paymentsApps | Get a list of Payments Apps - merchant level |
| [**ListPaymentsAppForStore**](PaymentsAppService.md#listpaymentsappforstore) | **GET** /merchants/{merchantId}/stores/{storeId}/paymentsApps | Get a list of Payments Apps - store level |
| [**RevokePaymentsApp**](PaymentsAppService.md#revokepaymentsapp) | **POST** /merchants/{merchantId}/paymentsApps/{installationId}/revoke | Revoke Payments App instance authentication |

<a id="generatepaymentsappboardingtokenformerchant"></a>
### **POST** **/merchants/{merchantId}/generatePaymentsAppBoardingToken**

Create a boarding token - merchant level

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **boardingTokenRequest** | **BoardingTokenRequest** |  |

#### Example usage

```csharp
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Services;

// Example `PaymentsAppService.GeneratePaymentsAppBoardingTokenForMerchant` usage:
// Provide the following values: merchantId, boardingTokenRequest.
IBoardingTokenResponse response = await paymentsAppService.GeneratePaymentsAppBoardingTokenForMerchantAsync(
    string merchantId,
    BoardingTokenRequest boardingTokenRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BoardingTokenResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BoardingTokenResponse]()


<a id="generatepaymentsappboardingtokenforstore"></a>
### **POST** **/merchants/{merchantId}/stores/{storeId}/generatePaymentsAppBoardingToken**

Create a boarding token - store level

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **storeId** | [string] | The unique identifier of the store. |
| **boardingTokenRequest** | **BoardingTokenRequest** |  |

#### Example usage

```csharp
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Services;

// Example `PaymentsAppService.GeneratePaymentsAppBoardingTokenForStore` usage:
// Provide the following values: merchantId, storeId, boardingTokenRequest.
IBoardingTokenResponse response = await paymentsAppService.GeneratePaymentsAppBoardingTokenForStoreAsync(
    string merchantId,
    string storeId,
    BoardingTokenRequest boardingTokenRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BoardingTokenResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BoardingTokenResponse]()


<a id="listpaymentsappformerchant"></a>
### **GET** **/merchants/{merchantId}/paymentsApps**

Get a list of Payments Apps - merchant level

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **statuses** | [string] | The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.   Possible values:  * **BOARDING**   * **BOARDED**   * **REVOKED** |
| **limit** | [int] | The number of items to return. |
| **offset** | [long] | The number of items to skip. |

#### Example usage

```csharp
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Services;

// Example `PaymentsAppService.ListPaymentsAppForMerchant` usage:
// Provide the following values: merchantId, statuses, limit, offset.
IPaymentsAppResponse response = await paymentsAppService.ListPaymentsAppForMerchantAsync(
    string merchantId,
    string statuses,
    int limit,
    long offset, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentsAppResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentsAppResponse]()


<a id="listpaymentsappforstore"></a>
### **GET** **/merchants/{merchantId}/stores/{storeId}/paymentsApps**

Get a list of Payments Apps - store level

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **storeId** | [string] | The unique identifier of the store. |
| **statuses** | [string] | The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.   Possible values:  * **BOARDING**   * **BOARDED**   * **REVOKED** |
| **limit** | [int] | The number of items to return. |
| **offset** | [long] | The number of items to skip. |

#### Example usage

```csharp
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Services;

// Example `PaymentsAppService.ListPaymentsAppForStore` usage:
// Provide the following values: merchantId, storeId, statuses, limit, offset.
IPaymentsAppResponse response = await paymentsAppService.ListPaymentsAppForStoreAsync(
    string merchantId,
    string storeId,
    string statuses,
    int limit,
    long offset, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentsAppResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentsAppResponse]()


<a id="revokepaymentsapp"></a>
### **POST** **/merchants/{merchantId}/paymentsApps/{installationId}/revoke**

Revoke Payments App instance authentication

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **installationId** | [string] | The unique identifier of the Payments App instance on a device. |

#### Example usage

```csharp
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Services;

// Example `PaymentsAppService.RevokePaymentsApp` usage:
// Provide the following values: merchantId, installationId.
I response = await paymentsAppService.RevokePaymentsAppAsync(
    string merchantId,
    string installationId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


