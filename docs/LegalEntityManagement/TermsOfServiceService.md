# Adyen.LegalEntityManagement.Services.TermsOfServiceService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptTermsOfService**](TermsOfServiceService.md#accepttermsofservice) | **PATCH** /legalEntities/{id}/termsOfService/{termsofservicedocumentid} | Accept Terms of Service |
| [**GetAcceptedTermsOfServiceDocument**](TermsOfServiceService.md#getacceptedtermsofservicedocument) | **GET** /legalEntities/{id}/acceptedTermsOfServiceDocument/{termsofserviceacceptancereference} | Get accepted Terms of Service document |
| [**GetTermsOfServiceDocument**](TermsOfServiceService.md#gettermsofservicedocument) | **POST** /legalEntities/{id}/termsOfService | Get Terms of Service document |
| [**GetTermsOfServiceInformationForLegalEntity**](TermsOfServiceService.md#gettermsofserviceinformationforlegalentity) | **GET** /legalEntities/{id}/termsOfServiceAcceptanceInfos | Get Terms of Service information for a legal entity |
| [**GetTermsOfServiceStatus**](TermsOfServiceService.md#gettermsofservicestatus) | **GET** /legalEntities/{id}/termsOfServiceStatus | Get Terms of Service status |

<a id="accepttermsofservice"></a>
# **PATCH** **/legalEntities/{id}/termsOfService/{termsofservicedocumentid}**

Accept Terms of Service

```csharp 
IAcceptTermsOfServiceResponse AcceptTermsOfServiceAsync(string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest acceptTermsOfServiceRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity.  For sole proprietorships, this is the individual legal entity ID of the owner.  For organizations, this is the ID of the organization.  For legal representatives of individuals, this is the ID of the individual.   |
| **termsofservicedocumentid** | **string** | The unique identifier of the Terms of Service document. |
| **acceptTermsOfServiceRequest** | [**AcceptTermsOfServiceRequest**](AcceptTermsOfServiceRequest.md) |  |

### Return type

[**AcceptTermsOfServiceResponse**](AcceptTermsOfServiceResponse.md)

<a id="getacceptedtermsofservicedocument"></a>
# **GET** **/legalEntities/{id}/acceptedTermsOfServiceDocument/{termsofserviceacceptancereference}**

Get accepted Terms of Service document

```csharp 
IGetAcceptedTermsOfServiceDocumentResponse GetAcceptedTermsOfServiceDocumentAsync(string id, string termsofserviceacceptancereference, string termsOfServiceDocumentFormat = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. For sole proprietorship, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| **termsofserviceacceptancereference** | **string** | An Adyen-generated reference for the accepted Terms of Service. |
| **termsOfServiceDocumentFormat** | **string** | The format of the Terms of Service document. Possible values: **JSON**, **PDF**, or **TXT** |

### Return type

[**GetAcceptedTermsOfServiceDocumentResponse**](GetAcceptedTermsOfServiceDocumentResponse.md)

<a id="gettermsofservicedocument"></a>
# **POST** **/legalEntities/{id}/termsOfService**

Get Terms of Service document

```csharp 
IGetTermsOfServiceDocumentResponse GetTermsOfServiceDocumentAsync(string id, GetTermsOfServiceDocumentRequest getTermsOfServiceDocumentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| **getTermsOfServiceDocumentRequest** | [**GetTermsOfServiceDocumentRequest**](GetTermsOfServiceDocumentRequest.md) |  |

### Return type

[**GetTermsOfServiceDocumentResponse**](GetTermsOfServiceDocumentResponse.md)

<a id="gettermsofserviceinformationforlegalentity"></a>
# **GET** **/legalEntities/{id}/termsOfServiceAcceptanceInfos**

Get Terms of Service information for a legal entity

```csharp 
IGetTermsOfServiceAcceptanceInfosResponse GetTermsOfServiceInformationForLegalEntityAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

### Return type

[**GetTermsOfServiceAcceptanceInfosResponse**](GetTermsOfServiceAcceptanceInfosResponse.md)

<a id="gettermsofservicestatus"></a>
# **GET** **/legalEntities/{id}/termsOfServiceStatus**

Get Terms of Service status

```csharp 
ICalculateTermsOfServiceStatusResponse GetTermsOfServiceStatusAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

### Return type

[**CalculateTermsOfServiceStatusResponse**](CalculateTermsOfServiceStatusResponse.md)

