# Adyen.Checkout.Services.PaymentLinksService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPaymentLink**](PaymentLinksService.md#getpaymentlink) | **GET** /paymentLinks/{linkId} | Get a payment link |
| [**PaymentLinks**](PaymentLinksService.md#paymentlinks) | **POST** /paymentLinks | Create a payment link |
| [**UpdatePaymentLink**](PaymentLinksService.md#updatepaymentlink) | **PATCH** /paymentLinks/{linkId} | Update the status of a payment link |

<a id="getpaymentlink"></a>
# **GET** **/paymentLinks/{linkId}**

Get a payment link

```csharp 
IPaymentLinkResponse GetPaymentLinkAsync(string linkId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **linkId** | **string** | Unique identifier of the payment link. |

### Return type

[**PaymentLinkResponse**](PaymentLinkResponse.md)

<a id="paymentlinks"></a>
# **POST** **/paymentLinks**

Create a payment link

```csharp 
IPaymentLinkResponse PaymentLinksAsync(string idempotencyKey = null, PaymentLinkRequest paymentLinkRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentLinkRequest** | [**PaymentLinkRequest**](PaymentLinkRequest.md) |  |

### Return type

[**PaymentLinkResponse**](PaymentLinkResponse.md)

<a id="updatepaymentlink"></a>
# **PATCH** **/paymentLinks/{linkId}**

Update the status of a payment link

```csharp 
IPaymentLinkResponse UpdatePaymentLinkAsync(string linkId, UpdatePaymentLinkRequest updatePaymentLinkRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **linkId** | **string** | Unique identifier of the payment link. |
| **updatePaymentLinkRequest** | [**UpdatePaymentLinkRequest**](UpdatePaymentLinkRequest.md) |  |

### Return type

[**PaymentLinkResponse**](PaymentLinkResponse.md)

