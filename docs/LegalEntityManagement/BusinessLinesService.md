# Adyen.LegalEntityManagement.Services.BusinessLinesService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBusinessLine**](BusinessLinesService.md#createbusinessline) | **POST** /businessLines | Create a business line |
| [**DeleteBusinessLine**](BusinessLinesService.md#deletebusinessline) | **DELETE** /businessLines/{id} | Delete a business line |
| [**GetBusinessLine**](BusinessLinesService.md#getbusinessline) | **GET** /businessLines/{id} | Get a business line |
| [**UpdateBusinessLine**](BusinessLinesService.md#updatebusinessline) | **PATCH** /businessLines/{id} | Update a business line |

<a id="createbusinessline"></a>
# **POST** **/businessLines**

Create a business line

```csharp 
IBusinessLine CreateBusinessLineAsync(BusinessLineInfo businessLineInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **businessLineInfo** | [**BusinessLineInfo**](BusinessLineInfo.md) |  |

### Return type

[**BusinessLine**](BusinessLine.md)

<a id="deletebusinessline"></a>
# **DELETE** **/businessLines/{id}**

Delete a business line

```csharp 
Ivoid DeleteBusinessLineAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the business line to be deleted. |

### Return type

void (empty response body)

<a id="getbusinessline"></a>
# **GET** **/businessLines/{id}**

Get a business line

```csharp 
IBusinessLine GetBusinessLineAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the business line. |

### Return type

[**BusinessLine**](BusinessLine.md)

<a id="updatebusinessline"></a>
# **PATCH** **/businessLines/{id}**

Update a business line

```csharp 
IBusinessLine UpdateBusinessLineAsync(string id, BusinessLineInfoUpdate businessLineInfoUpdate = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the business line. |
| **businessLineInfoUpdate** | [**BusinessLineInfoUpdate**](BusinessLineInfoUpdate.md) |  |

### Return type

[**BusinessLine**](BusinessLine.md)

