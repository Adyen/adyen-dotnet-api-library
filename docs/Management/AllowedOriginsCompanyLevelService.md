# Adyen.Management.Services.AllowedOriginsCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAllowedOrigin**](AllowedOriginsCompanyLevelService.md#createallowedorigin) | **POST** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins | Create an allowed origin |
| [**DeleteAllowedOrigin**](AllowedOriginsCompanyLevelService.md#deleteallowedorigin) | **DELETE** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Delete an allowed origin |
| [**GetAllowedOrigin**](AllowedOriginsCompanyLevelService.md#getallowedorigin) | **GET** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId} | Get an allowed origin |
| [**ListAllowedOrigins**](AllowedOriginsCompanyLevelService.md#listallowedorigins) | **GET** /companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins | Get a list of allowed origins |

<a id="createallowedorigin"></a>
# **POST** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Create an allowed origin

```csharp 
IAllowedOrigin CreateAllowedOriginAsync(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **allowedOrigin** | [**AllowedOrigin**](AllowedOrigin.md) |  |

### Return type

[**AllowedOrigin**](AllowedOrigin.md)

<a id="deleteallowedorigin"></a>
# **DELETE** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Delete an allowed origin

```csharp 
Ivoid DeleteAllowedOriginAsync(string companyId, string apiCredentialId, string originId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **originId** | **string** | Unique identifier of the allowed origin. |

### Return type

void (empty response body)

<a id="getallowedorigin"></a>
# **GET** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}**

Get an allowed origin

```csharp 
IAllowedOrigin GetAllowedOriginAsync(string companyId, string apiCredentialId, string originId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **originId** | **string** | Unique identifier of the allowed origin. |

### Return type

[**AllowedOrigin**](AllowedOrigin.md)

<a id="listallowedorigins"></a>
# **GET** **/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins**

Get a list of allowed origins

```csharp 
IAllowedOriginsResponse ListAllowedOriginsAsync(string companyId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**AllowedOriginsResponse**](AllowedOriginsResponse.md)

