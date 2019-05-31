using System.Collections.Generic;

namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class Authorise3DS2 : ServiceResource
    {
        public Authorise3DS2(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.Endpoint + "/pal/servlet/Payment/" + abstractService.Client.ApiVersion +
                "/authorise3ds2",
                new List<string>
                {
                    "merchantAccount",
                    "amount.value",
                    "amount.currency",
                    "reference"
                })
        {
        }
    }
}