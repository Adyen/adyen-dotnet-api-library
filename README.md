[![Build Status](https://travis-ci.org/Adyen/adyen-dotnet-api-library.svg?branch=develop)](https://travis-ci.org/Adyen/adyen-dotnet-api-library)


# Adyen .net API Library

The Adyen API Library for .net framework enables you to work with Adyen APIs, Hosted Payment Pages and Terminal API with any .net application.


## Integration
The Library supports all APIs under the following services:

* [x] bin lookup
* [x] checkout
* [x] checkout utility
* [x] payments
* [x] payout
* [x] modifications
* [x] recurring
* [x] notifications
* [x] Terminal API (Local and Cloud based)

## Requirements

* Adyen API Library supports .net standard 2.0
* In order for Adyen API Library to support local terminal api certificate validation the application should be set to .net core 2.1 and above or .net framework 4.6.1 and above
## Installation

* Simply download and restore nuget packages  
 https://www.nuget.org/packages/Adyen/
* or install it from package manager
 PM> Install-Package Adyen -Version 3.4.0

## Documentation
* https://docs.adyen.com/developers/development-resources/libraries
* https://docs.adyen.com/developers/checkout/api-integration

## HTTP Client Configuration

In order to submit http requests to adyen api you need to initialize the client. The following example makes a checkout payment request:

```csharp
var client = new Client("YOUR-XAPI-KEY", Model.Enum.Environment.Test); //or Model.Enum.Environment.Live
var checkout = new Checkout(client);
var paymentsResponse = checkout.Payments(paymentsRequest);
```

## Support
If you have any problems, questions or suggestions, create an issue here or send your inquiry to support@adyen.com.

## Contributing
We strongly encourage you to join us in contributing to this repository so everyone can benefit from:
* New features and functionality
* Resolved bug fixes and issues
* Any general improvements

Read our [**contribution guidelines**](CONTRIBUTING.md) to find out how.

## Licence
MIT license. For more information, see the LICENSE file.
