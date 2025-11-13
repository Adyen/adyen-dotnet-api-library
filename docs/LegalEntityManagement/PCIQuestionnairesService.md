## Adyen.LegalEntityManagement.Services.PCIQuestionnairesService

#### API Base-Path: **https://kyc-test.adyen.com/lem/v4**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureLegalEntityManagement((context, services, config) =>
    {
        config.ConfigureAdyenOptions(options =>
        {
            // Set your ADYEN_API_KEY or use get it from your environment using context.Configuration["ADYEN_API_KEY"].
            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];

            // Set your environment, e.g. `Test` or `Live`.
            options.Environment = AdyenEnvironment.Test;

            // For the Live environment, additionally include your LiveEndpointUrlPrefix.
            options.LiveEndpointUrlPrefix = "your-live-endpoint-url-prefix";
        });
    })
    .Build();

    // You can inject this service in your constructor.
    IPCIQuestionnairesService pCIQuestionnairesService = host.Services.GetRequiredService<IPCIQuestionnairesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculatePciStatusOfLegalEntity**](PCIQuestionnairesService.md#calculatepcistatusoflegalentity) | **POST** /legalEntities/{id}/pciQuestionnaires/signingRequired | Calculate PCI status of a legal entity |
| [**GeneratePciQuestionnaire**](PCIQuestionnairesService.md#generatepciquestionnaire) | **POST** /legalEntities/{id}/pciQuestionnaires/generatePciTemplates | Generate PCI questionnaire |
| [**GetPciQuestionnaire**](PCIQuestionnairesService.md#getpciquestionnaire) | **GET** /legalEntities/{id}/pciQuestionnaires/{pciid} | Get PCI questionnaire |
| [**GetPciQuestionnaireDetails**](PCIQuestionnairesService.md#getpciquestionnairedetails) | **GET** /legalEntities/{id}/pciQuestionnaires | Get PCI questionnaire details |
| [**SignPciQuestionnaire**](PCIQuestionnairesService.md#signpciquestionnaire) | **POST** /legalEntities/{id}/pciQuestionnaires/signPciTemplates | Sign PCI questionnaire |

<a id="calculatepcistatusoflegalentity"></a>
### **POST** **/legalEntities/{id}/pciQuestionnaires/signingRequired**

Calculate PCI status of a legal entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity to calculate PCI status. |
| **calculatePciStatusRequest** | **CalculatePciStatusRequest** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `PCIQuestionnairesService.CalculatePciStatusOfLegalEntity` usage:
// Provide the following values: id, calculatePciStatusRequest
ICalculatePciStatusResponse response = await pCIQuestionnairesService.CalculatePciStatusOfLegalEntityAsync(
    string id,
    CalculatePciStatusRequest calculatePciStatusRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CalculatePciStatusResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CalculatePciStatusResponse]()


<a id="generatepciquestionnaire"></a>
### **POST** **/legalEntities/{id}/pciQuestionnaires/generatePciTemplates**

Generate PCI questionnaire

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity to get PCI questionnaire information. |
| **generatePciDescriptionRequest** | **GeneratePciDescriptionRequest** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `PCIQuestionnairesService.GeneratePciQuestionnaire` usage:
// Provide the following values: id, generatePciDescriptionRequest
IGeneratePciDescriptionResponse response = await pCIQuestionnairesService.GeneratePciQuestionnaireAsync(
    string id,
    GeneratePciDescriptionRequest generatePciDescriptionRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GeneratePciDescriptionResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GeneratePciDescriptionResponse]()


<a id="getpciquestionnaire"></a>
### **GET** **/legalEntities/{id}/pciQuestionnaires/{pciid}**

Get PCI questionnaire

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The legal entity ID of the individual who signed the PCI questionnaire. |
| **pciid** | [string] | The unique identifier of the signed PCI questionnaire. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `PCIQuestionnairesService.GetPciQuestionnaire` usage:
// Provide the following values: id, pciid
IGetPciQuestionnaireResponse response = await pCIQuestionnairesService.GetPciQuestionnaireAsync(
    string id,
    string pciid, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetPciQuestionnaireResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetPciQuestionnaireResponse]()


<a id="getpciquestionnairedetails"></a>
### **GET** **/legalEntities/{id}/pciQuestionnaires**

Get PCI questionnaire details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity to get PCI questionnaire information. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `PCIQuestionnairesService.GetPciQuestionnaireDetails` usage:
// Provide the following values: id
IGetPciQuestionnaireInfosResponse response = await pCIQuestionnairesService.GetPciQuestionnaireDetailsAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetPciQuestionnaireInfosResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetPciQuestionnaireInfosResponse]()


<a id="signpciquestionnaire"></a>
### **POST** **/legalEntities/{id}/pciQuestionnaires/signPciTemplates**

Sign PCI questionnaire

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The legal entity ID of the user that has a contractual relationship with your platform. |
| **pciSigningRequest** | **PciSigningRequest** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `PCIQuestionnairesService.SignPciQuestionnaire` usage:
// Provide the following values: id, pciSigningRequest
IPciSigningResponse response = await pCIQuestionnairesService.SignPciQuestionnaireAsync(
    string id,
    PciSigningRequest pciSigningRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PciSigningResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PciSigningResponse]()


