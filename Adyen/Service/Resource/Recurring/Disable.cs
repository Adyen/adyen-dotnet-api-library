﻿using System.Collections.Generic;

namespace Adyen.Service.Resource.Recurring
{
    public class Disable:Resource
    {
        public Disable(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Recurring/" + abstractService.Client.ApiVersion + "/disable",
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
