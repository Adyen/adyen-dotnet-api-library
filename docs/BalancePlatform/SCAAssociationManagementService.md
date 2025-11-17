## Adyen.BalancePlatform.Services.SCAAssociationManagementService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    ISCAAssociationManagementService sCAAssociationManagementService = host.Services.GetRequiredService<ISCAAssociationManagementService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApproveAssociation**](SCAAssociationManagementService.md#approveassociation) | **PATCH** /scaAssociations | Approve a pending approval association |
| [**ListAssociations**](SCAAssociationManagementService.md#listassociations) | **GET** /scaAssociations | Get a list of devices associated with an entity |
| [**RemoveAssociation**](SCAAssociationManagementService.md#removeassociation) | **DELETE** /scaAssociations | Delete association to devices |

<a id="approveassociation"></a>
### **PATCH** **/scaAssociations**

Approve a pending approval association

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **wWWAuthenticate** | [string] | The header for authenticating through SCA. |
| **approveAssociationRequest** | **ApproveAssociationRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `SCAAssociationManagementService.ApproveAssociation` usage:
// Provide the following values: [HeaderParameter] wWWAuthenticate, approveAssociationRequest
IApproveAssociationResponse response = await sCAAssociationManagementService.ApproveAssociationAsync(
    ApproveAssociationRequest approveAssociationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ApproveAssociationResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ApproveAssociationResponse]()


<a id="listassociations"></a>
### **GET** **/scaAssociations**

Get a list of devices associated with an entity

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **entityType** | [ScaEntityType] | The type of entity you want to retrieve a list of associations for.   Possible values: **accountHolder** or **paymentInstrument**. |
| **entityId** | [string] | The unique identifier of the entity. |
| **pageSize** | [int] | The number of items to have on a page.   Default: **5**. |
| **pageNumber** | [int] | The index of the page to retrieve. The index of the first page is **0** (zero).   Default:  **0**. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `SCAAssociationManagementService.ListAssociations` usage:
// Provide the following values: entityType, entityId, pageSize, pageNumber
IListAssociationsResponse response = await sCAAssociationManagementService.ListAssociationsAsync(
    ScaEntityType entityType, string entityId, int pageSize, int pageNumber, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListAssociationsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListAssociationsResponse]()


<a id="removeassociation"></a>
### **DELETE** **/scaAssociations**

Delete association to devices

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **wWWAuthenticate** | [string] | The header for authenticating through SCA. |
| **removeAssociationRequest** | **RemoveAssociationRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `SCAAssociationManagementService.RemoveAssociation` usage:
// Provide the following values: [HeaderParameter] wWWAuthenticate, removeAssociationRequest
await sCAAssociationManagementService.RemoveAssociationAsync(
    RemoveAssociationRequest removeAssociationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


