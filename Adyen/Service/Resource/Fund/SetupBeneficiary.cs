using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
   public class SetupBeneficiary : Resource
    {
        public SetupBeneficiary(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/setupBeneficiary")
        {
        }
    }
}
