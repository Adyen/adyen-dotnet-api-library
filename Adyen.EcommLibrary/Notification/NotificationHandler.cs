using Adyen.EcommLibrary.Model.Notification;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Notification
{
    public class NotificationHandler
    {
        public NotificationRequest HandleNotificationRequest(string jsonRequest)
        {
            return JsonOperation.Deserialize<NotificationRequest>(jsonRequest);
        }
    }
}
