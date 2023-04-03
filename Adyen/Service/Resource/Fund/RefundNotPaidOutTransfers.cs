using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class RefundNotPaidOutTransfers : Resource
    {
        public RefundNotPaidOutTransfers(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/refundNotPaidOutTransfers")
        {
        }
    }
}
