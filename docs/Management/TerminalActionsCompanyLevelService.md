# Adyen.Management.Services.TerminalActionsCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTerminalAction**](TerminalActionsCompanyLevelService.md#getterminalaction) | **GET** /companies/{companyId}/terminalActions/{actionId} | Get terminal action |
| [**ListTerminalActions**](TerminalActionsCompanyLevelService.md#listterminalactions) | **GET** /companies/{companyId}/terminalActions | Get a list of terminal actions |

<a id="getterminalaction"></a>
# **GET** **/companies/{companyId}/terminalActions/{actionId}**

Get terminal action

```csharp 
IExternalTerminalAction GetTerminalActionAsync(string companyId, string actionId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **actionId** | **string** | The unique identifier of the terminal action. |

### Return type

[**ExternalTerminalAction**](ExternalTerminalAction.md)

<a id="listterminalactions"></a>
# **GET** **/companies/{companyId}/terminalActions**

Get a list of terminal actions

```csharp 
IListExternalTerminalActionsResponse ListTerminalActionsAsync(string companyId, int pageNumber = null, int pageSize = null, string status = null, string type = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| **status** | **string** | Returns terminal actions with the specified status.  Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**. |
| **type** | **string** | Returns terminal actions of the specified type.  Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**. |

### Return type

[**ListExternalTerminalActionsResponse**](ListExternalTerminalActionsResponse.md)

