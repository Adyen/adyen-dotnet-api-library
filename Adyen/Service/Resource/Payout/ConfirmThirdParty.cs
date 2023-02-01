using Adyen.Constants;

namespace Adyen.Service.Resource.Payout
{
    public class ConfirmThirdParty : Resource
    {
        public ConfirmThirdParty(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion + "/confirmThirdParty")
        {
        }
    }
}
