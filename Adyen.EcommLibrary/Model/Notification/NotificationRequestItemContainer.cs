using System;
using System.Text;

namespace Adyen.EcommLibrary.Model.Notification
{
    public class NotificationRequestItemContainer
    {
        public NotificationRequestItem NotificationItem { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationRequestItemContainer {\n");

            sb.Append("  notificationItem: ").Append(ToIndentedString(NotificationItem)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }


        private string ToIndentedString(Object o)
        {
            if (o == null)
            {
                return "null";
            }
            return o.ToString().Replace("\n", "\n    ");
        }

    }
}