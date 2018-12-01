using System.Collections.Generic;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class PaymentMethods : Resource
    {
        public PaymentMethods(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + "/paymentMethods", new List<string> { "MerchantAccount" })
        {
        }
    }
}
