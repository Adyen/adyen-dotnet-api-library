# Adyen.Checkout.Services.PaymentsService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CardDetails**](PaymentsService.md#carddetails) | **POST** /cardDetails | Get the brands and other details of a card |
| [**GetResultOfPaymentSession**](PaymentsService.md#getresultofpaymentsession) | **GET** /sessions/{sessionId} | Get the result of a payment session |
| [**PaymentMethods**](PaymentsService.md#paymentmethods) | **POST** /paymentMethods | Get a list of available payment methods |
| [**Payments**](PaymentsService.md#payments) | **POST** /payments | Start a transaction |
| [**PaymentsDetails**](PaymentsService.md#paymentsdetails) | **POST** /payments/details | Submit details for a payment |
| [**Sessions**](PaymentsService.md#sessions) | **POST** /sessions | Create a payment session |

<a id="carddetails"></a>
# **POST** **/cardDetails**

Get the brands and other details of a card

```csharp 
ICardDetailsResponse CardDetailsAsync(string idempotencyKey = null, CardDetailsRequest cardDetailsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **cardDetailsRequest** | [**CardDetailsRequest**](CardDetailsRequest.md) |  |

### Return type

[**CardDetailsResponse**](CardDetailsResponse.md)

<a id="getresultofpaymentsession"></a>
# **GET** **/sessions/{sessionId}**

Get the result of a payment session

```csharp 
ISessionResultResponse GetResultOfPaymentSessionAsync(string sessionId, string sessionResult)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **sessionId** | **string** | A unique identifier of the session. |
| **sessionResult** | **string** | The &#x60;sessionResult&#x60; value from the Drop-in or Component. |

### Return type

[**SessionResultResponse**](SessionResultResponse.md)

<a id="paymentmethods"></a>
# **POST** **/paymentMethods**

Get a list of available payment methods

```csharp 
IPaymentMethodsResponse PaymentMethodsAsync(string idempotencyKey = null, PaymentMethodsRequest paymentMethodsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentMethodsRequest** | [**PaymentMethodsRequest**](PaymentMethodsRequest.md) |  |

### Return type

[**PaymentMethodsResponse**](PaymentMethodsResponse.md)

<a id="payments"></a>
# **POST** **/payments**

Start a transaction

```csharp 
IPaymentResponse PaymentsAsync(string idempotencyKey = null, PaymentRequest paymentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentRequest** | [**PaymentRequest**](PaymentRequest.md) |  |

### Return type

[**PaymentResponse**](PaymentResponse.md)

<a id="paymentsdetails"></a>
# **POST** **/payments/details**

Submit details for a payment

```csharp 
IPaymentDetailsResponse PaymentsDetailsAsync(string idempotencyKey = null, PaymentDetailsRequest paymentDetailsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentDetailsRequest** | [**PaymentDetailsRequest**](PaymentDetailsRequest.md) |  |

### Return type

[**PaymentDetailsResponse**](PaymentDetailsResponse.md)

<a id="sessions"></a>
# **POST** **/sessions**

Create a payment session

```csharp 
ICreateCheckoutSessionResponse SessionsAsync(string idempotencyKey = null, CreateCheckoutSessionRequest createCheckoutSessionRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **createCheckoutSessionRequest** | [**CreateCheckoutSessionRequest**](CreateCheckoutSessionRequest.md) |  |

### Return type

[**CreateCheckoutSessionResponse**](CreateCheckoutSessionResponse.md)

