## Adyen.Management.Services.TerminalSettingsMerchantLevelService

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
    ITerminalSettingsMerchantLevelService terminalSettingsMerchantLevelService = host.Services.GetRequiredService<ITerminalSettingsMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsMerchantLevelService.md#getterminallogo) | **GET** /merchants/{merchantId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsMerchantLevelService.md#getterminalsettings) | **GET** /merchants/{merchantId}/terminalSettings | Get terminal settings |
| [**UpdateTerminalLogo**](TerminalSettingsMerchantLevelService.md#updateterminallogo) | **PATCH** /merchants/{merchantId}/terminalLogos | Update the terminal logo |
| [**UpdateTerminalSettings**](TerminalSettingsMerchantLevelService.md#updateterminalsettings) | **PATCH** /merchants/{merchantId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
### **GET** **/merchants/{merchantId}/terminalLogos**

Get the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsMerchantLevelService.GetTerminalLogo` usage:
// Provide the following values: merchantId, model
ILogo response = await terminalSettingsMerchantLevelService.GetTerminalLogoAsync(
    string merchantId, string model, 
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
### **GET** **/merchants/{merchantId}/terminalSettings**

Get terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsMerchantLevelService.GetTerminalSettings` usage:
// Provide the following values: merchantId
ITerminalSettings response = await terminalSettingsMerchantLevelService.GetTerminalSettingsAsync(
    string merchantId, 
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
### **PATCH** **/merchants/{merchantId}/terminalLogos**

Update the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **model** | [string] | The terminal model. Allowed values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| **logo** | **Logo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsMerchantLevelService.UpdateTerminalLogo` usage:
// Provide the following values: merchantId, model, logo
ILogo response = await terminalSettingsMerchantLevelService.UpdateTerminalLogoAsync(
    string merchantId, string model, Logo logo, 
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
### **PATCH** **/merchants/{merchantId}/terminalSettings**

Update terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **terminalSettings** | **TerminalSettings** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsMerchantLevelService.UpdateTerminalSettings` usage:
// Provide the following values: merchantId, terminalSettings
ITerminalSettings response = await terminalSettingsMerchantLevelService.UpdateTerminalSettingsAsync(
    string merchantId, TerminalSettings terminalSettings, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


