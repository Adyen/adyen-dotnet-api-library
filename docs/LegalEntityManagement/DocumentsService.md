## Adyen.LegalEntityManagement.Services.DocumentsService

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
    IDocumentsService documentsService = host.Services.GetRequiredService<IDocumentsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteDocument**](DocumentsService.md#deletedocument) | **DELETE** /documents/{id} | Delete a document |
| [**GetDocument**](DocumentsService.md#getdocument) | **GET** /documents/{id} | Get a document |
| [**UpdateDocument**](DocumentsService.md#updatedocument) | **PATCH** /documents/{id} | Update a document |
| [**UploadDocumentForVerificationChecks**](DocumentsService.md#uploaddocumentforverificationchecks) | **POST** /documents | Upload a document for verification checks |

<a id="deletedocument"></a>
### **DELETE** **/documents/{id}**

Delete a document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the document to be deleted. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `DocumentsService.DeleteDocument` usage:
// Provide the following values: id
await documentsService.DeleteDocumentAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getdocument"></a>
### **GET** **/documents/{id}**

Get a document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the document. |
| **skipContent** | [bool] | Do not load document content while fetching the document. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `DocumentsService.GetDocument` usage:
// Provide the following values: id, skipContent
IDocument response = await documentsService.GetDocumentAsync(
    string id, Option<bool> skipContent = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Document result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Document]()


<a id="updatedocument"></a>
### **PATCH** **/documents/{id}**

Update a document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the document to be updated. |
| **xRequestedVerificationCode** | [string] | Use the requested verification code 0_0001 to resolve any suberrors associated with the document. Requested verification codes can only be used in your test environment. |
| **document** | **Document** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `DocumentsService.UpdateDocument` usage:
// Provide the following values: id, [HeaderParameter] xRequestedVerificationCode, document
IDocument response = await documentsService.UpdateDocumentAsync(
    string id, Document document, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Document result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Document]()


<a id="uploaddocumentforverificationchecks"></a>
### **POST** **/documents**

Upload a document for verification checks

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **xRequestedVerificationCode** | [string] | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| **document** | **Document** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `DocumentsService.UploadDocumentForVerificationChecks` usage:
// Provide the following values: [HeaderParameter] xRequestedVerificationCode, document
IDocument response = await documentsService.UploadDocumentForVerificationChecksAsync(
    Document document, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Document result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Document]()


