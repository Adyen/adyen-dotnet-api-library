using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class AccountHolderBalance : Resource
    {
        public AccountHolderBalance(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/accountHolderBalance")
        {
        }
    }
}
