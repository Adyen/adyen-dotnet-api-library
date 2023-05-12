using System;
using System.Collections.Generic;
using Adyen.Model.Payment;

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
                LastName = "Approved"
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

            List<AdditionalDataOpenInvoice> invoiceLines = new List<AdditionalDataOpenInvoice>();

            // invoiceLine1
            AdditionalDataOpenInvoice invoiceLine = new AdditionalDataOpenInvoice
            {
                OpeninvoicedataLineItemNrCurrencyCode = ("EUR"),
                OpeninvoicedataLineItemNrDescription = ("Test product"),
                OpeninvoicedataLineItemNrItemVatAmount = ("1000"),
                OpeninvoicedataLineItemNrItemAmount = (itemAmount).ToString(),
                OpeninvoicedataLineItemNrItemVatPercentage = (itemVatPercentage).ToString(),
                OpeninvoicedataLineItemNrNumberOfItems = (1).ToString(),
                OpeninvoicedataLineItemNrItemId = ("1234")
            };

            // invoiceLine2
            // invoiceLine1
            AdditionalDataOpenInvoice invoiceLine2 = new AdditionalDataOpenInvoice
            {
                OpeninvoicedataLineItemNrCurrencyCode = ("EUR"),
                OpeninvoicedataLineItemNrDescription = ("Test product2"),
                OpeninvoicedataLineItemNrItemVatAmount = (itemVatAmount).ToString(),
                OpeninvoicedataLineItemNrItemAmount = (itemAmount).ToString(),
                OpeninvoicedataLineItemNrItemVatPercentage = (itemVatPercentage).ToString(),
                OpeninvoicedataLineItemNrNumberOfItems = (1).ToString(),
                OpeninvoicedataLineItemNrItemId = ("456")
            };
            
            invoiceLines.Add(invoiceLine);
            invoiceLines.Add(invoiceLine2);
            
            /*paymentRequest.AdditionalData(invoiceLines);*/

            return paymentRequest;
        }

    }
}
