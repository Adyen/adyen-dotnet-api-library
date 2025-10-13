using Adyen.Model.Notification;
using Adyen.Util;

namespace Adyen.Webhooks
{
    public class WebhookHandler
    {
        public NotificationRequest HandleNotificationRequest(string jsonRequest)
        {
            return JsonOperation.Deserialize<NotificationRequest>(jsonRequest);
        }
    }
}
