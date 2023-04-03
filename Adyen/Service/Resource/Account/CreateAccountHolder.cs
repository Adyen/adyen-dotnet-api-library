using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class CreateAccountHolder : Resource
    {
        public CreateAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/createAccountHolder")
        {
        }
    }
}
