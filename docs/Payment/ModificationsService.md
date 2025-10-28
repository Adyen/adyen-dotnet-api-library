# Adyen.Payment.Services.ModificationsService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payment/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustAuthorisation**](ModificationsService.md#adjustauthorisation) | **POST** /adjustAuthorisation | Change the authorised amount |
| [**Cancel**](ModificationsService.md#cancel) | **POST** /cancel | Cancel an authorisation |
| [**CancelOrRefund**](ModificationsService.md#cancelorrefund) | **POST** /cancelOrRefund | Cancel or refund a payment |
| [**Capture**](ModificationsService.md#capture) | **POST** /capture | Capture an authorisation |
| [**Donate**](ModificationsService.md#donate) | **POST** /donate | Create a donation |
| [**Refund**](ModificationsService.md#refund) | **POST** /refund | Refund a captured payment |
| [**TechnicalCancel**](ModificationsService.md#technicalcancel) | **POST** /technicalCancel | Cancel an authorisation using your reference |
| [**VoidPendingRefund**](ModificationsService.md#voidpendingrefund) | **POST** /voidPendingRefund | Cancel an in-person refund |

<a id="adjustauthorisation"></a>
# **POST** **/adjustAuthorisation**

Change the authorised amount

```csharp 
IModificationResult AdjustAuthorisationAsync(AdjustAuthorisationRequest adjustAuthorisationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **adjustAuthorisationRequest** | [**AdjustAuthorisationRequest**](AdjustAuthorisationRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="cancel"></a>
# **POST** **/cancel**

Cancel an authorisation

```csharp 
IModificationResult CancelAsync(CancelRequest cancelRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **cancelRequest** | [**CancelRequest**](CancelRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="cancelorrefund"></a>
# **POST** **/cancelOrRefund**

Cancel or refund a payment

```csharp 
IModificationResult CancelOrRefundAsync(CancelOrRefundRequest cancelOrRefundRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **cancelOrRefundRequest** | [**CancelOrRefundRequest**](CancelOrRefundRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="capture"></a>
# **POST** **/capture**

Capture an authorisation

```csharp 
IModificationResult CaptureAsync(CaptureRequest captureRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **captureRequest** | [**CaptureRequest**](CaptureRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="donate"></a>
# **POST** **/donate**

Create a donation

```csharp 
IModificationResult DonateAsync(DonationRequest donationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **donationRequest** | [**DonationRequest**](DonationRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="refund"></a>
# **POST** **/refund**

Refund a captured payment

```csharp 
IModificationResult RefundAsync(RefundRequest refundRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **refundRequest** | [**RefundRequest**](RefundRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="technicalcancel"></a>
# **POST** **/technicalCancel**

Cancel an authorisation using your reference

```csharp 
IModificationResult TechnicalCancelAsync(TechnicalCancelRequest technicalCancelRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **technicalCancelRequest** | [**TechnicalCancelRequest**](TechnicalCancelRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

<a id="voidpendingrefund"></a>
# **POST** **/voidPendingRefund**

Cancel an in-person refund

```csharp 
IModificationResult VoidPendingRefundAsync(VoidPendingRefundRequest voidPendingRefundRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **voidPendingRefundRequest** | [**VoidPendingRefundRequest**](VoidPendingRefundRequest.md) |  |

### Return type

[**ModificationResult**](ModificationResult.md)

