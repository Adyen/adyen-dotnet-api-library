## Adyen.DataProtection.Services.DataProtectionService

#### API Base-Path: **https://ca-test.adyen.com/ca/services/DataProtectionService/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.DataProtection.Extensions;
using Adyen.DataProtection.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureDataProtection((context, services, config) =>
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
    IDataProtectionService dataProtectionService = host.Services.GetRequiredService<IDataProtectionService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RequestSubjectErasure**](DataProtectionService.md#requestsubjecterasure) | **POST** /requestSubjectErasure | Submit a Subject Erasure Request. |

<a id="requestsubjecterasure"></a>
### **POST** **/requestSubjectErasure**

Submit a Subject Erasure Request.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **subjectErasureByPspReferenceRequest** | **SubjectErasureByPspReferenceRequest** |  |

#### Example usage

```csharp
using Adyen.DataProtection.Models;
using Adyen.DataProtection.Services;

// Example `DataProtectionService.RequestSubjectErasure` usage:
// Provide the following values: subjectErasureByPspReferenceRequest.
ISubjectErasureResponse response = await dataProtectionService.RequestSubjectErasureAsync(
    SubjectErasureByPspReferenceRequest subjectErasureByPspReferenceRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out SubjectErasureResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[SubjectErasureResponse]()


