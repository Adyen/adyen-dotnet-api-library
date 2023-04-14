﻿using Adyen.Model.MarketPay.Notification;
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

        public IWebhookNotification HandleMarketpayNotificationJson(string jsonRequest)
        {
            return JsonOperation.Deserialize<IWebhookNotification>(jsonRequest);
        }
    }
}
