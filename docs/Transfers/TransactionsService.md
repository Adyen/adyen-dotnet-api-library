## Adyen.Transfers.Services.TransactionsService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/btl/v4**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Transfers.Extensions;
using Adyen.Transfers.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureTransfers((context, services, config) =>
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
    ITransactionsService transactionsService = host.Services.GetRequiredService<ITransactionsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllTransactions**](TransactionsService.md#getalltransactions) | **GET** /transactions | Get all transactions |
| [**GetTransaction**](TransactionsService.md#gettransaction) | **GET** /transactions/{id} | Get a transaction |

<a id="getalltransactions"></a>
### **GET** **/transactions**

Get all transactions

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createdSince** | [DateTimeOffset] | Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **createdUntil** | [DateTimeOffset] | Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **balancePlatform** | [string] | The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60;. |
| **paymentInstrumentId** | [string] | The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).  To use this parameter, you must also provide a &#x60;balanceAccountId&#x60;, &#x60;accountHolderId&#x60;, or &#x60;balancePlatform&#x60;.  The &#x60;paymentInstrumentId&#x60; must be related to the &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60; that you provide. |
| **accountHolderId** | [string] | The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;balancePlatform&#x60;.  If you provide a &#x60;balanceAccountId&#x60;, the &#x60;accountHolderId&#x60; must be related to the &#x60;balanceAccountId&#x60;. |
| **balanceAccountId** | [string] | The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).  Required if you don&#39;t provide an &#x60;accountHolderId&#x60; or &#x60;balancePlatform&#x60;.  If you provide an &#x60;accountHolderId&#x60;, the &#x60;balanceAccountId&#x60; must be related to the &#x60;accountHolderId&#x60;. |
| **cursor** | [string] | The &#x60;cursor&#x60; returned in the links of the previous response. |
| **sortOrder** | [string] | Determines the sort order of the returned transactions. The sort order is based on the creation date of the transaction.  Possible values:   - **asc**: Ascending order, from oldest to most recent.  - **desc**: Descending order, from most recent to oldest.  Default value: **asc**. |
| **limit** | [int] | The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page. |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransactionsService.GetAllTransactions` usage:
// Provide the following values: createdSince, createdUntil, balancePlatform, paymentInstrumentId, accountHolderId, balanceAccountId, cursor, sortOrder, limit
ITransactionSearchResponse response = await transactionsService.GetAllTransactionsAsync(
    DateTimeOffset createdSince,
    DateTimeOffset createdUntil,
    string balancePlatform,
    string paymentInstrumentId,
    string accountHolderId,
    string balanceAccountId,
    string cursor,
    string sortOrder,
    int limit, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionSearchResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionSearchResponse]()


<a id="gettransaction"></a>
### **GET** **/transactions/{id}**

Get a transaction

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the transaction. |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransactionsService.GetTransaction` usage:
// Provide the following values: id
ITransaction response = await transactionsService.GetTransactionAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Transaction result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Transaction]()


