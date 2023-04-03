using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class RefundFundsTransfer : Resource
    {
        public RefundFundsTransfer(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/refundFundsTransfer")
        {
        }
    }
}
