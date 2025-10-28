# Adyen.Payout.Services.InitializationService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payout/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StoreDetail**](InitializationService.md#storedetail) | **POST** /storeDetail | Store payout details |
| [**StoreDetailAndSubmitThirdParty**](InitializationService.md#storedetailandsubmitthirdparty) | **POST** /storeDetailAndSubmitThirdParty | Store details and submit a payout |
| [**SubmitThirdParty**](InitializationService.md#submitthirdparty) | **POST** /submitThirdParty | Submit a payout |

<a id="storedetail"></a>
# **POST** **/storeDetail**

Store payout details

```csharp 
IStoreDetailResponse StoreDetailAsync(StoreDetailRequest storeDetailRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeDetailRequest** | [**StoreDetailRequest**](StoreDetailRequest.md) |  |

### Return type

[**StoreDetailResponse**](StoreDetailResponse.md)

<a id="storedetailandsubmitthirdparty"></a>
# **POST** **/storeDetailAndSubmitThirdParty**

Store details and submit a payout

```csharp 
IStoreDetailAndSubmitResponse StoreDetailAndSubmitThirdPartyAsync(StoreDetailAndSubmitRequest storeDetailAndSubmitRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeDetailAndSubmitRequest** | [**StoreDetailAndSubmitRequest**](StoreDetailAndSubmitRequest.md) |  |

### Return type

[**StoreDetailAndSubmitResponse**](StoreDetailAndSubmitResponse.md)

<a id="submitthirdparty"></a>
# **POST** **/submitThirdParty**

Submit a payout

```csharp 
ISubmitResponse SubmitThirdPartyAsync(SubmitRequest submitRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **submitRequest** | [**SubmitRequest**](SubmitRequest.md) |  |

### Return type

[**SubmitResponse**](SubmitResponse.md)

