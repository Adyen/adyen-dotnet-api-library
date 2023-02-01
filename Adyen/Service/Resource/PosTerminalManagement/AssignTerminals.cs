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
    public class AssignTerminals : ServiceResource
    {
        public AssignTerminals(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.PosTerminalManagementEndpoint + "/" + ClientConfig.PosTerminalManagementVersion + "/assignTerminals", new List<string> { "companyAccount", "terminals" })
        {
        }
    }
}