using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class Payments : ServiceResource
    {
        public Payments(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.ApiVersion + "/payments", new List<string> { "merchantAccount", "reference", "amount", "returnUrl", "paymentMethod" })
        {
        }
    }
}
