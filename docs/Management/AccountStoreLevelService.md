# Adyen.Management.Services.AccountStoreLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateStore**](AccountStoreLevelService.md#createstore) | **POST** /stores | Create a store |
| [**CreateStoreByMerchantId**](AccountStoreLevelService.md#createstorebymerchantid) | **POST** /merchants/{merchantId}/stores | Create a store |
| [**GetStore**](AccountStoreLevelService.md#getstore) | **GET** /merchants/{merchantId}/stores/{storeId} | Get a store |
| [**GetStoreById**](AccountStoreLevelService.md#getstorebyid) | **GET** /stores/{storeId} | Get a store |
| [**ListStores**](AccountStoreLevelService.md#liststores) | **GET** /stores | Get a list of stores |
| [**ListStoresByMerchantId**](AccountStoreLevelService.md#liststoresbymerchantid) | **GET** /merchants/{merchantId}/stores | Get a list of stores |
| [**UpdateStore**](AccountStoreLevelService.md#updatestore) | **PATCH** /merchants/{merchantId}/stores/{storeId} | Update a store |
| [**UpdateStoreById**](AccountStoreLevelService.md#updatestorebyid) | **PATCH** /stores/{storeId} | Update a store |

<a id="createstore"></a>
# **POST** **/stores**

Create a store

```csharp 
IStore CreateStoreAsync(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeCreationWithMerchantCodeRequest** | [**StoreCreationWithMerchantCodeRequest**](StoreCreationWithMerchantCodeRequest.md) |  |

### Return type

[**Store**](Store.md)

<a id="createstorebymerchantid"></a>
# **POST** **/merchants/{merchantId}/stores**

Create a store

```csharp 
IStore CreateStoreByMerchantIdAsync(string merchantId, StoreCreationRequest storeCreationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **storeCreationRequest** | [**StoreCreationRequest**](StoreCreationRequest.md) |  |

### Return type

[**Store**](Store.md)

<a id="getstore"></a>
# **GET** **/merchants/{merchantId}/stores/{storeId}**

Get a store

```csharp 
IStore GetStoreAsync(string merchantId, string storeId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **storeId** | **string** | The unique identifier of the store. |

### Return type

[**Store**](Store.md)

<a id="getstorebyid"></a>
# **GET** **/stores/{storeId}**

Get a store

```csharp 
IStore GetStoreByIdAsync(string storeId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | **string** | The unique identifier of the store. |

### Return type

[**Store**](Store.md)

<a id="liststores"></a>
# **GET** **/stores**

Get a list of stores

```csharp 
IListStoresResponse ListStoresAsync(int pageNumber = null, int pageSize = null, string reference = null, string merchantId = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| **reference** | **string** | The reference of the store. |
| **merchantId** | **string** | The unique identifier of the merchant account. |

### Return type

[**ListStoresResponse**](ListStoresResponse.md)

<a id="liststoresbymerchantid"></a>
# **GET** **/merchants/{merchantId}/stores**

Get a list of stores

```csharp 
IListStoresResponse ListStoresByMerchantIdAsync(string merchantId, int pageNumber = null, int pageSize = null, string reference = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| **reference** | **string** | The reference of the store. |

### Return type

[**ListStoresResponse**](ListStoresResponse.md)

<a id="updatestore"></a>
# **PATCH** **/merchants/{merchantId}/stores/{storeId}**

Update a store

```csharp 
IStore UpdateStoreAsync(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **storeId** | **string** | The unique identifier of the store. |
| **updateStoreRequest** | [**UpdateStoreRequest**](UpdateStoreRequest.md) |  |

### Return type

[**Store**](Store.md)

<a id="updatestorebyid"></a>
# **PATCH** **/stores/{storeId}**

Update a store

```csharp 
IStore UpdateStoreByIdAsync(string storeId, UpdateStoreRequest updateStoreRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storeId** | **string** | The unique identifier of the store. |
| **updateStoreRequest** | [**UpdateStoreRequest**](UpdateStoreRequest.md) |  |

### Return type

[**Store**](Store.md)

