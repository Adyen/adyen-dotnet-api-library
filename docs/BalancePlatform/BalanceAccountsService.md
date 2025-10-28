# Adyen.BalancePlatform.Services.BalanceAccountsService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

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
# **POST** **/balanceAccounts**

Create a balance account

```csharp 
IBalanceAccount CreateBalanceAccountAsync(BalanceAccountInfo balanceAccountInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountInfo** | [**BalanceAccountInfo**](BalanceAccountInfo.md) |  |

### Return type

[**BalanceAccount**](BalanceAccount.md)

<a id="createsweep"></a>
# **POST** **/balanceAccounts/{balanceAccountId}/sweeps**

Create a sweep

```csharp 
ISweepConfigurationV2 CreateSweepAsync(string balanceAccountId, CreateSweepConfigurationV2 createSweepConfigurationV2 = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | **string** | The unique identifier of the balance account. |
| **createSweepConfigurationV2** | [**CreateSweepConfigurationV2**](CreateSweepConfigurationV2.md) |  |

### Return type

[**SweepConfigurationV2**](SweepConfigurationV2.md)

<a id="deletesweep"></a>
# **DELETE** **/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}**

Delete a sweep

```csharp 
Ivoid DeleteSweepAsync(string balanceAccountId, string sweepId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | **string** | The unique identifier of the balance account. |
| **sweepId** | **string** | The unique identifier of the sweep. |

### Return type

void (empty response body)

<a id="getallsweepsforbalanceaccount"></a>
# **GET** **/balanceAccounts/{balanceAccountId}/sweeps**

Get all sweeps for a balance account

```csharp 
IBalanceSweepConfigurationsResponse GetAllSweepsForBalanceAccountAsync(string balanceAccountId, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | **string** | The unique identifier of the balance account. |
| **offset** | **int** | The number of items that you want to skip. |
| **limit** | **int** | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

### Return type

[**BalanceSweepConfigurationsResponse**](BalanceSweepConfigurationsResponse.md)

<a id="getalltransactionrulesforbalanceaccount"></a>
# **GET** **/balanceAccounts/{id}/transactionRules**

Get all transaction rules for a balance account

```csharp 
ITransactionRulesResponse GetAllTransactionRulesForBalanceAccountAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |

### Return type

[**TransactionRulesResponse**](TransactionRulesResponse.md)

<a id="getbalanceaccount"></a>
# **GET** **/balanceAccounts/{id}**

Get a balance account

```csharp 
IBalanceAccount GetBalanceAccountAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |

### Return type

[**BalanceAccount**](BalanceAccount.md)

<a id="getpaymentinstrumentslinkedtobalanceaccount"></a>
# **GET** **/balanceAccounts/{id}/paymentInstruments**

Get payment instruments linked to a balance account

```csharp 
IPaginatedPaymentInstrumentsResponse GetPaymentInstrumentsLinkedToBalanceAccountAsync(string id, int offset = null, int limit = null, string status = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **offset** | **int** | The number of items that you want to skip. |
| **limit** | **int** | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |
| **status** | **string** | The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status. |

### Return type

[**PaginatedPaymentInstrumentsResponse**](PaginatedPaymentInstrumentsResponse.md)

<a id="getsweep"></a>
# **GET** **/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}**

Get a sweep

```csharp 
ISweepConfigurationV2 GetSweepAsync(string balanceAccountId, string sweepId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | **string** | The unique identifier of the balance account. |
| **sweepId** | **string** | The unique identifier of the sweep. |

### Return type

[**SweepConfigurationV2**](SweepConfigurationV2.md)

<a id="updatebalanceaccount"></a>
# **PATCH** **/balanceAccounts/{id}**

Update a balance account

```csharp 
IBalanceAccount UpdateBalanceAccountAsync(string id, BalanceAccountUpdateRequest balanceAccountUpdateRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **balanceAccountUpdateRequest** | [**BalanceAccountUpdateRequest**](BalanceAccountUpdateRequest.md) |  |

### Return type

[**BalanceAccount**](BalanceAccount.md)

<a id="updatesweep"></a>
# **PATCH** **/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}**

Update a sweep

```csharp 
ISweepConfigurationV2 UpdateSweepAsync(string balanceAccountId, string sweepId, UpdateSweepConfigurationV2 updateSweepConfigurationV2 = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceAccountId** | **string** | The unique identifier of the balance account. |
| **sweepId** | **string** | The unique identifier of the sweep. |
| **updateSweepConfigurationV2** | [**UpdateSweepConfigurationV2**](UpdateSweepConfigurationV2.md) |  |

### Return type

[**SweepConfigurationV2**](SweepConfigurationV2.md)

