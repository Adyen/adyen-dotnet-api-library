# Adyen.Management.Services.PaymentMethodsMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddApplePayDomain**](PaymentMethodsMerchantLevelService.md#addapplepaydomain) | **POST** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains | Add an Apple Pay domain |
| [**GetAllPaymentMethods**](PaymentMethodsMerchantLevelService.md#getallpaymentmethods) | **GET** /merchants/{merchantId}/paymentMethodSettings | Get all payment methods |
| [**GetApplePayDomains**](PaymentMethodsMerchantLevelService.md#getapplepaydomains) | **GET** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains | Get Apple Pay domains |
| [**GetPaymentMethodDetails**](PaymentMethodsMerchantLevelService.md#getpaymentmethoddetails) | **GET** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId} | Get payment method details |
| [**RequestPaymentMethod**](PaymentMethodsMerchantLevelService.md#requestpaymentmethod) | **POST** /merchants/{merchantId}/paymentMethodSettings | Request a payment method |
| [**UpdatePaymentMethod**](PaymentMethodsMerchantLevelService.md#updatepaymentmethod) | **PATCH** /merchants/{merchantId}/paymentMethodSettings/{paymentMethodId} | Update a payment method |

<a id="addapplepaydomain"></a>
# **POST** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains**

Add an Apple Pay domain

```csharp 
Ivoid AddApplePayDomainAsync(string merchantId, string paymentMethodId, ApplePayInfo applePayInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **paymentMethodId** | **string** | The unique identifier of the payment method. |
| **applePayInfo** | [**ApplePayInfo**](ApplePayInfo.md) |  |

### Return type

void (empty response body)

<a id="getallpaymentmethods"></a>
# **GET** **/merchants/{merchantId}/paymentMethodSettings**

Get all payment methods

```csharp 
IPaymentMethodResponse GetAllPaymentMethodsAsync(string merchantId, string storeId = null, string businessLineId = null, int pageSize = null, int pageNumber = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **storeId** | **string** | The unique identifier of the store for which to return the payment methods. |
| **businessLineId** | **string** | The unique identifier of the Business Line for which to return the payment methods. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| **pageNumber** | **int** | The number of the page to fetch. |

### Return type

[**PaymentMethodResponse**](PaymentMethodResponse.md)

<a id="getapplepaydomains"></a>
# **GET** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains**

Get Apple Pay domains

```csharp 
IApplePayInfo GetApplePayDomainsAsync(string merchantId, string paymentMethodId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **paymentMethodId** | **string** | The unique identifier of the payment method. |

### Return type

[**ApplePayInfo**](ApplePayInfo.md)

<a id="getpaymentmethoddetails"></a>
# **GET** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}**

Get payment method details

```csharp 
IPaymentMethod GetPaymentMethodDetailsAsync(string merchantId, string paymentMethodId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **paymentMethodId** | **string** | The unique identifier of the payment method. |

### Return type

[**PaymentMethod**](PaymentMethod.md)

<a id="requestpaymentmethod"></a>
# **POST** **/merchants/{merchantId}/paymentMethodSettings**

Request a payment method

```csharp 
IPaymentMethod RequestPaymentMethodAsync(string merchantId, PaymentMethodSetupInfo paymentMethodSetupInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **paymentMethodSetupInfo** | [**PaymentMethodSetupInfo**](PaymentMethodSetupInfo.md) |  |

### Return type

[**PaymentMethod**](PaymentMethod.md)

<a id="updatepaymentmethod"></a>
# **PATCH** **/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}**

Update a payment method

```csharp 
IPaymentMethod UpdatePaymentMethodAsync(string merchantId, string paymentMethodId, UpdatePaymentMethodInfo updatePaymentMethodInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **paymentMethodId** | **string** | The unique identifier of the payment method. |
| **updatePaymentMethodInfo** | [**UpdatePaymentMethodInfo**](UpdatePaymentMethodInfo.md) |  |

### Return type

[**PaymentMethod**](PaymentMethod.md)

