namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class TerminalCloudApi : ServiceResource
    {
        public TerminalCloudApi(AbstractService abstractService,bool asynchronous)
            : base(abstractService, abstractService.Client.Config.TerminalCloudEndPoint, null)
        {
            if (asynchronous) {
                abstractService.Client.Config.Endpoint = abstractService.Client.Config.TerminalCloudEndPoint+ "/async";
            } else {
                abstractService.Client.Config.Endpoint = abstractService.Client.Config.TerminalCloudEndPoint + "/sync";
            }
        }
    }
}
