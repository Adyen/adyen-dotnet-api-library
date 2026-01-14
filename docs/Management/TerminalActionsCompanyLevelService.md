## Adyen.Management.Services.TerminalActionsCompanyLevelService

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
    ITerminalActionsCompanyLevelService terminalActionsCompanyLevelService = host.Services.GetRequiredService<ITerminalActionsCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalAction**](TerminalActionsCompanyLevelService.md#getterminalaction) | **GET** /companies/{companyId}/terminalActions/{actionId} | Get terminal action |
| [**ListTerminalActions**](TerminalActionsCompanyLevelService.md#listterminalactions) | **GET** /companies/{companyId}/terminalActions | Get a list of terminal actions |

<a id="getterminalaction"></a>
### **GET** **/companies/{companyId}/terminalActions/{actionId}**

Get terminal action

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **actionId** | [string] | The unique identifier of the terminal action. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalActionsCompanyLevelService.GetTerminalAction` usage:
// Provide the following values: companyId, actionId
IExternalTerminalAction response = await terminalActionsCompanyLevelService.GetTerminalActionAsync(
    string companyId, string actionId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ExternalTerminalAction result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ExternalTerminalAction]()


<a id="listterminalactions"></a>
### **GET** **/companies/{companyId}/terminalActions**

Get a list of terminal actions

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| **status** | [string] | Returns terminal actions with the specified status.  Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**. |
| **type** | [string] | Returns terminal actions of the specified type.  Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalActionsCompanyLevelService.ListTerminalActions` usage:
// Provide the following values: companyId, pageNumber, pageSize, status, type
IListExternalTerminalActionsResponse response = await terminalActionsCompanyLevelService.ListTerminalActionsAsync(
    string companyId, Option<int> pageNumber = default, Option<int> pageSize = default, Option<string> status = default, Option<string> type = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListExternalTerminalActionsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListExternalTerminalActionsResponse]()


