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

using Newtonsoft.Json;
using System.Text;

namespace Adyen.Model.Notification
{
    public interface IBalancePlatformWebhook
    {
        string Type { get; set; }
    }

    public class BalancePlatformWebhook : IBalancePlatformWebhook
    {
        public BalancePlatformWebhook()
        {
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanacePlatformWebhookRequest {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n").Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}
