using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Modification
{
    public class Cancel : ServiceResource
    {
        public Cancel(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion + "/cancel",
                new List<string>
                {
                    "merchantAccount",
                    "originalReference"
                })
        {

        }
    }
}
