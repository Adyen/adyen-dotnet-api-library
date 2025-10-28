# Adyen.Payment.Services.PaymentsService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payment/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Authorise**](PaymentsService.md#authorise) | **POST** /authorise | Create an authorisation |
| [**Authorise3d**](PaymentsService.md#authorise3d) | **POST** /authorise3d | Complete a 3DS authorisation |
| [**Authorise3ds2**](PaymentsService.md#authorise3ds2) | **POST** /authorise3ds2 | Complete a 3DS2 authorisation |
| [**GetAuthenticationResult**](PaymentsService.md#getauthenticationresult) | **POST** /getAuthenticationResult | Get the 3DS authentication result |
| [**Retrieve3ds2Result**](PaymentsService.md#retrieve3ds2result) | **POST** /retrieve3ds2Result | Get the 3DS2 authentication result |

<a id="authorise"></a>
# **POST** **/authorise**

Create an authorisation

```csharp 
IPaymentResult AuthoriseAsync(PaymentRequest paymentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentRequest** | [**PaymentRequest**](PaymentRequest.md) |  |

### Return type

[**PaymentResult**](PaymentResult.md)

<a id="authorise3d"></a>
# **POST** **/authorise3d**

Complete a 3DS authorisation

```csharp 
IPaymentResult Authorise3dAsync(PaymentRequest3d paymentRequest3d = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentRequest3d** | [**PaymentRequest3d**](PaymentRequest3d.md) |  |

### Return type

[**PaymentResult**](PaymentResult.md)

<a id="authorise3ds2"></a>
# **POST** **/authorise3ds2**

Complete a 3DS2 authorisation

```csharp 
IPaymentResult Authorise3ds2Async(PaymentRequest3ds2 paymentRequest3ds2 = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentRequest3ds2** | [**PaymentRequest3ds2**](PaymentRequest3ds2.md) |  |

### Return type

[**PaymentResult**](PaymentResult.md)

<a id="getauthenticationresult"></a>
# **POST** **/getAuthenticationResult**

Get the 3DS authentication result

```csharp 
IAuthenticationResultResponse GetAuthenticationResultAsync(AuthenticationResultRequest authenticationResultRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **authenticationResultRequest** | [**AuthenticationResultRequest**](AuthenticationResultRequest.md) |  |

### Return type

[**AuthenticationResultResponse**](AuthenticationResultResponse.md)

<a id="retrieve3ds2result"></a>
# **POST** **/retrieve3ds2Result**

Get the 3DS2 authentication result

```csharp 
IThreeDS2ResultResponse Retrieve3ds2ResultAsync(ThreeDS2ResultRequest threeDS2ResultRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **threeDS2ResultRequest** | [**ThreeDS2ResultRequest**](ThreeDS2ResultRequest.md) |  |

### Return type

[**ThreeDS2ResultResponse**](ThreeDS2ResultResponse.md)

