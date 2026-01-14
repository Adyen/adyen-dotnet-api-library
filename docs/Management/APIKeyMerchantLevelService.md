## Adyen.Management.Services.APIKeyMerchantLevelService

#### API Base-Path: **https://management-test.adyen.com/v3**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureManagement((context, services, config) =>
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
    IAPIKeyMerchantLevelService aPIKeyMerchantLevelService = host.Services.GetRequiredService<IAPIKeyMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewApiKey**](APIKeyMerchantLevelService.md#generatenewapikey) | **POST** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey | Generate new API key |

<a id="generatenewapikey"></a>
### **POST** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey**

Generate new API key

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APIKeyMerchantLevelService.GenerateNewApiKey` usage:
// Provide the following values: merchantId, apiCredentialId
IGenerateApiKeyResponse response = await aPIKeyMerchantLevelService.GenerateNewApiKeyAsync(
    string merchantId, string apiCredentialId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GenerateApiKeyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GenerateApiKeyResponse]()


