using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class Payments : Resource
    {
        public Payments(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/payments", new List<string> { "merchantAccount", "reference", "amount", "returnUrl", "paymentMethod" })
        {
        }
    }
}
