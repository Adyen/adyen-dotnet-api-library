# Adyen.LegalEntityManagement.Services.TaxEDeliveryConsentService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckStatusOfConsentForElectronicDeliveryOfTaxForms**](TaxEDeliveryConsentService.md#checkstatusofconsentforelectronicdeliveryoftaxforms) | **POST** /legalEntities/{id}/checkTaxElectronicDeliveryConsent | Check the status of consent for electronic delivery of tax forms |
| [**SetConsentStatusForElectronicDeliveryOfTaxForms**](TaxEDeliveryConsentService.md#setconsentstatusforelectronicdeliveryoftaxforms) | **POST** /legalEntities/{id}/setTaxElectronicDeliveryConsent | Set the consent status for electronic delivery of tax forms |

<a id="checkstatusofconsentforelectronicdeliveryoftaxforms"></a>
# **POST** **/legalEntities/{id}/checkTaxElectronicDeliveryConsent**

Check the status of consent for electronic delivery of tax forms

```csharp 
ICheckTaxElectronicDeliveryConsentResponse CheckStatusOfConsentForElectronicDeliveryOfTaxFormsAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

### Return type

[**CheckTaxElectronicDeliveryConsentResponse**](CheckTaxElectronicDeliveryConsentResponse.md)

<a id="setconsentstatusforelectronicdeliveryoftaxforms"></a>
# **POST** **/legalEntities/{id}/setTaxElectronicDeliveryConsent**

Set the consent status for electronic delivery of tax forms

```csharp 
Ivoid SetConsentStatusForElectronicDeliveryOfTaxFormsAsync(string id, SetTaxElectronicDeliveryConsentRequest setTaxElectronicDeliveryConsentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| **setTaxElectronicDeliveryConsentRequest** | [**SetTaxElectronicDeliveryConsentRequest**](SetTaxElectronicDeliveryConsentRequest.md) |  |

### Return type

void (empty response body)

