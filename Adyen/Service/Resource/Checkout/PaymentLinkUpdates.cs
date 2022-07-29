using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Checkout
{
    public class PaymentLinkUpdates : ServiceResource
    {
        public PaymentLinkUpdates(AbstractService abstractService, string linkId) :
            base(abstractService,
                abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + $"/paymentLinks/{linkId}",
                new List<string> {"linkId"})
        {
        }
    }
}