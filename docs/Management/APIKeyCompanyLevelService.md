## Adyen.Management.Services.APIKeyCompanyLevelService

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
    IAPIKeyCompanyLevelService aPIKeyCompanyLevelService = host.Services.GetRequiredService<IAPIKeyCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateNewApiKey**](APIKeyCompanyLevelService.md#generatenewapikey) | **POST** /companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey | Generate new API key |

<a id="generatenewapikey"></a>
### **POST** **/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey**

Generate new API key

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APIKeyCompanyLevelService.GenerateNewApiKey` usage:
// Provide the following values: companyId, apiCredentialId
IGenerateApiKeyResponse response = await aPIKeyCompanyLevelService.GenerateNewApiKeyAsync(
    string companyId,
    string apiCredentialId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GenerateApiKeyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GenerateApiKeyResponse]()


