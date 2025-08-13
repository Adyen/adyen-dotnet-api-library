![NET api](https://user-images.githubusercontent.com/16090523/211498272-75a50b61-b1cc-482e-9278-c10a267efe27.png)
# Adyen .NET API Library
[![nuget](https://img.shields.io/nuget/v/adyen.svg)](https://www.nuget.org/packages/adyen/) [![nuget](https://img.shields.io/nuget/dt/adyen.svg)](https://www.nuget.org/packages/adyen/) ![.NET Core](https://github.com/Adyen/adyen-dotnet-api-library/workflows/.NET%20Core/badge.svg)

This is the officially supported .NET library for the Adyen's APIs. Are you looking for examples? You can find our [.NET Integration examples on GitHub here](https://github.com/adyen-examples/adyen-dotnet-online-payments/).

## Supported API versions
The library supports all APIs under the following services:

| API                                                                                                                          | Description                                                                                                                                                                                                                                                                                                                             | Service Name                                                                                     | Supported version        |
|------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|--------------------------|
| [Checkout API](https://docs.adyen.com/api-explorer/Checkout/71/overview)                                                     | Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).                                                                        | [Checkout](Adyen/Service/Checkout)                                                               | **v71**                  |
| [Payments API](https://docs.adyen.com/api-explorer/Payment/68/overview)                                                      | A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods.                                                                               | [Payments](Adyen/Service/Payments)                                                               | **v68**                  |
| [Recurring API](https://docs.adyen.com/api-explorer/Recurring/68/overview)                                                   | The Recurring APIs allow you to manage and remove your tokens or saved payment details. Tokens should be created with validation during a payment request.                                                                                                                                                                              | [Recurring](Adyen/Service/RecurringService.cs)                                                   | **v68**                  |
| [Payouts API](https://docs.adyen.com/api-explorer/Payout/68/overview)                                                        | A set of API endpoints that allow you to store payout details, confirm, or decline a payout.                                                                                                                                                                                                                                            | [Payouts](Adyen/Service/Payouts)                                                                 | **v68**                  |
| [Adyen BinLookup API](https://docs.adyen.com/api-explorer/BinLookup/54/overview)                                             | Endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN. Current supported version                                                                                                                                                                                           | [BinLookup](Adyen/Service/BinLookupService.cs)                                                   | **v54**                  |
| [Stored Value API](https://docs.adyen.com/payment-methods/gift-cards/stored-value-api)                                       | Manage both online and point-of-sale gift cards and other stored-value cards.                                                                                                                                                                                                                                                           | [StoredValue](Adyen/Service/StoredValueService.cs)                                               | **v46**                  |
| [Legal Entity Management API](https://docs.adyen.com/api-explorer/legalentity/3/overview)                                    | The Legal Entity Management API enables you to manage legal entities that contain information required for verification                                                                                                                                                                                                                 | [LegalEntityManagement](Adyen/Service/LegalEntityManagement)                                     | **v3**                   |
| [Management API](https://docs.adyen.com/api-explorer/Management/3/overview)                                                  | Configure and manage your Adyen company and merchant accounts, stores, and payment terminals.                                                                                                                                                                                                                                           | [Management](Adyen/Service/Management)                                                           | **v3**                   |
| [Transfers API](https://docs.adyen.com/api-explorer/transfers/4/overview)                                                    | The Transfers API provides endpoints that you can use to get information about all your transactions, move funds within your balance platform or send funds from your balance platform to a transfer instrument.                                                                                                                        | [Transfers](Adyen/Service/Transfers)                                                             | **v4**                   |
| [Configuration API](https://docs.adyen.com/api-explorer/balanceplatform/2/overview)                                          | The Configuration API enables you to create a platform where you can onboard your users as account holders and create balance accounts, cards, and business accounts.                                                                                                                                                                   | [BalancePlatform](Adyen/Service/BalancePlatform)                                                 | **v2**                   |
| [Balance Control API](https://docs.adyen.com/api-explorer/BalanceControl/1/overview)                                         | The Balance Control API lets you transfer funds between merchant accounts that belong to the same legal entity and are under the same company account.                                                                                                                                                                                  | [BalanceControl](Adyen/Service/BalanceControlService.cs)                                         | **v1**                   |
| [Data Protection API](https://docs.adyen.com/development-resources/data-protection-api)                                      | Our Data Protection API allows you to process Subject Erasure Requests as mandated in General Data Protection Regulation (GDPR).                                                                                                                                                                                                        | [DataProtection](Adyen/Service/DataProtectionService.cs)                                         | **v1**                   |
| [Terminal API (Cloud communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/cloud)                   | Our point-of-sale integration.                                                                                                                                                                                                                                                                                                          | [Cloud-based Terminal API](Adyen/Service/TerminalCloudApi.cs)                                  | Cloud-based Terminal API |      |
| [Terminal API (Local communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/local)                   | Our point-of-sale integration.                                                                                                                                                                                                                                                                                                          | [Local-based Terminal API](Adyen/Service/TerminalLocalApi.cs)                                  | Local-based Terminal API |      |
| [POS Terminal Management API](https://docs.adyen.com/api-explorer/postfmapi/1/overview)                                      | ~~This API provides endpoints for managing your point-of-sale (POS) payment terminals. You can use the API to obtain information about a specific terminal, retrieve overviews of your terminals and stores, and assign terminals to a merchant account or store.~~ ‼️ **Deprecated**: use instead the [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview) for the management of your terminal fleet. terminals.                                                                                | ~~[POSTerminalManagement](Adyen/Service/POSTerminalManagementService.cs)~~                           | ~~**v1**~~                   |
| [Classic Platforms Account API](https://docs.adyen.com/api-explorer/Account/6/overview)                                      | This API is used for the classic integration. If you are just starting your implementation, refer to our new integration guide instead.                                                                                                                                                                                                 | [PlatformsAccount](Adyen/Service/PlatformsAccount)                                               | **v6**                   |
| [Classic Platforms Fund API](https://docs.adyen.com/api-explorer/Fund/6/overview)                                            | This API is used for the classic integration. If you are just starting your implementation, refer to our new integration guide instead.                                                                                                                                                                                                 | [PlatformsFund](Adyen/Service/PlatformsFundService.cs)                                           | **v6**                   |
| [Classic Platforms Hosted Onboarding Page API](https://docs.adyen.com/api-explorer/Hop/6/overview)                           | This API is used for the classic integration. If you are just starting your implementation, refer to our new integration guide instead.                                                                                                                                                                                                 | [PlatformsHostedOnboardingPage](Adyen/Service/PlatformsHostedOnboardingPage)                     | **v6**                   |
| [Classic Platforms Notification Configuration API](https://docs.adyen.com/api-explorer/NotificationConfiguration/6/overview) | This API is used for the classic integration. If you are just starting your implementation, refer to our new integration guide instead.                                                                                                                                                                                                 | [PlatformsNotificationConfiguration](Adyen/Service/PlatformsNotificationConfigurationService.cs) | **v6**                   |
| [Disputes API](https://docs.adyen.com/api-explorer/Disputes/30/overview)                                                     | You can use the [Disputes API](https://docs.adyen.com/risk-management/disputes-api) to automate the dispute handling process so that you can respond to disputes and chargebacks as soon as they are initiated. The Disputes API lets you retrieve defense reasons, supply and delete defense documents, and accept or defend disputes. | [Disputes](Adyen/Service/DisputesService.cs)                                                     | **v30**                  |
| [POS Mobile API](https://docs.adyen.com/api-explorer/possdk/68/overview)                                    | The POS Mobile API is used in the mutual authentication flow between an Adyen Android or iOS [POS Mobile SDK](https://docs.adyen.com/point-of-sale/ipp-mobile/) and the Adyen payments platform. The POS Mobile SDK for Android or iOS devices enables businesses to accept in-person payments using a commercial off-the-shelf (COTS) device like a phone. For example, Tap to Pay transactions, or transactions on a mobile device in combination with a card reader |  [POS Mobile](Adyen/Service/PosMobileService.cs)                        | **v68**                |
| [Payments App API](https://docs.adyen.com/api-explorer/payments-app/1/overview) | The Payments App API is used to Board and manage the Adyen Payments App on your Android mobile devices. | [PaymentsAppApi](Adyen/Service/PaymentsAppService.cs) | **v1** |

## Supported Webhook versions
The library supports all webhooks under the following model directories:

| Webhooks                                                                                          | Description                                                                                                                                                                                                                                                                         | Model Name                                                                       | Supported Version |
|---------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------|-------------------|
| [Authentication Webhooks](https://docs.adyen.com/api-explorer/Checkout/latest/overview)           | You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).                                                                                                                     | [AcsWebhooks](Adyen/Model/AcsWebhooks)                                           | **v1**            |
| [Configuration Webhooks](https://docs.adyen.com/api-explorer/balanceplatform-webhooks/2/overview) | You can use these webhooks to build your implementation. For example, you can use this information to update internal statuses when the status of a capability is changed.                                                                                                          | [ConfigurationWebhooks](Adyen/Model/ConfigurationWebhooks)                       | **v2**            |
| [Transfer Webhooks](https://docs.adyen.com/api-explorer/transfer-webhooks/4/overview)             | You can use these webhooks to build your implementation. For example, you can use this information to update balances in your own dashboards or to keep track of incoming funds.                                                                                                    | [TransferWebhooks](Adyen/Model/TransferWebhooks)                                 | **v4**            |
| [Transaction Webhooks](https://docs.adyen.com/api-explorer/transaction-webhooks/4/overview)       | Adyen sends webhooks to inform your system about incoming and outgoing transfers in your platform. You can use these webhooks to build your implementation. For example, you can use this information to update balances in your own dashboards or to keep track of incoming funds. | [TransactionWebhooks](Adyen/Model/TransactionWebhooks)                           | **v4**            |
| [Report Webhooks](https://docs.adyen.com/api-explorer/report-webhooks/1/overview)                 | You can download reports programmatically by making an HTTP GET request, or manually from your Balance Platform Customer Area                                                                                                                                                       | [ReportWebhooks](Adyen/Model/ReportWebhooks)                                     | **v1**            |
| [Management Webhooks](https://docs.adyen.com/api-explorer/ManagementNotification/3/overview)      | Adyen uses webhooks to inform your system about events that happen with your Adyen company and merchant accounts, stores, payment terminals, and payment methods when using Management API.                                                                                         | [ManagementWebhooks](Adyen/Model/ManagementWebhooks)                             | **v3**            |
| [Negative Balance Warning Webhooks](https://docs.adyen.com/api-explorer/Webhooks/1/overview)      | Adyen sends this webhook to inform you about a balance account whose balance has been negative for a given number of days.                                                                                                                                                          | [NegativeBalanceWarningWebhooks](Adyen/Model/NegativeBalanceWarningWebhooks)     | **v1**            |
| [Notification Webhooks](https://docs.adyen.com/api-explorer/Webhooks/1/overview)                  | We use webhooks to send you updates about payment status updates, newly available reports, and other events that you can subscribe to. For more information, refer to our documentation                                                                                             | [Notification](Adyen/Model/Notification)                                         | **v1**            |
| [Classic Platform Webhooks](https://docs.adyen.com/api-explorer/Notification/6/overview)          | The Notification API sends notifications to the endpoints specified in a given subscription. Subscriptions are managed through the Notification Configuration API. The API specifications listed here detail the format of each notification.                                       | [PlatformWebhooks](Adyen/Model/PlatformWebhooks)                                 | **v6**            |

For more information, refer to our [documentation](https://docs.adyen.com/) or the [API Explorer](https://docs.adyen.com/api-explorer/).

## Prerequisites
- [Adyen Test Account](https://docs.adyen.com/get-started-with-adyen)
- [Adyen API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). For testing, your API credential needs to have the [API PCI Payments role](https://docs.adyen.com/development-resources/api-credentials#roles).
- Adyen .NET API Library supports .NET Standard 2.0 and .NET 6.0
- In order for Adyen .NET API Library to support local terminal api certificate validation the application should be set to .net core 2.1 and above or .net framework 4.6.1 and above

## Installation
Simply download and restore nuget packages https://www.nuget.org/packages/Adyen/
or install it from package manager
```
PM> Install-Package Adyen -Version x.x.x
```
## ❗Disclaimer on Enum Values

Please note that the integer value (index) of the enums used in this library may change in future releases. These values are not guaranteed to remain static, and they may be modified, added, or removed as the library evolves.

⚠️ We advise against hard-coding or relying on specific enum integer values in your implementation, as they may break compatibility with future versions of this library. Use instead the string value of the enums.

Upon upgrade check the Release Notes and the associated PRs to understand the changes and any potential impact on your integration.

## Using the library

In order to submit http request to Adyen API you need to initialize the client. The following example makes a checkout payment request:
```csharp
using Adyen;
using Adyen.Model.Checkout;
using Adyen.Service.Checkout;
using Environment = Adyen.Model.Environment;

var config = new Config()
{
    XApiKey = "ADYEN_API_KEY",
    Environment = Environment.Test
};
var client = new Client(config);
var paymentsService = new PaymentsService(client);
var amount = new Model.Checkout.Amount("USD", 1000);
var cardDetails = new CardDetails
{
    EncryptedCardNumber = "test_4111111111111111",
    EncryptedSecurityCode = "test_737",
    EncryptedExpiryMonth = "test_03",
    EncryptedExpiryYear = "test_2030",
    HolderName = "John Smith",
    Type = CardDetails.TypeEnum.Card
};
var paymentRequest = new Model.Checkout.PaymentRequest
{
    Reference = "Your order number ",
    ReturnUrl = @"https://your-company.com/...",
    MerchantAccount = "your-merchant-account",
    Amount = amount,
    PaymentMethod = new CheckoutPaymentMethod(cardDetails)
};
var paymentResponse = paymentsService.Payments(paymentRequest);
```
Or in case you would like to make an asynchronous `/payments` request with idempotency key and cancellation token, the last line would be instead:
```sharp
var requestOptions = new RequestOptions();
requestOptions.IdempotencyKey = "YourGeneratedUniqueGuid";
PaymentResponse paymentResponse = await paymentsService.PaymentsAsync(paymentRequest, requestOptions: requestOptions, cancellationToken: new CancellationToken());
```
### Deserializing JSON Strings
In some setups you might need to deserialize JSON strings to request objects. For example, when using the libraries in combination with [Dropin/Components](https://github.com/Adyen/adyen-web). Please use the built-in deserialization functions:
~~~~ c#
// Import the required model class
using Adyen.Model.Checkout;

// Deserialize using built-in function
PaymentRequest paymentRequest = PaymentRequest.FromJson("YOUR_JSON_STRING");
~~~~
### Running the tests
Navigate to adyen-dotnet-api-library folder and run the following commands.
```
dotnet build
dotnet test
```

> [!IMPORTANT] We have split and renamed `TerminalCloudApi.cs` to:
> 1. `TerminalApiAsyncService.cs` (which sends requests to `terminal-api.adyen.com/async`) and
> 2. `TerminalApiSyncService.cs` (which sends requests to `terminal-api.adyen.com/sync`)
> 3. `TerminalApiLocalService.cs` (which sends requests to your custom endpoint, f.e. `https://198.51.100.1:8443/nexo`)


### Using the Cloud Terminal API 
In order to submit POS request with Cloud Terminal API, you need to initialize the client with the **endpoints that it is closer to your region** when going **live**. The Endpoints are available as contacts in [ClientConfig](/Adyen/Constants/ClientConfig.cs).
For more information, visit our [documentation](https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#live-endpoints)
```csharp
// Example for EU based region
using Adyen;
using Adyen.Constants;

var config = new Config
{
    XApiKey = "ADYEN_API_KEY",
    CloudApiEndPoint = ClientConfig.CloudApiEndPointEULive
};
var client = new Client(config);
```

To parse the terminal API notifications, you can use the following custom deserializer. This method will throw an exception for non-notification requests.

```csharp
SaleToPoiMessageSerializer serializer = new SaleToPoiMessageSerializer();
SaleToPOIRequest saleToPoiRequest = serializer.DeserializeNotification(your_terminal_notification);
```

### Example Cloud Terminal API integration `/sync`-endpoint
```c#
using System;
using Adyen.Model;
using Adyen.Model.TerminalApi;
using Adyen.Model.TerminalApi.Message;
using Adyen.Service;
using Environment = Adyen.Model.Environment;
 
namespace Adyen.Terminal
{
   public static class Program
   {
        private static void Main(string[] args)
        {
            var config = new Config() {
                XApiKey = "ADYEN_API_KEY",
                Environment = Environment.Test
            };
            var client = new Client(config, Environment.Test);
        }
       
        // Terminal-api `/sync` - `https://terminal-api-test.adyen.com/sync`
        private static SyncEndpointExample(Client client) {
            ITerminalApiSyncService terminalApiSyncService = new TerminalApiSyncService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            SaleToPOIResponse response = terminalApiSyncService.Request(GetPaymentRequest()); // Use: await terminalApiSyncService.RequestAsync(GetPaymentRequest()) for asynchronous communications.
            PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
            Console.WriteLine(paymentResponse?.Response?.Result);
        }
       
        // Terminal-api `/async` - `https://terminal-api-test.adyen.com/async`
        private static AsyncEndpointExample(Client client) {
            ITerminalApiAsyncService terminalApiAsyncService = new TerminalApiAsyncService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
            String response = terminalApiAsyncService.Request(GetPaymentRequest()); // Use: await terminalApiAsyncService.RequestAsync(GetPaymentRequest()) for asynchronous communications.
            Console.WriteLine(response);
        }
       
        private static SaleToPOIRequest GetPaymentRequest()
        {
            var serviceID = "SERVICE_ID"; // ServiceId should be unique for every request
            var saleID = "SALE_ID";
            var POIID = "SERIAL_NUMBER";
            var transactionID = "123459";
            SaleToPOIRequest saleToPOIRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeader()
                {
                    MessageClass = MessageClassType.Service,
                    MessageCategory = MessageCategoryType.Payment,
                    MessageType = MessageType.Request,
                    ServiceID = serviceID,
                    SaleID = saleID,
                    POIID = POIID
                },
                MessagePayload = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = transactionID,
                            TimeStamp = DateTime.Now
                        }
                    },
                    PaymentTransaction = new PaymentTransaction()
                    {
                        AmountsReq = new AmountsReq()
                        {
                            Currency = "EUR",
                            RequestedAmount = new decimal(13.37)
                        },
                    },
                }
            };
            return saleToPOIRequest;
        }
    }
}
```

### Using the Local Terminal API
The request and response payloads are identical to the Cloud Terminal API, however an additional encryption details object is required to send the requests. You can retrieve these details from the Customer Area, make sure you update your terminal to the latest version if you've updated these keys.
```csharp
using Adyen;
using Adyen.Security;

var encryptionCredentialDetails = new EncryptionCredentialDetails
{
    KeyVersion = 1,
    AdyenCryptoVersion = 1,
    KeyIdentifier = "CryptoKeyIdentifier12345",
    Password = "p@ssw0rd123456"
};
var config = new Config
{
    Environment = Model.Environment.Test,
    LocalTerminalApiEndpoint = @"https://_terminal_:8443/nexo/" // _terminal_ example: `https://198.51.100.1:8443/nexo` (can be found in the WIFI settings of your terminal)
};
var client = new Client(config);
ITerminalApiLocalService terminalApiLocalService = new TerminalApiLocalService(
    client,
    new SaleToPoiMessageSerializer(),
    new SaleToPoiMessageSecuredEncryptor(),
    new SaleToPoiMessageSecuredSerializer()
);
// Asynchronous call (preferred)
var saleToPOIResponse = await terminalApiLocalService.RequestEncryptedAsync(paymentRequest, encryptionCredentialDetails, new CancellationToken()); // Pass cancellation token or create a new one.
// Synchronous (blocking) call
//var saleToPOIResponse = terminalApiLocalService.RequestEncrypted(paymentRequest, encryptionCredentialDetails);
```
Alternatively one can use the local terminal API without encryption. This is only allowed in the TEST environment and in order for this to work one has to remove any encryption details from the Customer Area.
When sending requests to a local (unknown) endpoint, you may run into `System.Net.Http.HttpRequestException: The SSL connection could not be established` due to certificate issues. 
For **local** testing purposes, developers can override the `System.Net.Http.HttpClientHandler` and always returns `true` when validating the certificate. 

> [!CAUTION] Follow the guide in the [Adyen documentation](https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/local/#install-root-cert) to install the root certificate on TEST and on LIVE.

```csharp
using Adyen;
using Adyen.Security;

// Override the HttpClientHandler to always return true, for LOCAL TESTING PURPOSES, NEVER run this on live. 
var handler = new System.Net.Http.HttpClientHandler { ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true };
var client = new Client(config, new System.Net.Http.HttpClient(handler));

ITerminalApiLocalService terminalApiLocalService = new TerminalApiLocalService(client, new SaleToPoiMessageSerializer(), new SaleToPoiMessageSecuredEncryptor(), new SaleToPoiMessageSecuredSerializer());
SaleToPOIResponse response = await terminalApiLocalService.RequestEncryptedAsync(PaymentRequest());
PaymentResponse paymentResponse = response.MessagePayload as PaymentResponse;
Console.WriteLine(paymentResponse?.Response?.Result);
```

To parse the terminal API notifications, use the following custom deserializer. This method will throw an exception for non-notification requests.
```csharp
var serializer = new SaleToPoiMessageSerializer();
var saleToPoiRequest = serializer.DeserializeNotification(your_terminal_notification);
```
Note that the `AdditionalResponse` field, when performing a CardAcquisition request could be either a `based64 encoded`-string or `key-value`-pair. You can use the `CardAcquisitionUtil.AdditionalResponse(...)`-function to deserialize it. 
```csharp
AdditionalResponse additionalResponse = CardAcquisitionUtil.AdditionalResponse(jsonString);
```



### Parsing BalancePlatform and Management Webhooks
In order to parse banking webhooks, first validate the webhooks (recommended) by retrieving the hmac key from the webhook header and the hmac signature from the Balance Platform CA configuration page respectively.
```csharp
using Adyen.Model.ConfigurationWebhooks;
using Adyen.Webhooks;
using Adyen.Util;

...
var hmacValidator = new HmacValidator();
var handler = new BalancePlatformWebhookHandler();
bool isValid = hmacValidator.IsValidWebhook("hmacSignature", "ADYEN_HMAC_KEY", webhookPayload);

if (isValid) {
    dynamic webhook = handler.GetGenericBalancePlatformWebhook(webhookPayload);
}
```
If you want to handle specific webhook types you're expecting to receive, check the type and retrieve if the type is correct:
```csharp
var handler = new BalancePlatformWebhookHandler();
bool isAccountHolderNotification = handler.GetAccountHolderNotificationRequest(json_payload, out AccountHolderNotificationRequest webhook)
// Your logic here based on whether the webhook parsed correctly or not
```
Validating management webhooks is identical to validating the balance platform webhooks. To parse the management webhooks, however, one calls the following handler:
```csharp
var handler = new ManagementWebhookHandler();
if(handler.GetMerchantCreatedNotificationRequest(json_payload, out MerchantCreatedNotificationRequest webhook))
{ 
    // Your logic here using the passed through webhook variable
}
```

## Feedback
We value your input! Help us enhance our API Libraries and improve the integration experience by providing your feedback. Please take a moment to fill out [our feedback form](https://forms.gle/A4EERrR6CWgKWe5r9) to share your thoughts, suggestions or ideas. 

## Contributing
We encourage you to contribute to this repository, so everyone can benefit from new features, bug fixes, and any other improvements.
Have a look at our [contributing guidelines](/CONTRIBUTING.md) to find out how to raise a pull request.

## Support
If you have a feature request, or spotted a bug or a technical problem, [create an issue here](https://github.com/Adyen/adyen-dotnet-api-library/issues/new/choose).

For other questions, [contact our Support Team](https://www.adyen.help/hc/en-us/requests/new?ticket_form_id=360000705420).

## Licence
This repository is available under the [MIT license](/LICENSE).

## See also
* [Adyen .NET Integration Examples](https://github.com/adyen-examples/adyen-dotnet-online-payments/)
* [Adyen Docs](https://docs.adyen.com/)
* [API Explorer](https://docs.adyen.com/api-explorer/)
