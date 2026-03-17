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

using System.Text;
using System.Text.Json.Serialization;

namespace Adyen.Webhooks.Models
{
    public class NotificationRequestItemContainer
    {
        [JsonPropertyName("NotificationRequestItem")]
        public NotificationRequestItem NotificationItem { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationRequestItemContainer {\n");
            sb.Append("  notificationItem: ").Append(NotificationItem).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}