using Adyen.EcommLibrary.Model;
using Adyen.EcommLibrary.Model.AdditinalData;
using Adyen.EcommLibrary.Model.Enum;
using System;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Test
{
    internal class OpenInvoiceHelper
    {
        public static PaymentRequest CreateOpenInvoicePaymentRequest()
        {
            PaymentRequest paymentRequest = new PaymentRequest
            {
                Reference = "123456",
                Amount = new Amount("EUR", Int64.Parse("200")),
                ShopperName = CreateShopperName(),
                ShopperEmail = "youremail@email.com",
                TelephoneNumber = "0612345678",
                ShopperReference = "4",
                SelectedBrand = "klarna",
                DeliveryAddress = CreateAddress(),
                BillingAddress = CreateAddress()
            };
            // Set Shopper Info
            // Set Shopper Data
            // paymentRequest.setDateOfBirth(dateOfBirth);
           
            long itemAmount = Int64.Parse("9000");
            long itemVatAmount = Int64.Parse("1000");
            long itemVatPercentage = Int64.Parse("1000");

            List<InvoiceLine> invoiceLines = new List<InvoiceLine>();

            // invoiceLine1
            InvoiceLine invoiceLine = new InvoiceLine
            {
                CurrencyCode = "EUR",
                Description = "Test product",
                ItemAmount = itemAmount,
                ItemVatPercentage = itemVatPercentage,
                VatCategory = VatCategory.None,
                NumberOfItems = 1,
                ItemId = "1234"
            };

            // invoiceLine2
            InvoiceLine invoiceLine2 = new InvoiceLine
            {
                CurrencyCode = "EUR",
                Description = "Test product 2",
                ItemAmount = itemAmount,
                ItemVatPercentage = itemVatPercentage,
                VatCategory = VatCategory.None,
                NumberOfItems = 1,
                ItemId = "4567"
            };
            
            invoiceLines.Add(invoiceLine);
            invoiceLines.Add(invoiceLine2);
            paymentRequest.InvoiceLines = invoiceLines;

            return paymentRequest;
        }

        private static Address CreateAddress()
        {
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
            return address;
        }

        private static Name CreateShopperName()
        {
            Name shopperName = new Name
            {
                FirstName = "Testperson-nl",
                LastName = "Approved",
                Gender = GenderEnum.MALE
            };
            return shopperName;
        }
    }
}
