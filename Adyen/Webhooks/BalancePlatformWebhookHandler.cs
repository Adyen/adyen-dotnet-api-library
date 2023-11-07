using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Adyen.Model.AcsWebhooks;
using Adyen.Model.ReportWebhooks;
using Adyen.Model.ConfigurationWebhooks;
using Adyen.Model.TransactionWebhooks;
using Adyen.Model.TransferWebhooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adyen.Webhooks
{
    public class BalancePlatformWebhookHandler
    {
        /// <summary>
        /// Deserializes to a generic banking webhook from the <paramref name="jsonPayload"/>. Use this either to catch the
        /// webhook type if unknown or if the explicit type is not required.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <returns>The parsed webhook packaged in a dynamic object.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public dynamic GetGenericBalancePlatformWebhook(string jsonPayload)
        {
            if (GetAuthenticationNotificationRequest(jsonPayload, out var authenticationNotificationRequest)) 
            {
                return authenticationNotificationRequest;
            }
            
            if (GetAccountHolderNotificationRequest(jsonPayload, out var accountHolderNotificationRequest)) 
            {
                return accountHolderNotificationRequest;
            }
            
            if (GetBalanceAccountNotificationRequest(jsonPayload, out var balanceAccountNotificationRequest))
            {
                return balanceAccountNotificationRequest;
            }
            
            if (GetCardOrderNotificationRequest(jsonPayload, out var cardOrderNotificationRequest))
            {
                return cardOrderNotificationRequest;
            }
            
            if (GetPaymentNotificationRequest(jsonPayload, out var paymentNotificationRequest))
            {
                return paymentNotificationRequest;
            }
            
            if (GetSweepConfigurationNotificationRequest(jsonPayload, out var sweepConfigurationNotificationRequest))
            {
                return sweepConfigurationNotificationRequest;
            }
            
            if (GetReportNotificationRequest(jsonPayload, out var reportNotificationRequest))
            {
                return reportNotificationRequest;
            }
            if (GetTransferNotificationRequest(jsonPayload, out var transferNotificationRequest))
            {
                return transferNotificationRequest;
            }
            if (GetTransactionNotificationRequestV4(jsonPayload, out var transactionNotificationRequestV4))
            {
                return transactionNotificationRequestV4;
            }
            throw new JsonReaderException("Could not parse webhook");
        }
        /// <summary>
        /// Deserializes <see cref="AuthenticationNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="AuthenticationNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetAuthenticationNotificationRequest(string jsonPayload, out AuthenticationNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<AuthenticationNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<AuthenticationNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="AccountHolderNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="AccountHolderNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetAccountHolderNotificationRequest(string jsonPayload, out AccountHolderNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<AccountHolderNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<AccountHolderNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="BalanceAccountNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="BalanceAccountNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetBalanceAccountNotificationRequest(string jsonPayload, out BalanceAccountNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<BalanceAccountNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<BalanceAccountNotificationRequest>(jsonPayload);
            return true;
        }

        /// <summary>
        /// Deserializes <see cref="CardOrderNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="CardOrderNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetCardOrderNotificationRequest(string jsonPayload, out CardOrderNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<CardOrderNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<CardOrderNotificationRequest>(jsonPayload);
            return true;
        }

        /// <summary>
        /// Deserializes <see cref="PaymentNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="PaymentNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetPaymentNotificationRequest(string jsonPayload, out PaymentNotificationRequest result) // This class-name is confusing as it's referring to a paymentInstrument -> Rename to PaymentInstrumentNotificationRequest?
        {
            result = null;
            if (!ContainsValue<PaymentNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<PaymentNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="SweepConfigurationNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="SweepConfigurationNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetSweepConfigurationNotificationRequest(string jsonPayload, out SweepConfigurationNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<SweepConfigurationNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<SweepConfigurationNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="ReportNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>>
        /// <param name="result"><see cref="ReportNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetReportNotificationRequest(string jsonPayload, out ReportNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<ReportNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<ReportNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="TransferNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="TransferNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetTransferNotificationRequest(string jsonPayload, out TransferNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<TransferNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<TransferNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="TransactionNotificationRequestV4"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="TransactionNotificationRequestV4"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetTransactionNotificationRequestV4(string jsonPayload, out TransactionNotificationRequestV4 result)
        {
            result = null;
            if (!ContainsValue<TransactionNotificationRequestV4.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<TransactionNotificationRequestV4>(jsonPayload);
            return true;
        }
        
        // Check if the <T> contains TypeEnum value
        private static bool ContainsValue<T>(string jsonPayload) where T : struct, IConvertible
        {
            // Retrieve type from payload
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            // Search for type in <T>.TypeEnum
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

            return list.Contains(type);
        }
    }
}