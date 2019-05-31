using System.Collections.Generic;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Service.Resource.Checkout
{
    public class PaymentDetails : ServiceResource
    {
        public PaymentDetails(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion +
                "/payments/details", new List<string> {"paymentData", "details"})
        {
        }
    }
}