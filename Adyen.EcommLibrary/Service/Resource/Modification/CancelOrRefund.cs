using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Modification
{
    public class CancelOrRefund : ServiceResource
    {
        public CancelOrRefund(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion +
                "/cancelOrRefund",
                new List<string>
                {
                    "merchantAccount",
                    "originalReference"
                })
        {
        }
    }
}