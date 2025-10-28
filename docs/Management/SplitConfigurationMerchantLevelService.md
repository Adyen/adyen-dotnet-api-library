# Adyen.Management.Services.SplitConfigurationMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRule**](SplitConfigurationMerchantLevelService.md#createrule) | **POST** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId} | Create a rule |
| [**CreateSplitConfiguration**](SplitConfigurationMerchantLevelService.md#createsplitconfiguration) | **POST** /merchants/{merchantId}/splitConfigurations | Create a split configuration profile |
| [**DeleteSplitConfiguration**](SplitConfigurationMerchantLevelService.md#deletesplitconfiguration) | **DELETE** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId} | Delete a split configuration profile |
| [**DeleteSplitConfigurationRule**](SplitConfigurationMerchantLevelService.md#deletesplitconfigurationrule) | **DELETE** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId} | Delete a rule |
| [**GetSplitConfiguration**](SplitConfigurationMerchantLevelService.md#getsplitconfiguration) | **GET** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId} | Get a split configuration profile |
| [**ListSplitConfigurations**](SplitConfigurationMerchantLevelService.md#listsplitconfigurations) | **GET** /merchants/{merchantId}/splitConfigurations | Get a list of split configuration profiles |
| [**UpdateSplitConditions**](SplitConfigurationMerchantLevelService.md#updatesplitconditions) | **PATCH** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId} | Update the split conditions |
| [**UpdateSplitConfigurationDescription**](SplitConfigurationMerchantLevelService.md#updatesplitconfigurationdescription) | **PATCH** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId} | Update the description of the split configuration profile |
| [**UpdateSplitLogic**](SplitConfigurationMerchantLevelService.md#updatesplitlogic) | **PATCH** /merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}/splitLogic/{splitLogicId} | Update the split logic |

<a id="createrule"></a>
# **POST** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Create a rule

```csharp 
ISplitConfiguration CreateRuleAsync(string merchantId, string splitConfigurationId, SplitConfigurationRule splitConfigurationRule = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The unique identifier of the split configuration. |
| **splitConfigurationRule** | [**SplitConfigurationRule**](SplitConfigurationRule.md) |  |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="createsplitconfiguration"></a>
# **POST** **/merchants/{merchantId}/splitConfigurations**

Create a split configuration profile

```csharp 
ISplitConfiguration CreateSplitConfigurationAsync(string merchantId, SplitConfiguration splitConfiguration = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfiguration** | [**SplitConfiguration**](SplitConfiguration.md) |  |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="deletesplitconfiguration"></a>
# **DELETE** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Delete a split configuration profile

```csharp 
ISplitConfiguration DeleteSplitConfigurationAsync(string merchantId, string splitConfigurationId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The unique identifier of the split configuration. |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="deletesplitconfigurationrule"></a>
# **DELETE** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}**

Delete a rule

```csharp 
ISplitConfiguration DeleteSplitConfigurationRuleAsync(string merchantId, string splitConfigurationId, string ruleId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The unique identifier of the split configuration. |
| **ruleId** | **string** |  |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="getsplitconfiguration"></a>
# **GET** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Get a split configuration profile

```csharp 
ISplitConfiguration GetSplitConfigurationAsync(string merchantId, string splitConfigurationId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The unique identifier of the split configuration. |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="listsplitconfigurations"></a>
# **GET** **/merchants/{merchantId}/splitConfigurations**

Get a list of split configuration profiles

```csharp 
ISplitConfigurationList ListSplitConfigurationsAsync(string merchantId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**SplitConfigurationList**](SplitConfigurationList.md)

<a id="updatesplitconditions"></a>
# **PATCH** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}**

Update the split conditions

```csharp 
ISplitConfiguration UpdateSplitConditionsAsync(string merchantId, string splitConfigurationId, string ruleId, UpdateSplitConfigurationRuleRequest updateSplitConfigurationRuleRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The identifier of the split configuration. |
| **ruleId** | **string** | The unique identifier of the split configuration rule. |
| **updateSplitConfigurationRuleRequest** | [**UpdateSplitConfigurationRuleRequest**](UpdateSplitConfigurationRuleRequest.md) |  |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="updatesplitconfigurationdescription"></a>
# **PATCH** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Update the description of the split configuration profile

```csharp 
ISplitConfiguration UpdateSplitConfigurationDescriptionAsync(string merchantId, string splitConfigurationId, UpdateSplitConfigurationRequest updateSplitConfigurationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The unique identifier of the split configuration. |
| **updateSplitConfigurationRequest** | [**UpdateSplitConfigurationRequest**](UpdateSplitConfigurationRequest.md) |  |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

<a id="updatesplitlogic"></a>
# **PATCH** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}/splitLogic/{splitLogicId}**

Update the split logic

```csharp 
ISplitConfiguration UpdateSplitLogicAsync(string merchantId, string splitConfigurationId, string ruleId, string splitLogicId, UpdateSplitConfigurationLogicRequest updateSplitConfigurationLogicRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **splitConfigurationId** | **string** | The unique identifier of the split configuration. |
| **ruleId** | **string** | The unique identifier of the split configuration rule. |
| **splitLogicId** | **string** | The unique identifier of the split configuration split. |
| **updateSplitConfigurationLogicRequest** | [**UpdateSplitConfigurationLogicRequest**](UpdateSplitConfigurationLogicRequest.md) |  |

### Return type

[**SplitConfiguration**](SplitConfiguration.md)

