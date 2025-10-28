# Adyen.BalancePlatform.Services.ManageCardPINService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeCardPin**](ManageCardPINService.md#changecardpin) | **POST** /pins/change | Change a card PIN |
| [**PublicKey**](ManageCardPINService.md#publickey) | **GET** /publicKey | Get an RSA public key |
| [**RevealCardPin**](ManageCardPINService.md#revealcardpin) | **POST** /pins/reveal | Reveal a card PIN |

<a id="changecardpin"></a>
# **POST** **/pins/change**

Change a card PIN

```csharp 
IPinChangeResponse ChangeCardPinAsync(PinChangeRequest pinChangeRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pinChangeRequest** | [**PinChangeRequest**](PinChangeRequest.md) |  |

### Return type

[**PinChangeResponse**](PinChangeResponse.md)

<a id="publickey"></a>
# **GET** **/publicKey**

Get an RSA public key

```csharp 
IPublicKeyResponse PublicKeyAsync(string purpose = null, string format = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **purpose** | **string** | The purpose of the public key.  Possible values: **pinChange**, **pinReveal**, **panReveal**.  Default value: **pinReveal**. |
| **format** | **string** | The encoding format of public key.  Possible values: **jwk**, **pem**.  Default value: **pem**. |

### Return type

[**PublicKeyResponse**](PublicKeyResponse.md)

<a id="revealcardpin"></a>
# **POST** **/pins/reveal**

Reveal a card PIN

```csharp 
IRevealPinResponse RevealCardPinAsync(RevealPinRequest revealPinRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **revealPinRequest** | [**RevealPinRequest**](RevealPinRequest.md) |  |

### Return type

[**RevealPinResponse**](RevealPinResponse.md)

