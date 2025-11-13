## Adyen.LegalEntityManagement.Services.TransferInstrumentsService

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
    ITransferInstrumentsService transferInstrumentsService = host.Services.GetRequiredService<ITransferInstrumentsService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransferInstrument**](TransferInstrumentsService.md#createtransferinstrument) | **POST** /transferInstruments | Create a transfer instrument |
| [**DeleteTransferInstrument**](TransferInstrumentsService.md#deletetransferinstrument) | **DELETE** /transferInstruments/{id} | Delete a transfer instrument |
| [**GetTransferInstrument**](TransferInstrumentsService.md#gettransferinstrument) | **GET** /transferInstruments/{id} | Get a transfer instrument |
| [**UpdateTransferInstrument**](TransferInstrumentsService.md#updatetransferinstrument) | **PATCH** /transferInstruments/{id} | Update a transfer instrument |

<a id="createtransferinstrument"></a>
### **POST** **/transferInstruments**

Create a transfer instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **xRequestedVerificationCode** | [string] | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| **transferInstrumentInfo** | **TransferInstrumentInfo** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TransferInstrumentsService.CreateTransferInstrument` usage:
// Provide the following values: [HeaderParameter] xRequestedVerificationCode, transferInstrumentInfo
ITransferInstrument response = await transferInstrumentsService.CreateTransferInstrumentAsync(
    TransferInstrumentInfo transferInstrumentInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferInstrument result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferInstrument]()


<a id="deletetransferinstrument"></a>
### **DELETE** **/transferInstruments/{id}**

Delete a transfer instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the transfer instrument to be deleted. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TransferInstrumentsService.DeleteTransferInstrument` usage:
// Provide the following values: id
await transferInstrumentsService.DeleteTransferInstrumentAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="gettransferinstrument"></a>
### **GET** **/transferInstruments/{id}**

Get a transfer instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the transfer instrument. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TransferInstrumentsService.GetTransferInstrument` usage:
// Provide the following values: id
ITransferInstrument response = await transferInstrumentsService.GetTransferInstrumentAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferInstrument result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferInstrument]()


<a id="updatetransferinstrument"></a>
### **PATCH** **/transferInstruments/{id}**

Update a transfer instrument

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the transfer instrument. |
| **xRequestedVerificationCode** | [string] | Use the requested verification code 0_0001 to resolve any suberrors associated with the transfer instrument. Requested verification codes can only be used in your test environment. |
| **transferInstrumentInfo** | **TransferInstrumentInfo** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TransferInstrumentsService.UpdateTransferInstrument` usage:
// Provide the following values: id, [HeaderParameter] xRequestedVerificationCode, transferInstrumentInfo
ITransferInstrument response = await transferInstrumentsService.UpdateTransferInstrumentAsync(
    string id,
    TransferInstrumentInfo transferInstrumentInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransferInstrument result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransferInstrument]()


