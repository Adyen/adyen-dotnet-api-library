using Adyen.Constants;

namespace Adyen.Service.Resource.Hop
{
    public class GetOnboardingUrl : ServiceResource
    {
        public GetOnboardingUrl(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.MarketPayEndpoint + "/Hop/" + ClientConfig.HopApiVersion +
                "/getOnboardingUrl")
        {
        }
    }
}
