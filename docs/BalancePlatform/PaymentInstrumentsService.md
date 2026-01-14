## Adyen.BalancePlatform.Services.PaymentInstrumentsService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    IPaymentInstrumentsService paymentInstrumentsService = host.Services.GetRequiredService<IPaymentInstrumentsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNetworkTokenProvisioningData**](PaymentInstrumentsService.md#createnetworktokenprovisioningdata) | **POST** /paymentInstruments/{id}/networkTokenActivationData | Create network token provisioning data |
| [**CreatePaymentInstrument**](PaymentInstrumentsService.md#createpaymentinstrument) | **POST** /paymentInstruments | Create a payment instrument |
| [**GetAllTransactionRulesForPaymentInstrument**](PaymentInstrumentsService.md#getalltransactionrulesforpaymentinstrument) | **GET** /paymentInstruments/{id}/transactionRules | Get all transaction rules for a payment instrument |
| [**GetNetworkTokenActivationData**](PaymentInstrumentsService.md#getnetworktokenactivationdata) | **GET** /paymentInstruments/{id}/networkTokenActivationData | Get network token activation data |
| [**GetPanOfPaymentInstrument**](PaymentInstrumentsService.md#getpanofpaymentinstrument) | **GET** /paymentInstruments/{id}/reveal | Get the PAN of a payment instrument |
| [**GetPaymentInstrument**](PaymentInstrumentsService.md#getpaymentinstrument) | **GET** /paymentInstruments/{id} | Get a payment instrument |
| [**ListNetworkTokens**](PaymentInstrumentsService.md#listnetworktokens) | **GET** /paymentInstruments/{id}/networkTokens | List network tokens |
| [**RevealDataOfPaymentInstrument**](PaymentInstrumentsService.md#revealdataofpaymentinstrument) | **POST** /paymentInstruments/reveal | Reveal the data of a payment instrument |
| [**UpdatePaymentInstrument**](PaymentInstrumentsService.md#updatepaymentinstrument) | **PATCH** /paymentInstruments/{id} | Update a payment instrument |

<a id="createnetworktokenprovisioningdata"></a>
### **POST** **/paymentInstruments/{id}/networkTokenActivationData**

Create network token provisioning data

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |
| **networkTokenActivationDataRequest** | **NetworkTokenActivationDataRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.CreateNetworkTokenProvisioningData` usage:
// Provide the following values: id, networkTokenActivationDataRequest
INetworkTokenActivationDataResponse response = await paymentInstrumentsService.CreateNetworkTokenProvisioningDataAsync(
    string id, NetworkTokenActivationDataRequest networkTokenActivationDataRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out NetworkTokenActivationDataResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[NetworkTokenActivationDataResponse]()


<a id="createpaymentinstrument"></a>
### **POST** **/paymentInstruments**

Create a payment instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentInfo** | **PaymentInstrumentInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.CreatePaymentInstrument` usage:
// Provide the following values: paymentInstrumentInfo
IPaymentInstrument response = await paymentInstrumentsService.CreatePaymentInstrumentAsync(
    PaymentInstrumentInfo paymentInstrumentInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentInstrument result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentInstrument]()


<a id="getalltransactionrulesforpaymentinstrument"></a>
### **GET** **/paymentInstruments/{id}/transactionRules**

Get all transaction rules for a payment instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.GetAllTransactionRulesForPaymentInstrument` usage:
// Provide the following values: id
ITransactionRulesResponse response = await paymentInstrumentsService.GetAllTransactionRulesForPaymentInstrumentAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRulesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRulesResponse]()


<a id="getnetworktokenactivationdata"></a>
### **GET** **/paymentInstruments/{id}/networkTokenActivationData**

Get network token activation data

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.GetNetworkTokenActivationData` usage:
// Provide the following values: id
INetworkTokenActivationDataResponse response = await paymentInstrumentsService.GetNetworkTokenActivationDataAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out NetworkTokenActivationDataResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[NetworkTokenActivationDataResponse]()


<a id="getpanofpaymentinstrument"></a>
### **GET** **/paymentInstruments/{id}/reveal**

Get the PAN of a payment instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.GetPanOfPaymentInstrument` usage:
// Provide the following values: id
IPaymentInstrumentRevealInfo response = await paymentInstrumentsService.GetPanOfPaymentInstrumentAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentInstrumentRevealInfo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentInstrumentRevealInfo]()


<a id="getpaymentinstrument"></a>
### **GET** **/paymentInstruments/{id}**

Get a payment instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.GetPaymentInstrument` usage:
// Provide the following values: id
IPaymentInstrument response = await paymentInstrumentsService.GetPaymentInstrumentAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentInstrument result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentInstrument]()


<a id="listnetworktokens"></a>
### **GET** **/paymentInstruments/{id}/networkTokens**

List network tokens

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.ListNetworkTokens` usage:
// Provide the following values: id
IListNetworkTokensResponse response = await paymentInstrumentsService.ListNetworkTokensAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListNetworkTokensResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListNetworkTokensResponse]()


<a id="revealdataofpaymentinstrument"></a>
### **POST** **/paymentInstruments/reveal**

Reveal the data of a payment instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentRevealRequest** | **PaymentInstrumentRevealRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.RevealDataOfPaymentInstrument` usage:
// Provide the following values: paymentInstrumentRevealRequest
IPaymentInstrumentRevealResponse response = await paymentInstrumentsService.RevealDataOfPaymentInstrumentAsync(
    PaymentInstrumentRevealRequest paymentInstrumentRevealRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentInstrumentRevealResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentInstrumentRevealResponse]()


<a id="updatepaymentinstrument"></a>
### **PATCH** **/paymentInstruments/{id}**

Update a payment instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument. |
| **paymentInstrumentUpdateRequest** | **PaymentInstrumentUpdateRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentsService.UpdatePaymentInstrument` usage:
// Provide the following values: id, paymentInstrumentUpdateRequest
IUpdatePaymentInstrument response = await paymentInstrumentsService.UpdatePaymentInstrumentAsync(
    string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out UpdatePaymentInstrument result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[UpdatePaymentInstrument]()


