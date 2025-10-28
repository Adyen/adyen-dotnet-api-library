# Adyen.BalancePlatform.Services.AccountHoldersService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAccountHolder**](AccountHoldersService.md#createaccountholder) | **POST** /accountHolders | Create an account holder |
| [**GetAccountHolder**](AccountHoldersService.md#getaccountholder) | **GET** /accountHolders/{id} | Get an account holder |
| [**GetAllBalanceAccountsOfAccountHolder**](AccountHoldersService.md#getallbalanceaccountsofaccountholder) | **GET** /accountHolders/{id}/balanceAccounts | Get all balance accounts of an account holder |
| [**GetAllTransactionRulesForAccountHolder**](AccountHoldersService.md#getalltransactionrulesforaccountholder) | **GET** /accountHolders/{id}/transactionRules | Get all transaction rules for an account holder |
| [**GetTaxForm**](AccountHoldersService.md#gettaxform) | **GET** /accountHolders/{id}/taxForms | Get a tax form |
| [**UpdateAccountHolder**](AccountHoldersService.md#updateaccountholder) | **PATCH** /accountHolders/{id} | Update an account holder |

<a id="createaccountholder"></a>
# **POST** **/accountHolders**

Create an account holder

```csharp 
IAccountHolder CreateAccountHolderAsync(AccountHolderInfo accountHolderInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **accountHolderInfo** | [**AccountHolderInfo**](AccountHolderInfo.md) |  |

### Return type

[**AccountHolder**](AccountHolder.md)

<a id="getaccountholder"></a>
# **GET** **/accountHolders/{id}**

Get an account holder

```csharp 
IAccountHolder GetAccountHolderAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the account holder. |

### Return type

[**AccountHolder**](AccountHolder.md)

<a id="getallbalanceaccountsofaccountholder"></a>
# **GET** **/accountHolders/{id}/balanceAccounts**

Get all balance accounts of an account holder

```csharp 
IPaginatedBalanceAccountsResponse GetAllBalanceAccountsOfAccountHolderAsync(string id, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the account holder. |
| **offset** | **int** | The number of items that you want to skip. |
| **limit** | **int** | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

### Return type

[**PaginatedBalanceAccountsResponse**](PaginatedBalanceAccountsResponse.md)

<a id="getalltransactionrulesforaccountholder"></a>
# **GET** **/accountHolders/{id}/transactionRules**

Get all transaction rules for an account holder

```csharp 
ITransactionRulesResponse GetAllTransactionRulesForAccountHolderAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the account holder. |

### Return type

[**TransactionRulesResponse**](TransactionRulesResponse.md)

<a id="gettaxform"></a>
# **GET** **/accountHolders/{id}/taxForms**

Get a tax form

```csharp 
IGetTaxFormResponse GetTaxFormAsync(string id, string formType, int year, string legalEntityId = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the account holder. |
| **formType** | **string** | The type of tax form you want to retrieve. Accepted values are **US1099k** and **US1099nec** |
| **year** | **int** | The tax year in YYYY format for the tax form you want to retrieve |
| **legalEntityId** | **string** | The legal entity reference whose tax form you want to retrieve |

### Return type

[**GetTaxFormResponse**](GetTaxFormResponse.md)

<a id="updateaccountholder"></a>
# **PATCH** **/accountHolders/{id}**

Update an account holder

```csharp 
IAccountHolder UpdateAccountHolderAsync(string id, AccountHolderUpdateRequest accountHolderUpdateRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the account holder. |
| **accountHolderUpdateRequest** | [**AccountHolderUpdateRequest**](AccountHolderUpdateRequest.md) |  |

### Return type

[**AccountHolder**](AccountHolder.md)

