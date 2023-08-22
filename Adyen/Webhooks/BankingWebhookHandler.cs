using System;
using Adyen.Model.ReportNotification;
using Adyen.Model.ConfigurationNotification;
using Adyen.Model.TransferNotification;
using Newtonsoft.Json;

namespace Adyen.Webhooks
{
    public class BankingWebhookHandler
    {
        private string _jsonRequest;

        private object Deserialize<T>()
        {
            return JsonConvert.DeserializeObject<T>(_jsonRequest);
        }

        public dynamic HandleBankingWebhooks(string jsonWebhook)
        {
            _jsonRequest = jsonWebhook;
            var response = new object();
            var match = 0;
            
            // Configuration
            try { response = Deserialize<AccountHolderNotificationRequest>(); match++; } catch (JsonSerializationException) {}
            try { response = Deserialize<BalanceAccountNotificationRequest>(); match++;} catch (JsonSerializationException) {}
            try { response = Deserialize<CardOrderNotificationRequest>(); match++;} catch (JsonSerializationException) {}
            try { response = Deserialize<PaymentNotificationRequest>(); match++;} catch (JsonSerializationException) {}
            try { response = Deserialize<SweepConfigurationNotificationRequest>(); match++;} catch (JsonSerializationException) {}
            // Report
            try { response = Deserialize<ReportNotificationRequest>(); match++;} catch (JsonSerializationException) {}
            // Transfer
            try { response = Deserialize<TransferNotificationRequest>(); match++;} catch (JsonSerializationException) {}
            
            if (match != 1)
            {
                throw new JsonSerializationException($"Could not deserialise the webhook: {jsonWebhook}");
            }
            // make dynamic object
            dynamic data = response;
            return data;
        }
        public PaymentNotificationRequest GetPaymentNotificationRequest(string jsonRequest)
        {
            return (PaymentNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public AccountHolderNotificationRequest GetAccountHolderNotificationRequest(string jsonRequest)
        {
            return (AccountHolderNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public BalanceAccountNotificationRequest GetBalanceAccountNotificationRequest(string jsonRequest)
        {
            return (BalanceAccountNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public CardOrderNotificationRequest GetCardOrderNotificationRequest(string jsonRequest)
        {
            return (CardOrderNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public PaymentNotificationRequest GetConfigurationPaymentNotificationRequest(string jsonRequest)
        {
            return (PaymentNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public SweepConfigurationNotificationRequest GetSweepConfigurationNotificationRequest(string jsonRequest)
        {
            return (SweepConfigurationNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public ReportNotificationRequest GetReportNotificationRequest(string jsonRequest)
        {
            return (ReportNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
        
        public TransferNotificationRequest GetTransferNotificationRequest(string jsonRequest)
        {
            return (TransferNotificationRequest)HandleBankingWebhooks(jsonRequest);
        }
    }
}