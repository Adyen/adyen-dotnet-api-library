## Adyen.Transfers.Services.CapitalService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/btl/v4**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Transfers.Extensions;
using Adyen.Transfers.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureTransfers((context, services, config) =>
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
    ICapitalService capitalService = host.Services.GetRequiredService<ICapitalService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCapitalAccount**](CapitalService.md#getcapitalaccount) | **GET** /grants | Get a capital account |
| [**GetGrantReferenceDetails**](CapitalService.md#getgrantreferencedetails) | **GET** /grants/{id} | Get grant reference details |
| [**RequestGrantPayout**](CapitalService.md#requestgrantpayout) | **POST** /grants | Request a grant payout |

<a id="getcapitalaccount"></a>
### **GET** **/grants**

Get a capital account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **counterpartyAccountHolderId** | [string] | The counterparty account holder id. |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `CapitalService.GetCapitalAccount` usage:
// Provide the following values: counterpartyAccountHolderId
ICapitalGrants response = await capitalService.GetCapitalAccountAsync(
    Option<string> counterpartyAccountHolderId = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CapitalGrants result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CapitalGrants]()


<a id="getgrantreferencedetails"></a>
### **GET** **/grants/{id}**

Get grant reference details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the grant. |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `CapitalService.GetGrantReferenceDetails` usage:
// Provide the following values: id
ICapitalGrant response = await capitalService.GetGrantReferenceDetailsAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CapitalGrant result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CapitalGrant]()


<a id="requestgrantpayout"></a>
### **POST** **/grants**

Request a grant payout

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **capitalGrantInfo** | **CapitalGrantInfo** |  |

#### Example usage

```csharp
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;

// Example `CapitalService.RequestGrantPayout` usage:
// Provide the following values: [HeaderParameter] idempotencyKey, capitalGrantInfo
ICapitalGrant response = await capitalService.RequestGrantPayoutAsync(
    CapitalGrantInfo capitalGrantInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CapitalGrant result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CapitalGrant]()


