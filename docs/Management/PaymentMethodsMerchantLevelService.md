## Adyen.Management.Services.PaymentMethodsMerchantLevelService

#### API Base-Path: **https://management-test.adyen.com/v3**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureManagement((context, services, config) =>
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
    IPaymentMethodsMerchantLevelService paymentMethodsMerchantLevelService = host.Services.GetRequiredService<IPaymentMethodsMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddApplePayDomain**](PaymentMethodsMerchantLevelService.md#addapplepaydomain) | **POST** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains | Add an Apple Pay domain |
| [**GetAllPaymentMethods**](PaymentMethodsMerchantLevelService.md#getallpaymentmethods) | **GET** /merchants/{merchantId}/paymentMethodSettings | Get all payment methods |
| [**GetApplePayDomains**](PaymentMethodsMerchantLevelService.md#getapplepaydomains) | **GET** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains | Get Apple Pay domains |
| [**GetPaymentMethodDetails**](PaymentMethodsMerchantLevelService.md#getpaymentmethoddetails) | **GET** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId} | Get payment method details |
| [**RequestPaymentMethod**](PaymentMethodsMerchantLevelService.md#requestpaymentmethod) | **POST** /merchants/{merchantId}/paymentMethodSettings | Request a payment method |
| [**UpdatePaymentMethod**](PaymentMethodsMerchantLevelService.md#updatepaymentmethod) | **PATCH** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId} | Update a payment method |

<a id="addapplepaydomain"></a>
### **POST** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains**

Add an Apple Pay domain

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **paymentMethodId** | [string] | The unique identifier of the payment method. |
| **applePayInfo** | **ApplePayInfo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PaymentMethodsMerchantLevelService.AddApplePayDomain` usage:
// Provide the following values: merchantId, paymentMethodId, applePayInfo
await paymentMethodsMerchantLevelService.AddApplePayDomainAsync(
    string merchantId,
    string paymentMethodId,
    ApplePayInfo applePayInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getallpaymentmethods"></a>
### **GET** **/merchants/{merchantId}/paymentMethodSettings**

Get all payment methods

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **storeId** | [string] | The unique identifier of the store for which to return the payment methods. |
| **businessLineId** | [string] | The unique identifier of the Business Line for which to return the payment methods. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| **pageNumber** | [int] | The number of the page to fetch. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PaymentMethodsMerchantLevelService.GetAllPaymentMethods` usage:
// Provide the following values: merchantId, storeId, businessLineId, pageSize, pageNumber
IPaymentMethodResponse response = await paymentMethodsMerchantLevelService.GetAllPaymentMethodsAsync(
    string merchantId,
    string storeId,
    string businessLineId,
    int pageSize,
    int pageNumber, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentMethodResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentMethodResponse]()


<a id="getapplepaydomains"></a>
### **GET** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains**

Get Apple Pay domains

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **paymentMethodId** | [string] | The unique identifier of the payment method. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PaymentMethodsMerchantLevelService.GetApplePayDomains` usage:
// Provide the following values: merchantId, paymentMethodId
IApplePayInfo response = await paymentMethodsMerchantLevelService.GetApplePayDomainsAsync(
    string merchantId,
    string paymentMethodId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ApplePayInfo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ApplePayInfo]()


<a id="getpaymentmethoddetails"></a>
### **GET** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}**

Get payment method details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **paymentMethodId** | [string] | The unique identifier of the payment method. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PaymentMethodsMerchantLevelService.GetPaymentMethodDetails` usage:
// Provide the following values: merchantId, paymentMethodId
IPaymentMethod response = await paymentMethodsMerchantLevelService.GetPaymentMethodDetailsAsync(
    string merchantId,
    string paymentMethodId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentMethod result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentMethod]()


<a id="requestpaymentmethod"></a>
### **POST** **/merchants/{merchantId}/paymentMethodSettings**

Request a payment method

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **paymentMethodSetupInfo** | **PaymentMethodSetupInfo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PaymentMethodsMerchantLevelService.RequestPaymentMethod` usage:
// Provide the following values: merchantId, paymentMethodSetupInfo
IPaymentMethod response = await paymentMethodsMerchantLevelService.RequestPaymentMethodAsync(
    string merchantId,
    PaymentMethodSetupInfo paymentMethodSetupInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentMethod result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentMethod]()


<a id="updatepaymentmethod"></a>
### **PATCH** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}**

Update a payment method

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **paymentMethodId** | [string] | The unique identifier of the payment method. |
| **updatePaymentMethodInfo** | **UpdatePaymentMethodInfo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PaymentMethodsMerchantLevelService.UpdatePaymentMethod` usage:
// Provide the following values: merchantId, paymentMethodId, updatePaymentMethodInfo
IPaymentMethod response = await paymentMethodsMerchantLevelService.UpdatePaymentMethodAsync(
    string merchantId,
    string paymentMethodId,
    UpdatePaymentMethodInfo updatePaymentMethodInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentMethod result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentMethod]()


