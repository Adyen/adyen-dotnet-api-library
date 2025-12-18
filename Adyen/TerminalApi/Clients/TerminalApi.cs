using System;

namespace Adyen.Service.Resource.Terminal
{
    [Obsolete("Use TerminalApiSyncClient or TerminalApiAsyncClient instead.")]
    public class TerminalApi : ServiceResource
    {
        [Obsolete("Use TerminalApiSyncClient or TerminalApiAsyncClient instead.")]
        public TerminalApi(AbstractService abstractService, bool asynchronous)
            : base(abstractService, null)
        {
            if (asynchronous) {
                Endpoint = abstractService.Client.GetCloudApiEndpoint()+ "/async";
            } else {
                Endpoint = abstractService.Client.GetCloudApiEndpoint() + "/sync";
            }
        }
    }
}