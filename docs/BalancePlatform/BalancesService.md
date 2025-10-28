# Adyen.BalancePlatform.Services.BalancesService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhookSetting**](BalancesService.md#createwebhooksetting) | **POST** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings | Create a balance webhook setting |
| [**DeleteWebhookSetting**](BalancesService.md#deletewebhooksetting) | **DELETE** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId} | Delete a balance webhook setting by id |
| [**GetAllWebhookSettings**](BalancesService.md#getallwebhooksettings) | **GET** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings | Get all balance webhook settings |
| [**GetWebhookSetting**](BalancesService.md#getwebhooksetting) | **GET** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId} | Get a balance webhook setting by id |
| [**UpdateWebhookSetting**](BalancesService.md#updatewebhooksetting) | **PATCH** /balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId} | Update a balance webhook setting by id |

<a id="createwebhooksetting"></a>
# **POST** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings**

Create a balance webhook setting

```csharp 
IWebhookSetting CreateWebhookSettingAsync(string balancePlatformId, string webhookId, BalanceWebhookSettingInfo balanceWebhookSettingInfo)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | **string** | The unique identifier of the balance platform. |
| **webhookId** | **string** | The unique identifier of the balance webhook. |
| **balanceWebhookSettingInfo** | [**BalanceWebhookSettingInfo**](BalanceWebhookSettingInfo.md) |  |

### Return type

[**WebhookSetting**](WebhookSetting.md)

<a id="deletewebhooksetting"></a>
# **DELETE** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}**

Delete a balance webhook setting by id

```csharp 
Ivoid DeleteWebhookSettingAsync(string balancePlatformId, string webhookId, string settingId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | **string** | The unique identifier of the balance platform. |
| **webhookId** | **string** | The unique identifier of the balance webhook. |
| **settingId** | **string** | The unique identifier of the balance webhook setting. |

### Return type

void (empty response body)

<a id="getallwebhooksettings"></a>
# **GET** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings**

Get all balance webhook settings

```csharp 
IWebhookSettings GetAllWebhookSettingsAsync(string balancePlatformId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | **string** | The unique identifier of the balance platform. |
| **webhookId** | **string** | The unique identifier of the balance webhook. |

### Return type

[**WebhookSettings**](WebhookSettings.md)

<a id="getwebhooksetting"></a>
# **GET** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}**

Get a balance webhook setting by id

```csharp 
IWebhookSetting GetWebhookSettingAsync(string balancePlatformId, string webhookId, string settingId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | **string** | The unique identifier of the balance platform. |
| **webhookId** | **string** | The unique identifier of the balance webhook. |
| **settingId** | **string** | The unique identifier of the balance webhook setting. |

### Return type

[**WebhookSetting**](WebhookSetting.md)

<a id="updatewebhooksetting"></a>
# **PATCH** **/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}**

Update a balance webhook setting by id

```csharp 
IWebhookSetting UpdateWebhookSettingAsync(string balancePlatformId, string webhookId, string settingId, BalanceWebhookSettingInfoUpdate balanceWebhookSettingInfoUpdate)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balancePlatformId** | **string** | The unique identifier of the balance platform. |
| **webhookId** | **string** | The unique identifier of the balance webhook. |
| **settingId** | **string** | The unique identifier of the balance webhook setting. |
| **balanceWebhookSettingInfoUpdate** | [**BalanceWebhookSettingInfoUpdate**](BalanceWebhookSettingInfoUpdate.md) |  |

### Return type

[**WebhookSetting**](WebhookSetting.md)

