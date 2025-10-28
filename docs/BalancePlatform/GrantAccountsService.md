# Adyen.BalancePlatform.Services.GrantAccountsService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGrantAccount**](GrantAccountsService.md#getgrantaccount) | **GET** /grantAccounts/{id} | Get a grant account |

<a id="getgrantaccount"></a>
# **GET** **/grantAccounts/{id}**

Get a grant account

```csharp 
ICapitalGrantAccount GetGrantAccountAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the grant account. |

### Return type

[**CapitalGrantAccount**](CapitalGrantAccount.md)

