## Adyen.LegalEntityManagement.Services.BusinessLinesService

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
    IBusinessLinesService businessLinesService = host.Services.GetRequiredService<IBusinessLinesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBusinessLine**](BusinessLinesService.md#createbusinessline) | **POST** /businessLines | Create a business line |
| [**DeleteBusinessLine**](BusinessLinesService.md#deletebusinessline) | **DELETE** /businessLines/{id} | Delete a business line |
| [**GetBusinessLine**](BusinessLinesService.md#getbusinessline) | **GET** /businessLines/{id} | Get a business line |
| [**UpdateBusinessLine**](BusinessLinesService.md#updatebusinessline) | **PATCH** /businessLines/{id} | Update a business line |

<a id="createbusinessline"></a>
### **POST** **/businessLines**

Create a business line

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **businessLineInfo** | **BusinessLineInfo** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `BusinessLinesService.CreateBusinessLine` usage:
// Provide the following values: businessLineInfo
IBusinessLine response = await businessLinesService.CreateBusinessLineAsync(
    BusinessLineInfo businessLineInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BusinessLine result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BusinessLine]()


<a id="deletebusinessline"></a>
### **DELETE** **/businessLines/{id}**

Delete a business line

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the business line to be deleted. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `BusinessLinesService.DeleteBusinessLine` usage:
// Provide the following values: id
await businessLinesService.DeleteBusinessLineAsync(
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


<a id="getbusinessline"></a>
### **GET** **/businessLines/{id}**

Get a business line

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the business line. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `BusinessLinesService.GetBusinessLine` usage:
// Provide the following values: id
IBusinessLine response = await businessLinesService.GetBusinessLineAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BusinessLine result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BusinessLine]()


<a id="updatebusinessline"></a>
### **PATCH** **/businessLines/{id}**

Update a business line

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the business line. |
| **businessLineInfoUpdate** | **BusinessLineInfoUpdate** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `BusinessLinesService.UpdateBusinessLine` usage:
// Provide the following values: id, businessLineInfoUpdate
IBusinessLine response = await businessLinesService.UpdateBusinessLineAsync(
    string id,
    BusinessLineInfoUpdate businessLineInfoUpdate, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BusinessLine result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BusinessLine]()


