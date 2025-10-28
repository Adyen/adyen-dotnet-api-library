# Adyen.Payout.Services.ReviewingService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payout/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfirmThirdParty**](ReviewingService.md#confirmthirdparty) | **POST** /confirmThirdParty | Confirm a payout |
| [**DeclineThirdParty**](ReviewingService.md#declinethirdparty) | **POST** /declineThirdParty | Cancel a payout |

<a id="confirmthirdparty"></a>
# **POST** **/confirmThirdParty**

Confirm a payout

```csharp 
IModifyResponse ConfirmThirdPartyAsync(ModifyRequest modifyRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **modifyRequest** | [**ModifyRequest**](ModifyRequest.md) |  |

### Return type

[**ModifyResponse**](ModifyResponse.md)

<a id="declinethirdparty"></a>
# **POST** **/declineThirdParty**

Cancel a payout

```csharp 
IModifyResponse DeclineThirdPartyAsync(ModifyRequest modifyRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **modifyRequest** | [**ModifyRequest**](ModifyRequest.md) |  |

### Return type

[**ModifyResponse**](ModifyResponse.md)

