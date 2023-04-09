using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class CloseAccount : Resource
    {
        public CloseAccount(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/closeAccount")
        {
        }
    }
}
