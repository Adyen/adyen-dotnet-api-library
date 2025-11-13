## Adyen.Management.Services.SplitConfigurationMerchantLevelService

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
    ISplitConfigurationMerchantLevelService splitConfigurationMerchantLevelService = host.Services.GetRequiredService<ISplitConfigurationMerchantLevelService>();
```

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
### **POST** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Create a rule

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The unique identifier of the split configuration. |
| **splitConfigurationRule** | **SplitConfigurationRule** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.CreateRule` usage:
// Provide the following values: merchantId, splitConfigurationId, splitConfigurationRule
ISplitConfiguration response = await splitConfigurationMerchantLevelService.CreateRuleAsync(
    string merchantId,
    string splitConfigurationId,
    SplitConfigurationRule splitConfigurationRule, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="createsplitconfiguration"></a>
### **POST** **/merchants/{merchantId}/splitConfigurations**

Create a split configuration profile

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfiguration** | **SplitConfiguration** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.CreateSplitConfiguration` usage:
// Provide the following values: merchantId, splitConfiguration
ISplitConfiguration response = await splitConfigurationMerchantLevelService.CreateSplitConfigurationAsync(
    string merchantId,
    SplitConfiguration splitConfiguration, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="deletesplitconfiguration"></a>
### **DELETE** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Delete a split configuration profile

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The unique identifier of the split configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.DeleteSplitConfiguration` usage:
// Provide the following values: merchantId, splitConfigurationId
ISplitConfiguration response = await splitConfigurationMerchantLevelService.DeleteSplitConfigurationAsync(
    string merchantId,
    string splitConfigurationId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="deletesplitconfigurationrule"></a>
### **DELETE** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}**

Delete a rule

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The unique identifier of the split configuration. |
| **ruleId** | [string] |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.DeleteSplitConfigurationRule` usage:
// Provide the following values: merchantId, splitConfigurationId, ruleId
ISplitConfiguration response = await splitConfigurationMerchantLevelService.DeleteSplitConfigurationRuleAsync(
    string merchantId,
    string splitConfigurationId,
    string ruleId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="getsplitconfiguration"></a>
### **GET** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Get a split configuration profile

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The unique identifier of the split configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.GetSplitConfiguration` usage:
// Provide the following values: merchantId, splitConfigurationId
ISplitConfiguration response = await splitConfigurationMerchantLevelService.GetSplitConfigurationAsync(
    string merchantId,
    string splitConfigurationId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="listsplitconfigurations"></a>
### **GET** **/merchants/{merchantId}/splitConfigurations**

Get a list of split configuration profiles

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.ListSplitConfigurations` usage:
// Provide the following values: merchantId
ISplitConfigurationList response = await splitConfigurationMerchantLevelService.ListSplitConfigurationsAsync(
    string merchantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfigurationList result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfigurationList]()


<a id="updatesplitconditions"></a>
### **PATCH** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}**

Update the split conditions

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The identifier of the split configuration. |
| **ruleId** | [string] | The unique identifier of the split configuration rule. |
| **updateSplitConfigurationRuleRequest** | **UpdateSplitConfigurationRuleRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.UpdateSplitConditions` usage:
// Provide the following values: merchantId, splitConfigurationId, ruleId, updateSplitConfigurationRuleRequest
ISplitConfiguration response = await splitConfigurationMerchantLevelService.UpdateSplitConditionsAsync(
    string merchantId,
    string splitConfigurationId,
    string ruleId,
    UpdateSplitConfigurationRuleRequest updateSplitConfigurationRuleRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="updatesplitconfigurationdescription"></a>
### **PATCH** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}**

Update the description of the split configuration profile

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The unique identifier of the split configuration. |
| **updateSplitConfigurationRequest** | **UpdateSplitConfigurationRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.UpdateSplitConfigurationDescription` usage:
// Provide the following values: merchantId, splitConfigurationId, updateSplitConfigurationRequest
ISplitConfiguration response = await splitConfigurationMerchantLevelService.UpdateSplitConfigurationDescriptionAsync(
    string merchantId,
    string splitConfigurationId,
    UpdateSplitConfigurationRequest updateSplitConfigurationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


<a id="updatesplitlogic"></a>
### **PATCH** **/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}/splitLogic/{splitLogicId}**

Update the split logic

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **splitConfigurationId** | [string] | The unique identifier of the split configuration. |
| **ruleId** | [string] | The unique identifier of the split configuration rule. |
| **splitLogicId** | [string] | The unique identifier of the split configuration split. |
| **updateSplitConfigurationLogicRequest** | **UpdateSplitConfigurationLogicRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `SplitConfigurationMerchantLevelService.UpdateSplitLogic` usage:
// Provide the following values: merchantId, splitConfigurationId, ruleId, splitLogicId, updateSplitConfigurationLogicRequest
ISplitConfiguration response = await splitConfigurationMerchantLevelService.UpdateSplitLogicAsync(
    string merchantId,
    string splitConfigurationId,
    string ruleId,
    string splitLogicId,
    UpdateSplitConfigurationLogicRequest updateSplitConfigurationLogicRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SplitConfiguration result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SplitConfiguration]()


