## Adyen.Management.Services.TerminalActionsTerminalLevelService

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
    ITerminalActionsTerminalLevelService terminalActionsTerminalLevelService = host.Services.GetRequiredService<ITerminalActionsTerminalLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTerminalAction**](TerminalActionsTerminalLevelService.md#createterminalaction) | **POST** /terminals/scheduleActions | Create a terminal action |

<a id="createterminalaction"></a>
### **POST** **/terminals/scheduleActions**

Create a terminal action

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **scheduleTerminalActionsRequest** | **ScheduleTerminalActionsRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `TerminalActionsTerminalLevelService.CreateTerminalAction` usage:
// Provide the following values: scheduleTerminalActionsRequest.
IScheduleTerminalActionsResponse response = await terminalActionsTerminalLevelService.CreateTerminalActionAsync(
    ScheduleTerminalActionsRequest scheduleTerminalActionsRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ScheduleTerminalActionsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ScheduleTerminalActionsResponse]()


