## Adyen.LegalEntityManagement.Services.LegalEntitiesService

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
    ILegalEntitiesService legalEntitiesService = host.Services.GetRequiredService<ILegalEntitiesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckLegalEntitysVerificationErrors**](LegalEntitiesService.md#checklegalentitysverificationerrors) | **POST** /legalEntities/{id}/checkVerificationErrors | Check a legal entity&#39;s verification errors |
| [**ConfirmDataReview**](LegalEntitiesService.md#confirmdatareview) | **POST** /legalEntities/{id}/confirmDataReview | Confirm data review |
| [**CreateLegalEntity**](LegalEntitiesService.md#createlegalentity) | **POST** /legalEntities | Create a legal entity |
| [**GetAllBusinessLinesUnderLegalEntity**](LegalEntitiesService.md#getallbusinesslinesunderlegalentity) | **GET** /legalEntities/{id}/businessLines | Get all business lines under a legal entity |
| [**GetLegalEntity**](LegalEntitiesService.md#getlegalentity) | **GET** /legalEntities/{id} | Get a legal entity |
| [**UpdateLegalEntity**](LegalEntitiesService.md#updatelegalentity) | **PATCH** /legalEntities/{id} | Update a legal entity |

<a id="checklegalentitysverificationerrors"></a>
### **POST** **/legalEntities/{id}/checkVerificationErrors**

Check a legal entity's verification errors

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `LegalEntitiesService.CheckLegalEntitysVerificationErrors` usage:
// Provide the following values: id.
IVerificationErrors response = await legalEntitiesService.CheckLegalEntitysVerificationErrorsAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out VerificationErrors result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[VerificationErrors]()


<a id="confirmdatareview"></a>
### **POST** **/legalEntities/{id}/confirmDataReview**

Confirm data review

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `LegalEntitiesService.ConfirmDataReview` usage:
// Provide the following values: id.
IDataReviewConfirmationResponse response = await legalEntitiesService.ConfirmDataReviewAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DataReviewConfirmationResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DataReviewConfirmationResponse]()


<a id="createlegalentity"></a>
### **POST** **/legalEntities**

Create a legal entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **xRequestedVerificationCode** | [string] | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| **legalEntityInfoRequiredType** | **LegalEntityInfoRequiredType** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `LegalEntitiesService.CreateLegalEntity` usage:
// Provide the following values: xRequestedVerificationCode, legalEntityInfoRequiredType.
ILegalEntity response = await legalEntitiesService.CreateLegalEntityAsync(
    string xRequestedVerificationCode,
    LegalEntityInfoRequiredType legalEntityInfoRequiredType, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out LegalEntity result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[LegalEntity]()


<a id="getallbusinesslinesunderlegalentity"></a>
### **GET** **/legalEntities/{id}/businessLines**

Get all business lines under a legal entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `LegalEntitiesService.GetAllBusinessLinesUnderLegalEntity` usage:
// Provide the following values: id.
IBusinessLines response = await legalEntitiesService.GetAllBusinessLinesUnderLegalEntityAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BusinessLines result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BusinessLines]()


<a id="getlegalentity"></a>
### **GET** **/legalEntities/{id}**

Get a legal entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `LegalEntitiesService.GetLegalEntity` usage:
// Provide the following values: id.
ILegalEntity response = await legalEntitiesService.GetLegalEntityAsync(
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out LegalEntity result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[LegalEntity]()


<a id="updatelegalentity"></a>
### **PATCH** **/legalEntities/{id}**

Update a legal entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. |
| **xRequestedVerificationCode** | [string] | Use the requested verification code 0_0001 to resolve any suberrors associated with the legal entity. Requested verification codes can only be used in your test environment. |
| **legalEntityInfo** | **LegalEntityInfo** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `LegalEntitiesService.UpdateLegalEntity` usage:
// Provide the following values: id, xRequestedVerificationCode, legalEntityInfo.
ILegalEntity response = await legalEntitiesService.UpdateLegalEntityAsync(
    string id,
    string xRequestedVerificationCode,
    LegalEntityInfo legalEntityInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out LegalEntity result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[LegalEntity]()


