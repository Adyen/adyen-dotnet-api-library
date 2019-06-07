using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Reccuring
{
    public class ListReccuringDetails:Resource
    {
        public ListReccuringDetails(AbstractService abstractService)
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
