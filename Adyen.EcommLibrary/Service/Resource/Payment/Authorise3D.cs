using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class Authorise3D : ServiceResource
    {
        public Authorise3D(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion + "/authorise3d",
                new List<string>
                {
                    "merchantAccount",
                    "browserInfo",
                    "md",
                    "paResponse"
                })
        {
        }
    }
}
