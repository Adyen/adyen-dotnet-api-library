using Adyen.Constants;

namespace Adyen.Service.Resource.Payout
{
    public class PayoutService : Resource
    {
        public PayoutService(AbstractService abstractService)
         : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion + "/payout", null)
        {
        }
    }
}
