## Adyen.BalancePlatform.Services.ManageSCADevicesService

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
    IManageSCADevicesService manageSCADevicesService = host.Services.GetRequiredService<IManageSCADevicesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CompleteAssociationBetweenScaDeviceAndResource**](ManageSCADevicesService.md#completeassociationbetweenscadeviceandresource) | **PATCH** /registeredDevices/{deviceId}/associations | Complete an association between an SCA device and a resource |
| [**CompleteRegistrationOfScaDevice**](ManageSCADevicesService.md#completeregistrationofscadevice) | **PATCH** /registeredDevices/{id} | Complete the registration of an SCA device |
| [**DeleteRegistrationOfScaDevice**](ManageSCADevicesService.md#deleteregistrationofscadevice) | **DELETE** /registeredDevices/{id} | Delete a registration of an SCA device |
| [**InitiateAssociationBetweenScaDeviceAndResource**](ManageSCADevicesService.md#initiateassociationbetweenscadeviceandresource) | **POST** /registeredDevices/{deviceId}/associations | Initiate an association between an SCA device and a resource |
| [**InitiateRegistrationOfScaDevice**](ManageSCADevicesService.md#initiateregistrationofscadevice) | **POST** /registeredDevices | Initiate the registration of an SCA device |
| [**ListRegisteredScaDevices**](ManageSCADevicesService.md#listregisteredscadevices) | **GET** /registeredDevices | Get a list of registered SCA devices |

<a id="completeassociationbetweenscadeviceandresource"></a>
### **PATCH** **/registeredDevices/{deviceId}/associations**

Complete an association between an SCA device and a resource

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | [string] | The unique identifier of the SCA device that you are associating with a resource. |
| **associationFinaliseRequest** | **AssociationFinaliseRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageSCADevicesService.CompleteAssociationBetweenScaDeviceAndResource` usage:
// Provide the following values: deviceId, associationFinaliseRequest
IAssociationFinaliseResponse response = await manageSCADevicesService.CompleteAssociationBetweenScaDeviceAndResourceAsync(
    string deviceId,
    AssociationFinaliseRequest associationFinaliseRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AssociationFinaliseResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AssociationFinaliseResponse]()


<a id="completeregistrationofscadevice"></a>
### **PATCH** **/registeredDevices/{id}**

Complete the registration of an SCA device

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the SCA device. You obtain this &#x60;id&#x60; in the response of a POST&amp;nbsp;[/registeredDevices](https://docs.adyen.com/api-explorer/balanceplatform/2/post/registeredDevices#responses-200-id) request. |
| **registerSCARequest** | **RegisterSCARequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageSCADevicesService.CompleteRegistrationOfScaDevice` usage:
// Provide the following values: id, registerSCARequest
IRegisterSCAFinalResponse response = await manageSCADevicesService.CompleteRegistrationOfScaDeviceAsync(
    string id,
    RegisterSCARequest registerSCARequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out RegisterSCAFinalResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[RegisterSCAFinalResponse]()


<a id="deleteregistrationofscadevice"></a>
### **DELETE** **/registeredDevices/{id}**

Delete a registration of an SCA device

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the SCA device. |
| **paymentInstrumentId** | [string] | The unique identifier of the payment instrument linked to the SCA device. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageSCADevicesService.DeleteRegistrationOfScaDevice` usage:
// Provide the following values: id, paymentInstrumentId
await manageSCADevicesService.DeleteRegistrationOfScaDeviceAsync(
    string id,
    string paymentInstrumentId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="initiateassociationbetweenscadeviceandresource"></a>
### **POST** **/registeredDevices/{deviceId}/associations**

Initiate an association between an SCA device and a resource

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | [string] | The unique identifier of the SCA device that you are associating with a resource. |
| **associationInitiateRequest** | **AssociationInitiateRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageSCADevicesService.InitiateAssociationBetweenScaDeviceAndResource` usage:
// Provide the following values: deviceId, associationInitiateRequest
IAssociationInitiateResponse response = await manageSCADevicesService.InitiateAssociationBetweenScaDeviceAndResourceAsync(
    string deviceId,
    AssociationInitiateRequest associationInitiateRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AssociationInitiateResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AssociationInitiateResponse]()


<a id="initiateregistrationofscadevice"></a>
### **POST** **/registeredDevices**

Initiate the registration of an SCA device

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **registerSCARequest** | **RegisterSCARequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageSCADevicesService.InitiateRegistrationOfScaDevice` usage:
// Provide the following values: registerSCARequest
IRegisterSCAResponse response = await manageSCADevicesService.InitiateRegistrationOfScaDeviceAsync(
    RegisterSCARequest registerSCARequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out RegisterSCAResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[RegisterSCAResponse]()


<a id="listregisteredscadevices"></a>
### **GET** **/registeredDevices**

Get a list of registered SCA devices

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | [string] | The unique identifier of a payment instrument. It limits the returned list to SCA devices associated to this payment instrument. |
| **pageNumber** | [int] | The index of the page to retrieve. The index of the first page is 0 (zero).  Default: 0. |
| **pageSize** | [int] | The number of items to have on a page.  Default: 20. Maximum: 100. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageSCADevicesService.ListRegisteredScaDevices` usage:
// Provide the following values: paymentInstrumentId, pageNumber, pageSize
ISearchRegisteredDevicesResponse response = await manageSCADevicesService.ListRegisteredScaDevicesAsync(
    string paymentInstrumentId,
    int pageNumber,
    int pageSize, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SearchRegisteredDevicesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SearchRegisteredDevicesResponse]()


