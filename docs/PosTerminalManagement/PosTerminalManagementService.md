# Adyen.PosTerminalManagement.Services.PosTerminalManagementService

### API Base-Path: **https://postfmapi-test.adyen.com/postfmapi/terminal/v1**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignTerminals**](PosTerminalManagementService.md#assignterminals) | **POST** /assignTerminals | Assign terminals |
| [**FindTerminal**](PosTerminalManagementService.md#findterminal) | **POST** /findTerminal | Get the account or store of a terminal |
| [**GetStoresUnderAccount**](PosTerminalManagementService.md#getstoresunderaccount) | **POST** /getStoresUnderAccount | Get the stores of an account |
| [**GetTerminalDetails**](PosTerminalManagementService.md#getterminaldetails) | **POST** /getTerminalDetails | Get the details of a terminal |
| [**GetTerminalsUnderAccount**](PosTerminalManagementService.md#getterminalsunderaccount) | **POST** /getTerminalsUnderAccount | Get the list of terminals |

<a id="assignterminals"></a>
# **POST** **/assignTerminals**

Assign terminals

```csharp 
IAssignTerminalsResponse AssignTerminalsAsync(AssignTerminalsRequest assignTerminalsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **assignTerminalsRequest** | [**AssignTerminalsRequest**](AssignTerminalsRequest.md) |  |

### Return type

[**AssignTerminalsResponse**](AssignTerminalsResponse.md)

<a id="findterminal"></a>
# **POST** **/findTerminal**

Get the account or store of a terminal

```csharp 
IFindTerminalResponse FindTerminalAsync(FindTerminalRequest findTerminalRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **findTerminalRequest** | [**FindTerminalRequest**](FindTerminalRequest.md) |  |

### Return type

[**FindTerminalResponse**](FindTerminalResponse.md)

<a id="getstoresunderaccount"></a>
# **POST** **/getStoresUnderAccount**

Get the stores of an account

```csharp 
IGetStoresUnderAccountResponse GetStoresUnderAccountAsync(GetStoresUnderAccountRequest getStoresUnderAccountRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **getStoresUnderAccountRequest** | [**GetStoresUnderAccountRequest**](GetStoresUnderAccountRequest.md) |  |

### Return type

[**GetStoresUnderAccountResponse**](GetStoresUnderAccountResponse.md)

<a id="getterminaldetails"></a>
# **POST** **/getTerminalDetails**

Get the details of a terminal

```csharp 
IGetTerminalDetailsResponse GetTerminalDetailsAsync(GetTerminalDetailsRequest getTerminalDetailsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **getTerminalDetailsRequest** | [**GetTerminalDetailsRequest**](GetTerminalDetailsRequest.md) |  |

### Return type

[**GetTerminalDetailsResponse**](GetTerminalDetailsResponse.md)

<a id="getterminalsunderaccount"></a>
# **POST** **/getTerminalsUnderAccount**

Get the list of terminals

```csharp 
IGetTerminalsUnderAccountResponse GetTerminalsUnderAccountAsync(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **getTerminalsUnderAccountRequest** | [**GetTerminalsUnderAccountRequest**](GetTerminalsUnderAccountRequest.md) |  |

### Return type

[**GetTerminalsUnderAccountResponse**](GetTerminalsUnderAccountResponse.md)

