## Adyen.BalancePlatform.Services.ManageCardPINService

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
    IManageCardPINService manageCardPINService = host.Services.GetRequiredService<IManageCardPINService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeCardPin**](ManageCardPINService.md#changecardpin) | **POST** /pins/change | Change a card PIN |
| [**PublicKey**](ManageCardPINService.md#publickey) | **GET** /publicKey | Get an RSA public key |
| [**RevealCardPin**](ManageCardPINService.md#revealcardpin) | **POST** /pins/reveal | Reveal a card PIN |

<a id="changecardpin"></a>
### **POST** **/pins/change**

Change a card PIN

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pinChangeRequest** | **PinChangeRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageCardPINService.ChangeCardPin` usage:
// Provide the following values: pinChangeRequest
IPinChangeResponse response = await manageCardPINService.ChangeCardPinAsync(
    PinChangeRequest pinChangeRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PinChangeResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PinChangeResponse]()


<a id="publickey"></a>
### **GET** **/publicKey**

Get an RSA public key

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **purpose** | [string] | The purpose of the public key.  Possible values: **pinChange**, **pinReveal**, **panReveal**.  Default value: **pinReveal**. |
| **format** | [string] | The encoding format of public key.  Possible values: **jwk**, **pem**.  Default value: **pem**. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageCardPINService.PublicKey` usage:
// Provide the following values: purpose, format
IPublicKeyResponse response = await manageCardPINService.PublicKeyAsync(
    Option<string> purpose = default, Option<string> format = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PublicKeyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PublicKeyResponse]()


<a id="revealcardpin"></a>
### **POST** **/pins/reveal**

Reveal a card PIN

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **revealPinRequest** | **RevealPinRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `ManageCardPINService.RevealCardPin` usage:
// Provide the following values: revealPinRequest
IRevealPinResponse response = await manageCardPINService.RevealCardPinAsync(
    RevealPinRequest revealPinRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out RevealPinResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[RevealPinResponse]()


