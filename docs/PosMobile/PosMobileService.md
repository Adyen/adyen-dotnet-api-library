# Adyen.PosMobile.Services.PosMobileService

### API Base-Path: **https://checkout-test.adyen.com/checkout/possdk/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCommunicationSession**](PosMobileService.md#createcommunicationsession) | **POST** /sessions | Create a communication session |

<a id="createcommunicationsession"></a>
# **POST** **/sessions**

Create a communication session

```csharp 
ICreateSessionResponse CreateCommunicationSessionAsync(CreateSessionRequest createSessionRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createSessionRequest** | [**CreateSessionRequest**](CreateSessionRequest.md) |  |

### Return type

[**CreateSessionResponse**](CreateSessionResponse.md)

