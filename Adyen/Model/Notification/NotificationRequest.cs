using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Model.Notification
{
    public class NotificationRequest
    {
        public string Live { get; set; }

        [JsonProperty("NotificationItems")]
        public List<NotificationRequestItemContainer> NotificationItemContainers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRequest {\n");
            sb.Append("  Live: ").Append(this.Live).Append("\n");
            sb.Append("  NotificationItemContainers: ").Append(this.NotificationItemContainers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
