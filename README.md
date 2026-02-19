![NET api](https://user-images.githubusercontent.com/16090523/211498272-75a50b61-b1cc-482e-9278-c10a267efe27.png)
# Adyen .NET API Library
[![nuget](https://img.shields.io/nuget/v/adyen.svg)](https://www.nuget.org/packages/adyen/) [![nuget](https://img.shields.io/nuget/dt/adyen.svg)](https://www.nuget.org/packages/adyen/) ![.NET Core](https://github.com/Adyen/adyen-dotnet-api-library/workflows/.NET%20Core/badge.svg)

This is the officially supported .NET library for the Adyen's APIs. Are you looking for examples? You can find our [.NET Integration examples on GitHub here](https://github.com/adyen-examples/adyen-dotnet-online-payments/).

## Supported API versions
The library supports all APIs under the following services:

| API                                                                                                                         | Description                                                                                                                                                                                                                                                                                          | Service Name                                                   | Supported version |
|-----------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------|-------------------|
| [Adyen BinLookup API](https://docs.adyen.com/api-explorer/BinLookup/54/overview)                                            | Endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN. Current supported version                                                                                                                                                        | [BinLookup](Adyen/BinLookup)                                   | **v54**           |
| [Balance Control API](https://docs.adyen.com/api-explorer/BalanceControl/1/overview)                                        | The Balance Control API lets you transfer funds between merchant accounts that belong to the same legal entity and are under the same company account.                                                                                                                                               | [BalanceControl](Adyen/BalanceControl)                         | **v1**            |
| [Capital API](https://docs.adyen.com/api-explorer/capital/1/overview)                                                      | Provides endpoints for embedding Adyen Capital into your marketplace or platform.                                      | [Capital](Adyen/Capital)                                       | **v1**            |
| [Checkout API](https://docs.adyen.com/api-explorer/Checkout/71/overview)                                                    | Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).                                     | [Checkout](Adyen/Checkout)                                     | **v71**           |
| [Configuration API](https://docs.adyen.com/api-explorer/balanceplatform/2/overview)                                         | The Configuration API enables you to create a platform where you can onboard your users as account holders and create balance accounts, cards, and business accounts.                                                                                                                                | [BalancePlatform](Adyen/BalancePlatform)                       | **v2**            |
| [Data Protection API](https://docs.adyen.com/development-resources/data-protection-api)                                     | Our Data Protection API allows you to process Subject Erasure Requests as mandated in General Data Protection Regulation (GDPR).                                                                                                                                                                     | [DataProtection](Adyen/DataProtection)                         | **v1**            |
| [Disputes API](https://docs.adyen.com/api-explorer/Disputes/30/overview)                                                    | You can use the [Disputes API](https://docs.adyen.com/risk-management/disputes-api) to automate the dispute handling process so that you can respond to disputes and chargebacks as soon as they are initiated. The Disputes API lets you retrieve defense reasons, supply and delete defense documents, and accept or defend disputes. | [Disputes](Adyen/Disputes)                                     | **v30**           |
| [Legal Entity Management API](https://docs.adyen.com/api-explorer/legalentity/4/overview)                                   | The Legal Entity Management API enables you to manage legal entities that contain information required for verification                                                                                                                                                                              | [LegalEntityManagement](Adyen/LegalEntityManagement)           | **v4**            |
| [Management API](https://docs.adyen.com/api-explorer/Management/3/overview)                                                 | Configure and manage your Adyen company and merchant accounts, stores, and payment terminals.                                                                                                                                                                                                        | [Management](Adyen/Management)                                 | **v3**            |
| [Payments API](https://docs.adyen.com/api-explorer/Payment/68/overview)                                                     | A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods.                                            | [Payments](Adyen/Payment)                                       | **v68**           |
| [Payments App API](https://docs.adyen.com/api-explorer/payments-app/1/overview)                                             | The Payments App API is used to Board and manage the Adyen Payments App on your Android mobile devices. | [PaymentsAppApi](Adyen/PaymentsApp)                            | **v1**            |
| [POS Mobile API](https://docs.adyen.com/api-explorer/possdk/68/overview)                                                    | The POS Mobile API is used in the mutual authentication flow between an Adyen Android or iOS [POS Mobile SDK](https://docs.adyen.com/point-of-sale/ipp-mobile/) and the Adyen payments platform. The POS Mobile SDK for Android or iOS devices enables businesses to accept in-person payments using a commercial off-the-shelf (COTS) device like a phone. For example, Tap to Pay transactions, or transactions on a mobile device in combination with a card reader | [POS Mobile](Adyen/PosMobile)                                  | **v68**           |
| [Payouts API](https://docs.adyen.com/api-explorer/Payout/68/overview)                                                       | A set of API endpoints that allow you to store payout details, confirm, or decline a payout.                                                                                                                                                                                                         | [Payout](Adyen/Payout)                                         | **v68**           |
| [Recurring API](https://docs.adyen.com/api-explorer/Recurring/68/overview)                                                  | The Recurring APIs allow you to manage and remove your tokens or saved payment details. Tokens should be created with validation during a payment request.                                                                                                                                           | [Recurring](Adyen/Recurring)                                   | **v68**           |
| [Session Authentication API](https://docs.adyen.com/api-explorer/sessionauthentication/1/overview)                          | Create and manage the JSON Web Tokens (JWT) required for integrating [Onboarding](https://docs.adyen.com/platforms/onboard-users/components) and [Platform Experience](https://docs.adyen.com/platforms/build-user-dashboards) components.    | [SessionAuthentication](Adyen/SessionAuthentication)           | **v1**            |
| [Stored Value API](https://docs.adyen.com/payment-methods/gift-cards/stored-value-api)                                      | Manage both online and point-of-sale gift cards and other stored-value cards.                                                                                                                                                                                                                        | [StoredValue](Adyen/StoredValue)                               | **v46**           |
| [Terminal API (Cloud communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/cloud)                  | Our point-of-sale integration.                                                                                                                                                                                                                                                                       | [Cloud-based Terminal API](Adyen/TerminalApi/Services)         | **v1**            |      |
| [Terminal API (Local communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/local)                  | Our point-of-sale integration.                                                                                                                                                                                                                                                                       | [Local-based Terminal API](Adyen/TerminalApi/Services) | **v1**            |      |
| [Transfers API](https://docs.adyen.com/api-explorer/transfers/4/overview)                                                   | The Transfers API provides endpoints that you can use to get information about all your transactions, move funds within your balance platform or send funds from your balance platform to a transfer instrument.                                                                                     | [Transfers](Adyen/Transfers)                                   | **v4**            |

## Supported Webhook versions
The library supports all webhooks under the following model directories:

| Webhooks                                                                                          | Description                                                                                                                                                                                                                      | Model Name                                                                    | Supported Version |
|---------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------|-------------------|
| [Authentication Webhooks](https://docs.adyen.com/api-explorer/Checkout/latest/overview)           | You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).                                                                  | [AcsWebhooks](Adyen/AcsWebhooks/Models)                                       | **v1**            |
| [Balance Webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/1/overview)               | Adyen sends webhooks to inform you of balance changes in your balance platform.                                                                                                                   | [BalanceWebhooks](Adyen/BalanceWebhooks/Models)                               | **v1**            |
| [Configuration Webhooks](https://docs.adyen.com/api-explorer/balanceplatform-webhooks/2/overview) | You can use these webhooks to build your implementation. For example, you can use this information to update internal statuses when the status of a capability is changed.                                                       | [ConfigurationWebhooks](Adyen/ConfigurationWebhooks/Models)                   | **v2**            |
| [Management Webhooks](https://docs.adyen.com/api-explorer/ManagementNotification/3/overview)      | Adyen uses webhooks to inform your system about events that happen with your Adyen company and merchant accounts, stores, payment terminals, and payment methods when using Management API.                                      | [ManagementWebhooks](Adyen/ManagementWebhooks/Models)                         | **v3**            |
| [Negative Balance Warning Webhooks](https://docs.adyen.com/api-explorer/Webhooks/1/overview)      | Adyen sends this webhook to inform you about a balance account whose balance has been negative for a given number of days.                                                                                                       | [NegativeBalanceWarningWebhooks](Adyen/NegativeBalanceWarningWebhooks/Models) | **v1**            |
| [Notification Webhooks](https://docs.adyen.com/api-explorer/Webhooks/1/overview)                  | We use webhooks to send you updates about payment status updates, newly available reports, and other events that you can subscribe to. For more information, refer to our documentation                                          | [Notification](Adyen/Webhooks/Models)                                         | **v1**            |
| [Relayed Authorization Webhooks](https://docs.adyen.com/api-explorer/relayed-authorisation-webhooks/4/overview)  | Adyen sends webhooks to inform your system about events related to transaction authorizations.                                                                                                    | [RelayedAuthorizationWebhooks](Adyen/RelayedAuthorizationWebhooks/Models)     | **v4**            |
| [Report Webhooks](https://docs.adyen.com/api-explorer/report-webhooks/1/overview)                 | You can download reports programmatically by making an HTTP GET request, or manually from your Balance Platform Customer Area                                                                                                    | [ReportWebhooks](Adyen/ReportWebhooks/Models)                                 | **v1**            |
| [Tokenization Webhooks](https://docs.adyen.com/api-explorer/Tokenization-webhooks/1/overview)     | Adyen sends webhooks to inform you about the creation and changes to the recurring tokens.                                                                                                        | [TokenizationWebhooks](Adyen/TokenizationWebhooks/Models)                     | **v1**            |
| [Transaction Webhooks](https://docs.adyen.com/api-explorer/transaction-webhooks/4/overview)       | Adyen sends webhooks to inform your system about incoming and outgoing transfers in your platform. You can use these webhooks to build your implementation. For example, you can use this information to update balances in your own dashboards or to keep track of incoming funds. | [TransactionWebhooks](Adyen/TransactionWebhooks/Models)                       | **v4**            |
| [Transfer Webhooks](https://docs.adyen.com/api-explorer/transfer-webhooks/4/overview)             | You can use these webhooks to build your implementation. For example, you can use this information to update balances in your own dashboards or to keep track of incoming funds.                                                 | [TransferWebhooks](Adyen/TransferWebhooks/Models)                             | **v4**            |

For more information, refer to our [documentation](https://docs.adyen.com/) or the [API Explorer](https://docs.adyen.com/api-explorer/).

## Prerequisites
- [Adyen Test Account](https://docs.adyen.com/get-started-with-adyen)
- [Adyen API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). For testing, your API credential needs to have the [API PCI Payments role](https://docs.adyen.com/development-resources/api-credentials#roles).
- Adyen .NET API Library supports .NET Standard 2.0 and .NET 8.0  

## Installation
Simply download and restore nuget packages https://www.nuget.org/packages/Adyen/
or install it from package manager
```
PM> Install-Package Adyen -Version x.x.x
```
## Using the library

In order to submit http request to Adyen API you need to initialize the client. The following example makes a checkout payment request:
```csharp
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Adyen.Core.Extensions;
using Adyen.Checkout.Extensions;
using AdyenEnvironment = Adyen.Core.Model.Environment;

IHost host = Host.CreateDefaultBuilder()
          .ConfigureCheckout(
              (context, services, config) =>
              {
                  config.ConfigureAdyenOptions(options =>
                  {
                      options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                      options.Environment = AdyenEnvironment.Test;
                  });

                  services.AddPaymentsService();
              })
          .Build();

var paymentsService = host.Services.GetRequiredService<IPaymentsService>();

var request = new PaymentRequest(
    amount: new Amount("EUR", 1999),
    merchantAccount: "MY_MERCHANT_ACCOUNT",
    reference: "reference",
    returnUrl: "https://adyen.com/",
    paymentMethod: new CheckoutPaymentMethod(
        new CardDetails(
            type: CardDetails.TypeEnum.Scheme,
            encryptedCardNumber: "test_4111111111111111",
            encryptedExpiryMonth: "test_03",
            encryptedExpiryYear: "test_2030",
            encryptedSecurityCode: "test_737",
            holderName: "John Smith"
            )
        )
    );

var response = await paymentsService.PaymentsAsync(request);
if (response.TryDeserializeOkResponse(out var result);
{
    Console.WriteLine(result); // result.ResultCode 
}
```
Use the `RequestOptions` object to pass additional headers like the IdempotencyKey or other custom request header:
```csharp
var response = await paymentsService.PaymentsAsync(request, new RequestOptions().AddIdempotencyKey(Guid.NewGuid().ToString()));
```
### Deserializing JSON Strings
In some setups you might need to deserialize JSON strings to request objects. For example, when using the libraries in combination with [Dropin/Components](https://github.com/Adyen/adyen-web). Please use the built-in deserialization functions:
First, build the host and get the `JsonSerializerOptionsProvider` from the service container.
~~~~ csharp
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.Checkout.Models;

IHost host = Host.CreateDefaultBuilder()
          .ConfigureCheckout(
              (context, services, config) =>
              {
                  config.ConfigureAdyenOptions(options =>
                  {
                      options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                      options.Environment = AdyenEnvironment.Test;
                  });
              })
          .Build();

// Deserialize using built-in function
PaymentRequest paymentRequest = JsonSerializer.Deserialize<PaymentRequest>("YOUR_JSON_STRING", jsonSerializerOptionsProvider.Options);
~~~~
### Logging response bodies
Here's an example how you can log API responses using `{{classname}}Events`. Consider logging responses **only on TEST** to prevent logging confidential data. 

In case of `Payments` the snippet would be:
~~~~ c#
var events = new PaymentsEvents;
services.AddSingleton(events);

// Create a new logger

events.OnPayments += (sender, eventArgs) =>
{
    ApiResponse apiResponse = eventArgs.ApiResponse;
    logger.LogInformation("{TotalSeconds,-9} | {Path} | {StatusCode} |", (apiResponse.DownloadedAt - apiResponse.RequestedAt).TotalSeconds, apiResponse.Path, apiResponse.StatusCode);
};
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

### Parsing webhooks
In order to parse webhooks, first validate the webhooks (recommended) by retrieving the hmac key from the webhook header.
Please use the built-in webhook handlers:
```csharp
using Adyen.AcsWebhooks.Models;
using Adyen.AcsWebhooks.Handlers;
using Adyen.AcsWebhooks.Extensions;
using Adyen.Core.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AdyenEnvironment = Adyen.Core.Model.Environment;

// Setup the host to configure the AcsWebhooks handler with HMAC key
IHost host = Host.CreateDefaultBuilder()
    .ConfigureAcsWebhooks(
        (context, services, config) =>
        {
            config.ConfigureAdyenOptions(options =>
            {
                options.AdyenHmacKey = context.Configuration["ADYEN_HMAC_KEY"]; 
            });
            services.AddAcsWebhooksHandler();
        })
    .Build();

// Retrieve the handler and validate the signature
var handler = host.Services.GetRequiredService<IAcsWebhooksHandler>();
bool isValid = handler.IsValidHmacSignature(webhookPayload, "hmacSignature from header");

if (isValid) {
    AuthenticationNotificationRequest r = handler.DeserializeAuthenticationNotificationRequest(webhookPayload);
    // Your logic here based on the deserialized webhook
}
```
Validating management webhooks is identical to validating the balance platform webhooks. To parse the management webhooks, however, one calls the following handler:
```csharp
using Adyen.ManagementWebhooks.Extensions;
using Adyen.ManagementWebhooks.Models;
using Adyen.ManagementWebhooks.Handlers;

IHost host = Host.CreateDefaultBuilder()
          .ConfigureManagementWebhooks(
              (context, services, config) =>
              {
                  config.ConfigureAdyenOptions(options =>
                  {
                      options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                      options.Environment = AdyenEnvironment.Test;
                  });
              })
          .Build();
          
var handler = host.Services.GetRequiredService<IManagementWebhooksHandler>();
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
