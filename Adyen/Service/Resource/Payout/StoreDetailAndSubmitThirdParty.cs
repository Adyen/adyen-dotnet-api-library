using Adyen.Constants;

namespace Adyen.Service.Resource.Payout
{
    public class StoreDetailAndSubmitThirdParty : Resource
    {
        public StoreDetailAndSubmitThirdParty(AbstractService abstractService)
       : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion + "/storeDetailAndSubmitThirdParty", null)
        {
        }
    }
}
