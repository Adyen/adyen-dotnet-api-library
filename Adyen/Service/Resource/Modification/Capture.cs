using System.Collections.Generic;

namespace Adyen.Service.Resource.Modification
{
    public class Capture : ServiceResource
    {
        public Capture(AbstractService abstractService) : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion + "/capture",
            new List<string>
            {
                "merchantAccount",
                "originalReference"
            })
        {
        }
    }
}
