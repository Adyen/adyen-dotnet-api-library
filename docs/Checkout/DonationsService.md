## Adyen.Checkout.Services.DonationsService

#### API Base-Path: **https://checkout-test.adyen.com/v71**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureCheckout((context, services, config) =>
    {
        config.ConfigureAdyenOptions(options =>
        {
            // Set your ADYEN_API_KEY or use get it from your environment using context.Configuration["ADYEN_API_KEY"].
            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];

            // Set your environment, e.g. `Test` or `Live`.
            options.Environment = AdyenEnvironment.Test;

            // For the Live environment, additionally include your LiveEndpointUrlPrefix.
            options.LiveEndpointUrlPrefix = "your-live-endpoint-url-prefix";
        });
    })
    .Build();

    // You can inject this service in your constructor.
    IDonationsService donationsService = host.Services.GetRequiredService<IDonationsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DonationCampaigns**](DonationsService.md#donationcampaigns) | **POST** /donationCampaigns | Get a list of donation campaigns. |
| [**Donations**](DonationsService.md#donations) | **POST** /donations | Make a donation |

<a id="donationcampaigns"></a>
### **POST** **/donationCampaigns**

Get a list of donation campaigns.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **donationCampaignsRequest** | **DonationCampaignsRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `DonationsService.DonationCampaigns` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, donationCampaignsRequest
IDonationCampaignsResponse response = await donationsService.DonationCampaignsAsync(
    DonationCampaignsRequest donationCampaignsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DonationCampaignsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DonationCampaignsResponse]()


<a id="donations"></a>
### **POST** **/donations**

Make a donation

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **donationPaymentRequest** | **DonationPaymentRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `DonationsService.Donations` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, donationPaymentRequest
IDonationPaymentResponse response = await donationsService.DonationsAsync(
    DonationPaymentRequest donationPaymentRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out DonationPaymentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[DonationPaymentResponse]()


