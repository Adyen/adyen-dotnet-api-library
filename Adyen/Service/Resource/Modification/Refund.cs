using System.Collections.Generic;

namespace Adyen.Service.Resource.Modification
{
    public class Refund : ServiceResource
    {
        public Refund(AbstractService abstractService) : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion + "/refund",
            new List<string>
            {
                "merchantAccount",
                "modificationAmount",
                "modificationAmount.value",
                "modificationAmount.currency",
                "originalReference"
            })
        {
        }
    }
}
