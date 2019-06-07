using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Service.Resource.Checkout
{
    public class PaymentsResult : ServiceResource
    {
        public PaymentsResult(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/payments/result", new List<string> { "payload" })
        {
        }
    }
}
