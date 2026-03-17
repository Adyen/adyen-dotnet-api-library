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

using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Webhooks.Models
{
    public class NotificationRequest
    {
        [JsonPropertyName("live")]
        public string Live { get; set; }

        [JsonPropertyName("notificationItems")]
        public List<NotificationRequestItemContainer> NotificationItemContainers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRequest {\n");
            sb.Append("  Live: ").Append(this.Live).Append("\n");
            sb.Append("  NotificationItemContainers: ").Append(NotificationItemContainers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
