## Adyen.BalancePlatform.Services.BalanceAccountsService

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
    IBalanceAccountsService balanceAccountsService = host.Services.GetRequiredService<IBalanceAccountsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBalanceAccount**](BalanceAccountsService.md#createbalanceaccount) | **POST** /balanceAccounts | Create a balance account |
| [**CreateSweep**](BalanceAccountsService.md#createsweep) | **POST** /balanceAccounts/{balanceAccountId}/sweeps | Create a sweep |
| [**DeleteSweep**](BalanceAccountsService.md#deletesweep) | **DELETE** /balanceAccounts/{balanceAccountId}/sweeps/{sweepId} | Delete a sweep |
| [**GetAllSweepsForBalanceAccount**](BalanceAccountsService.md#getallsweepsforbalanceaccount) | **GET** /balanceAccounts/{balanceAccountId}/sweeps | Get all sweeps for a balance account |
| [**GetAllTransactionRulesForBalanceAccount**](BalanceAccountsService.md#getalltransactionrulesforbalanceaccount) | **GET** /balanceAccounts/{id}/transactionRules | Get all transaction rules for a balance account |
| [**GetBalanceAccount**](BalanceAccountsService.md#getbalanceaccount) | **GET** /balanceAccounts/{id} | Get a balance account |
| [**GetPaymentInstrumentsLinkedToBalanceAccount**](BalanceAccountsService.md#getpaymentinstrumentslinkedtobalanceaccount) | **GET** /balanceAccounts/{id}/paymentInstruments | Get payment instruments linked to a balance account |
| [**GetSweep**](BalanceAccountsService.md#getsweep) | **GET** /balanceAccounts/{balanceAccountId}/sweeps/{sweepId} | Get a sweep |
| [**UpdateBalanceAccount**](BalanceAccountsService.md#updatebalanceaccount) | **PATCH** /balanceAccounts/{id} | Update a balance account |
| [**UpdateSweep**](BalanceAccountsService.md#updatesweep) | **PATCH** /balanceAccounts/{balanceAccountId}/sweeps/{sweepId} | Update a sweep |

<a id="createbalanceaccount"></a>
### **POST** **/balanceAccounts**

Create a balance account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountInfo** | **BalanceAccountInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.CreateBalanceAccount` usage:
// Provide the following values: balanceAccountInfo.
IBalanceAccount response = await balanceAccountsService.CreateBalanceAccountAsync(
    BalanceAccountInfo balanceAccountInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalanceAccount result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalanceAccount]()


<a id="createsweep"></a>
### **POST** **/balanceAccounts/{balanceAccountId}/sweeps**

Create a sweep

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | [string] | The unique identifier of the balance account. |
| **createSweepConfigurationV2** | **CreateSweepConfigurationV2** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.CreateSweep` usage:
// Provide the following values: balanceAccountId, createSweepConfigurationV2.
ISweepConfigurationV2 response = await balanceAccountsService.CreateSweepAsync(
    string balanceAccountId,
    CreateSweepConfigurationV2 createSweepConfigurationV2, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SweepConfigurationV2 result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SweepConfigurationV2]()


<a id="deletesweep"></a>
### **DELETE** **/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}**

Delete a sweep

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | [string] | The unique identifier of the balance account. |
| **sweepId** | [string] | The unique identifier of the sweep. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.DeleteSweep` usage:
// Provide the following values: balanceAccountId, sweepId.
I response = await balanceAccountsService.DeleteSweepAsync(
    string balanceAccountId,
    string sweepId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getallsweepsforbalanceaccount"></a>
### **GET** **/balanceAccounts/{balanceAccountId}/sweeps**

Get all sweeps for a balance account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | [string] | The unique identifier of the balance account. |
| **offset** | [int] | The number of items that you want to skip. |
| **limit** | [int] | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.GetAllSweepsForBalanceAccount` usage:
// Provide the following values: balanceAccountId, offset, limit.
IBalanceSweepConfigurationsResponse response = await balanceAccountsService.GetAllSweepsForBalanceAccountAsync(
    string balanceAccountId,
    int offset,
    int limit, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalanceSweepConfigurationsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalanceSweepConfigurationsResponse]()


<a id="getalltransactionrulesforbalanceaccount"></a>
### **GET** **/balanceAccounts/{id}/transactionRules**

Get all transaction rules for a balance account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.GetAllTransactionRulesForBalanceAccount` usage:
// Provide the following values: id.
ITransactionRulesResponse response = await balanceAccountsService.GetAllTransactionRulesForBalanceAccountAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRulesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRulesResponse]()


<a id="getbalanceaccount"></a>
### **GET** **/balanceAccounts/{id}**

Get a balance account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.GetBalanceAccount` usage:
// Provide the following values: id.
IBalanceAccount response = await balanceAccountsService.GetBalanceAccountAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalanceAccount result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalanceAccount]()


<a id="getpaymentinstrumentslinkedtobalanceaccount"></a>
### **GET** **/balanceAccounts/{id}/paymentInstruments**

Get payment instruments linked to a balance account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **offset** | [int] | The number of items that you want to skip. |
| **limit** | [int] | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |
| **status** | [string] | The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.GetPaymentInstrumentsLinkedToBalanceAccount` usage:
// Provide the following values: id, offset, limit, status.
IPaginatedPaymentInstrumentsResponse response = await balanceAccountsService.GetPaymentInstrumentsLinkedToBalanceAccountAsync(
    string id,
    int offset,
    int limit,
    string status, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaginatedPaymentInstrumentsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaginatedPaymentInstrumentsResponse]()


<a id="getsweep"></a>
### **GET** **/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}**

Get a sweep

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | [string] | The unique identifier of the balance account. |
| **sweepId** | [string] | The unique identifier of the sweep. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.GetSweep` usage:
// Provide the following values: balanceAccountId, sweepId.
ISweepConfigurationV2 response = await balanceAccountsService.GetSweepAsync(
    string balanceAccountId,
    string sweepId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SweepConfigurationV2 result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SweepConfigurationV2]()


<a id="updatebalanceaccount"></a>
### **PATCH** **/balanceAccounts/{id}**

Update a balance account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the balance account. |
| **balanceAccountUpdateRequest** | **BalanceAccountUpdateRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.UpdateBalanceAccount` usage:
// Provide the following values: id, balanceAccountUpdateRequest.
IBalanceAccount response = await balanceAccountsService.UpdateBalanceAccountAsync(
    string id,
    BalanceAccountUpdateRequest balanceAccountUpdateRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalanceAccount result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalanceAccount]()


<a id="updatesweep"></a>
### **PATCH** **/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}**

Update a sweep

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | [string] | The unique identifier of the balance account. |
| **sweepId** | [string] | The unique identifier of the sweep. |
| **updateSweepConfigurationV2** | **UpdateSweepConfigurationV2** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalanceAccountsService.UpdateSweep` usage:
// Provide the following values: balanceAccountId, sweepId, updateSweepConfigurationV2.
ISweepConfigurationV2 response = await balanceAccountsService.UpdateSweepAsync(
    string balanceAccountId,
    string sweepId,
    UpdateSweepConfigurationV2 updateSweepConfigurationV2, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SweepConfigurationV2 result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SweepConfigurationV2]()


