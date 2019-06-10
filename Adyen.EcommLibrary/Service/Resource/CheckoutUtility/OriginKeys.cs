using Adyen.EcommLibrary.Constants;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.CheckoutUtility
{
    public class OriginKeys : ServiceResource
    {
        public OriginKeys(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutUtilityApiVersion +
                "/originKeys", new List<string> {"originDomains"})
        {
        }
    }
}
