# Adyen.Checkout.Services.RecurringService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTokenForStoredPaymentDetails**](RecurringService.md#deletetokenforstoredpaymentdetails) | **DELETE** /storedPaymentMethods/{storedPaymentMethodId} | Delete a token for stored payment details |
| [**GetTokensForStoredPaymentDetails**](RecurringService.md#gettokensforstoredpaymentdetails) | **GET** /storedPaymentMethods | Get tokens for stored payment details |
| [**StoredPaymentMethods**](RecurringService.md#storedpaymentmethods) | **POST** /storedPaymentMethods | Create a token to store payment details |

<a id="deletetokenforstoredpaymentdetails"></a>
# **DELETE** **/storedPaymentMethods/{storedPaymentMethodId}**

Delete a token for stored payment details

```csharp 
Ivoid DeleteTokenForStoredPaymentDetailsAsync(string storedPaymentMethodId, string shopperReference, string merchantAccount)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedPaymentMethodId** | **string** | The unique identifier of the token. |
| **shopperReference** | **string** | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address. |
| **merchantAccount** | **string** | Your merchant account. |

### Return type

void (empty response body)

<a id="gettokensforstoredpaymentdetails"></a>
# **GET** **/storedPaymentMethods**

Get tokens for stored payment details

```csharp 
IListStoredPaymentMethodsResponse GetTokensForStoredPaymentDetailsAsync(string shopperReference = null, string merchantAccount = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **shopperReference** | **string** | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address. |
| **merchantAccount** | **string** | Your merchant account. |

### Return type

[**ListStoredPaymentMethodsResponse**](ListStoredPaymentMethodsResponse.md)

<a id="storedpaymentmethods"></a>
# **POST** **/storedPaymentMethods**

Create a token to store payment details

```csharp 
IStoredPaymentMethodResource StoredPaymentMethodsAsync(string idempotencyKey = null, StoredPaymentMethodRequest storedPaymentMethodRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **storedPaymentMethodRequest** | [**StoredPaymentMethodRequest**](StoredPaymentMethodRequest.md) |  |

### Return type

[**StoredPaymentMethodResource**](StoredPaymentMethodResource.md)

