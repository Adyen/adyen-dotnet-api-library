## Adyen.Management.Services.TerminalSettingsTerminalLevelService

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
    ITerminalSettingsTerminalLevelService terminalSettingsTerminalLevelService = host.Services.GetRequiredService<ITerminalSettingsTerminalLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsTerminalLevelService.md#getterminallogo) | **GET** /terminals/{terminalId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsTerminalLevelService.md#getterminalsettings) | **GET** /terminals/{terminalId}/terminalSettings | Get terminal settings |
| [**UpdateLogo**](TerminalSettingsTerminalLevelService.md#updatelogo) | **PATCH** /terminals/{terminalId}/terminalLogos | Update the logo |
| [**UpdateTerminalSettings**](TerminalSettingsTerminalLevelService.md#updateterminalsettings) | **PATCH** /terminals/{terminalId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
### **GET** **/terminals/{terminalId}/terminalLogos**

Get the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | [string] | The unique identifier of the payment terminal. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsTerminalLevelService.GetTerminalLogo` usage:
// Provide the following values: terminalId.
ILogo response = await terminalSettingsTerminalLevelService.GetTerminalLogoAsync(
    string terminalId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Logo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Logo]()


<a id="getterminalsettings"></a>
### **GET** **/terminals/{terminalId}/terminalSettings**

Get terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | [string] | The unique identifier of the payment terminal. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsTerminalLevelService.GetTerminalSettings` usage:
// Provide the following values: terminalId.
ITerminalSettings response = await terminalSettingsTerminalLevelService.GetTerminalSettingsAsync(
    string terminalId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


<a id="updatelogo"></a>
### **PATCH** **/terminals/{terminalId}/terminalLogos**

Update the logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | [string] | The unique identifier of the payment terminal. |
| **logo** | **Logo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsTerminalLevelService.UpdateLogo` usage:
// Provide the following values: terminalId, logo.
ILogo response = await terminalSettingsTerminalLevelService.UpdateLogoAsync(
    string terminalId,
    Logo logo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Logo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Logo]()


<a id="updateterminalsettings"></a>
### **PATCH** **/terminals/{terminalId}/terminalSettings**

Update terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | [string] | The unique identifier of the payment terminal. |
| **terminalSettings** | **TerminalSettings** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsTerminalLevelService.UpdateTerminalSettings` usage:
// Provide the following values: terminalId, terminalSettings.
ITerminalSettings response = await terminalSettingsTerminalLevelService.UpdateTerminalSettingsAsync(
    string terminalId,
    TerminalSettings terminalSettings, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


