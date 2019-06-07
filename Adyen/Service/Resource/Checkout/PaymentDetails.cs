using System;
using System.Collections.Generic;
using System.Text;
using Adyen.Constants;

namespace Adyen.Service.Resource.Checkout
{
    public class PaymentDetails : ServiceResource
    {
        public PaymentDetails(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/payments/details", new List<string> {"paymentData", "details" })
        {
        }
    }
}
