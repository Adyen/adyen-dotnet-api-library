namespace Adyen.Service.Resource.Terminal
{
    /// <summary>
    /// Service that sends terminal-api requests to your specified endpoint in <see cref="Config.LocalTerminalApiEndpoint"/>.
    /// </summary>
    public class TerminalApiLocalClient : ServiceResource
    {
        /// <summary>
        /// Instantiate a <see cref="TerminalApiLocalClient"/> to send requests to your specified endpoint in <see cref="Config.LocalTerminalApiEndpoint"/>.
        /// </summary>
        /// <param name="abstractService"><see cref="AbstractService"/>.</param>
        public TerminalApiLocalClient(AbstractService abstractService) 
            : base(abstractService, abstractService.Client.Config.LocalTerminalApiEndpoint)
        {
        }
    }
}
