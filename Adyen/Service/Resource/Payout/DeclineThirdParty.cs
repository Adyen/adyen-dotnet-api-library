using Adyen.Constants;

namespace Adyen.Service.Resource.Payout
{
    public class DeclineThirdParty : Resource
    {
        public DeclineThirdParty(AbstractService abstractService)
           : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion + "/declineThirdParty")
        {
        }
    }
}
