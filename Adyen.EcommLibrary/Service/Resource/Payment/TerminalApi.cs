namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class TerminalApi : ServiceResource
    {
        public TerminalApi(ApiKeyAuthenticatedService abstractService, bool asynchronous)
            : base(abstractService, abstractService.Client.Config.CloudApiEndPoint, null)
        {
            if (asynchronous) {
                abstractService.Client.Config.Endpoint = abstractService.Client.Config.CloudApiEndPoint+ "/async";
            } else {
                abstractService.Client.Config.Endpoint = abstractService.Client.Config.CloudApiEndPoint + "/sync";
            }
        }
    }
}
