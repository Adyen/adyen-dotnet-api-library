![NET api](https://user-images.githubusercontent.com/16090523/211498272-75a50b61-b1cc-482e-9278-c10a267efe27.png)
# Adyen .NET API Library
[![nuget](https://img.shields.io/nuget/v/adyen.svg)](https://www.nuget.org/packages/adyen/) [![nuget](https://img.shields.io/nuget/dt/adyen.svg)](https://www.nuget.org/packages/adyen/) ![.NET Core](https://github.com/Adyen/adyen-dotnet-api-library/workflows/.NET%20Core/badge.svg)

This is the officially supported .NET library for using Adyen's APIs.
## Supported API versions
The library supports all APIs under the following services:

| API                                                                                                        | Description                                                                                                                                                                                                                                                       | Service Name                                                        | Supported version                                                |
|------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------|------------------------------------------------------------------|
| [Checkout API](https://docs.adyen.com/api-explorer/Checkout/70/overview)                         | Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).  | [Checkout](Adyen/Service/Checkout)                                  | **v70**                                                          |
| [Payments API](https://docs.adyen.com/api-explorer/Payment/68/overview)                                 | A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods.| [Payments](Adyen/Service/Payments)                                  | **v68**                                                          |
| [Recurring API](https://docs.adyen.com/api-explorer/Recurring/68/overview)                              | The Recurring APIs allow you to manage and remove your tokens or saved payment details. Tokens should be created with validation during a payment request.                                                                                                        | [Recurring](Adyen/Service/RecurringService.cs)                      | **v68**                                                          |
| [Payouts API](https://docs.adyen.com/api-explorer/Payout/68/overview)                                   | A set of API endpoints that allow you to store payout details, confirm, or decline a payout.                                                                                                                                                                      | [Payouts](Adyen/Service/Payouts)                                    | **v68**                                                          |
| [Adyen BinLookup API](https://docs.adyen.com/api-explorer/BinLookup/54/overview)                        | Endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN. Current supported version                                                                                                                     | [BinLookup](Adyen/Service/BinLookupService.cs)                      | **v54**                                                          |
| [Stored Value API](https://docs.adyen.com/payment-methods/gift-cards/stored-value-api)                     | Manage both online and point-of-sale gift cards and other stored-value cards.                                                                                                                     | [StoredValue](Adyen/Service/StoredValueService.cs)                  | **v46**                                                          |
| [Legal Entity Management API](https://docs.adyen.com/api-explorer/legalentity/3/overview)                  | The Legal Entity Management API enables you to manage legal entities that contain information required for verification                                                                                                                                           | [LegalEntityManagement](Adyen/Service/LegalEntityManagement)        | **v3**                                                           |
| [Transfers API](https://docs.adyen.com/api-explorer/transfers/3/overview)                                  | The Transfers API provides endpoints that you can use to get information about all your transactions, move funds within your balance platform or send funds from your balance platform to a transfer instrument.                                                  | [Transfers](Adyen/Service/Transfers)                                | **v3**                                                           |
| [Configuration API](https://docs.adyen.com/api-explorer/balanceplatform/2/overview) | The Configuration API enables you to create a platform where you can onboard your users as account holders and create balance accounts, cards, and business accounts. | [BalancePlatform](Adyen/Service/BalancePlatform) | **v2** 
| [Balance Control API](https://docs.adyen.com/api-explorer/BalanceControl/1/overview)                       | The Balance Control API lets you transfer funds between merchant accounts that belong to the same legal entity and are under the same company account.                                                  | [BalanceControl](Adyen/Service/BalanceControlService.cs)            | **v1**                                                           |
| [Data Protection API](https://docs.adyen.com/development-resources/data-protection-api)                               | Our Data Protection API allows you to process Subject Erasure Requests as mandated in General Data Protection Regulation (GDPR).                                                                                                                                                                                                                                         | [DataProtection](Adyen/Service/DataProtectionService.cs)            | **v1**                                                           |
| [Terminal API (Cloud communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/cloud) | Our point-of-sale integration.                                                                                                                                                                                                                                    | [Cloud-based Terminal API](Adyen/Service/PosPaymentCloudApi.cs)     | Cloud-based Terminal API |      |
| [Terminal API (Local communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/local) | Our point-of-sale integration.                                                                                                                                                                                                                                    | [Local-based Terminal API](Adyen/Service/PosPaymentLocalApi.cs)     | Local-based Terminal API |      |
| [POS Terminal Management API](https://docs.adyen.com/api-explorer/postfmapi/1/overview)                 | This API provides endpoints for managing your point-of-sale (POS) payment terminals. You can use the API to obtain information about a specific terminal, retrieve overviews of your terminals and stores, and assign terminals to a merchant account or store.                                                                                                                                                                                                       | [POSTerminalManagement](Adyen/Service/POSTerminalManagementService.cs) | **v1**                                                           |

## Supported Webhook versions
The library supports all webhooks under the following model directories:

| Webhooks                                                                                          | Description                                                                                                                                                                                 | Model Name                                                 | Supported Version |
|---------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------|-------------------|
| [Authentication Webhooks](https://docs.adyen.com/api-explorer/Checkout/latest/overview)           | You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).                             | [AcsWebhooks](Adyen/Model/AcsWebhooks)                     | **v1**            |
| [Configuration Webhooks](https://docs.adyen.com/api-explorer/balanceplatform-webhooks/1/overview) | You can use these webhooks to build your implementation. For example, you can use this information to update internal statuses when the status of a capability is changed.                  | [ConfigurationWebhooks](Adyen/Model/ConfigurationWebhooks) | **v1**            |
| [Transfer Webhooks](https://docs.adyen.com/api-explorer/transfer-webhooks/3/overview)             | You can use these webhooks to build your implementation. For example, you can use this information to update balances in your own dashboards or to keep track of incoming funds.            | [TransferWebhooks](Adyen/Model/TransferWebhooks)           | **v3**            |
| [Report Webhooks](https://docs.adyen.com/api-explorer/report-webhooks/1/overview)                 | You can download reports programmatically by making an HTTP GET request, or manually from your Balance Platform Customer Area                                                               | [ReportWebhooks](Adyen/Model/ReportWebhooks)               | **v1**            |
| [Management Webhooks](https://docs.adyen.com/api-explorer/ManagementNotification/1/overview)      | Adyen uses webhooks to inform your system about events that happen with your Adyen company and merchant accounts, stores, payment terminals, and payment methods when using Management API. | [ManagementWebhooks](Adyen/Model/ManagementWebhooks)       | **v1**            |
| [Notification Webhooks](https://docs.adyen.com/api-explorer/Webhooks/1/overview)                  | We use webhooks to send you updates about payment status updates, newly available reports, and other events that you can subscribe to. For more information, refer to our documentation     | [Notification](Adyen/Model/Notification)                   | **v1**            |


For more information, refer to our [documentation](https://docs.adyen.com/) or the [API Explorer](https://docs.adyen.com/api-explorer/).

## Prerequisites
- [Adyen test account](https://docs.adyen.com/get-started-with-adyen)
- [API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). For testing, your API credential needs to have the [API PCI Payments role](https://docs.adyen.com/development-resources/api-credentials#roles).
- Adyen dotnet API Library supports .net standard 2.0 and above
- In order for Adyen dotnet API Library to support local terminal api certificate validation the application should be set to .net core 2.1 and above or .net framework 4.6.1 and above

## Installation
Simply download and restore nuget packages https://www.nuget.org/packages/Adyen/
or install it from package manager
```
PM> Install-Package Adyen -Version x.x.x
```
## Using the library

In order to submit http request to Adyen API you need to initialize the client. The following example makes a checkout payment request:
```c#
    using Adyen;
    using Adyen.Model.Checkout;
    using Adyen.Service.Checkout;
    using Environment = Adyen.Model.Environment;

            var config = new Config()
            {
                XApiKey = "your-api-key",
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
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number ",
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "your-merchant-account",
                Amount = amount,
                PaymentMethod = new CheckoutPaymentMethod(cardDetails)
            };
            var paymentResponse = paymentsService.Payments(paymentsRequest);
```
Or in case you would like to make an asynchronous /payments call with idempotency key and cancellation token, the last line would be instead:
```c#
Task<PaymentResponse> paymentResponse = checkout.PaymentsAsync(
                paymentRequest,
                requestOptions: myIdempotencyKey, 
                cancellationToken: myCancellationToken);
```
## Running the tests
Navigate to adyen-dotnet-api-library folder and run the following commands.
```
dotnet build
dotnet test
```
## Using the Cloud Terminal API 
In order to submit POS request with Cloud Terminal API you need to initialize the client with the Endpoints that it is closer to your region. The Endpoints are available as contacts in [ClientConfig](https://github.com/Adyen/adyen-dotnet-api-library/blob/develop/Adyen/Constants/ClientConfig.cs#L35)
For more information please read our [documentation](https://docs.adyen.com/point-of-sale/terminal-api-fundamentals#cloud)
```c#
//Example for EU based Endpoint Syncronous
using Adyen;
using Adyen.Constants;

var config = new Config
  {
    XApiKey = "Your merchant XAPI key",
    CloudApiEndPoint = ClientConfig.CloudApiEndPointEULive
  };
var client = new Client(config);
```

To parse the terminal API notifications, please use the following custom deserializer. This method will throw an exception for non-notification requests.

~~~~ csharp
var serializer = new SaleToPoiMessageSerializer();
var saleToPoiRequest = serializer.DeserializeNotification(your_terminal_notification);
~~~~

## Example Cloud Terminal API integration
```c#
using System;
using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;
using Adyen.Service;
using Environment = Adyen.Model.Environment;
 
namespace Adyen.Terminal
{
   public static class Program
   {
        private static string XApiKey = "YOUR-API-KEY";
        private static void Main(string[] args)
        {
            var client = new Client(XApiKey, Environment.Test);
            TerminalCloudApi terminalCloudApi = new TerminalCloudApi(client);
            SaleToPOIResponse response = terminalCloudApi.TerminalRequestSync(PaymentRequest());
            PaymentResponse paymentResponse = (PaymentResponse) response.MessagePayload;
            Console.WriteLine(paymentResponse.Response.Result);
        }
 
        private static SaleToPOIRequest PaymentRequest()
        {
            var serviceID = "SERVICE_ID"; // ServiceId should be unique for every request
            var saleID = "SALE_ID";
            var POIID = "SERIAL_NUMBER";
            var transactionID = "123459";
            var saleToPOIRequest = new SaleToPOIRequest()
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
                            RequestedAmount = new decimal(10.9)
                        },
                    },
                }
            };
            return saleToPOIRequest;
        }
    }
}
```

## Using the Local Terminal API
The request and response payloads are identical to the Cloud Terminal API, however an additional encryption details object is required to send the requests.
```c#
var encryptionCredentialDetails = new EncryptionCredentialDetails
    {
        AdyenCryptoVersion = 1,
        KeyIdentifier = "CryptoKeyIdentifier12345",
        Password = "p@ssw0rd123456"
    };
var config = new Config
    {
        Environment = Model.Environment.Live,
        LocalTerminalApiEndpoint = @"https://_terminal_:8443/nexo/"
    };
var client = new Client(config);
var terminalLocalApi = new TerminalLocalApi(client);
var saleToPOIResponse = terminalLocalApi.TerminalRequest(paymentRequest, encryptionCredentialDetails);
```
Alternatively one can use the local terminal API without encryption. This is only allowed in the TEST environment and in order for this to work one has to remove any encryption details from the Customer Area.
```c#
var client = new Client(config);
var terminalLocalApiUnencrypted = new TerminalLocalApiUnencrypted(client);
var saleToPOIResponse = terminalLocalApiUnencrypted.TerminalRequest(paymentRequest);
```
To parse the terminal API notifications, please use the following custom deserializer. This method will throw an exception for non-notification requests.
```c#
var serializer = new SaleToPoiMessageSerializer();
var saleToPoiRequest = serializer.DeserializeNotification(your_terminal_notification);
```

## Parsing BalancePlatform and Management Webhooks
In order to parse banking webhooks, first validate the webhooks (recommended) by retrieving the hmac key from the webhook header and the hmac signature from the Balance Platform CA configuration page respectively.
```c#
using Adyen.Model.ConfigurationWebhooks;
using Adyen.Webhooks;
using Adyen.Util;

...
var hmacValidator = new HmacValidator();
var handler = new BalancePlatformWebhookHandler();
bool isValid = hmacValidator.IsValidWebhook("yourHmacKey", "yourHmacSignature", webhookPayload);

if (isValid) {
    dynamic webhook = handler.GetGenericBalancePlatformWebhook(webhookPayload);
}
```
If you want to handle specific webhook types you're expecting to receive, check the type and retrieve if the type is correct:
```c#
var handler = new BalancePlatformWebhookHandler();
bool isAccountHolderNotification = handler.GetAccountHolderNotificationRequest(json_payload, out AccountHolderNotificationRequest webhook)
// Your logic here based on whether the webhook parsed correctly or not
```
Validating management webhooks is identical to validating the balance platform webhooks. To parse the management webhooks, however, one calls the following handler:
```c#
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
Have a look at our [contributing guidelines](https://github.com/Adyen/adyen-dotnet-api-library/blob/develop/CONTRIBUTING.md) to find out how to raise a pull request.

## Support
If you have a feature request, or spotted a bug or a technical problem, [create an issue here](https://github.com/Adyen/adyen-dotnet-api-library/issues/new/choose).

For other questions, [contact our Support Team](https://www.adyen.help/hc/en-us/requests/new?ticket_form_id=360000705420).

## Licence
This repository is available under the [MIT license](https://github.com/Adyen/adyen-dotnet-api-library/blob/main/LICENSE).

## See also
* [Adyen docs](https://docs.adyen.com/)
* [API Explorer](https://docs.adyen.com/api-explorer/)
