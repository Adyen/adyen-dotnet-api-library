using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class UpdateAccountHolderState : Resource
    {
        public UpdateAccountHolderState(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/updateAccountHolderState")
        {
        }
    }
}
