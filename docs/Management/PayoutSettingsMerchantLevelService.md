# Adyen.Management.Services.PayoutSettingsMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPayoutSetting**](PayoutSettingsMerchantLevelService.md#addpayoutsetting) | **POST** /merchants/{merchantId}/payoutSettings | Add a payout setting |
| [**DeletePayoutSetting**](PayoutSettingsMerchantLevelService.md#deletepayoutsetting) | **DELETE** /merchants/{merchantId}/payoutSettings/{payoutSettingsId} | Delete a payout setting |
| [**GetPayoutSetting**](PayoutSettingsMerchantLevelService.md#getpayoutsetting) | **GET** /merchants/{merchantId}/payoutSettings/{payoutSettingsId} | Get a payout setting |
| [**ListPayoutSettings**](PayoutSettingsMerchantLevelService.md#listpayoutsettings) | **GET** /merchants/{merchantId}/payoutSettings | Get a list of payout settings |
| [**UpdatePayoutSetting**](PayoutSettingsMerchantLevelService.md#updatepayoutsetting) | **PATCH** /merchants/{merchantId}/payoutSettings/{payoutSettingsId} | Update a payout setting |

<a id="addpayoutsetting"></a>
# **POST** **/merchants/{merchantId}/payoutSettings**

Add a payout setting

```csharp 
IPayoutSettings AddPayoutSettingAsync(string merchantId, PayoutSettingsRequest payoutSettingsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **payoutSettingsRequest** | [**PayoutSettingsRequest**](PayoutSettingsRequest.md) |  |

### Return type

[**PayoutSettings**](PayoutSettings.md)

<a id="deletepayoutsetting"></a>
# **DELETE** **/merchants/{merchantId}/payoutSettings/{payoutSettingsId}**

Delete a payout setting

```csharp 
Ivoid DeletePayoutSettingAsync(string merchantId, string payoutSettingsId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **payoutSettingsId** | **string** | The unique identifier of the payout setting. |

### Return type

void (empty response body)

<a id="getpayoutsetting"></a>
# **GET** **/merchants/{merchantId}/payoutSettings/{payoutSettingsId}**

Get a payout setting

```csharp 
IPayoutSettings GetPayoutSettingAsync(string merchantId, string payoutSettingsId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **payoutSettingsId** | **string** | The unique identifier of the payout setting. |

### Return type

[**PayoutSettings**](PayoutSettings.md)

<a id="listpayoutsettings"></a>
# **GET** **/merchants/{merchantId}/payoutSettings**

Get a list of payout settings

```csharp 
IPayoutSettingsResponse ListPayoutSettingsAsync(string merchantId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**PayoutSettingsResponse**](PayoutSettingsResponse.md)

<a id="updatepayoutsetting"></a>
# **PATCH** **/merchants/{merchantId}/payoutSettings/{payoutSettingsId}**

Update a payout setting

```csharp 
IPayoutSettings UpdatePayoutSettingAsync(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **payoutSettingsId** | **string** | The unique identifier of the payout setting. |
| **updatePayoutSettingsRequest** | [**UpdatePayoutSettingsRequest**](UpdatePayoutSettingsRequest.md) |  |

### Return type

[**PayoutSettings**](PayoutSettings.md)

