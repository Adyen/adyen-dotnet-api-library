## Adyen.Disputes.Services.DisputesService

#### API Base-Path: **https://ca-test.adyen.com/ca/services/DisputeService/v30**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Disputes.Extensions;
using Adyen.Disputes.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureDisputes((context, services, config) =>
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
    IDisputesService disputesService = host.Services.GetRequiredService<IDisputesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptDispute**](DisputesService.md#acceptdispute) | **POST** /acceptDispute | Accept a dispute |
| [**DefendDispute**](DisputesService.md#defenddispute) | **POST** /defendDispute | Defend a dispute |
| [**DeleteDisputeDefenseDocument**](DisputesService.md#deletedisputedefensedocument) | **POST** /deleteDisputeDefenseDocument | Delete a defense document |
| [**RetrieveApplicableDefenseReasons**](DisputesService.md#retrieveapplicabledefensereasons) | **POST** /retrieveApplicableDefenseReasons | Get applicable defense reasons |
| [**SupplyDefenseDocument**](DisputesService.md#supplydefensedocument) | **POST** /supplyDefenseDocument | Supply a defense document |

<a id="acceptdispute"></a>
### **POST** **/acceptDispute**

Accept a dispute

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **acceptDisputeRequest** | **AcceptDisputeRequest** |  |

#### Example usage

```csharp
using Adyen.Disputes.Models;
using Adyen.Disputes.Services;

// Example `DisputesService.AcceptDispute` usage:
// Provide the following values: acceptDisputeRequest
IAcceptDisputeResponse response = await disputesService.AcceptDisputeAsync(
    AcceptDisputeRequest acceptDisputeRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AcceptDisputeResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AcceptDisputeResponse]()


<a id="defenddispute"></a>
### **POST** **/defendDispute**

Defend a dispute

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **defendDisputeRequest** | **DefendDisputeRequest** |  |

#### Example usage

```csharp
using Adyen.Disputes.Models;
using Adyen.Disputes.Services;

// Example `DisputesService.DefendDispute` usage:
// Provide the following values: defendDisputeRequest
IDefendDisputeResponse response = await disputesService.DefendDisputeAsync(
    DefendDisputeRequest defendDisputeRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DefendDisputeResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DefendDisputeResponse]()


<a id="deletedisputedefensedocument"></a>
### **POST** **/deleteDisputeDefenseDocument**

Delete a defense document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deleteDefenseDocumentRequest** | **DeleteDefenseDocumentRequest** |  |

#### Example usage

```csharp
using Adyen.Disputes.Models;
using Adyen.Disputes.Services;

// Example `DisputesService.DeleteDisputeDefenseDocument` usage:
// Provide the following values: deleteDefenseDocumentRequest
IDeleteDefenseDocumentResponse response = await disputesService.DeleteDisputeDefenseDocumentAsync(
    DeleteDefenseDocumentRequest deleteDefenseDocumentRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DeleteDefenseDocumentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DeleteDefenseDocumentResponse]()


<a id="retrieveapplicabledefensereasons"></a>
### **POST** **/retrieveApplicableDefenseReasons**

Get applicable defense reasons

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **defenseReasonsRequest** | **DefenseReasonsRequest** |  |

#### Example usage

```csharp
using Adyen.Disputes.Models;
using Adyen.Disputes.Services;

// Example `DisputesService.RetrieveApplicableDefenseReasons` usage:
// Provide the following values: defenseReasonsRequest
IDefenseReasonsResponse response = await disputesService.RetrieveApplicableDefenseReasonsAsync(
    DefenseReasonsRequest defenseReasonsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DefenseReasonsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DefenseReasonsResponse]()


<a id="supplydefensedocument"></a>
### **POST** **/supplyDefenseDocument**

Supply a defense document

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **supplyDefenseDocumentRequest** | **SupplyDefenseDocumentRequest** |  |

#### Example usage

```csharp
using Adyen.Disputes.Models;
using Adyen.Disputes.Services;

// Example `DisputesService.SupplyDefenseDocument` usage:
// Provide the following values: supplyDefenseDocumentRequest
ISupplyDefenseDocumentResponse response = await disputesService.SupplyDefenseDocumentAsync(
    SupplyDefenseDocumentRequest supplyDefenseDocumentRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SupplyDefenseDocumentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SupplyDefenseDocumentResponse]()


