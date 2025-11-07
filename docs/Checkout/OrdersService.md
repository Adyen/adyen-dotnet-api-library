## Adyen.Checkout.Services.OrdersService

#### API Base-Path: **https://checkout-test.adyen.com/v71**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureCheckout((context, services, config) =>
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
    IOrdersService ordersService = host.Services.GetRequiredService<IOrdersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](OrdersService.md#cancelorder) | **POST** /orders/cancel | Cancel an order |
| [**GetBalanceOfGiftCard**](OrdersService.md#getbalanceofgiftcard) | **POST** /paymentMethods/balance | Get the balance of a gift card |
| [**Orders**](OrdersService.md#orders) | **POST** /orders | Create an order |

<a id="cancelorder"></a>
### **POST** **/orders/cancel**

Cancel an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **cancelOrderRequest** | **CancelOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `OrdersService.CancelOrder` usage:
// Provide the following values: idempotencyKey, cancelOrderRequest.
ICancelOrderResponse response = await ordersService.CancelOrderAsync(
    string idempotencyKey,
    CancelOrderRequest cancelOrderRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CancelOrderResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CancelOrderResponse]()


<a id="getbalanceofgiftcard"></a>
### **POST** **/paymentMethods/balance**

Get the balance of a gift card

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **balanceCheckRequest** | **BalanceCheckRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `OrdersService.GetBalanceOfGiftCard` usage:
// Provide the following values: idempotencyKey, balanceCheckRequest.
IBalanceCheckResponse response = await ordersService.GetBalanceOfGiftCardAsync(
    string idempotencyKey,
    BalanceCheckRequest balanceCheckRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out BalanceCheckResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[BalanceCheckResponse]()


<a id="orders"></a>
### **POST** **/orders**

Create an order

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | [string] | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **createOrderRequest** | **CreateOrderRequest** |  |

#### Example usage

```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;

// Example `OrdersService.Orders` usage:
// Provide the following values: idempotencyKey, createOrderRequest.
ICreateOrderResponse response = await ordersService.OrdersAsync(
    string idempotencyKey,
    CreateOrderRequest createOrderRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateOrderResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateOrderResponse]()


