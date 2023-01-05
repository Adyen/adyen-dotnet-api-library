using Adyen.Constants;

namespace Adyen.Service.Resource.Checkout
{
    public class CheckoutResource : ServiceResource
    {
        public CheckoutResource(AbstractService abstractService, string endpoint)
            : base(abstractService,
                abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion + endpoint, null)
        {
        }
    }
}