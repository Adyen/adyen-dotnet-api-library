# Adyen.Management.Services.AccountCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCompanyAccount**](AccountCompanyLevelService.md#getcompanyaccount) | **GET** /companies/{companyId} | Get a company account |
| [**ListCompanyAccounts**](AccountCompanyLevelService.md#listcompanyaccounts) | **GET** /companies | Get a list of company accounts |
| [**ListMerchantAccounts**](AccountCompanyLevelService.md#listmerchantaccounts) | **GET** /companies/{companyId}/merchants | Get a list of merchant accounts |

<a id="getcompanyaccount"></a>
# **GET** **/companies/{companyId}**

Get a company account

```csharp 
ICompany GetCompanyAccountAsync(string companyId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |

### Return type

[**Company**](Company.md)

<a id="listcompanyaccounts"></a>
# **GET** **/companies**

Get a list of company accounts

```csharp 
IListCompanyResponse ListCompanyAccountsAsync(int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListCompanyResponse**](ListCompanyResponse.md)

<a id="listmerchantaccounts"></a>
# **GET** **/companies/{companyId}/merchants**

Get a list of merchant accounts

```csharp 
IListMerchantResponse ListMerchantAccountsAsync(string companyId, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListMerchantResponse**](ListMerchantResponse.md)

