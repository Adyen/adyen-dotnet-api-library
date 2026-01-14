## Adyen.LegalEntityManagement.Services.HostedOnboardingService

#### API Base-Path: **https://kyc-test.adyen.com/lem/v4**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureLegalEntityManagement((context, services, config) =>
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
    IHostedOnboardingService hostedOnboardingService = host.Services.GetRequiredService<IHostedOnboardingService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLinkToAdyenhostedOnboardingPage**](HostedOnboardingService.md#getlinktoadyenhostedonboardingpage) | **POST** /legalEntities/{id}/onboardingLinks | Get a link to an Adyen-hosted onboarding page |
| [**GetOnboardingLinkTheme**](HostedOnboardingService.md#getonboardinglinktheme) | **GET** /themes/{id} | Get an onboarding link theme |
| [**ListHostedOnboardingPageThemes**](HostedOnboardingService.md#listhostedonboardingpagethemes) | **GET** /themes | Get a list of hosted onboarding page themes |

<a id="getlinktoadyenhostedonboardingpage"></a>
### **POST** **/legalEntities/{id}/onboardingLinks**

Get a link to an Adyen-hosted onboarding page

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity |
| **onboardingLinkInfo** | **OnboardingLinkInfo** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `HostedOnboardingService.GetLinkToAdyenhostedOnboardingPage` usage:
// Provide the following values: id, onboardingLinkInfo
IOnboardingLink response = await hostedOnboardingService.GetLinkToAdyenhostedOnboardingPageAsync(
    string id, OnboardingLinkInfo onboardingLinkInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out OnboardingLink result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[OnboardingLink]()


<a id="getonboardinglinktheme"></a>
### **GET** **/themes/{id}**

Get an onboarding link theme

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the theme |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `HostedOnboardingService.GetOnboardingLinkTheme` usage:
// Provide the following values: id
IOnboardingTheme response = await hostedOnboardingService.GetOnboardingLinkThemeAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out OnboardingTheme result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[OnboardingTheme]()


<a id="listhostedonboardingpagethemes"></a>
### **GET** **/themes**

Get a list of hosted onboarding page themes

#### Parameters
This endpoint does not need any parameter.
#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `HostedOnboardingService.ListHostedOnboardingPageThemes` usage:
// Provide the following values: 
IOnboardingThemes response = await hostedOnboardingService.ListHostedOnboardingPageThemesAsync(
    
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out OnboardingThemes result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[OnboardingThemes]()


