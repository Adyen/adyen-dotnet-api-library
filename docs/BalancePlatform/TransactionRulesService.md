# Adyen.BalancePlatform.Services.TransactionRulesService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionRule**](TransactionRulesService.md#createtransactionrule) | **POST** /transactionRules | Create a transaction rule |
| [**DeleteTransactionRule**](TransactionRulesService.md#deletetransactionrule) | **DELETE** /transactionRules/{transactionRuleId} | Delete a transaction rule |
| [**GetTransactionRule**](TransactionRulesService.md#gettransactionrule) | **GET** /transactionRules/{transactionRuleId} | Get a transaction rule |
| [**UpdateTransactionRule**](TransactionRulesService.md#updatetransactionrule) | **PATCH** /transactionRules/{transactionRuleId} | Update a transaction rule |

<a id="createtransactionrule"></a>
# **POST** **/transactionRules**

Create a transaction rule

```csharp 
ITransactionRule CreateTransactionRuleAsync(TransactionRuleInfo transactionRuleInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleInfo** | [**TransactionRuleInfo**](TransactionRuleInfo.md) |  |

### Return type

[**TransactionRule**](TransactionRule.md)

<a id="deletetransactionrule"></a>
# **DELETE** **/transactionRules/{transactionRuleId}**

Delete a transaction rule

```csharp 
ITransactionRule DeleteTransactionRuleAsync(string transactionRuleId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleId** | **string** | The unique identifier of the transaction rule. |

### Return type

[**TransactionRule**](TransactionRule.md)

<a id="gettransactionrule"></a>
# **GET** **/transactionRules/{transactionRuleId}**

Get a transaction rule

```csharp 
ITransactionRuleResponse GetTransactionRuleAsync(string transactionRuleId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleId** | **string** | The unique identifier of the transaction rule. |

### Return type

[**TransactionRuleResponse**](TransactionRuleResponse.md)

<a id="updatetransactionrule"></a>
# **PATCH** **/transactionRules/{transactionRuleId}**

Update a transaction rule

```csharp 
ITransactionRule UpdateTransactionRuleAsync(string transactionRuleId, TransactionRuleInfo transactionRuleInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleId** | **string** | The unique identifier of the transaction rule. |
| **transactionRuleInfo** | [**TransactionRuleInfo**](TransactionRuleInfo.md) |  |

### Return type

[**TransactionRule**](TransactionRule.md)

