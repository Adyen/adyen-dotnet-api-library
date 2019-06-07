using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Service.Resource.Checkout
{
    public class PaymentSession : ServiceResource
    {
        public PaymentSession(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/paymentSession", new List<string> { "merchantAccount", "reference", "amount", "returnUrl", "countryCode" })
        {
        }
    }
}
