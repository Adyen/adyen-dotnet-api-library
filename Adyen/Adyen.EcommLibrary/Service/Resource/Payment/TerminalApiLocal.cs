using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class TerminalApiLocal: ServiceResource
    {
        public TerminalApiLocal(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.Endpoint, null)
        {
        }
    }
}
