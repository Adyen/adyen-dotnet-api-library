# Adyen.Management.Services.APIKeyMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewApiKey**](APIKeyMerchantLevelService.md#generatenewapikey) | **POST** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey | Generate new API key |

<a id="generatenewapikey"></a>
# **POST** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey**

Generate new API key

```csharp 
IGenerateApiKeyResponse GenerateNewApiKeyAsync(string merchantId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**GenerateApiKeyResponse**](GenerateApiKeyResponse.md)

