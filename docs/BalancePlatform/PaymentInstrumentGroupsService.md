## Adyen.BalancePlatform.Services.PaymentInstrumentGroupsService

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
    IPaymentInstrumentGroupsService paymentInstrumentGroupsService = host.Services.GetRequiredService<IPaymentInstrumentGroupsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePaymentInstrumentGroup**](PaymentInstrumentGroupsService.md#createpaymentinstrumentgroup) | **POST** /paymentInstrumentGroups | Create a payment instrument group |
| [**GetAllTransactionRulesForPaymentInstrumentGroup**](PaymentInstrumentGroupsService.md#getalltransactionrulesforpaymentinstrumentgroup) | **GET** /paymentInstrumentGroups/{id}/transactionRules | Get all transaction rules for a payment instrument group |
| [**GetPaymentInstrumentGroup**](PaymentInstrumentGroupsService.md#getpaymentinstrumentgroup) | **GET** /paymentInstrumentGroups/{id} | Get a payment instrument group |

<a id="createpaymentinstrumentgroup"></a>
### **POST** **/paymentInstrumentGroups**

Create a payment instrument group

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentGroupInfo** | **PaymentInstrumentGroupInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentGroupsService.CreatePaymentInstrumentGroup` usage:
// Provide the following values: paymentInstrumentGroupInfo.
IPaymentInstrumentGroup response = await paymentInstrumentGroupsService.CreatePaymentInstrumentGroupAsync(
    PaymentInstrumentGroupInfo paymentInstrumentGroupInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentInstrumentGroup result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentInstrumentGroup]()


<a id="getalltransactionrulesforpaymentinstrumentgroup"></a>
### **GET** **/paymentInstrumentGroups/{id}/transactionRules**

Get all transaction rules for a payment instrument group

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument group. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentGroupsService.GetAllTransactionRulesForPaymentInstrumentGroup` usage:
// Provide the following values: id.
ITransactionRulesResponse response = await paymentInstrumentGroupsService.GetAllTransactionRulesForPaymentInstrumentGroupAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRulesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRulesResponse]()


<a id="getpaymentinstrumentgroup"></a>
### **GET** **/paymentInstrumentGroups/{id}**

Get a payment instrument group

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the payment instrument group. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `PaymentInstrumentGroupsService.GetPaymentInstrumentGroup` usage:
// Provide the following values: id.
IPaymentInstrumentGroup response = await paymentInstrumentGroupsService.GetPaymentInstrumentGroupAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaymentInstrumentGroup result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaymentInstrumentGroup]()


