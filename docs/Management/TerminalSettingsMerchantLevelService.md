# Adyen.Management.Services.TerminalSettingsMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalLogo**](TerminalSettingsMerchantLevelService.md#getterminallogo) | **GET** /merchants/{merchantId}/terminalLogos | Get the terminal logo |
| [**GetTerminalSettings**](TerminalSettingsMerchantLevelService.md#getterminalsettings) | **GET** /merchants/{merchantId}/terminalSettings | Get terminal settings |
| [**UpdateTerminalLogo**](TerminalSettingsMerchantLevelService.md#updateterminallogo) | **PATCH** /merchants/{merchantId}/terminalLogos | Update the terminal logo |
| [**UpdateTerminalSettings**](TerminalSettingsMerchantLevelService.md#updateterminalsettings) | **PATCH** /merchants/{merchantId}/terminalSettings | Update terminal settings |

<a id="getterminallogo"></a>
# **GET** **/merchants/{merchantId}/terminalLogos**

Get the terminal logo

```csharp 
ILogo GetTerminalLogoAsync(string merchantId, string model)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

### Return type

[**Logo**](Logo.md)

<a id="getterminalsettings"></a>
# **GET** **/merchants/{merchantId}/terminalSettings**

Get terminal settings

```csharp 
ITerminalSettings GetTerminalSettingsAsync(string merchantId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**TerminalSettings**](TerminalSettings.md)

<a id="updateterminallogo"></a>
# **PATCH** **/merchants/{merchantId}/terminalLogos**

Update the terminal logo

```csharp 
ILogo UpdateTerminalLogoAsync(string merchantId, string model, Logo logo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **model** | **string** | The terminal model. Allowed values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| **logo** | [**Logo**](Logo.md) |  |

### Return type

[**Logo**](Logo.md)

<a id="updateterminalsettings"></a>
# **PATCH** **/merchants/{merchantId}/terminalSettings**

Update terminal settings

```csharp 
ITerminalSettings UpdateTerminalSettingsAsync(string merchantId, TerminalSettings terminalSettings = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **terminalSettings** | [**TerminalSettings**](TerminalSettings.md) |  |

### Return type

[**TerminalSettings**](TerminalSettings.md)

