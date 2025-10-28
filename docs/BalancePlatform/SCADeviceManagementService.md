# Adyen.BalancePlatform.Services.SCADeviceManagementService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BeginScaDeviceRegistration**](SCADeviceManagementService.md#beginscadeviceregistration) | **POST** /scaDevices | Begin SCA device registration |
| [**FinishScaDeviceRegistration**](SCADeviceManagementService.md#finishscadeviceregistration) | **PATCH** /scaDevices/{deviceId} | Finish registration process for a SCA device |
| [**SubmitScaAssociation**](SCADeviceManagementService.md#submitscaassociation) | **POST** /scaDevices/{deviceId}/scaAssociations | Create a new SCA association for a device |

<a id="beginscadeviceregistration"></a>
# **POST** **/scaDevices**

Begin SCA device registration

```csharp 
IBeginScaDeviceRegistrationResponse BeginScaDeviceRegistrationAsync(BeginScaDeviceRegistrationRequest beginScaDeviceRegistrationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **beginScaDeviceRegistrationRequest** | [**BeginScaDeviceRegistrationRequest**](BeginScaDeviceRegistrationRequest.md) |  |

### Return type

[**BeginScaDeviceRegistrationResponse**](BeginScaDeviceRegistrationResponse.md)

<a id="finishscadeviceregistration"></a>
# **PATCH** **/scaDevices/{deviceId}**

Finish registration process for a SCA device

```csharp 
IFinishScaDeviceRegistrationResponse FinishScaDeviceRegistrationAsync(string deviceId, FinishScaDeviceRegistrationRequest finishScaDeviceRegistrationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | **string** | The unique identifier of the SCA device that you are associating with a resource. |
| **finishScaDeviceRegistrationRequest** | [**FinishScaDeviceRegistrationRequest**](FinishScaDeviceRegistrationRequest.md) |  |

### Return type

[**FinishScaDeviceRegistrationResponse**](FinishScaDeviceRegistrationResponse.md)

<a id="submitscaassociation"></a>
# **POST** **/scaDevices/{deviceId}/scaAssociations**

Create a new SCA association for a device

```csharp 
ISubmitScaAssociationResponse SubmitScaAssociationAsync(string deviceId, SubmitScaAssociationRequest submitScaAssociationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deviceId** | **string** | The unique identifier of the SCA device that you are associating with a resource. |
| **submitScaAssociationRequest** | [**SubmitScaAssociationRequest**](SubmitScaAssociationRequest.md) |  |

### Return type

[**SubmitScaAssociationResponse**](SubmitScaAssociationResponse.md)

