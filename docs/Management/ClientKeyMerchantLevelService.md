# Adyen.Management.Services.ClientKeyMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewClientKey**](ClientKeyMerchantLevelService.md#generatenewclientkey) | **POST** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateClientKey | Generate new client key |

<a id="generatenewclientkey"></a>
# **POST** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateClientKey**

Generate new client key

```csharp 
IGenerateClientKeyResponse GenerateNewClientKeyAsync(string merchantId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**GenerateClientKeyResponse**](GenerateClientKeyResponse.md)

