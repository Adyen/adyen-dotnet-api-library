![NET api](https://user-images.githubusercontent.com/16090523/211498272-75a50b61-b1cc-482e-9278-c10a267efe27.png)
# Adyen .NET API Library
[![nuget](https://img.shields.io/nuget/v/adyen.svg)](https://www.nuget.org/packages/adyen/) [![nuget](https://img.shields.io/nuget/dt/adyen.svg)](https://www.nuget.org/packages/adyen/) ![.NET Core](https://github.com/Adyen/adyen-dotnet-api-library/workflows/.NET%20Core/badge.svg)

This is the officially supported .NET library for using Adyen's APIs.
## Supported API versions
The library supports all APIs under the following services:

| API                                                                                         | Description | Service Name | Supported version |
|---------------------------------------------------------------------------------------------| ----------- |-------|--------|
| [Checkout API](https://docs.adyen.com/api-explorer/#/CheckoutService/v68/overview)          | Our latest integration for accepting online payments. Current supported version | Checkout API | **v69** |
| [Payments API](https://docs.adyen.com/api-explorer/#/Payment/v51/overview)                  | Our classic integration for online payments. Current supported version | Payments API | **v51** |
| [Recurring API](https://docs.adyen.com/api-explorer/#/Recurring/v49/overview)               | Endpoints for managing saved payment details. Current supported version| Recurring API | **v49** |
| [Payouts API](https://docs.adyen.com/api-explorer/#/Payout/v51/overview)                    | Endpoints for sending funds to your customers. Current supported version| Payouts API | **v51** |
| [Adyen BinLookup API](https://docs.adyen.com/api-explorer/#/BinLookup/v52/overview)         | Endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN. Current supported version |Adyen BinLookup API| **v52**|
| [Utility API](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/originKeys)    | This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. Current supported version|Utility API| **v67**|
| [Hosted Onboarding API](https://docs.adyen.com/api-explorer/#/Hop/v1/overview)              | Current supported version | Hosted Onboarding API | **v1** |
| [Account API](https://docs.adyen.com/api-explorer/#/Account/v5/overview)                    | Current supported version | Account API | **v5** |
| [Fund API](https://docs.adyen.com/api-explorer/#/Fund/v5/overview)                          | Current supported version|   Fund API  | **v5** |
| [Terminal API (Cloud communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/cloud) | Our point-of-sale integration.| Cloud-based Terminal API | Cloud-based Terminal API       |      |
| [Terminal API (Local communications)](https://docs.adyen.com/point-of-sale/choose-your-architecture/local) | Our point-of-sale integration.| Local-based Terminal API |   Local-based Terminal API     |      |
| [POS Terminal Management API](https://docs.adyen.com/api-explorer/#/postfmapi/v1/overview)  | Endpoints for managing your point-of-sale payment terminals| POS Terminal Management API | **v1** |


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

// Create a paymentsRequest
using Adyen;
using Adyen.Model.Checkout;
using Adyen.Service;
using Environment = Adyen.Model.Enum.Environment;

// Create a paymentsRequest
var amount = new Amount("USD", 1000);
var paymentRequest = new PaymentRequest
{
    Reference = "Your order number",
    Amount = amount,
    ReturnUrl = @"https://your-company.com/...",
    MerchantAccount = "Your merchantAccount",
};

//Create the http client
var config = new Config
{
    XApiKey = "Your merchant XAPI key",
    Environment = Environment.Test
};
var client = new Client(config);
var checkout = new Checkout(client);
//Make the call to the service. This example code makes a call to /payments
var paymentResponse = checkout.Payments(paymentRequest);
```

## Running the tests
Navigate to adyen-dotnet-api-library folder and run the following commands.
```
dotnet build
dotnet test
```
## Using the Cloud API 
In order to submit POS request with Cloud API you need to initialize the client with the Endpoints that it is closer to your region. The Endpoints are available as contacts in [ClientConfig](https://github.com/Adyen/adyen-dotnet-api-library/blob/develop/Adyen/Constants/ClientConfig.cs#L35)
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

## Example cloud API integration
```c#
using System;
using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;
using Adyen.Service;
using Environment = Adyen.Model.Enum.Environment;
 
namespace Adyen.Terminal
{
   public static class Program
   {
        private static string XApiKey = "YOUR-API-KEY";
        private static void Main(string[] args)
        {
            var client = new Client(XApiKey, Environment.Test);
            PosPaymentCloudApi posPaymentCloudApi = new PosPaymentCloudApi(client);
            SaleToPOIResponse response = posPaymentCloudApi.TerminalApiCloudSync(PaymentRequest());
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

To parse the terminal API notifications, please use the following custom deserializer. This method will throw an exception for non-notification requests.
~~~~ csharp
var serializer = new SaleToPoiMessageSerializer();
var saleToPoiRequest = serializer.DeserializeNotification(your_terminal_notification);

~~~~
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
