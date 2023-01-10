using Adyen.Constants;

namespace Adyen.Service.Resource
{
    public class BalancePlatformResource : ServiceResource
    {
        public BalancePlatformResource(AbstractService abstractService, string endpoint)
            : base(abstractService, abstractService.Client.Config.BalancePlatformEndpoint + "/" + ClientConfig.BalancePlatformVersion + endpoint,null)
        {
        }
    }
}