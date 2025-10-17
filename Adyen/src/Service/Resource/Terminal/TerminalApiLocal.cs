using System;

namespace Adyen.Service.Resource.Terminal
{
    [Obsolete("Use TerminalApiLocalClient instead.")]
    public class TerminalApiLocal: ServiceResource
    {
        [Obsolete("Use TerminalApiLocalClient instead.")]
        public TerminalApiLocal(AbstractService abstractService) 
            : base(abstractService, abstractService.AdyenClient.Config.LocalTerminalApiEndpoint)
        {
        }
    }
}