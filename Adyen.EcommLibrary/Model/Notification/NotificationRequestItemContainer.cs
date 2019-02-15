using System;
using System.Text;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model.Notification
{
    public class NotificationRequestItemContainer
    {
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