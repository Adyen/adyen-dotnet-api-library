# Adyen.Management.Services.TerminalActionsTerminalLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTerminalAction**](TerminalActionsTerminalLevelService.md#createterminalaction) | **POST** /terminals/scheduleActions | Create a terminal action |

<a id="createterminalaction"></a>
# **POST** **/terminals/scheduleActions**

Create a terminal action

```csharp 
IScheduleTerminalActionsResponse CreateTerminalActionAsync(ScheduleTerminalActionsRequest scheduleTerminalActionsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **scheduleTerminalActionsRequest** | [**ScheduleTerminalActionsRequest**](ScheduleTerminalActionsRequest.md) |  |

### Return type

[**ScheduleTerminalActionsResponse**](ScheduleTerminalActionsResponse.md)

