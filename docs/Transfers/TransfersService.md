## Adyen.Transfers.Services.TransfersService

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
    ITransfersService transfersService = host.Services.GetRequiredService<ITransfersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApproveInitiatedTransfers**](TransfersService.md#approveinitiatedtransfers) | **POST** /transfers/approve | Approve initiated transfers |
| [**CancelInitiatedTransfers**](TransfersService.md#cancelinitiatedtransfers) | **POST** /transfers/cancel | Cancel initiated transfers |
| [**GetAllTransfers**](TransfersService.md#getalltransfers) | **GET** /transfers | Get all transfers |
| [**GetTransfer**](TransfersService.md#gettransfer) | **GET** /transfers/{id} | Get a transfer |
| [**ReturnTransfer**](TransfersService.md#returntransfer) | **POST** /transfers/{transferId}/returns | Return a transfer |
| [**TransferFunds**](TransfersService.md#transferfunds) | **POST** /transfers | Transfer funds |

<a id="approveinitiatedtransfers"></a>
### **POST** **/transfers/approve**

Approve initiated transfers

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **wWWAuthenticate** | [string] | Header for authenticating through SCA |
| **approveTransfersRequest** | **ApproveTransfersRequest** |  |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransfersService.ApproveInitiatedTransfers` usage:
// Provide the following values: idempotencyKey, wWWAuthenticate, approveTransfersRequest.
I response = await transfersService.ApproveInitiatedTransfersAsync(
    string idempotencyKey,
    string wWWAuthenticate,
    ApproveTransfersRequest approveTransfersRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="cancelinitiatedtransfers"></a>
### **POST** **/transfers/cancel**

Cancel initiated transfers

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **cancelTransfersRequest** | **CancelTransfersRequest** |  |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransfersService.CancelInitiatedTransfers` usage:
// Provide the following values: idempotencyKey, cancelTransfersRequest.
I response = await transfersService.CancelInitiatedTransfersAsync(
    string idempotencyKey,
    CancelTransfersRequest cancelTransfersRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getalltransfers"></a>
### **GET** **/transfers**

Get all transfers

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createdSince** | [DateTimeOffset] | Only include transfers that have been created on or after this point in time. The value must be in ISO 8601 format and not earlier than 6 months before the &#x60;createdUntil&#x60; date. For example, **2021-05-30T15:07:40Z**. |
| **createdUntil** | [DateTimeOffset] | Only include transfers that have been created on or before this point in time. The value must be in ISO 8601 format and not later than 6 months after the &#x60;createdSince&#x60; date. For example, **2021-05-30T15:07:40Z**. |
| **balancePlatform** | [string] | The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60;. |
| **accountHolderId** | [string] | The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;balancePlatform&#x60;.  If you provide a &#x60;balanceAccountId&#x60;, the &#x60;accountHolderId&#x60; must be related to the &#x60;balanceAccountId&#x60;. |
| **balanceAccountId** | [string] | The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).  Required if you don&#39;t provide an &#x60;accountHolderId&#x60; or &#x60;balancePlatform&#x60;.  If you provide an &#x60;accountHolderId&#x60;, the &#x60;balanceAccountId&#x60; must be related to the &#x60;accountHolderId&#x60;. |
| **paymentInstrumentId** | [string] | The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).  To use this parameter, you must also provide a &#x60;balanceAccountId&#x60;, &#x60;accountHolderId&#x60;, or &#x60;balancePlatform&#x60;.  The &#x60;paymentInstrumentId&#x60; must be related to the &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60; that you provide. |
| **reference** | [string] | The reference you provided in the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) request |
| **category** | [string] | The type of transfer.  Possible values:   - **bank**: Transfer to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id) or a bank account.  - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.  - **issuedCard**: Transfer initiated by a Adyen-issued card.  - **platformPayment**: Fund movements related to payments that are acquired for your users. |
| **sortOrder** | [string] | Determines the sort order of the returned transfers. The sort order is based on the creation date of the transfers.  Possible values:   - **asc**: Ascending order, from oldest to most recent.  - **desc**: Descending order, from most recent to oldest.  Default value: **asc**. |
| **cursor** | [string] | The &#x60;cursor&#x60; returned in the links of the previous response. |
| **limit** | [int] | The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page. |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransfersService.GetAllTransfers` usage:
// Provide the following values: createdSince, createdUntil, balancePlatform, accountHolderId, balanceAccountId, paymentInstrumentId, reference, category, sortOrder, cursor, limit.
IFindTransfersResponse response = await transfersService.GetAllTransfersAsync(
    DateTimeOffset createdSince,
    DateTimeOffset createdUntil,
    string balancePlatform,
    string accountHolderId,
    string balanceAccountId,
    string paymentInstrumentId,
    string reference,
    string category,
    string sortOrder,
    string cursor,
    int limit, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out FindTransfersResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[FindTransfersResponse]()


<a id="gettransfer"></a>
### **GET** **/transfers/{id}**

Get a transfer

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | Unique identifier of the transfer. |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransfersService.GetTransfer` usage:
// Provide the following values: id.
ITransferData response = await transfersService.GetTransferAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferData result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferData]()


<a id="returntransfer"></a>
### **POST** **/transfers/{transferId}/returns**

Return a transfer

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transferId** | [string] | The unique identifier of the transfer to be returned. |
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **returnTransferRequest** | **ReturnTransferRequest** |  |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransfersService.ReturnTransfer` usage:
// Provide the following values: transferId, idempotencyKey, returnTransferRequest.
IReturnTransferResponse response = await transfersService.ReturnTransferAsync(
    string transferId,
    string idempotencyKey,
    ReturnTransferRequest returnTransferRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ReturnTransferResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ReturnTransferResponse]()


<a id="transferfunds"></a>
### **POST** **/transfers**

Transfer funds

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **wWWAuthenticate** | [string] | Header for authenticating through SCA |
| **transferInfo** | **TransferInfo** |  |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `TransfersService.TransferFunds` usage:
// Provide the following values: idempotencyKey, wWWAuthenticate, transferInfo.
ITransfer response = await transfersService.TransferFundsAsync(
    string idempotencyKey,
    string wWWAuthenticate,
    TransferInfo transferInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Transfer result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Transfer]()


