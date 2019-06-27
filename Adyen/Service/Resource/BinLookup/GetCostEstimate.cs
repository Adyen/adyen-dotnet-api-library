using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.BinLookup
{
    public class GetCostEstimate : ServiceResource
    {
        public GetCostEstimate(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + "/" + ClientConfig.BinLookupPalSuffix + ClientConfig.BinLookupApiVersion + "/getCostEstimate", new List<string> { "merchantAccount", "amount" })
        {
        }
    }
}
