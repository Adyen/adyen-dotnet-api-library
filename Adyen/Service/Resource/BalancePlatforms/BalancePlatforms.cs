using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Service.Resource.BalancePlatforms
{
    public class BalancePlatforms : ServiceRestResource
    {
        public BalancePlatforms(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + ClientConfig.BalancePlatformEndpointTest + ClientConfig.BalancePlatformApiVersion + "/balancePlatforms")

        {
        }
    }
}
