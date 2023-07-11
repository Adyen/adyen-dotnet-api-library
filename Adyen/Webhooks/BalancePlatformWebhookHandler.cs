using System;
using Adyen.Model.ReportNotification;
using Adyen.Model.ConfigurationNotification;
using Adyen.Model.TransferNotification;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adyen.Webhooks
{
    public class BalancePlatformWebhookHandler
    {
        public BalancePlatformWebhookHandler()
        {
        }

        /// <summary>
        /// Deserializes <see cref="AccountHolderNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="AccountHolderNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetAccountHolderNotificationRequest(string jsonPayload, out AccountHolderNotificationRequest result)
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            switch (type)
            {
                case "balancePlatform.accountHolder.updated":
                case "balancePlatform.accountHolder.created":
                    result = JsonConvert.DeserializeObject<AccountHolderNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }
        
        /// <summary>
        /// Deserializes <see cref="BalanceAccountNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="BalanceAccountNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetBalanceAccountNotificationRequest(string jsonPayload, out BalanceAccountNotificationRequest result)
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            switch (type)
            {
                case "balancePlatform.balanceAccount.updated":
                case "balancePlatform.balanceAccount.created":
                    result = JsonConvert.DeserializeObject<BalanceAccountNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Deserializes <see cref="CardOrderNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="CardOrderNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetCardOrderNotificationRequest(string jsonPayload, out CardOrderNotificationRequest result)
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();

            switch (type)
            {
                case "balancePlatform.cardorder.updated":
                case "balancePlatform.cardorder.created":
                    result = JsonConvert.DeserializeObject<CardOrderNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Deserializes <see cref="PaymentNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="PaymentNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetPaymentNotificationRequest(string jsonPayload, out PaymentNotificationRequest result) // This class-name is confusing as it's referring to a paymentInstrument -> Rename to PaymentInstrumentNotificationRequest?
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            switch (type)
            {
                case "balancePlatform.paymentInstrument.updated":
                case "balancePlatform.paymentInstrument.created":
                    result = JsonConvert.DeserializeObject<PaymentNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }
        
        /// <summary>
        /// Deserializes <see cref="SweepConfigurationNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="SweepConfigurationNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetSweepConfigurationNotificationRequest(string jsonPayload, out SweepConfigurationNotificationRequest result)
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            switch (type)
            {
                case "balancePlatform.balanceAccountSweep.updated":
                case "balancePlatform.balanceAccountSweep.created":
                case "balancePlatform.balanceAccountSweep.deleted":
                    result = JsonConvert.DeserializeObject<SweepConfigurationNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }
        
        /// <summary>
        /// Deserializes <see cref="ReportNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>>
        /// <param name="result"><see cref="ReportNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetReportNotificationRequest(string jsonPayload, out ReportNotificationRequest result)
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            switch (type)
            {
                case "balancePlatform.report.created":
                    result = JsonConvert.DeserializeObject<ReportNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }
        
        /// <summary>
        /// Deserializes <see cref="TransferNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="TransferNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when type is not specified.</exception>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetTransferNotificationRequest(string jsonPayload, out TransferNotificationRequest result)
        {
            result = null;
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            switch (type)
            {
                case "balancePlatform.transfer.updated":
                case "balancePlatform.transfer.created":
                    result = JsonConvert.DeserializeObject<TransferNotificationRequest>(jsonPayload);
                    return true;
                default:
                    return false;
            }
        }
    }
}