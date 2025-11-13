## Adyen.Management.Services.PayoutSettingsMerchantLevelService

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
    IPayoutSettingsMerchantLevelService payoutSettingsMerchantLevelService = host.Services.GetRequiredService<IPayoutSettingsMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPayoutSetting**](PayoutSettingsMerchantLevelService.md#addpayoutsetting) | **POST** /merchants/{merchantId}/payoutSettings | Add a payout setting |
| [**DeletePayoutSetting**](PayoutSettingsMerchantLevelService.md#deletepayoutsetting) | **DELETE** /merchants/{merchantId}/payoutSettings/{payoutSettingsId} | Delete a payout setting |
| [**GetPayoutSetting**](PayoutSettingsMerchantLevelService.md#getpayoutsetting) | **GET** /merchants/{merchantId}/payoutSettings/{payoutSettingsId} | Get a payout setting |
| [**ListPayoutSettings**](PayoutSettingsMerchantLevelService.md#listpayoutsettings) | **GET** /merchants/{merchantId}/payoutSettings | Get a list of payout settings |
| [**UpdatePayoutSetting**](PayoutSettingsMerchantLevelService.md#updatepayoutsetting) | **PATCH** /merchants/{merchantId}/payoutSettings/{payoutSettingsId} | Update a payout setting |

<a id="addpayoutsetting"></a>
### **POST** **/merchants/{merchantId}/payoutSettings**

Add a payout setting

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **payoutSettingsRequest** | **PayoutSettingsRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PayoutSettingsMerchantLevelService.AddPayoutSetting` usage:
// Provide the following values: merchantId, payoutSettingsRequest
IPayoutSettings response = await payoutSettingsMerchantLevelService.AddPayoutSettingAsync(
    string merchantId,
    PayoutSettingsRequest payoutSettingsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PayoutSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PayoutSettings]()


<a id="deletepayoutsetting"></a>
### **DELETE** **/merchants/{merchantId}/payoutSettings/{payoutSettingsId}**

Delete a payout setting

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **payoutSettingsId** | [string] | The unique identifier of the payout setting. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PayoutSettingsMerchantLevelService.DeletePayoutSetting` usage:
// Provide the following values: merchantId, payoutSettingsId
await payoutSettingsMerchantLevelService.DeletePayoutSettingAsync(
    string merchantId,
    string payoutSettingsId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getpayoutsetting"></a>
### **GET** **/merchants/{merchantId}/payoutSettings/{payoutSettingsId}**

Get a payout setting

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **payoutSettingsId** | [string] | The unique identifier of the payout setting. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PayoutSettingsMerchantLevelService.GetPayoutSetting` usage:
// Provide the following values: merchantId, payoutSettingsId
IPayoutSettings response = await payoutSettingsMerchantLevelService.GetPayoutSettingAsync(
    string merchantId,
    string payoutSettingsId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PayoutSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PayoutSettings]()


<a id="listpayoutsettings"></a>
### **GET** **/merchants/{merchantId}/payoutSettings**

Get a list of payout settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PayoutSettingsMerchantLevelService.ListPayoutSettings` usage:
// Provide the following values: merchantId
IPayoutSettingsResponse response = await payoutSettingsMerchantLevelService.ListPayoutSettingsAsync(
    string merchantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PayoutSettingsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PayoutSettingsResponse]()


<a id="updatepayoutsetting"></a>
### **PATCH** **/merchants/{merchantId}/payoutSettings/{payoutSettingsId}**

Update a payout setting

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **payoutSettingsId** | [string] | The unique identifier of the payout setting. |
| **updatePayoutSettingsRequest** | **UpdatePayoutSettingsRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `PayoutSettingsMerchantLevelService.UpdatePayoutSetting` usage:
// Provide the following values: merchantId, payoutSettingsId, updatePayoutSettingsRequest
IPayoutSettings response = await payoutSettingsMerchantLevelService.UpdatePayoutSettingAsync(
    string merchantId,
    string payoutSettingsId,
    UpdatePayoutSettingsRequest updatePayoutSettingsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PayoutSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PayoutSettings]()


