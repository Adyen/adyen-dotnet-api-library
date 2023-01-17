#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using System.Collections.Generic;

namespace Adyen.Service.Resource.Recurring
{
    public class NotifyShopper : Resource
    {
        /// <summary>
        /// To send a pre-debit notification to your shopper, make a POST call to notifyShopper
        /// </summary>
        /// <param name="abstractService"></param>
        public NotifyShopper(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Recurring/" + abstractService.Client.RecurringApiVersion + "/notifyShopper",
                new List<string>
                {
                    "merchqantAccount",
                    "shopperReference",
                    "amount",
                    "reference"
                })
        {

        }
    }
}
