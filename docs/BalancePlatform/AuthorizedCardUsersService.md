## Adyen.BalancePlatform.Services.AuthorizedCardUsersService

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
    IAuthorizedCardUsersService authorizedCardUsersService = host.Services.GetRequiredService<IAuthorizedCardUsersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAuthorisedCardUsers**](AuthorizedCardUsersService.md#createauthorisedcardusers) | **POST** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Create authorized users for a card. |
| [**DeleteAuthorisedCardUsers**](AuthorizedCardUsersService.md#deleteauthorisedcardusers) | **DELETE** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Delete the authorized users for a card. |
| [**GetAllAuthorisedCardUsers**](AuthorizedCardUsersService.md#getallauthorisedcardusers) | **GET** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Get authorized users for a card. |
| [**UpdateAuthorisedCardUsers**](AuthorizedCardUsersService.md#updateauthorisedcardusers) | **PATCH** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Update the authorized users for a card. |

<a id="createauthorisedcardusers"></a>
### **POST** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Create authorized users for a card.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | [string] |  |
| **authorisedCardUsers** | **AuthorisedCardUsers** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AuthorizedCardUsersService.CreateAuthorisedCardUsers` usage:
// Provide the following values: paymentInstrumentId, authorisedCardUsers.
I response = await authorizedCardUsersService.CreateAuthorisedCardUsersAsync(
    string paymentInstrumentId,
    AuthorisedCardUsers authorisedCardUsers, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="deleteauthorisedcardusers"></a>
### **DELETE** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Delete the authorized users for a card.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | [string] |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AuthorizedCardUsersService.DeleteAuthorisedCardUsers` usage:
// Provide the following values: paymentInstrumentId.
I response = await authorizedCardUsersService.DeleteAuthorisedCardUsersAsync(
    string paymentInstrumentId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="getallauthorisedcardusers"></a>
### **GET** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Get authorized users for a card.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | [string] |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AuthorizedCardUsersService.GetAllAuthorisedCardUsers` usage:
// Provide the following values: paymentInstrumentId.
IAuthorisedCardUsers response = await authorizedCardUsersService.GetAllAuthorisedCardUsersAsync(
    string paymentInstrumentId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AuthorisedCardUsers result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AuthorisedCardUsers]()


<a id="updateauthorisedcardusers"></a>
### **PATCH** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Update the authorized users for a card.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | [string] |  |
| **authorisedCardUsers** | **AuthorisedCardUsers** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AuthorizedCardUsersService.UpdateAuthorisedCardUsers` usage:
// Provide the following values: paymentInstrumentId, authorisedCardUsers.
I response = await authorizedCardUsersService.UpdateAuthorisedCardUsersAsync(
    string paymentInstrumentId,
    AuthorisedCardUsers authorisedCardUsers, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


