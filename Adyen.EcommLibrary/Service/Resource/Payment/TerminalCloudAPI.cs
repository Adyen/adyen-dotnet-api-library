namespace Adyen.EcommLibrary.Service.Resource.Payment
{
    public class TerminalCloudApi : ServiceResource
    {
<<<<<<< HEAD
        public TerminalCloudApi(AbstractService abstractService, bool asynchronous)
=======
        public TerminalCloudApi(AbstractService abstractService,bool asynchronous)
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
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
