#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using Adyen.Constants;
using System.Collections.Generic;

namespace Adyen.Service.Resource.PosTerminalManagement
{
    public class GetTerminalDetails : ServiceResource
    {
        public GetTerminalDetails(AbstractService abstractService)
            : base(abstractService,
                abstractService.Client.Config.PosTerminalManagementEndpoint + "/" +
                ClientConfig.PosTerminalManagementVersion + "/getTerminalDetails", new List<string> {"terminal"})
        {
        }
    }
}