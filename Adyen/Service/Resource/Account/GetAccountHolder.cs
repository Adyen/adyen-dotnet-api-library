using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class GetAccountHolder : Resource
    {
        public GetAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion +"/getAccountHolder")
        {
        }
    }
}
