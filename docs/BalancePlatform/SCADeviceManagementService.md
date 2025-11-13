## Adyen.BalancePlatform.Services.SCADeviceManagementService

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
    ISCADeviceManagementService sCADeviceManagementService = host.Services.GetRequiredService<ISCADeviceManagementService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BeginScaDeviceRegistration**](SCADeviceManagementService.md#beginscadeviceregistration) | **POST** /scaDevices | Begin SCA device registration |
| [**FinishScaDeviceRegistration**](SCADeviceManagementService.md#finishscadeviceregistration) | **PATCH** /scaDevices/{deviceId} | Finish registration process for a SCA device |
| [**SubmitScaAssociation**](SCADeviceManagementService.md#submitscaassociation) | **POST** /scaDevices/{deviceId}/scaAssociations | Create a new SCA association for a device |

<a id="beginscadeviceregistration"></a>
### **POST** **/scaDevices**

Begin SCA device registration

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **beginScaDeviceRegistrationRequest** | **BeginScaDeviceRegistrationRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `SCADeviceManagementService.BeginScaDeviceRegistration` usage:
// Provide the following values: beginScaDeviceRegistrationRequest
IBeginScaDeviceRegistrationResponse response = await sCADeviceManagementService.BeginScaDeviceRegistrationAsync(
    BeginScaDeviceRegistrationRequest beginScaDeviceRegistrationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BeginScaDeviceRegistrationResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BeginScaDeviceRegistrationResponse]()


<a id="finishscadeviceregistration"></a>
### **PATCH** **/scaDevices/{deviceId}**

Finish registration process for a SCA device

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | [string] | The unique identifier of the SCA device that you are associating with a resource. |
| **finishScaDeviceRegistrationRequest** | **FinishScaDeviceRegistrationRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `SCADeviceManagementService.FinishScaDeviceRegistration` usage:
// Provide the following values: deviceId, finishScaDeviceRegistrationRequest
IFinishScaDeviceRegistrationResponse response = await sCADeviceManagementService.FinishScaDeviceRegistrationAsync(
    string deviceId,
    FinishScaDeviceRegistrationRequest finishScaDeviceRegistrationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out FinishScaDeviceRegistrationResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[FinishScaDeviceRegistrationResponse]()


<a id="submitscaassociation"></a>
### **POST** **/scaDevices/{deviceId}/scaAssociations**

Create a new SCA association for a device

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | [string] | The unique identifier of the SCA device that you are associating with a resource. |
| **submitScaAssociationRequest** | **SubmitScaAssociationRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `SCADeviceManagementService.SubmitScaAssociation` usage:
// Provide the following values: deviceId, submitScaAssociationRequest
ISubmitScaAssociationResponse response = await sCADeviceManagementService.SubmitScaAssociationAsync(
    string deviceId,
    SubmitScaAssociationRequest submitScaAssociationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SubmitScaAssociationResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SubmitScaAssociationResponse]()


