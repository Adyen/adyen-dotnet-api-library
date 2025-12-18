namespace Adyen.Service.Resource.Terminal
{
    public class TerminalApiSyncClient : ServiceResource
    {
        /// <summary>
        /// Instantiate a <see cref="TerminalApiSyncClient"/> to send requests to the cloud terminal-api `/sync` endpoint.
        /// </summary>
        /// <param name="abstractService"><see cref="AbstractService"/>.</param>
        public TerminalApiSyncClient(AbstractService abstractService)
            : base(abstractService, abstractService.Client.GetCloudApiEndpoint() + "/sync")
        {
        }
    }
}
