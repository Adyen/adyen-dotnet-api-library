using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class Authorise : ServiceResource
    {
        public Authorise(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion + "/authorise",
                new List<string>
                {
                    "merchantAccount",
                    "amount.value",
                    "amount.currency",
                    "reference",
                    "threeDS2RequestData.deviceChannel",
                    "threeDS2RequestData.notificationURL"
                })
        {
        }
    }
}
