## Adyen.SessionAuthentication.Services.SessionAuthenticationService

#### API Base-Path: **https://test.adyen.com/authe/api/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.SessionAuthentication.Extensions;
using Adyen.SessionAuthentication.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureSessionAuthentication((context, services, config) =>
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
    ISessionAuthenticationService sessionAuthenticationService = host.Services.GetRequiredService<ISessionAuthenticationService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAuthenticationSession**](SessionAuthenticationService.md#createauthenticationsession) | **POST** /sessions | Create a session token |

<a id="createauthenticationsession"></a>
### **POST** **/sessions**

Create a session token

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **authenticationSessionRequest** | **AuthenticationSessionRequest** |  |

#### Example usage

```csharp
using Adyen.SessionAuthentication.Models;
using Adyen.SessionAuthentication.Services;

// Example `SessionAuthenticationService.CreateAuthenticationSession` usage:
// Provide the following values: authenticationSessionRequest.
IAuthenticationSessionResponse response = await sessionAuthenticationService.CreateAuthenticationSessionAsync(
    AuthenticationSessionRequest authenticationSessionRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AuthenticationSessionResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AuthenticationSessionResponse]()


