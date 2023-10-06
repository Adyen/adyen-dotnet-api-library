namespace Adyen.Service.Resource.Terminal
{
    public class TerminalApi : ServiceResource
    {
        public TerminalApi(AbstractService abstractService, bool asynchronous)
            : base(abstractService, abstractService.Client.Config.Endpoint)
        {
            if (asynchronous) {
                Endpoint = abstractService.Client.GetCloudApiEndpoint()+ "/async";
            } else {
                Endpoint = abstractService.Client.GetCloudApiEndpoint() + "/sync";
            }
        }
    }
}
