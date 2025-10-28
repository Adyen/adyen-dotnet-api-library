# Adyen.Management.Services.TerminalSettingsTerminalLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsTerminalLevelService.md#getterminallogo) | **GET** /terminals/{terminalId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsTerminalLevelService.md#getterminalsettings) | **GET** /terminals/{terminalId}/terminalSettings | Get terminal settings |
| [**UpdateLogo**](TerminalSettingsTerminalLevelService.md#updatelogo) | **PATCH** /terminals/{terminalId}/terminalLogos | Update the logo |
| [**UpdateTerminalSettings**](TerminalSettingsTerminalLevelService.md#updateterminalsettings) | **PATCH** /terminals/{terminalId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
# **GET** **/terminals/{terminalId}/terminalLogos**

Get the terminal logo

```csharp 
ILogo GetTerminalLogoAsync(string terminalId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | **string** | The unique identifier of the payment terminal. |

### Return type

[**Logo**](Logo.md)

<a id="getterminalsettings"></a>
# **GET** **/terminals/{terminalId}/terminalSettings**

Get terminal settings

```csharp 
ITerminalSettings GetTerminalSettingsAsync(string terminalId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | **string** | The unique identifier of the payment terminal. |

### Return type

[**TerminalSettings**](TerminalSettings.md)

<a id="updatelogo"></a>
# **PATCH** **/terminals/{terminalId}/terminalLogos**

Update the logo

```csharp 
ILogo UpdateLogoAsync(string terminalId, Logo logo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | **string** | The unique identifier of the payment terminal. |
| **logo** | [**Logo**](Logo.md) |  |

### Return type

[**Logo**](Logo.md)

<a id="updateterminalsettings"></a>
# **PATCH** **/terminals/{terminalId}/terminalSettings**

Update terminal settings

```csharp 
ITerminalSettings UpdateTerminalSettingsAsync(string terminalId, TerminalSettings terminalSettings = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | **string** | The unique identifier of the payment terminal. |
| **terminalSettings** | [**TerminalSettings**](TerminalSettings.md) |  |

### Return type

[**TerminalSettings**](TerminalSettings.md)

