using Adyen.EcommLibrary.Util;
using System.Text;

namespace Adyen.EcommLibrary.Model.Notification
{
    using Newtonsoft.Json;

    public class NotificationRequestItemContainer
    {
        [JsonProperty("NotificationRequestItem")]
        public NotificationRequestItem NotificationItem { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRequestItemContainer {\n");

            sb.Append("  notificationItem: ").Append(NotificationItem.ToIndentedString()).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}