## Adyen.Recurring.Services.RecurringService

#### API Base-Path: **https://paltokenization-test.adyen.com/pal/servlet/Recurring/v68**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Recurring.Extensions;
using Adyen.Recurring.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureRecurring((context, services, config) =>
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
    IRecurringService recurringService = host.Services.GetRequiredService<IRecurringService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePermit**](RecurringService.md#createpermit) | **POST** /createPermit | Create new permits linked to a recurring contract. |
| [**Disable**](RecurringService.md#disable) | **POST** /disable | Disable stored payment details |
| [**DisablePermit**](RecurringService.md#disablepermit) | **POST** /disablePermit | Disable an existing permit. |
| [**ListRecurringDetails**](RecurringService.md#listrecurringdetails) | **POST** /listRecurringDetails | Get stored payment details |
| [**NotifyShopper**](RecurringService.md#notifyshopper) | **POST** /notifyShopper | Ask issuer to notify the shopper |
| [**ScheduleAccountUpdater**](RecurringService.md#scheduleaccountupdater) | **POST** /scheduleAccountUpdater | Schedule running the Account Updater |

<a id="createpermit"></a>
### **POST** **/createPermit**

Create new permits linked to a recurring contract.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createPermitRequest** | **CreatePermitRequest** |  |

#### Example usage

```csharp
using Adyen.Recurring.Models;
using Adyen.Recurring.Services;

// Example `RecurringService.CreatePermit` usage:
// Provide the following values: createPermitRequest
ICreatePermitResult response = await recurringService.CreatePermitAsync(
    CreatePermitRequest createPermitRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreatePermitResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreatePermitResult]()


<a id="disable"></a>
### **POST** **/disable**

Disable stored payment details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **disableRequest** | **DisableRequest** |  |

#### Example usage

```csharp
using Adyen.Recurring.Models;
using Adyen.Recurring.Services;

// Example `RecurringService.Disable` usage:
// Provide the following values: disableRequest
IDisableResult response = await recurringService.DisableAsync(
    DisableRequest disableRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DisableResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DisableResult]()


<a id="disablepermit"></a>
### **POST** **/disablePermit**

Disable an existing permit.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **disablePermitRequest** | **DisablePermitRequest** |  |

#### Example usage

```csharp
using Adyen.Recurring.Models;
using Adyen.Recurring.Services;

// Example `RecurringService.DisablePermit` usage:
// Provide the following values: disablePermitRequest
IDisablePermitResult response = await recurringService.DisablePermitAsync(
    DisablePermitRequest disablePermitRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DisablePermitResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DisablePermitResult]()


<a id="listrecurringdetails"></a>
### **POST** **/listRecurringDetails**

Get stored payment details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **recurringDetailsRequest** | **RecurringDetailsRequest** |  |

#### Example usage

```csharp
using Adyen.Recurring.Models;
using Adyen.Recurring.Services;

// Example `RecurringService.ListRecurringDetails` usage:
// Provide the following values: recurringDetailsRequest
IRecurringDetailsResult response = await recurringService.ListRecurringDetailsAsync(
    RecurringDetailsRequest recurringDetailsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out RecurringDetailsResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[RecurringDetailsResult]()


<a id="notifyshopper"></a>
### **POST** **/notifyShopper**

Ask issuer to notify the shopper

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **notifyShopperRequest** | **NotifyShopperRequest** |  |

#### Example usage

```csharp
using Adyen.Recurring.Models;
using Adyen.Recurring.Services;

// Example `RecurringService.NotifyShopper` usage:
// Provide the following values: notifyShopperRequest
INotifyShopperResult response = await recurringService.NotifyShopperAsync(
    NotifyShopperRequest notifyShopperRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out NotifyShopperResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[NotifyShopperResult]()


<a id="scheduleaccountupdater"></a>
### **POST** **/scheduleAccountUpdater**

Schedule running the Account Updater

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **scheduleAccountUpdaterRequest** | **ScheduleAccountUpdaterRequest** |  |

#### Example usage

```csharp
using Adyen.Recurring.Models;
using Adyen.Recurring.Services;

// Example `RecurringService.ScheduleAccountUpdater` usage:
// Provide the following values: scheduleAccountUpdaterRequest
IScheduleAccountUpdaterResult response = await recurringService.ScheduleAccountUpdaterAsync(
    ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ScheduleAccountUpdaterResult result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ScheduleAccountUpdaterResult]()


