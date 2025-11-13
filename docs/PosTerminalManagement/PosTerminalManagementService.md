## Adyen.PosTerminalManagement.Services.PosTerminalManagementService

#### API Base-Path: **https://postfmapi-test.adyen.com/postfmapi/terminal/v1**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.PosTerminalManagement.Extensions;
using Adyen.PosTerminalManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigurePosTerminalManagement((context, services, config) =>
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
    IPosTerminalManagementService posTerminalManagementService = host.Services.GetRequiredService<IPosTerminalManagementService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignTerminals**](PosTerminalManagementService.md#assignterminals) | **POST** /assignTerminals | Assign terminals |
| [**FindTerminal**](PosTerminalManagementService.md#findterminal) | **POST** /findTerminal | Get the account or store of a terminal |
| [**GetStoresUnderAccount**](PosTerminalManagementService.md#getstoresunderaccount) | **POST** /getStoresUnderAccount | Get the stores of an account |
| [**GetTerminalDetails**](PosTerminalManagementService.md#getterminaldetails) | **POST** /getTerminalDetails | Get the details of a terminal |
| [**GetTerminalsUnderAccount**](PosTerminalManagementService.md#getterminalsunderaccount) | **POST** /getTerminalsUnderAccount | Get the list of terminals |

<a id="assignterminals"></a>
### **POST** **/assignTerminals**

Assign terminals

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **assignTerminalsRequest** | **AssignTerminalsRequest** |  |

#### Example usage

```csharp
using Adyen.PosTerminalManagement.Models;
using Adyen.PosTerminalManagement.Services;

// Example `PosTerminalManagementService.AssignTerminals` usage:
// Provide the following values: assignTerminalsRequest
IAssignTerminalsResponse response = await posTerminalManagementService.AssignTerminalsAsync(
    AssignTerminalsRequest assignTerminalsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AssignTerminalsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AssignTerminalsResponse]()


<a id="findterminal"></a>
### **POST** **/findTerminal**

Get the account or store of a terminal

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **findTerminalRequest** | **FindTerminalRequest** |  |

#### Example usage

```csharp
using Adyen.PosTerminalManagement.Models;
using Adyen.PosTerminalManagement.Services;

// Example `PosTerminalManagementService.FindTerminal` usage:
// Provide the following values: findTerminalRequest
IFindTerminalResponse response = await posTerminalManagementService.FindTerminalAsync(
    FindTerminalRequest findTerminalRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out FindTerminalResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[FindTerminalResponse]()


<a id="getstoresunderaccount"></a>
### **POST** **/getStoresUnderAccount**

Get the stores of an account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **getStoresUnderAccountRequest** | **GetStoresUnderAccountRequest** |  |

#### Example usage

```csharp
using Adyen.PosTerminalManagement.Models;
using Adyen.PosTerminalManagement.Services;

// Example `PosTerminalManagementService.GetStoresUnderAccount` usage:
// Provide the following values: getStoresUnderAccountRequest
IGetStoresUnderAccountResponse response = await posTerminalManagementService.GetStoresUnderAccountAsync(
    GetStoresUnderAccountRequest getStoresUnderAccountRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetStoresUnderAccountResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetStoresUnderAccountResponse]()


<a id="getterminaldetails"></a>
### **POST** **/getTerminalDetails**

Get the details of a terminal

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **getTerminalDetailsRequest** | **GetTerminalDetailsRequest** |  |

#### Example usage

```csharp
using Adyen.PosTerminalManagement.Models;
using Adyen.PosTerminalManagement.Services;

// Example `PosTerminalManagementService.GetTerminalDetails` usage:
// Provide the following values: getTerminalDetailsRequest
IGetTerminalDetailsResponse response = await posTerminalManagementService.GetTerminalDetailsAsync(
    GetTerminalDetailsRequest getTerminalDetailsRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetTerminalDetailsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetTerminalDetailsResponse]()


<a id="getterminalsunderaccount"></a>
### **POST** **/getTerminalsUnderAccount**

Get the list of terminals

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **getTerminalsUnderAccountRequest** | **GetTerminalsUnderAccountRequest** |  |

#### Example usage

```csharp
using Adyen.PosTerminalManagement.Models;
using Adyen.PosTerminalManagement.Services;

// Example `PosTerminalManagementService.GetTerminalsUnderAccount` usage:
// Provide the following values: getTerminalsUnderAccountRequest
IGetTerminalsUnderAccountResponse response = await posTerminalManagementService.GetTerminalsUnderAccountAsync(
    GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetTerminalsUnderAccountResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetTerminalsUnderAccountResponse]()


