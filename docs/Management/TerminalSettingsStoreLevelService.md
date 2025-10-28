# Adyen.Management.Services.TerminalSettingsStoreLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

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
# **GET** **/merchants/{merchantId}/stores/{reference}/terminalLogos**

Get the terminal logo

```csharp 
ILogo GetTerminalLogoAsync(string merchantId, string reference, string model)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **reference** | **string** | The reference that identifies the store. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

### Return type

[**Logo**](Logo.md)

<a id="getterminallogobystoreid"></a>
# **GET** **/stores/{storeId}/terminalLogos**

Get the terminal logo

```csharp 
ILogo GetTerminalLogoByStoreIdAsync(string storeId, string model)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | **string** | The unique identifier of the store. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

### Return type

[**Logo**](Logo.md)

<a id="getterminalsettings"></a>
# **GET** **/merchants/{merchantId}/stores/{reference}/terminalSettings**

Get terminal settings

```csharp 
ITerminalSettings GetTerminalSettingsAsync(string merchantId, string reference)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **reference** | **string** | The reference that identifies the store. |

### Return type

[**TerminalSettings**](TerminalSettings.md)

<a id="getterminalsettingsbystoreid"></a>
# **GET** **/stores/{storeId}/terminalSettings**

Get terminal settings

```csharp 
ITerminalSettings GetTerminalSettingsByStoreIdAsync(string storeId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | **string** | The unique identifier of the store. |

### Return type

[**TerminalSettings**](TerminalSettings.md)

<a id="updateterminallogo"></a>
# **PATCH** **/merchants/{merchantId}/stores/{reference}/terminalLogos**

Update the terminal logo

```csharp 
ILogo UpdateTerminalLogoAsync(string merchantId, string reference, string model, Logo logo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **reference** | **string** | The reference that identifies the store. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T |
| **logo** | [**Logo**](Logo.md) |  |

### Return type

[**Logo**](Logo.md)

<a id="updateterminallogobystoreid"></a>
# **PATCH** **/stores/{storeId}/terminalLogos**

Update the terminal logo

```csharp 
ILogo UpdateTerminalLogoByStoreIdAsync(string storeId, string model, Logo logo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | **string** | The unique identifier of the store. |
| **model** | **string** | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| **logo** | [**Logo**](Logo.md) |  |

### Return type

[**Logo**](Logo.md)

<a id="updateterminalsettings"></a>
# **PATCH** **/merchants/{merchantId}/stores/{reference}/terminalSettings**

Update terminal settings

```csharp 
ITerminalSettings UpdateTerminalSettingsAsync(string merchantId, string reference, TerminalSettings terminalSettings = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **reference** | **string** | The reference that identifies the store. |
| **terminalSettings** | [**TerminalSettings**](TerminalSettings.md) |  |

### Return type

[**TerminalSettings**](TerminalSettings.md)

<a id="updateterminalsettingsbystoreid"></a>
# **PATCH** **/stores/{storeId}/terminalSettings**

Update terminal settings

```csharp 
ITerminalSettings UpdateTerminalSettingsByStoreIdAsync(string storeId, TerminalSettings terminalSettings = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | **string** | The unique identifier of the store. |
| **terminalSettings** | [**TerminalSettings**](TerminalSettings.md) |  |

### Return type

[**TerminalSettings**](TerminalSettings.md)

