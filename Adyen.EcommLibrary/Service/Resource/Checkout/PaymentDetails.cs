using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class PaymentDetails : Resource
    {
        public PaymentDetails(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/payments/details", new List<string> {"paymentData", "details" })
        {
        }
    }
}
