# Adyen.BalancePlatform.Services.PlatformService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllAccountHoldersUnderBalancePlatform**](PlatformService.md#getallaccountholdersunderbalanceplatform) | **GET** /balancePlatforms/{id}/accountHolders | Get all account holders under a balance platform |
| [**GetAllTransactionRulesForBalancePlatform**](PlatformService.md#getalltransactionrulesforbalanceplatform) | **GET** /balancePlatforms/{id}/transactionRules | Get all transaction rules for a balance platform |
| [**GetBalancePlatform**](PlatformService.md#getbalanceplatform) | **GET** /balancePlatforms/{id} | Get a balance platform |

<a id="getallaccountholdersunderbalanceplatform"></a>
# **GET** **/balancePlatforms/{id}/accountHolders**

Get all account holders under a balance platform

```csharp 
IPaginatedAccountHoldersResponse GetAllAccountHoldersUnderBalancePlatformAsync(string id, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |
| **offset** | **int** | The number of items that you want to skip. |
| **limit** | **int** | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

### Return type

[**PaginatedAccountHoldersResponse**](PaginatedAccountHoldersResponse.md)

<a id="getalltransactionrulesforbalanceplatform"></a>
# **GET** **/balancePlatforms/{id}/transactionRules**

Get all transaction rules for a balance platform

```csharp 
ITransactionRulesResponse GetAllTransactionRulesForBalancePlatformAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |

### Return type

[**TransactionRulesResponse**](TransactionRulesResponse.md)

<a id="getbalanceplatform"></a>
# **GET** **/balancePlatforms/{id}**

Get a balance platform

```csharp 
IBalancePlatform GetBalancePlatformAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |

### Return type

[**BalancePlatform**](BalancePlatform.md)

