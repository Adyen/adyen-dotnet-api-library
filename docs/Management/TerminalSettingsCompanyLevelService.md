## Adyen.Management.Services.TerminalSettingsCompanyLevelService

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
    ITerminalSettingsCompanyLevelService terminalSettingsCompanyLevelService = host.Services.GetRequiredService<ITerminalSettingsCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsCompanyLevelService.md#getterminallogo) | **GET** /companies/{companyId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsCompanyLevelService.md#getterminalsettings) | **GET** /companies/{companyId}/terminalSettings | Get terminal settings |
| [**UpdateTerminalLogo**](TerminalSettingsCompanyLevelService.md#updateterminallogo) | **PATCH** /companies/{companyId}/terminalLogos | Update the terminal logo |
| [**UpdateTerminalSettings**](TerminalSettingsCompanyLevelService.md#updateterminalsettings) | **PATCH** /companies/{companyId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
### **GET** **/companies/{companyId}/terminalLogos**

Get the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsCompanyLevelService.GetTerminalLogo` usage:
// Provide the following values: companyId, model
ILogo response = await terminalSettingsCompanyLevelService.GetTerminalLogoAsync(
    string companyId, string model, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Logo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Logo]()


<a id="getterminalsettings"></a>
### **GET** **/companies/{companyId}/terminalSettings**

Get terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsCompanyLevelService.GetTerminalSettings` usage:
// Provide the following values: companyId
ITerminalSettings response = await terminalSettingsCompanyLevelService.GetTerminalSettingsAsync(
    string companyId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


<a id="updateterminallogo"></a>
### **PATCH** **/companies/{companyId}/terminalLogos**

Update the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| **logo** | **Logo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsCompanyLevelService.UpdateTerminalLogo` usage:
// Provide the following values: companyId, model, logo
ILogo response = await terminalSettingsCompanyLevelService.UpdateTerminalLogoAsync(
    string companyId, string model, Logo logo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Logo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Logo]()


<a id="updateterminalsettings"></a>
### **PATCH** **/companies/{companyId}/terminalSettings**

Update terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **terminalSettings** | **TerminalSettings** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsCompanyLevelService.UpdateTerminalSettings` usage:
// Provide the following values: companyId, terminalSettings
ITerminalSettings response = await terminalSettingsCompanyLevelService.UpdateTerminalSettingsAsync(
    string companyId, TerminalSettings terminalSettings, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


