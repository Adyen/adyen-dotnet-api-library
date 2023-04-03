using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class TransferFunds : Resource
    {
        public TransferFunds(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/transferFunds")
        {
        }
    }
}
