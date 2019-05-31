using Adyen.EcommLibrary.Constants;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class PaymentSession : ServiceResource
    {
        public PaymentSession(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion +
                "/paymentSession",
                new List<string> {"merchantAccount", "reference", "amount", "returnUrl", "countryCode"})
        {
        }
    }
}