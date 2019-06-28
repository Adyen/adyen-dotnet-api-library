using Adyen.Model.Notification;
using Adyen.Util;

namespace Adyen.Notification
{
    public class NotificationHandler
    {
        public NotificationRequest HandleNotificationRequest(string jsonRequest)
        {
            return JsonOperation.Deserialize<NotificationRequest>(jsonRequest);
        }
    }
}
