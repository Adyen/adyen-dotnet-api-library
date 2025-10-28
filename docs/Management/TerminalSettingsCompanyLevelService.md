# Adyen.Management.Services.TerminalSettingsCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsCompanyLevelService.md#getterminallogo) | **GET** /companies/{companyId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsCompanyLevelService.md#getterminalsettings) | **GET** /companies/{companyId}/terminalSettings | Get terminal settings |
| [**UpdateTerminalLogo**](TerminalSettingsCompanyLevelService.md#updateterminallogo) | **PATCH** /companies/{companyId}/terminalLogos | Update the terminal logo |
| [**UpdateTerminalSettings**](TerminalSettingsCompanyLevelService.md#updateterminalsettings) | **PATCH** /companies/{companyId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
# **GET** **/companies/{companyId}/terminalLogos**

Get the terminal logo

```csharp 
ILogo GetTerminalLogoAsync(string companyId, string model)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

### Return type

[**Logo**](Logo.md)

<a id="getterminalsettings"></a>
# **GET** **/companies/{companyId}/terminalSettings**

Get terminal settings

```csharp 
ITerminalSettings GetTerminalSettingsAsync(string companyId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |

### Return type

[**TerminalSettings**](TerminalSettings.md)

<a id="updateterminallogo"></a>
# **PATCH** **/companies/{companyId}/terminalLogos**

Update the terminal logo

```csharp 
ILogo UpdateTerminalLogoAsync(string companyId, string model, Logo logo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| **logo** | [**Logo**](Logo.md) |  |

### Return type

[**Logo**](Logo.md)

<a id="updateterminalsettings"></a>
# **PATCH** **/companies/{companyId}/terminalSettings**

Update terminal settings

```csharp 
ITerminalSettings UpdateTerminalSettingsAsync(string companyId, TerminalSettings terminalSettings = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **terminalSettings** | [**TerminalSettings**](TerminalSettings.md) |  |

### Return type

[**TerminalSettings**](TerminalSettings.md)

