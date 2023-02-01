using Adyen.Constants;
using System.Collections.Generic;

namespace Adyen.Service.Resource.PosTerminalManagement
{
    public class GetStoresUnderAccount : ServiceResource
    {
        public GetStoresUnderAccount(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.PosTerminalManagementEndpoint + "/" +
                ClientConfig.PosTerminalManagementVersion + "/getStoresUnderAccount",
                new List<string> {"companyAccount"})
        {
        }
    }
}