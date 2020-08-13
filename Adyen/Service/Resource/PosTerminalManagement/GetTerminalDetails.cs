using Adyen.Constants;
using System.Collections.Generic;

namespace Adyen.Service.Resource.PosTerminalManagement
{
    public class GetTerminalDetails : ServiceResource
    {
        public GetTerminalDetails(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.PosTerminalManagementEndpoint + "/" + ClientConfig.PosTerminalManagementVersion + "/getTerminalDetails", new List<string> { "terminal" })
        {
        }

    }
}