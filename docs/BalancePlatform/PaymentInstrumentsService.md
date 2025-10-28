# Adyen.BalancePlatform.Services.PaymentInstrumentsService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNetworkTokenProvisioningData**](PaymentInstrumentsService.md#createnetworktokenprovisioningdata) | **POST** /paymentInstruments/{id}/networkTokenActivationData | Create network token provisioning data |
| [**CreatePaymentInstrument**](PaymentInstrumentsService.md#createpaymentinstrument) | **POST** /paymentInstruments | Create a payment instrument |
| [**GetAllTransactionRulesForPaymentInstrument**](PaymentInstrumentsService.md#getalltransactionrulesforpaymentinstrument) | **GET** /paymentInstruments/{id}/transactionRules | Get all transaction rules for a payment instrument |
| [**GetNetworkTokenActivationData**](PaymentInstrumentsService.md#getnetworktokenactivationdata) | **GET** /paymentInstruments/{id}/networkTokenActivationData | Get network token activation data |
| [**GetPanOfPaymentInstrument**](PaymentInstrumentsService.md#getpanofpaymentinstrument) | **GET** /paymentInstruments/{id}/reveal | Get the PAN of a payment instrument |
| [**GetPaymentInstrument**](PaymentInstrumentsService.md#getpaymentinstrument) | **GET** /paymentInstruments/{id} | Get a payment instrument |
| [**ListNetworkTokens**](PaymentInstrumentsService.md#listnetworktokens) | **GET** /paymentInstruments/{id}/networkTokens | List network tokens |
| [**RevealDataOfPaymentInstrument**](PaymentInstrumentsService.md#revealdataofpaymentinstrument) | **POST** /paymentInstruments/reveal | Reveal the data of a payment instrument |
| [**UpdatePaymentInstrument**](PaymentInstrumentsService.md#updatepaymentinstrument) | **PATCH** /paymentInstruments/{id} | Update a payment instrument |

<a id="createnetworktokenprovisioningdata"></a>
# **POST** **/paymentInstruments/{id}/networkTokenActivationData**

Create network token provisioning data

```csharp 
INetworkTokenActivationDataResponse CreateNetworkTokenProvisioningDataAsync(string id, NetworkTokenActivationDataRequest networkTokenActivationDataRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |
| **networkTokenActivationDataRequest** | [**NetworkTokenActivationDataRequest**](NetworkTokenActivationDataRequest.md) |  |

### Return type

[**NetworkTokenActivationDataResponse**](NetworkTokenActivationDataResponse.md)

<a id="createpaymentinstrument"></a>
# **POST** **/paymentInstruments**

Create a payment instrument

```csharp 
IPaymentInstrument CreatePaymentInstrumentAsync(PaymentInstrumentInfo paymentInstrumentInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentInfo** | [**PaymentInstrumentInfo**](PaymentInstrumentInfo.md) |  |

### Return type

[**PaymentInstrument**](PaymentInstrument.md)

<a id="getalltransactionrulesforpaymentinstrument"></a>
# **GET** **/paymentInstruments/{id}/transactionRules**

Get all transaction rules for a payment instrument

```csharp 
ITransactionRulesResponse GetAllTransactionRulesForPaymentInstrumentAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |

### Return type

[**TransactionRulesResponse**](TransactionRulesResponse.md)

<a id="getnetworktokenactivationdata"></a>
# **GET** **/paymentInstruments/{id}/networkTokenActivationData**

Get network token activation data

```csharp 
INetworkTokenActivationDataResponse GetNetworkTokenActivationDataAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |

### Return type

[**NetworkTokenActivationDataResponse**](NetworkTokenActivationDataResponse.md)

<a id="getpanofpaymentinstrument"></a>
# **GET** **/paymentInstruments/{id}/reveal**

Get the PAN of a payment instrument

```csharp 
IPaymentInstrumentRevealInfo GetPanOfPaymentInstrumentAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |

### Return type

[**PaymentInstrumentRevealInfo**](PaymentInstrumentRevealInfo.md)

<a id="getpaymentinstrument"></a>
# **GET** **/paymentInstruments/{id}**

Get a payment instrument

```csharp 
IPaymentInstrument GetPaymentInstrumentAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |

### Return type

[**PaymentInstrument**](PaymentInstrument.md)

<a id="listnetworktokens"></a>
# **GET** **/paymentInstruments/{id}/networkTokens**

List network tokens

```csharp 
IListNetworkTokensResponse ListNetworkTokensAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |

### Return type

[**ListNetworkTokensResponse**](ListNetworkTokensResponse.md)

<a id="revealdataofpaymentinstrument"></a>
# **POST** **/paymentInstruments/reveal**

Reveal the data of a payment instrument

```csharp 
IPaymentInstrumentRevealResponse RevealDataOfPaymentInstrumentAsync(PaymentInstrumentRevealRequest paymentInstrumentRevealRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentRevealRequest** | [**PaymentInstrumentRevealRequest**](PaymentInstrumentRevealRequest.md) |  |

### Return type

[**PaymentInstrumentRevealResponse**](PaymentInstrumentRevealResponse.md)

<a id="updatepaymentinstrument"></a>
# **PATCH** **/paymentInstruments/{id}**

Update a payment instrument

```csharp 
IUpdatePaymentInstrument UpdatePaymentInstrumentAsync(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument. |
| **paymentInstrumentUpdateRequest** | [**PaymentInstrumentUpdateRequest**](PaymentInstrumentUpdateRequest.md) |  |

### Return type

[**UpdatePaymentInstrument**](UpdatePaymentInstrument.md)

