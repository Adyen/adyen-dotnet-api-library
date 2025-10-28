# Adyen.LegalEntityManagement.Services.PCIQuestionnairesService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculatePciStatusOfLegalEntity**](PCIQuestionnairesService.md#calculatepcistatusoflegalentity) | **POST** /legalEntities/{id}/pciQuestionnaires/signingRequired | Calculate PCI status of a legal entity |
| [**GeneratePciQuestionnaire**](PCIQuestionnairesService.md#generatepciquestionnaire) | **POST** /legalEntities/{id}/pciQuestionnaires/generatePciTemplates | Generate PCI questionnaire |
| [**GetPciQuestionnaire**](PCIQuestionnairesService.md#getpciquestionnaire) | **GET** /legalEntities/{id}/pciQuestionnaires/{pciid} | Get PCI questionnaire |
| [**GetPciQuestionnaireDetails**](PCIQuestionnairesService.md#getpciquestionnairedetails) | **GET** /legalEntities/{id}/pciQuestionnaires | Get PCI questionnaire details |
| [**SignPciQuestionnaire**](PCIQuestionnairesService.md#signpciquestionnaire) | **POST** /legalEntities/{id}/pciQuestionnaires/signPciTemplates | Sign PCI questionnaire |

<a id="calculatepcistatusoflegalentity"></a>
# **POST** **/legalEntities/{id}/pciQuestionnaires/signingRequired**

Calculate PCI status of a legal entity

```csharp 
ICalculatePciStatusResponse CalculatePciStatusOfLegalEntityAsync(string id, CalculatePciStatusRequest calculatePciStatusRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity to calculate PCI status. |
| **calculatePciStatusRequest** | [**CalculatePciStatusRequest**](CalculatePciStatusRequest.md) |  |

### Return type

[**CalculatePciStatusResponse**](CalculatePciStatusResponse.md)

<a id="generatepciquestionnaire"></a>
# **POST** **/legalEntities/{id}/pciQuestionnaires/generatePciTemplates**

Generate PCI questionnaire

```csharp 
IGeneratePciDescriptionResponse GeneratePciQuestionnaireAsync(string id, GeneratePciDescriptionRequest generatePciDescriptionRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity to get PCI questionnaire information. |
| **generatePciDescriptionRequest** | [**GeneratePciDescriptionRequest**](GeneratePciDescriptionRequest.md) |  |

### Return type

[**GeneratePciDescriptionResponse**](GeneratePciDescriptionResponse.md)

<a id="getpciquestionnaire"></a>
# **GET** **/legalEntities/{id}/pciQuestionnaires/{pciid}**

Get PCI questionnaire

```csharp 
IGetPciQuestionnaireResponse GetPciQuestionnaireAsync(string id, string pciid)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The legal entity ID of the individual who signed the PCI questionnaire. |
| **pciid** | **string** | The unique identifier of the signed PCI questionnaire. |

### Return type

[**GetPciQuestionnaireResponse**](GetPciQuestionnaireResponse.md)

<a id="getpciquestionnairedetails"></a>
# **GET** **/legalEntities/{id}/pciQuestionnaires**

Get PCI questionnaire details

```csharp 
IGetPciQuestionnaireInfosResponse GetPciQuestionnaireDetailsAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity to get PCI questionnaire information. |

### Return type

[**GetPciQuestionnaireInfosResponse**](GetPciQuestionnaireInfosResponse.md)

<a id="signpciquestionnaire"></a>
# **POST** **/legalEntities/{id}/pciQuestionnaires/signPciTemplates**

Sign PCI questionnaire

```csharp 
IPciSigningResponse SignPciQuestionnaireAsync(string id, PciSigningRequest pciSigningRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The legal entity ID of the user that has a contractual relationship with your platform. |
| **pciSigningRequest** | [**PciSigningRequest**](PciSigningRequest.md) |  |

### Return type

[**PciSigningResponse**](PciSigningResponse.md)

