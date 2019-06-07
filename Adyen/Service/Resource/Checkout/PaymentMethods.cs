using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Checkout
{
    public class PaymentMethods : ServiceResource
    {
        public PaymentMethods(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/paymentMethods", new List<string> { "MerchantAccount" })
        {
        }
    }
}
