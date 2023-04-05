using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class CloseAccountHolder : Resource
    {
        public CloseAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/closeAccountHolder")
        {
        }
    }
}
