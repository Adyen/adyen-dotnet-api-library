using Adyen.Constants;

namespace Adyen.Service.Resource.Payout
{
    public class StoreDetail : Resource
    {
        public StoreDetail(AbstractService abstractService)
         : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion + "/storeDetail", null)
        {
        }
    }
}
