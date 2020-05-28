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
   public class FindTerminal : ServiceResource
    {
        public FindTerminal(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.PosTerminalManagementEndpoint + "/" + ClientConfig.PosTerminalManagementVersion + "/findTerminal", new List<string> { "terminal" })
        {
        }
    }
}
