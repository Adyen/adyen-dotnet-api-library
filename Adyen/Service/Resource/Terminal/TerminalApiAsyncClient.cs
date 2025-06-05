namespace Adyen.Service.Resource.Terminal
{
    /// <summary>
    /// Service that sends terminal-api requests to the cloud terminal-api `/async` endpoint.
    /// </summary>
    public class TerminalApiAsyncClient : ServiceResource
    {
        /// <summary>
        /// Instantiate a <see cref="TerminalApiAsyncClient"/> to send requests to the cloud terminal-api `/async` endpoint.
        /// </summary>
        /// <param name="abstractService"><see cref="AbstractService"/>.</param>
        public TerminalApiAsyncClient(AbstractService abstractService) 
            : base(abstractService, abstractService.AdyenClient.GetCloudApiEndpoint() + "/async")
        {
        }
    }
}
