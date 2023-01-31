using System.Collections.Generic;

namespace Adyen.Service.Resource
{
    public class RecurringResource : Resource
    {
        public RecurringResource(AbstractService abstractService, string endpoint)
            : base(abstractService,
                abstractService.Client.Config.Endpoint + "/pal/servlet/Recurring/" +
                abstractService.Client.RecurringApiVersion + endpoint, null)
        {
            
        }
    }
}