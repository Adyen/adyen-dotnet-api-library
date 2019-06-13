using System.Collections.Generic;

namespace Adyen.Service.Resource.Recurring
{
    public class ListRecurringDetails:Resource
    {
        public ListRecurringDetails(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Recurring/" + abstractService.Client.ApiVersion + "/listRecurringDetails",
                new List<string>
                {
                    "merchantAccount",
                    "recurring.contract",
                    "shopperReference"
                })
        {

        }
    }
}
