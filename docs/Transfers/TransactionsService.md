# Adyen.Transfers.Services.TransactionsService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/btl/v4**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllTransactions**](TransactionsService.md#getalltransactions) | **GET** /transactions | Get all transactions |
| [**GetTransaction**](TransactionsService.md#gettransaction) | **GET** /transactions/{id} | Get a transaction |

<a id="getalltransactions"></a>
# **GET** **/transactions**

Get all transactions

```csharp 
ITransactionSearchResponse GetAllTransactionsAsync(DateTimeOffset createdSince, DateTimeOffset createdUntil, string balancePlatform = null, string paymentInstrumentId = null, string accountHolderId = null, string balanceAccountId = null, string cursor = null, string sortOrder = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createdSince** | **DateTimeOffset** | Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **createdUntil** | **DateTimeOffset** | Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **balancePlatform** | **string** | The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60;. |
| **paymentInstrumentId** | **string** | The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).  To use this parameter, you must also provide a &#x60;balanceAccountId&#x60;, &#x60;accountHolderId&#x60;, or &#x60;balancePlatform&#x60;.  The &#x60;paymentInstrumentId&#x60; must be related to the &#x60;balanceAccountId&#x60; or &#x60;accountHolderId&#x60; that you provide. |
| **accountHolderId** | **string** | The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).  Required if you don&#39;t provide a &#x60;balanceAccountId&#x60; or &#x60;balancePlatform&#x60;.  If you provide a &#x60;balanceAccountId&#x60;, the &#x60;accountHolderId&#x60; must be related to the &#x60;balanceAccountId&#x60;. |
| **balanceAccountId** | **string** | The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).  Required if you don&#39;t provide an &#x60;accountHolderId&#x60; or &#x60;balancePlatform&#x60;.  If you provide an &#x60;accountHolderId&#x60;, the &#x60;balanceAccountId&#x60; must be related to the &#x60;accountHolderId&#x60;. |
| **cursor** | **string** | The &#x60;cursor&#x60; returned in the links of the previous response. |
| **sortOrder** | **string** | Determines the sort order of the returned transactions. The sort order is based on the creation date of the transaction.  Possible values:   - **asc**: Ascending order, from oldest to most recent.  - **desc**: Descending order, from most recent to oldest.  Default value: **asc**. |
| **limit** | **int** | The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page. |

### Return type

[**TransactionSearchResponse**](TransactionSearchResponse.md)

<a id="gettransaction"></a>
# **GET** **/transactions/{id}**

Get a transaction

```csharp 
ITransaction GetTransactionAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the transaction. |

### Return type

[**Transaction**](Transaction.md)

