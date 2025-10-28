# Adyen.Management.Services.APIKeyCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewApiKey**](APIKeyCompanyLevelService.md#generatenewapikey) | **POST** /companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey | Generate new API key |

<a id="generatenewapikey"></a>
# **POST** **/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey**

Generate new API key

```csharp 
IGenerateApiKeyResponse GenerateNewApiKeyAsync(string companyId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**GenerateApiKeyResponse**](GenerateApiKeyResponse.md)

