using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class CheckAccountHolder : Resource
    {
        public CheckAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/checkAccountHolder")
        {
        }
    }
}
