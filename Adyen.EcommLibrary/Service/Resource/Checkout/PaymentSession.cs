using Adyen.EcommLibrary.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class PaymentSession : ServiceResource
    {
        public PaymentSession(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.ApiVersion + "/paymentSession", new List<string> { "merchantAccount", "reference", "amount", "returnUrl", "countryCode" })
        {
        }
    }
}
