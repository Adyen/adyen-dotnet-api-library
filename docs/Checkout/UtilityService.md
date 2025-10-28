# Adyen.Checkout.Services.UtilityService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetApplePaySession**](UtilityService.md#getapplepaysession) | **POST** /applePay/sessions | Get an Apple Pay session |
| [**OriginKeys**](UtilityService.md#originkeys) | **POST** /originKeys | Create originKey values for domains |
| [**UpdatesOrderForPaypalExpressCheckout**](UtilityService.md#updatesorderforpaypalexpresscheckout) | **POST** /paypal/updateOrder | Updates the order for PayPal Express Checkout |
| [**ValidateShopperId**](UtilityService.md#validateshopperid) | **POST** /validateShopperId | Validates shopper Id |

<a id="getapplepaysession"></a>
# **POST** **/applePay/sessions**

Get an Apple Pay session

```csharp 
IApplePaySessionResponse GetApplePaySessionAsync(string idempotencyKey = null, ApplePaySessionRequest applePaySessionRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **applePaySessionRequest** | [**ApplePaySessionRequest**](ApplePaySessionRequest.md) |  |

### Return type

[**ApplePaySessionResponse**](ApplePaySessionResponse.md)

<a id="originkeys"></a>
# **POST** **/originKeys**

Create originKey values for domains

```csharp 
IUtilityResponse OriginKeysAsync(string idempotencyKey = null, UtilityRequest utilityRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **utilityRequest** | [**UtilityRequest**](UtilityRequest.md) |  |

### Return type

[**UtilityResponse**](UtilityResponse.md)

<a id="updatesorderforpaypalexpresscheckout"></a>
# **POST** **/paypal/updateOrder**

Updates the order for PayPal Express Checkout

```csharp 
IPaypalUpdateOrderResponse UpdatesOrderForPaypalExpressCheckoutAsync(string idempotencyKey = null, PaypalUpdateOrderRequest paypalUpdateOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paypalUpdateOrderRequest** | [**PaypalUpdateOrderRequest**](PaypalUpdateOrderRequest.md) |  |

### Return type

[**PaypalUpdateOrderResponse**](PaypalUpdateOrderResponse.md)

<a id="validateshopperid"></a>
# **POST** **/validateShopperId**

Validates shopper Id

```csharp 
IValidateShopperIdResponse ValidateShopperIdAsync(ValidateShopperIdRequest validateShopperIdRequest)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **validateShopperIdRequest** | [**ValidateShopperIdRequest**](ValidateShopperIdRequest.md) |  |

### Return type

[**ValidateShopperIdResponse**](ValidateShopperIdResponse.md)

