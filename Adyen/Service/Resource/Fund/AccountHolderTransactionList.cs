using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class AccountHolderTransactionList : Resource
    {
        public AccountHolderTransactionList(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/accountHolderTransactionList")
        {
        }
    }
}
