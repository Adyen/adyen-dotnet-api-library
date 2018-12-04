using Adyen.EcommLibrary.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Service.Resource.CheckoutUtility
{
    public class OriginKeys : ServiceResource
    {
        public OriginKeys(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutUtilityApiVersion + "/originkeys", new List<string> { "originDomains" })
        {
        }
    }
}
