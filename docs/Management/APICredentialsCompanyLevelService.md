# Adyen.Management.Services.APICredentialsCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiCredential**](APICredentialsCompanyLevelService.md#createapicredential) | **POST** /companies/{companyId}/apiCredentials | Create an API credential. |
| [**GetApiCredential**](APICredentialsCompanyLevelService.md#getapicredential) | **GET** /companies/{companyId}/apiCredentials/{apiCredentialId} | Get an API credential |
| [**ListApiCredentials**](APICredentialsCompanyLevelService.md#listapicredentials) | **GET** /companies/{companyId}/apiCredentials | Get a list of API credentials |
| [**UpdateApiCredential**](APICredentialsCompanyLevelService.md#updateapicredential) | **PATCH** /companies/{companyId}/apiCredentials/{apiCredentialId} | Update an API credential. |

<a id="createapicredential"></a>
# **POST** **/companies/{companyId}/apiCredentials**

Create an API credential.

```csharp 
ICreateCompanyApiCredentialResponse CreateApiCredentialAsync(string companyId, CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **createCompanyApiCredentialRequest** | [**CreateCompanyApiCredentialRequest**](CreateCompanyApiCredentialRequest.md) |  |

### Return type

[**CreateCompanyApiCredentialResponse**](CreateCompanyApiCredentialResponse.md)

<a id="getapicredential"></a>
# **GET** **/companies/{companyId}/apiCredentials/{apiCredentialId}**

Get an API credential

```csharp 
ICompanyApiCredential GetApiCredentialAsync(string companyId, string apiCredentialId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |

### Return type

[**CompanyApiCredential**](CompanyApiCredential.md)

<a id="listapicredentials"></a>
# **GET** **/companies/{companyId}/apiCredentials**

Get a list of API credentials

```csharp 
IListCompanyApiCredentialsResponse ListApiCredentialsAsync(string companyId, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListCompanyApiCredentialsResponse**](ListCompanyApiCredentialsResponse.md)

<a id="updateapicredential"></a>
# **PATCH** **/companies/{companyId}/apiCredentials/{apiCredentialId}**

Update an API credential.

```csharp 
ICompanyApiCredential UpdateApiCredentialAsync(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **apiCredentialId** | **string** | Unique identifier of the API credential. |
| **updateCompanyApiCredentialRequest** | [**UpdateCompanyApiCredentialRequest**](UpdateCompanyApiCredentialRequest.md) |  |

### Return type

[**CompanyApiCredential**](CompanyApiCredential.md)

