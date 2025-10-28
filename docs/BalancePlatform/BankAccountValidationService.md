# Adyen.BalancePlatform.Services.BankAccountValidationService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ValidateBankAccountIdentification**](BankAccountValidationService.md#validatebankaccountidentification) | **POST** /validateBankAccountIdentification | Validate a bank account |

<a id="validatebankaccountidentification"></a>
# **POST** **/validateBankAccountIdentification**

Validate a bank account

```csharp 
Ivoid ValidateBankAccountIdentificationAsync(BankAccountIdentificationValidationRequest bankAccountIdentificationValidationRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **bankAccountIdentificationValidationRequest** | [**BankAccountIdentificationValidationRequest**](BankAccountIdentificationValidationRequest.md) |  |

### Return type

void (empty response body)

