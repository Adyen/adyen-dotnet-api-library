# Adyen dotnet API Library
[![Build Status](https://travis-ci.org/Adyen/adyen-dotnet-api-library.svg?branch=develop)](https://travis-ci.org/Adyen/adyen-dotnet-api-library) [![nuget](https://img.shields.io/nuget/v/adyen.svg)](https://www.nuget.org/packages/adyen/) [![nuget](https://img.shields.io/nuget/dt/adyen.svg)](https://www.nuget.org/packages/adyen/)

The Adyen API Library for .net framework enables you to work with Adyen APIs, Hosted Payment Pages and Terminal API with any .net application.

The Library supports all APIs under the following services:
* [x] bin lookup
* [x] checkout
* [x] checkout utility
* [x] payments
* [x] payout
* [x] modifications
* [x] recurring
* [x] notifications
* [x] marketpay account
* [x] marketpay fund
* [x] Terminal API (Local and Cloud based)

## Requirements
* Adyen API Library supports .net standard 2.0
* In order for Adyen API Library to support local terminal api certificate validation the application should be set to .net core 2.1 and above or .net framework 4.6.1 and above

## Installation
* Simply download and restore nuget packages  
 https://www.nuget.org/packages/Adyen/
* or install it from package manager
 PM> Install-Package Adyen -Version 5.3.0

## Usage
In order to submit http request to Adyen API you need to initialize the client. The following example makes a checkout payment request:
```csharp
// Create a paymentsRequest
var amount = new Model.Checkout.Amount("USD", 1000);
var paymentsRequest = new Model.Checkout.PaymentRequest
{
      Reference = "Your order number",
      Amount = amount,
      ReturnUrl = @"https://your-company.com/...",
      MerchantAccount = ClientConstants.MerchantAccount,
};
paymentsRequest.AddCardData("4111111111111111", "10", "2020", "737", "John Smith");

//Create the http client
var client = new Client("YOUR-XAPI-KEY", Model.Enum.Environment.Test);//or Model.Enum.Environment.Live
var checkout = new Checkout(client);
//Make the call to the service. This example code makes a call to /payments
var paymentsResponse = checkout.Payments(paymentsRequest);
```

## Documentation
* https://docs.adyen.com/developers/development-resources/libraries
* https://docs.adyen.com/developers/checkout

## Contributing
We strongly encourage you to join us in contributing to this repository so everyone can benefit from:
* New features and functionality
* Resolved bug fixes and issues
* Any general improvements

Read our [**contribution guidelines**](CONTRIBUTING.md) to find out how.

## Suppor
If you have a feature request, or spotted a bug or a technical problem, create a GitHub issue. For other questions, contact our [support team](https://support.adyen.com/hc/en-us/requests/new?ticket_form_id=360000705420).

## Licence
MIT license. For more information, see the LICENSE file.
