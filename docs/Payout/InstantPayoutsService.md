# Adyen.Payout.Services.InstantPayoutsService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/Payout/v68**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Payout**](InstantPayoutsService.md#payout) | **POST** /payout | Make an instant card payout |

<a id="payout"></a>
# **POST** **/payout**

Make an instant card payout

```csharp 
IPayoutResponse PayoutAsync(PayoutRequest payoutRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **payoutRequest** | [**PayoutRequest**](PayoutRequest.md) |  |

### Return type

[**PayoutResponse**](PayoutResponse.md)

