#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Util;
using System.Text;

namespace Adyen.Model.Notification
{
    using Newtonsoft.Json;

    public class NotificationRequestItemContainer
    {
        [JsonProperty("NotificationRequestItem")]
        public NotificationRequestItem NotificationItem { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationRequestItemContainer {\n");

            sb.Append("  notificationItem: ").Append(NotificationItem.ToIndentedString()).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}