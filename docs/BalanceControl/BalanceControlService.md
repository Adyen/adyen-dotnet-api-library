## Adyen.BalanceControl.Services.BalanceControlService

#### API Base-Path: **https://pal-test.adyen.com/pal/servlet/BalanceControl/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalanceControl.Extensions;
using Adyen.BalanceControl.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalanceControl((context, services, config) =>
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
    IBalanceControlService balanceControlService = host.Services.GetRequiredService<IBalanceControlService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalanceTransfer**](BalanceControlService.md#balancetransfer) | **POST** /balanceTransfer | Start a balance transfer |

<a id="balancetransfer"></a>
### **POST** **/balanceTransfer**

Start a balance transfer

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceTransferRequest** | **BalanceTransferRequest** |  |

#### Example usage

```csharp
using Adyen.BalanceControl.Models;
using Adyen.BalanceControl.Services;

// Example `BalanceControlService.BalanceTransfer` usage:
// Provide the following values: balanceTransferRequest
IBalanceTransferResponse response = await balanceControlService.BalanceTransferAsync(
    BalanceTransferRequest balanceTransferRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalanceTransferResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalanceTransferResponse]()


