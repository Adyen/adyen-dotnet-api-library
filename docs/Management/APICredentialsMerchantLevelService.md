# Adyen.Management.Services.APICredentialsMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiCredential**](APICredentialsMerchantLevelService.md#createapicredential) | **POST** /merchants/{merchantId}/apiCredentials | Create an API credential |
| [**GetApiCredential**](APICredentialsMerchantLevelService.md#getapicredential) | **GET** /merchants/{merchantId}/apiCredentials/{apiCredentialId} | Get an API credential |
| [**ListApiCredentials**](APICredentialsMerchantLevelService.md#listapicredentials) | **GET** /merchants/{merchantId}/apiCredentials | Get a list of API credentials |
| [**UpdateApiCredential**](APICredentialsMerchantLevelService.md#updateapicredential) | **PATCH** /merchants/{merchantId}/apiCredentials/{apiCredentialId} | Update an API credential |

<a id="createapicredential"></a>
# **POST** **/merchants/{merchantId}/apiCredentials**

Create an API credential

```csharp 
ICreateApiCredentialResponse CreateApiCredentialAsync(string merchantId, CreateMerchantApiCredentialRequest createMerchantApiCredentialRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **createMerchantApiCredentialRequest** | [**CreateMerchantApiCredentialRequest**](CreateMerchantApiCredentialRequest.md) |  |

### Return type

[**CreateApiCredentialResponse**](CreateApiCredentialResponse.md)

<a id="getapicredential"></a>
# **GET** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}**

Get an API credential

```csharp 
IApiCredential GetApiCredentialAsync(string merchantId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**ApiCredential**](ApiCredential.md)

<a id="listapicredentials"></a>
# **GET** **/merchants/{merchantId}/apiCredentials**

Get a list of API credentials

```csharp 
IListMerchantApiCredentialsResponse ListApiCredentialsAsync(string merchantId, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListMerchantApiCredentialsResponse**](ListMerchantApiCredentialsResponse.md)

<a id="updateapicredential"></a>
# **PATCH** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}**

Update an API credential

```csharp 
IApiCredential UpdateApiCredentialAsync(string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest updateMerchantApiCredentialRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **updateMerchantApiCredentialRequest** | [**UpdateMerchantApiCredentialRequest**](UpdateMerchantApiCredentialRequest.md) |  |

### Return type

[**ApiCredential**](ApiCredential.md)

