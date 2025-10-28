# Adyen.Checkout.Services.OrdersService

### API Base-Path: **https://checkout-test.adyen.com/v71**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](OrdersService.md#cancelorder) | **POST** /orders/cancel | Cancel an order |
| [**GetBalanceOfGiftCard**](OrdersService.md#getbalanceofgiftcard) | **POST** /paymentMethods/balance | Get the balance of a gift card |
| [**Orders**](OrdersService.md#orders) | **POST** /orders | Create an order |

<a id="cancelorder"></a>
# **POST** **/orders/cancel**

Cancel an order

```csharp 
ICancelOrderResponse CancelOrderAsync(string idempotencyKey = null, CancelOrderRequest cancelOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **cancelOrderRequest** | [**CancelOrderRequest**](CancelOrderRequest.md) |  |

### Return type

[**CancelOrderResponse**](CancelOrderResponse.md)

<a id="getbalanceofgiftcard"></a>
# **POST** **/paymentMethods/balance**

Get the balance of a gift card

```csharp 
IBalanceCheckResponse GetBalanceOfGiftCardAsync(string idempotencyKey = null, BalanceCheckRequest balanceCheckRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **balanceCheckRequest** | [**BalanceCheckRequest**](BalanceCheckRequest.md) |  |

### Return type

[**BalanceCheckResponse**](BalanceCheckResponse.md)

<a id="orders"></a>
# **POST** **/orders**

Create an order

```csharp 
ICreateOrderResponse OrdersAsync(string idempotencyKey = null, CreateOrderRequest createOrderRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **createOrderRequest** | [**CreateOrderRequest**](CreateOrderRequest.md) |  |

### Return type

[**CreateOrderResponse**](CreateOrderResponse.md)

