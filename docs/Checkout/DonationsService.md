# Adyen.Checkout.Services.DonationsService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DonationCampaigns**](DonationsService.md#donationcampaigns) | **POST** /donationCampaigns | Get a list of donation campaigns. |
| [**Donations**](DonationsService.md#donations) | **POST** /donations | Make a donation |

<a id="donationcampaigns"></a>
# **POST** **/donationCampaigns**

Get a list of donation campaigns.

```csharp 
IDonationCampaignsResponse DonationCampaignsAsync(string idempotencyKey = null, DonationCampaignsRequest donationCampaignsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **donationCampaignsRequest** | [**DonationCampaignsRequest**](DonationCampaignsRequest.md) |  |

### Return type

[**DonationCampaignsResponse**](DonationCampaignsResponse.md)

<a id="donations"></a>
# **POST** **/donations**

Make a donation

```csharp 
IDonationPaymentResponse DonationsAsync(string idempotencyKey = null, DonationPaymentRequest donationPaymentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **donationPaymentRequest** | [**DonationPaymentRequest**](DonationPaymentRequest.md) |  |

### Return type

[**DonationPaymentResponse**](DonationPaymentResponse.md)

