## Adyen.BalancePlatform.Services.CardOrdersService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    ICardOrdersService cardOrdersService = host.Services.GetRequiredService<ICardOrdersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCardOrderItems**](CardOrdersService.md#getcardorderitems) | **GET** /cardorders/{id}/items | Get card order items |
| [**ListCardOrders**](CardOrdersService.md#listcardorders) | **GET** /cardorders | Get a list of card orders |

<a id="getcardorderitems"></a>
### **GET** **/cardorders/{id}/items**

Get card order items

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the card order. |
| **offset** | [int] | Specifies the position of an element in a list of card orders. The response includes a list of card order items that starts at the specified offset.  **Default:** 0, which means that the response contains all the elements in the list of card order items. |
| **limit** | [int] | The number of card order items returned per page. **Default:** 10. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `CardOrdersService.GetCardOrderItems` usage:
// Provide the following values: id, offset, limit
IPaginatedGetCardOrderItemResponse response = await cardOrdersService.GetCardOrderItemsAsync(
    string id,
    int offset,
    int limit, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaginatedGetCardOrderItemResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaginatedGetCardOrderItemResponse]()


<a id="listcardorders"></a>
### **GET** **/cardorders**

Get a list of card orders

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the card order.  |
| **cardManufacturingProfileId** | [string] | The unique identifier of the card manufacturer profile. |
| **status** | [string] | The status of the card order. |
| **txVariantCode** | [string] | The unique code of the card manufacturer profile.  Possible values: **mcmaestro**, **mc**, **visa**, **mcdebit**.  |
| **createdSince** | [DateTimeOffset] | Only include card orders that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **createdUntil** | [DateTimeOffset] | Only include card orders that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **lockedSince** | [DateTimeOffset] | Only include card orders that have been locked on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **lockedUntil** | [DateTimeOffset] | Only include card orders that have been locked on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| **serviceCenter** | [string] | The service center at which the card is issued. The value is case-sensitive.  |
| **offset** | [int] | Specifies the position of an element in a list of card orders. The response includes a list of card orders that starts at the specified offset.  **Default:** 0, which means that the response contains all the elements in the list of card orders. |
| **limit** | [int] | The number of card orders returned per page. **Default:** 10. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `CardOrdersService.ListCardOrders` usage:
// Provide the following values: id, cardManufacturingProfileId, status, txVariantCode, createdSince, createdUntil, lockedSince, lockedUntil, serviceCenter, offset, limit
IPaginatedGetCardOrderResponse response = await cardOrdersService.ListCardOrdersAsync(
    string id,
    string cardManufacturingProfileId,
    string status,
    string txVariantCode,
    DateTimeOffset createdSince,
    DateTimeOffset createdUntil,
    DateTimeOffset lockedSince,
    DateTimeOffset lockedUntil,
    string serviceCenter,
    int offset,
    int limit, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaginatedGetCardOrderResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaginatedGetCardOrderResponse]()


