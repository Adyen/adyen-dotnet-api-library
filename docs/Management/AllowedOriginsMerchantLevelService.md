# Adyen.Management.Services.AllowedOriginsMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAllowedOrigin**](AllowedOriginsMerchantLevelService.md#createallowedorigin) | **POST** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins | Create an allowed origin |
| [**DeleteAllowedOrigin**](AllowedOriginsMerchantLevelService.md#deleteallowedorigin) | **DELETE** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Delete an allowed origin |
| [**GetAllowedOrigin**](AllowedOriginsMerchantLevelService.md#getallowedorigin) | **GET** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Get an allowed origin |
| [**ListAllowedOrigins**](AllowedOriginsMerchantLevelService.md#listallowedorigins) | **GET** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins | Get a list of allowed origins |

<a id="createallowedorigin"></a>
# **POST** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Create an allowed origin

```csharp 
IAllowedOrigin CreateAllowedOriginAsync(string merchantId, string apiCredentialId, AllowedOrigin allowedOrigin = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **allowedOrigin** | [**AllowedOrigin**](AllowedOrigin.md) |  |

### Return type

[**AllowedOrigin**](AllowedOrigin.md)

<a id="deleteallowedorigin"></a>
# **DELETE** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Delete an allowed origin

```csharp 
Ivoid DeleteAllowedOriginAsync(string merchantId, string apiCredentialId, string originId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **originId** | **string** | Unique identifier of the allowed origin. |

### Return type

void (empty response body)

<a id="getallowedorigin"></a>
# **GET** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Get an allowed origin

```csharp 
IAllowedOrigin GetAllowedOriginAsync(string merchantId, string apiCredentialId, string originId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **originId** | **string** | Unique identifier of the allowed origin. |

### Return type

[**AllowedOrigin**](AllowedOrigin.md)

<a id="listallowedorigins"></a>
# **GET** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Get a list of allowed origins

```csharp 
IAllowedOriginsResponse ListAllowedOriginsAsync(string merchantId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**AllowedOriginsResponse**](AllowedOriginsResponse.md)

