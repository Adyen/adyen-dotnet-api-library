# Adyen.BalancePlatform.Services.ManageSCADevicesService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CompleteAssociationBetweenScaDeviceAndResource**](ManageSCADevicesService.md#completeassociationbetweenscadeviceandresource) | **PATCH** /registeredDevices/{deviceId}/associations | Complete an association between an SCA device and a resource |
| [**CompleteRegistrationOfScaDevice**](ManageSCADevicesService.md#completeregistrationofscadevice) | **PATCH** /registeredDevices/{id} | Complete the registration of an SCA device |
| [**DeleteRegistrationOfScaDevice**](ManageSCADevicesService.md#deleteregistrationofscadevice) | **DELETE** /registeredDevices/{id} | Delete a registration of an SCA device |
| [**InitiateAssociationBetweenScaDeviceAndResource**](ManageSCADevicesService.md#initiateassociationbetweenscadeviceandresource) | **POST** /registeredDevices/{deviceId}/associations | Initiate an association between an SCA device and a resource |
| [**InitiateRegistrationOfScaDevice**](ManageSCADevicesService.md#initiateregistrationofscadevice) | **POST** /registeredDevices | Initiate the registration of an SCA device |
| [**ListRegisteredScaDevices**](ManageSCADevicesService.md#listregisteredscadevices) | **GET** /registeredDevices | Get a list of registered SCA devices |

<a id="completeassociationbetweenscadeviceandresource"></a>
# **PATCH** **/registeredDevices/{deviceId}/associations**

Complete an association between an SCA device and a resource

```csharp 
IAssociationFinaliseResponse CompleteAssociationBetweenScaDeviceAndResourceAsync(string deviceId, AssociationFinaliseRequest associationFinaliseRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | **string** | The unique identifier of the SCA device that you are associating with a resource. |
| **associationFinaliseRequest** | [**AssociationFinaliseRequest**](AssociationFinaliseRequest.md) |  |

### Return type

[**AssociationFinaliseResponse**](AssociationFinaliseResponse.md)

<a id="completeregistrationofscadevice"></a>
# **PATCH** **/registeredDevices/{id}**

Complete the registration of an SCA device

```csharp 
IRegisterSCAFinalResponse CompleteRegistrationOfScaDeviceAsync(string id, RegisterSCARequest registerSCARequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the SCA device. You obtain this &#x60;id&#x60; in the response of a POST&amp;nbsp;[/registeredDevices](https://docs.adyen.com/api-explorer/balanceplatform/2/post/registeredDevices#responses-200-id) request. |
| **registerSCARequest** | [**RegisterSCARequest**](RegisterSCARequest.md) |  |

### Return type

[**RegisterSCAFinalResponse**](RegisterSCAFinalResponse.md)

<a id="deleteregistrationofscadevice"></a>
# **DELETE** **/registeredDevices/{id}**

Delete a registration of an SCA device

```csharp 
Ivoid DeleteRegistrationOfScaDeviceAsync(string id, string paymentInstrumentId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the SCA device. |
| **paymentInstrumentId** | **string** | The unique identifier of the payment instrument linked to the SCA device. |

### Return type

void (empty response body)

<a id="initiateassociationbetweenscadeviceandresource"></a>
# **POST** **/registeredDevices/{deviceId}/associations**

Initiate an association between an SCA device and a resource

```csharp 
IAssociationInitiateResponse InitiateAssociationBetweenScaDeviceAndResourceAsync(string deviceId, AssociationInitiateRequest associationInitiateRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | **string** | The unique identifier of the SCA device that you are associating with a resource. |
| **associationInitiateRequest** | [**AssociationInitiateRequest**](AssociationInitiateRequest.md) |  |

### Return type

[**AssociationInitiateResponse**](AssociationInitiateResponse.md)

<a id="initiateregistrationofscadevice"></a>
# **POST** **/registeredDevices**

Initiate the registration of an SCA device

```csharp 
IRegisterSCAResponse InitiateRegistrationOfScaDeviceAsync(RegisterSCARequest registerSCARequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **registerSCARequest** | [**RegisterSCARequest**](RegisterSCARequest.md) |  |

### Return type

[**RegisterSCAResponse**](RegisterSCAResponse.md)

<a id="listregisteredscadevices"></a>
# **GET** **/registeredDevices**

Get a list of registered SCA devices

```csharp 
ISearchRegisteredDevicesResponse ListRegisteredScaDevicesAsync(string paymentInstrumentId, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | **string** | The unique identifier of a payment instrument. It limits the returned list to SCA devices associated to this payment instrument. |
| **pageNumber** | **int** | The index of the page to retrieve. The index of the first page is 0 (zero).  Default: 0. |
| **pageSize** | **int** | The number of items to have on a page.  Default: 20. Maximum: 100. |

### Return type

[**SearchRegisteredDevicesResponse**](SearchRegisteredDevicesResponse.md)

