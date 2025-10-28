# Adyen.BalancePlatform.Services.SCAAssociationManagementService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApproveAssociation**](SCAAssociationManagementService.md#approveassociation) | **PATCH** /scaAssociations | Approve a pending approval association |
| [**ListAssociations**](SCAAssociationManagementService.md#listassociations) | **GET** /scaAssociations | Get a list of devices associated with an entity |
| [**RemoveAssociation**](SCAAssociationManagementService.md#removeassociation) | **DELETE** /scaAssociations | Delete association to devices |

<a id="approveassociation"></a>
# **PATCH** **/scaAssociations**

Approve a pending approval association

```csharp 
IApproveAssociationResponse ApproveAssociationAsync(string wWWAuthenticate, ApproveAssociationRequest approveAssociationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **wWWAuthenticate** | **string** | The header for authenticating through SCA. |
| **approveAssociationRequest** | [**ApproveAssociationRequest**](ApproveAssociationRequest.md) |  |

### Return type

[**ApproveAssociationResponse**](ApproveAssociationResponse.md)

<a id="listassociations"></a>
# **GET** **/scaAssociations**

Get a list of devices associated with an entity

```csharp 
IListAssociationsResponse ListAssociationsAsync(ScaEntityType entityType, string entityId, int pageSize, int pageNumber)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **entityType** | **ScaEntityType** | The type of entity you want to retrieve a list of associations for.   Possible values: **accountHolder** or **paymentInstrument**. |
| **entityId** | **string** | The unique identifier of the entity. |
| **pageSize** | **int** | The number of items to have on a page.   Default: **5**. |
| **pageNumber** | **int** | The index of the page to retrieve. The index of the first page is **0** (zero).   Default:  **0**. |

### Return type

[**ListAssociationsResponse**](ListAssociationsResponse.md)

<a id="removeassociation"></a>
# **DELETE** **/scaAssociations**

Delete association to devices

```csharp 
Ivoid RemoveAssociationAsync(string wWWAuthenticate, RemoveAssociationRequest removeAssociationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **wWWAuthenticate** | **string** | The header for authenticating through SCA. |
| **removeAssociationRequest** | [**RemoveAssociationRequest**](RemoveAssociationRequest.md) |  |

### Return type

void (empty response body)

