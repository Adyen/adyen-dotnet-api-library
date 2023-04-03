using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class UpdateAccountHolder : Resource
    {
        public UpdateAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/updateAccountHolder")
        {
        }
    }
}
