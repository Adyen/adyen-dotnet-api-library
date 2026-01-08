## Adyen.LegalEntityManagement.Services.TermsOfServiceService

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
    ITermsOfServiceService termsOfServiceService = host.Services.GetRequiredService<ITermsOfServiceService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptTermsOfService**](TermsOfServiceService.md#accepttermsofservice) | **PATCH** /legalEntities/{id}/termsOfService/{termsofservicedocumentid} | Accept Terms of Service |
| [**GetAcceptedTermsOfServiceDocument**](TermsOfServiceService.md#getacceptedtermsofservicedocument) | **GET** /legalEntities/{id}/acceptedTermsOfServiceDocument/{termsofserviceacceptancereference} | Get accepted Terms of Service document |
| [**GetTermsOfServiceDocument**](TermsOfServiceService.md#gettermsofservicedocument) | **POST** /legalEntities/{id}/termsOfService | Get Terms of Service document |
| [**GetTermsOfServiceInformationForLegalEntity**](TermsOfServiceService.md#gettermsofserviceinformationforlegalentity) | **GET** /legalEntities/{id}/termsOfServiceAcceptanceInfos | Get Terms of Service information for a legal entity |
| [**GetTermsOfServiceStatus**](TermsOfServiceService.md#gettermsofservicestatus) | **GET** /legalEntities/{id}/termsOfServiceStatus | Get Terms of Service status |

<a id="accepttermsofservice"></a>
### **PATCH** **/legalEntities/{id}/termsOfService/{termsofservicedocumentid}**

Accept Terms of Service

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity.  For sole proprietorships, this is the individual legal entity ID of the owner.  For organizations, this is the ID of the organization.  For legal representatives of individuals, this is the ID of the individual.   |
| **termsofservicedocumentid** | [string] | The unique identifier of the Terms of Service document. |
| **acceptTermsOfServiceRequest** | **AcceptTermsOfServiceRequest** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TermsOfServiceService.AcceptTermsOfService` usage:
// Provide the following values: id, termsofservicedocumentid, acceptTermsOfServiceRequest
IAcceptTermsOfServiceResponse response = await termsOfServiceService.AcceptTermsOfServiceAsync(
    string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest acceptTermsOfServiceRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AcceptTermsOfServiceResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AcceptTermsOfServiceResponse]()


<a id="getacceptedtermsofservicedocument"></a>
### **GET** **/legalEntities/{id}/acceptedTermsOfServiceDocument/{termsofserviceacceptancereference}**

Get accepted Terms of Service document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. For sole proprietorship, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| **termsofserviceacceptancereference** | [string] | An Adyen-generated reference for the accepted Terms of Service. |
| **termsOfServiceDocumentFormat** | [string] | The format of the Terms of Service document. Possible values: **JSON**, **PDF**, or **TXT** |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TermsOfServiceService.GetAcceptedTermsOfServiceDocument` usage:
// Provide the following values: id, termsofserviceacceptancereference, termsOfServiceDocumentFormat
IGetAcceptedTermsOfServiceDocumentResponse response = await termsOfServiceService.GetAcceptedTermsOfServiceDocumentAsync(
    string id, string termsofserviceacceptancereference, Option<string> termsOfServiceDocumentFormat = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetAcceptedTermsOfServiceDocumentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetAcceptedTermsOfServiceDocumentResponse]()


<a id="gettermsofservicedocument"></a>
### **POST** **/legalEntities/{id}/termsOfService**

Get Terms of Service document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| **getTermsOfServiceDocumentRequest** | **GetTermsOfServiceDocumentRequest** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TermsOfServiceService.GetTermsOfServiceDocument` usage:
// Provide the following values: id, getTermsOfServiceDocumentRequest
IGetTermsOfServiceDocumentResponse response = await termsOfServiceService.GetTermsOfServiceDocumentAsync(
    string id, GetTermsOfServiceDocumentRequest getTermsOfServiceDocumentRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetTermsOfServiceDocumentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetTermsOfServiceDocumentResponse]()


<a id="gettermsofserviceinformationforlegalentity"></a>
### **GET** **/legalEntities/{id}/termsOfServiceAcceptanceInfos**

Get Terms of Service information for a legal entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TermsOfServiceService.GetTermsOfServiceInformationForLegalEntity` usage:
// Provide the following values: id
IGetTermsOfServiceAcceptanceInfosResponse response = await termsOfServiceService.GetTermsOfServiceInformationForLegalEntityAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetTermsOfServiceAcceptanceInfosResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetTermsOfServiceAcceptanceInfosResponse]()


<a id="gettermsofservicestatus"></a>
### **GET** **/legalEntities/{id}/termsOfServiceStatus**

Get Terms of Service status

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TermsOfServiceService.GetTermsOfServiceStatus` usage:
// Provide the following values: id
ICalculateTermsOfServiceStatusResponse response = await termsOfServiceService.GetTermsOfServiceStatusAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CalculateTermsOfServiceStatusResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CalculateTermsOfServiceStatusResponse]()


