# Adyen.PaymentsApp.Services.PaymentsAppService

### API Base-Path: **https://management-live.adyen.com/v1**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GeneratePaymentsAppBoardingTokenForMerchant**](PaymentsAppService.md#generatepaymentsappboardingtokenformerchant) | **POST** /merchants/{merchantId}/generatePaymentsAppBoardingToken | Create a boarding token - merchant level |
| [**GeneratePaymentsAppBoardingTokenForStore**](PaymentsAppService.md#generatepaymentsappboardingtokenforstore) | **POST** /merchants/{merchantId}/stores/{storeId}/generatePaymentsAppBoardingToken | Create a boarding token - store level |
| [**ListPaymentsAppForMerchant**](PaymentsAppService.md#listpaymentsappformerchant) | **GET** /merchants/{merchantId}/paymentsApps | Get a list of Payments Apps - merchant level |
| [**ListPaymentsAppForStore**](PaymentsAppService.md#listpaymentsappforstore) | **GET** /merchants/{merchantId}/stores/{storeId}/paymentsApps | Get a list of Payments Apps - store level |
| [**RevokePaymentsApp**](PaymentsAppService.md#revokepaymentsapp) | **POST** /merchants/{merchantId}/paymentsApps/{installationId}/revoke | Revoke Payments App instance authentication |

<a id="generatepaymentsappboardingtokenformerchant"></a>
# **POST** **/merchants/{merchantId}/generatePaymentsAppBoardingToken**

Create a boarding token - merchant level

```csharp 
IBoardingTokenResponse GeneratePaymentsAppBoardingTokenForMerchantAsync(string merchantId, BoardingTokenRequest boardingTokenRequest)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **boardingTokenRequest** | [**BoardingTokenRequest**](BoardingTokenRequest.md) |  |

### Return type

[**BoardingTokenResponse**](BoardingTokenResponse.md)

<a id="generatepaymentsappboardingtokenforstore"></a>
# **POST** **/merchants/{merchantId}/stores/{storeId}/generatePaymentsAppBoardingToken**

Create a boarding token - store level

```csharp 
IBoardingTokenResponse GeneratePaymentsAppBoardingTokenForStoreAsync(string merchantId, string storeId, BoardingTokenRequest boardingTokenRequest)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **storeId** | **string** | The unique identifier of the store. |
| **boardingTokenRequest** | [**BoardingTokenRequest**](BoardingTokenRequest.md) |  |

### Return type

[**BoardingTokenResponse**](BoardingTokenResponse.md)

<a id="listpaymentsappformerchant"></a>
# **GET** **/merchants/{merchantId}/paymentsApps**

Get a list of Payments Apps - merchant level

```csharp 
IPaymentsAppResponse ListPaymentsAppForMerchantAsync(string merchantId, string statuses = null, int limit = null, long offset = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **statuses** | **string** | The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.   Possible values:  * **BOARDING**   * **BOARDED**   * **REVOKED** |
| **limit** | **int** | The number of items to return. |
| **offset** | **long** | The number of items to skip. |

### Return type

[**PaymentsAppResponse**](PaymentsAppResponse.md)

<a id="listpaymentsappforstore"></a>
# **GET** **/merchants/{merchantId}/stores/{storeId}/paymentsApps**

Get a list of Payments Apps - store level

```csharp 
IPaymentsAppResponse ListPaymentsAppForStoreAsync(string merchantId, string storeId, string statuses = null, int limit = null, long offset = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **storeId** | **string** | The unique identifier of the store. |
| **statuses** | **string** | The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.   Possible values:  * **BOARDING**   * **BOARDED**   * **REVOKED** |
| **limit** | **int** | The number of items to return. |
| **offset** | **long** | The number of items to skip. |

### Return type

[**PaymentsAppResponse**](PaymentsAppResponse.md)

<a id="revokepaymentsapp"></a>
# **POST** **/merchants/{merchantId}/paymentsApps/{installationId}/revoke**

Revoke Payments App instance authentication

```csharp 
Ivoid RevokePaymentsAppAsync(string merchantId, string installationId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **installationId** | **string** | The unique identifier of the Payments App instance on a device. |

### Return type

void (empty response body)

