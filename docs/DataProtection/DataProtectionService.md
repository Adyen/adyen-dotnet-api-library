# Adyen.DataProtection.Services.DataProtectionService

### API Base-Path: **https://ca-test.adyen.com/ca/services/DataProtectionService/v1**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RequestSubjectErasure**](DataProtectionService.md#requestsubjecterasure) | **POST** /requestSubjectErasure | Submit a Subject Erasure Request. |

<a id="requestsubjecterasure"></a>
# **POST** **/requestSubjectErasure**

Submit a Subject Erasure Request.

```csharp 
ISubjectErasureResponse RequestSubjectErasureAsync(SubjectErasureByPspReferenceRequest subjectErasureByPspReferenceRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **subjectErasureByPspReferenceRequest** | [**SubjectErasureByPspReferenceRequest**](SubjectErasureByPspReferenceRequest.md) |  |

### Return type

[**SubjectErasureResponse**](SubjectErasureResponse.md)

