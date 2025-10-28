# Adyen.Checkout.Services.ModificationsService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelAuthorisedPayment**](ModificationsService.md#cancelauthorisedpayment) | **POST** /cancels | Cancel an authorised payment |
| [**CancelAuthorisedPaymentByPspReference**](ModificationsService.md#cancelauthorisedpaymentbypspreference) | **POST** /payments/{paymentPspReference}/cancels | Cancel an authorised payment |
| [**CaptureAuthorisedPayment**](ModificationsService.md#captureauthorisedpayment) | **POST** /payments/{paymentPspReference}/captures | Capture an authorised payment |
| [**RefundCapturedPayment**](ModificationsService.md#refundcapturedpayment) | **POST** /payments/{paymentPspReference}/refunds | Refund a captured payment |
| [**RefundOrCancelPayment**](ModificationsService.md#refundorcancelpayment) | **POST** /payments/{paymentPspReference}/reversals | Refund or cancel a payment |
| [**UpdateAuthorisedAmount**](ModificationsService.md#updateauthorisedamount) | **POST** /payments/{paymentPspReference}/amountUpdates | Update an authorised amount |

<a id="cancelauthorisedpayment"></a>
# **POST** **/cancels**

Cancel an authorised payment

```csharp 
IStandalonePaymentCancelResponse CancelAuthorisedPaymentAsync(string idempotencyKey = null, StandalonePaymentCancelRequest standalonePaymentCancelRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **standalonePaymentCancelRequest** | [**StandalonePaymentCancelRequest**](StandalonePaymentCancelRequest.md) |  |

### Return type

[**StandalonePaymentCancelResponse**](StandalonePaymentCancelResponse.md)

<a id="cancelauthorisedpaymentbypspreference"></a>
# **POST** **/payments/{paymentPspReference}/cancels**

Cancel an authorised payment

```csharp 
IPaymentCancelResponse CancelAuthorisedPaymentByPspReferenceAsync(string paymentPspReference, string idempotencyKey = null, PaymentCancelRequest paymentCancelRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | **string** | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to cancel.  |
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentCancelRequest** | [**PaymentCancelRequest**](PaymentCancelRequest.md) |  |

### Return type

[**PaymentCancelResponse**](PaymentCancelResponse.md)

<a id="captureauthorisedpayment"></a>
# **POST** **/payments/{paymentPspReference}/captures**

Capture an authorised payment

```csharp 
IPaymentCaptureResponse CaptureAuthorisedPaymentAsync(string paymentPspReference, string idempotencyKey = null, PaymentCaptureRequest paymentCaptureRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | **string** | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to capture. |
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentCaptureRequest** | [**PaymentCaptureRequest**](PaymentCaptureRequest.md) |  |

### Return type

[**PaymentCaptureResponse**](PaymentCaptureResponse.md)

<a id="refundcapturedpayment"></a>
# **POST** **/payments/{paymentPspReference}/refunds**

Refund a captured payment

```csharp 
IPaymentRefundResponse RefundCapturedPaymentAsync(string paymentPspReference, string idempotencyKey = null, PaymentRefundRequest paymentRefundRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | **string** | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to refund. |
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentRefundRequest** | [**PaymentRefundRequest**](PaymentRefundRequest.md) |  |

### Return type

[**PaymentRefundResponse**](PaymentRefundResponse.md)

<a id="refundorcancelpayment"></a>
# **POST** **/payments/{paymentPspReference}/reversals**

Refund or cancel a payment

```csharp 
IPaymentReversalResponse RefundOrCancelPaymentAsync(string paymentPspReference, string idempotencyKey = null, PaymentReversalRequest paymentReversalRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | **string** | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to reverse.  |
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentReversalRequest** | [**PaymentReversalRequest**](PaymentReversalRequest.md) |  |

### Return type

[**PaymentReversalResponse**](PaymentReversalResponse.md)

<a id="updateauthorisedamount"></a>
# **POST** **/payments/{paymentPspReference}/amountUpdates**

Update an authorised amount

```csharp 
IPaymentAmountUpdateResponse UpdateAuthorisedAmountAsync(string paymentPspReference, string idempotencyKey = null, PaymentAmountUpdateRequest paymentAmountUpdateRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentPspReference** | **string** | The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment. |
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **paymentAmountUpdateRequest** | [**PaymentAmountUpdateRequest**](PaymentAmountUpdateRequest.md) |  |

### Return type

[**PaymentAmountUpdateResponse**](PaymentAmountUpdateResponse.md)

