# Adyen.Management.Services.TerminalsTerminalLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListTerminals**](TerminalsTerminalLevelService.md#listterminals) | **GET** /terminals | Get a list of terminals |
| [**ReassignTerminal**](TerminalsTerminalLevelService.md#reassignterminal) | **POST** /terminals/{terminalId}/reassign | Reassign a terminal |

<a id="listterminals"></a>
# **GET** **/terminals**

Get a list of terminals

```csharp 
IListTerminalsResponse ListTerminalsAsync(string searchQuery = null, string otpQuery = null, string countries = null, string merchantIds = null, string storeIds = null, string brandModels = null, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **searchQuery** | **string** | Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored. |
| **otpQuery** | **string** | Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored. |
| **countries** | **string** | Returns terminals located in the countries specified by their [two-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). |
| **merchantIds** | **string** | Returns terminals that belong to the merchant accounts specified by their unique merchant account ID. |
| **storeIds** | **string** | Returns terminals that are assigned to the [stores](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores) specified by their unique store ID. |
| **brandModels** | **string** | Returns terminals of the [models](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) specified in the format *brand.model*. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 20 items on a page. |

### Return type

[**ListTerminalsResponse**](ListTerminalsResponse.md)

<a id="reassignterminal"></a>
# **POST** **/terminals/{terminalId}/reassign**

Reassign a terminal

```csharp 
Ivoid ReassignTerminalAsync(string terminalId, TerminalReassignmentRequest terminalReassignmentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **terminalId** | **string** | The unique identifier of the payment terminal. |
| **terminalReassignmentRequest** | [**TerminalReassignmentRequest**](TerminalReassignmentRequest.md) |  |

### Return type

void (empty response body)

