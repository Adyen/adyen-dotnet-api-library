using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class PayoutAccountHolder : Resource
    {
        public PayoutAccountHolder(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/payoutAccountHolder")
        {
        }
    }
}

