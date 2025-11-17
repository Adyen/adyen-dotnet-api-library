## Adyen.Management.Services.TerminalSettingsStoreLevelService

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
    ITerminalSettingsStoreLevelService terminalSettingsStoreLevelService = host.Services.GetRequiredService<ITerminalSettingsStoreLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsStoreLevelService.md#getterminallogo) | **GET** /merchants/{merchantId}/stores/{reference}/terminalLogos | Get the terminal logo |
| [**GetTerminalLogoByStoreId**](TerminalSettingsStoreLevelService.md#getterminallogobystoreid) | **GET** /stores/{storeId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsStoreLevelService.md#getterminalsettings) | **GET** /merchants/{merchantId}/stores/{reference}/terminalSettings | Get terminal settings |
| [**GetTerminalSettingsByStoreId**](TerminalSettingsStoreLevelService.md#getterminalsettingsbystoreid) | **GET** /stores/{storeId}/terminalSettings | Get terminal settings |
| [**UpdateTerminalLogo**](TerminalSettingsStoreLevelService.md#updateterminallogo) | **PATCH** /merchants/{merchantId}/stores/{reference}/terminalLogos | Update the terminal logo |
| [**UpdateTerminalLogoByStoreId**](TerminalSettingsStoreLevelService.md#updateterminallogobystoreid) | **PATCH** /stores/{storeId}/terminalLogos | Update the terminal logo |
| [**UpdateTerminalSettings**](TerminalSettingsStoreLevelService.md#updateterminalsettings) | **PATCH** /merchants/{merchantId}/stores/{reference}/terminalSettings | Update terminal settings |
| [**UpdateTerminalSettingsByStoreId**](TerminalSettingsStoreLevelService.md#updateterminalsettingsbystoreid) | **PATCH** /stores/{storeId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
### **GET** **/merchants/{merchantId}/stores/{reference}/terminalLogos**

Get the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **reference** | [string] | The reference that identifies the store. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.GetTerminalLogo` usage:
// Provide the following values: merchantId, reference, model
ILogo response = await terminalSettingsStoreLevelService.GetTerminalLogoAsync(
    string merchantId, string reference, string model, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Logo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Logo]()


<a id="getterminallogobystoreid"></a>
### **GET** **/stores/{storeId}/terminalLogos**

Get the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | [string] | The unique identifier of the store. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.GetTerminalLogoByStoreId` usage:
// Provide the following values: storeId, model
ILogo response = await terminalSettingsStoreLevelService.GetTerminalLogoByStoreIdAsync(
    string storeId, string model, 
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
### **GET** **/merchants/{merchantId}/stores/{reference}/terminalSettings**

Get terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **reference** | [string] | The reference that identifies the store. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.GetTerminalSettings` usage:
// Provide the following values: merchantId, reference
ITerminalSettings response = await terminalSettingsStoreLevelService.GetTerminalSettingsAsync(
    string merchantId, string reference, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


<a id="getterminalsettingsbystoreid"></a>
### **GET** **/stores/{storeId}/terminalSettings**

Get terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | [string] | The unique identifier of the store. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.GetTerminalSettingsByStoreId` usage:
// Provide the following values: storeId
ITerminalSettings response = await terminalSettingsStoreLevelService.GetTerminalSettingsByStoreIdAsync(
    string storeId, 
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
### **PATCH** **/merchants/{merchantId}/stores/{reference}/terminalLogos**

Update the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **reference** | [string] | The reference that identifies the store. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T |
| **logo** | **Logo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.UpdateTerminalLogo` usage:
// Provide the following values: merchantId, reference, model, logo
ILogo response = await terminalSettingsStoreLevelService.UpdateTerminalLogoAsync(
    string merchantId, string reference, string model, Logo logo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Logo result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Logo]()


<a id="updateterminallogobystoreid"></a>
### **PATCH** **/stores/{storeId}/terminalLogos**

Update the terminal logo

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | [string] | The unique identifier of the store. |
| **model** | [string] | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| **logo** | **Logo** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.UpdateTerminalLogoByStoreId` usage:
// Provide the following values: storeId, model, logo
ILogo response = await terminalSettingsStoreLevelService.UpdateTerminalLogoByStoreIdAsync(
    string storeId, string model, Logo logo, 
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
### **PATCH** **/merchants/{merchantId}/stores/{reference}/terminalSettings**

Update terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **reference** | [string] | The reference that identifies the store. |
| **terminalSettings** | **TerminalSettings** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.UpdateTerminalSettings` usage:
// Provide the following values: merchantId, reference, terminalSettings
ITerminalSettings response = await terminalSettingsStoreLevelService.UpdateTerminalSettingsAsync(
    string merchantId, string reference, TerminalSettings terminalSettings, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


<a id="updateterminalsettingsbystoreid"></a>
### **PATCH** **/stores/{storeId}/terminalSettings**

Update terminal settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | [string] | The unique identifier of the store. |
| **terminalSettings** | **TerminalSettings** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalSettingsStoreLevelService.UpdateTerminalSettingsByStoreId` usage:
// Provide the following values: storeId, terminalSettings
ITerminalSettings response = await terminalSettingsStoreLevelService.UpdateTerminalSettingsByStoreIdAsync(
    string storeId, TerminalSettings terminalSettings, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TerminalSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TerminalSettings]()


