using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class UpdateAccount : Resource
    {
        public UpdateAccount(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/updateAccount")
        {
        }
    }
}
