## Adyen.Management.Services.ClientKeyMerchantLevelService

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
    IClientKeyMerchantLevelService clientKeyMerchantLevelService = host.Services.GetRequiredService<IClientKeyMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewClientKey**](ClientKeyMerchantLevelService.md#generatenewclientkey) | **POST** /merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateClientKey | Generate new client key |

<a id="generatenewclientkey"></a>
### **POST** **/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateClientKey**

Generate new client key

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `ClientKeyMerchantLevelService.GenerateNewClientKey` usage:
// Provide the following values: merchantId, apiCredentialId
IGenerateClientKeyResponse response = await clientKeyMerchantLevelService.GenerateNewClientKeyAsync(
    string merchantId,
    string apiCredentialId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GenerateClientKeyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GenerateClientKeyResponse]()


