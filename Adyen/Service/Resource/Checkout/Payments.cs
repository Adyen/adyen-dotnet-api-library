using System;
using System.Collections.Generic;
using System.Text;
using Adyen.Constants;

namespace Adyen.Service.Resource.Checkout
{
    public class Payments : ServiceResource
    {
        public Payments(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/payments", new List<string> { "merchantAccount", "reference", "amount", "returnUrl", "paymentMethod" })
        {
        }
    }
}
