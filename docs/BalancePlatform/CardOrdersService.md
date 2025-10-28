# Adyen.BalancePlatform.Services.CardOrdersService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCardOrderItems**](CardOrdersService.md#getcardorderitems) | **GET** /cardorders/{id}/items | Get card order items |
| [**ListCardOrders**](CardOrdersService.md#listcardorders) | **GET** /cardorders | Get a list of card orders |

<a id="getcardorderitems"></a>
# **GET** **/cardorders/{id}/items**

Get card order items

```csharp 
IPaginatedGetCardOrderItemResponse GetCardOrderItemsAsync(string id, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the card order. |
| **offset** | **int** | Specifies the position of an element in a list of card orders. The response includes a list of card order items that starts at the specified offset.  **Default:** 0, which means that the response contains all the elements in the list of card order items. |
| **limit** | **int** | The number of card order items returned per page. **Default:** 10. |

### Return type

[**PaginatedGetCardOrderItemResponse**](PaginatedGetCardOrderItemResponse.md)

<a id="listcardorders"></a>
# **GET** **/cardorders**

Get a list of card orders

```csharp 
IPaginatedGetCardOrderResponse ListCardOrdersAsync(string id = null, string cardManufacturingProfileId = null, string status = null, string txVariantCode = null, DateTimeOffset createdSince = null, DateTimeOffset createdUntil = null, DateTimeOffset lockedSince = null, DateTimeOffset lockedUntil = null, string serviceCenter = null, int offset = null, int limit = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the card order.  |
| **cardManufacturingProfileId** | **string** | The unique identifier of the card manufacturer profile. |
| **status** | **string** | The status of the card order. |
| **txVariantCode** | **string** | The unique code of the card manufacturer profile.  Possible values: **mcmaestro**, **mc**, **visa**, **mcdebit**.  |
| **createdSince** | **DateTimeOffset** | Only include card orders that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **createdUntil** | **DateTimeOffset** | Only include card orders that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **lockedSince** | **DateTimeOffset** | Only include card orders that have been locked on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **lockedUntil** | **DateTimeOffset** | Only include card orders that have been locked on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **serviceCenter** | **string** | The service center at which the card is issued. The value is case-sensitive.  |
| **offset** | **int** | Specifies the position of an element in a list of card orders. The response includes a list of card orders that starts at the specified offset.  **Default:** 0, which means that the response contains all the elements in the list of card orders. |
| **limit** | **int** | The number of card orders returned per page. **Default:** 10. |

### Return type

[**PaginatedGetCardOrderResponse**](PaginatedGetCardOrderResponse.md)

