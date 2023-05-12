using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class SuspendAccountHolder : Resource
    {
        public SuspendAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/suspendAccountHolder")
        {
        }
    }
}
