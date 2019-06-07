namespace Adyen.Service.Resource.Payment
{
    public class TerminalApi : ServiceResource
    {
        public TerminalApi(AbstractService abstractService, bool asynchronous)
            : base(abstractService, abstractService.Client.Config.Endpoint, null)
        {
            if (asynchronous) {
                Endpoint = abstractService.Client.Config.CloudApiEndPoint+ "/async";
            } else {
                Endpoint = abstractService.Client.Config.CloudApiEndPoint + "/sync";
            }
        }
    }
}
