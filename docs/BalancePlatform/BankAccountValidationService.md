## Adyen.BalancePlatform.Services.BankAccountValidationService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    IBankAccountValidationService bankAccountValidationService = host.Services.GetRequiredService<IBankAccountValidationService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ValidateBankAccountIdentification**](BankAccountValidationService.md#validatebankaccountidentification) | **POST** /validateBankAccountIdentification | Validate a bank account |

<a id="validatebankaccountidentification"></a>
### **POST** **/validateBankAccountIdentification**

Validate a bank account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **bankAccountIdentificationValidationRequest** | **BankAccountIdentificationValidationRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `BankAccountValidationService.ValidateBankAccountIdentification` usage:
// Provide the following values: bankAccountIdentificationValidationRequest
await bankAccountValidationService.ValidateBankAccountIdentificationAsync(
    BankAccountIdentificationValidationRequest bankAccountIdentificationValidationRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


