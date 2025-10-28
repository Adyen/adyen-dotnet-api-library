# Adyen.BalancePlatform.Services.TransferLimitsBalanceAccountLevelService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApprovePendingTransferLimits**](TransferLimitsBalanceAccountLevelService.md#approvependingtransferlimits) | **POST** /balanceAccounts/{id}/transferLimits/approve | Approve pending transfer limits |
| [**CreateTransferLimit**](TransferLimitsBalanceAccountLevelService.md#createtransferlimit) | **POST** /balanceAccounts/{id}/transferLimits | Create a transfer limit |
| [**DeletePendingTransferLimit**](TransferLimitsBalanceAccountLevelService.md#deletependingtransferlimit) | **DELETE** /balanceAccounts/{id}/transferLimits/{transferLimitId} | Delete a scheduled or pending transfer limit |
| [**GetCurrentTransferLimits**](TransferLimitsBalanceAccountLevelService.md#getcurrenttransferlimits) | **GET** /balanceAccounts/{id}/transferLimits/current | Get all current transfer limits |
| [**GetSpecificTransferLimit**](TransferLimitsBalanceAccountLevelService.md#getspecifictransferlimit) | **GET** /balanceAccounts/{id}/transferLimits/{transferLimitId} | Get the details of a transfer limit |
| [**GetTransferLimits**](TransferLimitsBalanceAccountLevelService.md#gettransferlimits) | **GET** /balanceAccounts/{id}/transferLimits | Filter and view the transfer limits |

<a id="approvependingtransferlimits"></a>
# **POST** **/balanceAccounts/{id}/transferLimits/approve**

Approve pending transfer limits

```csharp 
Ivoid ApprovePendingTransferLimitsAsync(string id, ApproveTransferLimitRequest approveTransferLimitRequest, string wWWAuthenticate = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **approveTransferLimitRequest** | [**ApproveTransferLimitRequest**](ApproveTransferLimitRequest.md) |  |
| **wWWAuthenticate** | **string** | Header for authenticating using SCA. |

### Return type

void (empty response body)

<a id="createtransferlimit"></a>
# **POST** **/balanceAccounts/{id}/transferLimits**

Create a transfer limit

```csharp 
ITransferLimit CreateTransferLimitAsync(string id, CreateTransferLimitRequest createTransferLimitRequest, string wWWAuthenticate = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **createTransferLimitRequest** | [**CreateTransferLimitRequest**](CreateTransferLimitRequest.md) |  |
| **wWWAuthenticate** | **string** | Header for authenticating through SCA |

### Return type

[**TransferLimit**](TransferLimit.md)

<a id="deletependingtransferlimit"></a>
# **DELETE** **/balanceAccounts/{id}/transferLimits/{transferLimitId}**

Delete a scheduled or pending transfer limit

```csharp 
Ivoid DeletePendingTransferLimitAsync(string id, string transferLimitId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **transferLimitId** | **string** | The unique identifier of the transfer limit. |

### Return type

void (empty response body)

<a id="getcurrenttransferlimits"></a>
# **GET** **/balanceAccounts/{id}/transferLimits/current**

Get all current transfer limits

```csharp 
ITransferLimitListResponse GetCurrentTransferLimitsAsync(string id, Scope scope = null, TransferType transferType = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **scope** | **Scope** | The scope to which the transfer limit applies. Possible values: * **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform. * **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| **transferType** | **TransferType** | The type of transfer to which the limit applies. Possible values: * **instant**: the limit applies to transfers with an **instant** priority. * **all**: the limit applies to all transfers, regardless of priority. |

### Return type

[**TransferLimitListResponse**](TransferLimitListResponse.md)

<a id="getspecifictransferlimit"></a>
# **GET** **/balanceAccounts/{id}/transferLimits/{transferLimitId}**

Get the details of a transfer limit

```csharp 
ITransferLimit GetSpecificTransferLimitAsync(string id, string transferLimitId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **transferLimitId** | **string** | The unique identifier of the transfer limit. |

### Return type

[**TransferLimit**](TransferLimit.md)

<a id="gettransferlimits"></a>
# **GET** **/balanceAccounts/{id}/transferLimits**

Filter and view the transfer limits

```csharp 
ITransferLimitListResponse GetTransferLimitsAsync(string id, Scope scope = null, TransferType transferType = null, LimitStatus status = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance account. |
| **scope** | **Scope** | The scope to which the transfer limit applies. Possible values: * **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform. * **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| **transferType** | **TransferType** | The type of transfer to which the limit applies. Possible values: * **instant**: the limit applies to transfers with an **instant** priority. * **all**: the limit applies to all transfers, regardless of priority. |
| **status** | **LimitStatus** | The status of the transfer limit. Possible values:    * **active**: the limit is currently active. * **inactive**: the limit is currently inactive. * **pendingSCA**: the limit is pending until your user performs SCA. * **scheduled**: the limit is scheduled to become active at a future date. |

### Return type

[**TransferLimitListResponse**](TransferLimitListResponse.md)

