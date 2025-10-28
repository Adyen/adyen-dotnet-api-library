# Adyen.Recurring.Services.RecurringService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Recurring/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePermit**](RecurringService.md#createpermit) | **POST** /createPermit | Create new permits linked to a recurring contract. |
| [**Disable**](RecurringService.md#disable) | **POST** /disable | Disable stored payment details |
| [**DisablePermit**](RecurringService.md#disablepermit) | **POST** /disablePermit | Disable an existing permit. |
| [**ListRecurringDetails**](RecurringService.md#listrecurringdetails) | **POST** /listRecurringDetails | Get stored payment details |
| [**NotifyShopper**](RecurringService.md#notifyshopper) | **POST** /notifyShopper | Ask issuer to notify the shopper |
| [**ScheduleAccountUpdater**](RecurringService.md#scheduleaccountupdater) | **POST** /scheduleAccountUpdater | Schedule running the Account Updater |

<a id="createpermit"></a>
# **POST** **/createPermit**

Create new permits linked to a recurring contract.

```csharp 
ICreatePermitResult CreatePermitAsync(CreatePermitRequest createPermitRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createPermitRequest** | [**CreatePermitRequest**](CreatePermitRequest.md) |  |

### Return type

[**CreatePermitResult**](CreatePermitResult.md)

<a id="disable"></a>
# **POST** **/disable**

Disable stored payment details

```csharp 
IDisableResult DisableAsync(DisableRequest disableRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **disableRequest** | [**DisableRequest**](DisableRequest.md) |  |

### Return type

[**DisableResult**](DisableResult.md)

<a id="disablepermit"></a>
# **POST** **/disablePermit**

Disable an existing permit.

```csharp 
IDisablePermitResult DisablePermitAsync(DisablePermitRequest disablePermitRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **disablePermitRequest** | [**DisablePermitRequest**](DisablePermitRequest.md) |  |

### Return type

[**DisablePermitResult**](DisablePermitResult.md)

<a id="listrecurringdetails"></a>
# **POST** **/listRecurringDetails**

Get stored payment details

```csharp 
IRecurringDetailsResult ListRecurringDetailsAsync(RecurringDetailsRequest recurringDetailsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **recurringDetailsRequest** | [**RecurringDetailsRequest**](RecurringDetailsRequest.md) |  |

### Return type

[**RecurringDetailsResult**](RecurringDetailsResult.md)

<a id="notifyshopper"></a>
# **POST** **/notifyShopper**

Ask issuer to notify the shopper

```csharp 
INotifyShopperResult NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **notifyShopperRequest** | [**NotifyShopperRequest**](NotifyShopperRequest.md) |  |

### Return type

[**NotifyShopperResult**](NotifyShopperResult.md)

<a id="scheduleaccountupdater"></a>
# **POST** **/scheduleAccountUpdater**

Schedule running the Account Updater

```csharp 
IScheduleAccountUpdaterResult ScheduleAccountUpdaterAsync(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **scheduleAccountUpdaterRequest** | [**ScheduleAccountUpdaterRequest**](ScheduleAccountUpdaterRequest.md) |  |

### Return type

[**ScheduleAccountUpdaterResult**](ScheduleAccountUpdaterResult.md)

