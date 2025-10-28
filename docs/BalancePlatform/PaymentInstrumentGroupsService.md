# Adyen.BalancePlatform.Services.PaymentInstrumentGroupsService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePaymentInstrumentGroup**](PaymentInstrumentGroupsService.md#createpaymentinstrumentgroup) | **POST** /paymentInstrumentGroups | Create a payment instrument group |
| [**GetAllTransactionRulesForPaymentInstrumentGroup**](PaymentInstrumentGroupsService.md#getalltransactionrulesforpaymentinstrumentgroup) | **GET** /paymentInstrumentGroups/{id}/transactionRules | Get all transaction rules for a payment instrument group |
| [**GetPaymentInstrumentGroup**](PaymentInstrumentGroupsService.md#getpaymentinstrumentgroup) | **GET** /paymentInstrumentGroups/{id} | Get a payment instrument group |

<a id="createpaymentinstrumentgroup"></a>
# **POST** **/paymentInstrumentGroups**

Create a payment instrument group

```csharp 
IPaymentInstrumentGroup CreatePaymentInstrumentGroupAsync(PaymentInstrumentGroupInfo paymentInstrumentGroupInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentGroupInfo** | [**PaymentInstrumentGroupInfo**](PaymentInstrumentGroupInfo.md) |  |

### Return type

[**PaymentInstrumentGroup**](PaymentInstrumentGroup.md)

<a id="getalltransactionrulesforpaymentinstrumentgroup"></a>
# **GET** **/paymentInstrumentGroups/{id}/transactionRules**

Get all transaction rules for a payment instrument group

```csharp 
ITransactionRulesResponse GetAllTransactionRulesForPaymentInstrumentGroupAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument group. |

### Return type

[**TransactionRulesResponse**](TransactionRulesResponse.md)

<a id="getpaymentinstrumentgroup"></a>
# **GET** **/paymentInstrumentGroups/{id}**

Get a payment instrument group

```csharp 
IPaymentInstrumentGroup GetPaymentInstrumentGroupAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the payment instrument group. |

### Return type

[**PaymentInstrumentGroup**](PaymentInstrumentGroup.md)

