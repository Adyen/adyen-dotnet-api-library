using Adyen.EcommLibrary.Constants;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class PaymentsResult : ServiceResource
    {
        public PaymentsResult(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion +
                "/payments/result", new List<string> {"payload"})
        {
        }
    }
}