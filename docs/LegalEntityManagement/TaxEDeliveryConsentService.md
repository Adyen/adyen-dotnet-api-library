## Adyen.LegalEntityManagement.Services.TaxEDeliveryConsentService

#### API Base-Path: **https://kyc-test.adyen.com/lem/v4**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureLegalEntityManagement((context, services, config) =>
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
    ITaxEDeliveryConsentService taxEDeliveryConsentService = host.Services.GetRequiredService<ITaxEDeliveryConsentService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckStatusOfConsentForElectronicDeliveryOfTaxForms**](TaxEDeliveryConsentService.md#checkstatusofconsentforelectronicdeliveryoftaxforms) | **POST** /legalEntities/{id}/checkTaxElectronicDeliveryConsent | Check the status of consent for electronic delivery of tax forms |
| [**SetConsentStatusForElectronicDeliveryOfTaxForms**](TaxEDeliveryConsentService.md#setconsentstatusforelectronicdeliveryoftaxforms) | **POST** /legalEntities/{id}/setTaxElectronicDeliveryConsent | Set the consent status for electronic delivery of tax forms |

<a id="checkstatusofconsentforelectronicdeliveryoftaxforms"></a>
### **POST** **/legalEntities/{id}/checkTaxElectronicDeliveryConsent**

Check the status of consent for electronic delivery of tax forms

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TaxEDeliveryConsentService.CheckStatusOfConsentForElectronicDeliveryOfTaxForms` usage:
// Provide the following values: id
ICheckTaxElectronicDeliveryConsentResponse response = await taxEDeliveryConsentService.CheckStatusOfConsentForElectronicDeliveryOfTaxFormsAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CheckTaxElectronicDeliveryConsentResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CheckTaxElectronicDeliveryConsentResponse]()


<a id="setconsentstatusforelectronicdeliveryoftaxforms"></a>
### **POST** **/legalEntities/{id}/setTaxElectronicDeliveryConsent**

Set the consent status for electronic delivery of tax forms

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| **setTaxElectronicDeliveryConsentRequest** | **SetTaxElectronicDeliveryConsentRequest** |  |

#### Example usage

```csharp
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;

// Example `TaxEDeliveryConsentService.SetConsentStatusForElectronicDeliveryOfTaxForms` usage:
// Provide the following values: id, setTaxElectronicDeliveryConsentRequest
await taxEDeliveryConsentService.SetConsentStatusForElectronicDeliveryOfTaxFormsAsync(
    string id,
    SetTaxElectronicDeliveryConsentRequest setTaxElectronicDeliveryConsentRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


