using Adyen.Constants;

namespace Adyen.Service.Resource.Payout
{
    public class SubmitThirdParty : Resource
    {
        public SubmitThirdParty(AbstractService abstractService)
     : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion + "/submitThirdParty", null)
        {
        }
    }
}
