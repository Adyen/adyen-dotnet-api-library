using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.BinLookup
{
    public class Get3dsAvailability : ServiceResource
    {
        public Get3dsAvailability(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/"+ ClientConfig.BinLookupPalSuffix + ClientConfig.BinLookupApiVersion + "/get3dsAvailability", new List<string> { "merchantAccount", "amount" })
        {
        }
    }
}
