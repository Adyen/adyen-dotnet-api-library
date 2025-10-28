# Adyen.LegalEntityManagement.Services.DocumentsService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteDocument**](DocumentsService.md#deletedocument) | **DELETE** /documents/{id} | Delete a document |
| [**GetDocument**](DocumentsService.md#getdocument) | **GET** /documents/{id} | Get a document |
| [**UpdateDocument**](DocumentsService.md#updatedocument) | **PATCH** /documents/{id} | Update a document |
| [**UploadDocumentForVerificationChecks**](DocumentsService.md#uploaddocumentforverificationchecks) | **POST** /documents | Upload a document for verification checks |

<a id="deletedocument"></a>
# **DELETE** **/documents/{id}**

Delete a document

```csharp 
Ivoid DeleteDocumentAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the document to be deleted. |

### Return type

void (empty response body)

<a id="getdocument"></a>
# **GET** **/documents/{id}**

Get a document

```csharp 
IDocument GetDocumentAsync(string id, bool skipContent = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the document. |
| **skipContent** | **bool** | Do not load document content while fetching the document. |

### Return type

[**Document**](Document.md)

<a id="updatedocument"></a>
# **PATCH** **/documents/{id}**

Update a document

```csharp 
IDocument UpdateDocumentAsync(string id, string xRequestedVerificationCode = null, Document document = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the document to be updated. |
| **xRequestedVerificationCode** | **string** | Use the requested verification code 0_0001 to resolve any suberrors associated with the document. Requested verification codes can only be used in your test environment. |
| **document** | [**Document**](Document.md) |  |

### Return type

[**Document**](Document.md)

<a id="uploaddocumentforverificationchecks"></a>
# **POST** **/documents**

Upload a document for verification checks

```csharp 
IDocument UploadDocumentForVerificationChecksAsync(string xRequestedVerificationCode = null, Document document = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **xRequestedVerificationCode** | **string** | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| **document** | [**Document**](Document.md) |  |

### Return type

[**Document**](Document.md)

