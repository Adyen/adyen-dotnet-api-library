## Adyen.Management.Services.TerminalsTerminalLevelService

#### API Base-Path: **https://management-test.adyen.com/v3**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureManagement((context, services, config) =>
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
    ITerminalsTerminalLevelService terminalsTerminalLevelService = host.Services.GetRequiredService<ITerminalsTerminalLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListTerminals**](TerminalsTerminalLevelService.md#listterminals) | **GET** /terminals | Get a list of terminals |
| [**ReassignTerminal**](TerminalsTerminalLevelService.md#reassignterminal) | **POST** /terminals/{terminalId}/reassign | Reassign a terminal |

<a id="listterminals"></a>
### **GET** **/terminals**

Get a list of terminals

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **searchQuery** | [string] | Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored. |
| **otpQuery** | [string] | Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored. |
| **countries** | [string] | Returns terminals located in the countries specified by their [two-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). |
| **merchantIds** | [string] | Returns terminals that belong to the merchant accounts specified by their unique merchant account ID. |
| **storeIds** | [string] | Returns terminals that are assigned to the [stores](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores) specified by their unique store ID. |
| **brandModels** | [string] | Returns terminals of the [models](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) specified in the format *brand.model*. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 20 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalsTerminalLevelService.ListTerminals` usage:
// Provide the following values: searchQuery, otpQuery, countries, merchantIds, storeIds, brandModels, pageNumber, pageSize.
IListTerminalsResponse response = await terminalsTerminalLevelService.ListTerminalsAsync(
    string searchQuery,
    string otpQuery,
    string countries,
    string merchantIds,
    string storeIds,
    string brandModels,
    int pageNumber,
    int pageSize, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListTerminalsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListTerminalsResponse]()


<a id="reassignterminal"></a>
### **POST** **/terminals/{terminalId}/reassign**

Reassign a terminal

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | [string] | The unique identifier of the payment terminal. |
| **terminalReassignmentRequest** | **TerminalReassignmentRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalsTerminalLevelService.ReassignTerminal` usage:
// Provide the following values: terminalId, terminalReassignmentRequest.
I response = await terminalsTerminalLevelService.ReassignTerminalAsync(
    string terminalId,
    TerminalReassignmentRequest terminalReassignmentRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


