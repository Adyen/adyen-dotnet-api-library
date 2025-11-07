## Adyen.BalancePlatform.Services.BalancesService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    IBalancesService balancesService = host.Services.GetRequiredService<IBalancesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhookSetting**](BalancesService.md#createwebhooksetting) | **POST** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings | Create a balance webhook setting |
| [**DeleteWebhookSetting**](BalancesService.md#deletewebhooksetting) | **DELETE** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId} | Delete a balance webhook setting by id |
| [**GetAllWebhookSettings**](BalancesService.md#getallwebhooksettings) | **GET** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings | Get all balance webhook settings |
| [**GetWebhookSetting**](BalancesService.md#getwebhooksetting) | **GET** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId} | Get a balance webhook setting by id |
| [**UpdateWebhookSetting**](BalancesService.md#updatewebhooksetting) | **PATCH** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId} | Update a balance webhook setting by id |

<a id="createwebhooksetting"></a>
### **POST** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings**

Create a balance webhook setting

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | [string] | The unique identifier of the balance platform. |
| **webhookId** | [string] | The unique identifier of the balance webhook. |
| **balanceWebhookSettingInfo** | **BalanceWebhookSettingInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalancesService.CreateWebhookSetting` usage:
// Provide the following values: balancePlatformId, webhookId, balanceWebhookSettingInfo.
IWebhookSetting response = await balancesService.CreateWebhookSettingAsync(
    string balancePlatformId,
    string webhookId,
    BalanceWebhookSettingInfo balanceWebhookSettingInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out WebhookSetting result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[WebhookSetting]()


<a id="deletewebhooksetting"></a>
### **DELETE** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}**

Delete a balance webhook setting by id

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | [string] | The unique identifier of the balance platform. |
| **webhookId** | [string] | The unique identifier of the balance webhook. |
| **settingId** | [string] | The unique identifier of the balance webhook setting. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalancesService.DeleteWebhookSetting` usage:
// Provide the following values: balancePlatformId, webhookId, settingId.
I response = await balancesService.DeleteWebhookSettingAsync(
    string balancePlatformId,
    string webhookId,
    string settingId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getallwebhooksettings"></a>
### **GET** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings**

Get all balance webhook settings

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | [string] | The unique identifier of the balance platform. |
| **webhookId** | [string] | The unique identifier of the balance webhook. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalancesService.GetAllWebhookSettings` usage:
// Provide the following values: balancePlatformId, webhookId.
IWebhookSettings response = await balancesService.GetAllWebhookSettingsAsync(
    string balancePlatformId,
    string webhookId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out WebhookSettings result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[WebhookSettings]()


<a id="getwebhooksetting"></a>
### **GET** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}**

Get a balance webhook setting by id

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | [string] | The unique identifier of the balance platform. |
| **webhookId** | [string] | The unique identifier of the balance webhook. |
| **settingId** | [string] | The unique identifier of the balance webhook setting. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalancesService.GetWebhookSetting` usage:
// Provide the following values: balancePlatformId, webhookId, settingId.
IWebhookSetting response = await balancesService.GetWebhookSettingAsync(
    string balancePlatformId,
    string webhookId,
    string settingId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out WebhookSetting result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[WebhookSetting]()


<a id="updatewebhooksetting"></a>
### **PATCH** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}**

Update a balance webhook setting by id

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | [string] | The unique identifier of the balance platform. |
| **webhookId** | [string] | The unique identifier of the balance webhook. |
| **settingId** | [string] | The unique identifier of the balance webhook setting. |
| **balanceWebhookSettingInfoUpdate** | **BalanceWebhookSettingInfoUpdate** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BalancesService.UpdateWebhookSetting` usage:
// Provide the following values: balancePlatformId, webhookId, settingId, balanceWebhookSettingInfoUpdate.
IWebhookSetting response = await balancesService.UpdateWebhookSettingAsync(
    string balancePlatformId,
    string webhookId,
    string settingId,
    BalanceWebhookSettingInfoUpdate balanceWebhookSettingInfoUpdate, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out WebhookSetting result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[WebhookSetting]()


