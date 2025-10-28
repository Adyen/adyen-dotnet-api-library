# Adyen.StoredValue.Services.StoredValueService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/StoredValue/v46**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeStatus**](StoredValueService.md#changestatus) | **POST** /changeStatus | Changes the status of the payment method. |
| [**CheckBalance**](StoredValueService.md#checkbalance) | **POST** /checkBalance | Checks the balance. |
| [**Issue**](StoredValueService.md#issue) | **POST** /issue | Issues a new card. |
| [**Load**](StoredValueService.md#load) | **POST** /load | Loads the payment method. |
| [**MergeBalance**](StoredValueService.md#mergebalance) | **POST** /mergeBalance | Merge the balance of two cards. |
| [**VoidTransaction**](StoredValueService.md#voidtransaction) | **POST** /voidTransaction | Voids a transaction. |

<a id="changestatus"></a>
# **POST** **/changeStatus**

Changes the status of the payment method.

```csharp 
IStoredValueStatusChangeResponse ChangeStatusAsync(StoredValueStatusChangeRequest storedValueStatusChangeRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueStatusChangeRequest** | [**StoredValueStatusChangeRequest**](StoredValueStatusChangeRequest.md) |  |

### Return type

[**StoredValueStatusChangeResponse**](StoredValueStatusChangeResponse.md)

<a id="checkbalance"></a>
# **POST** **/checkBalance**

Checks the balance.

```csharp 
IStoredValueBalanceCheckResponse CheckBalanceAsync(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueBalanceCheckRequest** | [**StoredValueBalanceCheckRequest**](StoredValueBalanceCheckRequest.md) |  |

### Return type

[**StoredValueBalanceCheckResponse**](StoredValueBalanceCheckResponse.md)

<a id="issue"></a>
# **POST** **/issue**

Issues a new card.

```csharp 
IStoredValueIssueResponse IssueAsync(StoredValueIssueRequest storedValueIssueRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueIssueRequest** | [**StoredValueIssueRequest**](StoredValueIssueRequest.md) |  |

### Return type

[**StoredValueIssueResponse**](StoredValueIssueResponse.md)

<a id="load"></a>
# **POST** **/load**

Loads the payment method.

```csharp 
IStoredValueLoadResponse LoadAsync(StoredValueLoadRequest storedValueLoadRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueLoadRequest** | [**StoredValueLoadRequest**](StoredValueLoadRequest.md) |  |

### Return type

[**StoredValueLoadResponse**](StoredValueLoadResponse.md)

<a id="mergebalance"></a>
# **POST** **/mergeBalance**

Merge the balance of two cards.

```csharp 
IStoredValueBalanceMergeResponse MergeBalanceAsync(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueBalanceMergeRequest** | [**StoredValueBalanceMergeRequest**](StoredValueBalanceMergeRequest.md) |  |

### Return type

[**StoredValueBalanceMergeResponse**](StoredValueBalanceMergeResponse.md)

<a id="voidtransaction"></a>
# **POST** **/voidTransaction**

Voids a transaction.

```csharp 
IStoredValueVoidResponse VoidTransactionAsync(StoredValueVoidRequest storedValueVoidRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueVoidRequest** | [**StoredValueVoidRequest**](StoredValueVoidRequest.md) |  |

### Return type

[**StoredValueVoidResponse**](StoredValueVoidResponse.md)

