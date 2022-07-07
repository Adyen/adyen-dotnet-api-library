# Adyen dotnet API Library
[![nuget](https://img.shields.io/nuget/v/adyen.svg)](https://www.nuget.org/packages/adyen/) [![nuget](https://img.shields.io/nuget/dt/adyen.svg)](https://www.nuget.org/packages/adyen/) ![.NET Core](https://github.com/Adyen/adyen-dotnet-api-library/workflows/.NET%20Core/badge.svg)

This is the officially supported dotnet library for using Adyen's APIs.

## Integration
The library supports all APIs under the following services:

* [Checkout API](https://docs.adyen.com/api-explorer/#/CheckoutService/v68/overview): Our latest integration for accepting online payments. Current supported version: **v69**
* [Payments API](https://docs.adyen.com/api-explorer/#/Payment/v51/overview): Our classic integration for online payments. Current supported version: **v51**
* [Recurring API](https://docs.adyen.com/api-explorer/#/Recurring/v49/overview): Endpoints for managing saved payment details. Current supported version: **v49**
* [Payouts API](https://docs.adyen.com/api-explorer/#/Payout/v51/overview): Endpoints for sending funds to your customers. Current supported version: **v51**
* [Adyen BinLookup API](https://docs.adyen.com/api-explorer/#/BinLookup/v50/overview): Endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN. Current supported version: **v50**
* [Utility API](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/originKeys): This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. Current supported version: **v67**
* [Platforms APIs](https://docs.adyen.com/platforms/api): Set of APIs when using Adyen for Platforms.
  * [Hosted Onboarding API](https://docs.adyen.com/api-explorer/#/Hop/v1/overview) Current supported version: **v1**
  * [Account API](https://docs.adyen.com/api-explorer/#/Account/v5/overview) Current supported version: **v5**
  * [Fund API](https://docs.adyen.com/api-explorer/#/Fund/v5/overview) Current supported version: **v5**
* [Cloud-based Terminal API](https://docs.adyen.com/point-of-sale/choose-your-architecture/cloud): Our point-of-sale integration.
* [Local-based Terminal API](https://docs.adyen.com/point-of-sale/choose-your-architecture/local): Our point-of-sale integration.
* [POS Terminal Management API](https://docs.adyen.com/api-explorer/#/postfmapi/v1/overview): Endpoints for managing your point-of-sale payment terminals **v1**

For more information, refer to our [documentation](https://docs.adyen.com/) or the [API Explorer](https://docs.adyen.com/api-explorer/).


## Prerequisites

- [Adyen test account](https://docs.adyen.com/get-started-with-adyen)
- [API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). For testing, your API credential needs to have the [API PCI Payments role](https://docs.adyen.com/development-resources/api-credentials#roles).
- Adyen dotnet API Library supports .net standard 2.0
- In order for Adyen dotnet API Library to support local terminal api certificate validation the application should be set to .net core 2.1 and above or .net framework 4.6.1 and above

## Installation
Simply download and restore nuget packages https://www.nuget.org/packages/Adyen/
or install it from package manager
~~~~ bash
PM> Install-Package Adyen -Version x.x.x
~~~~

## Using the library

### General use with API key

In order to submit http request to Adyen API you need to initialize the client. The following example makes a checkout payment request:
~~~~ csharp
// Create a paymentsRequest
var amount = new Model.Checkout.Amount("USD", 1000);
var paymentRequest = new Model.Checkout.PaymentRequest
{
      Reference = "Your order number",
      Amount = amount,
      ReturnUrl = @"https://your-company.com/...",
      MerchantAccount = ClientConstants.MerchantAccount,
};
paymentRequest.AddCardData("4111111111111111", "10", "2020", "737", "John Smith");

//Create the http client
var client = new Client("YOUR-XAPI-KEY", Model.Enum.Environment.Test);//or Model.Enum.Environment.Live
var checkout = new Checkout(client);
//Make the call to the service. This example code makes a call to /payments
var paymentResponse = checkout.Payments(paymentRequest);
~~~~

### Example integration

For a closer look at how our dotnet library works, clone our [ASP .net example integration](https://github.com/adyen-examples/adyen-dotnet-online-payments). This includes commented code, highlighting key features and concepts, and examples of API calls that can be made using the library.

### Running the tests
Navigate to adyen-dotnet-api-library folder and run the following commands.
~~~~ bash
dotnet build
dotnet test
~~~~

### Using the Cloud API for post
In order to submit POS request with Cloud API you need to initialize the client with the Endpoints that it is closer to your region. The Endpoints are available as contacts in [ClientConfig](https://github.com/Adyen/adyen-dotnet-api-library/blob/develop/Adyen/Constants/ClientConfig.cs#L35)
For more information please read our [documentation](https://docs.adyen.com/point-of-sale/terminal-api-fundamentals#cloud)
~~~~ csharp
//Example for EU based Endpoint Syncronous
var config = new Config
  {
    XApiKey = "Your merchant XAPI key",
    CloudApiEndPoint = ClientConfig.CloudApiEndPointEULive
  };
var client = new Client(config);
~~~~
### Using the Local communication for point of sale

The `Certificate` class in `Adyen.Util` provides a way to pass the certificate using the path rather than to install it on you local machine CA store. This works for unix based systems and Windows. For Windows you could simple install the certificate without having to create a new CA store for Adyen's certificate. For more information please check the [docs](https://docs.adyen.com/point-of-sale/choose-your-architecture/local#protect-communications). By default the `StoreName` is `Root` and the `StoreLocation` is `CurrentUser`
~~~~ csharp
// Example code. 
Certificate.AddCertificateFromPath(@"../adyen-terminalfleet-test.cer");
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
* [Example integration](https://github.com/adyen-examples/adyen-dotnet-online-payments)
* [Adyen docs](https://docs.adyen.com/)
* [API Explorer](https://docs.adyen.com/api-explorer/)
