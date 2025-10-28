# Adyen.Management.Services.AccountMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMerchantAccount**](AccountMerchantLevelService.md#createmerchantaccount) | **POST** /merchants | Create a merchant account |
| [**GetMerchantAccount**](AccountMerchantLevelService.md#getmerchantaccount) | **GET** /merchants/{merchantId} | Get a merchant account |
| [**ListMerchantAccounts**](AccountMerchantLevelService.md#listmerchantaccounts) | **GET** /merchants | Get a list of merchant accounts |
| [**RequestToActivateMerchantAccount**](AccountMerchantLevelService.md#requesttoactivatemerchantaccount) | **POST** /merchants/{merchantId}/activate | Request to activate a merchant account |

<a id="createmerchantaccount"></a>
# **POST** **/merchants**

Create a merchant account

```csharp 
ICreateMerchantResponse CreateMerchantAccountAsync(CreateMerchantRequest createMerchantRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createMerchantRequest** | [**CreateMerchantRequest**](CreateMerchantRequest.md) |  |

### Return type

[**CreateMerchantResponse**](CreateMerchantResponse.md)

<a id="getmerchantaccount"></a>
# **GET** **/merchants/{merchantId}**

Get a merchant account

```csharp 
IMerchant GetMerchantAccountAsync(string merchantId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**Merchant**](Merchant.md)

<a id="listmerchantaccounts"></a>
# **GET** **/merchants**

Get a list of merchant accounts

```csharp 
IListMerchantResponse ListMerchantAccountsAsync(int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListMerchantResponse**](ListMerchantResponse.md)

<a id="requesttoactivatemerchantaccount"></a>
# **POST** **/merchants/{merchantId}/activate**

Request to activate a merchant account

```csharp 
IRequestActivationResponse RequestToActivateMerchantAccountAsync(string merchantId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**RequestActivationResponse**](RequestActivationResponse.md)

