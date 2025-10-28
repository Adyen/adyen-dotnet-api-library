# Adyen.LegalEntityManagement.Services.LegalEntitiesService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckLegalEntitysVerificationErrors**](LegalEntitiesService.md#checklegalentitysverificationerrors) | **POST** /legalEntities/{id}/checkVerificationErrors | Check a legal entity&#39;s verification errors |
| [**ConfirmDataReview**](LegalEntitiesService.md#confirmdatareview) | **POST** /legalEntities/{id}/confirmDataReview | Confirm data review |
| [**CreateLegalEntity**](LegalEntitiesService.md#createlegalentity) | **POST** /legalEntities | Create a legal entity |
| [**GetAllBusinessLinesUnderLegalEntity**](LegalEntitiesService.md#getallbusinesslinesunderlegalentity) | **GET** /legalEntities/{id}/businessLines | Get all business lines under a legal entity |
| [**GetLegalEntity**](LegalEntitiesService.md#getlegalentity) | **GET** /legalEntities/{id} | Get a legal entity |
| [**UpdateLegalEntity**](LegalEntitiesService.md#updatelegalentity) | **PATCH** /legalEntities/{id} | Update a legal entity |

<a id="checklegalentitysverificationerrors"></a>
# **POST** **/legalEntities/{id}/checkVerificationErrors**

Check a legal entity's verification errors

```csharp 
IVerificationErrors CheckLegalEntitysVerificationErrorsAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. |

### Return type

[**VerificationErrors**](VerificationErrors.md)

<a id="confirmdatareview"></a>
# **POST** **/legalEntities/{id}/confirmDataReview**

Confirm data review

```csharp 
IDataReviewConfirmationResponse ConfirmDataReviewAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. |

### Return type

[**DataReviewConfirmationResponse**](DataReviewConfirmationResponse.md)

<a id="createlegalentity"></a>
# **POST** **/legalEntities**

Create a legal entity

```csharp 
ILegalEntity CreateLegalEntityAsync(string xRequestedVerificationCode = null, LegalEntityInfoRequiredType legalEntityInfoRequiredType = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **xRequestedVerificationCode** | **string** | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| **legalEntityInfoRequiredType** | [**LegalEntityInfoRequiredType**](LegalEntityInfoRequiredType.md) |  |

### Return type

[**LegalEntity**](LegalEntity.md)

<a id="getallbusinesslinesunderlegalentity"></a>
# **GET** **/legalEntities/{id}/businessLines**

Get all business lines under a legal entity

```csharp 
IBusinessLines GetAllBusinessLinesUnderLegalEntityAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. |

### Return type

[**BusinessLines**](BusinessLines.md)

<a id="getlegalentity"></a>
# **GET** **/legalEntities/{id}**

Get a legal entity

```csharp 
ILegalEntity GetLegalEntityAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. |

### Return type

[**LegalEntity**](LegalEntity.md)

<a id="updatelegalentity"></a>
# **PATCH** **/legalEntities/{id}**

Update a legal entity

```csharp 
ILegalEntity UpdateLegalEntityAsync(string id, string xRequestedVerificationCode = null, LegalEntityInfo legalEntityInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. |
| **xRequestedVerificationCode** | **string** | Use the requested verification code 0_0001 to resolve any suberrors associated with the legal entity. Requested verification codes can only be used in your test environment. |
| **legalEntityInfo** | [**LegalEntityInfo**](LegalEntityInfo.md) |  |

### Return type

[**LegalEntity**](LegalEntity.md)

