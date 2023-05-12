using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class DeleteBankAccount : Resource
    {
        public DeleteBankAccount(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/deleteBankAccounts")
        {
        }
    }
}
