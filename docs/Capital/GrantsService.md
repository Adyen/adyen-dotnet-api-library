## Adyen.Capital.Services.GrantsService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/capital/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Capital.Extensions;
using Adyen.Capital.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureCapital((context, services, config) =>
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
    IGrantsService grantsService = host.Services.GetRequiredService<IGrantsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllGrantDisbursements**](GrantsService.md#getallgrantdisbursements) | **GET** /grants/{grantId}/disbursements | Get all the disbursements of a grant |
| [**GetAllGrants**](GrantsService.md#getallgrants) | **GET** /grants | Get all the grants of an account holder |
| [**GetGrant**](GrantsService.md#getgrant) | **GET** /grants/{grantId} | Get the details of a grant |
| [**GetGrantDisbursement**](GrantsService.md#getgrantdisbursement) | **GET** /grants/{grantId}/disbursements/{disbursementId} | Get disbursement details |
| [**RequestGrant**](GrantsService.md#requestgrant) | **POST** /grants | Make a request for a grant |
| [**UpdateGrantDisbursement**](GrantsService.md#updategrantdisbursement) | **PATCH** /grants/{grantId}/disbursements/{disbursementId} | Update the repayment configuration of a disbursement |

<a id="getallgrantdisbursements"></a>
### **GET** **/grants/{grantId}/disbursements**

Get all the disbursements of a grant

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantId** | [string] | The unique identifier of the grant reference. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantsService.GetAllGrantDisbursements` usage:
// Provide the following values: grantId
IDisbursements response = await grantsService.GetAllGrantDisbursementsAsync(
    string grantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Disbursements result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Disbursements]()


<a id="getallgrants"></a>
### **GET** **/grants**

Get all the grants of an account holder

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **counterpartyAccountHolderId** | [string] | The unique identifier of the account holder that received the grants. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantsService.GetAllGrants` usage:
// Provide the following values: counterpartyAccountHolderId
IGrants response = await grantsService.GetAllGrantsAsync(
    string counterpartyAccountHolderId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Grants result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Grants]()


<a id="getgrant"></a>
### **GET** **/grants/{grantId}**

Get the details of a grant

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantId** | [string] | The unique identifier of the grant reference. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantsService.GetGrant` usage:
// Provide the following values: grantId
IGrant response = await grantsService.GetGrantAsync(
    string grantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Grant result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Grant]()


<a id="getgrantdisbursement"></a>
### **GET** **/grants/{grantId}/disbursements/{disbursementId}**

Get disbursement details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantId** | [string] | The unique identifier of the grant reference. |
| **disbursementId** | [string] | The unique identifier of the disbursement. |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantsService.GetGrantDisbursement` usage:
// Provide the following values: grantId, disbursementId
IDisbursement response = await grantsService.GetGrantDisbursementAsync(
    string grantId, string disbursementId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Disbursement result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Disbursement]()


<a id="requestgrant"></a>
### **POST** **/grants**

Make a request for a grant

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantInfo** | **GrantInfo** |  |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantsService.RequestGrant` usage:
// Provide the following values: grantInfo
IGrant response = await grantsService.RequestGrantAsync(
    GrantInfo grantInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Grant result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Grant]()


<a id="updategrantdisbursement"></a>
### **PATCH** **/grants/{grantId}/disbursements/{disbursementId}**

Update the repayment configuration of a disbursement

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantId** | [string] | The unique identifier of the grant reference. |
| **disbursementId** | [string] | The unique identifier of the disbursement. |
| **disbursementInfoUpdate** | **DisbursementInfoUpdate** |  |

#### Example usage

```csharp
using Adyen.Capital.Models;
using Adyen.Capital.Services;

// Example `GrantsService.UpdateGrantDisbursement` usage:
// Provide the following values: grantId, disbursementId, disbursementInfoUpdate
IDisbursement response = await grantsService.UpdateGrantDisbursementAsync(
    string grantId, string disbursementId, DisbursementInfoUpdate disbursementInfoUpdate, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Disbursement result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Disbursement]()


