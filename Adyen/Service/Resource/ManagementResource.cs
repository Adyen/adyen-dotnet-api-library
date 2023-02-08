#region License
// /*
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2023 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Constants;

namespace Adyen.Service.Resource
{
    public class ManagementResource : ServiceResource
    {
        public ManagementResource(AbstractService abstractService, string endpoint)
            : base(abstractService, abstractService.Client.Config.ManagementEndpoint + "/" + ClientConfig.ManagementVersion + endpoint,null)
        {
        }
    }
}