# Adyen.BalancePlatform.Services.TransferLimitsBalancePlatformLevelService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransferLimit**](TransferLimitsBalancePlatformLevelService.md#createtransferlimit) | **POST** /balancePlatforms/{id}/transferLimits | Create a transfer limit |
| [**DeletePendingTransferLimit**](TransferLimitsBalancePlatformLevelService.md#deletependingtransferlimit) | **DELETE** /balancePlatforms/{id}/transferLimits/{transferLimitId} | Delete a scheduled or pending transfer limit |
| [**GetSpecificTransferLimit**](TransferLimitsBalancePlatformLevelService.md#getspecifictransferlimit) | **GET** /balancePlatforms/{id}/transferLimits/{transferLimitId} | Get the details of a transfer limit |
| [**GetTransferLimits**](TransferLimitsBalancePlatformLevelService.md#gettransferlimits) | **GET** /balancePlatforms/{id}/transferLimits | Filter and view the transfer limits |

<a id="createtransferlimit"></a>
# **POST** **/balancePlatforms/{id}/transferLimits**

Create a transfer limit

```csharp 
ITransferLimit CreateTransferLimitAsync(string id, CreateTransferLimitRequest createTransferLimitRequest)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |
| **createTransferLimitRequest** | [**CreateTransferLimitRequest**](CreateTransferLimitRequest.md) |  |

### Return type

[**TransferLimit**](TransferLimit.md)

<a id="deletependingtransferlimit"></a>
# **DELETE** **/balancePlatforms/{id}/transferLimits/{transferLimitId}**

Delete a scheduled or pending transfer limit

```csharp 
Ivoid DeletePendingTransferLimitAsync(string id, string transferLimitId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |
| **transferLimitId** | **string** | The unique identifier of the transfer limit. |

### Return type

void (empty response body)

<a id="getspecifictransferlimit"></a>
# **GET** **/balancePlatforms/{id}/transferLimits/{transferLimitId}**

Get the details of a transfer limit

```csharp 
ITransferLimit GetSpecificTransferLimitAsync(string id, string transferLimitId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |
| **transferLimitId** | **string** | The unique identifier of the transfer limit. |

### Return type

[**TransferLimit**](TransferLimit.md)

<a id="gettransferlimits"></a>
# **GET** **/balancePlatforms/{id}/transferLimits**

Filter and view the transfer limits

```csharp 
ITransferLimitListResponse GetTransferLimitsAsync(string id, Scope scope = null, TransferType transferType = null, LimitStatus status = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the balance platform. |
| **scope** | **Scope** | The scope to which the transfer limit applies. Possible values: * **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform. * **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| **transferType** | **TransferType** | The type of transfer to which the limit applies. Possible values: * **instant**: the limit applies to transfers with an **instant** priority. * **all**: the limit applies to all transfers, regardless of priority. |
| **status** | **LimitStatus** | The status of the transfer limit. Possible values:    * **active**: the limit is currently active. * **inactive**: the limit is currently inactive. * **pendingSCA**: the limit is pending until your user performs SCA. * **scheduled**: the limit is scheduled to become active at a future date. |

### Return type

[**TransferLimitListResponse**](TransferLimitListResponse.md)

