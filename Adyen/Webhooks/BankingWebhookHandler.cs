using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Adyen.Model.ReportNotification;
using Adyen.Model.ConfigurationNotification;
using Adyen.Model.TransferNotification;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adyen.Webhooks
{
    public class BankingWebhookHandler
    {
        private readonly string _jsonRequest;
        public BankingWebhookHandler(string webhook)
        {
            _jsonRequest = webhook;
        }

        private object Deserialize<T>()
        {
            return JsonConvert.DeserializeObject<T>(_jsonRequest);
        }

        public dynamic HandleBankingWebhooks()
        {
            // Retrieve the webhook type
            var type = (string)JObject.Parse(_jsonRequest).GetValue("type") 
                       ?? throw new NullReferenceException("Webhook type is not populated");

            // Configuration webhooks
            if (ContainsValue<AccountHolderNotificationRequest.TypeEnum>(type))
            {
                return Deserialize<AccountHolderNotificationRequest>();
            }
            if (ContainsValue<BalanceAccountNotificationRequest.TypeEnum>(type))
            {
                return Deserialize<BalanceAccountNotificationRequest>();
            }
            if (ContainsValue<CardOrderNotificationRequest.TypeEnum>(type)) 
            {
                return Deserialize<CardOrderNotificationRequest>();
            }
            if (ContainsValue<PaymentNotificationRequest.TypeEnum>(type)) 
            {
                return Deserialize<PaymentNotificationRequest>();
            }
            if (ContainsValue<SweepConfigurationNotificationRequest.TypeEnum>(type)) 
            {
                return Deserialize<SweepConfigurationNotificationRequest>();
            }
            // Report Webhooks
            if (ContainsValue<ReportNotificationRequest.TypeEnum>(type)) 
            {
                return Deserialize<ReportNotificationRequest>();
            }
            // Transfer Webhooks
            if (ContainsValue<TransferNotificationRequest.TypeEnum>(type)) 
            {
                return Deserialize<TransferNotificationRequest>();
            }

            throw new JsonSerializationException("Could not parse the banking webhook");
        }
        
        // Check if the enum contains a Enum Member Value
        private static bool ContainsValue<T>(string value) where T : struct, IConvertible
        {
            List<string> list = new List<string>();
            var members = typeof(T)
                .GetTypeInfo()
                .DeclaredMembers;
            foreach (var member in members)
            {
                var val = member?.GetCustomAttribute<EnumMemberAttribute>(false)?.Value;
                if (!string.IsNullOrEmpty(val))
                    list.Add(val);
            }

            return list.Contains(value);
        }
        
        public PaymentNotificationRequest GetPaymentNotificationRequest()
        {
            return (PaymentNotificationRequest)HandleBankingWebhooks();
        }
        
        public AccountHolderNotificationRequest GetAccountHolderNotificationRequest()
        {
            return (AccountHolderNotificationRequest)HandleBankingWebhooks();
        }
        
        public BalanceAccountNotificationRequest GetBalanceAccountNotificationRequest()
        {
            return (BalanceAccountNotificationRequest)HandleBankingWebhooks();
        }
        
        public CardOrderNotificationRequest GetCardOrderNotificationRequest()
        {
            return (CardOrderNotificationRequest)HandleBankingWebhooks();
        }
        
        public PaymentNotificationRequest GetConfigurationPaymentNotificationRequest()
        {
            return (PaymentNotificationRequest)HandleBankingWebhooks();
        }
        
        public SweepConfigurationNotificationRequest GetSweepConfigurationNotificationRequest()
        {
            return (SweepConfigurationNotificationRequest)HandleBankingWebhooks();
        }
        
        public ReportNotificationRequest GetReportNotificationRequest()
        {
            return (ReportNotificationRequest)HandleBankingWebhooks();
        }
        
        public TransferNotificationRequest GetTransferNotificationRequest()
        {
            return (TransferNotificationRequest)HandleBankingWebhooks();
        }
    }
}