namespace Adyen.Service.Resource.Terminal
{
    public class TerminalApiLocal: ServiceResource
    {
        public TerminalApiLocal(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.LocalTerminalApiEndpoint)
        {
        }
    }
}
