#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model;
using Adyen.Model.AdditionalData;
using Adyen.Model.Enum;
using System;
using System.Collections.Generic;

namespace Adyen.Test
{
    public class MockOpenInvoicePayment
    {
        public static PaymentRequest CreateOpenInvoicePaymentRequest()
        {

            DateTime dateOfBirth = DateTime.Parse("1970-07-10");

            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequest();

            // Set Shopper Data
            paymentRequest.ShopperEmail = "youremail@email.com";
            paymentRequest.DateOfBirth = dateOfBirth;
            paymentRequest.TelephoneNumber = "0612345678";
            paymentRequest.ShopperReference = "4";

            // Set Shopper Info
            Name shopperName = new Name
            {
                FirstName = "Testperson-nl",
                LastName = "Approved",
                Gender = GenderEnum.MALE
            };
            paymentRequest.ShopperName = shopperName;

            // Set Billing and Delivery address
            Address address = new Address
            {
                City = "Gravenhage",
                Country = "NL",
                HouseNumberOrName = "1",
                PostalCode = "2521VA",
                StateOrProvince = "Zuid-Holland",
                Street = "Neherkade"
            };
            paymentRequest.DeliveryAddress = address;
            paymentRequest.BillingAddress = address;

            // Use OpenInvoice Provider (klarna, ratepay)
            paymentRequest.SelectedBrand = "klarna";

            long itemAmount = long.Parse("9000");
            long itemVatAmount = long.Parse("1000");
            long itemVatPercentage = long.Parse("1000");

            List<InvoiceLine> invoiceLines = new List<InvoiceLine>();

            // invoiceLine1
            InvoiceLine invoiceLine = new InvoiceLine
            {
                CurrencyCode = ("EUR"),
                Description = ("Test product"),
                VatAmount = (itemVatAmount),
                ItemAmount = (itemAmount),
                ItemVatPercentage = (itemVatPercentage),
                VatCategory = (VatCategory.None),
                NumberOfItems = (1),
                ItemId = ("1234")
            };

            // invoiceLine2
            // invoiceLine1
            InvoiceLine invoiceLine2 = new InvoiceLine
            {
                CurrencyCode = ("EUR"),
                Description = ("Test product2"),
                VatAmount = (itemVatAmount),
                ItemAmount = (itemAmount),
                ItemVatPercentage = (itemVatPercentage),
                VatCategory = (VatCategory.None),
                NumberOfItems = (1),
                ItemId = ("456")
            };
            
            invoiceLines.Add(invoiceLine);
            invoiceLines.Add(invoiceLine2);

            paymentRequest.InvoiceLines(invoiceLines);

            return paymentRequest;
        }

    }
}
