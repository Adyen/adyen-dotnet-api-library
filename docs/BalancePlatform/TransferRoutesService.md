# Adyen.BalancePlatform.Services.TransferRoutesService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateTransferRoutes**](TransferRoutesService.md#calculatetransferroutes) | **POST** /transferRoutes/calculate | Calculate transfer routes |

<a id="calculatetransferroutes"></a>
# **POST** **/transferRoutes/calculate**

Calculate transfer routes

```csharp 
ITransferRouteResponse CalculateTransferRoutesAsync(TransferRouteRequest transferRouteRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transferRouteRequest** | [**TransferRouteRequest**](TransferRouteRequest.md) |  |

### Return type

[**TransferRouteResponse**](TransferRouteResponse.md)

