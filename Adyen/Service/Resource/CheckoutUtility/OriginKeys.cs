using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Service.Resource.CheckoutUtility
{
    public class OriginKeys : ServiceResource
    {
        public OriginKeys(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutUtilityApiVersion + "/originKeys", new List<string> { "originDomains" })
        {
        }
    }
}
