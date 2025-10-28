# Adyen.BalanceControl.Services.BalanceControlService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/BalanceControl/v1**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalanceTransfer**](BalanceControlService.md#balancetransfer) | **POST** /balanceTransfer | Start a balance transfer |

<a id="balancetransfer"></a>
# **POST** **/balanceTransfer**

Start a balance transfer

```csharp 
IBalanceTransferResponse BalanceTransferAsync(BalanceTransferRequest balanceTransferRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **balanceTransferRequest** | [**BalanceTransferRequest**](BalanceTransferRequest.md) |  |

### Return type

[**BalanceTransferResponse**](BalanceTransferResponse.md)

