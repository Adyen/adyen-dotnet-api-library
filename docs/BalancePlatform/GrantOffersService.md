# Adyen.BalancePlatform.Services.GrantOffersService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllAvailableGrantOffers**](GrantOffersService.md#getallavailablegrantoffers) | **GET** /grantOffers | Get all available grant offers |
| [**GetGrantOffer**](GrantOffersService.md#getgrantoffer) | **GET** /grantOffers/{grantOfferId} | Get a grant offer |

<a id="getallavailablegrantoffers"></a>
# **GET** **/grantOffers**

Get all available grant offers

```csharp 
IGrantOffers GetAllAvailableGrantOffersAsync(string accountHolderId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **accountHolderId** | **string** | The unique identifier of the grant account. |

### Return type

[**GrantOffers**](GrantOffers.md)

<a id="getgrantoffer"></a>
# **GET** **/grantOffers/{grantOfferId}**

Get a grant offer

```csharp 
IGrantOffer GetGrantOfferAsync(string grantOfferId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **grantOfferId** | **string** | The unique identifier of the grant offer. |

### Return type

[**GrantOffer**](GrantOffer.md)

