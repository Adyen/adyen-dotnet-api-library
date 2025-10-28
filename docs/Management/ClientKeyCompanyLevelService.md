# Adyen.Management.Services.ClientKeyCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewClientKey**](ClientKeyCompanyLevelService.md#generatenewclientkey) | **POST** /companies/{companyId}/apiCredentials/{apiCredentialId}/generateClientKey | Generate new client key |

<a id="generatenewclientkey"></a>
# **POST** **/companies/{companyId}/apiCredentials/{apiCredentialId}/generateClientKey**

Generate new client key

```csharp 
IGenerateClientKeyResponse GenerateNewClientKeyAsync(string companyId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**GenerateClientKeyResponse**](GenerateClientKeyResponse.md)

