using Adyen.Constants;

namespace Adyen.Service.Resource.Account 
{
    public class CreateAccount : Resource
    {
        public CreateAccount(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/createAccount")
        {
        }
    }
}
